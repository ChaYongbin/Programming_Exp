using System;

namespace avg
{
	class MainApp
	{
		static void Main(string[] args)
		{
			Console.WriteLine("평균을 구하고자 하는 숫자를 입력해주세요.");
			
			int n = 0;
			int count = 0;
			int sum = 0;
			
			while(n != -1) 
			{
				sum = sum +n;
				string words = Console.ReadLine();
				n = Convert.ToInt32(words);	
				count = count +1;
			}

			count = count -1;

			Console.WriteLine("Sum: {0}", sum);
			Console.WriteLine("Count: {0}", count);
			Console.WriteLine("avg: {0} ", sum / count);
		}
	}
}

