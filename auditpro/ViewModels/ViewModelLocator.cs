using System;

using auditpro.Services;
using auditpro.Views;

using CommonServiceLocator;

using GalaSoft.MvvmLight.Ioc;

namespace auditpro.ViewModels
{
    [Windows.UI.Xaml.Data.Bindable]
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            SimpleIoc.Default.Register(() => new NavigationServiceEx());
            SimpleIoc.Default.Register<ShellViewModel>();
            Register<HomeViewModel, HomePage>();
            Register<AuftragsManagementViewModel, AuftragsManagementPage>();
            Register<ProjekteViewModel, ProjektePage>();
            Register<AuditViewModel, AuditPage>();
            Register<FilesViewModel, FilesPage>();
            Register<ChartViewModel, ChartPage>();
            Register<BenutzerManagmentViewModel, BenutzerManagmentPage>();
            Register<SchemeActivationSampleViewModel, SchemeActivationSamplePage>();
            Register<SettingsViewModel, SettingsPage>();
        }

        public SettingsViewModel SettingsViewModel => ServiceLocator.Current.GetInstance<SettingsViewModel>();

        public SchemeActivationSampleViewModel SchemeActivationSampleViewModel => ServiceLocator.Current.GetInstance<SchemeActivationSampleViewModel>();

        public BenutzerManagmentViewModel BenutzerManagmentViewModel => ServiceLocator.Current.GetInstance<BenutzerManagmentViewModel>();

        public ChartViewModel ChartViewModel => ServiceLocator.Current.GetInstance<ChartViewModel>();

        public FilesViewModel FilesViewModel => ServiceLocator.Current.GetInstance<FilesViewModel>();

        public AuditViewModel AuditViewModel => ServiceLocator.Current.GetInstance<AuditViewModel>();

        public ProjekteViewModel ProjekteViewModel => ServiceLocator.Current.GetInstance<ProjekteViewModel>();

        public AuftragsManagementViewModel AuftragsManagementViewModel => ServiceLocator.Current.GetInstance<AuftragsManagementViewModel>();

        public HomeViewModel HomeViewModel => ServiceLocator.Current.GetInstance<HomeViewModel>();

        public ShellViewModel ShellViewModel => ServiceLocator.Current.GetInstance<ShellViewModel>();

        public NavigationServiceEx NavigationService => ServiceLocator.Current.GetInstance<NavigationServiceEx>();

        public void Register<VM, V>()
            where VM : class
        {
            SimpleIoc.Default.Register<VM>();

            NavigationService.Configure(typeof(VM).FullName, typeof(V));
        }
    }
}
