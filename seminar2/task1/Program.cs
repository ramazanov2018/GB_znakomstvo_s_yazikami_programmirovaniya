
//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int GetSecondNumber(int number)
{
    int secondNumber = (number%100)/10;
    return secondNumber;
}
Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int secondNumber = GetSecondNumber(number);
Console.Write("Второе число = "+ secondNumber);
