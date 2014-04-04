using System;

namespace exq03
{
	class MainApp
	{
		static void Main(string[] args)
		{
			int x = 0;
			int y = 0;

			do
			{
				do
				{
					Console.Write("*");
					y++;
				}
				while(y <= x);
				Console.WriteLine();
				x++;
				y = 0;
			}
			while(x < 5);
		}
	}
}

