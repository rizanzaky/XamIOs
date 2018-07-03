﻿using System;
using Blank.Utility;
using Blank.Views.Settings;
using UIKit;

namespace Blank.ViewControllers
{
    public class SettingsViewController : UIViewController
    {
        private readonly SettingsView _settingsView;

        public SettingsViewController()
        {
            _settingsView = new SettingsView();
        }

        public override void LoadView()
        {
            View = _settingsView;
        }

        public override void ViewDidLoad()
        {
            _settingsView.BackButton.TouchUpInside += OnBackButtonTouched;
            _settingsView.ThemeChanged += OnThemeChanged;
        }

        private void OnThemeChanged(object sender, ThemeEventArgs args)
        {
            Console.WriteLine($"Value: {args.ThemeType}");
            Theme.UpdateTheme(args.ThemeType);
            _settingsView.UpdateElements();
            //Theme.Update(ref Theme.PrimaryBackgroundColor);
        }

        private void OnBackButtonTouched(object sender, EventArgs e)
        {
            DismissViewController(true, null);
        }
    }
}