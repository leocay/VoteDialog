using CommunityToolkit.Mvvm.Input;
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



        public MainWindow()
        {
            InitializeComponent();
 

            Items = new ObservableCollection<Item>
        {
            new Item { Hint = "Lựa chọn 1", CanDelete = Visibility.Collapsed },
            new Item { Hint = "Lựa chọn 2", CanDelete = Visibility.Collapsed },
        };

            // Gán DataContext cho cửa sổ
            DataContext = this;
        }


        [RelayCommand]
        private void AddOption()
        {
            Items?.Add(new Item { Hint = $"Lựa chọn {Items.Count + 1}", CanDelete = Visibility.Visible, DeleteCommand = DeleteOptionCommand });
        }

        [RelayCommand]
        private void DeleteOption(Item option)
        {
            if (Items.Contains(option))
            {
                Items.Remove(option);
            }
        }

    }
}