﻿namespace EvenOddNumbersApp
{
	internal class Program
	{
		static void PrintNumbers(string title, IEnumerable<int> numbers)
		{
            Console.Write($"{title}: [");
			foreach (var n in numbers)
				Console.Write($"{n},");
            Console.Write("]");
            Console.WriteLine();
		}

		static bool IsEven(int n) => n % 2 == 0;

		static bool IsOdd(int n) => !IsEven(n);

		static void Main(string[] args)
		{
			int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

			PrintNumbers("Numbers", nums);
			PrintNumbers("Even No", nums.Where(x => IsEven(x)));
			PrintNumbers("Odd No", nums.Where(x => IsOdd(x)));
		}
	}
}
