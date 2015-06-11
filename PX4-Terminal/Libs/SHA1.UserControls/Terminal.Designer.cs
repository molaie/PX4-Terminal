namespace SHA1.UserControls {
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
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.greenOnBlackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.whiteOnBlackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.blackOnWhiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.customToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(104, 26);
			// 
			// colorToolStripMenuItem
			// 
			this.colorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.greenOnBlackToolStripMenuItem,
            this.whiteOnBlackToolStripMenuItem,
            this.blackOnWhiteToolStripMenuItem,
            this.customToolStripMenuItem});
			this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
			this.colorToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
			this.colorToolStripMenuItem.Text = "Color";
			// 
			// greenOnBlackToolStripMenuItem
			// 
			this.greenOnBlackToolStripMenuItem.Checked = true;
			this.greenOnBlackToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.greenOnBlackToolStripMenuItem.Name = "greenOnBlackToolStripMenuItem";
			this.greenOnBlackToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
			this.greenOnBlackToolStripMenuItem.Text = "&Green on Black";
			// 
			// whiteOnBlackToolStripMenuItem
			// 
			this.whiteOnBlackToolStripMenuItem.Name = "whiteOnBlackToolStripMenuItem";
			this.whiteOnBlackToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
			this.whiteOnBlackToolStripMenuItem.Text = "&White on Black";
			// 
			// blackOnWhiteToolStripMenuItem
			// 
			this.blackOnWhiteToolStripMenuItem.Name = "blackOnWhiteToolStripMenuItem";
			this.blackOnWhiteToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
			this.blackOnWhiteToolStripMenuItem.Text = "&Black on White";
			// 
			// customToolStripMenuItem
			// 
			this.customToolStripMenuItem.Name = "customToolStripMenuItem";
			this.customToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
			this.customToolStripMenuItem.Text = "&Custom";
			// 
			// richTextBox1
			// 
			this.richTextBox1.BackColor = System.Drawing.Color.Black;
			this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.richTextBox1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.richTextBox1.ForeColor = System.Drawing.Color.Lime;
			this.richTextBox1.Location = new System.Drawing.Point(0, 0);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(597, 376);
			this.richTextBox1.TabIndex = 1;
			this.richTextBox1.Text = "adsasda";
			// 
			// Terminal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.richTextBox1);
			this.Name = "Terminal";
			this.Size = new System.Drawing.Size(597, 376);
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem greenOnBlackToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem whiteOnBlackToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem blackOnWhiteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem customToolStripMenuItem;
		private System.Windows.Forms.RichTextBox richTextBox1;
	}
}
