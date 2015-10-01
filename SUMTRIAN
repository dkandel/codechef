using System;
using System.Collections.Generic;

public class SUMTRIAN
{
	public static void Main()
	{
		String input = Console.ReadLine();
		int inputCount;
		if (!int.TryParse(input, out inputCount))
		{
			return;
		}

		int N = 0;
		for (int i = 0; i < inputCount; i++)
		{
			input = Console.ReadLine();
			if (!int.TryParse(input, out N))
			{
				return;
			}

			List<int> inputs = new List<int>();
			for (int j = 0; j < N; j++)
			{
				string[] inputS = Console.ReadLine().Trim().Split(' ');
				for (int k = 0; k < inputS.Length; k++)
				{
					inputs.Add(int.Parse(inputS[k]));
				}
			}
			foreach(var v in inputs){
			Console.WriteLine(v/2+1);
			}

		}
	}
}
