using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//written by Bobbi Lovstad
// 2/20/25

namespace Homework4
{
    public class StringOrder
    {
        public bool Order(char[] input)
        {
            int length = 0;

            while (true)
            {
                if (input.Length <= length || input(length) == '\0') break;
                length++;
            }

            

            if (length < 2)
            {
                return true;
            }

            //Compare each character to the previous

            for (int x = 0;  x < length-1; x++ )
            {
                if (input[x] > input[x+1])
                {
                    return false;
                }
            }
            return true;

        }

    }
}


public class progrm
{
    public static void Main(string[] args)
    {
        StringOrder check = new StringOrder();

        char[] String1 = "abc".ToCharArray();  // "true"
        Console.WriteLine(check.Order(String1));

        char[] String2 = "acb".ToCharArray();  // "false"
        Console.WriteLine(check.Order(String2));
    }
}
