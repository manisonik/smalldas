namespace SmallDAS
{
    partial class DeviceView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Use = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DeviceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Communication = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Protocol = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Timeout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Config = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Use,
            this.DeviceName,
            this.Communication,
            this.Protocol,
            this.Timeout,
            this.Config,
            this.Column1});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(823, 338);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_UserAddedRow);
            this.dataGridView1.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_UserDeletedRow);
            // 
            // Use
            // 
            this.Use.FalseValue = "false";
            this.Use.Frozen = true;
            this.Use.HeaderText = "Use";
            this.Use.Name = "Use";
            this.Use.TrueValue = "true";
            // 
            // DeviceName
            // 
            this.DeviceName.Frozen = true;
            this.DeviceName.HeaderText = "Device Name";
            this.DeviceName.Name = "DeviceName";
            // 
            // Communication
            // 
            this.Communication.Frozen = true;
            this.Communication.HeaderText = "Communication";
            this.Communication.Items.AddRange(new object[] {
            "TCP",
            "UDP",
            "Serial",
            "Visa",
            "SerialPort"});
            this.Communication.Name = "Communication";
            this.Communication.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Communication.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Protocol
            // 
            this.Protocol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Protocol.Frozen = true;
            this.Protocol.HeaderText = "Protocol";
            this.Protocol.Items.AddRange(new object[] {
            "AK",
            "RawScpi"});
            this.Protocol.Name = "Protocol";
            // 
            // Timeout
            // 
            this.Timeout.Frozen = true;
            this.Timeout.HeaderText = "Timeout";
            this.Timeout.Name = "Timeout";
            // 
            // Config
            // 
            this.Config.HeaderText = "Config";
            this.Config.Name = "Config";
            this.Config.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Channel Setup";
            this.Column1.Name = "Column1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(823, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            // 
            // DeviceView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 362);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DeviceView";
            this.Text = "Devices";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DeviceView_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Use;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeviceName;
        private System.Windows.Forms.DataGridViewComboBoxColumn Communication;
        private System.Windows.Forms.DataGridViewComboBoxColumn Protocol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Timeout;
        private System.Windows.Forms.DataGridViewImageColumn Config;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
    }
}