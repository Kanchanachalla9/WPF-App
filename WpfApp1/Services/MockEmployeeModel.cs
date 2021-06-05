using System;
using System.Collections.Generic;
using System.Text;
using WpfApp1.Model;

namespace WpfApp1.Services
{
    public class MockEmployeeModel
    {
        //same as JSON name- Employees
        public List<Employee> Employees { get; set; }

        public MockEmployeeModel()
        {
            Employees = new List<Employee>();
        }
    }
}
