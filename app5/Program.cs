
void FillArray(int[,] arr,int n)
{
    int num = 1;
    for (int temp = 0; temp < n - 2; temp++)
    {
        for (int i = 0 + temp; i < n - temp; i++)
        {
            arr[0 + temp, i] = num;
            num++;
        }
        num--;
        for (int i = 0 + temp; i < n - temp; i++)
        {
            arr[i, n - 1 - temp] = num;
            num++;
        }
        num--;
        for (int i = n - 1 - temp; i >= 0 + temp; i--)
        {
            arr[n - 1 - temp, i] = num;
            num++;
        }
        num--;
        for (int i = n - 1 - temp; i >= 1 + temp; i--)
        {
            arr[i,0+temp]=num;
            num++;
        }
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
Console.WriteLine("Введите размер равностороннего массива:");
int arrayBound = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[arrayBound,arrayBound];
FillArray(array, arrayBound);
PrintArray(array);
