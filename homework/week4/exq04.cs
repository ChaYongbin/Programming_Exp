using System;

namespace exq04
{
	class MainApp
	{
		static void Main(string[] args)
		{
			Console.WriteLine("원하시는 횟수를 입력하세요.");
			string x = 0;
			x = Convert.ToInt32(Console.ReadLine());

			if(x <= 0)
			{
				Console.WriteLine("오류가 났습니다. 다시 입력해주세요);
				goto x;
			}
			for(int i = 0;i < x; i++)
			{
				for(int j = 0; j <= i; j++)
				{
					Console.Write("*");
				}
				Console.WrtieLine();
			}
		}
	}
}

