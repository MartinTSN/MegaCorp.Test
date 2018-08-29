﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MegaCorp.DataAccess;
using MegaCorp.Entities;

namespace MegaCorp.Test
{
    class MegaCorpTest
    {
        static void Main(string[] args)
        {
            EmployeeRepository employeeRepository = new EmployeeRepository();
            List<Employee> employees = employeeRepository.GetAllEmployees();
            foreach (var item in employees)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
