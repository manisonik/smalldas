using SmallDAS.Core;
using System;
using System.Drawing;
using System.Runtime.Remoting.Channels;
using System.Windows.Forms;

namespace SmallDAS
{
    public partial class RawScpiDeviceForm : Form
    {
        private readonly TreeNode _parserNode;
        private readonly TreeNode _controlChannelNode;
        private Device _device;
        private DynamicTypeDescriptor _dtpChannel = new DynamicTypeDescriptor(typeof(Channel));
        private DynamicTypeDescriptor _dtpParser = new DynamicTypeDescriptor(typeof(Parser));
        private Channel _currentChannel;

        public RawScpiDeviceForm(Device device)
        {
            InitializeComponent();
            _device = device;
            _parserNode = treeView1.Nodes.Add("Parsers");
            _controlChannelNode = treeView1.Nodes.Add("Channels");
        }

        private void SCPIDeviceForm_Load(object sender, EventArgs e)
        {
            foreach(var channel in _device.Channels)
            {
                TreeNode channelNode = _controlChannelNode.Nodes.Add(channel.Name);
                channelNode.Tag = channel;
            }

            foreach (var parser in _device.Parsers)
            {
                TreeNode parserNode = _parserNode.Nodes.Add(parser.Name);
                parserNode.Tag = parser;

                foreach (var command in parser.Commands)
                {
                    TreeNode commandNode = parserNode.Nodes.Add(command.Name);
                    commandNode.Tag = command;
                }
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();

            if (e.Node.Tag is Parser)
            {
                Parser parser = (Parser)e.Node.Tag;

                ParserFragment parserFragment = new ParserFragment(parser);
                parserFragment.Dock = DockStyle.Fill;
                splitContainer1.Panel2.Controls.Add(parserFragment);

                /*PropertyGrid propertyGrid1 = new PropertyGrid();
                propertyGrid1.Dock = DockStyle.Fill;
                propertyGrid1.PropertySort = PropertySort.NoSort;
                propertyGrid1.CommandsVisibleIfAvailable = true;
                propertyGrid1.TabIndex = 1;
                propertyGrid1.Text = "Property Grid";

                splitContainer1.Panel2.Controls.Add(propertyGrid1);

                propertyGrid1.SelectedObject = _dtpParser.FromComponent(parser);*/
            }

            if (e.Node.Tag is Channel)
            {
                Channel channel = (Channel)e.Node.Tag;

                ChannelFragment channelFragment = new ChannelFragment(_device, channel);
                channelFragment.Dock = DockStyle.Fill;
                splitContainer1.Panel2.Controls.Add(channelFragment);

                /*PropertyGrid propertyGrid1 = new PropertyGrid();
                propertyGrid1.Dock = DockStyle.Fill;
                propertyGrid1.PropertySort = PropertySort.NoSort;
                propertyGrid1.CommandsVisibleIfAvailable = true;
                propertyGrid1.TabIndex = 1;
                propertyGrid1.Text = "Property Grid";
                propertyGrid1.PropertyValueChanged += PropertyValueChanged;

                splitContainer1.Panel2.Controls.Add(propertyGrid1);

                UpdateChannelType();

                // Update object
                propertyGrid1.SelectedObject = _dtpChannel.FromComponent(_currentChannel);*/
            }

            if (e.Node.Tag is Command)
            {
                Command command = (Command)e.Node.Tag;

                CommandFragment commandFragment = new CommandFragment(_device, command);
                commandFragment.Dock = DockStyle.Fill;
                splitContainer1.Panel2.Controls.Add(commandFragment);

            }
        }

        private void UpdateChannelType()
        {
            switch (_currentChannel.Type)
            {
                case ChannelType.Text:
                    {
                        var current = _dtpChannel.OriginalProperties["Text"];
                        _dtpChannel.RemoveProperty("Text");
                        _dtpChannel.RemoveProperty("Value");
                        var prop = new DynamicTypeDescriptor.DynamicProperty(_dtpChannel, current, _currentChannel);
                        _dtpChannel.AddProperty(prop);
                        //_dtpChannel.SwapProperty("Value", "Text");
                    }
                    break;
                case ChannelType.Number:
                    {
                        var current = _dtpChannel.OriginalProperties["Value"];
                        _dtpChannel.RemoveProperty("Text");
                        _dtpChannel.RemoveProperty("Value");
                        var prop = new DynamicTypeDescriptor.DynamicProperty(_dtpChannel, current, _currentChannel);
                        _dtpChannel.AddProperty(prop);
                        //_dtpChannel.SwapProperty("Text", "Value");
                    }
                    break;
            }
        }

        private void PropertyValueChanged(object sender, PropertyValueChangedEventArgs e)
        {
            PropertyGrid propertyGrid = sender as PropertyGrid;
            if (e.ChangedItem.Label == "Type")
            {
                UpdateChannelType();
                propertyGrid.SelectedObject = _dtpChannel.FromComponent(_currentChannel);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            TreeNode node = _parserNode.Nodes.Add("Parser1");

            Parser parser = new Parser();
            parser.Name = "Parser1";
            node.Tag = parser;

            _device.Parsers.Add(parser);
        }

        private void _channelToolStripButtion_Click(object sender, EventArgs e)
        {
            TreeNode node = _controlChannelNode.Nodes.Add("Channel1");

            Channel channel = new Channel();
            channel.Name = "Channel1";
            channel.Description = "Channel1";
            node.Tag = channel;

            _device.Channels.Add(channel);
        }

        private void _commandStripButton1_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode.Tag is Parser)
            {
                var parser = (Parser)treeView1.SelectedNode.Tag;
                
                var selectedNode = treeView1.SelectedNode;
                selectedNode.Nodes.Add("Command1");

                Command command = new Command();
                command.Name = "Command1";
                command.Format = "{0} {1} {2}";
                selectedNode.Tag = command;

                parser.Commands.Add(command);
            }
        }

        private void splitContainerPanel_Paint(object sender, PaintEventArgs e)
        {
            if (sender is Panel)
            {
                Panel panel = (Panel)sender;
                ControlPaint.DrawBorder(e.Graphics, panel.ClientRectangle, Color.DarkGray, ButtonBorderStyle.Solid);
            }
        }
    }
}
