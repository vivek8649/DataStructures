using System;
using System.Collections.Generic;
using System.Text;

namespace DSAlgo.Tree
{
	public class ExpNode
	{
		public char key;
		public ExpNode left, right;

		// constructor 
		public ExpNode(char key)
		{
			this.key = key;
			left = null;
			right = null;
		}
	}

	public class ExprNode
	{
		public string key;
		public ExprNode left, right;

		// constructor 
		public ExprNode(string key)
		{
			this.key = key;
			left = null;
			right = null;
		}
	}
}
