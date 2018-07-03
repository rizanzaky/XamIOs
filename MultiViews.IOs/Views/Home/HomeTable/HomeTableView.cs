using System;
using Blank.Utility;
using UIKit;

namespace Blank.Views.Home.HomeTable
{
    public class HomeTableView : UITableView
    {
        public HomeTableView()
        {
            RegisterClassForCellReuse(typeof(HomeTableCell), HomeTableCell.CellId);
            BackgroundColor = Theme.PrimaryBackgroundColor; // UIColor.Black; // UIColor.White; // TODO: theme
        }

        internal void UpdateElements()
        {
            BackgroundColor = Theme.PrimaryBackgroundColor;
        }
    }
}