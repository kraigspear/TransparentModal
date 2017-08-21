using Foundation;
using System;
using UIKit;

namespace TransparentModel
{
    public partial class ModalViewController : UIViewController
    {
        public ModalViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            View.BackgroundColor = UIColor.Black.ColorWithAlpha(0.5f);
            View.Opaque = false;
        }

        partial void TapAction(UITapGestureRecognizer sender)
        {
            DismissViewController(true, null);
        }
    }
}