using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VirusAquarium.Simulation.Activities {
	public class BlueScreenActivity : ComputerActivity {
		bool reboot;
		public BlueScreenActivity(bool reboot) {
			this.reboot = reboot;
		}

		public override string Name {
			get { return "Blue Screen"; }
		}
		public override ComputerState State {
			get { return ComputerState.Crashed; }
		}

		public override ComputerActivity RunLoop() {
			if (reboot) this.Computer.Reboot(); //reboot immedeately
			return null; //or stay on the screen
		}
	}
}
