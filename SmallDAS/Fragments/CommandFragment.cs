using OxyPlot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SmallDAS
{
    public partial class CommandFragment : UserControl
    {
        private Command _command;
        private Device _device;
        private DataGridViewComboBoxColumn _cb;
        private DataGridViewComboBoxColumn _ctype;

        public CommandFragment(Device device, Command command)
        {
            InitializeComponent();
            _command = command;
            _device = device;
            _nameTextBox.Text = command.Name;
            _formatTextBox.Text = command.Format;

            _cb = new DataGridViewComboBoxColumn();
            _cb.FlatStyle = FlatStyle.Flat;
            _cb.HeaderText = "Channel";
            _cb.Width = 200;
            foreach (var chan in device.Channels)
            {
                _cb.Items.Add(chan.Name);
            }

            _ctype = new DataGridViewComboBoxColumn();
            _ctype.HeaderText = "Type";
            _ctype.FlatStyle = FlatStyle.Flat;
            _ctype.Items.Add("Integer");
            _ctype.Items.Add("Float");
            _ctype.Items.Add("Double");
            _ctype.Items.Add("String");
            

            _channelDataGridView.Columns.Add(_cb);
            _channelDataGridView.Columns.Add(_ctype);
            _channelDataGridView.Columns.Add("Format", "Format");
            _channelDataGridView.Columns.Add("Preview", "Preview");

            int numOfRows = Regex.Matches(command.Format, @"\{[0-9]+\}").Count;
            for (int i = 0; i < numOfRows; i++) {
                _channelDataGridView.Rows.Add();
            }
        }

        private void _nameTextBox_TextChanged(object sender, EventArgs e)
        {
            _command.Name = _nameTextBox.Text;
        }

        private void _formatTextBox_TextChanged(object sender, EventArgs e)
        {
            _command.Format = _formatTextBox.Text;
        }

        private void _channelDataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            ComboBox c = e.Control as ComboBox;
            if (c != null) {
                c.DropDownStyle = ComboBoxStyle.DropDown;
            }
        }

        private void _channelDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == _cb.Index)
            {
                string editingValue = e.FormattedValue as string;
                if (!_cb.Items.Contains(editingValue) && !string.IsNullOrEmpty(editingValue))
                {
                    _cb.Items.Add(editingValue);
                    _channelDataGridView[e.ColumnIndex, e.RowIndex].Value = editingValue;
                }
            }
        }
    }
}
