using System;
using System.Collections.Generic;
using System.Text;

namespace Treeb
{
    class Tree
    {
        public Node root;

        public Tree()
        {
            this.root = null;
        }

        public void Add(int val)
        {
            Node newNode = new Node(val);
            if (this.root == null)
            {
                this.root = newNode;
            }
            else
            {
                Add(this.root, newNode);
            }
        }

        private void Add(Node node, Node newNode)
        {
            if (newNode.value < node.value)
            {
                if (node.left == null)
                {
                    node.left = newNode;
                }
                else
                {
                    Add(node.left, newNode);
                }
            }
            else
            {
                if (node.right == null)
                {
                    node.right = newNode;
                }
                else
                {
                    Add(node.right, newNode);
                }
            }
        }

        public bool Search(int val)
        {
            return Search(this.root, val);
        }

        private bool Search(Node node, int val)
        {
            if (node == null)
            {
                return false;
            }
            else if (val == node.value)
            {
                return true;
            }
            else if (val < node.value)
            {
                return Search(node.left, val);
            }
            else
            {
                return Search(node.right, val);
            }
        }
    }
}