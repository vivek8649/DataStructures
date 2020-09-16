using System;
using System.Collections.Generic;
using System.Text;

namespace DSAlgo
{
	class BSTCount
	{
		public void findCount(List<int> A, int B)
		{
			int leftStart = findIndex(A, B, -1, true);
			int rightStart = findIndex(A, B, -1, false);
			Console.WriteLine((rightStart - leftStart) + 1);
			Console.ReadLine();
		}

		public int findIndex(List<int> A, int B, int result, bool isStartCount)
		{
			int low = 0;
			int high = A.Count - 1;
			while (low <= high)
			{
				int mid = (high + low) / 2;
				if (A[mid] == B)
				{
					result = mid;
					if (isStartCount)
					{
						high = mid - 1;
					}
					else
					{
						low = mid + 1;
					}
				}
				else if (A[mid] > B)
				{
					high = mid - 1;
				}
				else if (A[mid] < B)
				{
					low = mid + 1;
				}
			}
			return result;
		}

	}
}
