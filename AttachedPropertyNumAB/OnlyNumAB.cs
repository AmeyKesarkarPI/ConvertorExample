using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace AttachedPropertyNumAB
{
    public class OnlyNumAB : TextBox
    {


        public static string GetValidation(DependencyObject obj)
        {
            return (string)obj.GetValue(ValidationProperty);
        }

        public static void SetValidation(DependencyObject obj, string value)
        {
            obj.SetValue(ValidationProperty, value);
        }

        // Using a DependencyProperty as the backing store for Validation.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ValidationProperty =
            DependencyProperty.RegisterAttached("Validation", typeof(string), typeof(OnlyNumAB), new PropertyMetadata(null, (a,b) =>
            {
                var CurrentValue = a.GetValue(ValidationProperty);
                int num;
                bool IsNum = int.TryParse((string)CurrentValue, out num);
                if (IsNum != false && (char)CurrentValue != 'a' && (char)CurrentValue != 'b')
                {

                }
                else
                {
                    MessageBox.Show("Other");
                }
            }));

    }
}
