using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHA1FP {
	//this copied from this page of stackoverflow
	//http://stackoverflow.com/questions/3874134/cleaning-up-code-littered-with-invokerequired
	public static class ControlHelpers {
		public static void InvokeIfRequired(this ISynchronizeInvoke control, Action<ISynchronizeInvoke> action, object[] args) {
			if (control.InvokeRequired) {
				control.Invoke(new Action(() => action(control)), args);
			} else {
				action(control);
			}
		}
	}
}
