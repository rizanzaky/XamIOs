using UIKit;

namespace Blank.Views.Home.HomeTable
{
    public class HomeTableView : UITableView
    {
        public HomeTableView()
        {
            RegisterClassForCellReuse(typeof(HomeTableCell), HomeTableCell.CellId);
        }
    }
}