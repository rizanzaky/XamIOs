using Blank.Views.Home;
using Blank.Views.Home.HomeTable;
using UIKit;

namespace Blank.ViewControllers
{
    public class HomeViewController : UIViewController
    {
        private readonly HomeView _homeView;
        private readonly HomeTableSource _homeTableSource;

        public HomeViewController()
        {
            _homeTableSource = new HomeTableSource();
            _homeView = new HomeView();
        }

        public override void LoadView()
        {
            View = _homeView;
        }

        public override void ViewDidLoad()
        {
            _homeView.HomeTableView.Source = _homeTableSource;
        }
    }
}