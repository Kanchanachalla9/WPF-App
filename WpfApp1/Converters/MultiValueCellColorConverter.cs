using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace WpfApp1.Converters
{
    public class MultiValueCellColorConverter : IMultiValueConverter
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
                        return Brushes.Blue;
                    else
                    {
                        double input = (double)values[0];
                        if (input > 60000)
                            return Brushes.Green;
                        else
                            return Brushes.Red;
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
