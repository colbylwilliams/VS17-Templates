using System;

using UIKit;

namespace CollectionViewTemplate
{
	public partial class CollectionViewTemplateCollectionViewHeader : UICollectionReusableView
	{
		public CollectionViewTemplateCollectionViewHeader (IntPtr handle) : base (handle)
		{
			// Used when instantiated from .storyboard
		}

		public void SetData (string data)
		{
			title.Text = data;
		}
	}
}
