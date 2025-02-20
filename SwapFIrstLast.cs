using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using Homework4;
//Written By Bobbi Lovstad
// 2/20/25
namespace Homework4
{
    public class StringChange
    {
        public string swap(char[] input)
        {
            int length = 0
            //Counting the length of string
            while (true)
            {
                if (input.Length <= length || input(length) == '\0') break;
                length ++;
            }

            //Condition 1

            if (length < 2)
            {
                return "incompatible"
            }

            // Swap first and last chacters 

            char temp = input[0];
            input[0] = input[length - 1];
            input[length - 1] = temp;

            // New string from char array 

            string newString = '';
            for (int x =0; x< length; x++)
            {
                newString += input[x];
            }

            return newString;








               
        }
    }
}


public class program
{
    public static void Main(string[]args)
    {
        StringChange sc = new StringChange();

        char[] String1 = "hello".ToCharArray();  // "olleh"
        Console.WriteLine(sc.swap(String1));

    }
}
