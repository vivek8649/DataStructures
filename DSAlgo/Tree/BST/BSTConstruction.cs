using System;
using System.Collections.Generic;
using System.Text;

namespace DSAlgo.Tree.BST
{
	class BSTConstruction
	{
		public class BST
		{
			public int value;
			public BST left;
			public BST right;

			public BST(int value)
			{
				this.value = value;
			}

			public BST Insert(int value)
			{
				// Write your code here.
				// Do not edit the return statement of this method.

				this.BSTInsertion(this, value);

				return this;
			}

			private BST BSTInsertion(BST bst, int value)
			{
				if (bst == null)
				{
					return new BST(value);
				}
				if (value < bst.value)
				{
					bst.left = BSTInsertion(bst.left, value);
				}
				else
				{
					bst.right = BSTInsertion(bst.right, value);
				}

				return bst;
			}

			public bool Contains(int value)
			{
				// Write your code here.
				return BSTContains(this, value);
			}

			private bool BSTContains(BST bst, int value)
			{
				if (bst == null) return false;

				if (bst.value == value)
				{
					return true;
				}

				if (value < bst.value)
				{
					return BSTContains(bst.left, value);
				}
				else if (value > bst.value)
				{
					return BSTContains(bst.right, value);
				}
				else
				{
					return true;
				}
			}

			public BST Remove(int value)
			{
				// Write your code here.
				// Do not edit the return statement of this method.
				RemoveBST(this, value);

				return this;
			}

			private BST RemoveBST(BST bst, int value)
			{
				if (bst == null || bst.value == value)
				{
					return bst;
				}

				if (value < bst.value)
				{
					bst.left = RemoveBST(bst, value);
				}
				else if (value > bst.value)
				{
					bst.right = RemoveBST(bst, value);
				}
				else
				{
					if (bst.left == null)
					{
						bst = bst.right;
						bst.right = null;
					}
					else if (bst.right == null)
					{
						bst = bst.left;
						bst.left = null;
					}
					else
					{
						var minInorderSuccesor = FindMinInOrderSuccesor(bst.right, value);
						bst.value = minInorderSuccesor;
						RemoveBST(bst.right, bst.value);
					}
				}
				return bst;
			}

			private int FindMinInOrderSuccesor(BST bst, int value)
			{
				BST temp = bst;

				while (temp.left != null)
				{
					temp = temp.left;
				}
				return temp.value;
			}
		}
	}
}
