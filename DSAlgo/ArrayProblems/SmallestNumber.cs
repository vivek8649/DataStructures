using System;
using System.Collections.Generic;
using System.Text;

namespace DSAlgo.ArrayProblems
{
	class SmallestNumber
	{
		public static int[] SmallestDifference(int[] arrayOne, int[] arrayTwo)
		{
			var res = new int[] { };
			// Write your code here.
			for (int i = 0; i < arrayOne.Length; i++)
			{
				var min = Int32.MaxValue;

				for (int j = 0; j < arrayTwo.Length; j++)
				{
					if (Math.Abs(arrayTwo[j] - arrayOne[i]) < min)
					{
						min = Math.Abs(arrayTwo[j] - arrayOne[i]);
						res[0] = i;
						res[j] = j;
					}
				}
			}

			return res;
		}

		public static int[] SmallestDifferenceOrderN(int[] arrayOne, int[] arrayTwo)
		{
			// Write your code here.
			Array.Sort(arrayTwo);
			Array.Sort(arrayOne);

			int firstIndex = 0;
			int secondIndex = 0;
			int smallest = Int32.MaxValue;
			int current = Int32.MaxValue;
			int[] res = new int[2];

			while (firstIndex < arrayOne.Length && secondIndex < arrayTwo.Length)
			{
				int firstNum = arrayOne[firstIndex];
				int secondNum = arrayTwo[secondIndex];
				if (firstNum < secondNum)
				{
					current = secondNum - firstNum;
					firstIndex++;
				}
				else if (firstNum > secondNum)
				{
					current = firstNum - secondNum;
					secondIndex++;
				}
				else
				{
					return new int[] { firstNum, secondNum };
				}

				if (smallest > current)
				{
					res = new int[] { firstNum, secondNum };
				}
			}

			return res; 
		}
	}
}
