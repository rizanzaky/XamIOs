using System;
using UIKit;

namespace Blank.Utility
{
    public static class Theme // TODO: check static necessity
    {
        public static UIColor PrimaryBackgroundColor { get; private set; } = UIColor.Black;
        public static UIColor SecondaryBackgroundColor { get; private set; } = UIColor.DarkGray;
        public static UIColor PrimaryTextColor { get; private set; } = UIColor.White;
        public static UIColor SecondaryTextColor { get; private set; } = UIColor.LightGray;

        public static UIImage SettingsIcon { get; private set; } = UIImage.FromBundle("SettingsWhiteIcon.png");
        //public static UIColor PrimaryBackgroundColor = UIColor.Black;
        //public static UIColor SecondaryBackgroundColor = UIColor.DarkGray;
        //public static UIColor PrimaryTextColor = UIColor.White;
        //public static UIColor SecondaryTextColor = UIColor.LightGray;

        public static void UpdateTheme(nint themeType)
        {
            switch (themeType)
            {
                case 2: // dark
                    PrimaryBackgroundColor = UIColor.Black;
                    SecondaryBackgroundColor = UIColor.DarkGray;
                    PrimaryTextColor = UIColor.White;
                    SecondaryTextColor = UIColor.LightGray;

                    SettingsIcon = UIImage.FromBundle("SettingsWhiteIcon.png");
                    break;
                default: // light
                    PrimaryBackgroundColor = UIColor.White;
                    SecondaryBackgroundColor = UIColor.LightGray;
                    PrimaryTextColor = UIColor.Black;
                    SecondaryTextColor = UIColor.DarkGray;

                    SettingsIcon = UIImage.FromBundle("HomeSettingsIcon.png");
                    break;
            }
        }
    }

    public class Palette
    {
        public UIColor PrimaryBackgroundColor { get; } = UIColor.Black;
        public UIColor SecondaryBackgroundColor { get; } = UIColor.DarkGray;
        public UIColor PrimaryTextColor { get; } = UIColor.White;
        public UIColor SecondaryTextColor { get; } = UIColor.LightGray;
    }
}