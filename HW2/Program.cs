using HW2.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            int menu = 0;
            while (true)
            {
                Console.WriteLine("\tMenu");
                Console.WriteLine("--------------------");
                Console.WriteLine("1- Find max and sum of digits in string");
                Console.WriteLine("2- Find max and position of digit in string");
                Console.WriteLine("3- Find max in array of int.");
                Console.WriteLine("4- Find max in array of int with position.");
                Console.WriteLine("0-exit");
                Int32.TryParse(Console.ReadLine(), out menu);
                if (menu == 0)
                {
                    break;
                }
                else if(menu == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Enter text with digits");
                    StringWithNumbers text = new StringWithNumbers(Console.ReadLine());
                    text.GetSumAndMaxOfDigits();
                }
                else if (menu == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Enter text with digits");
                    StringWithNumbers text = new StringWithNumbers(Console.ReadLine());
                    text.GetIndexAndMaxNumber();
                }
                else if (menu == 3)
                {
                    Console.Clear();
                    WorkWithArray array = new WorkWithArray(100);
                    array.Random(100, 1000);
                    array.Show();
                    array.FindMax();
                }
                else if (menu == 4)
                {
                    Console.Clear();
                    WorkWithArray array = new WorkWithArray(40);
                    array.Random(240, 480);
                    array.Show();
                    Console.WriteLine("a)");
                    array.FindMaxFirstIndex();
                    Console.WriteLine("b)");
                    array.FindMaxLastIndex();
                }
            }

        }
    }
}
