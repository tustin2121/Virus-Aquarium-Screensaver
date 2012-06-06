using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace VirusAquarium {
	public partial class PreviewForm : Form {
		[DllImport("user32.dll")]
		static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

		[DllImport("user32.dll")]
		static extern int SetWindowLong(IntPtr hWnd, int nIndex, IntPtr dwNewLong);

		[DllImport("user32.dll", SetLastError = true)]
		static extern int GetWindowLong(IntPtr hWnd, int nIndex);

		[DllImport("user32.dll")]
		static extern bool GetClientRect(IntPtr hWnd, out Rectangle lpRect);


		public PreviewForm(IntPtr PreviewWndHandle) {
			InitializeComponent();

			// Set the preview window as the parent of this window
			SetParent(this.Handle, PreviewWndHandle);

			// Make this a child window so it will close when the parent dialog closes
			// GWL_STYLE = -16, WS_CHILD = 0x40000000
			SetWindowLong(this.Handle, -16, new IntPtr(GetWindowLong(this.Handle, -16) | 0x40000000));

			// Place our window inside the parent
			Rectangle ParentRect;
			GetClientRect(PreviewWndHandle, out ParentRect);
			Size = ParentRect.Size;
			Location = new Point(0, 0);

		}
	}
}
