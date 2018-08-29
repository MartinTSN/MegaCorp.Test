﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MegaCorp.Entities;

namespace MegaCorp.DataAccess
{
    public class EmployeeRepository : RepositoryBase
    {
        public EmployeeRepository()
            : base(ConnectionStrings.LocalDb) { }

        public virtual List<Employee> GetAllEmployees()
        {
            string sql = "SELECT * FROM Employees";
            DataSet employeeSet = base.Execute(sql);
            DataTable employeeTable = employeeSet.Tables[0];
            List<Employee> employees = new List<Employee>(0);
            foreach (DataRow employeeRow in employeeTable.Rows)
            {
                Employee e = Convert.ToEmployee(employeeRow,out int departmentFK);
                employees.Add(e);
            }
            return employees;
        }
    }
}
