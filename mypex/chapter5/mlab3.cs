using System;

namespace Switch
{
	class MainApp
	{
		static void Main(string[] args)
		{
			Console.WriteLine("요일을 입력하세요.");
			string day = Console.ReadLine();

			switch (day)
			{
				case "일":
					Console.WriteLine("Sunday");
					break;
				case "월":
					Console.WriteLine("Monday");
					break;
				case "화":
					Console.WriteLine("Tuesday");
					break;
				case "수":
					Console.WriteLine("Wednesday");
					break;
				case "목":
					Console.WriteLine("Thursday");
					break;
				case "금":
					Console.WriteLine("Friday");
					break;
				case "토":
					Console.WriteLine("saturday");
					break;
				default:
					Console.WriteLine("입력하신 정보인 '{0}'은 요일이 아닙니다.", day);
					Console.WriteLine("다시 입력해주시길 바랍니다.");
					break;
			}
		}	
	}
}
