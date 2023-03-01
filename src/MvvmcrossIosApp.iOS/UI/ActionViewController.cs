using System;
using MvvmCross.Platforms.Ios.Views;
using MvvmcrossIosApp.Core.ViewModels.Main;
using UIKit;

namespace MvvmcrossIosApp.iOS.UI
{
    public partial class ActionViewController : MvxTableViewController<BasicviewModel>
    {
        public ActionViewController () : base ("ActionViewController", null)
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


