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
			this.lblHealth = new System.Windows.Forms.Label();
			this.lblCPU = new System.Windows.Forms.Label();
			this.lblRAM = new System.Windows.Forms.Label();
			this.lblStatus = new System.Windows.Forms.Label();
			this.lblName = new System.Windows.Forms.Label();
			this.lblRuntime = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.desktopBox)).BeginInit();
			this.SuspendLayout();
			// 
			// desktopBox
			// 
			this.desktopBox.BackColor = System.Drawing.Color.Black;
			this.desktopBox.Location = new System.Drawing.Point(8, 62);
			this.desktopBox.Margin = new System.Windows.Forms.Padding(4);
			this.desktopBox.Name = "desktopBox";
			this.desktopBox.Size = new System.Drawing.Size(128, 96);
			this.desktopBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.desktopBox.TabIndex = 0;
			this.desktopBox.TabStop = false;
			// 
			// lblHealth
			// 
			this.lblHealth.AutoSize = true;
			this.lblHealth.BackColor = System.Drawing.Color.Transparent;
			this.lblHealth.ForeColor = System.Drawing.Color.Lime;
			this.lblHealth.Location = new System.Drawing.Point(142, 57);
			this.lblHealth.Name = "lblHealth";
			this.lblHealth.Size = new System.Drawing.Size(56, 15);
			this.lblHealth.TabIndex = 1;
			this.lblHealth.Text = "Healthy";
			// 
			// lblCPU
			// 
			this.lblCPU.AutoSize = true;
			this.lblCPU.BackColor = System.Drawing.Color.Transparent;
			this.lblCPU.ForeColor = System.Drawing.Color.White;
			this.lblCPU.Location = new System.Drawing.Point(143, 73);
			this.lblCPU.Name = "lblCPU";
			this.lblCPU.Size = new System.Drawing.Size(63, 15);
			this.lblCPU.TabIndex = 2;
			this.lblCPU.Text = "CPU: 1.0";
			// 
			// lblRAM
			// 
			this.lblRAM.AutoSize = true;
			this.lblRAM.BackColor = System.Drawing.Color.Transparent;
			this.lblRAM.ForeColor = System.Drawing.Color.White;
			this.lblRAM.Location = new System.Drawing.Point(143, 89);
			this.lblRAM.Name = "lblRAM";
			this.lblRAM.Size = new System.Drawing.Size(63, 15);
			this.lblRAM.TabIndex = 3;
			this.lblRAM.Text = "RAM: 1.0";
			// 
			// lblStatus
			// 
			this.lblStatus.BackColor = System.Drawing.Color.Transparent;
			this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblStatus.ForeColor = System.Drawing.Color.Turquoise;
			this.lblStatus.Location = new System.Drawing.Point(5, 27);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(279, 31);
			this.lblStatus.TabIndex = 4;
			this.lblStatus.Text = "AI Status Update, talking about stuff, and other stuff, and some other stuff";
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.BackColor = System.Drawing.Color.Transparent;
			this.lblName.ForeColor = System.Drawing.Color.White;
			this.lblName.Location = new System.Drawing.Point(5, 11);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(63, 15);
			this.lblName.TabIndex = 5;
			this.lblName.Text = "CompName";
			// 
			// lblRuntime
			// 
			this.lblRuntime.AutoSize = true;
			this.lblRuntime.BackColor = System.Drawing.Color.Transparent;
			this.lblRuntime.ForeColor = System.Drawing.Color.White;
			this.lblRuntime.Location = new System.Drawing.Point(143, 104);
			this.lblRuntime.Name = "lblRuntime";
			this.lblRuntime.Size = new System.Drawing.Size(28, 15);
			this.lblRuntime.TabIndex = 6;
			this.lblRuntime.Text = "run";
			// 
			// ComputerIcon
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.Black;
			this.Controls.Add(this.lblRuntime);
			this.Controls.Add(this.lblName);
			this.Controls.Add(this.lblStatus);
			this.Controls.Add(this.lblRAM);
			this.Controls.Add(this.lblCPU);
			this.Controls.Add(this.lblHealth);
			this.Controls.Add(this.desktopBox);
			this.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "ComputerIcon";
			this.Size = new System.Drawing.Size(287, 371);
			((System.ComponentModel.ISupportInitialize)(this.desktopBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox desktopBox;
		private System.Windows.Forms.Label lblHealth;
		private System.Windows.Forms.Label lblCPU;
		private System.Windows.Forms.Label lblRAM;
		private System.Windows.Forms.Label lblStatus;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Label lblRuntime;
	}
}
