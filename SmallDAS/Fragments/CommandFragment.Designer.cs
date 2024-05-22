namespace SmallDAS
{
    partial class CommandFragment
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this._nameTextBox = new System.Windows.Forms.TextBox();
            this._nameLabel = new System.Windows.Forms.Label();
            this._formatTextBox = new System.Windows.Forms.TextBox();
            this._labelFormat = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this._channelDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._channelDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // _nameTextBox
            // 
            this._nameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._nameTextBox.ForeColor = System.Drawing.Color.White;
            this._nameTextBox.Location = new System.Drawing.Point(64, 32);
            this._nameTextBox.Name = "_nameTextBox";
            this._nameTextBox.Size = new System.Drawing.Size(141, 20);
            this._nameTextBox.TabIndex = 0;
            this._nameTextBox.TextChanged += new System.EventHandler(this._nameTextBox_TextChanged);
            // 
            // _nameLabel
            // 
            this._nameLabel.AutoSize = true;
            this._nameLabel.ForeColor = System.Drawing.Color.White;
            this._nameLabel.Location = new System.Drawing.Point(19, 32);
            this._nameLabel.Name = "_nameLabel";
            this._nameLabel.Size = new System.Drawing.Size(38, 13);
            this._nameLabel.TabIndex = 1;
            this._nameLabel.Text = "Name:";
            // 
            // _formatTextBox
            // 
            this._formatTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._formatTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._formatTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._formatTextBox.ForeColor = System.Drawing.Color.White;
            this._formatTextBox.Location = new System.Drawing.Point(64, 58);
            this._formatTextBox.Name = "_formatTextBox";
            this._formatTextBox.Size = new System.Drawing.Size(141, 20);
            this._formatTextBox.TabIndex = 2;
            this._formatTextBox.TextChanged += new System.EventHandler(this._formatTextBox_TextChanged);
            // 
            // _labelFormat
            // 
            this._labelFormat.AutoSize = true;
            this._labelFormat.ForeColor = System.Drawing.Color.White;
            this._labelFormat.Location = new System.Drawing.Point(19, 60);
            this._labelFormat.Name = "_labelFormat";
            this._labelFormat.Size = new System.Drawing.Size(42, 13);
            this._labelFormat.TabIndex = 3;
            this._labelFormat.Text = "Format:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.splitContainer1.Panel1.Controls.Add(this._nameTextBox);
            this.splitContainer1.Panel1.Controls.Add(this._labelFormat);
            this.splitContainer1.Panel1.Controls.Add(this._nameLabel);
            this.splitContainer1.Panel1.Controls.Add(this._formatTextBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this._channelDataGridView);
            this.splitContainer1.Size = new System.Drawing.Size(515, 337);
            this.splitContainer1.SplitterDistance = 160;
            this.splitContainer1.TabIndex = 4;
            // 
            // _channelDataGridView
            // 
            this._channelDataGridView.AllowUserToAddRows = false;
            this._channelDataGridView.AllowUserToDeleteRows = false;
            this._channelDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this._channelDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._channelDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._channelDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this._channelDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._channelDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this._channelDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._channelDataGridView.EnableHeadersVisualStyles = false;
            this._channelDataGridView.Location = new System.Drawing.Point(0, 0);
            this._channelDataGridView.Name = "_channelDataGridView";
            this._channelDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._channelDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this._channelDataGridView.RowHeadersVisible = false;
            this._channelDataGridView.Size = new System.Drawing.Size(515, 173);
            this._channelDataGridView.TabIndex = 0;
            this._channelDataGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this._channelDataGridView_CellValidating);
            this._channelDataGridView.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this._channelDataGridView_EditingControlShowing);
            // 
            // CommandFragment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.splitContainer1);
            this.Name = "CommandFragment";
            this.Size = new System.Drawing.Size(515, 337);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._channelDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox _nameTextBox;
        private System.Windows.Forms.Label _nameLabel;
        private System.Windows.Forms.TextBox _formatTextBox;
        private System.Windows.Forms.Label _labelFormat;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView _channelDataGridView;
    }
}
