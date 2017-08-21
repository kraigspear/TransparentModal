// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace TransparentModel
{
    [Register ("ModalViewController")]
    partial class ModalViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITapGestureRecognizer CloseTabGesture { get; set; }

        [Action ("TapAction:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void TapAction (UIKit.UITapGestureRecognizer sender);

        void ReleaseDesignerOutlets ()
        {
            if (CloseTabGesture != null) {
                CloseTabGesture.Dispose ();
                CloseTabGesture = null;
            }
        }
    }
}