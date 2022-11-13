//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


// 1. задать число строк/ столбцов
int NumOfText(string text)
{
    Console.WriteLine($"Введите число {text}");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
// 2. создать массив состоящий из заданных значений
int[,] CreatArray(int m, int n)
{
    return new int[m, n];
}
// 3. заполнить  созданный массив.
void Fill_MxN_Array_Random(int[,] ar, int min, int max)
{
    for (int i = 0; i < ar.GetLength(0); i++)
    {
        for (int j = 0; j < ar.GetLength(1); j++)
        { ar[i, j] = new Random().Next(min, max); }
    }
}
// 4. вывод на печать массива
void Print_MxN_Array(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++, Console.WriteLine(" "))
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "\t");
        }
    }
}
// 5. найти среднее арифметическое элементов в столбце 
// 6. вывод на печать средне арифметическое элементов столбца
double Find_ArithmeticMean_ColumnArray(int[,] array)
{
    int m = array.GetLength(0);
    int n = array.GetLength(1);
    double ArithmeticMean = 0;
    for (int j = 0; j< n; j++)
    { ArithmeticMean = 0;
        for (int i = 0; i < m; i++)
        {ArithmeticMean += array[i, j];}
        ArithmeticMean /=m;
        Console.Write($"{ArithmeticMean:f2}\t");
    }return ArithmeticMean;
}


Console.Clear();
int M = NumOfText("Строк:");
int N = NumOfText("Столбцов:");
int[,] array = CreatArray(M, N);
Fill_MxN_Array_Random(array, 0, 25);
Console.WriteLine("Получен следующий двумерный массив:");
Print_MxN_Array(array);
Console.WriteLine("Получены следующие средне-арифметические значения элементов столбцов:");
double A = Find_ArithmeticMean_ColumnArray(array);
