using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MegaCorp.Entities;

namespace MegaCorp.DataAccess
{
    public static class Convert
    {
        public static Employee ToEmployee(DataRow employeeRow, out int departmentFK)
        {
            departmentFK = (int)employeeRow["DepartmentId"];
            int id = (int)employeeRow["EmployeeId"];
            string firstname = (string)employeeRow["Firstname"];
            string lastname = (string)employeeRow["Lastname"];
            DateTime startDate = (DateTime)employeeRow["StartDate"];
            string position = (string)employeeRow["Position"];
            decimal salary = (decimal)employeeRow["Salary"];
            Employee employee = new Employee(id, firstname, lastname, salary, position, startDate);
            return employee;
        }
    }
}
