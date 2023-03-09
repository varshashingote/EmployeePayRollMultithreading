using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayRoll_MultiThreading
{
    public class EmployeePayRollOperation
    {
        public List<Employeedeatils> employeedeatils = new List<Employeedeatils>();
        public void AddEmployeePayRoll(List<Employeedeatils> employeedeatils)
        {
            employeedeatils.ForEach(employeeData =>
            {
                Console.WriteLine("Employee Being Added :" + employeeData.EmployeeName);
                this.addEmployeeToPayroll(employeeData);
                Console.WriteLine("Employee added : " + employeeData.EmployeeName);
            });
            Console.WriteLine(this.employeedeatils.ToString());
        }


        public void AddEmployeeToPayrollWiththred(List<Employeedeatils> employeedeatils)
        {

            employeedeatils.ForEach(employeeData =>
            {
                Task thread = new Task(() =>
                {
                    Console.WriteLine("Employee Being Added :" + employeeData.EmployeeName);
                    this.addEmployeeToPayroll(employeeData);
                    Console.WriteLine("Employee added : " + employeeData.EmployeeName);
                });
                thread.Start();

            });
            Console.WriteLine(this.employeedeatils.Count);
        }
            public void addEmployeeToPayroll(Employeedeatils emp)
            {
                employeedeatils.Add(emp);
            }
        }
    }


