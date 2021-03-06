﻿using Foundation;
using UIKit;
using CoreText;

using MaterialComponents.MaterialIcons;
//using MaterialComponents.Icons;

namespace ShrineRemoteImage.iOS
{
    using ShrineRemoteImage.iOS.View;
    // The UIApplicationDelegate for the application. This class is responsible for launching the
    // User Interface of the application, as well as listening (and optionally responding) to application events from iOS.
    [Register("AppDelegate")]
    public class AppDelegate : UIApplicationDelegate
    {
        // class-level declarations

        public override UIWindow Window { get; set;  }

        public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)  {
            // Override point for customization after application launch.
            // If not required for your application you can safely delete this method

            var flexHeadVC = ShrineFlexibleHeaderContainerViewController.InitializeWithController();
            Window.RootViewController = flexHeadVC;
            Window.MakeKeyAndVisible();

            MDCIcons.Ic_arrow_backUseNewStyle(true);

            //var p = MDCIcons.PathFor_ic_arrow_back;
            //var backButtonImage = MDCIcons.ImageFor_ic_arrow_back;
            //var pa = MDCIcons.PathFor_ic_arrow_back;
            return true;
        }
    }
}

