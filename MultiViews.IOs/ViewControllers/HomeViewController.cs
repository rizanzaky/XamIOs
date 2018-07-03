using System;
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
            _homeView.SettingsButton.TouchUpInside += OnHomeSettingsTapped;
            SettingsViewController.ThemeChanged += OnThemeChanged;
        }

        private void OnThemeChanged(object sender, EventArgs e)
        {
            _homeView.UpdateElements();
        }

        private void OnHomeSettingsTapped(object sender, EventArgs e)
        {
            // navigate to settings page
            var settingsController = new SettingsViewController();
            settingsController.NavigationItem.SetLeftBarButtonItem(new UIBarButtonItem { Title = "Back" }, true);
            PresentViewController(settingsController, true, null);
        }
    }
}