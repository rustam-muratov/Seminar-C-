
// Семинар 1. Знакомство с языками программирования
// Напишите программу, которая принимает на вход
// трёхзначное целое число и на выходе показывает сумму
// первой и последней цифры этого числа.
// 456 => 10
// 782 => 9
// 918 => 17

// int num = 567;
// int first = num / 100;
// int last = num % 100 % 10;
// int sum = first + last;
// Console.Write(sum);

int num = 234;
int first = num / 100;
int second = num % 10;
int sum = first + second;
Console.Write(sum);