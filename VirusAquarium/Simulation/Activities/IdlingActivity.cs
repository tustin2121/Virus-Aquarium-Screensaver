using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VirusAquarium.Simulation.Activities {
	public class IdlingActivity : ComputerActivity {
		public override string Name {
			get { return "Idling"; }
		}
		public override ComputerActivity RunLoop() {
			return null;
		}
	}
}
