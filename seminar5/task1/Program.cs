//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
Console.WriteLine("Введите длину массива");

int array_length = Convert.ToInt32(Console.ReadLine());
int[] GenerateArrNumbers(int array_length){
    Random rnd = new Random();
    int[] Numbers = new int[array_length];

    for(int i = 0 ; i < array_length; i++)
    {
        Numbers[i] = rnd.Next(100, 999);
    }
    return Numbers;
}

int GetEvenCount(int[] numbers){
    int count = 0;
    for(int i = 0; i < numbers.Length; i++)
    {
        if(numbers[i]%2 == 0)
        {
            count++;
        }
    }
    return count;
}

Console.WriteLine("Количество чётных чисел = " + GetEvenCount(GenerateArrNumbers(array_length)));
