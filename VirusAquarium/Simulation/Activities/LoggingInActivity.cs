using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VirusAquarium.Simulation.Activities {
	public class LoggingInActivity : ComputerActivity {
		public override string Name {
			get { return "Logging In"; }
		}
		public override ComputerState State {
			get { return ComputerState.Booting; }
		}

		public override ComputerActivity RunLoop() {
			if (this.Runtime > (3 * this.Computer.RunningPrograms.Count)+15)
				return new IdlingActivity();
			else
				return null;
		}
	}
}
