using System;
using System.Collections.Generic;
using System.Text;

namespace DSAlgo
{
	public class BacktrackingConfidential
	{
		static string res = "";
		public void RunConfidential()
		{
			int t = Int32.Parse(Console.ReadLine());
			for (int i = 0; i < t; i++)
			{
				res = "";
				double n = Double.Parse(Console.ReadLine().Trim(' '));
				string s = Console.ReadLine();
				char[] charArray = s.ToCharArray();
				Confidential(0, s.Length -1, charArray);
				Console.WriteLine(res);
			}
		}

		public static void Confidential(double start, double end, char[] charArray)
		{
			if (start > end )
			{
				return;
			}
			int mid = Convert.ToInt32(Math.Floor((start + end) / 2));
			res += charArray[mid];
			Confidential(start, mid-1, charArray);
			Confidential((mid + 1), end, charArray);
		}
	}
}
