using Blank.Views.Home;
using UIKit;

namespace Blank.ViewControllers
{
    public class HomeViewController : UIViewController
    {
        private readonly HomeView _homeView;

        public HomeViewController()
        {
            _homeView = new HomeView();
        }

        public override void LoadView()
        {
            View = _homeView;
        }
    }
}