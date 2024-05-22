using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SmallDAS
{
    public partial class ChannelFragment : UserControl
    {
        Channel _channel;
        Device _device;

        public ChannelFragment(Device device, Channel channel)
        {
            InitializeComponent();
            _channel = channel;
            _device = device;

            // Add parsers by name
            foreach (var parser in _device.Parsers)
            {
                _parserTypeComboBox.Items.Add(parser.Name);
            }

            _nameTextBox.Text = _channel.Name;
            _descriptionTextBox.Text = _channel.Description;
            _parserTypeComboBox.SelectedIndex = _channel.Parser;
            _channelTypeComboBox.SelectedIndex = (int)_channel.Type;
        }

        private void _nameTextBox_TextChanged(object sender, EventArgs e)
        {
            _channel.Name = _nameTextBox.Text;
        }

        private void _descriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            _channel.Description = _descriptionTextBox.Text;
        }

        private void _parserTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _channel.Parser = _parserTypeComboBox.SelectedIndex;
        }

        private void _channelTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _channel.Type = (ChannelType)_channelTypeComboBox.SelectedIndex;
        }
    }
}
