
// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
bool IsWeekend(int Number){
    bool res;
    if (Number == 6 || Number == 7)
    {
        res = true;
    }
    else 
    {
         res = false;
    }

    return res;
}

Console.Write("Введи число: ");
int Number = Convert.ToInt32(Console.ReadLine());
bool weekend = IsWeekend(Number);

if(weekend)
{
    Console.Write("Да");
}
else
{
    Console.Write("Нет");
}