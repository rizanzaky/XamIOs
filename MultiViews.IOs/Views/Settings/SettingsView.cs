using System;
using Blank.Utility;
using CoreGraphics;
using UIKit;

namespace Blank.Views.Settings
{
    public class SettingsView : UIView
    {
        public UIButton BackButton { get; private set; } // TODO: add navBar
        private UILabel _titleLabel;
        private UILabel _themesLabel;
        private UIStackView _themesStack;

        private UIButton _lightTheme;
        private UIButton _darkTheme;
        private UIView _stackFiller;

        public SettingsView()
        {
            InitElements();
        }

        private void InitElements()
        {
            CreateElements();
            SetStyles();
            SetHierarchy();
            SetConstraints();
            BindData(); // TODO: MVVM
        }

        internal void UpdateElements()
        {
            SetStyles();
        }

        private void CreateElements()
        {
            BackButton = new UIButton(UIButtonType.System) { TranslatesAutoresizingMaskIntoConstraints = false };
            BackButton.SetTitle("Back", UIControlState.Normal);
            _titleLabel = new UILabel { AdjustsFontForContentSizeCategory = true, TranslatesAutoresizingMaskIntoConstraints = false };
            _themesLabel = new UILabel { AdjustsFontForContentSizeCategory = true, TranslatesAutoresizingMaskIntoConstraints = false };
            _themesStack = new UIStackView { Axis = UILayoutConstraintAxis.Horizontal, TranslatesAutoresizingMaskIntoConstraints = false };

            _lightTheme = new UIButton(UIButtonType.System) { Frame = new CGRect(0, 0, 50f, 50f), BackgroundColor = UIColor.White, Tag = 1 };
            _darkTheme = new UIButton(UIButtonType.System) { Frame = new CGRect(0, 0, 50f, 50f), BackgroundColor = UIColor.Black, Tag = 2 };
            _stackFiller = new UIView();

            _lightTheme.TouchUpInside += (sender, args) => { ThemeChanged?.Invoke(this, new ThemeEventArgs(_lightTheme.Tag)); };
            _darkTheme.TouchUpInside += (sender, args) => { ThemeChanged?.Invoke(this, new ThemeEventArgs(_darkTheme.Tag)); };
        }

        private void SetStyles()
        {
            BackgroundColor = Theme.PrimaryBackgroundColor; // UIColor.White; // TODO: theme

            BackButton.Layer.BorderWidth = 1f;
            BackButton.Layer.BorderColor = UIColor.Blue.CGColor; // TODO: theme
            BackButton.ContentEdgeInsets = new UIEdgeInsets(10f, 30f, 10f, 30f);

            _titleLabel.Font = UIFont.PreferredTitle1;
            _titleLabel.TextColor = Theme.PrimaryTextColor; // UIColor.Black; // TODO: theme

            _themesLabel.Font = UIFont.PreferredTitle3;
            _themesLabel.TextColor = Theme.PrimaryTextColor; // UIColor.Black; // TODO: theme

            _lightTheme.Layer.BorderWidth = 1f;
            _darkTheme.Layer.BorderWidth = 1f;
            _lightTheme.Layer.BorderColor = Theme.PrimaryTextColor.CGColor; // TODO: theme
            _darkTheme.Layer.BorderColor = Theme.PrimaryTextColor.CGColor; // TODO: theme
        }

        private void SetHierarchy()
        {
            Add(BackButton);
            Add(_titleLabel);
            Add(_themesLabel);
            Add(_themesStack);

            _themesStack.AddArrangedSubview(_lightTheme);
            _themesStack.AddArrangedSubview(_darkTheme);
            _themesStack.AddArrangedSubview(_stackFiller);
        }

        private void SetConstraints()
        {
            BackButton.TopAnchor.ConstraintEqualTo(LayoutMarginsGuide.TopAnchor, 10f).Active = true;
            BackButton.LeftAnchor.ConstraintEqualTo(LayoutMarginsGuide.LeftAnchor, 5f).Active = true;

            _titleLabel.TopAnchor.ConstraintEqualTo(BackButton.BottomAnchor, 25f).Active = true;
            _titleLabel.CenterXAnchor.ConstraintEqualTo(LayoutMarginsGuide.CenterXAnchor).Active = true;

            _themesLabel.TopAnchor.ConstraintEqualTo(_titleLabel.BottomAnchor, 25f).Active = true;
            _themesLabel.LeftAnchor.ConstraintEqualTo(LayoutMarginsGuide.LeftAnchor, 10f).Active = true;

            _themesStack.TopAnchor.ConstraintEqualTo(_themesLabel.BottomAnchor, 20f).Active = true;
            _themesStack.LeftAnchor.ConstraintEqualTo(LayoutMarginsGuide.LeftAnchor, 10f).Active = true;
            _themesStack.RightAnchor.ConstraintEqualTo(LayoutMarginsGuide.RightAnchor, -10f).Active = true;
            _themesStack.Distribution = UIStackViewDistribution.Fill;
            _themesStack.Spacing = 20f;
        }

        private void BindData()
        {
            _titleLabel.Text = "Settings";
            _themesLabel.Text = "Themes";
        }

        public EventHandler<ThemeEventArgs> ThemeChanged;
    }

    public class ThemeEventArgs : EventArgs
    {
        public ThemeEventArgs(nint themeType)
        {
            ThemeType = themeType;
        }

        public nint ThemeType { get; }
    }
}