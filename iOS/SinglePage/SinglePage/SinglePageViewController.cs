using System;

using UIKit;

namespace SinglePage
{
	public partial class SinglePageViewController : UIViewController
	{
		public SinglePageViewController (IntPtr handle) : base (handle)
		{
			// Used when instantiated from .storyboard
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Do any additional setup after loading the view, typically from a nib.
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

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Dispose of any resources that can be recreated.
		}
	}
}
