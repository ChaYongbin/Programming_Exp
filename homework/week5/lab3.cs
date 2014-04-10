using System;

namespace lab3
{
	class MainApp
	{
		static void Main(string[] args)
		{
			int n = Convert.ToInt32(Console.ReadLine());
			int[,] array;
			array = new int[n,n];
			
			for(int i = 0 ; i < n ; i++)
			{
				for(int j = 0 ; j < n ; j++)
				{
					Console.Write("[{0},{1}] : ", i, j);
					int x = Convert.ToInt32(Console.ReadLine());
					array[i, j] = x;
				}
			}
			for(int i = 0; i < n; i++)
			{
				for(int j = 0; j < n; j++)
				{
					Console.Write("{0} ", array[i,j]);
				}
				Console.WriteLine();
			}
		}
	}
}

