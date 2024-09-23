using System.Data;
using Internal;
using System;
// Задание 3. Совместная работа
// Семинар 5. Двумерные массивы
// 20 мин
// Задайте двумерный массив из целых чисел. Сформируйте новый
// одномерный массив, состоящий из средних арифметических
// значений по строкам двумерного массива.
// Пример
// 2 3 4 3
// 4 3 4 1 => [3 3 5]
// 2 9 5 4
int[,] Create2dArray(int min, int max, int rows, int cols)
{
    int[,] array = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            array[i, j] = new Random().Next(min, max + 1);
        }
    }
    return array;
}
void Show2dArray(int[,] array)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Consol.WriteLine();
    }
}

 
int ArithmeticMaen(int[,]array){
    int array2 = new int [array.GetLengch(0)];
    int sum =0;

    for(int i =0;i < array.GetLengch(0);i++){
        for(int j =0 ;j < array.GetLengch(1);j++){
            int sum += array[i,j] ;

        }
        array2 = sum/ array.GetLengch(1);
    }
    return array2;
}
Console.WriteLine(" Введите минемальное значение массива: ")
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" Введите максимальное значение массива: ")
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" Введите количиство строк в массиве: ")
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" Введите количество столбцов в массиве: ")
int cols = Convert.ToInt32(Console.ReadLine());

 int matrix = Create2dArray(int min, int max, int rows, int cols);
 Show2dArray(matrix);
 int array = 
