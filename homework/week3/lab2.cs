using System;

namespace Lab2
{
	public class MainClass
	{
		public static void Main(string[] args)
		{
			String l1, l2, l3;
			double n;
			Console.Write ("이름 : ");
			l1 = Console.ReadLine ();
			Console.Write ("밑변 : ");
			l2 = Console.ReadLine ();
			Console.Write ("높이 : ");
			l3 = Console.ReadLine ();

			int x = Convert.ToInt32 (l2);
			int y = Convert.ToInt32 (l3);

			n = Convert.ToDouble(x*y)/2;

			Console.Write ("{0}의 넓이는 {1}이다.",l1, n);
		}
	}
}
