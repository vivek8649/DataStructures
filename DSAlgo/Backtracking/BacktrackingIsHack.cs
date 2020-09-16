using System;
using System.Collections.Generic;
using System.Text;

namespace DSAlgo
{
	class BacktrackingIsHack
	{


		int n = Int32.Parse(Console.ReadLine());
		int h1 = 10;
		int h2 = 20;
		public void setData() {
			for (int i = 1; i <= n; i++)
			{
				double x = Double.Parse(Console.ReadLine());

				if (ishack(1, x) == 1)
				{
					Console.WriteLine("Yes");
				}
				else
				{
					Console.WriteLine("No");
				}
			}
		}


		public static int ishack(double m, double n)
		{

			double h10 = 0, h20 = 0;

			if (n % 20 == 0)
				h20 = ishack(1, n / 20);
			if (n % 10 == 0)
				h10 = ishack(1, n / 10);
			if (h20 == 1 || h10 == 1)
				return 1;

			if (n == 1) return 1;
			else return 0;

			//  if(m<n) return (ishack(m*10,n) || ishack(m*20,n));
			//    else if(m==n) return true;
			//   else return false;
		}
	}

}

