using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VirusAquarium.Simulation.Activities;

namespace VirusAquarium.Simulation.Events {
	public class Event {
		public Computer Computer { get; set; }
		public ComputerActivity Activity { get; set; }
	}

	public class ComputerBootEvent : Event { }
	public class ComptuerLoginEvent : Event { }

	public class NetworkEstablishedEvent : Event { }

	public class ActivityStartEvent : Event { }
}
