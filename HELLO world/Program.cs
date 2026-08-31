using System.Numerics;
using System.Runtime.CompilerServices;
using static System.Console;

Console.CursorVisible = false;

Random rnd = new Random();
ConsoleKeyInfo key;
int y = 1;

List<int> list = new List<int>(new int[10]);
List<int> list2 = new List<int>(new int[10]);
list2 = [ 5, 0, 0, 0, 0, 0, 0, 0, 0, 5 ];

while (true)
{
    int num = rnd.Next(1, 10);

    Console.SetCursorPosition(5, 5);

    for (int i = 0; i < list.Count(); i++)
    {
        Console.Write($" {list[i]}");
    }
    Console.SetCursorPosition(5, 7);

    for (int i = 0; i < list.Count(); i++)
    {
        Console.Write($" {list2[i]}");
    }
    if (KeyAvailable)
    {
        key = Console.ReadKey(true);
        if (key.Key == ConsoleKey.A)
        {
            if (list2[y - 1] != 5) { list[y - 1] = 1; y--; }
        }
        if (key.Key == ConsoleKey.D)
        {
            if (list2[y + 1] != 5) { list[y + 1] = 1; y++; }
        }
        if (key.Key == ConsoleKey.Spacebar)
        {
            list2[y] += 2;
        }
        if (key.Key == ConsoleKey.W)
        {   
            Console.SetCursorPosition(5 + num, 5);
            Console.Write("w");
        }
    }
    list[y + 1] = 0;
    list[y - 1] = 0;



}
