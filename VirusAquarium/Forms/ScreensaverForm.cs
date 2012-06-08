using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VirusAquarium.Forms;

namespace VirusAquarium
{
    public partial class ScreensaverForm : Form
    {
		private const int SIG_MOUSE_MOVE = 5;

		private Point lastMouseLoc = Point.Empty;
		private MasterControl mcp; //master control program

		public List<ComputerIcon> IconList { get; set; }
		public bool IsPrimary { get; set; }

		public ScreensaverForm(MasterControl masterControlProgram, Rectangle bounds) {
			InitializeComponent();

			this.mcp = masterControlProgram;
			this.Bounds = bounds;
			this.IconList = new List<ComputerIcon>();
		}

		public void UpdateView() {
			IconList.ForEach((x) => x.UpdateOperatingStatus());
		}

		////////////////////////////////////////Events////////////////////////////////////////////

		private void OnLoad(object sender, EventArgs e) {
			Cursor.Hide();
			this.TopMost = true;

			this.commandBox.Visible = false;
			this.scrollbackPane.Visible = false;
		}

		private void OnMouseMove(object sender, MouseEventArgs e) {
			if (!lastMouseLoc.IsEmpty) {
				if (Math.Abs(lastMouseLoc.X - e.X) > SIG_MOUSE_MOVE || Math.Abs(lastMouseLoc.Y - e.Y) > SIG_MOUSE_MOVE) {
					mcp.Shutdown();
				}
			}

			lastMouseLoc = e.Location;
		}

		private void OnMouseClick(object sender, MouseEventArgs e) {
			mcp.Shutdown();
		}

		private void OnKeyDown(object sender, KeyEventArgs e) {
			mcp.HandleKeyInput(e);
		}
		

    }
}
