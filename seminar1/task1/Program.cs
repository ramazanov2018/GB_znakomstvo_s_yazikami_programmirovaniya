﻿

// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

if(a > b ){
    Console.Write("Число: "+a+" больше числа: "+b);
}else if(a < b ){
    Console.Write("Число: "+a+" меньше числа: "+b);
}else{
    Console.Write("Число: "+a+" ровно числа: "+b);
}



