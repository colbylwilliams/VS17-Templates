using System;

using Foundation;
using UIKit;

namespace CollectionViewTemplate
{
	public partial class CollectionViewTemplateCollectionViewController : UICollectionViewController
	{
		public CollectionViewTemplateCollectionViewController (IntPtr handle) : base (handle)
		{
			// Used when instantiated from .storyboard
		}


		public override nint NumberOfSections (UICollectionView collectionView)
		{
			return CollectionViewTemplateData.Sections.Count;
		}


		public override nint GetItemsCount (UICollectionView collectionView, nint section)
		{
			return CollectionViewTemplateData.Items [(int)section].Count;
		}


		public override UICollectionViewCell GetCell (UICollectionView collectionView, NSIndexPath indexPath)
		{
			var cell = collectionView.DequeueReusableCell (typeof (CollectionViewTemplateCollectionViewCell).Name, indexPath) as CollectionViewTemplateCollectionViewCell;

			cell.SetData (CollectionViewTemplateData.Items [indexPath.Section] [indexPath.Row]);

			return cell;
		}


		public override UICollectionReusableView GetViewForSupplementaryElement (UICollectionView collectionView, NSString elementKind, NSIndexPath indexPath)
		{
			if (elementKind == UICollectionElementKindSectionKey.Header)
			{
				var header = collectionView.DequeueReusableSupplementaryView (elementKind, typeof (CollectionViewTemplateCollectionViewHeader).Name, indexPath) as CollectionViewTemplateCollectionViewHeader;

				header.SetData (CollectionViewTemplateData.Sections [indexPath.Section]);

				return header;
			}

			return base.GetViewForSupplementaryElement (collectionView, elementKind, indexPath);
		}


		public override void ItemSelected (UICollectionView collectionView, NSIndexPath indexPath)
		{
			if (Storyboard.InstantiateViewController (typeof (CollectionViewTemplateViewController).Name) is CollectionViewTemplateViewController controller)
			{
				controller.Item = CollectionViewTemplateData.Items [indexPath.Section] [indexPath.Row];

				controller.Section = CollectionViewTemplateData.Sections [indexPath.Section];

				ShowViewController (controller, this);
			}
		}
	}
}
