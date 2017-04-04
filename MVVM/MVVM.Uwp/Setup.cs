using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using MvvmCross.Platform.Plugins;
using MvvmCross.Platform.UI;
using MvvmCross.Plugins.Color.WindowsCommon;
using MvvmCross.Plugins.Visibility.WindowsCommon;
using MvvmCross.WindowsUWP.Platform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace MVVM.UWP
{
    public class Setup : MvxWindowsSetup
    {
        public Setup(Frame rootFrame) : base(rootFrame)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            return new Core.App();
        }

        protected override IMvxPluginManager CreatePluginManager()
        {
            Mvx.RegisterType<IMvxNativeColor, MvxWindowsCommonColor>();
            Mvx.RegisterType<IMvxNativeVisibility, MvxWinRTVisibility>();
            return base.CreatePluginManager();
        }

        protected override void InitializeFirstChance()
        {
    
        }
    }
}
