namespace VirusAquarium
{
    partial class ScreensaverForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.commandBox = new System.Windows.Forms.TextBox();
			this.scrollbackPane = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// commandBox
			// 
			this.commandBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.commandBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.commandBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.commandBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.commandBox.ForeColor = System.Drawing.Color.White;
			this.commandBox.Location = new System.Drawing.Point(12, 448);
			this.commandBox.Name = "commandBox";
			this.commandBox.Size = new System.Drawing.Size(616, 22);
			this.commandBox.TabIndex = 0;
			this.commandBox.Text = "Command Entry";
			// 
			// scrollbackPane
			// 
			this.scrollbackPane.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.scrollbackPane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.scrollbackPane.Location = new System.Drawing.Point(12, 12);
			this.scrollbackPane.Name = "scrollbackPane";
			this.scrollbackPane.Size = new System.Drawing.Size(616, 434);
			this.scrollbackPane.TabIndex = 1;
			// 
			// ScreensaverForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(640, 480);
			this.Controls.Add(this.scrollbackPane);
			this.Controls.Add(this.commandBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "ScreensaverForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.OnLoad);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
			this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnMouseClick);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

		private System.Windows.Forms.TextBox commandBox;
		private System.Windows.Forms.Panel scrollbackPane;
    }
}

