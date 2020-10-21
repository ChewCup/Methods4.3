using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Methods4._0
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare
            //ask users salary
            Console.Write("Ange din bruttolön ");
            double brutto = double.Parse(Console.ReadLine());
            Console.WriteLine($"du betalar { CalcSalaryTax(brutto) }");
            /*Console.Write("du betalar {0}kr i skatt och din nettolön är {1}kr", tax, netto);*/
            /*nettoSalary = CalcSalaryTax();*/
            //stop
            Console.ReadKey();
        }
        static string CalcSalaryTax(double brutto)
        {

            double tax = brutto * 0.32;
            double netto = brutto - tax;

            return tax.ToString();
        }
    }
}
