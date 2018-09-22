using System;

using auditpro.ViewModels;

using Windows.UI.Xaml.Controls;

namespace auditpro.Views
{
    public sealed partial class BenutzerManagmentPage : Page
    {
        private BenutzerManagmentViewModel ViewModel
        {
            get { return DataContext as BenutzerManagmentViewModel; }
        }

        public BenutzerManagmentPage()
        {
            InitializeComponent();
        }
    }
}
