using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SHA1FP.SerialUtilities;

namespace SHA1FP.UserControls {
	public partial class Terminal : UserControl {


		List<string> cmdHistory = new List<string>();

		private List<string> TerminalCommands = new List<string>() {
			"cls"
			, "......"

		};


		int history = 0;
		//save last position of caret, so user can go up & down in history
		int inputStartPos = 0;
		//Which comport?
		public string SelectedComPort { get; set; }
		private bool isConnected;

		private SerialPortManager serialManager = new SerialPortManager();

		public Terminal() {
			InitializeComponent();
			txtTerminal.SelectionStart = txtTerminal.Text.Length;
		}

		public new bool Enabled {
			get { return txtTerminal.Enabled; }
			set { txtTerminal.Enabled = value; }
		}


		public void ClearLog() {
			txtTerminal.Text = "";
			serialManager.WriteLine("");
		}

		public IList<string> GetExistingPorts() {
			return SerialUtilities.SerialUtilities.LoadPorts();
		}


		private void InsertLog(string log) {
			if (string.IsNullOrWhiteSpace(log)) {
				log = "NOP" + Environment.NewLine;
			}
			log = log.TrimEnd('\r');
			log = log.Replace("\0", "");
			log = log.Replace((char)0x1b + "[K", "");

			txtTerminal.InvokeIfRequired(c => {
				txtTerminal.AppendText(log);
				txtTerminal.SelectionStart = txtTerminal.Text.Length;
				inputStartPos = txtTerminal.SelectionStart;
				txtTerminal.ScrollToCaret();
				txtTerminal.Focus();
			}, null);
		}


		public void Connect() {
			if (string.IsNullOrWhiteSpace(SelectedComPort)) {
				InsertLog("There is no comport to connect");
			}

			var connectionResult = serialManager.InitSerial(SelectedComPort, handler: sePort_DataReceived);
			InsertLog(connectionResult);
			if ("Connected" == connectionResult) {
				//we need at least one enter to see Nuttx
				serialManager.WriteLine("");
				isConnected = true;
				serialManager.WriteLine("?");
			}
		}


		private void sePort_DataReceived(object sender, SerialDataReceivedEventArgs e) {
			string result = serialManager.ReadExisting();
			InsertLog(result);
		}



		private async void txtTerminal_KeyPress(object sender, KeyPressEventArgs e) {
			if (e.KeyChar != '\r') {
				return;
			}
			if (!isConnected) {
				return;
			}
			try {
				string cmd = "";

				cmd = txtTerminal.Text.Substring(inputStartPos, txtTerminal.Text.Length - inputStartPos - 1).ToLower();
				txtTerminal.Select(inputStartPos, txtTerminal.Text.Length - inputStartPos);
				txtTerminal.SelectedText = "";
				if (cmd.Length > 0 && (cmdHistory.Count == 0 || cmdHistory.Last() != cmd)) {

					cmdHistory.Add(cmd);
					history = cmdHistory.Count;
				}
				if (cmd == "cls") {
					ClearLog();
				} else if (cmd == "reboot") {
					serialManager.WriteLine("reboot");
					serialManager.close();
					await RebootAndWait();
					Connect();
				} else {
					serialManager.WriteLine(cmd);
				}
			} catch {
				//CustomMessageBox.Show(Strings.ErrorCommunicating, Strings.ERROR);
			}
		}



		private async Task RebootAndWait() {
			await Task.Delay(12000);
		}


		private void txtTerminal_KeyDown(object sender, KeyEventArgs e) {
			if (!isConnected) {
				e.Handled = true;
				return;
			}
			txtTerminal.SelectionStart = txtTerminal.Text.Length;
			switch (e.KeyData) {
				case Keys.Up:
					if (history > 0) {
						txtTerminal.Select(inputStartPos, txtTerminal.Text.Length - inputStartPos);
						txtTerminal.SelectedText = "";
						txtTerminal.AppendText(cmdHistory[--history]);
					}
					e.Handled = true;
					break;
				case Keys.Down:
					if (history < cmdHistory.Count - 1) {
						txtTerminal.Select(inputStartPos, txtTerminal.Text.Length - inputStartPos);
						txtTerminal.SelectedText = "";
						txtTerminal.AppendText(cmdHistory[++history]);
					}
					e.Handled = true;
					break;
				case Keys.Left:
				case Keys.Back:
					if (txtTerminal.SelectionStart <= inputStartPos)
						e.Handled = true;
					break;

				//case Keys.Right:
				//    break;
			}
		}

		private void mnu_theme_Click(object sender, EventArgs e) {
			var mnuItem = (sender as ToolStripMenuItem);
			mnuTheme.DropDownItems.Cast<ToolStripMenuItem>().Where(x => x.Checked).ToList().ForEach(x => x.Checked = false);
			mnuItem.Checked = true;

			var mnutext =  mnuItem.Text;

			var mnucolor = mnutext.Substring(0, mnutext.IndexOf("on")).ToLower();
			if (mnucolor.Contains("green")) {
				txtTerminal.BackColor = Color.Black;
				txtTerminal.ForeColor = Color.Green;
			} else if (mnucolor.Contains("black")) {
				txtTerminal.BackColor = Color.White;
				txtTerminal.ForeColor = Color.Black;
			} else if (mnucolor.Contains("white")) {
				txtTerminal.BackColor = Color.Black;
				txtTerminal.ForeColor = Color.White;
			}

		}

		
	}
}
