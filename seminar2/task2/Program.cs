
//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
string isThirdNumberMsg(int Number){
    string msg;
    string NumberText = Convert.ToString(Number);
    
    if (NumberText.Length > 2)
    {
        msg = "третья цифра " + NumberText[2];
    }
    else 
    {
        msg = "третьей цифры нет";
    }
    return msg;
}

Console.Write("Введи число: ");
int Number = Convert.ToInt32(Console.ReadLine());
string msg = isThirdNumberMsg(Number);

Console.Write(msg);
