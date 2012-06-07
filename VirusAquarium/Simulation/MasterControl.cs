using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VirusAquarium {
	public class MasterControl {
		private List<ScreensaverForm> formList; //primary form is first in the array
		private Timer simTimer, drawTimer;

		public MasterControl() {
			formList = new List<ScreensaverForm>(Screen.AllScreens.Length);
		}

		

		///////////////////////////////////////////////////////////

		public void Startup() {
			//setup update timers
			simTimer = new Timer();
			simTimer.Interval = 100;
			simTimer.Tick += new EventHandler(OnSimTick);

			drawTimer = new Timer();
			drawTimer.Interval = 60;
			drawTimer.Tick += new EventHandler(OnDrawTick);

			simTimer.Start(); drawTimer.Start();

		}

		public void Shutdown() {
			simTimer.Stop();

			//TODO

			drawTimer.Stop();
			Application.Exit();
		}

		///////////////////////////////////////////////////////////

		public void AddForm(ScreensaverForm ssf) {
			formList.Add(ssf);
			ssf.IsPrimary = (formList.Count == 1);
		}

		///////////////////////////////////////////////////////////

		protected void OnDrawTick(object sender, EventArgs e) {
			foreach(ScreensaverForm ssf in formList){
				ssf
			}
		}

		protected void OnSimTick(object sender, EventArgs e) {
			
		}

		public void HandleKeyInput(KeyEventArgs e) {
			//TODO if in keyboard input mode, don't shutdown, otherwise do, for all keys
			if (e.KeyCode == Keys.Escape) {
				Shutdown();
			}
		}


	}
}
