using System;

namespace lab1
{
	class MainApp
	{
		static void Main(string[] args)
		{
			int x = 0;
			x = Convert.ToInt32(Console.ReadLine());
			for(int i = 0; i < x; i++)
			{
				for(int j = i; j < x; j++)
				{
					Console.Write(" ");
				}
				for (int k = 2*i+1; k > 0; k--)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}
		}
	}
}

