using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VirusAquarium.Simulation;

namespace VirusAquarium.Forms {
	public partial class ComputerIcon : UserControl {
		public Computer Model { get; set; }
		public AIUser User { get; set; }

		public ComputerIcon() {
			InitializeComponent();
			this.BackColor = Color.Transparent;
		}

		public void UpdateOperatingStatus() {
			lblName.Text = Model.Name + " ["+Model.CurrentActivity.Name+"]";
			lblCPU.Text = "CPU: " + Model.CurrentLoad;
			lblRAM.Text = "RAM: " + Model.CurrentRamUsage;
			lblRuntime.Text = "RT: " + Model.CurrentActivity.Runtime;
		}

		protected override void OnPaintBackground(PaintEventArgs e) {
			base.OnPaintBackground(e);

			var p = new Pen(Color.Red, 4);
			e.Graphics.DrawRectangle(p, this.desktopBox.Bounds);

			//Draw Virus List here:
			for (int i = 0; i < 10; i++) {
				e.Graphics.DrawString("Virus.Entry.Funky32 [Passive]", this.Font, Brushes.Lime, 
					this.desktopBox.Left-4, this.desktopBox.Bottom + this.Font.GetHeight()*i + 4);
			}
		}

		private Point screenCenter;
		public Point ScreenCenter { get {
			if (screenCenter == null)
				screenCenter = new Point(
					this.desktopBox.Left + this.desktopBox.Width/2,
					this.desktopBox.Top + this.desktopBox.Height/2
				);
			return screenCenter;
		} }
	}
}
