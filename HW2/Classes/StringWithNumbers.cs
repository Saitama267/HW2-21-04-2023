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
            _text = text; 
        }

        public override string ToString()
        {
            return _text;
        }

        // Method for the 1 task
        public void GetSumAndMaxOfDigits()// Method that helps to find Maximal digit and Sum of all digits in string(_text)  
        {
            int max = 0;
            int sum = 0;
            int temp;
            for (int i = 0; i < _text.Length; i++)
            {
                if (char.IsDigit(_text[i]))
                {
                    temp = (int)Char.GetNumericValue(_text[i]);
                    sum += temp;
                    if (max < temp)
                    {
                        max = temp;
                    }
                }
            }
            Console.WriteLine($"Max number in string: {max}" +
                $"\nSum of numbers in string: {sum}");
     
        }
        // Method for the 2 task
        public void GetIndexAndMaxNumber()// Method that helps to find Maximal digit and Position of this digit in string(_text) whitout spaces 
        {
            int index = 0;
            int max = 0;
            int position = -1;
            int temp;
            for (int i = 0; i < _text.Length; i++)
            {
                if (char.IsDigit(_text[i]))
                {
                    temp = (int)char.GetNumericValue(_text[i]);
                    if (max < temp )
                    {
                        max = temp;
                        index = i;
                       
                    }
                }
            }
            for (int i = 0; i < _text.Length; i++)
            {
                if (!char.IsWhiteSpace(_text[i]))
                {
                    position += 1;
                }
            }

            Console.WriteLine($"Max number in string: {max}" +
               $"\nPosition of max in string: {position}");
        }

    }
}
