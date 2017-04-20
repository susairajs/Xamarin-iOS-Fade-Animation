using System;
using CoreGraphics;
using UIKit;

namespace XamariniOSFadeAnimation
{
	public partial class ViewController : UIViewController
	{
		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.
		}

		partial void BtnHide_TouchUpInside(UIButton sender)
		{
			FadeAnimation(view1, isIn: false, duration: 1, onFinished: null);
		}

		partial void BtnShow_TouchUpInside(UIButton sender)
		{
			FadeAnimation(view1, isIn: true, duration: 1, onFinished: null);
		}


		public static void FadeAnimation(UIView view, bool isIn, double duration = 0.3, Action onFinished = null)
		{
			var minAlpha = (nfloat)0.0f;
			var maxAlpha = (nfloat)1.0f;

			view.Alpha = isIn ? minAlpha : maxAlpha;
			view.Transform = CGAffineTransform.MakeIdentity();
			UIView.Animate(duration, 0, UIViewAnimationOptions.CurveEaseInOut,
				() =>
				{
					view.Alpha = isIn ? maxAlpha : minAlpha;
				},
				onFinished
			);
		}


		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}
