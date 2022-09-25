

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());

if(a > b && a > c){
    Console.Write("максимальное число: = "+a);
}else if(b > a && b > c){
    Console.Write("максимальное число: = "+b);
}else if(c > a && c > b){
    Console.Write("максимальное число: = "+c);
}else{
    Console.Write("числа равны:");
}