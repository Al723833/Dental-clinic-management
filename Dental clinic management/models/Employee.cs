using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dental_clinic_management
{
    class Employee
    {
        public int EmployeeID { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String mobileNumber { get; set; }
        public String EmployeeAddress { get; set; }
        public double Salary { get; set; }

        public Employee(int EmployeeID, String FirstName, String LastName, String mobileNumber, String EmployeeAddress, double Salary)
        {
            this.EmployeeID = EmployeeID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.mobileNumber = mobileNumber;
            this.EmployeeAddress = EmployeeAddress;
            this.Salary = Salary;

        }
    }
}
