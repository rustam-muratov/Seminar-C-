// Задание 1. Совместная работа
// Семинар 5. Двумерные массивы
// 15 мин
// Задайте двумерный массив. Найдите элементы, у которых оба
// индекса чётные, и замените эти элементы на их квадраты.
// Пример

// 2 3 4 3
//  4 3 4 1 =>
//  2 9 5 4

// Обсудить этапы решения задачи
// Оформить этапы в виде функций

// 4 3 4 3
// 4 3 4 1
// 2 9 25 4

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

 void MakeSquarti(int[,]array){
    for(int i = 0;i < array.Length(0); i ++){
        for(int j = 0;j < array.Length(1); j ++){
            array[i,j] *= array[i,j];
        }
    }
    return array;
 }
 int[,] matrix = Create2dArray(1,9,3,3);
Show2dArray(matrix);
Console.WriteLine();
int[,] matrix2 = MakeSquares(matrix);
Show2dArray(matrix2);