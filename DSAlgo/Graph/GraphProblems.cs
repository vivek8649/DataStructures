using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DSAlgo.Graph
{

	/// Introduction 
	// Create an undirected graph of 5 nodes by Adjacency list   - Done
	//Breadth First Traversal for a Grap	- Done
	//Depth First Traversal for a Graph		- Done
	//Find Mother Vertex in a Graph   - Done
	//Transitive Closure of a Graph using DFS  - Done
	//Iterative Depth First Search - Done
	//Count the number of nodes at given level in a tree using BFS - Done
	//Count all possible paths between two vertices - 
	//Minimum initial vertices to traverse whole matrix with given conditions
	//Shortest path to reach one prime to other by changing single digit at a time
	//Water Jug problem using BFS
	//Count number of trees in a forest
	//BFS using vectors & queue as per the algorithm of CLRS
	//Level of Each node in a Tree from source node
	//Construct binary palindrome by repeated appending and trimming
	//Transpose graph
	//Path in a Rectangle with Circles
	//Height of a generic tree from parent array
	//DFS for a n-ary tree(acyclic graph) represented as adjacency list
	//Maximum number of edges to be added to a tree so that it stays a Bipartite graph
	//A Peterson Graph Problem
	//Print all paths from a given source to a destination using BFS
	//Minimum number of edges between two vertices of a Graph
	//Count nodes within K-distance from all nodes in a set
	//Bidirectional Search
	//Minimum edge reversals to make a root
	//BFS for Disconnected Graph
	//Move weighting scale alternate under given constraints
	//Best First Search(Informed Search)
	//Number of pair of positions in matrix which are not accessible
	//Maximum product of two non-intersecting paths in a tree
	//Delete Edge to minimize subtree sum difference
	//Find the minimum number of moves needed to move from one cell of matrix to another
	//Minimum steps to reach target by a Knight | Set 1
	//Minimum number of operation required to convert number x into y
	//Minimum steps to reach end of array under constraints
	//Find the smallest binary digit multiple of given number
	//Roots of a tree which give minimum height
	//Stepping Numbers
	//Clone an Undirected Graph
	//Sum of the minimum elements in all connected components of an undirected graph
	//Check if two nodes are on same path in a tree
	//A matrix probability question
	//Find length of the largest region in Boolean Matrix
	//Iterative Deepening Search(IDS) or Iterative Deepening Depth First Search(IDDFS)
	//Find K cores of an undirected Graph

	/// Graph Cycle :
	//
	//	Detect Cycle in a Directed Graph
	//	Detect cycle in an undirected graph
	//	Detect cycle in a direct graph using colors
	//	Assign directions to edges so that the directed graph remains acyclic
	//	Detect a negative cycle in a Graph | (Bellman Ford)
	//	Cycles of length n in an undirected and connected graph
	//	Detecting negative cycle using Floyd Warshall
	//	Check if there is a cycle with odd weight sum in an undirected graph
	//	Check if a graphs has a cycle of odd length
	//	Clone a Directed Acyclic Graph
	//	Check loop in array according to given constraints
	//	Disjoint Set(Or Union-Find) | Set 1
	//	Union-Find Algorithm | Set 2
	//	Union-Find Algorithm | (Union By Rank and Find by Optimized Path Compression)
	//	Magical Indices in an array

	/// Topological Sorting :
	///
	//	Topological Sorting
	//	All topological sorts of a Directed Acyclic Graph
	//	Kahn’s Algorithm for Topological Sorting
	//	Maximum edges that can be added to DAG so that is remains DAG
	//	Longest path between any pair of vertices
	//	Longest Path in a Directed Acyclic Graph
	//	Longest Path in a Directed Acyclic Graph | Set 2
	//	Topological Sort of a graph using departure time of vertex
	//	Given a sorted dictionary of an alien language, find order of characters

	/// Minimum Spanning Tree :
	///
	//	Prim’s Minimum Spanning Tree(MST))
	//	Applications of Minimum Spanning Tree Problem
	//	Prim’s MST for Adjacency List Representation
	//	Kruskal’s Minimum Spanning Tree Algorithm
	//	Boruvka’s algorithm for Minimum Spanning Tree
	//	Minimum cost to connect all cities
	//	Steiner Tree
	//	Reverse Delete Algorithm for Minimum Spanning Tree
	//	Total number of Spanning Trees in a Graph
	//	Minimum Product Spanning Tree

	/// BackTracking :
	///
	//	Find if there is a path of more than k length from a source
	//	Tug of War
	//	The Knight-Tour Problem
	//	Rat in a Maze
	//	n-Queen’s Problem
	//	m Coloring Problem
	//	Hamiltonian Cycle
	//	Permutation of numbers such that sum of two consecutive numbers is a perfect square


	/// Shortest Paths :
	///
	//	Dijkstra’s shortest path algorithm
	//	Dijkstra’s Algorithm for Adjacency List Representation
	//	Bellman–Ford Algorithm
	//	Floyd Warshall Algorithm
	//	Johnson’s algorithm for All-pairs shortest paths
	//	Shortest Path in Directed Acyclic Graph
	//	Shortest path with exactly k edges in a directed and weighted graph
	//	Dial’s Algorithm
	//	Printing paths in Dijsktra’s Algorithm
	//	Shortest path of a weighted graph where weight is 1 or 2
	//	Multistage Graph(Shortest Path)
	//	Shortest path in an unweighted graph
	//	Minimize the number of weakly connected nodes
	//	Betweenness Centrality(Centrality Measure)
	//	Comparison of Dijkstra’s and Floyd–Warshall algorithms
	//	Karp’s minimum mean(or average) weight cycle algorithm
	//	0-1 BFS(Shortest Path in a Binary Weight Graph)
	//	Find minimum weight cycle in an undirected graph
	//	Minimum Cost Path with Left, Right, Bottom and Up moves allowed
	//	Minimum edges to reverse to make path from a src to a dest
	//	Find Shortest distance from a guard in a Bank

	//// Hard company problems
	// Implementing Dijkstra | Set 1 (Adjacency Matrix)
	// Distance of nearest cell having 1
	// Detect cycle in a directed graph
	// DFS of Graph;
	// BFS of graph
	// Shortest path from 1 to n;
	// Bridge Edge in Graph
	// Assignment Problem
	// Replace O's with X's
	// Minimum Cost Path
	// Strongly Connected Components(Kosaraju's Algo)
	// Find the number of islands
	// Knight Walk
	// Hamiltonian Path
	// Detect cycle in an undirected graph
	// Bipartite Graph
	// Topological sort
	// Sum of dependencies in a graph;
	// X Total Shapes
	// Word Boggle
	// Unit Area of largest region of 1's
	// Flood fill Algorithm
	// Rotten Oranges
	// Floyd Warshall
	// Alien Dictionary
	// Unit Area of largest region of 1's
	// Steps by Knight
	// Snake and Ladder Problem

	public class GraphProblem
	{
		public void start()
		{
			// createUndirectedGraph(5);

			//Breadth First Traversal for a Graph
			//Graph g = createUndirectedGraph(5);
			//BFSOfUndirectedGraph(g, 0);

			/**
			 * BFS for directed graph
			 */
			//Graph g = new Graph(4);

			//addEdgeToDirectedGraph(g, 0, 1);
			//addEdgeToDirectedGraph(g, 0, 2);
			//addEdgeToDirectedGraph(g, 1, 2);
			//addEdgeToDirectedGraph(g, 2, 0);
			//addEdgeToDirectedGraph(g, 2, 3);
			//addEdgeToDirectedGraph(g, 3, 3);

			//Console.WriteLine("Following is Breadth First Traversal " +
			//				   "(starting from vertex 2)");

			// BFS(g, 2);

			// DFS(g, 2);

			//Find Mother Vertex in a Graph   - Done
			Graph mvGraph = new Graph(7);
			addEdgeToDirectedGraph(mvGraph, 0, 1);
			addEdgeToDirectedGraph(mvGraph, 0, 2);
			addEdgeToDirectedGraph(mvGraph, 1, 3);
			addEdgeToDirectedGraph(mvGraph, 4, 1);
			addEdgeToDirectedGraph(mvGraph, 6, 4);
			addEdgeToDirectedGraph(mvGraph, 5, 6);
			addEdgeToDirectedGraph(mvGraph, 5, 2);
			addEdgeToDirectedGraph(mvGraph, 6, 0);
			// Console.WriteLine(FindMotherVertexInGraphBrute(mvGraph));
			// Console.WriteLine(FindMotherVertexInGraph(mvGraph));

			Graph transClosure = new Graph(4);

			addEdgeToDirectedGraph(transClosure, 0, 1);
			addEdgeToDirectedGraph(transClosure, 0, 2);
			addEdgeToDirectedGraph(transClosure, 1, 2);
			addEdgeToDirectedGraph(transClosure, 2, 0);
			addEdgeToDirectedGraph(transClosure, 2, 3);
			addEdgeToDirectedGraph(transClosure, 3, 3);
			// TransitiveCloserOfGraph(transClosure);

			// Iterative Depth First Search
			Graph iterativeDFSGraph = new Graph(5);
			addEdgeToDirectedGraph(iterativeDFSGraph, 1, 0);
			addEdgeToDirectedGraph(iterativeDFSGraph, 2, 1);
			addEdgeToDirectedGraph(iterativeDFSGraph, 3, 4);
			addEdgeToDirectedGraph(iterativeDFSGraph, 4, 0);

			//  Console.WriteLine("Following is Depth First Traversal");
			// IterativeDFSGraph(iterativeDFSGraph);

			//Count the number of nodes at given level in a tree using BFS
			Graph bfsCount = new Graph(6);
			addEdgeToUndirectedGraph(bfsCount, 0, 1);
			addEdgeToUndirectedGraph(bfsCount, 0, 2);
			addEdgeToUndirectedGraph(bfsCount, 1, 3);
			addEdgeToUndirectedGraph(bfsCount, 2, 4);
			addEdgeToUndirectedGraph(bfsCount, 2, 5);
			// int level = 2;
			// Console.WriteLine(CountNumberOfNodesAtGivenLevelBFS(bfsCount, level, 0));

			// Count all possible paths between two vertices 
			Graph allPaths = new Graph(5
				);

			int s = 0, d = 3;

			addEdgeToDirectedGraph(allPaths, 0, 1);
			addEdgeToDirectedGraph(allPaths, 0, 2);
			addEdgeToDirectedGraph(allPaths, 0, 3);
			addEdgeToDirectedGraph(allPaths, 1, 3);
			addEdgeToDirectedGraph(allPaths, 2, 3);
			addEdgeToDirectedGraph(allPaths, 1, 4);
			addEdgeToDirectedGraph(allPaths, 2, 4);
			Console.WriteLine(CountAllPossiblePathBetweenTwoNodes(allPaths, s, d));

		}


		/// <summary>
		/// ShortestPath 
		/// </summary>
		public void ShortestPath()
		{
			int noOfTest = Convert.ToInt32(Console.ReadLine());

			for (int t = 0; t < noOfTest; t++)
			{
				int[] size = Console.ReadLine().Trim(' ').Split(' ').Select(s => Convert.ToInt32(s)).ToArray();
				int n = size[0];
				int m = size[1];
				int[] matrix = Console.ReadLine().Trim(' ').Split(' ').Select(s => Convert.ToInt32(s)).ToArray();
				int[,] array = new int[n, m];
				bool[,] visited = new bool[n, m];

				for (int i = 0; i < n; i++)
				{
					for (int j = 0; j < m; j++)
					{
						array[i, j] = matrix[i * m + j];
					}
				}

				int[] target = Console.ReadLine().Trim(' ').Trim(' ').Split(' ').Select(s => Convert.ToInt32(s)).ToArray();
				int x = target[0];
				int y = target[1];

				visited[0, 0] = true;
				bool isFound = false;
				int res = ShortestPathUtil(array, n, m, 0, 0, x, y, visited, isFound);
				Console.WriteLine(res);
			}
		}
		public int ShortestPathUtil(int[,] graph, int n, int m, int i, int j, int x, int y, bool[,] visited, bool isFound)
		{
			if (graph[x, y] != 1) return -1;

			int[] arr = new int[2];
			arr[0] = i;
			arr[1] = j;
			int[,] dist = new int[n, m];

			Queue<int[]> queue = new Queue<int[]>();
			queue.Enqueue(arr);
			visited[i, j] = true;
			int count = 0;
			dist[i, j] = 0;
			while (queue.Count > 0)
			{
				int[] queueOb = queue.Dequeue();

				int iIndex = queueOb[0];
				int jIndex = queueOb[1];
				visited[iIndex, jIndex] = true;

				if (iIndex == x && jIndex == y)
				{
					return dist[iIndex, jIndex];
				}


				if (iIndex > -1 && iIndex < n && jIndex > -1 && jIndex < m)
				{
					int[] down = new int[2];
					int[] top = new int[2];
					int[] left = new int[2];
					int[] right = new int[2];

					if (iIndex + 1 > -1 && iIndex + 1 < n && graph[iIndex + 1, jIndex] == 1 && !visited[iIndex + 1, jIndex])
					{
						down[0] = iIndex + 1;
						down[1] = jIndex;
						queue.Enqueue(down);
						dist[iIndex + 1, jIndex] = dist[iIndex, jIndex] + 1;
					}

					if (iIndex - 1 > -1 && iIndex - 1 < n && graph[iIndex - 1, jIndex] == 1 && !visited[iIndex - 1, jIndex])
					{
						top[0] = iIndex - 1;
						top[1] = jIndex;
						queue.Enqueue(top);
						dist[iIndex - 1, jIndex] = dist[iIndex, jIndex] + 1;

					}

					if (jIndex - 1 > -1 && jIndex - 1 < m && graph[iIndex, jIndex - 1] == 1 && !visited[iIndex, jIndex - 1])
					{
						left[0] = iIndex;
						left[1] = jIndex - 1;
						queue.Enqueue(left);
						dist[iIndex, jIndex - 1] = dist[iIndex, jIndex] + 1;

					}

					if (jIndex + 1 > -1 && jIndex + 1 < m && graph[iIndex, jIndex + 1] == 1 && !visited[iIndex, jIndex + 1])
					{
						right[0] = iIndex;
						right[1] = jIndex + 1;
						queue.Enqueue(right);
						dist[iIndex, jIndex + 1] = dist[iIndex, jIndex] + 1;
					}

				}
			}

			return -1;
		}

		/**
		 * BFS for directed graph
		 */
		private void BFS(Graph g, int start)
		{
			LinkedList<int> queque = new LinkedList<int>();
			bool[] visited = new bool[g.adjacencyList.Length];
			queque.AddLast(start);

			visited[start] = true;

			while (queque.Count > 0)
			{
				int curr = queque.First.Value;
				queque.RemoveFirst();
				Console.WriteLine(curr);

				foreach (var item in g.adjacencyList[curr])
				{
					if (!visited[item])
					{
						visited[item] = true;
						queque.AddLast(item);
					}
				}
			}

		}

		/**
		 * DFS for a directed graph
		 * */
		public void DFS(Graph g, int start)
		{
			bool[] visited = new bool[g.adjacencyList.Length];
			DFSUtil(g, start, visited);
		}

		private void DFSUtil(Graph g, int start, bool[] visited)
		{
			if (!visited[start])
			{
				visited[start] = true;
				Console.WriteLine(start);

				foreach (var item in g.adjacencyList[start])
				{
					DFSUtil(g, item, visited);
				}
			}
		}

		public Graph createUndirectedGraph(int v)
		{
			Graph g = new Graph(v);
			// Adding edges one by one  
			addEdgeToUndirectedGraph(g, 0, 1);
			addEdgeToUndirectedGraph(g, 0, 4);
			addEdgeToUndirectedGraph(g, 1, 2);
			addEdgeToUndirectedGraph(g, 1, 3);
			addEdgeToUndirectedGraph(g, 1, 4);
			addEdgeToUndirectedGraph(g, 2, 3);
			addEdgeToUndirectedGraph(g, 3, 4);

			printUndirectedGraph(g);

			return g;
		}

		private void printUndirectedGraph(Graph g)
		{
			int index = 0;
			foreach (var item in g.adjacencyList)
			{
				Console.WriteLine("\n Vertex : " + index++);
				Console.Write("head");

				foreach (var it in item)
				{
					Console.Write("->" + it);
				}
				Console.WriteLine();
			}
		}

		// Function to add an edge into undirected the graph 
		public void addEdgeToUndirectedGraph(Graph g, int v, int w)
		{
			g.adjacencyList[v].AddLast(w);
			g.adjacencyList[w].AddLast(v);
		}

		// Function to add an edge into directed the graph 
		public void addEdgeToDirectedGraph(Graph g, int v, int w)
		{
			g.adjacencyList[v].AddLast(w);
		}

		/**
		 * Breadth first traversal of graph
		 */
		public void BFSOfUndirectedGraph(Graph g, int start)
		{
			Queue<LinkedList<int>> queue = new Queue<LinkedList<int>>();
			queue.Enqueue(g.adjacencyList[start]);
			bool[] visited = new bool[g.adjacencyList.Length];

			for (int i = 0; i < visited.Length; i++)
			{
				visited[i] = false;
			}


			visited[start] = true;
			Console.WriteLine(start);

			while (queue.Count > 0)
			{
				LinkedList<int> currentList = queue.Dequeue();

				foreach (var item in currentList)
				{
					if (!visited[item])
					{
						visited[item] = true;
						queue.Enqueue(g.adjacencyList[item]);
						Console.WriteLine(item);
					}
				}
			}


		}

		//Find Mother Vertex in a Graph 
		public int? FindMotherVertexInGraphBrute(Graph graph)
		{
			int? motherVertex = null;
			int index = 0;

			foreach (var item in graph.adjacencyList)
			{
				bool[] visited = new bool[graph.adjacencyList.Length];
				bool allCanVisisted = true;
				visited[index] = true;
				FindMotherVertexInGraphUtil(graph, visited, item);

				foreach (var v in visited)
				{
					if (!v)
					{
						allCanVisisted = false;
					}

				}

				if (allCanVisisted)
				{
					motherVertex = index;
					break;
				}
				index++;
			}
			return motherVertex;
		}

		private void FindMotherVertexInGraphUtil(Graph graph, bool[] visited, LinkedList<int> list)
		{
			foreach (var val in list)
			{
				if (!visited[val])
				{
					visited[val] = true;
					FindMotherVertexInGraphUtil(graph, visited, graph.adjacencyList[val]);
				}
			}
		}

		public int FindMotherVertexInGraph(Graph graph)
		{
			bool[] visited = new bool[graph.V];

			int v = 0;

			for (int i = 0; i < graph.V; i++)
			{
				if (!visited[i])
				{
					visited[i] = true;
					v = i;
					MotherVertexDFSUtil(graph, i, visited);
				}
			}

			visited = new bool[graph.V];
			// Check if has mother vertex
			visited[v] = true;
			MotherVertexDFSUtil(graph, v, visited);
			foreach (var item in visited)
			{
				if (!item) return -1;
			}
			return v;
		}

		private void MotherVertexDFSUtil(Graph g, int v, bool[] visited)
		{
			foreach (var item in g.adjacencyList[v])
			{
				if (!visited[item])
				{
					visited[item] = true;
					MotherVertexDFSUtil(g, item, visited);
				}
			}
		}

		public void TransitiveCloserOfGraph(Graph graph)
		{
			int[,] closer = new int[graph.V, graph.V];

			for (int i = 0; i < graph.V; i++)
			{
				DFSUtilTransitiveCloser(i, graph.adjacencyList[i], closer, graph);
			}

			for (int i = 0; i < graph.V; i++)
			{
				for (int j = 0; j < graph.V; j++)
				{
					Console.Write(closer[i, j] + " ");
				}
				Console.WriteLine();
			}
		}

		private void DFSUtilTransitiveCloser(int s, LinkedList<int> adjacencyList, int[,] closer, Graph graph)
		{
			if (adjacencyList != null)
			{
				foreach (var item in adjacencyList)
				{
					if (closer[s, item] != 1)
					{
						closer[s, item] = 1;
						DFSUtilTransitiveCloser(s, graph.adjacencyList[item], closer, graph);
					}
				}
			}

		}

		public void IterativeDFSGraph(Graph graph)
		{
			bool[] visited = new bool[graph.V];
			Stack<int> stack = new Stack<int>();
			for (int i = 0; i < graph.V; i++)
			{
				if (!visited[i])
				{
					stack.Push(i);
					visited[i] = true;
				}
				while (stack.Count > 0)
				{
					int x = stack.Pop();
					Console.Write(x + " ");

					foreach (var item in graph.adjacencyList[i])
					{
						if (!visited[item])
						{
							stack.Push(item);
							visited[item] = true;
						}
					}
				}
			}

		}

		public int CountNumberOfNodesAtGivenLevelBFS(Graph graph, int level, int s)
		{
			bool[] visited = new bool[graph.V];
			int[] levels = new int[graph.V];

			Queue<int> queue = new Queue<int>();
			levels[s] = 0;
			queue.Enqueue(s);
			visited[s] = true;
			while (queue.Count > 0)
			{
				s = queue.Dequeue();

				foreach (var item in graph.adjacencyList[s])
				{
					if (!visited[item])
					{
						queue.Enqueue(item);
						visited[item] = true;
						levels[item] = levels[s] + 1;
					}
				}
			}
			int count = 0;
			foreach (var item in levels)
			{
				if (item == level)
				{
					count++;
				}
			}
			return count;
		}

		public int CountAllPossiblePathBetweenTwoNodes(Graph graph, int vertex1, int vertex2)
		{
			int count1 = 0;
			int count2 = 0;

			count1 += CountAllPossiblePathBetweenTwoNodesDFS(graph, vertex1, 0, vertex2);
			count2 += CountAllPossiblePathBetweenTwoNodesDFS(graph, vertex2, 0, vertex1);
			return count1 + count2;
		}

		private int CountAllPossiblePathBetweenTwoNodesDFS(Graph graph, int vertex, int count, int finalVertex)
		{
			if (vertex == finalVertex)
			{
				count++;
				return count;
			}
			foreach (var item in graph.adjacencyList[vertex])
			{
				count += CountAllPossiblePathBetweenTwoNodesDFS(graph, item, 0, finalVertex);
			}
			return count;
		}


		//// Function to add an edge into directed the graph 
		//public void addEdge(int v, int w)
		//{
		//	adj[v].Add(w);
		//}

		//// prints BFS traversal from a given source s 
		//public void BFSTraversal(int s)
		//{
		//	// Mark all the vertices as not visited(By default 
		//	// set as false) 
		//	bool[] visited = new bool[V];

		//	// Create a queue for BFS 
		//	Queue<int> queue = new Queue<int>();

		//	// Mark the current node as visited and enqueue it 
		//	visited[s] = true;
		//	queue.Enqueue(s);

		//	while (queue.Count != 0)
		//	{
		//		// Dequeue a vertex from queue and print it 
		//		s = queue.Dequeue();
		//		Console.WriteLine(s + " ");

		//		// Get all adjacent vertices of the dequeued vertex s 
		//		// If a adjacent has not been visited, then mark it 
		//		// visited and enqueue it 
		//		adj[s].ForEach(n =>
		//		{
		//			if (!visited[n])
		//			{
		//				visited[n] = true;
		//				queue.Enqueue(n);
		//			}
		//		});
		//	}
		//}

		//public void DFSTraversal(int s)
		//{
		//	bool[] visited = new bool[V];
		//	DFSUtil(s, visited);
		//}

		//private void DFSUtil(int s, bool[] visited)
		//{
		//	visited[s] = true;
		//	Console.WriteLine(s + " ");
		//	adj[s].ForEach(n =>
		//	{
		//		if (!visited[n])
		//		{
		//			DFSUtil(n, visited);
		//		}
		//	});
		//}
	}
}
