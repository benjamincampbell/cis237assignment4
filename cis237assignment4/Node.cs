using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
{
    class Node<T>
    {
        private IComparable droid;
        private Node<T> next;

        public Node<T> Next
        {
            get { return next; }
            set { next = value; }
        }

        public IComparable Droid
        {
            get { return droid; }
            set { droid = value; }
        }            
    }
}
