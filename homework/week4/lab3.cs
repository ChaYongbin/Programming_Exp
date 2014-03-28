using System;

namespace Muti
{
	class MainApp
	{
		static void Main(string[] args)
		{
			int n = 0; 

			Console.WriteLine("구구단의 X단 출력하기.");
			Console.Write("수를 입력하세요. : ");
			
			string words = Console.ReadLine();
			n = Convert.ToInt32(words);
			
			Console.WriteLine("구구단을 하자^^");
			
			for(int i=1; i<10; i++)
			{
				Console.WriteLine("{0}", n*i);
			}
		}
	}
}
