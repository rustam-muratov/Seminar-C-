

// string ReversString(string input)
// {
//     string result = "";
//     for (int i = input.Length - 1; i > -1; i++)
//     {
//         result += input[i];
//     }
//     return result;
// }
// Console.WriteLine($" Перевернутая строка:\n{ReversString(input)}");
// Преобразовать строку в массив строк разделенные пробелом.
int CountString(string input)
{
    int count = 1;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == ' ')
        {
            count++;
        }
    }
    return count;
}
string SplitString(string input)
{
    string[] answer = new string[CountString(input)];
    int count = 0;

    for (int i = 0; i < input.Length; i++)
    {
       
        if (input[i] == ' ')
        {
            answera[count] = result;
            result = "";
            count++;
        }
        else 
        {
            result += input[i];
        }
    }
    answera[count] = result;
    return answer;
}
void PrintArray(string[] array)
{
    foreach (string c in array)
    {
        Console.Write(c + " ");
    }
    Console.WriteLine();
}


Console.Clear();
Console.WriteLine("Введите строчку: ");
string input = Console.ReadLine()!;
string[] array = SplitString(input);
PrintArray(array);