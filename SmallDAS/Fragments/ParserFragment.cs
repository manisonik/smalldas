using Antlr.Runtime;
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
    public partial class ParserFragment : UserControl
    {
        public Parser _parser;

        public ParserFragment(Parser parser)
        {
            _parser = parser;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ParserFragment_Load(object sender, EventArgs e)
        {
            _terminatorTextBox.Text = _parser.Terminator;
            _delimiterTextBox.Text = _parser.Delimiter;
            _etxTextBox.Text = _parser.ETX;
            _stxTextBox.Text = _parser.STX;
        }

        private void _stxTextBox_TextChanged(object sender, EventArgs e)
        {
            _parser.STX = _stxTextBox.Text;
        }

        private void _etxTextBox_TextChanged(object sender, EventArgs e)
        {
            _parser.ETX = _etxTextBox.Text;
        }

        private void _delimiterTextBox_TextChanged(object sender, EventArgs e)
        {
            _parser.Delimiter = _delimiterTextBox.Text;
        }

        private void _terminatorTextBox_TextChanged(object sender, EventArgs e)
        {
            _parser.Terminator = _terminatorTextBox.Text;
        }
    }
}
