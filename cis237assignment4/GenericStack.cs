using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
{
    class GenericStack<T>
    {
        //Add and take from front
        private Node<T> lastNode;
        private Node<T> currentNode;

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
            {//If nodes already exist, set the newNode's next to the current HeadNode
                newNode.Next = HeadNode;
                HeadNode = newNode;
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
            //Start at the beginning
            Node<T> tempNode = HeadNode;
            //Set up our node to return
            Node<T> returnNode = null;

            int i = 0;

            while (tempNode != null)
            {
                if (i == Position - 1)
                {//If we're at the position, set returnNode to the Node we want and exit the loops
                    returnNode = tempNode;
                    break;
                }
                i++;
                tempNode = tempNode.Next;
            }

            return returnNode;
        }
    }
}
