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
    public partial class FrmFPTree : Form
    {
        public string[] frequencyItems_TID;
        private List[] list_frequencyItems_TID;
        public FPTree tree;
        public FrmFPTree()
        {
            InitializeComponent();
        }

        private void FrmFPTree_Load(object sender, EventArgs e)
        {
            tree = new FPTree();
            tree = CreateTree();
            HienThi_FPTree(tree, tree.root);
        }
        private FPTree CreateTree()
        {
            FPTree tree = new FPTree();
            int i = 0;
            tree.root.toaDoX = pictureBoxTree.Width / 2;
            tree.root.toaDoY = 20;
            list_frequencyItems_TID = ChuyenQuaList(frequencyItems_TID);
            for (i = 0; i < frequencyItems_TID.Length; i++)
            {
                List list = new List();
                list = list_frequencyItems_TID[i];
                tree = tree.InsertNode(tree, list);
            }
            return tree;
        }
        private List[] ChuyenQuaList(string[] frequencyItemsTID)
        {
            List[] mangList = new List[frequencyItemsTID.Length];
            int toado_X = 70;
            int toado_Y = 70;
            int i = 0, j = 0;
            for (i = 0; i < frequencyItemsTID.Length; i++)
            {
                string str = frequencyItemsTID[i];
                string[] mangStr = str.Split(new char[] { ',' });
                List list = new List();
                list = list.CreateList();
                Node node = new Node();
                //Tao List cho TID
                for (j = 0; j < mangStr.Length - 1; j++)
                {
                    node = node.CreateNode(mangStr[j].Trim());
                    node.toaDoX = toado_X;
                    node.toaDoY = toado_Y;
                    list = list.InsertTail(list, node);
                    toado_Y = 70 + 50 * (j + 1);
                }
                mangList[i] = list;
                toado_Y = 70;
                toado_X += 50;
            }
            return mangList;
        }

        private void pictureBoxTree_Paint(object sender, PaintEventArgs e)
        {
            VeNhanhCay(tree.root, e);
        }
        public void HienThi_FPTree(FPTree tree, Node root)
        {
            if (tree.root.itemName == root.itemName)
            {
                Tao_Lable(pictureBoxTree.Width / 2, 20, "lbl_Root", "ROOT");
            }
            else
            {
                if (root.toaDoX != 0 && root.toaDoY != 0)
                {
                    Tao_Lable(root.toaDoX, root.toaDoY, "lbl_" + root.itemName, root.itemName + " : " + root.count);
                }
            }

            int dem = 0;
            for (int i = 0; i < root.nodeChildrens.Length; i++)
            {
                if (root.nodeChildrens[i] != null)
                {
                    dem += 1;
                    HienThi_FPTree(tree, root.nodeChildrens[i]);
                }
            }
        }
        private void Tao_Lable(int toado_X, int toado_Y, string name, string text)
        {
            DevExpress.XtraEditors.LabelControl lbl = new DevExpress.XtraEditors.LabelControl();
            lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(248)))));
            lbl.Font = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl.Location = new System.Drawing.Point(toado_X, toado_Y);
            lbl.Name = name;
            lbl.Size = new System.Drawing.Size(40, 23);
            lbl.Text = text;
            pictureBoxTree.Controls.Add(lbl);
        }
        private void VeNhanhCay(Node root, PaintEventArgs e)
        {
            Graphics gr = e.Graphics;
            int i = 0;
            for (i = 0; i < root.nodeChildrens.Length; i++)
            {
                if (root.nodeLink != null)
                {
                    //Vẽ thêm cái này thì rối hình, khi nào yêu cầu sẽ vẽ
                    //gr.DrawLine(Pens.Red, root.toaDoX + 20, root.toaDoY,
                    //    root.nodeLink.toaDoX + 20, root.nodeLink.toaDoY);
                }
                if (root.nodeChildrens[i] != null)
                {
                    gr.DrawLine(Pens.Yellow, root.toaDoX + 20, root.toaDoY, 
                        root.nodeChildrens[i].toaDoX + 20, root.nodeChildrens[i].toaDoY);
                    VeNhanhCay(root.nodeChildrens[i], e);
                }
            }
        }
    }
}
