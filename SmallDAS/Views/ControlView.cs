using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SmallDAS
{
    public partial class ControlView : UserControl
    {
        public class CommandExecutedEventArgs : EventArgs
        {
            public string Command { get; set; }
            public string Value { get; set; }
        }

        public event EventHandler<CommandExecutedEventArgs> CommandExecuted;

        public ControlView()
        {
            InitializeComponent();
        }

        private void ControlView_Load(object sender, EventArgs e)
        {
        }

        public void Add(string controlName)
        {
            Label label = new Label();
            label.Text = controlName;
            label.Dock = DockStyle.Left;

            TextBox textBox = new TextBox();
            textBox.Dock = DockStyle.Fill;

            Button button = new Button();
            button.Text = "Execute";
            button.Dock = DockStyle.Right;
            button.Click += delegate (object sender, EventArgs e)
            {
                CommandExecutedEventArgs args = new CommandExecutedEventArgs();
                args.Command = controlName;
                args.Value = textBox.Text;
                CommandExecuted(this, args);
            };

            Panel panel = new Panel();
            panel.Height = 20;
            panel.Dock = DockStyle.Top;
            panel.Controls.Add(textBox);
            panel.Controls.Add(label);
            panel.Controls.Add(button);

            this.Controls.Add(panel);
        }
    }
}
