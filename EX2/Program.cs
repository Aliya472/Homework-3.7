/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

// 1. функция ввод числа 
int Num() 
{ 
    Console.WriteLine("Введите число "); 
    int n = Convert.ToInt32(Console.ReadLine()); 
    return n; 
} 
// 2. запрос количества строк 
int NumOfText(string text) 
{ 
    Console.WriteLine($"Введите число {text}"); 
    int n = Convert.ToInt32(Console.ReadLine()); 
    return n; 
} 
// 3. Запрос количества столбцов 
// 4. создание массива 
int[,] Creat_MxN_Array(int m, int n) 
{ 
    return new int[m, n]; 
} 
// 5. заполнение массива 
void Fill_MxN_Array_Random(int[,] a, int min, int max) 
{ 
    for (int i = 0; i < a.GetLength(0); i++) 
    { 
        for (int j = 0; j < a.GetLength(1); j++) 
        { 
            a[i, j] = new Random().Next(min, max); 
            //a[i, j] = Random.Shared.Next(min, max); 
        } 
    } 
} 
// 6. вывод заполненного массива на печать 
void PrintArray(int[,] N) 
{ 
    for (int i = 0; i < N.GetLength(0); i++, Console.WriteLine("")) 
    { 
        for (int j = 0; j < N.GetLength(1); j++) 
        { Console.Write(N[i, j] + "\t"); } 
    } 
} 
//7. поиск значения в массиве 
string FindNumINArray(int[,] arr, int n) 
{ 
    string text = string.Empty; 
    int Row = arr.GetLength(0); 
    int Columb = arr.GetLength(1); 
    int i = n / Columb; 
    int j = n % Columb; 
    if (n <= Row * Columb) 
    {if (j == 0) {j = Columb;text = $"на позиции {n} находится число {arr[i-1, j-1]}";} 
        else text = $"на позиции {n} находится число {arr[i, j - 1]}";    } 
    else text = "такой позиции в масиве нет"; 
 
    return text; 
} 
//8. искомое значение 
// if (n <= Row * Columb) 
//     { 
//         if (j == 0) { if (i==0) {j = Columb;text = $"на позиции {n} находится число {arr[i, j]}";} 
//         else j = Columb; text = $"на позиции {n} находится число {arr[i, j]}"; } 
//         else text = $"на позиции {n} находится число {arr[i, j - 1]}"; 
//     } 
//     else text = "такой позиции в масиве нет"; 
 
 
Console.Clear(); 
int a = NumOfText("строк"); 
int b = NumOfText("столбцов"); 
int f = NumOfText("для поиска позиции"); 
int[,] array = Creat_MxN_Array(a, b); 
Fill_MxN_Array_Random(array, 0, 25); 
Console.WriteLine(""); 
PrintArray(array); 
string find = FindNumINArray(array, f); 
Console.WriteLine(find);