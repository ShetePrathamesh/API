using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Employee
    {
        public string? Dept_Id { get; set; }
        public string? Dept_Name { get;set; }
        public List<EmployeeInfo>? Employees { get; set;}

    }

    public class EmployeeInfo
    {
        public string? userId { get; set; }
        public string? firstName { get; set; }

        public string? lastName { get; set; }

        public string? email { get; set; }
        public string? jobTitleName { get; set; }
    }

    
}
