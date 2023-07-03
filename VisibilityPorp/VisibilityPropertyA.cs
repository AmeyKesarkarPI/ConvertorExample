using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace VisibilityPorp
{
    public class VisibilityPropertyA
    {


        public static bool GetShowOnlyWhenProperty(DependencyObject obj)
        {
            return (bool)obj.GetValue(ShowOnlyWhenPropertyProperty);
        }

        public static void SetShowOnlyWhenProperty(DependencyObject obj, bool value)
        {
            obj.SetValue(ShowOnlyWhenPropertyProperty, value);
        }

        // Using a DependencyProperty as the backing store for ShowOnlyWhenProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ShowOnlyWhenPropertyProperty =
            DependencyProperty.RegisterAttached("ShowOnlyWhenProperty", typeof(bool), typeof(VisibilityPropertyA), new PropertyMetadata(false, (a,b) =>
            {

                var CurrentValue = a.GetValue(ShowOnlyWhenPropertyProperty);

                UIElement Element = (UIElement)a;
                if (CurrentValue is true)
                {
                    Element.Visibility = Visibility.Visible;
                }else
                {
                    Element.Visibility = Visibility.Hidden;
                }
            }));


    }
}
