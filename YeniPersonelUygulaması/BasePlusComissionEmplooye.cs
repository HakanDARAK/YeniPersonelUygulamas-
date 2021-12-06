using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YeniPersonelUygulaması
{
    public class BasePlusComissionEmplooye : ComissionEmployee
    {

        private double _baseSalary;

        public double baseSalary
        {
            get { return _baseSalary; }
            set { _baseSalary = value; }
        }

        public BasePlusComissionEmplooye()
        {
        }
        public override double earnings()
        {
            return (comissionRate * grossSales) + baseSalary;
        }

        public override void ToString()
        {
            try
            {
                Console.WriteLine("Please type employee Firstname");
                this.firstName = Console.ReadLine();
                Console.WriteLine("Please type employee Lastname");
                this.lastName = Console.ReadLine();
                Console.WriteLine("Please type employee SSN");
                this.SSN = Console.ReadLine();
                Console.WriteLine("Please enter employee comission rate");
                this.comissionRate = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please enter employee gross sales");
                this.grossSales = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please enter employee base salary");
                this.baseSalary = Convert.ToDouble(Console.ReadLine());

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

        }

    }

}
