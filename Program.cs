using System;

class MainClass
{

    static string? ShowColor(string UserName)
    {

        (string UserName, int age) anketa;

        /*Console.Write("Введите имя: ");
        anketa.UserName = Console.ReadLine();
        Console.Write("Введите возраст с цифрами: ");
        anketa.age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ваше имя: {0}", anketa.UserName);
        Console.WriteLine("Ваш возраст: {0}", anketa.age);

        Console.ReadKey();*/


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
        var (name, age) = ("Евгения", 27);

        Console.WriteLine("Мое имя: {0}", name);
        Console.WriteLine("Мой возраст: {0}", age);

        Console.Write("Введите имя: ");
        name = Console.ReadLine();
        Console.Write("Введите возрас с цифрами:");
        age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ваше имя: {0}", name);
        Console.WriteLine("Ваш возраст: {0}", age);

        var favcolor = new string?[3];
        for (int i = 0; i < favcolor.Length; i++)
        {
            favcolor[i] = ShowColor(name);
        }
        GetArrayFromConsole();
     

    }
    static int[] GetArrayFromConsole()
    {
        var result = new int[5];

        for (int i = 0; i < result.Length; i++)
        {
            Console.WriteLine("Введите элемент массива номер {0}", i + 1);
            result[i] = int.Parse(Console.ReadLine());
        }
        int temp;

        
        for(int i = 0; i < result.Length; i++)
        {
            for(int j = 0; j < result.Length; j++)
            {
                if (result[i] < result[j])
                {
                    temp = result[i];
                    result[i] = result[j];
                    result[j] = temp;
                }
            }
        }
        foreach(var res in result)
        {
            Console.WriteLine(res);
        }
        return result;

        

    }

}