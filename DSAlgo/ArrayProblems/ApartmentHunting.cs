using System;
using System.Collections.Generic;
using System.Text;

namespace DSAlgo.ArrayProblems
{
	class ApartmentHunting
	{
		public static int ApartmentHuntingFn(List<Dictionary<string, bool>> blocks, string[] reqs)
		{
			// Write your code here.
			int min = Int32.MaxValue;
			int res = -1;

			for (int i = 0; i < blocks.Count; i++)
			{

				var block = blocks[i];

				Dictionary<string, int> dist = new Dictionary<string, int>();

				foreach (var item in reqs)
				{
					if (!block[item])
					{
						var itemDistance = GetItemDistance(blocks, item, i);
						dist.Add(item, itemDistance);
					}
					else
					{
						dist.Add(item, i);
					}
				}

				int distance = 0;
				var upDist = 0;
				var downDist = 0;

				foreach (var item in dist)
				{
					if (item.Value < i)
					{
						upDist = Math.Max(upDist, i - item.Value);
					}
					else if (item.Value > i)
					{
						downDist = Math.Max(downDist, item.Value - i);
					}
				}
				distance = upDist + downDist;

				if (distance < min)
				{
					res = i;
					min = distance;
				}
			}

			return res;
		}

		private static int GetItemDistance(List<Dictionary<string, bool>> blocks, string item, int currentBlock)
		{
			int res = -1;
			int up = currentBlock - 1;
			int down = currentBlock + 1;
			while (up >= 0 || down < blocks.Count)
			{

				if (up >= 0)
				{
					if (blocks[up][item])
					{
						res = up;
						break;
					}
				}
				if (down <= blocks.Count - 1)
				{
					if (blocks[down][item])
					{
						res = down;
						break;
					}
				}
				up--;
				down++;
			}
			return res;
		}
	}
}
