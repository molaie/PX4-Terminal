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

		private SerialPortManager se = new SerialPortManager();

		public Form1() {
			InitializeComponent();
			FillPortsCombo();
		}

		private void btnConnect_Click(object sender, EventArgs e) {
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
			if (this.txtLog.InvokeRequired) {
				Invoke(new Action(() => txtLog.Text += log + Environment.NewLine));
			} else {
				if (log == null) {
					log = "<NULL>";
				}
				if (log.Trim() == string.Empty) {
					log = "<None>";
				}
				txtLog.Text += log + Environment.NewLine;
			}
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



	}
}
