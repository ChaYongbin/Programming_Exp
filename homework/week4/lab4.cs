using System;

namespace Sum
{
	class MainApp
	{
		static void Main(string[] args)
		{
			Console.WriteLine("초기값, 끝값, 스텝 순으로 수를 입력 해주세요.");
			
			int n = 0;
			int max = 0;
			int step = 0;
			int x = 0;
			n = Convert.ToInt32(Console.ReadLine());
			max = Convert.ToInt32(Console.ReadLine());
			step = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("입력: {0} {1} {2} ", n, max, step);
			Console.WriteLine("결과입니다.");
			while(n < max)
			{
				x = x + n;
				Console.WriteLine(x);
				n += step;

			}
		}
	}
}

