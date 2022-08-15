using System;

public enum orderBy
{
  Ascending,
  Descending
}
public enum SortAlgorithmType
{
	SelectionSort,
	BubbleSort,
	InsertionSort
}
class array1// name should follow to pascal notation
{
	static int fill(int[] array)
	{
		var Randomizer = new Random();

		for (int i = 0; i < array.Length; i++)
			array[i] = Randomizer.Next(100);

		return array.Length;
	}
	static void sort(int[] arr)
	{
		int n = arr.Length;

		for (int i = 0; i < n - 1; i++)
		{
			int min_idx = i;
			for (int j = i + 1; j < n; j++)
				if (arr[j] < arr[min_idx])
					min_idx = j;

			int temp = arr[min_idx];
			arr[min_idx] = arr[i];
			arr[i] = temp;
		}
	}
	static void bubbleSort(int[] arr)
	{
		int n = arr.Length;
		for (int i = 0; i < n - 1; i++)
			for (int j = 0; j < n - i - 1; j++)
				if (arr[j] > arr[j + 1])
				{
					int temp = arr[j];
					arr[j] = arr[j + 1];
					arr[j + 1] = temp;
				}
	}
	static void insertionSort(int[] arr)
	{
		int n = arr.Length;
		for (int i = 1; i < n; ++i)
		{
			int key = arr[i];
			int j = i - 1;

			while (j >= 0 && arr[j] > key)
			{
				arr[j + 1] = arr[j];
				j = j - 1;
			}
			arr[j + 1] = key;
		}
	}
	static void printArray(int[] arr)
	{
		int n = arr.Length;
		for (int i = 0; i < n; ++i)
			Console.Write(arr[i] + " ");

		Console.WriteLine();
	}
	static void switchCase(SortAlgorithmType switcher, int[] arr)//void name should follow to pascal notation
    {
		
		switch (switcher)
		{
			case SortAlgorithmType.SelectionSort:
				sort(arr);
				Console.WriteLine("Sorted array");

				break;
			case SortAlgorithmType.BubbleSort:
				bubbleSort(arr);
				Console.WriteLine("Sorted by bubble array algorithm");

				break;
			case SortAlgorithmType.InsertionSort:
				insertionSort(arr);
				Console.WriteLine("Sorted by insertion");

				break;

			default:
				Console.WriteLine("You've chosen the wrong action");
				break;
		}
	}
	static void OrderBy(orderBy switcher, int[] arr)
    {
		if (switcher == orderBy.Descending)
		{
			switchCase(SortAlgorithmType.SelectionSort, arr);
			Array.Reverse(arr);
		}
	}
	static void Main()
	{
		Console.WriteLine("Input size of your array");
		int size = Convert.ToInt32(Console.ReadLine());

		int[] arr = new int[size];

		fill(arr);
        Console.WriteLine("Filled array");

		Console.WriteLine("Input the way of sorting the array\n1.Selection\n2.Bubble\n3.Insertion\n4.Descendin");

		int switcher0 = Convert.ToInt32(Console.ReadLine());

		switch (switcher0)//try to arrange all your code with same indentations
        {
			case 1:
				switchCase(SortAlgorithmType.SelectionSort, arr);
				printArray(arr);
				break;
			case 2:	
				switchCase(SortAlgorithmType.BubbleSort, arr);
				printArray(arr);
				break;
			case 3:
				switchCase(SortAlgorithmType.InsertionSort, arr);
				printArray(arr);
				break;
			case 4:
				OrderBy(orderBy.Descending, arr);
				printArray(arr);
				break;
			default:
                Console.WriteLine("You put wrong action");
                break;
        }
    }
}
//checked
