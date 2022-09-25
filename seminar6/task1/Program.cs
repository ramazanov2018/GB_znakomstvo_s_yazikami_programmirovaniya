//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.WriteLine("Введите длину массива");

int array_length = Convert.ToInt32(Console.ReadLine());

int[] GetArrNumbers(int array_length){
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

int GetCount(int[] numbers){
    int sum = 0;
    for(int i = 0; i < numbers.Length; i++){
        if(numbers[i] > 0){
            sum++;
        }
    }
    return sum;
}
int[] arrNumbers = GetArrNumbers(array_length);
Console.WriteLine("Количество чисел больше 0 = " + GetCount(arrNumbers));