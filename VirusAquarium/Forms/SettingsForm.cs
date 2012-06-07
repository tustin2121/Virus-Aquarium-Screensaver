using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace VirusAquarium {
	public partial class SettingsForm : Form {

		public SettingsForm() {
			InitializeComponent();
			//TODO: Load settings
		}

		private void SaveStringToRegKey(string key, string value) {
			RegistryKey rk = Registry.CurrentUser.CreateSubKey("SOFTWARE\\VirusAquariumScreensaver");
			rk.SetValue(key, value);
		}

		private string LoadStringFromRegKey(string key, string defaultValue) {
			RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\VirusAquariumScreensaver");
			return (string)rk.GetValue(key, defaultValue);
		}
	}
}
