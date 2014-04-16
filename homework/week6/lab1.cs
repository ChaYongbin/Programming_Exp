using System;

namespace week6
{
	class lab1
	{
		static void Main()
		{
			Console.WriteLine(date(1, 2));
		}
		static void date(int month, int day)
		{
			int[] month = new int[12] {31, 28, 31, 30, 31, 30, 31, 30, 31, 30, 31, 30};
			string[] day = new string[7] {"SUN", "MON", "THU", "WED", "THR", "FRI", "SAT"};

			int date = day;

			for(int i = 0; i < month -1; i++)
				date += monthday[i];
				
			return weekday[day % 7];
			
		}
	}
}

					

