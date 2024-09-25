namespace EvenOddNumbersApp
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

		static bool IsEven(int n)
		{
			if (n % 2 == 0)
				return true;
			else
				return false;
		}

		static bool IsOdd(int n)
		{
			if (n % 2 != 0)
				return true;
			else
				return false;
		}

		static void Main(string[] args)
		{
			int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

			PrintNumbers("Numbers", nums);
			PrintNumbers("Even No", nums.Where(x => IsEven(x)));
			PrintNumbers("Odd No", nums.Where(x => IsOdd(x)));
		}
	}
}
