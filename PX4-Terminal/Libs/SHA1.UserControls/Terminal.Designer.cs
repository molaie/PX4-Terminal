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
			this.components = new System.ComponentModel.Container();
			this.txtTerminal = new System.Windows.Forms.RichTextBox();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.mnuTheme = new System.Windows.Forms.ToolStripMenuItem();
			this.mnu_green = new System.Windows.Forms.ToolStripMenuItem();
			this.mnu_White = new System.Windows.Forms.ToolStripMenuItem();
			this.mnu_Black = new System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtTerminal
			// 
			this.txtTerminal.BackColor = System.Drawing.Color.Black;
			this.txtTerminal.ContextMenuStrip = this.contextMenuStrip1;
			this.txtTerminal.DetectUrls = false;
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
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTheme});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(112, 26);
			// 
			// mnuTheme
			// 
			this.mnuTheme.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_green,
            this.mnu_White,
            this.mnu_Black});
			this.mnuTheme.Name = "mnuTheme";
			this.mnuTheme.Size = new System.Drawing.Size(152, 22);
			this.mnuTheme.Text = "Theme";
			// 
			// mnu_green
			// 
			this.mnu_green.Checked = true;
			this.mnu_green.CheckOnClick = true;
			this.mnu_green.CheckState = System.Windows.Forms.CheckState.Checked;
			this.mnu_green.Name = "mnu_green";
			this.mnu_green.Size = new System.Drawing.Size(153, 22);
			this.mnu_green.Text = "&Green on black";
			this.mnu_green.Click += new System.EventHandler(this.mnu_theme_Click);
			// 
			// mnu_White
			// 
			this.mnu_White.Name = "mnu_White";
			this.mnu_White.Size = new System.Drawing.Size(153, 22);
			this.mnu_White.Text = "&White on black";
			this.mnu_White.Click += new System.EventHandler(this.mnu_theme_Click);
			// 
			// mnu_Black
			// 
			this.mnu_Black.Name = "mnu_Black";
			this.mnu_Black.Size = new System.Drawing.Size(153, 22);
			this.mnu_Black.Text = "&Black on White";
			this.mnu_Black.Click += new System.EventHandler(this.mnu_theme_Click);
			// 
			// Terminal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.txtTerminal);
			this.Name = "Terminal";
			this.Size = new System.Drawing.Size(356, 150);
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.RichTextBox txtTerminal;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem mnuTheme;
		private System.Windows.Forms.ToolStripMenuItem mnu_green;
		private System.Windows.Forms.ToolStripMenuItem mnu_White;
		private System.Windows.Forms.ToolStripMenuItem mnu_Black;
	}
}
