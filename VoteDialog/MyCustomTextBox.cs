using System.Windows.Controls;
using System.Windows;

namespace VoteDialog;

public class MyCustomTextBox : TextBox
{
    static MyCustomTextBox()
    {
        DefaultStyleKeyProperty.OverrideMetadata(typeof(MyCustomTextBox), new FrameworkPropertyMetadata(typeof(MyCustomTextBox)));
    }

    // Bạn có thể thêm các thuộc tính hoặc phương thức tùy chỉnh tại đây
}
