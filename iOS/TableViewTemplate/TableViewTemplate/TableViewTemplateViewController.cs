using System;

using UIKit;

namespace TableViewTemplate
{
	public partial class TableViewTemplateViewController : UIViewController
	{
		public string Item { get; set; }

		public string Section { get; set; }


		public TableViewTemplateViewController (IntPtr handle) : base (handle)
		{
			// Used when instantiated from .storyboard
		}


		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Do any additional setup after loading the view, typically from a nib.

			label.Text = $"{Section} : {Item}";
		}


		public override void ViewDidAppear (bool animated)
		{
			base.ViewDidAppear (animated);
			// Connect event handlers
		}


		public override void ViewDidDisappear (bool animated)
		{
			base.ViewDidDisappear (animated);
			// Disconnect event handlers
		}
	}
}
