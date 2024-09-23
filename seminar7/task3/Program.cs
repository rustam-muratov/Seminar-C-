
// Семинар 7. Рекурсия

// Считать строку с консоли, содержащую латинские буквы. 
// Вывести на экран согласные буквы этой строки.
// Указание
// Использовать рекурсию. Не использовать цикл.
// Пример

// “hello” => h l l
// “World” => W r l d
// “Hello world!” => H l l w r l d



void GetOnlySoglLetters(string letters)
{
    string glasniye = "euaioy";

    if (letters.Length < 1)
    {
        return;
    }
    if (char.IsLetter(letters[0]) && !glasniye.Contains(char.ToLower(letters[0])))
    {
        System.Console.WriteLine($"{letters[0]} ");
    }
    GetOnlySoglLetters(letters.Substring(1));

}
string letters = Console.ReadLine()!;
GetOnlySoglLetters(letters);