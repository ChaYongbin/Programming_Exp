using System;

namespace Add1 {
	class Addlab1 {
		public static void Main(string[] args) {
			Console.WriteLine("행 * 열을 입력해주세요.");

		string line = Console.ReadLine();
		string[] words = line.Split(' ');
		int r = Convert.ToInt32(words[0]);
		int c = Convert.ToInt32(words[1]);
		int[,] arr = new int[r,c];

		for (int i = 0; i < r;  i++) {
			for (int j = 0; j < c; j++) {
				arr[i, j]= (i + 1)*(j + 1);
				Console.Write("{0}  ", arr[i, j]);
			}
			Console.WriteLine();
		}	
		}
	}
}

			
		
