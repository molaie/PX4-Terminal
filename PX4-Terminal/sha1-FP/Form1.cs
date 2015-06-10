using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SHA1FP.SerialUtilities;

namespace sha1_FP {
	public partial class Form1 : Form {


		List<string> cmdHistory = new List<string>();
		int history = 0;
		//save last position of caret, so user can go up & down in commands history
		int inputStartPos = 0;


		private SerialPortManager se = new SerialPortManager();

		public Form1() {
			InitializeComponent();
			FillPortsCombo();
		}

		private void btnConnect_Click(object sender, EventArgs e) {
			if (cmbPorts.Items.Count == 0) {
				InsertLog("There is no comport to connect");
			}
			InsertLog(se.InitSerial(cmbPorts.SelectedItem.ToString(), handler: sePort_DataReceived));
			se.WriteLine("");
		}

		private void btnClearLog_Click(object sender, EventArgs e) {
			txtLog.Clear();
		}

		public void FillPortsCombo() {
			cmbPorts.DataSource = SerialUtilities.LoadPorts();
		}


		private void InsertLog(string log) {
			if (log == null) {
				log = "<NULL>";
			}
			if (log.Trim() == string.Empty) {
				log = "<None>";
			}

			log = log.TrimEnd('\r');
			log = log.Replace("\0", "");
			log = log.Replace((char)0x1b + "[K", "");
			txtLog.Text += log + Environment.NewLine;
			txtLog.SelectionStart = txtLog.Text.Length;
			inputStartPos = txtLog.SelectionStart;

			txtLog.InvokeIfRequired(c => txtLog.Text = log, null);
		}


		private void sePort_DataReceived(object sender, SerialDataReceivedEventArgs e) {
			string result = se.ReadExisting();





			InsertLog(result);
		}


		private void textBox1_KeyUp(object sender, KeyEventArgs e) {
			if (e.KeyCode == Keys.Enter) {

				var command = txtCommand.Text.Trim();
				//sePort.DiscardInBuffer();
				//sePort.DiscardOutBuffer();
				//command = command.Replace("<ENTER>", "\r");
				//command = command.Replace("<CTRL-Z>", "\u001a");
				se.WriteLine(command);
			}
		}

		private void txtLog_KeyDown(object sender, KeyEventArgs e) {
			txtLog.SelectionStart = txtLog.Text.Length;
			switch (e.KeyData) {
				case Keys.Up:
					if (history > 0) {
						txtLog.Select(inputStartPos, txtLog.Text.Length - inputStartPos);
						txtLog.SelectedText = "";
						txtLog.AppendText(cmdHistory[--history]);
					}
					e.Handled = true;
					break;
				case Keys.Down:
					if (history < cmdHistory.Count - 1) {
						txtLog.Select(inputStartPos, txtLog.Text.Length - inputStartPos);
						txtLog.SelectedText = "";
						txtLog.AppendText(cmdHistory[++history]);
					}
					e.Handled = true;
					break;
				case Keys.Left:
				case Keys.Back:
					if (txtLog.SelectionStart <= inputStartPos)
						e.Handled = true;
					break;

				//case Keys.Right:
				//    break;
			}
		}



	}
}
