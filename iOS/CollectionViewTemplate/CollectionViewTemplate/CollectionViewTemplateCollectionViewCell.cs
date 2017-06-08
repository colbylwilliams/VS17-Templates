using System;

using UIKit;

namespace CollectionViewTemplate
{
	public partial class CollectionViewTemplateCollectionViewCell : UICollectionViewCell
	{
		public CollectionViewTemplateCollectionViewCell (IntPtr handle) : base (handle)
		{
			// Used when instantiated from .storyboard
		}

		public void SetData (string data)
		{
			label.Text = data;
		}
	}
}
