//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
Console.WriteLine("Введите длину массива");

int array_length = Convert.ToInt32(Console.ReadLine());

int[] GenerateArrNumbers(int array_length){
    int[] Nembers = new int[array_length];
    Random rnd = new Random();

    for(int i = 0; i < Nembers.Length; i++){
        Nembers[i] = rnd.Next(1, 100);
    }
    return Nembers;
}

int GetOddNemberSum(int[] numbers){
    int sum = 0;
    for(int i = 0; i < numbers.Length; i++){
        if(numbers[i]%2 > 0){
            sum = sum + numbers[i];
        }
    }
    return sum;
}
Console.WriteLine("Сумма нечетных чисел = " + GetOddNemberSum(GenerateArrNumbers(array_length)));