global using System;
global using System.Collections.Generic;
global using System.Linq;
global using System.Text;
global using System.Net;
global using System.Threading.Tasks;
global using NET6.NewFeatures.CSharp10;
global using NET6.NewFeatures.NET6;

namespace NET6.NewFeatures.CSharp10;
public class Declaring
{
    private static (int x, int y) point;

    public static void Test()
    {
        point = new(1, 1); //KROTKA
        // Deklaracja:
        (int x, int y) = point;
        Console.WriteLine($"Deklaracja:{x},{y}");

        // Przypisanie:
        int x1 = 0;
        int y1 = 0;
        (x1, y1) = point;
        Console.WriteLine($"Przypisanie:{x1},{y1}");


        int x2 = 2;
        (x2, int y2) = point;
        Console.WriteLine($"Przypisanie + Deklaracja:{x2},{y2}");

    }
}