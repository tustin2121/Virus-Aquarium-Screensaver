using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VirusAquarium.Simulation.Activities {
	public class BootingActivity : ComputerActivity {
		public override string Name {
			get { return "Booting"; }
		}
		public override ComputerActivity RunLoop() {
			if (this.Runtime > 9) return new StartupActivity();
			return null;
		}
	}
}
