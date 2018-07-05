using System;
using UIKit;

namespace Blank.Views.Home
{
    public class HomeView : UIView
    {
        private UIView _topView;
        private UIView _bottomView;
        private NSLayoutConstraint _topConstraint;

        public HomeView()
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

        private void CreateElements()
        {
            _topView = new UIView { TranslatesAutoresizingMaskIntoConstraints = false };
            _bottomView = new UIView { TranslatesAutoresizingMaskIntoConstraints = false };
        }

        private void SetStyles()
        {
            _topView.BackgroundColor = UIColor.Red;
            _bottomView.BackgroundColor = UIColor.Blue;
        }

        private void SetHierarchy()
        {
            Add(_topView);
            Add(_bottomView);
        }

        private void SetConstraints()
        {
            _topConstraint = _topView.TopAnchor.ConstraintEqualTo(TopAnchor);
            _topConstraint.Active = true;
            _topView.LeftAnchor.ConstraintEqualTo(LeftAnchor).Active = true;
            _topView.RightAnchor.ConstraintEqualTo(RightAnchor).Active = true;
            _topView.HeightAnchor.ConstraintEqualTo(80f).Active = true;

            _bottomView.TopAnchor.ConstraintEqualTo(_topView.BottomAnchor).Active = true;
            _bottomView.LeftAnchor.ConstraintEqualTo(LeftAnchor).Active = true;
            _bottomView.RightAnchor.ConstraintEqualTo(RightAnchor).Active = true;
            _bottomView.HeightAnchor.ConstraintEqualTo(1000f).Active = true;
        }

        private void BindData()
        {

        }

        public void UpdateView(nfloat updateBy)
        {
            if (_topConstraint.Constant + updateBy < -80f || _topConstraint.Constant + updateBy > 0f)
            {
                return;
            }

            _topConstraint.Constant += updateBy;
        }
    }
}