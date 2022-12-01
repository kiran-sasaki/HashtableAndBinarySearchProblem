namespace HashTableAndBinarySearchProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Wellcome to Hash Table and Binary Search Tree Problem");
            MyMapNode<string, string> node = new MyMapNode<string, string>(5);
            node.Add("0", "To");
            node.Add("1", "be");
            node.Add("2", "or");
            node.Add("3", "not");
            node.Add("4", "to");
            node.Add("5", "be");
            string node0 = node.Get("0");
            Console.WriteLine("0th index value: " + node0);
            string node1 = node.Get("1");
            Console.WriteLine("1st index value: " + node1);
            string node2 = node.Get("2");
            Console.WriteLine("2nd index value: " + node2);
            string node3 = node.Get("3");
            Console.WriteLine("3rd index value: " + node3);
            string node4 = node.Get("4");
            Console.WriteLine("4th index value: " + node4);
            string node5 = node.Get("5");
            Console.WriteLine("5th index value: " + node5);
        }
    }
}
