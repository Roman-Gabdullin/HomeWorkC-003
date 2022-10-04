// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число: ");
int Cube = Convert.ToInt32(Console.ReadLine());

string TablCubes (int cube)
{
    return $"{cube}     {Math.Pow(cube, 3)}";
}

for (int count = 1; count <= Cube; count++ )
{
    Console.WriteLine(TablCubes(count));
}