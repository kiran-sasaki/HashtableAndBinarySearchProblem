namespace HashTableAndBinarySearchProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            //UC6
            MyBinaryNode<int> binaryNode = new MyBinaryNode<int>(56);
            binaryNode.Add(30);
            binaryNode.Add(70);
            binaryNode.Add(22);
            binaryNode.Add(40);
            binaryNode.Add(60);
            binaryNode.Add(95);
            binaryNode.Add(11);
            binaryNode.Add(65);
            binaryNode.Add(3);
            binaryNode.Add(16);
            binaryNode.Add(63);
            binaryNode.Add(67);
            binaryNode.Display();
            bool result = binaryNode.IfExists(67, binaryNode);
            Console.WriteLine(result);
        }
    }
}
