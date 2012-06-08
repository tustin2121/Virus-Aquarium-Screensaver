using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VirusAquarium.Simulation {

	public enum CompAssesement {
		Healthy, Slow, BootLoop, 
	}

	/// <summary>
	/// Represents the stupid user AI that are using the computer. They will show their status updates
	/// (that is, what they are doing currently) up on top of the computer screen. Their statuses will
	/// be funny: "Attempting to leave TV Tropes, failing", "Laughing at cat picture", "Bemused as to
	/// why the computer is taking so long...", etc.
	/// </summary>
	public class AIUser {
		public Computer OwnedComputer { get; set; }
		
	}
}
