using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VirusAquarium.Simulation.AIModes {
	public abstract class AIStateMode {
		/// <summary>
		/// AIStateModes are set up like a stack: when the mode changes, the current mode is pushed onto
		/// the stack, the previous mode beneith it, with the assumtion that once one mode completes, then
		/// the previous mode will continue. Things like surfing the web will beget downloading something,
		/// which will then complete to surfing again.
		/// </summary>
		public AIStateMode PreviousMode { get; set; }

		protected Random RNG;

		public AIStateMode(AIStateMode PrevMode) {
			this.PreviousMode = PrevMode;
			this.RNG = new Random();
		}

		public abstract AIStateMode RunStateMachine(AIUser user);
	}
}
