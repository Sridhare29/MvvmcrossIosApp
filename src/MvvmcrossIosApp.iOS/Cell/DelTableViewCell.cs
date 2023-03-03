using System;

using Foundation;
using MvvmCross.Platforms.Ios.Binding.Views;
using MvvmCross.ViewModels;
using MvvmcrossIosApp.Core.ViewModels;
using UIKit;

namespace MvvmcrossIosApp.iOS.Cell
{
    public partial class DelTableViewCell : MvxTableViewCell
    {
        public static readonly NSString Key = new NSString("DelTableViewCell");
        public static readonly UINib Nib;

        static DelTableViewCell()
        {
            Nib = UINib.FromName("DelTableViewCell", NSBundle.MainBundle);
        }

        protected DelTableViewCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

    }
}