using System;

namespace zadanie2
{
    public class Class1
    {
        static void Main(string[] args)
        {
            int[] maxi;

            Console.Write("Введите количество элементов массива");

            int elementsCount = int.Parse(Console.ReadLine());

            int[] array = new int[elementsCount];

            for (int i = 0; i < array.Length; i++);
            {
                Console.Write("Введите элемент массива");
                array[i] = int.Parse(Console.ReadLine());

            }

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (array[j] > maxi[i])
                        maxi[i] = array[j];
                }
            }


            Console.Write("Вывод массива");

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(maxi[i]);
                Console.WriteLine(" ");
            }
        }
    }
}
