namespace VirusAquarium.Forms {
	partial class ComputerIcon {
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.desktopBox = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.desktopBox)).BeginInit();
			this.SuspendLayout();
			// 
			// desktopBox
			// 
			this.desktopBox.BackColor = System.Drawing.Color.Black;
			this.desktopBox.Location = new System.Drawing.Point(32, 32);
			this.desktopBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.desktopBox.Name = "desktopBox";
			this.desktopBox.Size = new System.Drawing.Size(128, 96);
			this.desktopBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.desktopBox.TabIndex = 0;
			this.desktopBox.TabStop = false;
			// 
			// ComputerIcon
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.Black;
			this.Controls.Add(this.desktopBox);
			this.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "ComputerIcon";
			this.Size = new System.Drawing.Size(256, 276);
			((System.ComponentModel.ISupportInitialize)(this.desktopBox)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox desktopBox;
	}
}
