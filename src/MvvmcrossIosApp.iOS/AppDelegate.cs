using Foundation;
using MvvmCross;
using MvvmCross.Platforms.Ios.Core;
using MvvmCross.Platforms.Ios.Presenters;
using MvvmCross.ViewModels;
using MvvmcrossIosApp.Core;
using MvvmcrossIosApp.Core.ViewModels.Main;
using MvvmcrossIosApp.iOS.UI;
using UIKit;

namespace MvvmcrossIosApp.iOS
{
    [Register(nameof(AppDelegate))]
    public class AppDelegate : MvxApplicationDelegate<Setup, App>
    {
       
    }
}
