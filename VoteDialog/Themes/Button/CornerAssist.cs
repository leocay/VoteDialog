using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace VoteDialog.Themes.Button
{
    public class CornerAssist
    {
        public static readonly DependencyProperty CornerProperty = DependencyProperty.RegisterAttached(
            "Corner",
            typeof(int),
            typeof(CornerAssist),
            new PropertyMetadata(5));

        public static int GetCorner(DependencyObject obj)
        {
            return (int)obj.GetValue(CornerProperty);
        }

        public static void SetCorner(DependencyObject obj, int value)
        {
            obj.SetValue(CornerProperty, value);
        }
    }
}
