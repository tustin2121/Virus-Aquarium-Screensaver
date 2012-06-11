using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VirusAquarium.Simulation.AIModes {
	public class BaseStateMode : AIStateMode {
		//This should be the only mode without a previous state to fall back on
		public BaseStateMode() : base(null) { }

		public override AIStateMode RunStateMachine(AIUser user) {
			switch (user.OwnedComputer.CurrentState) {
				case ComputerState.Off:
					return new BootMachineStateMode(this);
				case ComputerState.Booting:
					user.NoteWaitingTime(false);
					return null; //do nothing while computer is booting
				case ComputerState.Idling:
					user.NoteWaitingTime(true); //finished waiting time
					switch (RNG.Next(10)) {
						case 0:
							//TODO for each number, pull up a different activity
						default:
							break;
					}
					return null; //?
				case ComputerState.Unresponsive:
				case ComputerState.Crashed:
				default:
					throw new Exception("BaseStateMode given Unknown Computer state! State:"+user.OwnedComputer.CurrentState
						+" Named:"+Enum.GetName(typeof(ComputerState), user.OwnedComputer.CurrentState));
			}
		}
	}
}
