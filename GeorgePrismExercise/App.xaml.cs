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
            
        }
    }

}
