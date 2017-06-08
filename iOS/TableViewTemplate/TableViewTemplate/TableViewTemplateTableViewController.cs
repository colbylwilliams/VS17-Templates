using System;

using Foundation;
using UIKit;

namespace TableViewTemplate
{
	public partial class TableViewTemplateTableViewController : UITableViewController
	{
		public TableViewTemplateTableViewController (IntPtr handle) : base (handle)
		{
			// Used when instantiated from .storyboard
		}


		public override nint NumberOfSections (UITableView tableView)
		{
			return TableViewTemplateData.Sections.Count;
		}


		public override nint RowsInSection (UITableView tableView, nint section)
		{
			return TableViewTemplateData.Items [(int)section].Count;
		}


		public override string TitleForHeader (UITableView tableView, nint section)
		{
			return TableViewTemplateData.Sections [(int)section];
		}


		public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
		{
			var cell = tableView.DequeueReusableCell (typeof (TableViewTemplateTableViewCell).Name, indexPath) as TableViewTemplateTableViewCell;

			cell.TextLabel.Text = TableViewTemplateData.Items [indexPath.Section] [indexPath.Row];

			return cell;
		}


		public override void RowSelected (UITableView tableView, NSIndexPath indexPath)
		{
			if (Storyboard.InstantiateViewController (typeof (TableViewTemplateViewController).Name) is TableViewTemplateViewController controller)
			{
				controller.Item = TableViewTemplateData.Items [indexPath.Section] [indexPath.Row];

				controller.Section = TableViewTemplateData.Sections [indexPath.Section];

				ShowViewController (controller, this);
			}
		}
	}
}
