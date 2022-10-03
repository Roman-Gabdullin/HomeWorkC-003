// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

void QueryCall(string numDot)
{
    Console.WriteLine($"Введите координаты {numDot} точки:");
}

int Coor (string Coor)
{
    Console.Write($"{Coor}:");
    return Convert.ToInt16(Console.ReadLine());
}

QueryCall("1");
int x1 = Coor("x");
int y1 = Coor("y");
int z1 = Coor("z");

QueryCall("2");
int x2 = Coor("x");
int y2 = Coor("y");
int z2 = Coor("z");

double result(double x1, double x2, double y1, double y2, double z1, double z2)
{
     return Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2) + Math.Pow((z2-z1), 2));
}

double Result = Math.Round(result(x1, x2, y1, y2, z1, z2), 2); 

Console.WriteLine($"Расстояние между точками = {Result}");