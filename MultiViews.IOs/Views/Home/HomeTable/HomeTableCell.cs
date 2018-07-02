using System;
using UIKit;

namespace Blank.Views.Home.HomeTable
{
    public class HomeTableCell : UITableViewCell
    {
        public const string CellId = "HomeTableCell";
        private UILabel _titleLabel;
        private UILabel _subTextLabel;
        private UIStackView _textStack;
        private UIStackView _rowStack;
        private UIImageView _cellIconView;

        public HomeTableCell(IntPtr handler) : base(handler)
        {
            _cellIconView = new UIImageView(UIImage.FromBundle("EleBlueIcon.png"));
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
            _textStack = new UIStackView { Axis = UILayoutConstraintAxis.Vertical, TranslatesAutoresizingMaskIntoConstraints = false };
            _titleLabel = new UILabel { TranslatesAutoresizingMaskIntoConstraints = false };
            _subTextLabel = new UILabel { TranslatesAutoresizingMaskIntoConstraints = false, Lines = 2 };
            _rowStack = new UIStackView { Axis = UILayoutConstraintAxis.Horizontal, TranslatesAutoresizingMaskIntoConstraints = false };
        }

        private void SetStyles()
        {
            BackgroundColor = UIColor.White; // TODO: theme

            _titleLabel.Font = UIFont.PreferredHeadline;
            _titleLabel.TextColor = UIColor.Black; // TODO: theme
            

            _subTextLabel.Font = UIFont.PreferredSubheadline;
            _subTextLabel.TextColor = UIColor.LightGray; // TODO: theme
        }

        private void SetHierarchy()
        {
            Add(_textStack);
            _textStack.AddArrangedSubview(_titleLabel);
            _textStack.AddArrangedSubview(_subTextLabel);
            Add(_rowStack);
            _rowStack.AddArrangedSubview(_textStack);
            _rowStack.AddArrangedSubview(_cellIconView);
        }

        private void SetConstraints()
        {
            _textStack.Spacing = 5f;
            //_textStack.TopAnchor.ConstraintEqualTo(TopAnchor, 5f).Active = true;
            //_textStack.LeftAnchor.ConstraintEqualTo(LeftAnchor).Active = true;
            //_textStack.RightAnchor.ConstraintEqualTo(RightAnchor).Active = true;
            //_textStack.BottomAnchor.ConstraintEqualTo(BottomAnchor, -5f).Active = true;

            _rowStack.Alignment = UIStackViewAlignment.Top;
            _rowStack.Distribution = UIStackViewDistribution.Fill;
            _rowStack.TopAnchor.ConstraintEqualTo(TopAnchor, 5f).Active = true;
            _rowStack.LeftAnchor.ConstraintEqualTo(LeftAnchor).Active = true;
            _rowStack.RightAnchor.ConstraintEqualTo(RightAnchor).Active = true;
            _rowStack.BottomAnchor.ConstraintEqualTo(BottomAnchor, -5f).Active = true;
        }

        private void BindData()
        {
            _titleLabel.Text = "Home Row";
            _subTextLabel.Text = "There are many variations of passages of Lorem Ipsum available, but the majority have suffered";
        }
    }
}