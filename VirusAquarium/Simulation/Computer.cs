using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace VirusAquarium.Simulation {
	public enum ComputerActivity {
		Off = 0,
		StartingUp, ShutingDown, LoggingIn,
		Idling, Processing, Frozen,
		CheckingEmail, OpeningAttachments, ClickingLinks, ReplyingToScam, ReadingEmail, 
		ForwardingChainLetter, //can forward to other computers in the network
		SurfingWeb, LoadingWebpage, ClickingAdverts, InstallingEmotes, InstallingToolbar,
		SharingFiles, InstallingVirusChecker,
		ExaminingPron, LaughingAtPicture,
	}

	/// <summary>
	/// Represents the stupid user AI that are using the computer. They will show their status updates
	/// (that is, what they are doing currently) up on top of the computer screen. Their statuses will
	/// be funny: "Attempting to leave TV Tropes, failing", "Laughing at cat picture", "Bemused as to
	/// why the computer is taking so long...", etc.
	/// </summary>
	public class AIUser {
	}

	public class Computer {
		public Point Location { get; set; }
		public List<Virus> Infections { get; set; }

		//Fun Stats
		public int NumEmotesInstalled { get; set; }
		public int NumToolbarsInstalled { get; set; }
		
	}
}
