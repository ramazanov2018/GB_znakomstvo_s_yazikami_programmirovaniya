//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
Console.WriteLine("Введите количество строк в массиве:");
bool isNumberM = int.TryParse(Console.ReadLine(), out int m);

Console.WriteLine("Введите количество столбцов в массиве:");
bool isNumberN = int.TryParse(Console.ReadLine(), out int n);

double[,] GenerateArr(int m, int n)
{
    double[,] numbers = new double[m, n];
    Random rnd = new Random();
    for(int i = 0; i < numbers.GetLength(0); i++){
        for(int j = 0; j < numbers.GetLength(1); j++){
            numbers[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
    return numbers;
}

void ArrPrint(double[,] numbers)
{
    for(int i = 0; i < numbers.GetLength(0); i++){
        for(int j = 0; j < numbers.GetLength(1); j++){
            Console.WriteLine(numbers[i, j]) ;
        }
    }
}

if(isNumberM && isNumberN)
{
    double[,] numbers = GenerateArr(m, n);
    ArrPrint(numbers);
}
else
{
    Console.Write("Ввели не корректные данные");
}