using System;

using auditpro.ViewModels;

using Windows.UI.Xaml.Controls;

namespace auditpro.Views
{
    public sealed partial class FilesPage : Page
    {
        private FilesViewModel ViewModel
        {
            get { return DataContext as FilesViewModel; }
        }

        public FilesPage()
        {
            InitializeComponent();
        }
    }
}
