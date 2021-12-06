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
            try
            {
                Console.WriteLine("Please type employee Firstname");
                this.firstName = Console.ReadLine();
                Console.WriteLine("Please type employee Lastname");
                this.lastName = Console.ReadLine();
                Console.WriteLine("Please type employee SSN");
                this.SSN = Console.ReadLine();
                Console.WriteLine("Please enter employee weekly salary");
                this.weeklysalary = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
