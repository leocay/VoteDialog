using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace VoteDialog
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Item> Items { get; set; }
        public class Item
        {
            public string Text { get; set; }
        }

        public MainWindow()
        {
            InitializeComponent();
 

            Items = new ObservableCollection<Item>
            {
                new Item { Text = "Lựa chọn 1" },
                new Item { Text = "Lựa chọn 2" },
            };

            // Gán DataContext cho cửa sổ
            DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //// Kiểm tra xem cột 2 có đang hiển thị không
            //if (OptionColumn.Width.Value > 0)
            //{
            //    // Ẩn cột 2 bằng cách đặt Width là 0
            //    OptionColumn.Width = new GridLength(0);
            //}
            //else
            //{
            //    // Hiển thị lại cột 2 bằng cách đặt Width là *
            //    OptionColumn.Width = new GridLength(1, GridUnitType.Star);
            //}
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Items.Add(new Item { Text = $"Lựa chọn {Items.Count + 1}" });
            this.SizeToContent = SizeToContent.Height;
        }
    }
}