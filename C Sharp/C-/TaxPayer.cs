using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    class TaxPayer
    {
        private int ssn;
        private int income;
        private double taxOwed;

        public int SSN
        {
            get { return ssn; }
            set { ssn = value; }
        }

        public TaxPayer(int assn)
        {
            SSN = assn;
            Console.WriteLine("Enter Income");
            Income = Convert.ToInt32(Console.ReadLine());
            taxOwed = taxCal(Income);
        }

        public int Income
        {
            get { return income; }
            set { income = value; }
        }

        public double TaxOwed
        {
            get { return taxOwed; }
        }

        private double taxCal(double i)
        {
            if(i < 30000)
            {
                return (i * 0.15);
            }
            return(i * 0.28);
        }
    }
}
