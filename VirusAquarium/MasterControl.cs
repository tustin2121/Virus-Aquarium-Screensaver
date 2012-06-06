using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VirusAquarium {
	public class MasterControl {
		public void Startup() {
		}

		public void Shutdown() {
			//TODO
			Application.Exit();
		}

		public void HandleKeyInput(KeyEventArgs e) {
			//TODO if in keyboard input mode, don't shutdown, otherwise do, for all keys
			if (e.KeyCode == Keys.Escape) {
				Shutdown();
			}
		}
	}
}
