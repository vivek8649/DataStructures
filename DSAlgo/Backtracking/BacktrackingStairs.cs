using System;
using System.Collections.Generic;
using System.Text;

namespace DSAlgo
{
  public class BacktrackingStairs
	{

		public void StaircaseWays()
		{
			int n = Int32.Parse(Console.ReadLine());
			int[] arr = new int[] { 1, 2, 3 };
			Console.WriteLine(Staircase(n, arr));
		}

		public static int Staircase(int n, int[] numArray)
		{



			if (n == 0) return 1;
			int total = 0;

			for (int i = 0; i < numArray.Length; i++)
			{
				if (n - numArray[i] >= 0)
					total += Staircase(n - i, numArray);
			}
			return total;


			/*
            if(n == 1 || n ==0){
                return 1;
            }
            else if(n == 2){
                return 2;
            }
            return Staircase(n-3) + Staircase(n-2) + Staircase(n-1);
            */
			/*
            int[] arr = new int[n+1];
            arr[0] = 1;
            arr[1] = 1;
            arr[2] = 2;
            for(int i=3;i<=n;i++){
                arr[i] = arr[i-1] + arr[i-2]+ arr[i-3];
            }
            return arr[n];
            */



		}
	}
}
