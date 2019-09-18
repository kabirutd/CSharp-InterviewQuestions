using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree nums = new BinarySearchTree();
            nums.Insert(50);
            nums.Insert(17);
            nums.Insert(23);
            nums.Insert(12);
            nums.Insert(19);
            nums.Insert(54);
            nums.Insert(9);
            nums.Insert(14);
            nums.Insert(67);
            nums.Insert(76);
            nums.Insert(72);
        }

        //public void InsertNode(object data)

        //{

        //    TNode newNode = new TNode(data);



        //    if (root.Data == null) //First node insertion  

        //        root = newNode;

        //    else

        //    {

        //        current = root;

        //        while (true)

        //        {

        //            tempParent = current;

        //            if (Convert.ToInt32(newNode.Data) < Convert.ToInt32(current.Data))

        //            {

        //                current = current.Left;

        //                if (current == null)

        //                {

        //                    tempParent.Left = newNode;

        //                    newNode.Parent = tempParent;

        //                    return;

        //                }

        //            }

        //            else

        //            {

        //                current = current.Right;

        //                if (current == null)

        //                {

        //                    tempParent.Right = newNode;

        //                    newNode.Parent = tempParent;

        //                    return;

        //                }

        //            }

        //        }

        //    }

        //}


        //public object DeleteNode(object data)

        //{

        //    TNode tempDelete = this.GetNode(data);

        //    if (tempDelete != null)

        //    {

        //        if ((tempDelete.Left == null) && (tempDelete.Right == null)) //Its a Leaf node

        //        {

        //            tempParent = tempDelete.Parent;

        //            if (tempDelete == tempParent.Left) //Justremove by making it null

        //                tempParent.Left = null;

        //            else

        //                tempParent.Right = null;

        //        }

        //        else if ((tempDelete.Left == null) || (tempDelete.Right == null)) //It has either Left orRight child

        //        {

        //            tempChild = tempDelete.Left == null ? tempDelete.Right : tempDelete.Left; //Get the child

        //            tempParent = tempDelete.Parent; //Getthe parent

        //            if (tempDelete == tempParent.Left) //Makeparent points to it's child so it will automatically deleted like Linked list

        //                tempParent.Left = tempChild;

        //            else

        //                tempParent.Right = tempChild;

        //        }

        //        else if ((tempDelete.Left != null) || (tempDelete.Right != null)) //It has both Left andRight child

        //        {

        //            TNodepredNode = this.GetNode(this.TreePredecessor_Ite(data));  //Findit's predecessor

        //            if (predNode.Left != null) // Predecessor node canhave no or left child. Do below two steps only if it has left child

        //            {

        //                tempChild = predNode.Left;

        //                predNode.Parent.Right = tempChild; //Assignleft child of predecessor to it's Parent's right.

        //            }

        //            tempDelete.Data = predNode.Data; //Replace the value of predecessor nodeto the value of to be deleted node

        //            //predNode = null; //Remove predecessornode as it's no longer required.

        //        }



        //        return data + " Deleted";

        //    }

        //    else

        //        return "Please enter the valid tree element!";

        //}
    }


    public class BinarySearchTree
    {

        public class Node
        {
            public int Data;
            public Node Left;
            public Node Right;
            public void DisplayNode()
            {
                Console.Write(Data + " ");
            }
        }
        public Node root;
        public BinarySearchTree()
        {
            root = null;
        }
        public void Insert(int i)
        {
            Node newNode = new Node();
            newNode.Data = i;
            if (root == null)
                root = newNode;
            else
            {
                Node current = root;
                Node parent;
                while (true)
                {
                    parent = current;
                    if (i < current.Data)
                    {
                        current = current.Left;
                        if (current == null)
                        {
                            parent.Left = newNode;
                            break;
                        }

                        else
                        {
                            current = current.Right;
                            if (current == null)
                            {
                                parent.Right = newNode;
                                break;
                            }
                        }
                    }
                }
            }
        }
    }
}