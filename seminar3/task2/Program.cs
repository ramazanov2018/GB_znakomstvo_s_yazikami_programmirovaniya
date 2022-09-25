﻿//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
int x1 = Coordinate("x1", "A");
int y1 = Coordinate("y1", "A");
int z1 = Coordinate("z1", "A");
int x2 = Coordinate("x2", "B");
int y2 = Coordinate("y2", "B");
int z2 = Coordinate("z2", "B");

int Coordinate(string coorName, string pointName){
    Console.Write("Введите координату "+coorName+" точки "+pointName + ":");
    return Convert.ToInt16(Console.ReadLine());
}

double Distance(double x1, double y1, double z1, double x2, double y2, double z2){
    return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
}

double distance = Math.Round(Distance(x1, y1, z1, x2, y2, z2), 2);
Console.Write("Расстояние = " + distance);
