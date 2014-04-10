using System;

namespace lab2
{
	class MainApp
	{
		static void Main(string[] args)
		{
			int x = 0;
			int y = 0;

			x = Convert.ToInt32(Console.ReadLine());
			y = Convert.ToInt32(Console.ReadLine());

			for(int i = 0; i < x; i++)
			{
				for(int j = 0; j < y; j++)
					{
						Console.Write("{0}{1} ",i ,j);
					}
				Console.WriteLine();
			}
		}
	}
}

