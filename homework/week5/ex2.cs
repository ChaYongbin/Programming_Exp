using System;

public class Ex1 {
	public static void Method() {
		int x = 50;
		Console.WriteLine("Method x: {0}", x);
	}

	static void Main(string[] args) {
		int x = 20;
		Console.WriteLine("Main x: {0}", x);
		Method();
		Console.WriteLine("Main x: {0}", x);
	}
}

