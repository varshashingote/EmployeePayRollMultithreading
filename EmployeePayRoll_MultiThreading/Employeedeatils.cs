using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayRoll_MultiThreading
{
    public class Employeedeatils
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Department { get; set; }
        public char Gender { get; set; }
        public double BasicPay { get; set; }
        public double Deductions { get; set; }
        public double TaxablePay { get; set; }
        public double Tax { get; set; }
        public double NetPay { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
       

      

        public Employeedeatils(int employeeID, string employeeName, string phoneNumber, string address, string department, char gender, int basicPay, int taxablePay, int tax, int netPay, string city, string country)
        {
            EmployeeID = employeeID;
            EmployeeName = employeeName;
            PhoneNumber = phoneNumber;
            Address = address;
            Department = department;
            Gender = gender;
            BasicPay = basicPay;
            TaxablePay = taxablePay;
            Tax = tax;
            NetPay = netPay;
            City = city;
            Country = country;
        }
    }
}
