using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows.Forms;

/*TODO Handshake, send Environment.MachineName*/
/**/
namespace BCarGui_Windows {

    public partial class BCarGui : Form {

        public BCarGui() {
            InitializeComponent();
            coms_box.Items.Add("");
            coms_box.Items.Add("COM1");
            coms_box.Items.Add("COM2");
            coms_box.Items.Add("COM3");
            coms_box.Items.Add("COM4");
            coms_box.Items.Add("COM5");
        }

        private void coms_box_SelectedIndexChanged(object sender, EventArgs e) {
        }

        private void Connect_Click(object sender, EventArgs e) {
            SerialPort sp = null;
            try {
                sp = initBt(coms_box.SelectedItem.ToString());
            } catch (NullReferenceException) {
                MessageBox.Show("COM port cannot be empty.");
            }

            if (sp != null) {
                RemoteControl rc = new RemoteControl(sp);
                rc.Show();
            }
        }

        private SerialPort initBt(String port) {
            SerialPort _btPort = null;
            try {
                _btPort = new SerialPort();
                _btPort.BaudRate = 9600;
                _btPort.PortName = port;
                _btPort.Open();
            }
            catch (Exception) {
                MessageBox.Show("Error while trying to communicate with port: " + port);
                _btPort = null;
            }
            return _btPort;
        }
    }
}
