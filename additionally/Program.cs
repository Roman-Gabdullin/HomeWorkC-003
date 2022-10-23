// Дополнительно.
// Напишите программу, которая принимает на вход число (N) и выдает таблицу простых чисел от 1 до N.
// 11 -> 2, 3, 5 , 7, 11

Console.WriteLine("Введите натуральное число:");
int n = Convert.ToInt32(Console.ReadLine());
void Natur(int num)
{
    Console.WriteLine($"{num}->");
    for (int i = 2; i <= num; i++)
    {
        if (i == 2 || i ==3)
            Console.WriteLine($"    {i}");
        if (i % 2 != 0 && i % 3 !=0)
            Console.WriteLine($"    {i}");
    }
}
Natur(n);
