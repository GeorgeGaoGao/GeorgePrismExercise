using GeorgePrism.Core.Share;
using GeorgePrism.Modules.AdapterModule.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeorgePrism.Modules.AdapterModule
{
    public class AdapterModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager= containerProvider.Resolve<IRegionManager>();
            //regionManager.RequestNavigate(RegionNames.AdapterRegion,"AdapterView");
            regionManager.RegisterViewWithRegion<AdapterView>(RegionNames.AdapterRegion); 

            var region = regionManager.Regions[RegionNames.ItemsControlRegion];
            var a = containerProvider.Resolve<ItemsControlView>();
            var b= containerProvider.Resolve<ItemsControlView>();
            var c = containerProvider.Resolve<ItemsControlView>();
            var d = containerProvider.Resolve<ItemsControlView>();
            region.Add(a);
            region.Add(b);
            region.Add(c);
            region.Add(d);
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<AdapterView>();
        }
    }
}
