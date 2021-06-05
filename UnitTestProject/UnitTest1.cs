using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Windows.Media;
using WpfApp1.Converters;
using WpfApp1.Model;
using WpfApp1.Services;
using WpfApp1.View;
using WpfApp1.ViewModel;

namespace UnitTestProject
{
    [TestClass]
    public class CellColorConverterTests
    {
        [TestMethod]
        public void CellColorConverterTest()
        {
            MultiValueCellColorConvertTest converter = new MultiValueCellColorConvertTest();
            Assert.AreEqual(converter.Convert(new object[] { 60000, "HR" }, null, null, System.Globalization.CultureInfo.CurrentCulture), "blue");
            Assert.AreEqual(converter.Convert(new object[] { 40000.0, "IT" }, null, null, System.Globalization.CultureInfo.CurrentCulture), "red");
        }

        [TestMethod]
        public void EmployeeDataTest()
        {
            var jsonFilePath = @"C:\MVVM app\WpfApp1\bin\x64\Debug\netcoreapp3.1\EmployeeJsonData.txt";

            //get data from JSON file
            var data = System.IO.File.ReadAllText(jsonFilePath);

            //deserialize the json data 
            MockEmployeeModel mockEmployee = JsonConvert.DeserializeObject<MockEmployeeModel>(data);

            Assert.AreEqual(mockEmployee.Employees.Count, 5);
        }
    }
}
