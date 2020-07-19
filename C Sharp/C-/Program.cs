using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "conference", "ham", "gallery", "essay", "signature", "internet", "corner", "gossip" };

            Random randomGenerator = new Random();
            int num = randomGenerator.Next(0, 8);

            string myString = words[num];

            string str = "*";
            for (int i = 1; i < myString.Length; i++)
            {
                str += '*';
            }

            char guess;
            Console.WriteLine(myString);
            Console.WriteLine("Guess this word \n");
            bool end = false;
            string str1;
            string str2;
            while (!end)
            {
                Console.WriteLine(str);
                Console.WriteLine("Enter the letter ");
                guess = Convert.ToChar(Console.ReadLine());
                if (myString.Contains(guess))
                {
                    Console.WriteLine("You Got that right");
                    for(int j = 0; j < str.Length; j++)
                    {
                        if(myString[j] == guess)
                        {
                            str1 = str.Substring(0, j);
                            str2 = str.Substring(j + 1);
                            str = str1 + guess + str2;
                            if (!(str.Contains('*')))
                            {
                                end = true;
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Wrong Guess");
                }
                
            }
            Console.WriteLine("You Win!");



            Console.ReadLine();
        }
    }
}