//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
double k1 = ConsoleInput("k1");
double k2 = ConsoleInput("k2");
double b1 = ConsoleInput("b1");
double b2 = ConsoleInput("b2");

double ConsoleInput(string Point){
    Console.WriteLine("Введите значение точки - "+ Point);
    double input = Convert.ToInt32(Console.ReadLine());
    return input;
}

double x = (b2 - b1)/(k1 - k2);
double y = k2 * x + b2;
Console.WriteLine("Точка пересечения x = "+ x);
Console.WriteLine("Точка пересечения y - "+ y);