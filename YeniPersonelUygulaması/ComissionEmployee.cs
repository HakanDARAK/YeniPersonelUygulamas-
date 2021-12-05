using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YeniPersonelUygulaması
{
    public class ComissionEmployee : Employee
    {
        private double _grossSales;

        public double grossSales
        {
            get { return _grossSales; }
            set { _grossSales = value; }
        }
        private double _comissionRate;

        public double comissionRate
        {
            get { return _comissionRate; }
            set { _comissionRate = value; }
        }

        public ComissionEmployee()
        {

        }

        public override double earnings()
        {

            return comissionRate * grossSales;
        }

        public override void ToString()
        {
            try
            {
                Console.WriteLine("Please type employee Firstname");
                firstName = Console.ReadLine();
                Console.WriteLine("Please type employee Lastname");
                lastName = Console.ReadLine();
                Console.WriteLine("Please type employee SSN");
                SSN = Console.ReadLine();
                Console.WriteLine("Please enter employee comission rate");
                comissionRate = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please enter employee gross sales");
                grossSales = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
