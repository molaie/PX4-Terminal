namespace sha1_FP {
	partial class Form1 {
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.txtLog = new System.Windows.Forms.RichTextBox();
			this.btnConnect = new System.Windows.Forms.Button();
			this.cmbPorts = new System.Windows.Forms.ComboBox();
			this.btnClearLog = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtLog
			// 
			this.txtLog.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.txtLog.Location = new System.Drawing.Point(0, 41);
			this.txtLog.Name = "txtLog";
			this.txtLog.Size = new System.Drawing.Size(784, 337);
			this.txtLog.TabIndex = 0;
			this.txtLog.Text = "";
			// 
			// btnConnect
			// 
			this.btnConnect.Location = new System.Drawing.Point(249, 12);
			this.btnConnect.Name = "btnConnect";
			this.btnConnect.Size = new System.Drawing.Size(75, 23);
			this.btnConnect.TabIndex = 1;
			this.btnConnect.Text = "Connect";
			this.btnConnect.UseVisualStyleBackColor = true;
			this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
			// 
			// cmbPorts
			// 
			this.cmbPorts.FormattingEnabled = true;
			this.cmbPorts.Location = new System.Drawing.Point(22, 12);
			this.cmbPorts.Name = "cmbPorts";
			this.cmbPorts.Size = new System.Drawing.Size(201, 21);
			this.cmbPorts.TabIndex = 2;
			// 
			// btnClearLog
			// 
			this.btnClearLog.Location = new System.Drawing.Point(331, 12);
			this.btnClearLog.Name = "btnClearLog";
			this.btnClearLog.Size = new System.Drawing.Size(75, 23);
			this.btnClearLog.TabIndex = 3;
			this.btnClearLog.Text = "Clear Log";
			this.btnClearLog.UseVisualStyleBackColor = true;
			this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 378);
			this.Controls.Add(this.btnClearLog);
			this.Controls.Add(this.cmbPorts);
			this.Controls.Add(this.btnConnect);
			this.Controls.Add(this.txtLog);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.Text = "PX4Terminal";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.RichTextBox txtLog;
		private System.Windows.Forms.Button btnConnect;
		private System.Windows.Forms.ComboBox cmbPorts;
		private System.Windows.Forms.Button btnClearLog;
	}
}

