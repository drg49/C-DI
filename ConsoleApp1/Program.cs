using System;
using System.Collections.Generic;
using System.Linq;

namespace PalindromeAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a word to see if it is a palindrome: ");
            string word = Console.ReadLine();


            static void isPalindrome(string input)
            {
                char[] charArray = input.ToCharArray();
                Array.Reverse(charArray);                
                string reversedWord = new string(charArray);
                if (input == reversedWord)
                {
                    Console.WriteLine($"{input} is a palindrome");
                } 
                else
                {
                    Console.WriteLine($"{input} is not a palindrome");
                }
            }

            isPalindrome(word);
        }
    }
}
