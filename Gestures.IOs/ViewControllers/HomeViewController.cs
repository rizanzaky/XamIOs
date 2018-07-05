using System;
using Blank.Views.Home;
using UIKit;

namespace Blank.ViewControllers
{
    public class HomeViewController : UIViewController
    {
        private HomeView _homeView;

        public HomeViewController()
        {
            _homeView = new HomeView();
        }

        public override void LoadView()
        {
            View = _homeView;
        }

        public override void ViewDidLoad()
        {
            WireUpDragGestureRecognizer();
        }

        private void WireUpDragGestureRecognizer()
        {
            var gesture = new UIPanGestureRecognizer();
            gesture.AddTarget(() => HandleDrag(gesture));
            _homeView.AddGestureRecognizer(gesture);
        }

        private void HandleDrag(UIPanGestureRecognizer gesture)
        {
            Console.WriteLine("Hello World");
        }
    }
}