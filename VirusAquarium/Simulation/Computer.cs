using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using VirusAquarium.Simulation.Activities;
using VirusAquarium.Simulation.Events;

namespace VirusAquarium.Simulation {
	public class Computer {
		public string Name { get; set; }
		public Point Location { get; set; }

		public List<Virus> Infections { get; set; }
		public Network Network { get; set; }
		public List<Virus> StartupPrograms { get; set; }

		public List<Virus> RunningPrograms { get; set; }
		public uint Uptime { get; set; }
		public float CurrentLoad { get; set; }
		public float CurrentRamUsage { get; set; }
		public float CurrentCycleSpeed { get; set; }

		public ComputerActivity CurrentActivity { get; set; }
		public float BaseSpeed { get; set; } //amount of runtime to add each cycle, modified by CPU usage, RAM

		//Fun Stats
		public int NumEmotesInstalled { get; set; }
		public int NumToolbarsInstalled { get; set; }

		public Computer() {
			this.Infections = new List<Virus>();
			this.RunningPrograms = new List<Virus>();
			this.StartupPrograms = new List<Virus>();
			this.Network = new Network();

			this.BaseSpeed = 1.0f;
		}

		/////////////////////////////////////////////////////////////////////////////////

		protected void DisbatchEvent(Event e) {
			foreach (Virus v in RunningPrograms) {
				bool b = v.HandleEvent(v, e);
				if (b) break;
			}
		}

		public void BeginNewActivity(ComputerActivity act) {
			if (CurrentActivity != null)
				CurrentActivity.Terminate();
			CurrentActivity = act;
			act.Computer = this;
			act.Runtime = 0;
			act.Begin();

			ActivityStartEvent ase = new ActivityStartEvent();
			ase.Activity = CurrentActivity;
			ase.Computer = this;
			this.DisbatchEvent(ase);
		}

		public void Reboot() { //also used to boot
			this.RunningPrograms.Clear();
			this.Uptime = 0;

			this.BeginNewActivity(new BootingActivity());
		}


		public void CPUCycle() {
			float load = 0, ram = 0;
			foreach (Virus v in RunningPrograms) {
				load += v.CPUUsage(v);
				ram += v.RAMUsage(v);
			}

			//if the load exceeds 1.0, the cycles start getting slower
			float cycleSpeed = (load > 1.0) ? (this.BaseSpeed / load) : (this.BaseSpeed);
			//as soon as the ram load goes over 0.8, the speed drops drastically
			cycleSpeed = (ram > 0.8f) ? (cycleSpeed / (ram - 0.8f + 1.0f)) : cycleSpeed;

			this.CurrentLoad = load;
			this.CurrentRamUsage = ram;
			this.CurrentCycleSpeed = cycleSpeed;

			this.Uptime++;
			this.CurrentActivity.Runtime += cycleSpeed;
			ComputerActivity c = this.CurrentActivity.RunLoop();
			if (c != null) this.BeginNewActivity(c);
		}

		
	}


/*#region Activities
/*	public enum OnScreen {
		Off = 0,
		Booting, StartingUp, ShuttingDown, LoggingIn,
		Idling, Processing, Frozen,
		CheckingEmail, OpeningAttachments, ClickingLinks, ReplyingToScam, ReadingEmail, 
		ForwardingChainLetter, //can forward to other computers in the network
		SurfingWeb, LoadingWebpage, ClickingAdverts, InstallingEmotes, InstallingToolbar,
		SharingFiles, InstallingVirusChecker,
	}*
	public delegate void ComputerActivity(Computer comp, ref float timeLeft);

	public static class ComputerActivities {
		public static void Off(Computer comp, ref float timeLeft) {}
		public static void Booting(Computer comp, ref float timeLeft) { 

		}
	}
#endregion */
}
