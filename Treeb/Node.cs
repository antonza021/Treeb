using System;
using System.Collections.Generic;
using System.Text;

namespace Treeb
{
    class Node
    {
        public int value;
        public Node left;
        public Node right;

        public Node(int val)
        {
            this.value = val;
            this.left = null;
            this.right = null;
        }
    }
}
