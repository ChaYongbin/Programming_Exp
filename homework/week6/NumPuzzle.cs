using System;

public class NumPuzzle
{
	public string name;
	private int [,] mData;
	private int mSize;
	private int xZero, yZero;

	public void Init(int size)
	{
		mSize = size;
		mData = new int[size,size];
		for (int i = 0; i < size; i++)
			for (int j = 0; j < size ; j++)
				mData[i,j] = i * size + 1;
		mData[size-1,size-1] = 0;
		xZero = yZero = size -1;
	}
	public string FindMove()
	{

		string ret ="";
		return ret;
	}

	private void ZeroLocation()
	{
		for (int i = 0; i < mSize; i++)
			for (int j = 0; j < mSize; j++)
				if mData[i,j] == 0 {
					xZero = i;
					yZero = j;
					return;
				}
	}

	private bool IsMove(int row, int col)
	{
		ZeroLocation();
		
	}
}

class Test
{
	static void Fail(string msg) 
	{
		Console.WriteLine(msg);
		Environment.Exit(1);
	}
	static void Main()
	{
		NumPuzzle np =  new NumPuzzle();

		np.Init(3); // 1 2 3 4 5 6 7 8 9 0
		//init test
		if (np.mSize != 3) Fail("init test fail");
		if (np.mData[np.mSize-1,np.mSize-1] != 0) Fail("init test2 fail");

		Console.WriteLine("init test success");
		
		string av = np.FindMove();
		if(av != "6 8")
		{
			Console.WriteLine("test1 fail!!!");
			Environment.Exit(1);
		}
		
		Console.WriteLine("test1 success");

	}
}
