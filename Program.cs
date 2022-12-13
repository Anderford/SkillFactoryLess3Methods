using System;
using System.Reflection.Metadata.Ecma335;

class MainClass
{

    static string? ShowColor(string UserName, int UserAge)
    {

        (string UserName, int age) anketa;

        Console.WriteLine($"Привет {UserName} напишите свой любимый цвет на английском с маленькой буквы");
        var color = Console.ReadLine();
        //return color;
        switch (color)
        {
            case "red":
                
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
                 break;

            case "green":
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is green!");
                break;
            case "cyan":
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is cyan!");
                break;
            default:
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("Your color is yellow!");
                break;
        }
        return color;
    }

    public static void Main(string[] args)
    {
        

        var SomeName = "Ilia";
        Console.WriteLine(SomeName);

        GetName(ref SomeName);

        Console.WriteLine(SomeName);

        var arr = new int[] { 1, 2, 3 };
        BigDataOperation(arr);

        Console.WriteLine(arr[0]);

    }

    static void GetName(ref string name)
    {
        Console.WriteLine("Введите имя");
        name = Console.ReadLine();
    }

    static void BigDataOperation(in int[] arr)
    {
        arr[0] = 4;
    } 

}