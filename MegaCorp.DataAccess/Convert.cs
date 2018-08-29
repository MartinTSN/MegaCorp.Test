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
        public static Employee ToEmployee(DataRow dataRow)
        {
            return new Employee(default, default, default, default, default);
        }
    }
}
