using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VirusAquarium.Forms {
	public partial class ComputerIcon : UserControl {
		public ComputerIcon() {
			InitializeComponent();
			this.BackColor = Color.Transparent;
		}

		protected override void OnPaintBackground(PaintEventArgs e) {
			base.OnPaintBackground(e);

			var p = new Pen(Color.Red, 4);
			e.Graphics.DrawRectangle(p, this.desktopBox.Bounds);

			e.Graphics.DrawString("Test Virus", this.Font, Brushes.LightGreen, this.desktopBox.Left, this.desktopBox.Bottom);
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
