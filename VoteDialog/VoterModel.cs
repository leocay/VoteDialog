using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoteDialog
{
    public partial class VoterModel : ObservableObject
    {
        public int Id { get; set; }

        [ObservableProperty]
        private string _name = string.Empty;
    }
}
