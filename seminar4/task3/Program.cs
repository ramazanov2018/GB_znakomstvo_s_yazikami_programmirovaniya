//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
Console.WriteLine("Введите длину массива");

int array_length = Convert.ToInt32(Console.ReadLine());

int[] FillArray(int array_length){
    int[] array = new int[array_length];

    Console.WriteLine("Введите значение массива через запятой(,)");
    string input = Console.ReadLine();
    string[] inputArray = input.Split(',');

    for(int i = 0 ; i < inputArray.Length && i < array_length; i++)
    {
        array[i] = Convert.ToInt32(inputArray[i]);
    }
    return array;
}

void PrintArray(int[] array){

    for(int i = 0 ; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
}

int [] result = FillArray(array_length);
PrintArray(result);