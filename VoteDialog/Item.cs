using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Windows;

namespace VoteDialog;

public partial class Item : ObservableObject
{

    public int Id { get; set; }

    [ObservableProperty]
    private string _content = string.Empty;

    [ObservableProperty]
    private ObservableCollection<VoterModel> _voters = [];

    [ObservableProperty]
    private Visibility _canDelete = Visibility.Visible;

    [ObservableProperty]
    private string _hint = string.Empty;

    [ObservableProperty]
    private ICommand? _deleteCommand;
}



