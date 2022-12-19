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

        Recursion();



        var array = GetArrayFromConsole();

         SortArray(array, out int[] sortedasc, out int[] sorteddesc);

         var SomeName = "Ilia";
         Console.WriteLine(SomeName);

         GetName(ref SomeName);

         Console.WriteLine(SomeName);

         var arr = new int[] { 1, 2, 3 };
         BigDataOperation(arr);

         Console.WriteLine(arr[0]);

    }

    static int[] GetArrayFromConsole()
    {
        var result = new int[5];

        for (int i = 0; i < result.Length; i++)
        {
            Console.WriteLine("Введите элемент массива номер {0}", i + 1);
            result[i] = int.Parse(Console.ReadLine());
        }
        return result;
    }
    static void SortArray(int[] array, out int[] sortedasc, out int[] sorteddesc)
    {
        sortedasc = new int[array.Length];
        sorteddesc = new int[array.Length];

        SortArrayAsc(array).CopyTo(sortedasc, 0);
        Console.WriteLine("");
        SortArrayDesc(array).CopyTo(sorteddesc, 0);
    }

    static int[] SortArrayAsc(int[] result)
    {
        int temp;
        for (int i = 0; i < result.Length; i++)
        {
            for (int j = 0; j < result.Length; j++)
            {
                if (result[i] < result[j])
                {
                    temp = result[i];
                    result[i] = result[j];
                    result[j] = temp;
                }
            }
        }
        foreach (var item in result)
        {
            Console.Write(item + " ");
        }
        return result;

    }

    static int[] SortArrayDesc(int[] result)
    {
        int temp;
        for (int i = 0; i < result.Length; i++)
        {
            for (int j = 0; j < result.Length; j++)
            {
                if (result[i] > result[j])
                {
                    temp = result[i];
                    result[i] = result[j];
                    result[j] = temp;
                }
            }
        }
        foreach (var item in result)
        {
            Console.Write(item + " ");
        }

        return result;

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



    static void Recursion()
    {
        Console.WriteLine("Write something");
        var str = Console.ReadLine();
        Console.WriteLine("Echo deep");
        var EchoDeep = Convert.ToInt32(Console.ReadLine());

        Echo(str, EchoDeep);

    }


    static void Echo(string Phaze, int EchoDeep)
    {

        var modif = Phaze;

        if (modif.Length > 2)
        {
            modif = modif.Remove(0, 2);
          
        }
        Console.WriteLine("..." + modif);
        Console.BackgroundColor = (ConsoleColor)EchoDeep;
        if (EchoDeep > 1)
        {
            Echo(modif, EchoDeep - 1);
        }
    }
   

}



