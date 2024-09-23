// Задание 2. Работа в сессионных залах
// Семинар 6. Массивы и строки
// На основе символов строки (тип string) сформировать массив 
// символов (тип char[]). Вывести массив на экран.
// Указание
// Метод строки ToCharArray() не использовать.
// Пример
// “Hello!” => [‘H’, ‘e’, ‘l’, ‘l’, ‘o’, ‘!’ ] 

char[] ToCharArray(string input)
{
    char[] array = new char[input.Length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = input[i];

    }
    return array;
}
void PrintArray(char[] array)
{
    foreach (char c in array)
    {
        Console.Write(c + " ");
    }
    Console.WriteLine();
}



Console.Clear();
Console.WriteLine("Введите строчку: ");
string input = Console.ReadLine();
char[] array = ToCharArray(input);

Console.WriteLine(" Полученый массив: ");
PrintArray(array);


