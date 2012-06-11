using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VirusAquarium.Simulation.Activities {
	public class OffActivity : ComputerActivity {
		public override string Name {
			get { return "Off"; }
		}
		public override ComputerState State {
			get { return ComputerState.Off; }
		}
		public override ComputerActivity RunLoop() { return null; }
	}
}
