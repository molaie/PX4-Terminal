namespace SHA1FP.UserControls {
	partial class Terminal {
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
			this.txtTerminal = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// txtTerminal
			// 
			this.txtTerminal.BackColor = System.Drawing.Color.Black;
			this.txtTerminal.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtTerminal.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTerminal.ForeColor = System.Drawing.Color.Lime;
			this.txtTerminal.Location = new System.Drawing.Point(0, 0);
			this.txtTerminal.Name = "txtTerminal";
			this.txtTerminal.Size = new System.Drawing.Size(356, 150);
			this.txtTerminal.TabIndex = 0;
			this.txtTerminal.Text = "PX4 Terminal\nCopyright 2015 Ahmad molaie.\n";
			this.txtTerminal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTerminal_KeyDown);
			this.txtTerminal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTerminal_KeyPress);
			// 
			// Terminal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.txtTerminal);
			this.Name = "Terminal";
			this.Size = new System.Drawing.Size(356, 150);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.RichTextBox txtTerminal;
	}
}
