// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Введите пятизначное число");
bool isNumber = int.TryParse(Console.ReadLine(), out int number);

bool NumberCount(int number){
    if(number > 9999 && number < 100000)
    {
        return true;
    }
    return false;
}

bool isPollindrom(int number){
    string arNumbers = Convert.ToString(number);
    if(arNumbers[0] == arNumbers[4] && arNumbers[1] == arNumbers[3])
    {
        Console.Write("Число является полиндромом");
        return false;
    }
    Console.Write("Число не является полиндромом");
    return true; 
}

if(isNumber && NumberCount(number))
{
    isPollindrom(number);
}
else
{
    Console.Write("Ввели не корректное число");
}