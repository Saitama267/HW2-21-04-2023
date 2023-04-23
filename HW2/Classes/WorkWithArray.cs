using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2.Classes
{
    class WorkWithArray
    {
        private int[] _arr;
        private int _size;

        public WorkWithArray(int size)
        {
            _size = size;
            _arr = new int[size];
        }

        public void Random(int from, int to )
        {
            Random rand = new Random();
            for (int i = 0; i < _size; i++)
            {
                _arr[i] = rand.Next(from, to);                    
            }
        }
        public void Show()
        {
            for (int i = 0; i < _size; i++)
            {
                Console.Write($"{_arr[i]}\t");
            }
            Console.WriteLine();
        }

        // Method for the third task
        public void FindMax()
        {
            int max = 0;
            for (int i = 0; i < _size; i++)
            {
                if (max < _arr[i])
                {
                    max = _arr[i];
                }
            }

            Console.WriteLine($"Maximal number is: {max}");
        }

        // Method for the fourth task part one
        public void FindMaxFirstIndex()
        {
            int max = 0;
            int index = 0;
            for (int i = 0; i < _size; i++)
            {
                if (max < _arr[i])
                {
                    max = _arr[i];
                    index = i;
                }
            }
            Console.WriteLine($"Maximal number is: {max}");
            Console.WriteLine($"Maximal number index is: {index}");
        }
        // Method for the fourth task part one
        public void FindMaxLastIndex()
        {
            int max = 0;
            int index = 0;
            for (int i = 0; i < _size; i++)
            {
                if (max <= _arr[i])
                {
                    max = _arr[i];
                    index = i;
                }
            }
            Console.WriteLine($"Maximal number is: {max}");
            Console.WriteLine($"Maximal number index is: {index}");
        }
    }
}
