using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest
{
    class Node
    {

        public Node next = null;
        public int data;
        public Node(int d)
        {
            data = d;
        }

        void appendNode(int d)
        {
            Node end = new Node(d);
            Node cur = this;
            while (cur.next!=null)
            {
                cur = cur.next;
            }
            cur = end;
        }


    }
}
