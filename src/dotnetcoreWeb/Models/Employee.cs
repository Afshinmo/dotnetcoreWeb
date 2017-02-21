﻿using System;
using System.Collections.Generic;
using System.Linq;


namespace TestApplication.Models
{
    public class Employee
    {
        public int EmpId { get; set; }
        public string Name { get; set; }

        public int Salary { get; set; }
    }

    public class EmployeeStore
    {
        public static List<Employee> FetchEmployees()
        {
            if (EmployeeList == null)
            {
                List<Employee> empList = new List<Employee>();
                empList.Add(new Employee() { EmpId = 1, Name = "Mats", Salary = 3000 });
                empList.Add(new Employee() { EmpId = 2, Name = "Afshin", Salary = 2500 });
                empList.Add(new Employee() { EmpId = 3, Name = "Peter", Salary = 4000 });
                EmployeeList = empList;
            }
            return EmployeeList;
        }

        public static List<Employee> EmployeeList = null;
    }
}