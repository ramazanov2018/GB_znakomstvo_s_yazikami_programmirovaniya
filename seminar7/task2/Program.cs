//Напишите программу, которая на вход принимает число и ищет в двумерном массиве, и возвращает индексы этого элемента или же указание, что такого элемента нет.
int[,] ArrNumbers = { { 1, 4, 7, 2 }, { 5, 9, 2, 3 },{ 8, 4, 2, 4 } };

Console.WriteLine("Введите число для поиска:");
int number = Convert.ToInt32(Console.ReadLine());

bool PrintPosition(int number, int[,] ArrNumbers)
{
    for(int i = 0; i < ArrNumbers.GetLength(0); i++){
        for(int j = 0; j < ArrNumbers.GetLength(1); j++){
            if(number == ArrNumbers[i,j]){
                Console.WriteLine("["+i+","+j+"]") ;
                return true;
            }
        }
    }
    return false;
}
PrintPosition(number, ArrNumbers);