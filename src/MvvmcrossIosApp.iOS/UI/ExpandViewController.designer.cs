// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace MvvmcrossIosApp.iOS.UI
{
	[Register ("ExpandViewController")]
	partial class ExpandViewController
	{
		[Outlet]
		UIKit.UITableView Tableviewlabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (Tableviewlabel != null) {
				Tableviewlabel.Dispose ();
				Tableviewlabel = null;
			}
		}
	}
}
