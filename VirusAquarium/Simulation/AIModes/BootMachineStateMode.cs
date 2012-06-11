using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VirusAquarium.Simulation.AIModes {
	public class BootMachineStateMode : AIStateMode {
		private BaseStateMode baseStateMode;

		public BootMachineStateMode(AIStateMode pm) : base(pm) { }

		public override AIStateMode RunStateMachine(AIUser user) {
			switch (user.OwnedComputer.CurrentState) {
				case ComputerState.Off: //start computer
					user.OwnedComputer.Reboot(); return null;
				case ComputerState.Booting: //wait for startup
					user.NoteWaitingTime(false);
					return null;
				default: //once finished, return to previous mode
					user.NoteWaitingTime(true); //finished waiting
					return PreviousMode;
			}
			
		}
	}
}
