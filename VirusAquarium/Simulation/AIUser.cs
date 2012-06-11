using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VirusAquarium.Simulation.AIModes;

namespace VirusAquarium.Simulation {

	public enum CompAssesement {
		Healthy, Slow, BootLoop, 
	}
	public enum AIMode {
		BootMachine, CheckEmail, 
		SurfWeb_News, SurfWeb_Pron, SurfWeb_Emotes, SurfWeb_MySpace, SurfWeb_Wiki, SurfWeb_LOL,
		CheckTwitter, DownloadAndInstall,
	}

	/// <summary>
	/// Represents the stupid user AI that are using the computer. They will show their status updates
	/// (that is, what they are doing currently) up on top of the computer screen. Their statuses will
	/// be funny: "Attempting to leave TV Tropes, failing", "Laughing at cat picture", "Bemused as to
	/// why the computer is taking so long...", etc.
	/// </summary>
	public class AIUser {
		public Computer OwnedComputer { get; set; }
		public string StatusLine { get; set; }
		public AIStateMode CurrentMode { get; set; }

		public AIUser() {
			
		}

		public void NoteWaitingTime(bool finished) {
			//TODO determine if machine is "slow"
		}

		public void StepSimulation() {

		}
	}
}
