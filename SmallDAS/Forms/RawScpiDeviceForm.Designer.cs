namespace SmallDAS
{
    partial class RawScpiDeviceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RawScpiDeviceForm));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.addButton1 = new System.Windows.Forms.ToolStripButton();
            this._channelToolStripButtion = new System.Windows.Forms.ToolStripButton();
            this._commandStripButton1 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.ForeColor = System.Drawing.Color.White;
            this.treeView1.LineColor = System.Drawing.Color.Gray;
            this.treeView1.Location = new System.Drawing.Point(0, 25);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(271, 477);
            this.treeView1.TabIndex = 1;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip1);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainerPanel_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainerPanel_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(818, 502);
            this.splitContainer1.SplitterDistance = 271;
            this.splitContainer1.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addButton1,
            this._channelToolStripButtion,
            this._commandStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(271, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // addButton1
            // 
            this.addButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.addButton1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.addButton1.Image = ((System.Drawing.Image)(resources.GetObject("addButton1.Image")));
            this.addButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addButton1.Name = "addButton1";
            this.addButton1.Size = new System.Drawing.Size(33, 22);
            this.addButton1.Text = "Add";
            this.addButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // _channelToolStripButtion
            // 
            this._channelToolStripButtion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this._channelToolStripButtion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this._channelToolStripButtion.Image = ((System.Drawing.Image)(resources.GetObject("_channelToolStripButtion.Image")));
            this._channelToolStripButtion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._channelToolStripButtion.Name = "_channelToolStripButtion";
            this._channelToolStripButtion.Size = new System.Drawing.Size(80, 22);
            this._channelToolStripButtion.Text = "Add Channel";
            this._channelToolStripButtion.Click += new System.EventHandler(this._channelToolStripButtion_Click);
            // 
            // _commandStripButton1
            // 
            this._commandStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this._commandStripButton1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this._commandStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("_commandStripButton1.Image")));
            this._commandStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._commandStripButton1.Name = "_commandStripButton1";
            this._commandStripButton1.Size = new System.Drawing.Size(93, 22);
            this._commandStripButton1.Text = "Add Command";
            this._commandStripButton1.Click += new System.EventHandler(this._commandStripButton1_Click);
            // 
            // RawScpiDeviceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 502);
            this.Controls.Add(this.splitContainer1);
            this.Name = "RawScpiDeviceForm";
            this.Text = "SCPIDeviceForm";
            this.Load += new System.EventHandler(this.SCPIDeviceForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton addButton1;
        private System.Windows.Forms.ToolStripButton _channelToolStripButtion;
        private System.Windows.Forms.ToolStripButton _commandStripButton1;
    }
}