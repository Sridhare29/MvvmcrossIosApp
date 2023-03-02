using System;
using CoreGraphics;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Views;
using MvvmCross.ViewModels;
using MvvmcrossIosApp.Core.ViewModels.Main;
using UIKit;

namespace MvvmcrossIosApp.iOS.Cell
{
    public partial class EXViewController : MvxViewController<Sampleviewmodel>
    {
        public EXViewController () : base ("EXViewController", null)
        {
        }

        private UIButton _button;

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            _button = UIButton.FromType(UIButtonType.System);
            _button.SetTitle("Click Me", UIControlState.Normal);
            _button.Frame = new CGRect(0, 0, 100, 50);
            _button.Center = View.Center;

            View.AddSubview(_button);

            var set = this.CreateBindingSet<EXViewController, Sampleviewmodel>();
            set.Bind(_button).To(vm => vm.ButtonClickCommand);
            set.Apply();
        }

        public override void DidReceiveMemoryWarning ()
        {
            base.DidReceiveMemoryWarning ();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}


