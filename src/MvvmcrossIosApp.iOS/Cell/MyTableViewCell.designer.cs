// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace MvvmcrossIosApp.iOS.Cell
{
	[Register ("MyTableViewCell")]
	partial class MyTableViewCell
	{
		[Outlet]
		UIKit.UILabel subtittletext { get; set; }

		[Outlet]
		UIKit.UILabel tittletext { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (tittletext != null) {
				tittletext.Dispose ();
				tittletext = null;
			}

			if (subtittletext != null) {
				subtittletext.Dispose ();
				subtittletext = null;
			}
		}
	}
}
