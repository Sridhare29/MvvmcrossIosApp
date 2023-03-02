using System;
using Foundation;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Binding.Views;
using MvvmCross.Platforms.Ios.Views;
using MvvmcrossIosApp.Core.ViewModels;
using UIKit;

namespace MvvmcrossIosApp.iOS.Views
{
    public partial class ChartViewController : MvxViewController<MyListViewModel>

    {
        public ChartViewController() : base("ChartViewController", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var tableView = new UITableView(View.Bounds, UITableViewStyle.Plain);
            tableView.RegisterClassForCellReuse(typeof(MyListCell), MyListCell.Key);

            var source = new MyListTableViewSource(tableView);
            tableView.Source = source;

            View.AddSubview(tableView);
            this.CreateBinding(source).To<MyListViewModel>(vm => vm.Items).Apply();

        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        private class MyListTableViewSource : MvxTableViewSource
        {
            public MyListTableViewSource(UITableView tableView) : base(tableView)
            {
            }

            protected override UITableViewCell GetOrCreateCellFor(UITableView tableView, NSIndexPath indexPath, object item)
            {
                var cell = (MyListCell)TableView.DequeueReusableCell(MyListCell.Key, indexPath);

                if (cell == null)
                {
                    cell = new MyListCell();
                }

                return cell;
            }
        }
        public class MyListCell : MvxTableViewCell
        {
            public static readonly NSString Key = new NSString("MyListCell");

            public MyListCell() : base(Key, (IntPtr)UITableViewCellStyle.Default)
            {
                TextLabel.TextAlignment = UITextAlignment.Center;
            }


            public override void UpdateConstraints()
            {
                base.UpdateConstraints();

                TextLabel.CenterXAnchor.ConstraintEqualTo(CenterXAnchor).Active = true;
                TextLabel.CenterYAnchor.ConstraintEqualTo(CenterYAnchor).Active = true;
            }
        }

    }

}
