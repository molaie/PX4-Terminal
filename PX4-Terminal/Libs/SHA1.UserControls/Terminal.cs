using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHA1.UserControls {
	public partial class Terminal : UserControl {


		List<string> cmdHistory = new List<string>();
		int history = 0;
		//save last position of caret, so user can go up & down in history
		int inputStartPos = 0;

		public Terminal() {
			InitializeComponent();
		}

		private void txtTerminal_KeyPress(object sender, KeyPressEventArgs e) {

		}

		private void txtTerminal_KeyDown(object sender, KeyEventArgs e) {
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

	}
}
