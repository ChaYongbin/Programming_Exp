using System;

class lab3 { // while test
	public static void Main(){
		int i = 0;
		int sum = 0;
		while (i <= 100) {
			sum += i;
			i ++;
			Console.WriteLine(sum);
		}
		Console.WriteLine("sum : {0}", sum);
	}
}
