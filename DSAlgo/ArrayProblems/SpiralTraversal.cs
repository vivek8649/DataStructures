using System;
using System.Collections.Generic;
using System.Text;

namespace DSAlgo.ArrayProblems
{
	class SpiralTraversal
	{
		public static List<int> SpiralTraverse(int[,] array)
		{
			bool left = false, right = true, top = false, bottom = false;
			List<int> res = new List<int>();
			int row = array.GetLength(0) - 1;
			int col = array.GetLength(1) - 1;

			int rowStart = 0;
			int colStart = 0;

			int rStart = 0;
			int cStart = 0;

			while (rowStart >= 0 && colStart >= 0 && rowStart <= row && colStart <= col && row >= rStart)
			{
				if (right)
				{
					res.Add(array[rowStart, colStart]);
					if (colStart == col)
					{
						bottom = true;
						right = false;
						rowStart++;
						rStart++;
					}
					else
					{
						colStart++;
					}
				}
				else if (bottom)
				{
					res.Add(array[rowStart, colStart]);
					if (rowStart == row)
					{
						bottom = false;
						left = true;
						colStart--;
						col--;
					}
					else
					{
						rowStart++;
					}
				}
				else if (left)
				{
					if (array[rowStart, colStart] == 16)
					{
						Console.WriteLine("br");
					}
					res.Add(array[rowStart, colStart]);
					if (colStart == cStart)
					{
						top = true;
						left = false;
						rowStart--;
						row--;
					}
					else
					{
						colStart--;
					}
				}
				else
				{  // top
					res.Add(array[rowStart, colStart]);
					if (rowStart == rStart)
					{
						top = false;
						right = true;
						cStart++;
						colStart++;
					}
					else
					{
						rowStart--;
					}
				}
			}

			return res;

		}

		public static List<int> SpiralTraverseRec(int[,] array)
		{
			if (array.Length == 0) return new List<int>() { };

			var res = new List<int>();
			var result = SpiralFill(array, 0, array.GetLength(0) - 1, 0, array.GetLength(1) - 1, res);
			return result;
		}
		private static List<int> SpiralFill(int[,] array, int rowStart, int row, int colStart, int col, List<int> result)
		{
			if (rowStart > row || colStart > col) return result;

			for (int i = colStart; i <= col; i++)
			{
				result.Add(array[rowStart, i]);
			}

			for (int i = rowStart + 1; i <= row; i++)
			{
				result.Add(array[i, col]);
			}
			for (int i = col - 1; i >= colStart; i--)
			{
				if (rowStart == row) break;
				result.Add(array[row, i]);
			}
			for (int i = row - 1; i >= rowStart + 1; i--)
			{
				if (colStart == col) break;
				result.Add(array[i, colStart]);
			}

			return SpiralFill(array, rowStart + 1, row - 1, colStart + 1, col - 1, result);

		}
	}
}
