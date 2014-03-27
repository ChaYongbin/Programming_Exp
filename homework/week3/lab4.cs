using System;

namespace Lab4
{
	public class Circle
	{
		public int x;
		public int y;
		public int r;
	}

	public class Lab4
	{
		public static void Main (string[] args)
		{
			Circle c1 = new Circle ();
			Circle c2 = new Circle ();
			double distance;

			Console.Write ("Circle one x : ");
			c1.x = Convert.ToInt32 (Console.ReadLine ());
			Console.Write ("Circle one y : ");
			c1.y = Convert.ToInt32 (Console.ReadLine ());
	 		Console.Write ("Circle one Radius : ");
			c1.r = Convert.ToInt32 (Console.ReadLine ());
			Console.Write ("Circle two x : ");
			c2.x = Convert.ToInt32 (Console.ReadLine ());
			Console.Write ("Circle two y : ");
			c2.y = Convert.ToInt32 (Console.ReadLine ());
			Console.Write ("Circle two Radius : ");
			c2.r = Convert.ToInt32 (Console.ReadLine ());

			distance = Math.Sqrt (Math.Pow ((c1.x - c2.x),2) + Math.Pow ((c1.y-c2.y),2));
			if (distance - (c1.r + c2.r) <= 0)
				Console.WriteLine (" 충!!돌!!");
			else
				Console.WriteLine (" 충돌하지 않았어요");
		}
	}
}

