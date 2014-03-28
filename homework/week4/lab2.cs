using System;

namespace RamdomGame
{
	class MainApp
	{
		static void Main(string[] args)
		{
			Random r = new Random();
			int x = r.Next(1,11);
			
			Console.WriteLine("자신이 생각하는 숫자를 입력하세요. 단 1~10사이의 숫자만 인정.");

			int n = 0;
			int count = 0;
			string words = Console.ReadLine();
			n = Convert.ToInt32(words);

			while(n != x)
			{
				if ( n > x )
					Console.WriteLine("당신이 입력한 수는 큽니다.");
				else if ( n < x ) 
					Console.WriteLine("당신이 입력한 수는 작아요.");
				else
					break;

				count = count+1;
				n = Convert.ToInt32(Console.ReadLine());

			}
			
			count = count -1;

			Console.WriteLine("{0}번 만에 맟았습니다.", count);
		}
	}
}

