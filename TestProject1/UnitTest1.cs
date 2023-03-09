using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeePayRoll_MultiThreading;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Diagnostics.Metrics;
using System.Net;
using System.Reflection;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]

        public void Given10Eployee_WhenAddedToList_ShouldmatchEmployeeEntries()
        {
            List<Employeedeatils> employeedetails = new List<Employeedeatils>();
            employeedetails.Add(new Employeedeatils(employeeID: 1, employeeName: "varsha", phoneNumber: "3245678", address: "xyz", department: "IT", gender: 'f', basicPay: 234343, taxablePay: 345, tax: 7313, netPay: 487, city: "pune", country: "India"));
            employeedetails.Add(new Employeedeatils(employeeID: 2, employeeName: "vasu", phoneNumber: "3245678", address: "xyz", department: "IT", gender: 'f', basicPay: 234343, taxablePay: 345, tax: 7313, netPay: 487, city: "pune", country: "India"));
            employeedetails.Add(new Employeedeatils(employeeID: 3, employeeName: "Suraj", phoneNumber: "3245678", address: "xyz", department: "HR", gender: 'M', basicPay: 234343, taxablePay: 345, tax: 7313, netPay: 487, city: "pune", country: "India"));
            employeedetails.Add(new Employeedeatils(employeeID: 4, employeeName: "shiva", phoneNumber: "3245678", address: "xyz", department: "IT", gender: 'f', basicPay: 234343, taxablePay: 345, tax: 7313, netPay: 487, city: "pune", country: "India"));
            employeedetails.Add(new Employeedeatils(employeeID: 5, employeeName: "shivadnya", phoneNumber: "3245678", address: "xyz", department: "HR", gender: 'f', basicPay: 234343, taxablePay: 345, tax: 7313, netPay: 487, city: "pune", country: "India"));
            employeedetails.Add(new Employeedeatils(employeeID: 6, employeeName: "pilu", phoneNumber: "3245678", address: "xyz", department: "IT", gender: 'f', basicPay: 234343, taxablePay: 345, tax: 7313, netPay: 487, city: "pune", country: "India"));
            employeedetails.Add(new Employeedeatils(employeeID: 7, employeeName: "aditya", phoneNumber: "3245678", address: "xyz", department: "IT", gender: 'f', basicPay: 234343, taxablePay: 345, tax: 7313, netPay: 487, city: "pune", country: "India"));
            employeedetails.Add(new Employeedeatils(employeeID: 8, employeeName: "swati", phoneNumber: "3245678", address: "xyz", department: "IT", gender: 'f', basicPay: 234343, taxablePay: 345, tax: 7313, netPay: 487, city: "pune", country: "India"));
            employeedetails.Add(new Employeedeatils(employeeID: 9, employeeName: "Adishri", phoneNumber: "3245678", address: "xyz", department: "IT", gender: 'f', basicPay: 234343, taxablePay: 345, tax: 7313, netPay: 487, city: "pune", country: "India"));
            employeedetails.Add(new Employeedeatils(employeeID: 10, employeeName: "sanket", phoneNumber: "3245678", address: "xyz", department: "HR", gender: 'f', basicPay: 234343, taxablePay: 345, tax: 7313, netPay: 487, city: "pune", country: "India"));
            employeedetails.Add(new Employeedeatils(employeeID: 11, employeeName: "monika", phoneNumber: "3245678", address: "xyz", department: "xyz", gender: 'M', basicPay: 234343, taxablePay: 345, tax: 7313, netPay: 487, city: "pune", country: "India"));
            employeedetails.Add(new Employeedeatils(employeeID: 12, employeeName: "sandip", phoneNumber: "3245678", address: "xyz", department: "IT", gender: 'M', basicPay: 234343, taxablePay: 345, tax: 7313, netPay: 487, city: "pune", country: "India"));
            employeedetails.Add(new Employeedeatils(employeeID: 13, employeeName: "poonam", phoneNumber: "3245678", address: "xyz", department: "HR", gender: 'f', basicPay: 234343, taxablePay: 345, tax: 7313, netPay: 487, city: "pune", country: "India"));
            employeedetails.Add(new Employeedeatils(employeeID: 14, employeeName: "Ashwini", phoneNumber: "3245678", address: "xyz", department: "HR", gender: 'f', basicPay: 234343, taxablePay: 345, tax: 7313, netPay: 487, city: "pune", country: "India"));
            EmployeePayRollOperation employeePayRollOperation = new EmployeePayRollOperation();
            employeePayRollOperation.AddEmployeePayRoll(employeedetails);
            DateTime startdateTime = DateTime.Now;
            employeePayRollOperation.AddEmployeePayRoll(employeedetails);
            DateTime stopdateTime = DateTime.Now;
            Console.WriteLine("Duation without thread" + (stopdateTime - startdateTime));


            DateTime StartdatetimeThread = DateTime.Now;
            employeePayRollOperation.AddEmployeeToPayrollWiththred(employeedetails);
            DateTime stopdateTimethread = DateTime.Now;
            Console.WriteLine("Duation with thread" + (stopdateTimethread - StartdatetimeThread));


        }

    }
}