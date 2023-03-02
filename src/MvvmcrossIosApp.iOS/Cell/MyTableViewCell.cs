using System;

using Foundation;
using MvvmcrossIosApp.Core.Model;
using UIKit;

namespace MvvmcrossIosApp.iOS.Cell
{
    public partial class MyTableViewCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString ("MyTableViewCell");
        public static readonly UINib Nib;

        static MyTableViewCell ()
        {
            Nib = UINib.FromName ("MyTableViewCell", NSBundle.MainBundle);
        }

        protected MyTableViewCell (IntPtr handle) : base (handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
        public MyTableViewCell()
        {
        }

        public void PopulateCell(SectionModel gameObj)
        {
            tittletext.Text = gameObj.Title;
            subtittletext.Text = gameObj.Subtitle;
        }
    }
}

