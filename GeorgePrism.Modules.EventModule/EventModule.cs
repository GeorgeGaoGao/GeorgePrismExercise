using GeorgePrism.Core.Share;
using GeorgePrism.Modules.EventModule.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeorgePrism.Modules.EventModule
{
    public class EventModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            containerProvider.Resolve<IRegionManager>().RegisterViewWithRegion<EventView>(RegionNames.EventRegion);
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
        }
    }
}
