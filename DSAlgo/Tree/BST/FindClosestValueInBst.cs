using System;
using System.Collections.Generic;
using System.Text;

namespace DSAlgo.Tree.BST
{
	public class FindClosestValueInBst
	{
		public static int FindClosestValueInBstFn(BST tree, int target)
		{
			// Write your code here.
			return FindClosest(target, tree, tree.value);
		}

		private static int FindClosest(int target, BST tree, int res)
		{
			if (Math.Abs(target - res) > Math.Abs(target - tree.value))
			{
				res = tree.value;
			}

			if (target < tree.value && tree.left != null)
			{
				return FindClosest(target, tree.left, res);
			}
			else if (target > tree.value && tree.right != null)
			{
				return FindClosest(target, tree.right, res);
			}
			else
			{
				return res;
			}
		}

		public class BST
		{
			public int value;
			public BST left;
			public BST right;

			public BST(int value)
			{
				this.value = value;
			}
		}
	}
}
