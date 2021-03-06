﻿using System;
using System.Windows.Forms;

namespace sha1_FP {
	public partial class Form1 : Form {


		string selectedComPort = "";

		public Form1() {
			InitializeComponent();
			FillPortsCombo();
		}

		public void FillPortsCombo() {
			var coms = terminal1.GetExistingPorts();

			foreach (var item in coms) {
				ToolStripMenuItem newComMenu = new ToolStripMenuItem();
				newComMenu.Text = item;
				newComMenu.Click += newComMenu_Click;
				mnu_newConsole.DropDownItems.Add(newComMenu);
			}
			if (null != coms && coms.Count > 0) {
				thereIsNoComportToConnectToolStripMenuItem.Visible = false;
			}
		}

		void newComMenu_Click(object sender, EventArgs e) {
			var selectedCom = sender as ToolStripMenuItem;
			if (null == selectedCom) {
				return;
			}
			selectedComPort = selectedCom.Text;
			terminal1.SelectedComPort = selectedComPort;
			terminal1.Connect();
			terminal1.Enabled = true;
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
			Application.Exit();
		}

		private void clearLogToolStripMenuItem_Click(object sender, EventArgs e) {
			terminal1.ClearLog();
		}

		private void mnu_about_Click(object sender, EventArgs e) {
			frmAbout f = new frmAbout();
			f.ShowDialog();
		}



	}
}
