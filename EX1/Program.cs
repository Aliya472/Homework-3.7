//* Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

// 1. функция ввод числа 
int Num() 
{ 
    Console.WriteLine("Введите число "); 
    int n = Convert.ToInt32(Console.ReadLine()); 
    return n; 
} 
// 2. запрос количества строк 
int Rows_OR_Columbs_Num(string text) 
{ 
    Console.WriteLine($"Введите число {text}"); 
    int n = Convert.ToInt32(Console.ReadLine()); 
    return n; 
} 
// 3. Запрос количества столбцов 
// 4. создание массива 
double[,] Creat_MxN_Array(int m, int n) 
{ 
    return new double[m, n]; 
} 
// 5. заполнение массива 
void Fill_MxN_Array_Random(double[,] a,  int max) 
{ 
    for (int i = 0; i < a.GetLength(0); i++) 
    { 
        for (int j = 0; j < a.GetLength(1); j++) 
        { 
            a[i, j] = new Random().NextDouble()*max; 
            //a[i, j] = Random.Shared.Next(min, max); 
        } 
    } 
} 
// 6. вывод заполненного массива на печать 
void PrintArray(double[,] N) 
{ 
    for (int i = 0; i < N.GetLength(0); i++, Console.WriteLine("")) 
    { 
        for (int j = 0; j < N.GetLength(1); j++) 
        { Console.Write($"{N[i, j]:f2} \t");} 
    } 
} 
 
 
 
Console.Clear(); 
int a = Rows_OR_Columbs_Num("строк"); 
int b = Rows_OR_Columbs_Num("столбцов"); 
double[,] array = Creat_MxN_Array(a, b); 
Fill_MxN_Array_Random(array, 25); 
Console.WriteLine(""); 
PrintArray(array);

