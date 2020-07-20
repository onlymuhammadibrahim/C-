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
            
            
            TaxPayer[] list = new TaxPayer[10];
            for (int i = 0; i < 10; i++)
            {
                TaxPayer s1 = new TaxPayer(i);
                list[i] = s1;
            }        
            
            for (int j = 0; j < 10; j++)
            {
                Console.WriteLine("Tax Payer # " + list[j].SSN + " having income of " + list[j].Income + " has tax of " + list[j].TaxOwed);
            }
            
            Console.ReadLine();
        }
    }
}