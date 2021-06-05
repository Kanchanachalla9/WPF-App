using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using System.Windows.Media;
using WpfApp1.Model;
using System.Reflection;
using WpfApp1.Services;

namespace WpfApp1.ViewModel
{
    public class EmployeeViewModel
    {
        public List<Employee> Employees { get; set; }

        public static EmployeeViewModel Instance
        {
            get;
            private set;
        }

        public EmployeeViewModel()
        {
            Instance = this;
            //get data file path, Please place the EmployeeJsonData.txt file in bin\debug\netcore folder
            string jsonFilePath = @$"{AppDomain.CurrentDomain.BaseDirectory}EmployeeJsonData.txt"; 

           
            //get data from JSON file
            string data = System.IO.File.ReadAllText(jsonFilePath);
            
            //deserialize the json data 
            MockEmployeeModel mockEmployee = JsonConvert.DeserializeObject<MockEmployeeModel>(data);

            //assign the data to Employees
            Employees = mockEmployee.Employees;
        }
    }    
}
