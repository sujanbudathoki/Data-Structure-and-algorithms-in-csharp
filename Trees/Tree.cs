using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structures.Trees
{
    //Main Tree Class
  public   class Tree
    {

        private Node pRoot { get; set; }
        public Tree()
        {
            pRoot = null;
        }

        //Finding a node with key
        public Node Find(int key)
        {
            Node pCurrent = pRoot;
            while(pCurrent.IData == key)
            {
                if(pCurrent.IData>key)
                {
                    pCurrent = pCurrent.LChild;
                }
                else
                {
                    pCurrent = pCurrent.RChild;
                }
                //unable to find a node respect to the key so return null
                if(pCurrent==null)
                {
                    return null;
                }
            }
            //node respects to key is found
            return pCurrent;
        }
        //Inserting node in a tree
        public void Insert(int iData,int dData)
        {
            Node pnewNode = new Node();
            pnewNode.dData = dData;
            pnewNode.IData = iData;
            if(pRoot==null)//if proot is empty ie no node is inerted and given info is for first node
            {
                pRoot = pnewNode;
            }
            else
            {
                Node pCurrent = pRoot;
                Node pParent;
                while(true)
                {
                    pParent = pCurrent;
                    if(iData<pCurrent.IData)
                    {
                        pCurrent = pCurrent.LChild;
                        if(pCurrent==null)
                        {
                            pParent.LChild = pnewNode;
                            return;
                        }
                    }
                    else
                    {
                        pCurrent = pCurrent.RChild;
                        if(pCurrent==null)
                        {
                            pParent.RChild = pnewNode;
                            return;
                        }
                    }
                }
            }
        }

        //In order traversal Left, Print , Right
        public void DisplayTree(Node node)
        {
            if(node!=null)
            {
                DisplayTree(node.LChild);
                Console.WriteLine(node.dData);
                DisplayTree(node.RChild);
            }
        }

        public Node Minimum()
        {
            Node pCurrent = pRoot;
            Node pLast = new Node();
            if(pCurrent!=null)
            {
                pLast = pCurrent;
                pCurrent = pCurrent.LChild;

            }
            return pLast;
        }


    }//End of Tree Class
}
