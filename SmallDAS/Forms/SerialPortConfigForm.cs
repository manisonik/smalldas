using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace SmallDAS
{
    public partial class SerialPortConfigForm : Form
    {
        private Device _device;

        public SerialPortConfigForm(Device device)
        {
            _device = device;
            InitializeComponent();
            EnumeratePorts();
        }

        private void EnumeratePorts()
        {
            // Get a list of serial port names.
            string[] ports = SerialPort.GetPortNames();

            foreach (string port in ports) {
                _portComboBox.Items.Add(port);
            }
        }

        private void _rtsEnableCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _device.SetParameter("RtsEnable", _rtsEnableCheckBox.Checked);
        }

        private void _baudRateTextBox_TextChanged(object sender, EventArgs e)
        {
            int value;
            if (int.TryParse(_baudRateTextBox.Text, out value))
            {
                _device.SetParameter("BaudRate", value);
            }
        }

        private void _parityTextBox_TextChanged(object sender, EventArgs e)
        {
            int value;
            if (int.TryParse(_parityTextBox.Text, out value))
            {
                _device.SetParameter("Parity", value);
            }
        }

        private void _stopBitsTextBox_TextChanged(object sender, EventArgs e)
        {
            int value;
            if (int.TryParse(_stopBitsTextBox.Text, out value))
            {
                _device.SetParameter("StopBits", value);
            }
        }

        private void _dataBitsTextBox_TextChanged(object sender, EventArgs e)
        {
            int value;
            if (int.TryParse(_dataBitsTextBox.Text, out value))
            {
                _device.SetParameter("DataBits", value);
            }
        }

        private void _handShakeTextBox_TextChanged(object sender, EventArgs e)
        {
            int value;
            if (int.TryParse(_handShakeTextBox.Text, out value))
            {
                _device.SetParameter("Handshake", value);
            }
        }

        private void _portComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _device.SetParameter("PortName", _portComboBox.Text);
        }
    }
}
