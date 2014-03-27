using System;

namespace Lab1
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int ko1, ko2;
			int math1, math2;
			double avg1, avg2, avg3;
			String name1, name2;

			ko1 = 80;
			ko2 = 88;
			math1 = 90;
			math2 = 60; // 점수기록

			avg1 = Convert.ToDouble(ko1 + math1)/2; //Double형으로 계산 될 경우를 위한 변환
			avg2 = Convert.ToDouble(ko2 + math2)/2;
			avg3 = (avg1 + avg2)/2; //평균계산

			name1 = "홍길동";
			name2 = "차용빈"; //이름 설정

			Console.WriteLine("{0} 평균 {1}", name1, avg1);
			Console.WriteLine("---------------");
			Console.WriteLine("{0} 평균 {1}", name2, avg2);
			Console.WriteLine("---------------");
			Console.WriteLine(" 총평균  {0}", avg3);
		}
	}
}
