using System;

using auditpro.ViewModels;

using Windows.UI.Xaml.Controls;

namespace auditpro.Views
{
    public sealed partial class AuftragsManagementPage : Page
    {
        private AuftragsManagementViewModel ViewModel
        {
            get { return DataContext as AuftragsManagementViewModel; }
        }

        public AuftragsManagementPage()
        {
            InitializeComponent();
        }
    }
}
