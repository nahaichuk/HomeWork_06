static void BubbleSort(int[] array, String sortType, int y = 0)
{
    switch (sortType)
    {
		case "Selection":
			for (int i = 0; i < array.Length - 1; i++)
			{
				//поиск минимального числа
				int min = i;
				for (int j = i + 1; j < array.Length; j++)
				{
					if ((array[j] < array[min] & y == 0)
						^ (array[j] > array[min] & y == 1))
					{
						min = j;
					}
				}
				//обмен элементов
				int temp = array[min];
				array[min] = array[i];
				array[i] = temp;
			}
			break;
		case "Bubble":
			
			for (int i = 0; i < array.Length; i++)
				for (int j = 0; j < array.Length - 1; j++)
					if ((array[j] > array[j + 1] & y == 0)
						^ (array[j] < array[j + 1] & y == 1))
					{
						int t = array[j + 1];
						array[j + 1] = array[j];
						array[j] = t;
					}
			break;

		case "Insertion":
			for (int i = 1; i < array.Length; i++)
			{
				int k = array[i];
				int j = i - 1;

				while ((j >= 0 && array[j] > k & y == 0)
					^ (j >= 0 && array[j] < k & y == 1))
				{
					array[j + 1] = array[j];
					array[j] = k;
					j--;
				}
			}

			break;
	} 
    //
	
	
}

static void Out1()//
{
	int[] array = { 5, 3, 4, 9, 7, 2, 1, 8, 6 };
	BubbleSort(array, "Selection", 0);
    foreach (int e in array)
	{
        Console.Write(e);
	}
	Console.WriteLine();
}
static void Out2()//
{
	int[] array = { 5, 3, 4, 9, 7, 2, 1, 8, 6 };
	BubbleSort(array, "Selection", 1);
	foreach (int e in array)
	{
		Console.Write(e);
	}
	Console.WriteLine();
}
static void Out3()//
{
	int[] array = { 5, 3, 4, 9, 7, 2, 1, 8, 6 };
	BubbleSort(array, "Bubble", 0);
	foreach (int e in array)
	{
		Console.Write(e);
	}
	Console.WriteLine();
}
static void Out4()
{
	int[] array = { 5, 3, 4, 9, 7, 2, 1, 8, 6 };
	BubbleSort(array, "Bubble", 1);
	foreach (int e in array)
	{
		Console.Write(e);
	}
	Console.WriteLine();
}
static void Out5()
{
	int[] array = { 5, 3, 4, 9, 7, 2, 1, 8, 6 };
	BubbleSort(array, "Insertion", 0);
	foreach (int e in array)
	{
		Console.Write(e);
	}
	Console.WriteLine();
}
static void Out6()
{
	int[] array = { 5, 3, 4, 9, 7, 2, 1, 8, 6 };
	BubbleSort(array, "Insertion", 1);
	foreach (int e in array)
	{
		Console.Write(e);
	}
	Console.ReadKey();
}

Out1();
Out2();
Out3();
Out4();
Out5();
Out6();
//checked
