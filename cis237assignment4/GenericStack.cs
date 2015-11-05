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
            Node<T> nodeDeletePointer = HeadNode;

            if (Position == 1)
            {
                Node<T> tempNode = HeadNode;
                tempNode.Next = null;
                HeadNode = tempNode;
                return true;
            }

            if (Position > 1)
            {
                Node<T> tempNode = HeadNode;
                Node<T> previousTempNode = null;
                int i = 0;

                while (tempNode != null)
                {
                    if (i == Position - 1)
                    {
                        previousTempNode.Next = tempNode.Next;

                        if (tempNode.Next == null)
                        {
                            lastNode = previousTempNode;
                        }

                        tempNode.Next = null;

                        return true;
                    }

                    i++;

                    previousTempNode = tempNode;

                    tempNode = tempNode.Next;
                }
            }

            return false;
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
