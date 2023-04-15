using System;

namespace Treeb
{
    class Program
    {
        static void Main()
        {
            Tree tree = new Tree();
            tree.Add(5);
            tree.Add(2);
            tree.Add(7);
            Console.WriteLine(tree.Search(2));
            Console.WriteLine(tree.Search(6));
        }
    }
}