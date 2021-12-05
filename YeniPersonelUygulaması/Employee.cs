using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YeniPersonelUygulaması
{
    public abstract class Employee
    {
        private string _firsName;

        public string firstName
        {
            get { return _firsName; }
            set { _firsName = value; }
        }
        private string _lastName;

        public string lastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        private string _SSN;

        public string SSN
        {
            get { return _SSN; }
            set { _SSN = value; }
        }
        public abstract double earnings();
        public abstract void ToString();



    }
}
