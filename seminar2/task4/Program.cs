﻿
// Напишите программу, которая выводит третью с
// конца цифру заданного числа или сообщает, что
// третьей цифры нет.

// 456 => 6
// 7812 => 8
// 91 => Третьей цифры нет

int num = 7812;

if (num > 99){
    while(num>= 1000){
        num/=10;
        Console.Write(num%10);
    }
}
else{
    Console.Write("нет третьей цифры");
}