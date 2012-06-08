using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VirusAquarium.Simulation.Activities {
	public abstract class ComputerActivity {
		public abstract string Name { get; }
		public float Runtime { get; set; }
		public Computer Computer { get; set; }

		/// <summary>
		/// Runs at the start of the activity, to set it up
		/// </summary>
		public virtual void Begin() {}

		/// <summary>
		/// Runs during the loop of the activity. If the activity should end, 
		/// it should return a non-null value.
		/// </summary>
		/// <returns>A ComputerActivity to change to, null to continue the activity</returns>
		public abstract ComputerActivity RunLoop();

		/// <summary>
		/// Runs at the completion of the activity, for cleanup
		/// </summary>
		public virtual void Terminate() {}
	}
}
