using System;

using auditpro.ViewModels;

using Windows.UI.Xaml.Controls;

namespace auditpro.Views
{
    public sealed partial class AuditPage : Page
    {
        private AuditViewModel ViewModel
        {
            get { return DataContext as AuditViewModel; }
        }

        public AuditPage()
        {
            InitializeComponent();
        }
    }
}
