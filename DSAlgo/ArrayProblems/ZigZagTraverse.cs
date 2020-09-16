using System;
using System.Collections.Generic;
using System.Text;

namespace DSAlgo.ArrayProblems
{
	class ZigZagTraverse
	{
		public static List<int> ZigzagTraverseAE(List<List<int>> array)
		{
			int col = 0;
			int row = 0;
			int rowLen = array.Count - 1;
			int colLen = array[0].Count - 1;
			List<int> res = new List<int>();
			bool isGoingDown = true;

			while (row <= rowLen && col <= colLen && row >= 0 && col >= 0)
			{
				res.Add(array[row][col]);

				if (isGoingDown)
				{
					if (row == rowLen || col == 0)
					{
						isGoingDown = false;
						if (row == rowLen)
						{
							col++;
						}
						else
						{
							row++;
						}
					}
					else
					{
						row++;
						col--;
					}
				}
				else
				{
					if (row == 0 || col == colLen)
					{
						isGoingDown = true;
						if (row == 0)
						{
							col++;
						}
						else
						{
							row++;
						}
					}
					else {
						row--;
						col++;
					}

				}
			}
			return res;
		}


		public static List<int> ZigzagTraverse(List<List<int>> array)
		{
			// Write your code here.
			int rowLen = array.Count;
			int row = 0;
			int colLen = array[0].Count;
			int col = 0;

			List<int> result = new List<int>();

			if (array.Count == 1)
			{
				return array[0];
			}
			if (array[0].Count == 1)
			{
				foreach (var item in array)
				{
					result.Add(item[0]);
				}
				return result;
			}

			while (row < rowLen && col < colLen)
			{

				if (left(row, col, array))
				{
					result.Add(array[row][col]);
					result.Add(array[++row][col]);
					//Go to diagonal top right

					traverseDiagonalTopRight(ref row, ref col, array, result);
				}
				else if (top(row, col, array))
				{
					// Go one right
					result.Add(array[row][col]);
					result.Add(array[row][++col]);
					// Go diagonal bottom left
					traverseDiagonalLeftBottom(ref row, ref col, array, result);
				}
				else if (bottom(row, col, array))
				{
					result.Add(array[row][col]);
					result.Add(array[row][++col]);
					//Go to diagonal top right
					traverseDiagonalTopRight(ref row, ref col, array, result);
				}
				else if (right(row, col, array))
				{
					result.Add(array[row][col]);
					result.Add(array[++row][col]);
					//Go to diagonal top right
					traverseDiagonalLeftBottom(ref row, ref col, array, result);
				}
				else if (row == array.Count - 1 && col == array[0].Count - 1)
				{
					break;
				}
			}
			return result;
		}
		private static bool left(int row, int col, List<List<int>> array)
		{
			return col == 0 && row != array.Count - 1;
		}
		private static void traverseDiagonalTopRight(ref int row, ref int col, List<List<int>> array, List<int> result)
		{
			while (row > 0 && col < array[0].Count - 1)
			{
				row--;
				col++;
				if (row > 0 && col < array[0].Count - 1)
					result.Add(array[row][col]);
			}
		}
		private static void traverseDiagonalLeftBottom(ref int row, ref int col, List<List<int>> array, List<int> result)
		{
			while (row < array.Count - 1 && col > 0)
			{
				row++;
				col--;
				if (row < array.Count - 1 && col > 0)
					result.Add(array[row][col]);
			}
		}
		private static bool top(int row, int col, List<List<int>> array)
		{
			return row == 0 && col != array[0].Count - 1;
		}
		private static bool bottom(int row, int col, List<List<int>> array)
		{
			return row == array.Count - 1 && col != array[0].Count - 1;
		}
		private static bool right(int row, int col, List<List<int>> array)
		{
			return row != array.Count - 1 && col == array[0].Count - 1;
		}
	}
}
