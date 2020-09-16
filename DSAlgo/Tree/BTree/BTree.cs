using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DSAlgo.Tree.BTree
{
	#region Question List

	/**
	Convert a binary tree into its mirror tree  - DONE
	Check if a given binary tree is sum tree or not  - DONE
	Find a lowest common ancestor of a given two nodes in a binary tree - DONE
	Convert an arbitrary binary tree to a tree that holds children sum property - Done
	Construct tree from given inorder and post order traversal - Done
	Convert a Binary Tree to a circular DLL - Done 
	Evaluation of expression tree - Done
	Print extreme node of each level of Binary Tree in alternative order - Done
	Print cousins of a given node in Binary Tree - Done
	Diagonal traversal of Binary Tree -  Done
	Find multiplication of sums of data of leaves at same level. -  Done
	Given a binary tree, find maximum value we can get by subtracting value of node B from value of node A - Done
	Given a Binary Tree and a number k, remove all nodes that lie only on root to leaf path(s) of length smaller than k. - Done
	Print all nodes that are at distance k from a leaf node. - Done
	Serialize and deserialize an N-ary tree. - Done
	Reverse alternate levels of a perfect Binary Tree. - Done
	Construct complete binary tree from its linked list representation. - Done
	Find next right nodes of given leafs in a binary tree. - Done
	Given a binary tree, print boundary nodes of the binary tree Anti-Clockwise starting from the root. - Done
	Convert a given tree to its sum tree. - Done
	Given a binary tree, find out if the tree can be folded or not. - Done
	Given a Binary Tree, find vertical sum of the nodes that are in same vertical line. - Done
	Print nodes in a top view of Binary Tree. - Done

	Check if removing an edge can divide a binary tree in the form of n-ary tree.
	Construct tree from ancestor matrix 
	Find largest sub tree having identical left and right sub tree. 
	locking and unlocking of resource arranged on the form of n-ary tree.
	Custom tree problem.
	*/

	#endregion

	public class BTree
	{
		#region Helper Classes
		public class Indexer
		{
			public int index = 0;
			public NodeWithNext next = null;
			public int data = -1;
			public bool isTrue = true;
		}
		public class NodeWithNext
		{
			public int data;
			public NodeWithNext left;
			public NodeWithNext right;
			public NodeWithNext next;
			public NodeWithNext(int data)
			{
				this.data = data;
				left = right = next = null;
			}
		}

		// Doubly Linked List Node  
		public class LLNode
		{
			public int data;
			public LLNode prev, next;
			public LLNode(int d)
			{
				data = d;
			}
		}

		public class QuequeObj
		{
			public Node node;
			public int hd;

			public QuequeObj(Node obj, int hd)
			{
				node = obj;
				this.hd = hd;
			}
		}

		#endregion

		public void start()
		{
			BTree bTree = new BTree();
			/**
			 * Insert
			 */
			Node root = null;
			root = bTree.Insert(root, 40);
			bTree.Insert(root, 50);
			bTree.Insert(root, 60);
			bTree.Insert(root, 70);
			bTree.Insert(root, 80);
			bTree.Insert(root, 90);
			// Inorder(root);

			/**
			 * Delete from tree
			 */

			Node node1 = new Node(10);
			node1.left = new Node(11);
			node1.left.left = new Node(12);
			node1.left.right = new Node(13);
			node1.right = new Node(11);
			node1.right.left = new Node(12);
			node1.right.right = new Node(13);
			// Inorder(bTree.Delete(node1, 11));

			/**
			 * Is a continous tree
			 */
			Node node2 = new Node(10);
			node2.left = new Node(11);
			node2.left.left = new Node(12);
			node2.right = new Node(9);
			node2.right.right = new Node(8);
			// Console.WriteLine(bTree.isAContinousTree(node2));

			/**
			 * Is foldable tree
			 */
			//		 34
			//	 23	     45
			//	   31   1  12	
			// inorder   23 31 34 1 45 12
			Node node3 = new Node(34);
			node3.left = new Node(23);
			node3.left.right = new Node(31);
			node3.right = new Node(45);
			node3.right.left = new Node(1);
			node3.right.right = new Node(12);
			// Console.WriteLine(bTree.isFoldableByCovertingOneSubTreeToMirror(node3));
			// Console.WriteLine(bTree.isFoldable(node3));

			/**
			 * Inorder traversal without recursion
			 */
			// bTree.inorderTraversalWithoutRecursion(node3);

			/**
			 * Inorder traversal without recursion and stack
			 */
			// bTree.inorderTraversalWithoutRecursionAndStack(node3);

			/**
			 * Print post order with given inorder and preorder
			 */
			// output 31, 23, 1, 12, 45, 34
			// bTree.printPostOrderFromInOrderAndPreOrder(new int[] { 23, 31, 34, 1, 45, 12 }, new int[] { 34, 23, 31, 45, 1, 12 }, 6);

			/**
			 * Print all possible trees from inorder
			 */
			// Console.WriteLine(bTree.printAllPossibleTreesFromInorder(new int[] { 23, 31, 34, 1,56 }, 5));

			/**
			 * Replace each node in binary tree with the sum of its inorder predecessor and successor
			 */
			//	Inorder(bTree.replaceNodeWithSumOfItsInorderPredessorAndSuccessor(node3));
			// Inorder(bTree.replaceNodeWithSumOfItsInorderPredessorAndSuccessor2(node3));

			/**
			 * Add inorder successor to each node
			 * **/
			/* Constructed binary tree is 
					  10 
					 /   \ 
					8      12 
				   / 
				  3    */
			NodeWithNext tree = new NodeWithNext(10);
			tree.left = new NodeWithNext(8);
			tree.right = new NodeWithNext(12);
			tree.left.left = new NodeWithNext(3);

			//// Populates nextRight pointer in all nodes 
			//addInorderSuccessorToNode(tree, new Indexer());

			//// Let us see the populated values 
			//NodeWithNext ptr = tree.left.left;
			//while (ptr != null)
			//{
			//	// -1 is printed if there is no successor 
			//	int print = ptr.next != null ? ptr.next.data : -1;
			//	Console.WriteLine("Next of " + ptr.data + " is: " + print);
			//	ptr = ptr.next;
			//}

			/**
			 * Find inorder successor of a node
			 */
			//var indexer = new Indexer();
			//findInorderSuccessorOfANode(node3, indexer, 31);
			//Console.WriteLine(indexer.index);

			/**
			 * Level order traversal BTree
			*/
			// levelOrderTraversalBTree(node3);

			/**
			 * Level order traversal BTree in spiral
			*/
			// levelOrderTraversalBTreeSpiral(node3);
			// levelOrderTraversalBTreeSpiralUsingStack(node3);

			/**
			 * Convert a binary tree into its mirror tree
			 */
			// Inorder(ConvertBinaryTreeToMirrorTree(node3));
			// Inorder(ConvertBinaryTreeToMirrorTreeIterative(node3));

			/**
			 * Check if binary tree is sum tree or not
			 */
			Node node = new Node(26);
			node.left = new Node(10);
			node.left.left = new Node(4);
			node.left.right = new Node(6);
			node.right = new Node(3);
			node.right.right = new Node(3);

			// var indexer = new Indexer();
			// CheckIfBinaryTreeIsSumTree(node, indexer);
			// Console.WriteLine(indexer.isTrue);
			// Console.WriteLine(CheckIfBinaryTreeIsSumTreeGFG(node));
			//if (CheckIfBinaryTreeIsSumTreeOrderN(node) == Int32.MinValue)
			//{
			//	Console.WriteLine("No");
			//}
			//else
			//{
			//	Console.WriteLine("Yes");
			//}

			/*
			 * Lowest common ancestor of a binary tree
			 */
			//				34
			//		  23		 76
			//    32	  56   45   13
			Node node4 = new Node(34);
			node4.left = new Node(23);
			node4.left.left = new Node(32);
			node4.left.right = new Node(56);
			node4.right = new Node(76);
			node4.right.left = new Node(45);
			node4.right.right = new Node(13);

			//Console.WriteLine("LCA ; " + lowestCommonAncestorOfBTree(node4, 45, 13).key); // 76
			//Console.WriteLine("LCA ; " + lowestCommonAncestorOfBTree(node4, 76, 13).key); // 76
			//Console.WriteLine("LCA ; " + lowestCommonAncestorOfBTree(node4, 32, 56).key); // 23
			//Console.WriteLine("LCA ; " + lowestCommonAncestorOfBTree(node4, 32, 76).key); // 34

			/**
			 * 	Convert an arbitrary binary tree to a tree that holds children sum property
			 */
			Node node5 = new Node(50);
			node5.left = new Node(7);
			node5.right = new Node(2);
			node5.left.left = new Node(3);
			node5.left.right = new Node(5);
			node5.right.left = new Node(1);
			node5.right.right = new Node(30);
			//ConvertBTreeToChildrenSum(node5);
			//Inorder(node5);

			/**
			 * Construct BTree from preorder and inorder
			 * */
			//          34 
			//     23         76
			//  32     56   45    13
			// inorder 32 23 56 34 45 76 13
			// preorder 34 23 32 56 76 45 13
			var inorder = new int[] { 32, 23, 56, 34, 45, 76, 13 };
			//Inorder(ConstructBTreeFromPreorderAndInorder(new int[] { 34, 23, 32, 56, 76, 45, 13 }, 0, 6,
			//	new int[] { 32, 23, 56, 34, 45, 76, 13 }, 0, 6));

			//Inorder(ConstructBTreeFromPreorderAndInorderOrderN(new int[] { 34, 23, 32, 56, 76, 45, 13 }, 0, 6,
			//	new int[] { 32, 23, 56, 34, 45, 76, 13 }, 0, 6, Enumerable.Range(0, inorder.Length).ToDictionary(x => inorder[x], y => y)));

			/**
			 * Convert BTree into circular doubly linked list
			 */
			//          10
			//    12			15
			// 25    30    36
			Node node6 = new Node(10);
			node6.left = new Node(12);
			node6.right = new Node(15);
			node6.left.left = new Node(25);
			node6.left.right = new Node(30);
			node6.right.left = new Node(36);

			// Node prev = null;
			// Node head = null;
			// ConvertBTreeToCircularDoublyLinkeList(node6, ref prev, ref head);
			// printCircularLinkedList(head);
			// printCircularLinkedList(ConvertBTreeToCircularDoublyLinkeListGFG(node6));

			/***
			 * Construction of expression tree
			 */
			//String postfix = "ab+ef*g*-";
			//char[] charArray = postfix.ToCharArray();
			//Inorder(ConstructExpressionTree(charArray));

			/**
			 * Evaluation of expression tree
			 */
			//ExprNode expNode = new ExprNode("+");
			//expNode.left = new ExprNode("*");
			//expNode.left.left = new ExprNode("5");
			//expNode.left.right = new ExprNode("4");
			//expNode.right = new ExprNode("-");
			//expNode.right.left = new ExprNode("100");
			//expNode.right.right = new ExprNode("20");
			//Console.WriteLine(EvaluateExpressionTree(expNode));

			/**
			 * Print extreme node of each level of Binary Tree in alternative order
			 */
			Node node7 = new Node(1);
			node7.left = new Node(2);
			node7.right = new Node(3);
			node7.left.left = new Node(4);
			node7.left.right = new Node(5);
			node7.right.left = new Node(6);
			node7.right.right = new Node(7);

			node7.left.right.left = new Node(10);
			node7.left.right.right = new Node(11);

			node7.right.left.left = new Node(12);
			node7.right.left.right = new Node(13);

			node7.left.left.left = new Node(8);
			node7.left.left.right = new Node(9);

			node7.right.right.left = new Node(14);
			node7.right.right.right = new Node(15);

			// PrintExtremeNodeOfEacchLevvelInAlternativeOrderUsingStack(node7);
			// PrintExtremeNodeOfEacchLevvelInAlternativeOrderUsingQueue(node7);


			/**
			 * Print cousins of a given node in Binary Tree
			 */
			// PrintCousinsOfABinaryTree(node7, 15);
			// PrintCousinsOfABinaryTreeRec(node7, 15);

			/**
			 * 	Diagonal traversal of Binary Tree
			 */
			// DiagnoalTraversalOfBinaryTree(node7);

			/**
			 * Construct tree from ancestor matrix
			 */
			int[,] array2D = new int[,] {
								{ 0, 0, 0, 0, 0, 0 },
								{ 1, 0, 0, 0, 1, 0 },
								{ 0, 0, 0, 1, 0, 0 },
								{ 0, 0, 0, 0, 0, 0 },
								{ 0, 0, 0, 0, 0, 0 },
								{ 1, 1, 1, 1, 1, 0 }
								 };

			// Inorder(ConstructTreeFromAncestorMatrix(array2D));


			/**
			 * 	Given a Binary Tree, find vertical sum of the nodes that are in same vertical line.
			 */
			// FindVerticalSum(node7);
			// FindVerticalSumWithoutExtraSpace(node7);

			/**
			 * Find multiplication of sums of data of leaves at same level.
			 */
			Node node8 = new Node(2);
			node8.left = new Node(7);
			node8.right = new Node(5);
			node8.left.left = new Node(8);
			node8.left.right = new Node(6);
			node8.left.right.left = new Node(1);
			node8.left.right.right = new Node(11);
			node8.right.right = new Node(9);
			node8.right.right.left = new Node(4);
			node8.right.right.right = new Node(10);
			// Console.WriteLine(MultiplicationOfSumsOfDataOfLeavesAtSameLevel(node8));

			/**
			 * 	Given a binary tree, find maximum value we can get by subtracting value of node B from value of node 
			 */
			// Console.WriteLine(MaximumSubtractedValueOfTwoNodes(node8));

			/**
			 * Print nodes in a top view of Binary Tree.
			 */
			///           1
			///      2        3
			///         4
			///             5
			///                 6
			Node node9 = new Node(1);
			node9.left = new Node(2);
			node9.right = new Node(3);
			node9.left.right = new Node(4);
			node9.left.right.right = new Node(5);
			node9.left.right.right.right = new Node(6);
			// PrintNodesInTopView(node9);
			// PrintNodesInTopViewOrderN(node9);
			// PrintNodesInTopViewOrderNWithoutQueue(node9);

			/**
			 * 	Given a Binary Tree and a number k, remove all nodes that lie only on root to leaf path(s) of length smaller than k.
			 */
			///						1
			///					2        3
			///				4	   5          6
			///			7	              8  
			Node node10 = new Node(1);
			node10.left = new Node(2);
			node10.right = new Node(3);
			node10.left.left = new Node(4);
			node10.left.right = new Node(5);
			node10.left.left.left = new Node(7);
			node10.right.right = new Node(6);
			node10.right.right.left = new Node(8);
			//Console.WriteLine("The inorder traversal of original tree is : ");
			//Inorder(node10);
			//RemoveAllNodesWithLengthSmallerThanK(node10, 4, null, null, 0);
			//Console.WriteLine("");
			//Console.WriteLine("The inorder traversal of modified tree is : ");
			//Inorder(node10);

			//Inorder(RemoveAllNodesWithLengthSmallerThanKGFG(node10, 1, 4));

			/**
			 * 	Print all nodes that are at distance k from a leaf node.
			 */
			// PrintAllNodesAtDistanceKFromALeaf(node10, 1, 1);

			/**
			 * 	Serialize and deserialize an N-ary tree.
			 */
			NTree nTree = new NTree("A");
			nTree.children = new NTree[] {
				new NTree("B"),
				new NTree("C"),
				new NTree("D")
			};

			nTree.children[0].children = new NTree[]
			{
			new NTree("E"),
			new NTree("F")
			};

			nTree.children[2].children = new NTree[]
			{
			new NTree("G"),
			new NTree("H"),
			new NTree("I"),
			new NTree("J")
			};

			nTree.children[0].children[1].children = new NTree[]
			{
			new NTree("K")
			};

			//	SerializeAndDeserializeNaryTree(nTree);
			// SerializeAndDeserializeNaryTreeRec(nTree, 4);

			/**
			 * 	Reverse alternate levels of a perfect Binary Tree.
			 */
			//				34
			//		  23		 76
			//    32	  56   45   13

			// After reverse
			//				34
			//		  76		 23
			//    32	  56   45   13
			// Inorder - 32 76 56 34 45 23 13
			// Inorder(ReverseAlternateLevelsOfAPerfectBinaryTree(node4, node4, -1));


			/**
			 * Construct BTree From Its LinkedList Representation
			 * */
			LinkedList<Node> linkedList = new LinkedList<Node>();
			linkedList.AddFirst(new Node(36));
			linkedList.AddFirst(new Node(30));
			linkedList.AddFirst(new Node(25));
			linkedList.AddFirst(new Node(15));
			linkedList.AddFirst(new Node(12));
			linkedList.AddFirst(new Node(10));

			// Inorder(ConstructBTreeFromItsLinkedListRepresentation(linkedList));

			/**
			 * 	Find next right nodes of given leafs in a binary tree.
			 */
			//				34
			//		  23		 76
			//    32	  56   45   13
			// Console.WriteLine(FindNextRightNodesofGivenLeafsInABinaryTree(node4, 56).key);

			/*
			 * 	Given a binary tree, print boundary nodes of the binary tree Anti-Clockwise starting from the root.
			 */
			// Reccursive  -  https://www.geeksforgeeks.org/boundary-traversal-of-binary-tree/
			// Output 34 23 32 56 45 13 76
			// PrintBoundaryNodesOfBTreeAntiClockWiseFromRoot(node4);
			//Console.WriteLine();
			/// Node9
			///           1
			///      2        3
			///         4
			///             5
			///                 6
			///     Output  1 2 4 5 6 3
			//  PrintBoundaryNodesOfBTreeAntiClockWiseFromRoot(node9);

			/**
			 * 	Convert a given tree to its sum tree.
			 */
			//				10
			//			  /	  \
			//          -2     6
			//          /  \   /  \ 
			//         8 - 4  7    5
			// Output -  0 4 0 20 0 12 0
			Node node11 = new Node(10);
			node11.left = new Node(-2);
			node11.right = new Node(6);
			node11.left.left = new Node(8);
			node11.left.right = new Node(-4);
			node11.right.left = new Node(7);
			node11.right.right = new Node(5);
			//ConvertAGivenTreeToItsSumTree(node11);
			//Inorder(node11);

			/**
			 * 	Given a binary tree, find out if the tree can be folded or not.
			 */
			//Console.WriteLine(isFoldable(node11));
			//Console.WriteLine(isFoldable(node9));

		}

		/**
		 * Insert in a tree
		 */
		public Node Insert(Node root, int data)
		{
			if (root == null)
			{
				root = new Node(data);
				return root;
			}
			Queue<Node> queue = new Queue<Node>();
			queue.Enqueue(root);

			while (queue.Count != 0)
			{
				root = queue.Peek();
				queue.Dequeue();

				if (root.left == null)
				{
					root.left = new Node(data);
					break;
				}
				else
				{
					queue.Enqueue(root.left);
				}

				if (root.right == null)
				{
					root.right = new Node(data);
					break;
				}
				else
				{
					queue.Enqueue(root.right);
				}

			}
			return root;

		}

		/**
		 * Delete a node of a tree
		 */
		public Node Delete(Node root, int data)
		{
			if (root == null)
			{
				return null;
			}

			if (root.key == data && root.left == null && root.right == null)
			{
				root = null;
				return root;
			}

			Queue<Node> queue = new Queue<Node>();
			queue.Enqueue(root);

			Node deleteNode = null, temp = null;

			while (queue.Count != 0)
			{
				temp = queue.Peek();
				queue.Dequeue();

				if (temp.key == data)
				{
					deleteNode = temp;
				}
				if (temp.left != null)
				{
					queue.Enqueue(temp.left);
				}
				if (temp.right != null)
				{
					queue.Enqueue(temp.right);
				}
			}
			if (deleteNode != null)
			{
				deleteNode.key = temp.key;
				deleteDeepest(root, temp);
			}

			return root;
		}
		private void deleteDeepest(Node root, Node nodeToDelete)
		{
			Queue<Node> queue = new Queue<Node>();
			queue.Enqueue(root);

			while (queue.Count != 0)
			{
				Node temp = queue.Peek();
				queue.Dequeue();

				if (temp == nodeToDelete)
				{
					temp = null;
				}
				if (temp.left != null)
				{
					if (temp.left == nodeToDelete)
					{
						temp.left = null;
					}
					else
					{
						queue.Enqueue(temp.left);
					}
				}
				if (temp.right != null)
				{
					if (temp.right == nodeToDelete)
					{
						temp.right = null;
					}
					else
					{
						queue.Enqueue(temp.right);
					}
				}
			}
		}

		/**
		 * Is a continous tree
		 */
		public bool isAContinousTree(Node node)
		{
			if (node == null)
			{
				return true;
			}
			else if (node.left == null && node.right == null)
			{
				return true;
			}
			else if (node.left == null && node.right != null)
			{
				return (Math.Abs(node.key - node.right.key) == 1) && isAContinousTree(node.right);
			}
			else if (node.right == null && node.left != null)
			{
				return (Math.Abs(node.key - node.left.key) == 1) && isAContinousTree(node.left);
			}
			else
			{
				return (Math.Abs(node.key - node.right.key) == 1) && (Math.Abs(node.key - node.left.key) == 1) && isAContinousTree(node.left) && isAContinousTree(node.right);
			}
		}

		/**
		 * Is a foldable tree
		 * *
		 */
		public bool isFoldableByCovertingOneSubTreeToMirror(Node node)
		{
			if (node == null)
			{
				return true;
			}

			mirror(node.left);

			bool isFoldable = isStructSame(node.left, node.right);

			mirror(node.right);

			return isFoldable;
		}
		private bool isStructSame(Node left, Node right)
		{
			if (left == null && right == null)
			{
				return true;
			}
			else if (left != null && right != null)
			{
				return isStructSame(left.left, right.left) && isStructSame(left.right, right.right);
			}
			else
			{
				return false;
			}
		}
		private void mirror(Node node)
		{
			if (node == null)
			{
				return;
			}
			Node temp = null;

			mirror(node.left);
			mirror(node.right);

			temp = node.left;
			node.left = node.right;
			node.right = temp;
		}


		/**
		 * Print Inorder
		*/


		/**
		 * Inorder traversal without recursion
		 */
		public void inorderTraversalWithoutRecursion(Node current)
		{
			Stack<Node> stack = new Stack<Node>();
			while (current != null || stack.Count > 0)
			{
				while (current != null)
				{
					stack.Push(current);
					current = current.left;
				}

				current = stack.Pop();

				Console.WriteLine(current.key);

				current = current.right;
			}
		}

		/**
		 * Inorder traversal without stack and recursion 
		 */
		public void inorderTraversalWithoutRecursionAndStack(Node node)
		{
			Node curr = node;
			while (curr != null)
			{
				if (curr.left == null)
				{
					Console.WriteLine(curr.key + " ");
					curr = curr.right;
				}
				else
				{
					Node pre = curr.left;
					while (pre.right != null && pre.right != curr)
					{
						pre = pre.right;
					}

					if (pre.right == null)
					{
						pre.right = curr;
						curr = curr.left;
					}

					if (pre.right == curr)
					{
						pre.right = null;
						Console.WriteLine(curr.key);
						curr = curr.right;
					}
				}
			}
		}

		/**
		 * Print post order traversal from inorder and pre order
		 */
		public void printPostOrderFromInOrderAndPreOrder(int[] inorder, int[] preorder, int n)
		{
			int rootindex = searchForRootIndexInInorder(inorder, preorder[0], n);

			// print left subtree  
			int[] ar;
			if (rootindex != 0)
			{
				ar = new int[n - 1];
				Array.Copy(preorder, 1, ar, 0, n - 1);
				printPostOrderFromInOrderAndPreOrder(inorder, ar, rootindex);
			}

			int[] ar1;
			if (rootindex != n - 1)
			{
				ar1 = new int[n - (rootindex + 1)];
				Array.Copy(inorder, rootindex + 1, ar1, 0, n - (rootindex + 1));
				ar = new int[n - (rootindex + 1)];
				Array.Copy(preorder, rootindex + 1, ar, 0, n - (rootindex + 1));

				printPostOrderFromInOrderAndPreOrder(ar1, ar, n - (rootindex + 1));
			}

			Console.WriteLine(inorder[rootindex]);
		}

		private int searchForRootIndexInInorder(int[] inorder, int root, int n)
		{
			int index = -1;
			for (int i = 0; i < n; i++)
			{
				if (inorder[i] == root)
				{
					index = i;
				}
			}
			return index;
		}

		/*
		 * Print all possible trees from inorder
		 * */
		public int printAllPossibleTreesFromInorder(int[] pre, int n)
		{
			if (n <= 1)
			{
				return 1;
			}

			int sum = 0;
			for (int i = 1; i <= n; i++)
			{
				int left = printAllPossibleTreesFromInorder(pre, i - 1);
				int right = printAllPossibleTreesFromInorder(pre, n - i);
				sum += left * right;
			}
			return sum;
		}

		/**
		 * Replace node with sum of its inorder predecessor and successor
		*/
		public Node replaceNodeWithSumOfItsInorderPredessorAndSuccessor(Node root)
		{
			int[] inorderArr = GetInorderArray(root, new List<int>());
			int[] sumArr = new int[inorderArr.Length];

			for (int i = 0; i < inorderArr.Length; i++)
			{

				int pred = 0, succ = 0;
				if (i - 1 >= 0)
				{
					pred = inorderArr[i - 1];
				}
				if ((i + 1) < inorderArr.Length)
				{
					succ = inorderArr[i + 1];
				}

				sumArr[i] = pred + succ;
			}
			return updateBTreeFromInOrder(root, sumArr, new Indexer());
		}
		private Node updateBTreeFromInOrder(Node root, int[] inorder, Indexer index)
		{
			if (root == null)
			{
				return root;
			}
			updateBTreeFromInOrder(root.left, inorder, index);
			root.key = inorder[index.index++];
			updateBTreeFromInOrder(root.right, inorder, index);

			return root;
		}
		private int[] GetInorderArray(Node root, List<int> arr)
		{
			if (root == null)
			{
				return new int[] { };
			}
			GetInorderArray(root.left, arr);
			arr.Add(root.key);
			GetInorderArray(root.right, arr);

			return arr.ToArray();
		}

		/**
		 * Replace node with sum of its inorder predecessor and successor
		*/
		public Node replaceNodeWithSumOfItsInorderPredessorAndSuccessor2(Node root)
		{
			List<int> inorderArr = new List<int>();
			inorderArr.Add(0);
			CreateInorderFromList(root, inorderArr);
			inorderArr.Add(0);

			return replaceRootWithSum(root, inorderArr, new Indexer() { index = 1 });
		}

		private Node replaceRootWithSum(Node root, List<int> inorder, Indexer index)
		{
			if (root == null)
			{
				return null;
			}
			if (index.index < inorder.Count - 1)
			{
				replaceRootWithSum(root.left, inorder, index);
				root.key = inorder[index.index - 1] + inorder[index.index + 1];
				index.index++;
				replaceRootWithSum(root.right, inorder, index);
			}
			return root;
		}
		private void CreateInorderFromList(Node root, List<int> inorder)
		{
			if (root == null)
			{
				return;
			}
			CreateInorderFromList(root.left, inorder);
			inorder.Add(root.key);
			CreateInorderFromList(root.right, inorder);
		}

		/**
		 * Add inorder successor to each node
		 */
		public void addInorderSuccessorToNode(NodeWithNext node, Indexer index)
		{
			if (node != null)
			{
				addInorderSuccessorToNode(node.right, index);

				node.next = index.next;

				index.next = node;

				addInorderSuccessorToNode(node.left, index);

			}
		}

		/**
		 * Inorder succesor of a node
		 */
		public void findInorderSuccessorOfANode(Node root, Indexer index, int data)
		{
			if (root != null)
			{
				findInorderSuccessorOfANode(root.right, index, data);
				if (root.key == data)
				{
					index.index = index.data;
				}
				else
				{
					index.data = root.key;
					findInorderSuccessorOfANode(root.left, index, data);
				}
			}
		}

		/**
		 * Level order traversal BTree
		*/
		public void levelOrderTraversalBTree(Node node)
		{
			Queue<Node> queue = new Queue<Node>();
			queue.Enqueue(node);

			while (queue.Count > 0)
			{
				Node root = queue.Dequeue();

				Console.WriteLine(root.key);
				if (root.left != null)
				{
					queue.Enqueue(root.left);
				}

				if (root.right != null)
				{
					queue.Enqueue(root.right);
				}
			}
		}

		/**
		 * Level order traversal BTree in spiral
		*/
		public void levelOrderTraversalBTreeSpiral(Node node)
		{
			var height = calHeight(node);
			bool itr = false;
			for (int i = 1; i <= height; i++)
			{
				printLevelOrderTraversalBTreeSpiral(node, i, itr);
				itr = !itr;
				Console.WriteLine();
			}
		}

		public void printLevelOrderTraversalBTreeSpiral(Node node, int level, bool itr)
		{
			if (node == null)
			{
				return;
			}

			if (level == 1)
			{
				Console.Write(node.key + " ");
			}
			else if (itr)
			{
				printLevelOrderTraversalBTreeSpiral(node.left, level - 1, itr);
				printLevelOrderTraversalBTreeSpiral(node.right, level - 1, itr);
			}
			else if (!itr)
			{
				printLevelOrderTraversalBTreeSpiral(node.right, level - 1, itr);
				printLevelOrderTraversalBTreeSpiral(node.left, level - 1, itr);
			}


		}
		private int calHeight(Node node)
		{
			if (node == null)
			{
				return 0;
			}

			int leftHeight = calHeight(node.left);
			int rightHeight = calHeight(node.right);

			return Math.Max(leftHeight, rightHeight) + 1;
		}

		public void levelOrderTraversalBTreeSpiralUsingStack(Node node)
		{
			Stack<Node> stack1 = new Stack<Node>();
			Stack<Node> stack2 = new Stack<Node>();

			stack1.Push(node);

			while (stack1.Count > 0 || stack2.Count > 0)
			{

				while (stack1.Count > 0)
				{
					Node n = stack1.Pop();
					Console.Write(n.key + " ");
					if (n.left != null)
					{
						stack2.Push(n.left);

					}
					if (n.right != null)
					{
						stack2.Push(n.right);
					}
				}

				Console.WriteLine();

				while (stack2.Count > 0)
				{
					Node n = stack2.Pop();
					Console.Write(n.key + " ");
					if (n.left != null)
					{
						stack1.Push(n.left);

					}
					if (n.right != null)
					{
						stack1.Push(n.right);
					}
				}
				Console.WriteLine();
			}
		}

		/**
		 * Convert a binary tree into its mirror tree
		 */
		public Node ConvertBinaryTreeToMirrorTree(Node node)
		{
			if (node == null)
			{
				return null;
			}
			//Node temp = node.left;

			//node.left = ConvertBinaryTreeToMirrorTree(node.right);
			//node.right = ConvertBinaryTreeToMirrorTree(temp);

			Node left = ConvertBinaryTreeToMirrorTree(node.left);
			Node right = ConvertBinaryTreeToMirrorTree(node.right);

			node.left = right;
			node.right = left;

			return node;

		}
		public Node ConvertBinaryTreeToMirrorTreeIterative(Node node)
		{
			Queue<Node> queue = new Queue<Node>();
			queue.Enqueue(node);

			while (queue.Count > 0)
			{
				Node root = queue.Dequeue();

				Node temp = root.left;
				root.left = root.right;
				root.right = temp;

				if (root.left != null)
				{
					queue.Enqueue(root.left);
				}

				if (root.right != null)
				{
					queue.Enqueue(root.right);
				}
			}
			return node;
		}

		/**
		 * Check if binary tree is a sum tree
		 */
		public int CheckIfBinaryTreeIsSumTree(Node node, Indexer indexer)
		{
			int leftSum = 0;
			int rightSum = 0;

			if (node == null)
			{
				return 0;
			}

			if (indexer.isTrue)
			{
				leftSum = CheckIfBinaryTreeIsSumTree(node.left, indexer);
				rightSum = CheckIfBinaryTreeIsSumTree(node.right, indexer);
			}
			int sum = leftSum + rightSum;
			if (node.left == null && node.right == null)
			{
				sum = node.key;
			}
			else if (node.left != null && node.right == null)
			{
				sum = node.left.key + node.key;
			}
			else if (node.left == null && node.right != null)
			{
				sum = node.right.key + node.key;
			}

			if (leftSum + rightSum == node.key)
			{
				indexer.isTrue = true;
			}

			return sum;
		}
		public bool CheckIfBinaryTreeIsSumTreeGFG(Node node)
		{
			int ls = 0;
			int rs = 0;

			if (node == null || (node.left == null && node.right == null))
			{
				return true;
			}

			ls = sum(node.left);
			rs = sum(node.right);

			if (ls + rs == node.key && CheckIfBinaryTreeIsSumTreeGFG(node.left) && CheckIfBinaryTreeIsSumTreeGFG(node.right))
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		public int CheckIfBinaryTreeIsSumTreeOrderN(Node node)
		{
			if (node == null)
			{
				return 0;
			}

			if (node.left == null && node.right == null)
			{
				return node.key;
			}

			if (node.key == CheckIfBinaryTreeIsSumTreeOrderN(node.left) + CheckIfBinaryTreeIsSumTreeOrderN(node.right))
			{
				return 2 * node.key;
			}

			return Int32.MinValue;
		}
		int sum(Node node)
		{
			if (node == null)
			{
				return 0;
			}
			return sum(node.left) + sum(node.right) + node.key;
		}

		/*
		 * Lowest common ancestor of a binary tree
		 */
		public Node lowestCommonAncestorOfBTree(Node root, int key1, int key2)
		{
			if (root == null) return null;

			if (root.key == key1 || root.key == key2) return root;


			Node left = lowestCommonAncestorOfBTree(root.left, key1, key2);
			Node right = lowestCommonAncestorOfBTree(root.right, key1, key2);

			if (left == null && right == null) return null;

			if (left != null && right != null) return root;

			return left != null ? left : right;

		}

		/**
		 * Convert BTree to children sum
		 */
		public void ConvertBTreeToChildrenSum(Node node)
		{
			int leftDiff = 0; int rightDiff = 0;
			if (node == null || (node.left == null && node.right == null))
			{
				return;
			}
			ConvertBTreeToChildrenSum(node.left);
			ConvertBTreeToChildrenSum(node.right);

			if (node.left != null)
			{
				leftDiff = node.left.key;
			}
			if (node.right != null)
			{
				rightDiff = node.right.key;
			}
			int diff = leftDiff + rightDiff - node.key;

			if (diff > 0)
			{
				node.key = diff + node.key;
			}
			else
			{
				increment(node, -diff);
			}
		}
		private void increment(Node node, int diff)
		{
			if (node.left != null)
			{
				node.left.key = node.left.key + diff;
				increment(node.left, diff);
			}
			else if (node.right != null)
			{
				node.right.key = node.right.key + diff;
				increment(node.right, diff);
			}
		}

		/**
		 * Construct BTree from preorder and inorder
		 */
		public Node ConstructBTreeFromPreorderAndInorder(int[] preorder, int preLow, int preHigh, int[] inorder, int inLow, int inHigh)
		{
			if (preLow > preHigh || inLow > inHigh)
			{
				return null;
			}
			int rootIndexInInorder = searchInorder(preorder[preLow], inorder, inLow, inHigh);
			int sizeOfLeftSubTreeInorder = rootIndexInInorder - inLow;
			int sizeOfRightSubTreeInorder = inHigh - rootIndexInInorder;

			Node node = new Node(preorder[preLow]);

			node.right = ConstructBTreeFromPreorderAndInorder(preorder, preLow + sizeOfLeftSubTreeInorder + 1, preLow + sizeOfLeftSubTreeInorder + sizeOfRightSubTreeInorder,
				inorder, rootIndexInInorder + 1, inHigh);

			node.left = ConstructBTreeFromPreorderAndInorder(preorder, preLow + 1, preLow + sizeOfLeftSubTreeInorder,
				inorder, inLow, rootIndexInInorder - 1);

			return node;
		}

		public Node ConstructBTreeFromPreorderAndInorderOrderN(int[] preorder, int preLow, int preHigh, int[] inorder, int inLow, int inHigh, Dictionary<int, int> keyValuePairs)
		{
			if (preLow > preHigh || inLow > inHigh)
			{
				return null;
			}
			int rootIndexInInorder = keyValuePairs[preorder[preLow]];
			int sizeOfLeftSubTreeInorder = rootIndexInInorder - inLow;
			int sizeOfRightSubTreeInorder = inHigh - rootIndexInInorder;

			Node node = new Node(preorder[preLow]);

			node.right = ConstructBTreeFromPreorderAndInorder(preorder, preLow + sizeOfLeftSubTreeInorder + 1, preLow + sizeOfLeftSubTreeInorder + sizeOfRightSubTreeInorder,
				inorder, rootIndexInInorder + 1, inHigh);

			node.left = ConstructBTreeFromPreorderAndInorder(preorder, preLow + 1, preLow + sizeOfLeftSubTreeInorder,
				inorder, inLow, rootIndexInInorder - 1);

			return node;
		}

		int searchInorder(int val, int[] inorder, int lowInorder, int highInorder)
		{
			for (int i = lowInorder; i <= highInorder; i++)
			{
				if (val == inorder[i]) return i;
			}
			return -1;
		}

		/**
		 *  Convert BTree into circular doubly linked list
		 */
		public void ConvertBTreeToCircularDoublyLinkeList(Node root, ref Node prev, ref Node head)
		{
			if (root == null) return;

			ConvertBTreeToCircularDoublyLinkeList(root.left, ref prev, ref head);

			root.left = prev;

			if (prev != null)
			{
				prev.right = root;
			}
			else
			{
				head = root;
			}

			Node right = root.right;

			head.left = root;
			root.right = head;

			prev = root;

			ConvertBTreeToCircularDoublyLinkeList(right, ref prev, ref head);
		}

		private void printCircularLinkedList(Node head)
		{
			Node itr = head;
			do
			{
				Console.Write(itr.key + " ");
				itr = itr.right;
			} while (itr.key != head.key);
		}

		public Node ConvertBTreeToCircularDoublyLinkeListGFG(Node root)
		{
			if (root == null) return root;

			Node left = ConvertBTreeToCircularDoublyLinkeListGFG(root.left);
			Node right = ConvertBTreeToCircularDoublyLinkeListGFG(root.right);

			root.left = root.right = root;

			return concateLeftAndRightSubTrees(concateLeftAndRightSubTrees(left, root), right);

		}

		private Node concateLeftAndRightSubTrees(Node leftSubtree, Node rightSubtree)
		{
			if (leftSubtree == null) return rightSubtree;
			if (rightSubtree == null) return leftSubtree;

			Node leftSubTreeEnd = leftSubtree.left;
			Node rightSubTreeEnd = rightSubtree.left;

			leftSubTreeEnd.right = rightSubtree;
			rightSubtree.left = leftSubTreeEnd;

			leftSubtree.left = rightSubTreeEnd;
			rightSubTreeEnd.right = leftSubtree;

			return leftSubtree;
		}

		/***
		 * Construction of expression tree
		 */
		public ExpNode ConstructExpressionTree(char[] charArray)
		{
			Stack<ExpNode> stack = new Stack<ExpNode>();

			for (int i = 0; i < charArray.Length; i++)
			{
				var item = charArray[i];
				ExpNode node = new ExpNode(item);
				if (!Char.IsLetterOrDigit(item))
				{
					ExpNode right = stack.Pop();
					ExpNode left = stack.Pop();

					node.left = left;
					node.right = right;
					stack.Push(node);
				}
				else
				{
					stack.Push(node);
				}
			}

			return stack.Pop();
		}

		/***
		 * Evaluation of expression tree
		 */
		public double EvaluateExpressionTree(ExprNode node)
		{
			if (node == null)
			{
				return 0;
			}

			if (node.left == null && node.right == null)
			{
				var c = Int32.Parse(node.key);
				return c;
			}

			double leftSum = EvaluateExpressionTree(node.left);
			double rightSum = EvaluateExpressionTree(node.right);

			if (node.key == "*")
			{
				return leftSum * rightSum;
			}
			else if (node.key == "+")
			{
				return leftSum + rightSum;
			}
			else if (node.key == "/")
			{
				return leftSum / rightSum;
			}
			else
			{
				return leftSum - rightSum;
			}
		}

		/**
		* Print extreme node of each level of Binary Tree in alternative order
		*/
		public void PrintExtremeNodeOfEacchLevvelInAlternativeOrderUsingStack(Node node)
		{
			Stack<Node> stack1 = new Stack<Node>();
			Stack<Node> stack2 = new Stack<Node>();

			stack1.Push(node);

			while (stack1.Count > 0 || stack2.Count > 0)
			{
				Node firstNode = null;
				Node lastNode = null;

				if (stack1.Count > 0)
				{
					firstNode = stack1.Peek();

					if (firstNode != null)
					{
						Console.Write(firstNode.key + " ");
					}

					while (stack1.Count > 0)
					{
						lastNode = stack1.Pop();
						if (lastNode.left != null)
						{
							stack2.Push(lastNode.left);
						}
						if (lastNode.right != null)
						{
							stack2.Push(lastNode.right);
						}
					}
				}

				Console.WriteLine();


				if (stack2.Count > 0)
				{
					lastNode = null;
					firstNode = stack2.Peek();
					if (firstNode != null)
					{
						Console.Write(firstNode.key + " ");
					}
					while (stack2.Count > 0)
					{
						lastNode = stack2.Pop();
						if (lastNode.right != null)
						{
							stack1.Push(lastNode.right);
						}
						if (lastNode.left != null)
						{
							stack1.Push(lastNode.left);
						}
					}
					Console.WriteLine();
				}
			}
		}
		public void PrintExtremeNodeOfEacchLevvelInAlternativeOrderUsingQueue(Node node)
		{
			Queue<Node> queue = new Queue<Node>();
			queue.Enqueue(node);
			bool isAltEnd = true;

			while (queue.Count > 0)
			{

				int nodeCount = queue.Count;
				int n = nodeCount;

				while (n-- > 0)
				{
					Node curr = queue.Peek();

					if (curr.left != null)
					{
						queue.Enqueue(curr.left);
					}

					if (curr.right != null)
					{
						queue.Enqueue(curr.right);
					}

					queue.Dequeue();

					if (isAltEnd && n == nodeCount - 1)
					{
						Console.Write(curr.key + " ");
					}

					if (!isAltEnd && n == 0)
					{
						Console.Write(curr.key + " ");
					}
				}
				isAltEnd = !isAltEnd;
				Console.WriteLine();
			}
		}

		/**
		 * Print cousins of a given node in Binary Tree
		*/
		public void PrintCousinsOfABinaryTree(Node root, int nodeKey)
		{
			if (root.key == nodeKey)
			{
				Console.WriteLine("No Cousin");
				return;
			}

			Queue<Node> queue = new Queue<Node>();

			queue.Enqueue(root);
			bool isFound = false;

			while (queue.Count > 0 && !isFound)
			{
				int n = queue.Count;
				Queue<Node> cousinQueue = new Queue<Node>();

				while (n-- > 0)
				{
					Node curr = queue.Peek();

					if (curr.left != null)
					{
						queue.Enqueue(curr.left);

						if (curr.left.key == nodeKey)
						{
							isFound = true;
						}
					}

					if (curr.right != null)
					{
						queue.Enqueue(curr.right);

						if (curr.right.key == nodeKey)
						{
							isFound = true;
						}
					}

					if (!isFound)
					{
						if (curr.left != null)
							cousinQueue.Enqueue(curr.left);

						if (curr.right != null)
							cousinQueue.Enqueue(curr.right);
					}

					queue.Dequeue();

				}

				if (isFound)
				{
					if (cousinQueue.Count == 0)
					{
						Console.WriteLine("No cousins");
						return;
					}
					while (cousinQueue.Count > 0)
					{
						Console.Write(cousinQueue.Dequeue().key + " ");
					}
				}

			}
		}

		public void PrintCousinsOfABinaryTreeRec(Node root, int nodeKey)
		{
			int level = getLevel(root, nodeKey, 1);
			PrintCousinsOfABinaryTreeRec(root, nodeKey, level);
		}

		private void PrintCousinsOfABinaryTreeRec(Node root, int nodeKey, int level)
		{
			if (root == null || level < 2)
			{
				return;
			}

			if (level == 2)
			{
				if ((root.left != null && root.left.key == nodeKey) || (root.right != null && root.right.key == nodeKey))
				{
					return;
				}
				if (root.left != null)
				{
					Console.WriteLine(root.left.key + " ");
				}
				if (root.right != null)
				{
					Console.WriteLine(root.right.key + " ");
				}
			}

			if (level > 2)
			{
				PrintCousinsOfABinaryTreeRec(root.left, nodeKey, level - 1);
				PrintCousinsOfABinaryTreeRec(root.right, nodeKey, level - 1);
			}
		}

		private int getLevel(Node root, int nodeKey, int level)
		{
			if (root == null)
			{
				return 0;
			}
			if (root.key == nodeKey)
			{
				return level;
			}
			int foundLevel = getLevel(root.left, nodeKey, level + 1);
			if (foundLevel != 0)
			{
				return foundLevel;
			}
			return getLevel(root.right, nodeKey, level + 1);
		}

		/**
		 * Print diagnoal traversal of binary tree
		 */
		public void DiagnoalTraversalOfBinaryTree(Node node)
		{
			Queue<Node> queue = new Queue<Node>();

			queue.Enqueue(node);
			queue.Enqueue(null);

			while (queue.Count > 0)
			{
				Node curr = queue.Dequeue();

				if (curr == null)
				{
					Console.WriteLine();
					queue.Enqueue(null);
					curr = queue.Dequeue();

					if (curr == null) break;
				}

				while (curr != null)
				{
					if (curr.left != null)
					{
						queue.Enqueue(curr.left);
					}
					Console.Write(curr.key + " ");
					curr = curr.right;
				}
			}
		}

		/**
		* Construct tree from ancestor matrix
		*/
		public Node ConstructTreeFromAncestorMatrix(int[,] ancestorMatrix)
		{
			Node root = null;
			List<Node> unlist = new List<Node>();
			for (int i = 0; i < ancestorMatrix.GetLength(0); i++)
			{
				for (int j = 0; j < ancestorMatrix.GetLength(1); j++)
				{
					if (ancestorMatrix[i, j] == 1)
					{
						if (root == null)
						{
							root = new Node(i);
						}

						Node ancestor = checkIfNodeExist(root, i);
						if (ancestor == null)
						{
							ancestor = unlist.Where(x => x.key == i).FirstOrDefault();

							if (ancestor == null)
							{
								ancestor = new Node(i);
								unlist.Add(ancestor);

							}
						}

						Node child = checkIfNodeExist(root, j);
						if (child == null)
						{
							child = unlist.Where(x => x.key == j).FirstOrDefault();

							if (child == null)
							{
								child = new Node(j);
								unlist.Add(child);
							}
						}

						if (ancestor.left == null)
						{
							ancestor.left = child;
						}
						else
						{
							ancestor.right = child;
						}
						if (j == root.key)
						{
							root = ancestor;
						}
					}
				}
			}
			return root;
		}
		private Node checkIfNodeExist(Node root, int key)
		{
			if (root == null) { return new Node(key); };

			if (root.key == key) { return root; }

			Queue<Node> queue = new Queue<Node>();
			queue.Enqueue(root);
			Node curr = null;
			bool isFound = false;
			while (queue.Count > 0)
			{
				curr = queue.Dequeue();
				if (curr.left != null)
				{
					if (curr.left.key == key)
					{
						curr = curr.left;
						isFound = true;
						break;
					}
					queue.Enqueue(curr.left);
				}
				if (curr.right != null)
				{
					if (curr.right.key == key)
					{
						curr = curr.right;
						isFound = true;
						break;
					}
					queue.Enqueue(curr.right);
				}
			}


			return isFound ? curr : null;

		}

		/**
		 * 	Given a Binary Tree, find vertical sum of the nodes that are in same vertical line.
		 */
		public void FindVerticalSum(Node node)
		{
			SortedDictionary<int, int> hm = new SortedDictionary<int, int>();
			verticalSumUtil(node, 0, hm);
			int index = 0;
			foreach (var item in hm)
			{
				index++;
				Console.WriteLine("Vertical line " + index + ": sum = " + item.Value);
			}
		}
		private void verticalSumUtil(Node node, int hd, SortedDictionary<int, int> hm)
		{
			if (node == null) return;

			verticalSumUtil(node.left, hd - 1, hm);

			if (hm.ContainsKey(hd))
			{
				hm[hd] = hm[hd] + node.key;
			}
			else
			{
				hm.Add(hd, node.key);
			}

			verticalSumUtil(node.right, hd + 1, hm);

		}

		public void FindVerticalSumWithoutExtraSpace(Node root)
		{
			// Create a doubly linked list node to  
			// store sum of lines going through root.  
			// Vertical sum is initialized as 0.  
			LLNode llnode = new LLNode(0);

			// Compute vertical sum of different lines  
			FindVerticalSumWithoutExtraSpaceUtil(root, llnode);

			// llnode refers to sum of vertical line  
			// going through root. Move llnode to the  
			// leftmost line.  
			while (llnode.prev != null)
			{
				llnode = llnode.prev;
			}

			// Prints vertical sum of all lines  
			// starting from leftmost vertical line  
			while (llnode != null)
			{
				Console.Write(llnode.data + " ");
				llnode = llnode.next;
			}
		}
		private void FindVerticalSumWithoutExtraSpaceUtil(Node tnode, LLNode llnode)
		{
			// Add current node's data to  
			// its vertical line  
			llnode.data = llnode.data + tnode.key;

			// Recursively process left subtree  
			if (tnode.left != null)
			{
				if (llnode.prev == null)
				{
					llnode.prev = new LLNode(0);
					llnode.prev.next = llnode;
				}
				FindVerticalSumWithoutExtraSpaceUtil(tnode.left, llnode.prev);
			}

			// Process right subtree  
			if (tnode.right != null)
			{
				if (llnode.next == null)
				{
					llnode.next = new LLNode(0);
					llnode.next.prev = llnode;
				}
				FindVerticalSumWithoutExtraSpaceUtil(tnode.right, llnode.next);
			}
		}

		/**
		* Find multiplication of sums of data of leaves at same level.
		*/
		public int MultiplicationOfSumsOfDataOfLeavesAtSameLevel(Node node)
		{
			Queue<Node> queue = new Queue<Node>();
			queue.Enqueue(node);
			int result = 1;

			while (queue.Count > 0)
			{
				int n = queue.Count;
				int sum = 0;
				while (n-- > 0)
				{
					Node curr = queue.Dequeue();

					if (curr.left == null && curr.right == null)
					{
						sum += curr.key;
					}

					if (curr.left != null)
					{
						queue.Enqueue(curr.left);
					}

					if (curr.right != null)
					{
						queue.Enqueue(curr.right);
					}
				}

				if (sum > 0)
				{
					result *= sum;
				}
			}

			return result;

		}

		/**
		 * 	Given a binary tree, find maximum value we can get by subtracting value of node B from value of node A
		*/
		public int MaximumSubtractedValueOfTwoNodes(Node node)
		{
			int max = Int32.MinValue;
			int min = Int32.MaxValue;

			MaximumSubtractedValueOfTwoNodesUtil(node, ref min, ref max);

			return max - min;
		}
		private void MaximumSubtractedValueOfTwoNodesUtil(Node node, ref int min, ref int max)
		{
			if (node == null) return;

			if (node.key > max)
			{
				max = node.key;
			}

			if (node.key < min)
			{
				min = node.key;
			}

			MaximumSubtractedValueOfTwoNodesUtil(node.left, ref min, ref max);

			MaximumSubtractedValueOfTwoNodesUtil(node.right, ref min, ref max);
		}

		/**
		 * Print nodes in top view of binary tree
		 */
		public void PrintNodesInTopView(Node node)
		{
			Queue<Node> queue = new Queue<Node>();
			queue.Enqueue(node);
			List<Node> lod = new List<Node>();

			// Level order traversal
			while (queue.Count > 0)
			{
				Node curr = queue.Dequeue();
				lod.Add(curr);

				if (curr.left != null) queue.Enqueue(curr.left);
				if (curr.right != null) queue.Enqueue(curr.right);
			}

			// Vertical Order traversal
			Dictionary<int, List<Node>> vod = new Dictionary<int, List<Node>>();
			verticalOrderTraversal(node, 0, vod);

			foreach (var item in vod)
			{
				if (item.Value.Count == 1)
				{
					Console.Write(item.Value[0].key + " ");
				}
				else if (item.Value.Count > 0)
				{
					foreach (var n in lod)
					{
						if (item.Value.Any(p => p.key == n.key))
						{
							Console.Write(n.key + " ");
							break;
						};
					}
				}
			}


		}
		private void verticalOrderTraversal(Node node, int hd, Dictionary<int, List<Node>> dictionary)
		{
			if (node == null) return;

			if (dictionary.ContainsKey(hd))
			{
				dictionary[hd].Add(node);
			}
			else
			{
				dictionary.Add(hd, new List<Node>() { node });
			}

			verticalOrderTraversal(node.left, hd - 1, dictionary);
			verticalOrderTraversal(node.right, hd + 1, dictionary);
		}
		public void PrintNodesInTopViewOrderN(Node node)
		{
			Queue<QuequeObj> queue = new Queue<QuequeObj>();
			SortedDictionary<int, QuequeObj> keyValuePairs = new SortedDictionary<int, QuequeObj>();
			int hd = 0;
			queue.Enqueue(new QuequeObj(node, hd));

			while (queue.Count > 0)
			{
				QuequeObj curr = queue.Dequeue();

				if (!keyValuePairs.ContainsKey(curr.hd))
				{
					keyValuePairs.Add(curr.hd, new QuequeObj(curr.node, curr.hd));
				}

				if (curr.node.left != null)
				{
					queue.Enqueue(new QuequeObj(curr.node.left, curr.hd - 1));
				}

				if (curr.node.right != null)
				{
					queue.Enqueue(new QuequeObj(curr.node.right, curr.hd + 1));
				}
			}

			foreach (var item in keyValuePairs)
			{
				Console.Write(item.Value.node.key + " ");
			}
		}
		public void PrintNodesInTopViewOrderNWithoutQueue(Node node)
		{
			SortedDictionary<int, TreeDataLevel> keyValuePairs = new SortedDictionary<int, TreeDataLevel>();
			PrintNodesInTopViewOrderNWithoutQueueUtil(node, 0, 0, keyValuePairs);
			foreach (var item in keyValuePairs)
			{
				Console.Write(item.Value.data + " ");
			}
		}
		private void PrintNodesInTopViewOrderNWithoutQueueUtil(Node node, int dist, int level, SortedDictionary<int, TreeDataLevel> keyValuePairs)
		{
			if (node == null) return;

			if (!keyValuePairs.ContainsKey(dist))
			{
				keyValuePairs.Add(dist, new TreeDataLevel(node.key, level));
			}
			else
			{
				if (keyValuePairs[dist].level > level)
				{
					keyValuePairs[dist] = new TreeDataLevel(node.key, level);
				}
			}

			PrintNodesInTopViewOrderNWithoutQueueUtil(node.left, dist - 1, level + 1, keyValuePairs);
			PrintNodesInTopViewOrderNWithoutQueueUtil(node.right, dist + 1, level + 1, keyValuePairs);
		}

		/**
		 * 	Given a Binary Tree and a number k, remove all nodes that lie only on root to leaf path(s) of length smaller than k.
		 */
		public void RemoveAllNodesWithLengthSmallerThanK(Node root, int k, Node parent, bool? isLeft, int h)
		{
			if (root == null) return;

			h++;
			RemoveAllNodesWithLengthSmallerThanK(root.left, k, root, true, h);
			RemoveAllNodesWithLengthSmallerThanK(root.right, k, root, false, h);

			if (h < k && root.left == null && root.right == null)
			{
				if (parent != null)
				{
					if (isLeft != null)
					{
						if (isLeft == true) parent.left = null;
						else parent.right = null;
					}
				}
			}
		}
		public Node RemoveAllNodesWithLengthSmallerThanKGFG(Node root, int level, int k)
		{
			if (root == null) return root;

			root.left = RemoveAllNodesWithLengthSmallerThanKGFG(root.left, level + 1, k);
			root.right = RemoveAllNodesWithLengthSmallerThanKGFG(root.right, level + 1, k);

			if (root.left == null && root.right == null && level < k)
			{
				return null;
			}

			return root;

		}

		/**
		 * 	Print all nodes that are at distance k from a leaf node.
		 */
		public int PrintAllNodesAtDistanceKFromALeaf(Node node, int level, int k)
		{
			if (node == null) return -1;

			int lk = PrintAllNodesAtDistanceKFromALeaf(node.left, level + 1, k);
			int rk = PrintAllNodesAtDistanceKFromALeaf(node.right, level + 1, k);

			bool isLeaf = (lk == rk && rk == -1);

			if (lk == 0 || rk == 0 || isLeaf && k == 0) Console.Write(node.key + " ");

			if (isLeaf && k > 0) return k - 1;

			if (lk > 0) return lk - 1;

			if (rk > 0) return rk - 1;

			return -2;
		}

		/**
		 * Serialize and deserialize N-ary Tree
		 */
		public void SerializeAndDeserializeNaryTree(NTree nTree)
		{
			var serializedTree = nTree.data.ToString();
			GetSearlializedNTree(nTree, ref serializedTree);
			Console.Write("Serialized Tree : ");
			Console.WriteLine(serializedTree);
			Console.Write("Deserialized Tree : ");
			PrintDeserializedTree(serializedTree);

		}
		private string GetSearlializedNTree(NTree nTree, ref string serializedTree)
		{
			if (nTree == null) return string.Empty;

			if (nTree.children == null)
			{
				serializedTree += ")";
				return serializedTree;
			}
			foreach (var child in nTree.children)
			{
				serializedTree += child.data;
				GetSearlializedNTree(child, ref serializedTree);
			}
			serializedTree += ")";

			return serializedTree;
		}
		private void PrintDeserializedTree(string serializedTree)
		{
			NTree node = new NTree(serializedTree[0].ToString());
			Stack<NTree> stack = new Stack<NTree>();
			stack.Push(node);
			Console.Write(node.data + " ");

			for (int i = 1; i < serializedTree.Length; i++)
			{
				var root = stack.Peek();

				if (char.Equals(serializedTree[i], ')'))
				{
					stack.Pop();
				}
				else
				{
					var tree = new NTree(serializedTree[i].ToString());
					if (root.children == null)
					{
						root.children = new NTree[] { tree };
					}
					else
					{
						var z = new NTree[root.children.Length + 1];
						root.children.CopyTo(z, 0);
						z[root.children.Length] = tree;
						node.children = z;
					}
					Console.Write(tree.data + " ");
					stack.Push(tree);
				}
			}
		}
		public void SerializeAndDeserializeNaryTreeRec(NTree nTree, int n)
		{
			var serializedTree = string.Empty;
			GetSearlializedNTreeRec(nTree, ref serializedTree, n);
			Console.Write("Serialized Tree : ");
			Console.WriteLine(serializedTree);
			Console.Write("Deserialized Tree : ");
			NTree root = null;
			int start = 0;
			GetDeSearlializedNTreeRec(serializedTree[0].ToString(), ref root, ref serializedTree, n, ref start);
			traverseNTree(root, n);
		}
		private void traverseNTree(NTree ntree, int n)
		{
			if (ntree == null) return;

			Console.Write(ntree.data + " ");
			for (int i = 0; i < n; i++)
			{
				var next = ntree.children != null && i < ntree.children.Length ? ntree.children[i] : null;
				traverseNTree(next, n);
			}
		}
		private void GetSearlializedNTreeRec(NTree root, ref string serializedTree, int n)
		{
			// Base case 
			if (root == null) return;

			// Else, store current node and recur for its children 
			serializedTree += root.data;

			for (int i = 0; i < n && root.children != null && i < root.children.Length; i++)
				GetSearlializedNTreeRec(root.children[i], ref serializedTree, n);

			// Store marker at the end of children 
			serializedTree += ")";
		}
		private bool GetDeSearlializedNTreeRec(string value, ref NTree nTree, ref string serializedTree, int n, ref int start)
		{
			// Read next item from file. If theere are no more items or next 
			// item is marker, then return 1 to indicate same 
			if (start >= serializedTree.Length - 1) return true;
			if (value == ")")
				return true;

			// Else create node with this item and recur for children 
			nTree = new NTree(value);
			if (nTree.children == null)
			{
				nTree.children = new NTree[] { null, null, null, null };
			}
			for (int i = 0; i < n; i++)
			{
				if (GetDeSearlializedNTreeRec(serializedTree[++start].ToString(), ref nTree.children[i], ref serializedTree, n, ref start))
					break;
			}

			// Finally return 0 for successful finish 
			return false;
		}

		/**
		 * 	Reverse alternate levels of a perfect Binary Tree. 
		 */
		public Node ReverseAlternateLevelsOfAPerfectBinaryTree(Node root1, Node root2, int level)
		{
			if (root1 == null || root2 == null)
			{
				return null;
			}

			if (level % 2 == 0)
			{
				swap(root1, root2);
			}

			ReverseAlternateLevelsOfAPerfectBinaryTree(root1.left, root2.right, level + 1);
			ReverseAlternateLevelsOfAPerfectBinaryTree(root1.right, root2.left, level + 1);
			return root1;
		}
		private void swap(Node root1, Node root2)
		{
			int root2Key = root2.key;
			root2.key = root1.key;
			root1.key = root2Key;
		}

		/*
		 * 	Construct complete binary tree from its linked list representation.
		 * */
		public Node ConstructBTreeFromItsLinkedListRepresentation(LinkedList<Node> linkedList)
		{
			Queue<Node> queue = new Queue<Node>();
			int index = 0;

			Node head = linkedList.ElementAt(index++);
			queue.Enqueue(head);

			Node next = linkedList.ElementAt(index++);

			while (next != null)
			{
				Node curr = queue.Dequeue();

				Node left = null, right = null;

				left = next;
				queue.Enqueue(left);

				next = linkedList.ElementAtOrDefault(index++);
				if (next != null)
				{
					right = next;
					next = linkedList.ElementAtOrDefault(index++);
					queue.Enqueue(right);
				}

				curr.left = left;
				curr.right = right;
			}

			return head;
		}

		/**
		 * 	Find next right nodes of given leafs in a binary tree.
		 */
		public Node FindNextRightNodesofGivenLeafsInABinaryTree(Node node, int k)
		{
			if (node == null || node.key == k) return null;

			Queue<Node> queueN = new Queue<Node>();
			Queue<int> queueLevel = new Queue<int>();

			queueN.Enqueue(node);
			queueLevel.Enqueue(0);

			while (queueN.Count > 0)
			{
				Node curr = queueN.Dequeue();
				int level = queueLevel.Dequeue();

				if (curr.key == k)
				{
					if (queueN.Count == 0 || queueLevel.Peek() != level)
					{
						return null;
					}
					else
					{
						return queueN.Peek();
					}
				}

				if (curr.left != null)
				{
					queueN.Enqueue(curr.left);
					queueLevel.Enqueue(level + 1);
				}

				if (curr.right != null)
				{
					queueN.Enqueue(curr.right);
					queueLevel.Enqueue(level + 1);
				}
			}
			return null;

		}

		/*
		 * 	Given a binary tree, print boundary nodes of the binary tree Anti-Clockwise starting from the root.
		 */
		public void PrintBoundaryNodesOfBTreeAntiClockWiseFromRoot(Node root)
		{
			PrintBoundary(root, "left");
			PrintLeaf(root);
			PrintBoundary(root.right, "right");

		}
		private void PrintBoundary(Node root, string dir)
		{

			if (dir == "left")
			{
				while (!(root.left == null && root.right == null))
				{
					Console.Write(root.key + " ");
					if (root.left != null)
					{
						root = root.left;
					}
					else if (root.right != null)
					{
						root = root.right;

					}
				}
			}
			else
			{
				Stack<Node> stack = new Stack<Node>();
				while (!(root.left == null && root.right == null))
				{
					stack.Push(root);
					if (root.right != null)
					{
						root = root.right;
					}
					else if (root.left != null)
					{
						root = root.left;
					}
					else
					{
						break;
					}
				}

				while (stack.Count > 0)
				{
					Console.Write(stack.Pop().key + " ");
				}
			}
		}
		private void PrintLeaf(Node root)
		{
			if (root == null) return;

			PrintLeaf(root.left);
			if (root.left == null && root.right == null)
			{
				Console.Write(root.key + " ");
			}
			PrintLeaf(root.right);
		}

		/**
		* 	Convert a given tree to its sum tree.
		*/
		public int ConvertAGivenTreeToItsSumTree(Node node)
		{
			if (node == null) return 0;

			int nodeKey = node.key;

			node.key = ConvertAGivenTreeToItsSumTree(node.left) + ConvertAGivenTreeToItsSumTree(node.right);

			return nodeKey + node.key;
		}

		/**
		 * 	Given a binary tree, find out if the tree can be folded or not.
		 */
		public bool isFoldable(Node node)
		{
			if (node == null)
			{
				return true;
			}
			return isFoldableUtil(node, node);
		}
		/**
		 * Also code for mirror
		 */
		private bool isFoldableUtil(Node left, Node right)
		{
			if (left == null && right == null)
			{
				return true;
			}
			if (left != null && right != null)
			{
				return isFoldableUtil(left.left, right.right) && isFoldableUtil(left.right, right.left);
			}
			else
			{
				return false;
			}
		}


		/**
		 *  Inorder 
		 */
		public Node Inorder(Node root)
		{
			if (root == null)
			{
				return root;
			}
			Inorder(root.left);
			Console.WriteLine(root.key);
			Inorder(root.right);
			return root;
		}
		public ExpNode Inorder(ExpNode root)
		{
			if (root == null)
			{
				return root;
			}
			Inorder(root.left);
			Console.WriteLine(root.key);
			Inorder(root.right);
			return root;
		}
	}
}
