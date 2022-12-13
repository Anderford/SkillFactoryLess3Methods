using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactoryLess3Methods
{
    internal class task
    {
        public static void Main(string[] args)
        {
            var array = GetArrayFromConsole();

            SortArray(array, out int[] sortedasc, out int[] sorteddesc);
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
    }
}
