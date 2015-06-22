using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace UIBarButtonItemWithImage
{
	// The UIApplicationDelegate for the application. This class is responsible for launching the 
	// User Interface of the application, as well as listening (and optionally responding) to 
	// application events from iOS.
	[Register ("AppDelegate")]
	public partial class AppDelegate : UIApplicationDelegate
	{
		UIWindow window;
		UIBarButtonItemWithImageViewController viewController;
		UINavigationController nav;

		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			window = new UIWindow (UIScreen.MainScreen.Bounds);

			viewController = new UIBarButtonItemWithImageViewController ();
			nav = new UINavigationController (viewController);
			window.RootViewController = nav;
			window.MakeKeyAndVisible ();
            
			return true;
		}
	}
}

