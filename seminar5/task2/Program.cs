
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
int Sum(int[,] array){
    int sum = 0;
    int count =0;
    if(array.GetLengch(0)< array.GetLengch(1)){
        count = array.GetLengch(0);
    }
    else{
        count = array.GetLengch(1);
    }

    for (int i = 0; i < count; i++)
    {
        sum = array[i, i];
    }
    return sum;
}
int[,]array = Create2dArray(1,9, 3,3);
Show2dArray(array);
Console.WriteLine();
Console.Write(Sum,(array));