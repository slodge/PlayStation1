using System;
using System.Collections.Generic;

using Sce.Pss.Core;
using Sce.Pss.Core.Environment;
using Sce.Pss.Core.Graphics;
using Sce.Pss.Core.Input;

using Sce.Pss.HighLevel.UI;
using PssUI1;

namespace PSS1
{
	public class AppMain
	{
		private static GraphicsContext graphics;
		
		public static void Main (string[] args)
		{
			Initialize ();

			while (true) {
				SystemEvents.CheckEvents ();
				Update ();
				Render ();
			}
		}

		public static void Initialize ()
		{
			// Set up the graphics system
			graphics = new GraphicsContext ();
			
			UISystem.Initialize(graphics);
			
			// Create scene
			Scene s = new Scene1();
			
			// Set scene
			UISystem.SetScene(s, null);

		}

		public static void Update ()
		{
			// Query gamepad for current state
			var gamePadData = GamePad.GetData (0);
			
			List<TouchData> tdl = Touch.GetData(0);
			
			UISystem.Update(tdl);
		}

		public static void Render ()
		{
			// Clear the screen
			graphics.SetClearColor (220.0f, 220.0f, 255.0f, 0.0f);
			graphics.Clear ();
			
			UISystem.Render();
			
			// Present the screen
			graphics.SwapBuffers ();
		}
	}
}
