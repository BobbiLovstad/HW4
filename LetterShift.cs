using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//written by Bobbi Lovstad
// 2/20/25
namespace Homework4
{
    public class letterShift
    {
        public string ShiftLetter(char[] input)
        {
            int length = 0;

            while (true)
            {
                if (input.Length <= length || input[length] == '\0') break;
                length++;
            }

            // new array for shifted values

            char[] result = new char[length];

            // iterate through each character

            for( int x = 0; x< length; x++)
            {
                char current = input[x];

                //shifting just the alphabet 

                if ((current >= 'a' && current <= 'z' || (current >='A' && current <='Z'))
                {
                    if (current == 'z')
                    {
                        result[x] = 'a';
                    }
                    else if (current == 'Z')
                    {
                        result[x] = "A";
                    }
                    else
                    {
                        result[x] = current;
                    }
                }

                string output = "";

                for(int x = 0; x < length; x++)
                {
                    output += result[x];
                }

                return output;

            }
        }
    }
}
public class program
{
    public static void Main(string[]args)
    {
        lettershift shifter = new lettershift();

        char[] String1 = "hello".ToCharArray();  // "ifmnp"
        Console.WriteLine(shifter.letterShift(String1));
    }
}