using UIKit;

namespace Blank.Views.Home.HomeTable
{
    public class HomeTableView : UITableView
    {
        public HomeTableView()
        {
            RegisterClassForCellReuse(typeof(HomeTableCell), HomeTableCell.CellId);
            BackgroundColor = UIColor.Black; // UIColor.White; // TODO: theme
        }
    }
}