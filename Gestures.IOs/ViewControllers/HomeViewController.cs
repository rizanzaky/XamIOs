using System;
using Blank.Views.Home;
using CoreGraphics;
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

        private void HandleDrag(UIPanGestureRecognizer recognizer)
        {
            var offset = recognizer.TranslationInView(_homeView);
            _homeView.UpdateView(offset.Y);
            Console.WriteLine($"Hello World {offset.Y}");
            recognizer.SetTranslation(CGPoint.Empty, _homeView);
        }
    }
}