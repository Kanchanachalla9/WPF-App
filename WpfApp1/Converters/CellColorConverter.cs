using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Data;
using System.Windows.Media;
using WpfApp1.Model;

namespace WpfApp1.Converters
{
    //another way to use the IValueConverter
    public class CellColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                if (value is Employee)
                {
                    var employee = value as Employee;

                    if (employee.Department == "HR")
                        return new SolidColorBrush(Colors.Blue);
                    else if (employee.Salary > 60000)
                        return new SolidColorBrush(Colors.Green);
                    else if (employee.Salary < 60000)
                        return new SolidColorBrush(Colors.Red);
                }
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
