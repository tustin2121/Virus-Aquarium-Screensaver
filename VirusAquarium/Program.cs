using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace VirusAquarium {
	static class Program {
		static MasterControl masterControlProgram;

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args) {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
		//	Application.Run(new ScreensaverForm());

			if (args.Length > 0) {
				string mode = args[0].ToLower().Trim();
				string handle = null;

				// Handle cases where arguments are separated by colon.
				// Examples: /c:1234567 or /P:1234567
				if (mode.Length > 2) {
					handle = mode.Substring(3).Trim();
					mode = mode.Substring(0, 2);

				} else if (args.Length > 1) {
					handle = args[1];
				}

				switch (mode[1]) { // modes based on whether /c, /p, or /s is passed in
					case 'c': //Config mode "/c"
						Application.Run(new SettingsForm());
						break;
					case 'p': //Preview mode "/p"
						if (handle == null) {
							MessageBox.Show("Error: Expected window handle.", "Virus Aquarium Screensaver", MessageBoxButtons.OK, MessageBoxIcon.Error);
							return;
						}

						IntPtr wndHandle = new IntPtr(long.Parse(handle));
						Application.Run(new PreviewForm(wndHandle));
						break;
					case 's': //Full-screen mode "/s"
						ShowScreenSaver();
						Application.Run();
						break;
					default: //undefined argument
						MessageBox.Show("Error: Invalid command line argument: " + mode, "Virus Aquarium Screensaver", MessageBoxButtons.OK, MessageBoxIcon.Information);
						break;
				}
			} else {
				//no line arguments
				MessageBox.Show("This is the Virus Aquarium Screensaver, made by Tustin2121. To run, supply a \"/s\" argument.", "Virus Aquarium Screensaver", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}

		}

		static void ShowScreenSaver() {
			masterControlProgram = new MasterControl();

			foreach (Screen sc in Screen.AllScreens) {
				ScreensaverForm ssf = new ScreensaverForm(masterControlProgram, sc.Bounds);
				ssf.Show();
			}
		}
	}
}
