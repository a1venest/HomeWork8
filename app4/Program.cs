int GetNumberFromConsole(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int GetNumberValue(int minValue, int maxValue)
{
    return new Random().Next(minValue, maxValue + 1);
}

void FillArray(int[,,] arr, int minValue, int maxValue)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                arr[i, j, k] = GetNumberValue(minValue, maxValue);
            }
        }
    }
}

void PrintArray(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
                Console.Write($"{arr[i, j, k]}({i}, {j}, {k}) ");
        }
        Console.WriteLine();
    }
}

int[,,] InitializateArray(int m, int n, int l)
{
    return new int[m, n, l];
}

int m = GetNumberFromConsole("Введите размерность массива: m");
int n = GetNumberFromConsole("Введите размерность массива: n");
int l = GetNumberFromConsole("Введите размерность массива: l");
int[,,] array = InitializateArray(m, n, l);
int maxValue = GetNumberFromConsole("Введите максимальное допустимое число в массиве:");
int minValue = GetNumberFromConsole("Введите минимальное допустимое число в массиве:");
FillArray(array, minValue, maxValue);
PrintArray(array);
