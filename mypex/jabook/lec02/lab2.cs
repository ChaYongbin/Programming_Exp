using System;

class lab2 { // if구문 연습
	public static void Main() {
		Console.WriteLine("나이를 입력해주세요");
		Console.Write("나이 : ");
		int age = Convert.ToInt32(Console.ReadLine());
		if (age < 20 )
			Console.WriteLine("미성년자 입니다.");
		else
			Console.WriteLine("성인입니다.");
	}
}


