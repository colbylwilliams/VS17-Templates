using System;

using UIKit;

namespace CollectionViewTemplate
{
	public partial class CollectionViewTemplateViewController : UIViewController
	{
		public string Item { get; set; }

		public string Section { get; set; }


		public CollectionViewTemplateViewController (IntPtr handle) : base (handle)
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
