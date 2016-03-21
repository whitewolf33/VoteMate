﻿using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using Foundation;
using UIKit;
using ImageCircle.Forms.Plugin.iOS;

namespace VoteMate.iOS
{
	[Register ("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			Forms.Init ();
			Forms.Init ();
			ImageCircleRenderer.Init ();

			// Code for starting up the Xamarin Test Cloud Agent
			#if ENABLE_TEST_CLOUD
			Xamarin.Calabash.Start ();
			#endif

			LoadApplication (new VoteMate ());

			return base.FinishedLaunching (app, options);
		}
	}
}

