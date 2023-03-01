using System;
using MvvmCross.Platforms.Ios.Views;
using MvvmcrossIosApp.Core.ViewModels;
using UIKit;

namespace MvvmcrossIosApp.iOS.UI
{
    public partial class ExpandViewController : MvxViewController<Expand>
    {
        public ExpandViewController () 
        {
        }

        public override void ViewDidLoad ()
        {
            base.ViewDidLoad ();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning ()
        {
            base.DidReceiveMemoryWarning ();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}


