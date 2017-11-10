using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FP_Growth
{
    public class Node
    {
        // Thuộc tính
        public string itemName;
        public int count;
        public Node[] nodeChildrens = new Node[10];
        public Node nodeChild;
        public Node nodeParent;
        public Node nodeLink;// liên kết các node có item giống nó trên cây
        public int toaDoX;
        public int toaDoY;
        public bool visited;
        // Phương thức
        public Node CreateNode(string name)
        {
            Node node = new Node();
            node.itemName = name;
            node.count = 0;
            node.nodeChildrens = new Node[10];
            node.nodeChild = null;
            node.nodeParent = null;
            node.nodeLink = null;
            node.toaDoX = 0;
            node.toaDoY = 0;
            node.visited = false;
            return node;
        }
    }
    public class List
    {
        // Thuộc tính
        public Node pHead;
        public Node pTail;
        // Phương thức
        public List CreateList()
        {
            List list = new List();
            list.pHead = null;
            list.pTail = null;
            return list;
        }
        public List InsertTail(List list, Node node)
        {
            if(list.pHead == null)
            {
                list.pHead = node;
                list.pTail = list.pHead;
            }
            else
            {
                node.nodeParent = list.pTail;
                list.pTail.nodeChild = node;
                list.pTail = node;
            }
            return list;
        }
    }
    public class FPTree
    {
        // Thuộc tính
        public Node root = new Node();
        public Node[] arrayNode = new Node[99];
        public int countNode;
        // Phương thức
        public FPTree CreateTree()
        {
            FPTree tree = new FPTree();
            tree.root = new Node();
            tree.arrayNode = new Node[99];
            tree.countNode = 0;
            return tree;
        }
        public FPTree InsertNode(FPTree tree, List list)
        {
            int i = 0;
            Node root = new Node();
            root = tree.root;
            Node node = new Node();
            node = list.pHead;
            while(node!=null)
            {
                bool flag = false;
                // tìm rtrong root có itemName nào trùng với node.itemName không? 
                for(i =0;i<root.nodeChildrens.Length;i++)
                {
                    if(root.nodeChildrens[i]!=null)
                        if(root.nodeChildrens[i].itemName == node.itemName)
                        {
                            flag = true;
                            break;
                        }
                }
                // nếu tìm thấy thì tăng cout của itemName đó lên 1
                if(flag==true)
                {
                    root.nodeChildrens[i].count += 1;
                    if(node.nodeChild!=null &&  node.nodeChild.nodeParent!=null)
                    {
                        node.nodeChild.nodeParent = root.nodeChildrens[i];
                    }

                }
                // ngược lại tạo node mới
                else
                {
                    node.nodeParent = root;
                    node.count += 1;
                    tree.countNode += 1;
                    // gán node là con của root
                    for(i=0;i<root.nodeChildrens.Length;i++)
                    {
                        if(root.nodeChildrens[i]==null)
                        {
                            root.nodeChildrens[i] = node;
                            break;
                        }
                    }
                    // thêm node vào arrayNode
                    for(i=0;i<tree.countNode;i++)
                    {
                        if(tree.arrayNode[i]==null)
                        {
                            tree.arrayNode[i] = node;
                            break;
                        }
                    }
                    // link đến node có itemName giống node
                    for(i=tree.countNode-2;i>0;i--)
                    {
                        if(tree.arrayNode[i]!=null)
                        {
                            if(tree.arrayNode[i].itemName == node.itemName)
                            {
                                node.nodeLink = arrayNode[i];
                                break;
                            }
                        }
                    }
                }
                if(node.nodeChild==null)
                {
                    root = node;
                }
                else
                {
                    root = node.nodeChild.nodeParent;
                }
                node = node.nodeChild;
            }
            return tree;
        }
    }
}
