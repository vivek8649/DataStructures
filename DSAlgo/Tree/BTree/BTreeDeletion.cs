// C# program to insert element in binary tree 
using DSAlgo.Tree;
using System;
using System.Collections.Generic;

class BTreeDeletion
{

	public BTreeDeletion() { 

	}
	static Node root;

	/* Inorder traversal of a binary tree*/
	static void inorder(Node temp)
	{
		if (temp == null)
			return;

		inorder(temp.left);
		Console.Write(temp.key + " ");
		inorder(temp.right);
	}

	/*function to insert element in binary tree */
	static void delete(Node temp, int key)
	{
		Queue<Node> q = new Queue<Node>();
		q.Enqueue(temp);

		Node root = temp;
		Node key_node = null;
		Node last = null;
		// Do level order traversal until we find 
		while (q.Count != 0)
		{
			temp = q.Peek();
			last = temp;
			q.Dequeue();
			if (temp.key == key)
			{
				key_node = temp;
			}
			if (temp.left != null)
			{
			//	last = temp.left;
				q.Enqueue(temp.left);
			}
			if (temp.right != null)
			{
			//	last = temp.right;
				q.Enqueue(temp.right);
			}
		}

		if (key_node != null)
		{
			int lastKey = last.key;
			deleteLastnode(root, last);
			key_node.key = lastKey;
		}
	}

	public static void deleteLastnode(Node root, Node deleteNode)
	{
		if (root == null)
		{
			return;
		}
		if (deleteNode == null)
		{
			return;
		}

		Queue<Node> q = new Queue<Node>();
		q.Enqueue(root);

		while (q.Count > 0)
		{
			Node temp = q.Peek();
			q.Dequeue();

			if (temp.left == deleteNode)
			{
				temp.left = null;
				break;
			}
			else
			{
				q.Enqueue(temp.left);
			}

			if (temp.right == deleteNode)
			{
				temp.right = null;
				break;
			}
			else
			{
				q.Enqueue(temp.right);
			}
		}
	}

	// Driver code 
	public void DeleteNode()
	{
		root = new Node(10);
		root.left = new Node(11);
		root.left.left = new Node(7);
		root.left.right = new Node(12);
		root.right = new Node(9);
		root.right.left = new Node(15);
		root.right.right = new Node(8);

		Console.Write("Inorder traversal before insertion:");
		inorder(root);

		int key = 12;
		delete(root, key);

		Console.Write("\nInorder traversal after insertion:");
		inorder(root);
		Console.ReadLine();
	}
}

// This code is contributed by Rajput-Ji 
