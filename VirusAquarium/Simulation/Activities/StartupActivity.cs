using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VirusAquarium.Simulation.Activities {
	public class StartupActivity : ComputerActivity {
		Queue<RunnableProgram> stillToActivate;
		int nextStart; //next tick to start a program at

		public override string Name {
			get { return "Starting Up"; }
		}
		public override ComputerState State {
			get { return ComputerState.Booting; }
		}

		public override void Begin() {
			stillToActivate = new Queue<RunnableProgram>(this.Computer.StartupPrograms);
			nextStart = 10;
		}
		public override ComputerActivity RunLoop() {
			if (this.Runtime > nextStart) {
				if (stillToActivate.Count > 0) {
					RunnableProgram v = stillToActivate.Dequeue();
					v.Execute(v);
					if (v.IsRunning) this.Computer.RunningPrograms.Add(v);

					nextStart += 2;
				} else {
					return new LoggingInActivity();
				}
			}
			return null;
		}
	}
}
