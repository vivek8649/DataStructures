using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace DSAlgo.Tree.BST
{
	/*
	Implement in order traversal without stack and recursion - DONE
	Determine if the given two trees are identical or not  - DONE
	Print out all of its roof to leaf paths in a given binary tree/ binary search tree - DONE
	Find a lowest common ancestor of a given two nodes in a a binary search tree - DONE
	Level order traversal in spiral form - DONE
	Find the Diameter of a BST - DONE
	Convert a normal binary search tree to balanced BST. - DONE
	Construct BST from preorder - DONE
	**/


	public class Index
	{
		public int index = 0;
		public int k = 0;
		public int o = 0;
		public int sum = 0;
		public int count = 0;
		public int height = 0;
		public int heightForDiamter = Int32.MinValue;
	}

	public class MinMax
	{
		public int min;
		public int max;
		public int size;
		public bool isBST;
		public MinMax()
		{
			min = Int32.MaxValue;
			max = Int32.MinValue;
			isBST = true;
			size = 0;
		}
	}

	class BST
	{
		public BST()
		{
		}

		public void Inorder(Node root)
		{
			if (root != null)
			{
				Inorder(root.left);
				Console.WriteLine(root.key);
				Inorder(root.right);
			}
		}

		public void Insert(int data, Node root)
		{
			if (root == null)
			{
				root = new Node(data);
			}
			if (data < root.key)
			{
				if (root.left == null)
				{
					root.left = new Node(data);
				}
				else
				{
					Insert(data, root.left);
				}
			}
			if (data > root.key)
			{
				if (root.right == null)
				{
					root.right = new Node(data);
				}
				else
				{
					Insert(data, root.right);
				}
			}
		}

		public Node Search(int data, Node root)
		{
			if (root == null)
			{
				return null;
			}
			if (root.key == data)
			{
				return root;
			}
			else if (root.left.key < data)
			{
				return Search(data, root.right);
			}
			else
			{
				return Search(data, root.left);
			}

		}

		public Node Delete(int data, Node root)
		{
			if (root == null) return null;

			if (root.key > data)
			{
				root.left = Delete(data, root.left);
			}
			else if (root.key < data)
			{
				root.right = Delete(data, root.right);
			}
			else
			{
				if (root.left == null)
				{
					return root.right;
				}
				else if (root.right == null)
				{
					return root.left;
				}

				root.key = findInorderSuccessor(root.right);

				root.right = Delete(root.key, root.right);
			}

			return root;

		}

		public Node CreateBSTFromBTree(Node root)
		{
			// 1. Create temp inorder array
			int[] temp = new int[5];
			this.createTempInorderArrayFromBTree(root, temp, new Index());
			Array.Sort(temp);
			this.updateBinaryTree(root, temp, new Index());
			return root;
		}

		public Node CreateBalancedBSTFromLinkedList(LinkedList<int> sortedLinkedList)
		{

			//	return this.CreateBalancedBSTFromLinkedListUtil(sortedLinkedList, 0, sortedLinkedList.Count);

			// O(n)
			return this.CreateBalancedBSTFromLinkedListUtilInOrderN(sortedLinkedList, sortedLinkedList.Count, new Index());

		}

		public Node CreateGreaterSumTreeFromBST(Node root)
		{
			return this.CreateGreaterSumTreeFromBSTUtil(root, new Index());
		}

		public int CreatePossibleBSTFrom1ToN(int n)
		{
			int[] arr = new int[n + 1];

			arr[0] = 1;
			arr[1] = 1;

			for (int i = 2; i <= n; i++)
			{
				for (int j = 0; j < i; j++)
				{
					arr[i] += arr[j] * arr[i - j - 1];
				}
			}
			return arr[n];
		}

		public int CreatePossibleBSTFrom1ToNUsingRecursion(int n)
		{
			if (n <= 1)
			{
				return 1;
			}
			else
			{
				int sum = 0;
				for (int i = 1; i <= n; i++)
				{
					int left = CreatePossibleBSTFrom1ToNUsingRecursion(i - 1);
					int right = CreatePossibleBSTFrom1ToNUsingRecursion(n - i);
					sum += left * right;
				}
				return sum;
			}
		}

		public bool CheckIfBTreeIsBST(Node root, int min, int max)
		{
			if (root == null)
			{
				return true;
			}
			if (root.key < min || root.key > max)
			{
				return false;
			}
			return CheckIfBTreeIsBST(root.left, min, root.key) && CheckIfBTreeIsBST(root.right, root.key, max);
		}

		public MinMax LargestBSTInBTree(Node node)
		{
			if (node == null)
			{
				return new MinMax();
			}

			MinMax leftMinMax = LargestBSTInBTree(node.left);
			MinMax rightMinMax = LargestBSTInBTree(node.right);

			MinMax m = new MinMax();

			if (leftMinMax.isBST == false || rightMinMax.isBST == false || (node.key < leftMinMax.max || node.key >= rightMinMax.min))
			{
				m.isBST = false;
				m.size = Math.Max(leftMinMax.size, rightMinMax.size);
				return m;
			}

			m.isBST = true;
			m.size = leftMinMax.size + rightMinMax.size + 1;
			m.min = node.left != null ? leftMinMax.min : node.key;
			m.max = node.right != null ? rightMinMax.max : node.key;

			return m;
		}

		public Node KthSmallestElementOrderN(Node node, int k)
		{
			return KthSmallestElementOrderNUtil(node, k, new Index());
		}

		public int KthSmallestElementOrderNWithArray(Node node, int k)
		{
			int[] arr = new int[2];

			inorderForKthSmallest(node, arr, k);

			return arr[1];
		}

		/**
		 * Create BST from pre order 
		 */
		public Node CreateBSTFromPreOrder(int[] arr)
		{

			Index index = new Index();

			return this.BSTFromPreorderUsingStack(arr);

			// return this.CreateBSTFromPreOrderUtil(arr, index, arr[0], int.MinValue, int.MaxValue);


			// return this.CreateBSTFromPreOrderUtilOn2(arr, index, 0, arr.Length - 1, arr.Length);
		}
		private Node BSTFromPreorderUsingStack(int[] pre)
		{
			Stack<Node> stack = new Stack<Node>();
			Node root = new Node(pre[0]);
			stack.Push(root);

			for (int i = 1; i < pre.Length; ++i)
			{
				Node temp = null;
				while (stack.Count > 0 && stack.Peek().key < pre[i])
				{
					temp = stack.Pop();
				}

				if (temp != null)
				{
					temp.right = new Node(pre[i]);
					stack.Push(temp.right);
				}
				else
				{
					temp = stack.Peek();
					temp.left = new Node(pre[i]);
					stack.Push(temp.left);
				}
			}
			return root;
		}
		private Node CreateBSTFromPreOrderUtilOn2(int[] arr, Index index, int start, int end, int size)
		{
			if (index.index > size || start > end)
			{
				return null;
			}
			Node root = null;

			index.index = index.index + 1;
			root = new Node(arr[start]);

			if (index.index < size)
			{
				int i;
				for (i = start; i <= end; i++)
				{
					if (arr[i] > arr[start])
						break;
				}

				root.left = CreateBSTFromPreOrderUtilOn2(arr, index, index.index, i - 1, size);
				root.right = CreateBSTFromPreOrderUtilOn2(arr, index, i, end, size);
			}
			return root;
		}
		private Node CreateBSTFromPreOrderUtil(int[] pre, Index index, int key, int min, int max)
		{
			if (index.index >= pre.Length)
			{
				return null;
			}

			Node root = null;
			if (key > min && key < max)
			{
				root = new Node(key);
				index.index = index.index + 1;

				if (index.index < pre.Length)
				{
					root.left = CreateBSTFromPreOrderUtil(pre, index, pre[index.index], min, key);

					root.right = CreateBSTFromPreOrderUtil(pre, index, pre[index.index], key, max);
				}
			}

			return root;
		}


		/**
		 * Implement in order traversal without stack and recursion
		 */
		public void InOrderWithoutStackAndRecursion(Node node)
		{
			Node current = node;
			while (current != null)
			{
				if (current.left == null)
				{
					Console.WriteLine(current.key);
					current = current.right;
				}
				else
				{
					// predecessor
					Node pre = current.left;
					while (pre.right != null && pre.right != current)
					{
						pre = pre.right;
					}

					if (pre.right == null)
					{
						pre.right = current;
						current = current.left;
					}
					if (pre.right == current)
					{
						pre.right = null;
						Console.WriteLine(current.key);
						current = current.right;
					}
				}
			}
		}


		/**
		 * 	Determine if the given two trees are identical or not
		 */
		public bool checkIfTwoBSTsAreidentical(Node root1, Node root2)
		{
			if (root1 == null && root2 == null)
			{
				return true;
			}

			if ((root1 != null && root2 == null) || (root2 != null && root1 == null))
			{
				return false;
			}
			else
			{
				return (root1.key == root2.key) ?
					checkIfTwoBSTsAreidentical(root1.left, root2.left) && checkIfTwoBSTsAreidentical(root1.right, root2.right)
					: false;
			}


		}


		/**
		 * 	Print out all of its roof to leaf paths in a given binary search tree
		 */
		public void allRootToLeafPathsInAGivenBST(Node root)
		{
			Node[] arr = new Node[1000];
			int index = 0;
			allRootToLeafPathsInAGivenBSTUtil(root, arr, index);
		}
		private void allRootToLeafPathsInAGivenBSTUtil(Node root, Node[] arr, int index)
		{
			if (root != null)
			{
				arr[index] = root;
				index++;
			}

			if (root.left == null && root.right == null)
			{
				foreach (var item in arr)
				{
					if (item != null)
					{
						Console.Write(item.key + " ");
					}
				}
				Console.WriteLine();
			}
			else
			{
				allRootToLeafPathsInAGivenBSTUtil(root.left, arr, index);
				allRootToLeafPathsInAGivenBSTUtil(root.right, arr, index);
			}

		}


		/**
		 * 	Find a lowest common ancestor of a given two nodes in a a binary search tree
		 */
		public Node lowestCommonAncestorOfABinaryTree(Node root, Node node1, Node node2)
		{
			if (root == null)
			{
				return root;
			}
			if (root.key > node1.key && root.key > node2.key)
			{
				return lowestCommonAncestorOfABinaryTree(root.left, node1, node2);
			}
			else if (root.key < node1.key && root.key < node2.key)
			{
				return lowestCommonAncestorOfABinaryTree(root.right, node1, node2);
			}
			else
			{
				return root;
			}

			//if (root.key > Math.Min(node1.key, node2.key) && root.key < Math.Max(node1.key, node2.key))
			//{
			//	return root;
			//}
			//else if (root.key < Math.Min(node1.key, node2.key) && root.key < Math.Max(node1.key, node2.key))
			//{
			//	return lowestCommonAncestorOfABinaryTree(root.right, node1, node2);
			//}
			//else 
			//{
			//	return lowestCommonAncestorOfABinaryTree(root.left, node1, node2);
			//}
		}


		/**
		 * Level order traversal in spiral form
		 */
		public void levelOrderTraversalOfBSTInSpiralOrderNsqare(Node node)
		{
			int h = height(node);
			bool itr = false;
			for (int i = 1; i <= h; i++)
			{
				levelOrderTraversalOfBSTInSpiralOrderNsqareUtil(node, i, itr);
				itr = !itr;
				Console.WriteLine();
			}
		}
		private void levelOrderTraversalOfBSTInSpiralOrderNsqareUtil(Node node, int level, bool itr)
		{
			if (node == null)
			{
				return;
			}
			if (level == 1)
			{
				Console.Write(node.key + " ");
				return;
			}
			else if (level >= 1)
			{
				if (itr == true)
				{
					levelOrderTraversalOfBSTInSpiralOrderNsqareUtil(node.left, level - 1, itr);
					levelOrderTraversalOfBSTInSpiralOrderNsqareUtil(node.right, level - 1, itr);
				}
				else
				{
					levelOrderTraversalOfBSTInSpiralOrderNsqareUtil(node.right, level - 1, itr);
					levelOrderTraversalOfBSTInSpiralOrderNsqareUtil(node.left, level - 1, itr);
				}
			}

		}
		public void levelOrderTraversalOfBSTInSpiralOrderN(Node node)
		{
			Stack<Node> s1 = new Stack<Node>();
			Stack<Node> s2 = new Stack<Node>();

			s1.Push(node);

			while (s1.Count != 0 || s1.Count != 0)
			{
				while (s1.Count != 0)
				{
					Node s = s1.Peek();
					s1.Pop();

					Console.Write(s.key);
					if (s.right != null)
					{
						s2.Push(s.right);
					}
					if (s.left != null)
					{
						s2.Push(s.left);
					}
				}


				while (s2.Count != 0)
				{
					Node s = s2.Peek();
					s2.Pop();

					Console.Write(s.key);

					if (s.right != null)
					{
						s1.Push(s.left);
					}
					if (s.left != null)
					{
						s1.Push(s.right);
					}
				}
				Console.WriteLine();
			}
		}
		private int height(Node node)
		{
			if (node == null)
			{
				return 0;
			}

			int lHeight = height(node.left);
			int rHeight = height(node.right);

			if (lHeight > rHeight)
			{
				return lHeight + 1;
			}
			else
			{
				return rHeight + 1;
			}
		}


		/**
		 * Find the Diameter of a BST
		 */
		public int diameterOfBSTOrderNsquare(Node node)
		{
			if (node == null)
			{
				return 0;
			}
			int leftHeight = height(node.left);
			int rightHeight = height(node.right);

			int leftDiameter = diameterOfBSTOrderNsquare(node.left);
			int rightDiameter = diameterOfBSTOrderNsquare(node.right);

			int max = Math.Max(leftHeight + rightHeight + 1, Math.Max(leftDiameter, rightDiameter));

			return max;
		}
		public int diameterOfBSTOrderN(Node node, Index index)
		{
			if (node == null)
			{
				index.height = 0;
				return 0;
			}
			Index leftHeight = new Index();
			Index rightHeight = new Index();

			int leftDiameter = diameterOfBSTOrderN(node.left, leftHeight);
			int rightDiameter = diameterOfBSTOrderN(node.right, rightHeight);

			index.height = Math.Max(leftHeight.height, rightHeight.height) + 1;

			int max = Math.Max(leftHeight.height + rightHeight.height + 1, Math.Max(leftDiameter, rightDiameter));

			return max;
		}
		public int diameterOfBSTOrderNOnlyHeightFuntion(Node node)
		{
			if (node == null)
			{
				return 0;
			}
			Index indexForHeight = new Index();
			heightForDiameter(node, indexForHeight);

			return indexForHeight.heightForDiamter;
		}
		private int heightForDiameter(Node node, Index index)
		{
			if (node == null)
			{
				return 0;
			}

			int leftHeight = heightForDiameter(node.left, index);
			int rightHeight = heightForDiameter(node.right, index);

			index.heightForDiamter = Math.Max(index.heightForDiamter, leftHeight + rightHeight + 1);

			return Math.Max(leftHeight, rightHeight) + 1;
		}


		/**
		 * Convert a normal binary search tree to balanced BST.
		 */
		public Node ConvertBSTToBalancedTree(Node node)
		{
			// traverse inorder to create array
			List<Node> list = new List<Node>();
			this.getInorderedList(node, list);
			return this.createBSTFromArray(list, 0, list.Count - 1);
		}
		private void getInorderedList(Node node, List<Node> list)
		{
			if (node == null)
			{
				return;
			}
			getInorderedList(node.left, list);
			list.Add(node);
			getInorderedList(node.right, list);
		}
		private Node createBSTFromArray(List<Node> list, int start, int end)
		{
			if (start > end)
			{
				return null;
			}

			int mid = (start + end) / 2;
			Node node = new Node(list.ElementAt(mid).key);

			node.left = createBSTFromArray(list, start, mid - 1);
			node.right = createBSTFromArray(list, mid + 1, end);

			return node;
		}

		/**
		 * Practise  - Create BST from pre order
		 */
		public Node ConstructBSTFromPreorder(int[] preorder, int start, int end)
		{
			if (start > end)
			{
				return null;
			}
			int root = preorder[start];

			Node node = new Node(root);

			int keyIndex = -1;

			for (int j = start; j < end; j++)
			{
				if (preorder[j] > root)
				{
					keyIndex = j;
					break;
				}
			}
			if (keyIndex > -1)
			{
				node.left = ConstructBSTFromPreorder(preorder, start + 1, keyIndex);

				node.right = ConstructBSTFromPreorder(preorder, keyIndex, end);
			}
			return node;
		}

		public Node CreateBSTFromPreOrderOrderN(int[] pre, Index index, int min, int max)
		{
			if (index.index >= pre.Length || pre[index.index] < min || pre[index.index] > max)
			{
				return null;
			}

			Node node = new Node(pre[index.index]);
			index.index++;

			if (index.index < pre.Length)
			{
				node.left = CreateBSTFromPreOrderOrderN(pre, index, min, node.key);
				node.right = CreateBSTFromPreOrderOrderN(pre, index, node.key, max);
			}
			return node;
		}

		public Node CreateBSTFromPreorderUsingStack(int[] pre)
		{
			Stack<Node> stack = new Stack<Node>();
			Node root = new Node(pre[0]);
			stack.Push(root);

			for (int i = 1; i < pre.Length; i++)
			{
				Node temp = null;
				while (stack.Count > 0 && pre[i] > stack.Peek().key)
				{
					temp = stack.Pop();
				}

				if (temp != null)
				{
					temp.right = new Node(pre[i]);
					stack.Push(temp.right);
				}
				else
				{
					temp = stack.Peek();
					temp.left = new Node(pre[i]);
					stack.Push(temp.left);
				}

			}
			return root;
		}

		public Node PrintPostOrderFromPre(int[] pre, Index index, int min, int max)
		{
			if (index.index >= pre.Count() || pre[index.index] > max || pre[index.index] < min)
			{
				return null;
			}

			Node node = new Node(pre[index.index]);
			index.index++;

			if (index.index <= pre.Count())
			{
				node.left = PrintPostOrderFromPre(pre, index, min, node.key);

				node.right = PrintPostOrderFromPre(pre, index, node.key, max);

				Console.WriteLine(node.key);
			}
			return node;

		}

		private void inorderForKthSmallest(Node node, int[] num, int k)
		{
			if (node == null)
			{
				return;
			}

			inorderForKthSmallest(node.left, num, k);

			if (++num[0] == k)
			{
				num[1] = node.key;
			}

			inorderForKthSmallest(node.right, num, k);

		}

		private Node KthSmallestElementOrderNUtil(Node node, int k, Index index)
		{
			if (node == null)
			{
				return node;
			}

			Node left = KthSmallestElementOrderNUtil(node.left, k, index);

			if (left != null)
			{
				return left;
			}

			index.count++;
			if (index.count == k)
			{
				return node;
			}

			return KthSmallestElementOrderNUtil(node.right, k, index);
		}

		private Node CreateGreaterSumTreeFromBSTUtil(Node root, Index index)
		{
			if (root == null)
			{
				return root;
			}

			this.CreateGreaterSumTreeFromBSTUtil(root.right, index);

			index.sum += root.key;

			root.key = index.sum - root.key;

			this.CreateGreaterSumTreeFromBSTUtil(root.left, index);

			return root;
		}

		private Node CreateBalancedBSTFromLinkedListUtilInOrderN(LinkedList<int> sortedLinkedList, int n, Index index)
		{
			if (n <= 0)
			{
				return null;
			}

			Node left = this.CreateBalancedBSTFromLinkedListUtilInOrderN(sortedLinkedList, n / 2, index);

			Node root = new Node(sortedLinkedList.ElementAt(index.index++));

			root.left = left;

			root.right = this.CreateBalancedBSTFromLinkedListUtilInOrderN(sortedLinkedList, n - n / 2 - 1, index);

			return root;
		}

		private Node CreateBalancedBSTFromLinkedListUtil(LinkedList<int> sortedLinkedList, int start, int end)
		{
			Node root = null;
			if (start < end)
			{
				int mid = (start + end) / 2;

				root = new Node(sortedLinkedList.ElementAt(mid));

				root.left = CreateBalancedBSTFromLinkedListUtil(sortedLinkedList, start, mid);

				root.right = CreateBalancedBSTFromLinkedListUtil(sortedLinkedList, mid + 1, end);
			}
			return root;
		}

		private void createTempInorderArrayFromBTree(Node root, int[] temp, Index index)
		{
			if (root != null)
			{
				this.createTempInorderArrayFromBTree(root.left, temp, index);
				temp[index.index++] = root.key;
				this.createTempInorderArrayFromBTree(root.right, temp, index);
			}
		}

		private void updateBinaryTree(Node root, int[] temp, Index index)
		{
			if (root != null && index.index < temp.Length)
			{
				this.updateBinaryTree(root.left, temp, index);
				root.key = temp[index.index];
				index.index++;
				this.updateBinaryTree(root.right, temp, index);
			}
		}

		private int findInorderSuccessor(Node node)
		{
			int min = node.key;

			while (node.left != null)
			{
				if (min > node.left.key)
				{
					min = node.left.key;
				}
			}
			return min;
		}


		public void start()
		{
			BST bst = new BST();
			/* Let us create following BST 
			  50 
		   /     \ 
		  30      70 
		 /  \    /  \ 
	   20   40  60   80 */
			Node root = new Node(50);
			bst.Insert(30, root);
			bst.Insert(20, root);
			bst.Insert(40, root);
			bst.Insert(70, root);
			bst.Insert(60, root);
			bst.Insert(80, root);

			Node node = new Node(25);
			node.left = new Node(18);
			node.right = new Node(50);

			node.left.left = new Node(29);
			node.left.right = new Node(20);

			node.left.left.right = new Node(15);

			node.left.right.left = new Node(18);
			node.left.right.right = new Node(28);

			node.left.right.left = new Node(18);
			node.left.right.right = new Node(25);

			node.right.left = new Node(35);
			node.right.right = new Node(65);

			node.right.left.left = new Node(20);
			node.right.left.right = new Node(40);

			node.right.right.left = new Node(55);
			node.right.right.right = new Node(70);

			node.right.left.left.right = new Node(25);

			//// print inorder traversal of the BST 
			//bst.Inorder(root);

			//Console.WriteLine("Delete");

			//bst.Delete(30, root);

			//Console.WriteLine("Inorder");
			//bst.Inorder(root);


			//int[] pre = new int[] { 10, 5, 1, 7, 40, 50 };
			//int size = pre.Length;
			//Node root = bst.CreateBSTFromPreOrder(pre);


			//Node btree = new Node(10);
			//btree.left = new Node(30);
			//btree.right = new Node(15);
			//btree.left.left = new Node(20);
			//btree.right.right = new Node(5);

			//Node createdBST = bst.CreateBSTFromBTree(btree);
			//Console.WriteLine("Inorder traversal of the constructed tree is ");
			//bst.Inorder(createdBST);

			//Node res = bst.CreateBalancedBSTFromLinkedList(new LinkedList<int>(new List<int>() { 1, 2, 3, 4, 5, 6, 7 }));
			//bst.Inorder(res);

			//bst.Inorder(bst.CreateGreaterSumTreeFromBST(root));

			// Console.WriteLine(bst.CreatePossibleBSTFrom1ToN(5));
			// Console.WriteLine(bst.CreatePossibleBSTFrom1ToNUsingRecursion(5));

			// Console.WriteLine(bst.CheckIfBTreeIsBST(root, Int32.MinValue, Int32.MaxValue));

			//Console.WriteLine(bst.LargestBSTInBTree(node).size);

			// Console.WriteLine(bst.KthSmallestElementOrderN(root, 3).key);

			// Console.WriteLine(bst.KthSmallestElementOrderNWithArray(root, 3));

			/**
			 	Implement in order traversal without stack and recursion
			 */
			// bst.InOrderWithoutStackAndRecursion(root);

			/**
		  	Determine if the given two trees are identical or not
			*/
			//Node root1 = new Node(50);
			//bst.Insert(30, root);
			//bst.Insert(25, root);
			//bst.Insert(40, root);
			//bst.Insert(70, root);
			//bst.Insert(60, root);
			//bst.Insert(80, root);
			//Console.WriteLine(bst.checkIfTwoBSTsAreidentical(root, root1));

			/**
			* 	Print out all of its roof to leaf paths in a given binary search tree
			*/
			// bst.allRootToLeafPathsInAGivenBST(root);

			/**
			 * 	Find a lowest common ancestor of a given two nodes in a a binary search tree
			 */
			// Console.WriteLine(bst.lowestCommonAncestorOfABinaryTree(root, root.left.left, root.left.right).key);

			/**
			 * Level order traversal in spiral form
			 */
			// bst.levelOrderTraversalOfBSTInSpiralOrderNsqare(root);
			//bst.levelOrderTraversalOfBSTInSpiralOrderN(root);

			/**
			 * Find the Diameter of a BST
			 */
			// Console.WriteLine(bst.diameterOfBSTOrderNsquare(root));
			// Console.WriteLine(bst.diameterOfBSTOrderN(root, new Tree.BST.Index()));
			// Console.WriteLine(bst.diameterOfBSTOrderNOnlyHeightFuntion(root));

			/**
			 * Convert a normal binary search tree to balanced BST.
			 */
			Node unbalancedTree = new Node(45);
			bst.Insert(55, unbalancedTree);
			bst.Insert(65, unbalancedTree);
			bst.Insert(75, unbalancedTree);
			bst.Insert(85, unbalancedTree);
			bst.Insert(95, unbalancedTree);
			bst.Insert(105, unbalancedTree);
			//bst.Inorder(bst.ConvertBSTToBalancedTree(unbalancedTree));

			/**
			 * Construct a BST from preorder
			 */
			//				    75
			//			65	           85
			//		45		70      80	   105
			// pre order - 75, 65, 45, 70, 85, 80, 105
			// inorder - 45, 65, 70, 75, 80, 85, 105
			// post order - 45 70 65 80 105 85 75

			//bst.Inorder(bst.ConstructBSTFromPreorder(new int[] { 75, 65, 45, 70, 85, 80, 105 }, 0, 7));
			// bst.Inorder(bst.CreateBSTFromPreOrderOrderN(new int[] { 75, 65, 45, 70, 85, 80, 105 }, new Index(), Int32.MinValue, Int32.MaxValue));
			// bst.Inorder(bst.CreateBSTFromPreorderUsingStack(new int[] { 75, 65, 45, 70, 85, 80, 105 }));
			 PrintPostOrderFromPre(new int[] { 75, 65, 45, 70, 85, 80, 105 }, new Index(), Int32.MinValue, Int32.MaxValue);


			//LNode btree = new LNode(10);
			//btree.left = new LNode(5);
			//btree.right = new LNode(15);
			//btree.left.left = new LNode(3);
			//btree.right.right = new LNode(20);

			// new BacktrackingStringPermutaion().createInputData();
			// new BacktrackingIsHack().setData();
			// new BacktrackingConfidential().RunConfidential();
			// new BacktrackingStairs().StaircaseWays();
			// new BacktrackingSubset().subsets(new List<int>() { 15, 20, 12, 19, 4});
			// new BacktrackingCombination().combine(4, 2);
			// new BacktrackingCommbinationSum().combinationSum(new List<int>() { 8, 10, 6, 11, 1, 16, 8 }, 28);
			// new BSTCount().findCount(new List<int>() { 4, 7, 7, 7, 8, 10, 10 }, 3);

			/**
			 * BTree 
			 */

			// new BTreeDeletion().DeleteNode(); 

			//BTreeTraverseWithoutStack tree = new BTreeTraverseWithoutStack();
			//tree.root = new Node(25);
			//tree.root.left = new Node(15);
			//tree.root.right = new Node(50);

			//tree.root.left.left = new Node(10);
			//tree.root.left.right = new Node(22);

			//tree.root.left.left.left = new Node(4);
			//tree.root.left.left.right = new Node(12);

			//tree.root.left.right.left = new Node(18);
			//tree.root.left.right.right = new Node(24);

			//tree.root.right.left = new Node(35);
			//tree.root.right.right = new Node(70);


			//tree.root.right.right.left = new Node(66);
			//tree.root.right.right.right = new Node(90);

			//BTreeTraverseWithoutStack.TraverseWithoutStack(tree.root);

			/*
			 BFS Traversal
			*/
			//Graph.Graph g = new Graph.Graph(4);

			//g.addEdge(0, 1);
			//g.addEdge(0, 2);
			//g.addEdge(1, 2);
			//g.addEdge(2, 0);
			//g.addEdge(2, 3);
			//g.addEdge(3, 3);

			//Console.WriteLine("Following is Depth First Traversal " + "(starting from vertex 2)");
			//g.DFSTraversal(2);

			//Console.WriteLine("Following is Breadth First Traversal " + "(starting from vertex 2)");
			//g.BFSTraversal(2);

			Console.ReadLine();
		}

	}
}
