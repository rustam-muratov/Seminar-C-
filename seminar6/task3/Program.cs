using System;
// Считать строку с консоли, состоящую из латинских 
// букв в нижнyем регистре. Выяснить, сколько среди 
// введённых букв гласных.
// Пример
// “hello” => 2
// “world” => 1
// int countGlasniyeArray(string array){
//     int count = 0;
//     for(int i = 0; i < array.Length; i++){
//         if (array [i] == 'a'||array [i] == 'e'||array [i] == 'u'||array [i] == 'q'||array [i] == 'o'||array [i] == 'j'){
//             count ++;
//         }
//     }
//     return count;
// 

bool isLetterVowels(char)
{
    char[] vowels = { 'a', 'e', 'i', 'u', 'q', 'j' };
    foreach(char item in vowels)
    {
        if (vowels == item)
        {
            return true;
        }
    }
    return false;
}
int countGlasniyeArray(string array)
{

    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (isLetterVowels(array[i]))
        {
            count++;
        }
    }
    return count;
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
Console.WriteLine($"Количество гласных букв в строке:\n{countGlasniyeArray(input)}");
