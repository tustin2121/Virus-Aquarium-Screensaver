using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VirusAquarium.Simulation {
	/// <summary>
	/// Represents anything that computers can do activities on. 
	/// These can and probably will carry viruses.
	/// </summary>
	public abstract class ActivitySubject {
		public List<Virus> VirusesOnBoard { get; set; }

		public void Open() { } //open email, webpage, file, etc
		public void Interact() { } //install, execute, view, click links, etc
		public void Close() { } //close email, page, kill program, etc
	}

	///////////////////////////////////////////////////////////////////////////
	#region Email

	public class Email : ActivitySubject {
		public string Subject { get; set; }
		public string Sender { get; set; }
	}

	public class SpamEmail : Email {

	}
	public class ChainLetter : Email {
	}

	#endregion
	///////////////////////////////////////////////////////////////////////////
	#region Web

	public enum WebpageType {
		Blank = 0, 
		News, Game, Company, Advert, Video, Download, Pron, Wiki //beware the TV Tropes
	}
	public class Webpage : ActivitySubject {
		public string Address { get; set; }
		public string Subject { get; set; }
		public bool IsPron { get; set; }
	}

	#endregion
	///////////////////////////////////////////////////////////////////////////
	#region Download

	public abstract class DownloadItem : ActivitySubject {
		public abstract bool IsInstallable { get; }
		public bool IsInstalled { get; set; }

		
	}

	public class Toolbar : DownloadItem {
		public override bool IsInstallable { get { return true; } }
	}
	public class AntiVirus : DownloadItem {
		public override bool IsInstallable { get { return true; } }
		public bool IsLegitamate { get; set; }
	}
	public class Pictures : DownloadItem {
		public override bool IsInstallable { get { return false; } }
	}
	public class WordDocument : DownloadItem {
		public override bool IsInstallable { get { return false; } }
		//macros can be viruses, right?
	}
	public class Game : DownloadItem {
		public override bool IsInstallable { get { return true; } }
		//Shock the Monkey... O_o
	}

	#endregion
}
