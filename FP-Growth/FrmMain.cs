using DevExpress.XtraBars.Ribbon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FP_Growth
{
    public partial class FrmMain : Form
    {
        Dictionary<string, int> ItemCount = new Dictionary<string, int>();
        DataTable dataItem = new DataTable();
        DataTable dataFrequency = new DataTable();
        FrmFPTree frmTree;
        public FrmMain()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            dataFrequency.Columns.Add("Items", typeof(string));
            dataFrequency.Columns.Add("Count", typeof(int));
            //
            string[] database = System.IO.File.ReadAllLines(@"..\..\..\data.txt");
            
            dataItem.Columns.Add("TID", typeof(string));
            dataItem.Columns.Add("Items", typeof(string));
            dataItem.Columns.Add("ItemsPhoBien", typeof(string));
            foreach(string item in database)
            {
                dataItem.Rows.Add(item.Split('\t')[0], item.Split('\t')[1]);
            }
            gridControl.DataSource = dataItem;
            // đếm các item
            foreach (DataRow dr in dataItem.Rows)
            {
                string[] items = dr["Items"].ToString().Split(',');
                foreach (string item in items)
                {
                    if (ItemCount.ContainsKey(item.Trim()))
                    {
                        ItemCount[item.Trim()] += 1;
                    }
                    else
                    {
                        ItemCount.Add(item.Trim(), 1);
                    }
                }
            }
            
            
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void txtMincount_EditValueChanged(object sender, EventArgs e)
        {
            int mincount = Convert.ToInt32(txtMincount.Text);
            dataFrequency.Rows.Clear();
            foreach (DataRow dr in dataItem.Rows)
            {
                dr["ItemsPhoBien"] = null;
            }
            if (mincount > 0)
            {

                foreach (var item in ItemCount.OrderBy(key => key.Key).OrderByDescending(value => value.Value))
                {
                    if (item.Value >= mincount)
                    {
                        dataFrequency.Rows.Add(item.Key, item.Value);
                        foreach (DataRow dr in dataItem.Rows)
                        {
                            string[] items = dr["Items"].ToString().Split(',');
                            var results = Array.FindAll(items, s => s.Trim().Equals(item.Key));
                            if (results.Length > 0)
                            {
                                dr["ItemsPhoBien"] += item.Key + ", ";
                            }
                        }
                    }
                }
            }
            gridControlCount.DataSource = dataFrequency;
        }

        private void btnFPTree_Click(object sender, EventArgs e)
        {
            frmTree = new FrmFPTree();
            frmTree.frequencyItems_TID = FrequencyItems_TID();
            frmTree.ShowDialog();
        }
        private string [] FrequencyItems_TID()
        {
            string[] listFrequency = new string[dataItem.Rows.Count];
            int i = 0;
            foreach(DataRow dr in dataItem.Rows)
            {
                listFrequency[i] = dr["ItemsPhoBien"].ToString();
                i++;
            }

            return listFrequency;
        }

        private void btnFPGrowth_Click(object sender, EventArgs e)
        {
            FPTree tree = frmTree.tree;
            // tìm cơ sở mẫu điều kiện, duyệt cây theo biến visited = false, = true đã ghé
            Dictionary<string, string> coSoMauDieuKiem = new Dictionary<string, string>();
            for(int i = dataFrequency.Rows.Count - 1;i>=0;i--)
            {
                string item = dataFrequency.Rows[i]["Items"].ToString();
                if(!coSoMauDieuKiem.ContainsKey(item))
                {
                    coSoMauDieuKiem.Add(item, null);
                }
                for(int j =0; j<tree.countNode;j++)
                {
                    var node = tree.arrayNode[j];
                    if (node.itemName.Equals(item) && !node.visited)
                    {
                        node.visited = true;
                        var nodeparent = node.nodeParent;
                        string coso = "";
                        while(nodeparent.itemName !=null)
                        {
                            coso += nodeparent.itemName+",";
                            nodeparent = nodeparent.nodeParent;
                        }
                        if(!string.IsNullOrEmpty(coso))
                        {
                            coso += ":" + node.count;
                            coSoMauDieuKiem[item] += coso + ";";
                        }
                    }
                }
            }
            DataTable dataResult = new DataTable();
            dataResult.Columns.Add("Items", typeof(string));
            dataResult.Columns.Add("CoSoMau", typeof(string));
            dataResult.Columns.Add("FPTree", typeof(string));
            dataResult.Columns.Add("MauPhoBien", typeof(string));
            foreach(var item in coSoMauDieuKiem)
            {
                Dictionary<string, int> fPTreeDieuKien = new Dictionary<string, int>();
                // đếm các item
                if (item.Value != null)
                {
                    string[] dieukien = item.Value.Split(';');
                    foreach (var items in dieukien)
                    {
                        string[] it = items.Split(':')[0].Split(',');
                        foreach (var t in it)
                        {
                            if (!string.IsNullOrEmpty(t))
                            {
                                if (!fPTreeDieuKien.ContainsKey(t))
                                {
                                    fPTreeDieuKien.Add(t, Convert.ToInt32(items.Split(':')[1]));
                                }
                                else
                                {
                                    fPTreeDieuKien[t] += Convert.ToInt32(items.Split(':')[1]);
                                }
                            }
                        }
                    }
                }
                // loại các item count < mincount
                List<string> keys = new List<string>(fPTreeDieuKien.Keys);
                foreach (var key in keys)
                {
                    if (fPTreeDieuKien[key] < Convert.ToInt32(txtMincount.Text))
                    {
                        fPTreeDieuKien.Remove(key);
                    }
                }
                dataResult.Rows.Add(item.Key, item.Value, 
                    string.Join(",", fPTreeDieuKien.Select(x => x.Key + ":" + x.Value).ToArray()),CacMauPhoBien(item.Key,fPTreeDieuKien));
            }

            gridControlResult.DataSource = dataResult;
        }
        private string CacMauPhoBien(string item, Dictionary<string, int> fPTreeDieuKien)
        {
            List<string> keys = new List<string>(fPTreeDieuKien.Keys);
            int n = keys.Count;
            int[] A = new int[n+1];
            string kq = item + "; ";
            int k = 1;
            for( k =1;k<=n;k++)
            {
                kq += Next(item,keys,A, n, k, true);
            }
            return kq;
        }
        private string Next(string item,List<string> keys,int[] A, int n, int k, bool flag)
        {
            string xuat = null;
            for (int i = 1; i <= n; i++)
                A[i] = i;
            while(flag)
            {
                // xuất ra
                for (int t = 1; t <= k; t++)
                    xuat += keys[A[t] - 1] + ",";
                xuat += item+"; ";
                //
                SinhToHop(A, n, k,ref flag);
            }
            return xuat;
        }
        private void SinhToHop(int[] A,int n,int k,ref bool flag)
        {
            int i = k;
            while (i > 0 && A[i] == n + i - k) i--;
            A[i]++;
            if (i > 0)
            {
                for (int j = i + 1; j <= n; j++)
                    A[j] = A[i] + j - i;
            }
            else flag = false;
        }
    }
}
