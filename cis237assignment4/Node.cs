using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
{
    class Node<T>
    {

        public Node<T> Next
        {
            get { return Next; }
            set { Next = value; }
        }

        public IComparable Droid
        {
            get { return Droid; }
            set { Droid = value; }
        }
            
    }
}
