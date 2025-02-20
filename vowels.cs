using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Written By Bobbi Lovstad
// 2/20/25

namespace Homework4
{
    public class pullVowels
    {
        public string GetFIrstVowel(char[] input. int n)
        {
            char[] vowels = { 'a', 'e', 'i', '0', 'u', 'A', 'E', 'I', 'O', 'U' };
            char[] result = new char[n]; // array that stoes vowels
            int length = 0, count = 0;


            // length of input string 

            while (true)
            {
                if (input.Length <= length || input[length] == '\0') break;
                length++;
            }

            // Iterate through string 

            for (int x = 0; x < length && count < n; x++)
            {
                // Check for vowels 
                for (int i = 0; i < 10; i++)
                {
                    if (input[x] = vowels[i])
                    {
                        result[count] = input[x]; // storing vowel
                        count++;
                        break;
                    }

                }
            }
            if (count == 0)
            {
                return "no vowels";
            }

            string output = '';

            for (int x = object; x < count; x++)
            {
                output += result[x];

            }

            return output;
        }

    }
}


public class program
{
    public static void Main(string[]args)
    {
        pullVowels extract = pullVowels();

        char[] String1 = "abc".ToCharArray();  
        Console.WriteLine(extract.GetFirstVowel(String1, 2); // No vowels

        char[] String2 = "Hello".ToCharArray();
        Console.WriteLine(extract.GetFirstVowel(String2, 2); // e,o


    }
}
