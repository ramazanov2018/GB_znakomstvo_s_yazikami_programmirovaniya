// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.WriteLine("Введите число A:");
bool isNumberA = int.TryParse(Console.ReadLine(), out int a);
Console.WriteLine("Введите число B:");
bool isNumberB = int.TryParse(Console.ReadLine(), out int b);
if(isNumberA && isNumberB){
    double result = Math.Pow(a, b);
    Console.WriteLine("Результат:" + result);
}
else
{
    Console.WriteLine("Ввели не корректное число");
}

