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
List<int> list3 = new List<int>(new int[10]);
list3 = [5, 0, 0, 0, 0, 0, 0, 0, 0, 5];
List<int> list4 = new List<int>(new int[10]);
list4 = [5, 0, 0, 0, 0, 0, 0, 0, 0, 5];
List<int> list5 = new List<int>(new int[10]);
list5 = [5, 0, 0, 0, 0, 0, 0, 0, 0, 5];

while (true)
{
    //int num = rnd.Next(1, 10);
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
            list2[y] += 1;
        }
    }
    list[y + 1] = 0;
    list[y - 1] = 0;

    Console.SetCursorPosition(5, 5);

    for (int i = 0; i < list.Count(); i++)
    {
        if (list[i] == 10) { list2[i] += 1; list[i] = 0; }
        
        Console.Write($" {list[i]}");
    }
    Console.SetCursorPosition(5, 7);
     
    for (int i = 0; i < list.Count(); i++)
    {
        if (list2[i] == 10) { list3[i] += 1; list2[i] = 0; }
        
        Console.Write($" {list2[i]}");
    }
    Console.SetCursorPosition(5, 9);

    for (int i = 0; i < list.Count(); i++)
    {
        if (list3[i] == 10) { list4[i] += 1; list3[i] = 0; }
        
        Console.Write($" {list3[i]}");
    }
    Console.SetCursorPosition(5, 11);

    for (int i = 0; i < list.Count(); i++)
    {
        if (list4[i] == 10) { list5[i] += 1; list4[i] = 0; }

        Console.Write($" {list4[i]}");
    }
    Console.SetCursorPosition(5, 13);

    for (int i = 0; i < list.Count(); i++)
    {
        Console.Write($" {list5[i]}");
    }


}
