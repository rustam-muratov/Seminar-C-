using System.ComponentModel;
using System;
int[,] CreateMatrix(int rowCount, int colunsCount){
    int[,] array = new int[ rowCount, colunsCount];

    Random rnd = new Random();
    for (int i = 0; i <array.GetLength(0); i++) //проход по строкам
    {
        for (int j = 0; j < array.GetLength(1); j++)//проход по столбцам
        {

            array[i, j] = rnd.Next(1, 11);
        }
    }
    return array;
}

void ShowMatrix(int[,]array){
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j <array.GetLength(1); j++)
        {

            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}


int FindMaxInRows(int[,]array){
    
    for(int i =0;i<arrayGetLingth(0);i++){
        int max = array[i];
        for(int j =0;j<arrayGetLingth(1);j++){
           if( array[i]<array[i]+1){
            arrayp[i,j] = max;
           }
        }
    }
    return max;
}
int[,] array = CreateMatrix(4, 5);
ShowMatrix(array);
С