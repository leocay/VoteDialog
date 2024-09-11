using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace VoteDialog.Themes.TextBox
{

    public class TitleAssist
    {
        public static readonly DependencyProperty TitleProperty = DependencyProperty.RegisterAttached(
            "Title",
            typeof(string),
            typeof(TitleAssist));

        public static readonly DependencyProperty FontSizeProperty = DependencyProperty.RegisterAttached(
            "FontSize",
            typeof(int),
            typeof(TitleAssist),
            new PropertyMetadata(16));

        public static readonly DependencyProperty FontWeightProperty = DependencyProperty.RegisterAttached(
            "FontWeight",
            typeof(string),
            typeof(TitleAssist));

        public static string GetTitle(DependencyObject obj)
        {
            return (string)obj.GetValue(TitleProperty);
        }

        public static void SetTitle(DependencyObject obj, string value)
        {
            obj.SetValue(TitleProperty, value);
        }

        public static int GetFontSize(DependencyObject obj)
        {
            return (int)obj.GetValue(TitleProperty);
        }

        public static void SetFontSize(DependencyObject obj, int value)
        {
            obj.SetValue(TitleProperty, value);
        }

        public static string GetFontWeight(DependencyObject obj)
        {
            return (string)obj.GetValue(FontWeightProperty);
        }

        public static void SetFontWeight(DependencyObject obj, string value)
        {
            obj.SetValue(FontWeightProperty, value);
        }
    }
}
