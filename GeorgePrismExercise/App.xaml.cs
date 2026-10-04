using GeorgePrism.Modules.AdapterModule;
using GeorgePrism.Modules.DialogModule;
using GeorgePrism.Modules.EventModule;
using GeorgePrism.Modules.NavigationModule;
using GeorgePrismExercise.ViewModels;
using GeorgePrismExercise.Views;
using System.Configuration;
using System.Data;
using System.Windows;

namespace GeorgePrismExercise
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            //return new MainWindow() { Title="prismExercise"};
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<HeaderView>();
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            base.ConfigureModuleCatalog(moduleCatalog);
            moduleCatalog.AddModule<AdapterModule>();
            moduleCatalog.AddModule<DialogModule>();
            moduleCatalog.AddModule<NavigationModule>();
            moduleCatalog.AddModule<EventModule>();
        }

    }

}
