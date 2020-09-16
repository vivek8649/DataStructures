using System;
using System.Collections.Generic;
using System.Text;

namespace DSAlgo.Tree
{
	public class BTreeTraverseWithoutStack
	{
		public BTreeTraverseWithoutStack()
		{

		}

		public Node root;

		public static void TraverseWithoutStack(Node root)
		{
			Stack<Node> stack = new Stack<Node>();
			Node current = root;

			while (current != null)
			{
				stack.Push(current);
				current = current.left;

				while (current == null && stack.Count > 0)
				{
					Node top = stack.Pop();
					Console.Write(top.key + ", ");
					current = top.right;
				}
			}
		}
	}
}
