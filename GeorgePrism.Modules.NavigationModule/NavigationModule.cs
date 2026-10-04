using GeorgePrism.Core.Share;
using GeorgePrism.Modules.NavigationModule.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeorgePrism.Modules.NavigationModule
{
    public class NavigationModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            containerProvider.Resolve<IRegionManager>().RegisterViewWithRegion<NavigationView>(RegionNames.NavigationRegion);
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
        }
    }
}
