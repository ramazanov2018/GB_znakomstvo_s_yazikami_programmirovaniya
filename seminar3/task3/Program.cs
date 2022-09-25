// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Введите число");
bool isNumber = int.TryParse(Console.ReadLine(), out int number);

void PowMsg(int number, int exponent){
    for(int i = 1; i <= number; i++)
    {
        double result = Math.Pow(i, exponent);
        Console.Write(result + ", ");
    }
}

if(isNumber && number > 0)
{
    PowMsg(number, 3);
}
else
{
    Console.Write("Ввели не корректное число");
}