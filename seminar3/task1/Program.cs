
// Семинар 3. Массивы

// Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве. Программа
// должна выдать ответ: Да/Нет.

// Примеры
// [1 3 4 19 3], 8 => Нет
// [-4 3 4 1], 3 => Да

int num = 8;
int[] array = new int [] { 1, 3, 4, 19, 3 };

bool flag = false;

foreach (int item in array)
{
    if (item ==num)
    {
        flag = true;
    }

}
if (flag){
    Console.Write("Да");

}
else{
    Console.Write("Нет");
}