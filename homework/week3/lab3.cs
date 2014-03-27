using System;

namespace Lab3
{
	public class Student
	{
		public String name;
		public int kor;
		public int math;
		public double avg;
	}

	class Test
	{
		static void Main(string[] args)
		{
			Student s1;
			s1 = new Student();
			s1.name = "Cha";
			s1.kor = 80;
			s1.math = 90;
			s1.avg = Convert.ToDouble(s1.kor+s1.math)/2;

			Student s2;
			s2 = new Student();
			s2.name = "Gang";
			s2.kor = 60;
			s2.math = 40;
			s2.avg = Convert.ToDouble(s2.kor+s2.math)/2;

			double tav;
			tav = (s1.avg + s2.avg)/2;

			Console.WriteLine("{0}의 평균은 {1}입니다.", s1.name, s1.avg);
			Console.WriteLine("{0}의 평균은 {1}입니다.", s2.name, s2.avg);
			Console.WriteLine("{0}과 {1}의 평균값은 [{2}]입니다.", s1.name, s2.name, tav);
		}
	}
}
			
