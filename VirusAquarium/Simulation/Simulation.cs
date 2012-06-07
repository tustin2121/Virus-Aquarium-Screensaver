using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace VirusAquarium.Simulation {
	public class Simulation {
		/// <summary>
		/// Current tick of the simulation. Saved.
		/// </summary>
		public ulong CurrentTick { get; private set; }

		/// <summary>
		/// April Fools joke: On April 1st, there is a chance that viruses will "escape" the network.
		/// When that happens, the management program will report that "Failsafes have failed" and that
		/// a virus has escaped. Then, when the screensaver shuts down, it will launch a window on your
		/// screen that shows a picture which could be considered pron by only the vaugest of definitions.
		/// </summary>
		public int EscapedViruses { get; set; }

	}
}
