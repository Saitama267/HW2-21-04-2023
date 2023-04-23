using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2.Classes
{
    class StringWithNumbers
    {
        private string _text;

        public StringWithNumbers(string text)
        {
            this._text = text; 
        }

        public override string ToString()
        {
            return _text;
        }

        public void GetSumAndMaxOfNumbers()// Method that helps to find Maximal digit and Sum of all digits in string(_text)  
        {
            int max = 0;
            int sum = 0;
            int temp;
            for (int i = 0; i < _text.Length; i++)
            {
                if (char.IsDigit(_text[i]))
                {
                    temp = Convert.ToInt32(_text[i]);
                    sum += temp;
                    if (max < temp)
                    {
                        max = temp;
                    }
                }
            }
            Console.WriteLine($"Max number in string: {max}" +
                $"\n Sum of numbers in string: {sum}");
     
        }
    }
}
