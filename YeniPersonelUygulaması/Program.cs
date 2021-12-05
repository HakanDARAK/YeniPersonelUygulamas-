using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YeniPersonelUygulaması
{
    class Program
    {
        static void Main(string[] args)
        {
            string decision = string.Empty;
            int decision1 = 0;
            double salary = 0;

            try
            {

                do
                {
                    Console.Clear();
                    Console.WriteLine("Please enter between 1-4");
                    Console.WriteLine("1--Salaried Employee");
                    Console.WriteLine("2--Hourly Employee");
                    Console.WriteLine("3--Comission Employee");
                    Console.WriteLine("4--Base Plus Comission Employee");
                    decision1 = Convert.ToInt32(Console.ReadLine());

                    switch (decision1)
                    {
                        case 1:
                            Salaried_Employee s1 = new Salaried_Employee();
                            s1.ToString();
                            salary = s1.earnings();
                            Console.WriteLine("Salary is " + salary);
                            break;
                        case 2:
                            HourlyEmployee h1 = new HourlyEmployee();
                            h1.ToString();
                            salary = h1.earnings();
                            Console.WriteLine("Salary is " + salary);
                            break;
                        case 3:
                            ComissionEmployee c1 = new ComissionEmployee();
                            c1.ToString();
                            salary = c1.earnings();
                            Console.WriteLine("Salary is " + salary);
                            break;
                        case 4:
                            BasePlusComissionEmplooye b1 = new BasePlusComissionEmplooye();
                            b1.ToString();
                            salary = b1.earnings();
                            Console.WriteLine("Salary is " + salary);
                            break;
                        default:
                            Console.WriteLine("Error! you have to enter between 1-4");
                            break;
                    }


                    Console.WriteLine("Do you want to continue please type 'y' otherwise you will be in the loop");
                    decision = Console.ReadLine();

                } while (decision != "n");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);

            }

            Console.ReadLine();




        }
    }
}
