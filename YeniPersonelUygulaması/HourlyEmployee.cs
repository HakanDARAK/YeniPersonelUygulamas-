using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YeniPersonelUygulaması
{
    public class HourlyEmployee : Employee
    {
        private double _wage;
        public double salary = 0;

        public double wage
        {
            get { return _wage; }
            set { _wage = value; }
        }
        private double _hours;

        public double hours
        {
            get { return _hours; }
            set { _hours = value; }
        }
        public HourlyEmployee()
        {

        }


        public override double earnings()
        {

            try
            {
                if (hours <= 40 && hours > 0)
                {
                    salary = wage * hours;
                }
                else if (hours > 40)
                {
                    salary = 40 * wage + (hours - 40) * wage * 1.5;
                }
                else
                {
                    Console.WriteLine("Your hours that you worked must be greater than zero");
                }
                
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            return salary;
        }

        public override void ToString()
        {
            Console.WriteLine("Please type employee Firstname");
            firstName = Console.ReadLine();
            Console.WriteLine("Please type employee Lastname");
            lastName = Console.ReadLine();
            Console.WriteLine("Please type employee SSN");
            SSN = Console.ReadLine();
            Console.WriteLine("Please type employee hourly wage");
            wage = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please type employee  hours worked");
            hours = Convert.ToDouble(Console.ReadLine());
        }
    }
}
