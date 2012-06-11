using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using VirusAquarium.Simulation.Activities;
using VirusAquarium.Simulation.Events;

namespace VirusAquarium.Simulation {
	public enum ComputerState {
		Off, Booting, Idling, Unresponsive, Crashed
	}

	public class Computer {
		public string Name { get; set; }
		public Point Location { get; set; }

		public List<Virus> Infections { get; set; }
		public Network Network { get; set; }
		public List<RunnableProgram> StartupPrograms { get; set; }

		public List<RunnableProgram> RunningPrograms { get; set; }
		public uint Uptime { get; set; }
		public float CurrentLoad { get; set; }
		public float CurrentRamUsage { get; set; }
		public float CurrentCycleSpeed { get; set; }

		public ComputerActivity CurrentActivity { get; set; }
		public float BaseSpeed { get; set; } //amount of runtime to add each cycle, modified by CPU usage, RAM
		public ComputerState CurrentState { get { 

		} }

		//Fun Stats
		public int NumEmotesInstalled { get; set; }
		public int NumToolbarsInstalled { get; set; }

		public Computer() {
			this.Infections = new List<Virus>();
			this.RunningPrograms = new List<RunnableProgram>();
			this.StartupPrograms = new List<RunnableProgram>();
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
			float load = 0, ram = 0.2f; //base load and ram, from OS
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

	public class RunnableProgram {
		public string Name { get; set; }
		public Computer Host { get; set; }

		public RunnableProgram() { }
		public RunnableProgram(RunnableProgram clone) {
			this.Name = clone.Name;

			this.CPUCycle = clone.CPUCycle;
			this.CPUUsage = clone.CPUUsage;
			this.RAMUsage = clone.RAMUsage;
			this.Execute = clone.Execute;
			this.HandleEvent = clone.HandleEvent;
		}

		public virtual bool IsRunning { get; protected set; }

		public CPUUsageDel CPUUsage { get; set; }
		public RAMUsageDel RAMUsage { get; set; }
		public ExecuteDel Execute { get; set; }
		public HandleEventDel HandleEvent { get; set; }
		public CPUCycleDel CPUCycle { get; set; }
	}

	public delegate float CPUUsageDel(RunnableProgram self);
	public delegate float RAMUsageDel(RunnableProgram self);
	public delegate void ExecuteDel(RunnableProgram self);
	public delegate bool HandleEventDel(RunnableProgram self, Event e); //return true = stop propigation
	public delegate void CPUCycleDel(RunnableProgram self);

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
