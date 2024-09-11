using System.Windows.Controls;
using System.Windows;

namespace VoteDialog;

public class MyCustomTextBox : TextBox
{
    static MyCustomTextBox()
    {
        DefaultStyleKeyProperty.OverrideMetadata(typeof(MyCustomTextBox), new FrameworkPropertyMetadata(typeof(MyCustomTextBox)));
    }

}
