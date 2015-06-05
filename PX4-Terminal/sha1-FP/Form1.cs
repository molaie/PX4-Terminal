using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sha1_FP {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}

		private void btnConnect_Click(object sender, EventArgs e) {

		}

		private void btnClearLog_Click(object sender, EventArgs e) {
			txtLog.Clear();
		}












		public new static string[] GetPortNames() {
				string[] ports = null;

				try {
					ports = System.IO.Ports.SerialPort.GetPortNames()
					.Select(p => p.TrimEnd())
					
					.ToArray();
				} catch { }

				return ports.ToArray();
			}
		}


	}
}
