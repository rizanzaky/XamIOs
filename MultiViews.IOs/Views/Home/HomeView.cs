using Blank.Views.Home.HomeTable;
using UIKit;

namespace Blank.Views.Home
{
    public class HomeView : UIView
    {
        private UIStackView _topHorizontalStack;
        private UILabel _myHomeLabel;
        private readonly UIImage _settingsIcon;
        private UIButton _settingsButton;
        private UITextView _myHomeDescriptionText;
        public HomeTableView HomeTableView { get; private set; }

        public HomeView()
        {
            _settingsIcon = UIImage.FromBundle("HomeSettingsIcon.png");
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

        private void CreateElements()
        {
            _topHorizontalStack = new UIStackView { Axis = UILayoutConstraintAxis.Horizontal, TranslatesAutoresizingMaskIntoConstraints = false };
            _myHomeLabel = new UILabel { AdjustsFontForContentSizeCategory = true, TranslatesAutoresizingMaskIntoConstraints = false };
            _settingsButton = new UIButton(UIButtonType.System) { TranslatesAutoresizingMaskIntoConstraints = false };
            _myHomeDescriptionText = new UITextView { ScrollEnabled = false, AdjustsFontForContentSizeCategory = true, TranslatesAutoresizingMaskIntoConstraints = false };
            HomeTableView = new HomeTableView { TranslatesAutoresizingMaskIntoConstraints = false };
        }

        private void SetStyles()
        {
            BackgroundColor = UIColor.White; // TODO: theme

            _myHomeLabel.Font = UIFont.PreferredTitle1;
            _myHomeLabel.TextColor = UIColor.Black; // TODO: theme

            _settingsButton.SetBackgroundImage(_settingsIcon, UIControlState.Normal);

            _myHomeDescriptionText.Font = UIFont.PreferredSubheadline;
            _myHomeDescriptionText.BackgroundColor = UIColor.LightGray; // TODO: theme
            _myHomeDescriptionText.TextColor = UIColor.DarkGray; // TODO: theme
        }

        private void SetHierarchy()
        {
            Add(_topHorizontalStack);
            _topHorizontalStack.AddArrangedSubview(_myHomeLabel);
            _topHorizontalStack.AddArrangedSubview(_settingsButton);
            Add(_myHomeDescriptionText);
            Add(HomeTableView);
        }

        private void SetConstraints()
        {
            _topHorizontalStack.TopAnchor.ConstraintEqualTo(LayoutMarginsGuide.TopAnchor, 15f).Active = true;
            _topHorizontalStack.LeftAnchor.ConstraintEqualTo(LayoutMarginsGuide.LeftAnchor, 10f).Active = true;
            _topHorizontalStack.RightAnchor.ConstraintEqualTo(LayoutMarginsGuide.RightAnchor, -10f).Active = true;
            _topHorizontalStack.Alignment = UIStackViewAlignment.Center;
            _topHorizontalStack.Distribution = UIStackViewDistribution.Fill;
            
            _settingsButton.HeightAnchor.ConstraintEqualTo(32f).Active = true;
            _settingsButton.WidthAnchor.ConstraintEqualTo(32f).Active = true;

            _myHomeDescriptionText.TopAnchor.ConstraintEqualTo(_topHorizontalStack.BottomAnchor, 15f).Active = true;
            _myHomeDescriptionText.LeftAnchor.ConstraintEqualTo(LayoutMarginsGuide.LeftAnchor, 10f).Active = true;
            _myHomeDescriptionText.RightAnchor.ConstraintEqualTo(LayoutMarginsGuide.RightAnchor, -10f).Active = true;

            HomeTableView.TopAnchor.ConstraintEqualTo(_myHomeDescriptionText.BottomAnchor, 20f).Active = true;
            HomeTableView.LeftAnchor.ConstraintEqualTo(LayoutMarginsGuide.LeftAnchor, 10f).Active = true;
            HomeTableView.RightAnchor.ConstraintEqualTo(LayoutMarginsGuide.RightAnchor, -10f).Active = true;
            HomeTableView.BottomAnchor.ConstraintEqualTo(LayoutMarginsGuide.BottomAnchor, -15f).Active = true;
        }

        // TODO: MVVM
        private void BindData()
        {
            _myHomeLabel.Text = "My Home";
            _myHomeDescriptionText.Text = "There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form";
        }
    }
}