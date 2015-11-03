using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
{
    class GenericStack<T>
    {

        public Node<T> HeadNode
        {
            get { return HeadNode; }
            set { HeadNode = value; }
        }

        public void Add(IComparable droid)
        {
            if (HeadNode == null)
            {   //If the head node doesn't exist, we will create it and set its Droid property to the added droid. 
                HeadNode = new Node<T>();
                HeadNode.Droid = droid;
            }
            else
            {
                Node<T> tempNode = HeadNode;
                while (tempNode.Next != null)
                {   //As long as the next Node doesn't exist, we'll keep going through the stack.
                    tempNode = tempNode.Next;
                }

                Node<T> addedNode = new Node<T>();
                addedNode.Droid = droid;
                tempNode.Next = addedNode;
            }
        }
    }
}
