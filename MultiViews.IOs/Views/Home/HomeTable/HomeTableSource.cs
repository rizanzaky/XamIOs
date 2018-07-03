using System;
using Foundation;
using UIKit;

namespace Blank.Views.Home.HomeTable
{
    public class HomeTableSource : UITableViewSource
    {
        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = (HomeTableCell)tableView.DequeueReusableCell("HomeTableCell");
            cell.UpdateElements();
            return cell;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return 5; // TODO: MVVM, TODO: common models
        }
    }
}