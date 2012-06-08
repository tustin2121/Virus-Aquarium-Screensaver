using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

using VirusAquarium.Simulation;
using VirusAquarium.Simulation.Activities;
using VirusAquarium.Simulation.Events;
using VirusAquarium.Forms;

namespace VirusAquarium {
	public class MasterControl {
		private List<ScreensaverForm> formList; //primary form is first in the array
		private Timer simTimer, drawTimer;

		private Simulation.Simulation CurrentSim { get; set; }

		public MasterControl() {
			formList = new List<ScreensaverForm>(Screen.AllScreens.Length);
		}

		///////////////////////////////////////////////////////////

		

		///////////////////////////////////////////////////////////

		public void Startup() {
			//TEMP
			CurrentSim = new Simulation.Simulation();

			var c = new Computer();
			CurrentSim.AllComputers.Add(c);

			var f = formList[0];
			var n = new ComputerIcon();
			n.Model = c;
			n.Location = new Point(f.Bounds.Width / 2 - n.ScreenCenter.X, f.Bounds.Height / 2 - n.ScreenCenter.Y);
			f.Controls.Add(n);
			f.IconList.Add(n);

			CurrentSim.AllComputers.ForEach((co) => co.Reboot());
			//END TEMP
			
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
				ssf.UpdateView();
			}
		}

		protected void OnSimTick(object sender, EventArgs e) {
			CurrentSim.Tick();
		}

		public void HandleKeyInput(KeyEventArgs e) {
			//TODO if in keyboard input mode, don't shutdown, otherwise do, for all keys
			if (e.KeyCode == Keys.Escape) {
				Shutdown();
			}
		}


	}
}
