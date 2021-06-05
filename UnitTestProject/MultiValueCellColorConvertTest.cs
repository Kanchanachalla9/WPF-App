using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows;
using System.Windows.Data;

namespace UnitTestProject
{
    public class MultiValueCellColorConvertTest : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            //Salary is 1st, Dept is 2nd
            foreach (object value in values)
            {
                try
                {
                    //Checking Dept first, considering Dept is priority than salary
                    if (values[1].ToString() == "HR")
                        return "blue";
                    else
                    {
                        double input = (double)values[0];
                        if (input > 60000)
                            return "green";
                        else
                            return "red";
                    }
                }
                catch
                {

                }
            }
            return DependencyProperty.UnsetValue;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}
