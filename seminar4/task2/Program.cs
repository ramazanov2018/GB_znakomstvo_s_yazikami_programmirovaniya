// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine("Введите число");
bool isNumber = int.TryParse(Console.ReadLine(), out int number);
double GetNumberSumm(double number){
    double summ = 0;
    double tmp;
    while(number > 0){
        tmp = number%10;
        summ = summ + tmp;
        number = (number - tmp)/10;
    }

    return summ;
}

if(isNumber){
    double result = GetNumberSumm(number);
    Console.WriteLine("Результат:" + result);
}
else
{
    Console.WriteLine("Ввели не корректное число");
}
