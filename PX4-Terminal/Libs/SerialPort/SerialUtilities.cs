using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace SHA1FP.SerialUtilities {
	public class SerialUtilities {

		public static IList<string> LoadPort() {
			return SerialPort.GetPortNames().ToList();
			
		}


	}
}
