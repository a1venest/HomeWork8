int GetNumberFromConsole(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int GetNumberValue(int minValue, int maxValue)
{
    return new Random().Next(minValue, maxValue + 1);
}

void FillArray(int[,] arr, int minValue, int maxValue)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = GetNumberValue(minValue, maxValue);
        }
    }
}

void SumLine(int[,] arr, int[,] arrSum)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum = sum + arr[i, j];
            if (j == arr.GetLength(1) - 1)
            {
                arrSum[i, 0] = sum;

            }

        }
        Console.WriteLine($"Сумма чисел {i+1} строки равняется: {sum}");
    }
}



void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void MinSumLine(int[,] arr)
{
    int min = arr[0, 0];
    for (int i = 1; i < arr.GetLength(0); i++)
    {
        if (arr[i, 0] < min)
        {
            min = arr[i, 0];
        }
    }
    for (int j = 0; j < arr.GetLength(0); j++)
    {
        if (min == arr[j, 0])
        {
            Console.WriteLine($"Строка с минимальной суммой {j + 1}");
        }
    }
}

int[,] InitializateArray(int m, int n)
{
    return new int[m, n];
}

int m = GetNumberFromConsole("Введите размерность массива: m");
int n = GetNumberFromConsole("Введите размерность массива: n");
int[,] array = InitializateArray(m, n);
int maxValue = GetNumberFromConsole("Введите максимальное допустимое число в массиве:");
int minValue = GetNumberFromConsole("Введите минимальное допустимое число в массиве:");
int[,] sumArray = new int[array.GetLength(0), 1];
FillArray(array, minValue, maxValue);
PrintArray(array);
Console.WriteLine();
SumLine(array, sumArray);
MinSumLine(sumArray);
