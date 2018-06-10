using System;

public class Node
{
    public int Value { get; set; }

    public Node Left { get; set; }

    public Node Right { get; set; }

    public Node(int value, Node left, Node right)
    {
        Value = value;
        Left = left;
        Right = right;
    }
}

public class BinarySearchTree
{
    public static bool Contains(Node root, int value)
    {
        if(value > root.Value)
        {
            if (root.Right != null)
            {
                if (root.Right.Value == value) return true;
                else return Contains(root.Right, value);
            }
            else return false;
        }

        if (value < root.Value)
        {
            if (root.Left != null)
            {
                if (root.Left.Value == value) return true;
                else return Contains(root.Left, value);
            }
            else return false;
        }
        else return true;
    }

    public static void Main(string[] args)
    {
        Node n1 = new Node(1, null, null);
        Node n3 = new Node(3, null, null);
        Node n2 = new Node(2, n1, n3);

        Console.WriteLine(Contains(n2, 3));
        Console.ReadLine();
    }
}