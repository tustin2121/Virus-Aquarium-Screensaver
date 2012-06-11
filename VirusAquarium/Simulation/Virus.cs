using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using VirusAquarium.Resources;
using VirusAquarium.Simulation.Activities;
using VirusAquarium.Simulation.Events;

namespace VirusAquarium.Simulation {
	public enum VirusStatus {
		Passive = 0, Spreading, DeliveringPayload, RunningBotnet, CallingHome,
		Inactive = -1, Frozen = -2, 
	}

	public class Virus : RunnableProgram {
		public VirusStatus Status { get; set; }
		public string StatusName { get {
			string key = "Virus_Status_" + Enum.GetName(typeof(VirusStatus), this.Status);
			return BehaviorBundle.ResourceManager.GetString(key, BehaviorBundle.Culture) ?? BehaviorBundle.Virus_Status_Default;
			/*
			switch (this.Status) {
				case VirusStatus.Passive: return BehaviorBundle.Virus_Status_Passive;
				case VirusStatus.Spreading: return BehaviorBundle.Virus_Status_Spreading;
				case VirusStatus.DeliveringPayload: return BehaviorBundle.Virus_Status_DeliveringPayload;
				case VirusStatus.RunningBotnet: return BehaviorBundle.Virus_Status_RunningBotnet;
				case VirusStatus.CallingHome: return BehaviorBundle.Virus_Status_CallingHome;
				case VirusStatus.Frozen: return BehaviorBundle.Virus_Status_Frozen;
				default: return BehaviorBundle.Virus_Status_Default; //"Unknown"
			}*/
		} }

		public override bool IsRunning { get { return Status >= VirusStatus.Passive; } }

		public Virus() {
			this.Name = "Virus.Unknown";
			this.Status = VirusStatus.Inactive;
		}

		public Virus(Virus clone) : base(clone) {
			this.Status = VirusStatus.Inactive;
		}

		//Behavior
	}
}
