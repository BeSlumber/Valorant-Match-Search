using System.Configuration;
using System.Data;
using System.Windows;

using Prism.Unity;

using Valorant_Match_search.ViewModels;
using Valorant_Match_search.Views;

namespace Valorant_Match_search
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<MatchPage, MatchPageViewModel>();
            //containerRegistry.RegisterForNavigation<Edge, EdgeViewModel>();
        }
    }

}
