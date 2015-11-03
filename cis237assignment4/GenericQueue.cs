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
            {   //Set the newNode's next to the front of the queue, since we're adding to the front
                newNode.Next = HeadNode;
                //Set the HeadNode to now be the node we just added
                HeadNode = newNode;
            }
        }
    }
}
