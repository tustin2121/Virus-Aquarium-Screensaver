using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VirusAquarium.Simulation.Activities {
	public class FrozenActivity : ComputerActivity {
		private const int AVG_THAWTIME = 10;

		public bool IsSolid { get; set; }
		public int TimeTillThaw { get; set; }
		public ComputerActivity ActivityToResume { get; set; }

		public FrozenActivity() : this(0, null) { }
		public FrozenActivity(ComputerActivity resumeActivity) : this(AVG_THAWTIME, resumeActivity) { }
		public FrozenActivity(int maxThaw, ComputerActivity resumeActivity) {
			this.IsSolid = (maxThaw == 0 || resumeActivity == null);
			this.TimeTillThaw = new Random().Next(maxThaw);
			this.ActivityToResume = resumeActivity;
		}

		public override string Name {
			get { return "Not Responding"; }
		}
		public override ComputerState State {
			get { return ComputerState.Unresponsive; }
		}

		public override ComputerActivity RunLoop() {
			if (IsSolid) return null;
			if (Runtime > TimeTillThaw) return ActivityToResume;
			return null;
		}
	}
}
