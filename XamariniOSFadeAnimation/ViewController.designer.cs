// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace XamariniOSFadeAnimation
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnHide { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnShow { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView view1 { get; set; }

        [Action ("BtnHide_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void BtnHide_TouchUpInside (UIKit.UIButton sender);

        [Action ("BtnShow_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void BtnShow_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnHide != null) {
                btnHide.Dispose ();
                btnHide = null;
            }

            if (btnShow != null) {
                btnShow.Dispose ();
                btnShow = null;
            }

            if (view1 != null) {
                view1.Dispose ();
                view1 = null;
            }
        }
    }
}