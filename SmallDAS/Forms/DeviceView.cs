using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace SmallDAS
{
    public partial class DeviceView : Form
    {
        private Configuration _config;

        public DeviceView(Configuration config)
        {
            InitializeComponent();
            this._config = config;

            PopulateDevices();
        }

        private void PopulateDevices()
        {
            foreach (Device dev in _config.Devices)
            {
                int i = dataGridView1.Rows.Add(dev.Enabled, dev.Name, dev.Protocol, dev.Timeout);
                dataGridView1.Rows[i].Tag = dev;
            }
        }

        public void Save()
        {
            XmlSerializer xs = new XmlSerializer(typeof(Configuration));
            using (StreamWriter fs = System.IO.File.CreateText("SmallDAS.Configuration.xml"))
            {
                xs.Serialize(fs, _config);
            }
        }

        private void DeviceView_FormClosing(object sender, FormClosingEventArgs e)
        {
            Save();
        }

        private void ShowChannelView(Device device)
        {
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (_config == null)
                return;

            switch (e.ColumnIndex) {
                case 0:
                    _config.Devices[e.RowIndex].Enabled = bool.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                    break;
                case 1:
                    _config.Devices[e.RowIndex].Name = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                    break;
                case 2:
                    _config.Devices[e.RowIndex].Protocol = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                    break;
                case 3:
                    _config.Devices[e.RowIndex].Timeout = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                    break;
                default:
                    return;
            }
        }

        private void dataGridView1_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            _config.Devices.Add(new Device());
        }

        private void dataGridView1_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            _config.Devices.Remove((Device)e.Row.Tag);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 5:
                    ShowChannelView((Device)dataGridView1.Rows[e.RowIndex].Tag);
                    break;
                default:
                    return;
            }
        }
    }
}
