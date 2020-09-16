using System;
using System.Collections.Generic;
using System.Text;

namespace DSAlgo.Tree
{
	/* A binary tree node has key, pointer to 
	left child and a pointer to right child */
	public class Node
	{
		public int key;
		public Node left, right;

		// constructor 
		public Node(int key)
		{
			this.key = key;
			left = null;
			right = null;
		}
	}

	public class TreeDataLevel
	{
		public int data;
		public int level;
		public TreeDataLevel(int data, int level)
		{
			this.data = data;
			this.level = level;
		}
	}
}
