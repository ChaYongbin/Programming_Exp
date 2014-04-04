using System;

namespace exq01
{
	class MainApp
	{
		static void Main(string[] args)
		{
			int x = 0;
			x = Convert.ToInt32(Console.ReadLine());
			for(int i = 0; i < x; i++)
			{
				for(int j = 0; j <= i; j++)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}
		}
	}
}

