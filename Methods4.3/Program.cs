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
            double tax;
            double netto;
            //ask users salary
            Console.Write("Ange din bruttolön ");
            double brutto = double.Parse(Console.ReadLine());
            CalcSalaryTax(brutto, out tax, out netto);
            Console.WriteLine("Din bruttolön är {0}kr och du betalar {1}kr i skatt. Efter din skatt har du {2}kr.", brutto, tax, netto);
            /*Console.Write("du betalar {0}kr i skatt och din nettolön är {1}kr", tax, netto);*/
            /*nettoSalary = CalcSalaryTax();*/
            //stop
            Console.ReadKey();
        }
        static void CalcSalaryTax(double brutto, out double tax, out double netto)
        {
             tax = brutto * 0.32;
             netto = brutto - tax;
        }
    }
}
