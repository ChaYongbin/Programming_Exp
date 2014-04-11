using System;

namespace add3
{
	class addlab3
	{
		static void Main(string[] args)
		{
			string[,] arr; // array

			// 우선 짝수와 홀수를 판별해야함
			Console.WriteLine("배열 형성을 원하는 수를 홀수로 입력해주세요.");
			
			int n = Convert.ToInt32(Console.ReadLine());
			if (n%2 == 0)
			{
				Console.WriteLine("짝수를 입력하셨어요 ㅠ^ㅠ 홀수 모르는거 아니죠?");
				Console.WriteLine("다시 입력해주세요.");
				Console.ReadKey();
			}
			else 
			{
			}
			
			arr = new string[n,n];
		 	for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
				{
					arr[i,j] = "* ";
					Console.Write(arr[i,j]);
				}
				Console.WriteLine();
			}
			while (true)
			{
				Console.WriteLine("어떤거 지울거에요?");
				int row = Convert.ToInt32(Console.ReadLine());
				int column = Convert.ToInt32(Console.ReadLine());

				if (row < 0 || column < 0)
				{
					break;
				}
				else if(arr[row - 1, column - 1].Equals("  "))
				{
					Console.WriteLine("아..다시!! 이미 입력한 값이에요.");
				}
				else
				{
					arr[row - 1, column - 1]= "  ";
				}
				
				for (int i = 0; i < n; i++)
				{
					for(int j = 0; j < n; j++)
					{
						Console.Write(arr[i,j]);
					}
					Console.WriteLine();
				}
			}
		}
	}
}
