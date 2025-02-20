using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework4;
//Written by Bobbi Lovstad
// 2/20/
// 
// Create a method that takes a string and returns the word count
namespace Homework4
{
    public class WordCounter
    {
        public int CountWords(string sentence)
        {
            int count = 0;
            bool Word = false;

            for int(int x = 0; x < sentence.Lenght; x++)
            {
                //Checking if there is any space or punctuations

                if (sentence[x} == '' || sentence[x] == '\t' || sentence[x] == '\n'){
                Word = false; }


                else if (!Word) // if a new word starts
            {
                Word = true;
                count++
            }
            return count;
        }

        }
    }
}


public class progrma
{
    public static void Main(string[]args)
    {
        WordCounter wc = new WordCounter();

        Console.WriteLine( "Enter a sentence")
        string sentence = Console.ReadLine();

        int wordCount = wc.CountWords(sentence);
        Console.WriteLine("Word count:" + wordCount);
    }
}