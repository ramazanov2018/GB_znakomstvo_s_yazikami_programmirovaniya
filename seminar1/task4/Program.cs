

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write("Введите число: ");
int b = Convert.ToInt32(Console.ReadLine());
int i = 1;
while(i <= b){
    int ost = i % 2;
    if(ost == 0 ){
        Console.Write(i+",");
    }
    i++;
}