using Binary_tree;

internal class Program
{
    private static void Main(string[] args)
    {
        BTree binaryTree = new BTree();

        binaryTree.Add(1);
        binaryTree.Add(2);
        binaryTree.Add(7);
        binaryTree.Add(3);
        binaryTree.Add(10);
        binaryTree.Add(5);
        binaryTree.Add(8);

       

        Console.WriteLine("PreOrder Traversal:");
        binaryTree.TraversePreOrder(binaryTree.Root);
        Console.WriteLine();

        Console.WriteLine("InOrder Traversal:");
        binaryTree.TraverseInOrder(binaryTree.Root);
        Console.WriteLine();

        Console.WriteLine("PostOrder Traversal:");
        binaryTree.TraversePostOrder(binaryTree.Root);
        Console.WriteLine();

        binaryTree.Remove(7);
        

        Console.WriteLine("PreOrder Traversal After Removing Operation:");
        binaryTree.TraversePreOrder(binaryTree.Root);
        Console.WriteLine();


    }
}