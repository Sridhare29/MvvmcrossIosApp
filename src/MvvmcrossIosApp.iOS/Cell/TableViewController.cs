using System;
using MvvmCross.Platforms.Ios.Views;
using MvvmcrossIosApp.Core.Model;
using System.Collections.Generic;
using System.Linq; 
using UIKit;

namespace MvvmcrossIosApp.iOS.Cell
{
    public partial class TableViewController : MvxTableViewController<SectionModel>
    {
        public TableViewController (IntPtr handle) : base (handle)
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


