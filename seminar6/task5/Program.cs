//Ввести строку, ввести символ, найти, сколько раз этот символ встречается в строке
Console.Clear();
Console.WriteLine("Введите строчку: ");
string stroka = Console.ReadLine();
Console.WriteLine("Введите символ: ");
char simval = Console.ReadLine()[0];

int count = 0;
foreach (char item in stroka)
{
    if (item == simval)
    {
        count++;
    }
}
Console.WriteLine($"Количество символов{simval}");
Console.WriteLine(count);
