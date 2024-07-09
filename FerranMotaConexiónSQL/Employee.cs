using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FerranMotaConexiónSQL
{
    internal class Employee
    {
        public int Employee_id {  get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public string Email { get; set; }
        public string Phone_number { get; set; }
        public DateTime Hire_date { get; set; }
        public int Job_id { get; set; }
        public decimal Salary { get; set; }
        public int Manager_id { get; set; }
        public int Department_id { get; set; }

        public Employee()
        {
        }

        
        public Employee(int employeeId, string firstName, string lastName, string email, string phoneNumber, DateTime hireDate, int jobId, decimal salary, int managerId, int departmentId)
        {
            Employee_id = employeeId;
            First_name = firstName;
            Last_name = lastName;
            Email = email;
            Phone_number = phoneNumber;
            Hire_date = hireDate;
            Job_id = jobId;
            Salary = salary;
            Manager_id = managerId;
            Department_id = departmentId;
        }
    }

}