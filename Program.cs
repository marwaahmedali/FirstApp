using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int loan = 600;
            int asset = 900;
            string totalLoans;
            string totalApplicants;
            int x = 150000;
            int y = 100000;
            int num = 400;
            int z = 1000000;
            string ltv;
                        
            Console.Write("Amount that the loan is for (GBP): ");
            loan = Console.ReadLine();
            

            Console.Write("Value of asset the loan will secure: ");
            asset = Console.ReadLine();

            if (num >=1 && num <= 999)
            {
                Console.WriteLine("applicant successful");
            }
            else
            {
                Console.WriteLine("applicant not successful");
            }


            Console.Write("Total number of successful applicants to date: ");
            totalApplicants = Console.ReadLine();

            Console.Write("Total values of loans written to date: ");
            totalLoans = Console.ReadLine();

            Console.WriteLine("((loan / asset)*100)");
            ltv = Console.ReadLine();



            if (x >= 1500000 || y <= 100000) 
            {
                Console.WriteLine("application declined");
            }
            else
            {
                Console.WriteLine("application accepted");
            }


            if( z >= 1000000)
            {
                Console.WriteLine("LTV must be 60% or less and credit score must be 950 or more");
            }
            else
            {
                Console.WriteLine("Applicant is declined");
            }

           

            Console.ReadLine();
        }
    }
}
