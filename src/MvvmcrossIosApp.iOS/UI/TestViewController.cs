using System;
using MvvmCross.Platforms.Ios.Views;
using MvvmcrossIosApp.Core.ViewModels;
using UIKit;

namespace MvvmcrossIosApp.iOS.UI
{
    public partial class TestViewController : MvxViewController<HomeViewModel>
    {
        public TestViewController () : base ("TestViewController", null)
        {
        }

        public override void ViewDidLoad ()
        {
            base.ViewDidLoad ();
            datestext.Text = DateTime.Now.ToString("dd MMMM yyyy").ToUpper();
        }

        public override void DidReceiveMemoryWarning ()
        {
            base.DidReceiveMemoryWarning ();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}


