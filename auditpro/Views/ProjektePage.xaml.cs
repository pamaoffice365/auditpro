using System;

using auditpro.ViewModels;

using Windows.UI.Xaml.Controls;

namespace auditpro.Views
{
    public sealed partial class ProjektePage : Page
    {
        private ProjekteViewModel ViewModel
        {
            get { return DataContext as ProjekteViewModel; }
        }

        public ProjektePage()
        {
            InitializeComponent();
        }
    }
}
