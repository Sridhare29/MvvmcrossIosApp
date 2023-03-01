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
        public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
        {
            // Initialize MvvmCross
            Setup setup = new Setup(this, _window);
            setup.Initialize();

            // Register storyboard and view controller
            IMvxIosViewPresenter presenter = Mvx.IoCProvider.Resolve<IMvxIosViewPresenter>();
            presenter.RegisterStoryboard(R.ActionStoryboard);
            presenter.RegisterViewWithViewModel<ActionViewController, BasicviewModel>();

            // Run the app
            Window.MakeKeyAndVisible();
            return true;
        }
    }
}
