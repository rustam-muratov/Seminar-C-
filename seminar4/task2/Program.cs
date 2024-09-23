
// Семинар 4. Функции

// Задайте массив из N случайных целых чисел (N вводится с
// клавиатуры).
// Найдите количество чисел, которые оканчиваются на 1 и
// делятся нацело на 7

// Пример
// [1 5 11 21 81 4 0 91 2 3]
// => 2

int[] CreateRandomArray(int min, int max, int size){
    int[] array = new int [size];
    for(int i = 0; i< size;i++){
        array[i]= new Random().Next(min,max+1);
    }
    return array;
}

void ShowArray(int[] array){
    foreach(int item in array){
        Console.Write(item+ " ");
    }
}
Console.WriteLine("Input min value: ");
int minimum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max value: ");
int maxsimum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input size value: ");
int lenght = Convert.ToInt32(Console.ReadLine());

int [] array = CreateRandomArray(minimum, maxsimum, lenght);
ShowArray(array);
