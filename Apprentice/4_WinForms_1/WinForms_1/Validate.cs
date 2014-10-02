using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_1
{
    public static class Validate
    {
        public static bool IsEscape(ConsoleKeyInfo keyPressed)
        {
            if (keyPressed.Key == ConsoleKey.Escape)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsYesNo(ConsoleKeyInfo keyPressed)
        {
            if ((keyPressed.Key != ConsoleKey.Y) && (keyPressed.Key != ConsoleKey.N))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool IsNumber(string input, out decimal result)
        {
            var isNumber = decimal.TryParse(input, out result);
            if (isNumber)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int Range(int value, int begin, int end)
        {
            if (value >= begin && value <= end)
            {
                return value;
            }
            else
            {
                return 0;
            }
        }

        public static int Range(ConsoleKeyInfo keyPressed, int begin, int end)
        {
            decimal result;
            if (IsNumber(keyPressed.KeyChar.ToString(), out result))
            {
                return Range((int)result, begin, end);
            }
            else
            {
                return 0;
            }
        }

        public static decimal Range(string input, int begin, int end)
        {
            decimal result;
            if (IsNumber(input, out result))
            {
                if (result >= begin && result <= end)
                {
                    return result;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }
        }
    }
}
