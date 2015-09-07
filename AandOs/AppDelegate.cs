using System;

using Foundation;
using AppKit;

namespace AandOs
{
	public partial class AppDelegate : NSApplicationDelegate
	{
		MainWindowController mainWindowController;

		public AppDelegate ()
		{
		}

		public override void DidFinishLaunching (NSNotification notification)
		{
			mainWindowController = new MainWindowController ();

			// Tells the main window that it should be in focus and accept user input (key)
			mainWindowController.Window.MakeKeyAndOrderFront (this);
		}
	}
}

