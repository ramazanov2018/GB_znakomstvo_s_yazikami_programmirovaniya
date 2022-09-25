//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
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

int MinMaxDifference(int[] array){
    int min = array[0];
    int max = array[0];
    int diff = 0;

    for(int i = 0 ; i < array.Length; i++)
    {
       if(array[i] > max)
       {
            max = array[i];
       }
       if(array[i] < min)
       {
            min = array[i];
       }
    }

    return (max - min);
}

Console.WriteLine("разницу между максимальным и минимальным чиселом = " + MinMaxDifference(FillArray(array_length)));