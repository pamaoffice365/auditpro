using System;

using auditpro.ViewModels;

using Windows.UI.Xaml.Controls;

namespace auditpro.Views
{
    public sealed partial class HomePage : Page
    {
        private HomeViewModel ViewModel
        {
            get { return DataContext as HomeViewModel; }
        }

        public HomePage()
        {
            InitializeComponent();
        }
    }
}
