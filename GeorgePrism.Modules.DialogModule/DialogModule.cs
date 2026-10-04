using GeorgePrism.Core.Share;
using GeorgePrism.Modules.DialogModule.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeorgePrism.Modules.DialogModule
{
    public class DialogModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            containerProvider.Resolve<IRegionManager>().RegisterViewWithRegion<DialogView>(RegionNames.DialogRegion);
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
        }
    }
}
