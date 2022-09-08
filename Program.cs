int[,] array = new int[10,7];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next();
    }
}































void Print(int[,] _array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{ array[i, j]} ");
        }
        Console.WriteLine();
    }
}
