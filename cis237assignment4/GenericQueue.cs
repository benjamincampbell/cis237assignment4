using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
{
    class GenericQueue<T>
    {

        //Add to end, take from front
        private Node<T> lastNode;

        public Node<T> HeadNode
        {
            get { return HeadNode; }
            set { HeadNode = value; }
        }

        public void Add(IComparable droid)
        {
            //The node to be added
            Node<T> newNode = new Node<T>();
            //And the Droid to be added
            newNode.Droid = droid;

            if (HeadNode == null)
            {//If the HeadNode doesn't exist, we'll put it here
                HeadNode = newNode;
                lastNode = newNode;
            }
            else
            {   //Attach the new node onto the next property of the last node
                lastNode.Next = newNode;
                //And set the lastNode to now be the node we just added
                lastNode = newNode;
            }
        }

        public bool Delete(int Position)
        {
            try
            {
                if (Position == 1)
                {   //Deleting the first item
                    HeadNode = HeadNode.Next;
                    return true;
                }
                else
                {   //Deleting any other item, start counter at 2 since it's going to be 2 at minimum anyway
                    int i = 2;
                    Node<T> tempNode = HeadNode;
                    Node<T> deleteNode = tempNode.Next;
                    while (i < Position)
                    {   //If Position = 2, this loop is skipped
                        tempNode = tempNode.Next;
                        deleteNode = deleteNode.Next;
                        i++;
                    }
                    //for example, tempNode = position 1 and deleteNode = position 2, so make 1.Next = position 3, we take 2 out of the set.
                    tempNode.Next = deleteNode.Next;
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public Node<T> Retrieve(int Position)
        {
            int i = 1;
            Node<T> tempNode = HeadNode;

            while (i < Position)
            {
                tempNode = tempNode.Next;
                i++;
            }

            return tempNode;
        }

        public void AddStack(GenericStack<T> stack)
        {
            Node<T> tempNode = stack.HeadNode;

            while (tempNode != null)
            {
                Add(tempNode.Droid);
                tempNode = tempNode.Next;
            }
        }
    }
}
