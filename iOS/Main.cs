using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace neu_PDA.iOS
{
	public class Application
	{
		// This is the main entry point of the application.
		static void Main(string[] args)
		{
			// if you want to use a different Application Delegate class from "AppDelegate"
			// you can specify it here.
			App.getCLR = new GetCLR(new WebClient_clr());

			UIApplication.Main(args, null, "AppDelegate");
		}
	}
}

