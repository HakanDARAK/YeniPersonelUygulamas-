using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YeniPersonelUygulaması
{
    public class Salaried_Employee : Employee
    {
        private double _weeklysalary;

        public double weeklysalary
        {
            get { return _weeklysalary; }
            set { _weeklysalary = value; }
        }
        public Salaried_Employee()
        {

        }
        public override double earnings()
        {
            return weeklysalary;

        }

        public override void ToString()
        {
            Console.WriteLine("Please type employee Firstname");
            firstName = Console.ReadLine();
            Console.WriteLine("Please type employee Lastname");
            lastName = Console.ReadLine();
            Console.WriteLine("Please type employee SSN");
            SSN = Console.ReadLine();
            Console.WriteLine("Please enter employee weekly salary");
            weeklysalary = Convert.ToDouble(Console.ReadLine());
        }
    }
}
