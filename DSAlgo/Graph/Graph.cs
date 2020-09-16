using System;
using System.Collections.Generic;
using System.Text;

namespace DSAlgo.Graph
{
	public class Graph
	{

		public int V;   // No. of vertices 
		public LinkedList<int>[] adj; //Adjacency Lists 
		public LinkedList<int>[] adjacencyList;

		// Constructor 
		public Graph(int v)
		{
			V = v;
			adj = new LinkedList<int>[v];
			for (int i = 0; i < v; ++i)
				adj[i] = new LinkedList<int>();


			adjacencyList = new LinkedList<int>[v];
			for (int i = 0; i < v; i++)
				adjacencyList[i] = new LinkedList<int>();
		}
	}
}
