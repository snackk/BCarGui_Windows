using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace BCarGui_Windows{

    public partial class RemoteControl : Form {
        private enum _state { FORWARD, REVERSE, TURN_LEFT, TURN_RIGHT, BREAK };

        private SerialPort _btPort;

        public RemoteControl(SerialPort btPort) {
            _btPort = btPort;
            InitializeComponent();
        }

        private void sendBt(_state message) {
            try {
                _btPort.WriteLine(message.ToString());
            }
            catch (Exception) {
                MessageBox.Show("Could not send data.");
            }
        }

        private void ForwardButton_Click(object sender, EventArgs e) {
            sendBt(_state.FORWARD);
        }

        private void RightButton_Click(object sender, EventArgs e) {
            sendBt(_state.TURN_RIGHT);
        }

        private void ReverseButton_Click(object sender, EventArgs e) {
            sendBt(_state.REVERSE);
        }

        private void LeftButton_Click(object sender, EventArgs e) {
            sendBt(_state.TURN_LEFT);
        }
    }
}
