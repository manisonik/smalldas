namespace SmallDAS
{
    partial class ChannelFragment
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
            this._nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this._descriptionTypeLabel = new System.Windows.Forms.Label();
            this._descriptionTextBox = new System.Windows.Forms.TextBox();
            this._channelTypeLabel = new System.Windows.Forms.Label();
            this._parserLabel = new System.Windows.Forms.Label();
            this._parserTypeComboBox = new System.Windows.Forms.ComboBox();
            this._channelTypeComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // _nameTextBox
            // 
            this._nameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._nameTextBox.ForeColor = System.Drawing.Color.White;
            this._nameTextBox.Location = new System.Drawing.Point(109, 26);
            this._nameTextBox.Name = "_nameTextBox";
            this._nameTextBox.Size = new System.Drawing.Size(198, 20);
            this._nameTextBox.TabIndex = 0;
            this._nameTextBox.TextChanged += new System.EventHandler(this._nameTextBox_TextChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.nameLabel.Location = new System.Drawing.Point(15, 29);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name:";
            // 
            // _descriptionTypeLabel
            // 
            this._descriptionTypeLabel.AutoSize = true;
            this._descriptionTypeLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this._descriptionTypeLabel.Location = new System.Drawing.Point(15, 55);
            this._descriptionTypeLabel.Name = "_descriptionTypeLabel";
            this._descriptionTypeLabel.Size = new System.Drawing.Size(63, 13);
            this._descriptionTypeLabel.TabIndex = 3;
            this._descriptionTypeLabel.Text = "Description:";
            // 
            // _descriptionTextBox
            // 
            this._descriptionTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._descriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._descriptionTextBox.ForeColor = System.Drawing.Color.White;
            this._descriptionTextBox.Location = new System.Drawing.Point(109, 52);
            this._descriptionTextBox.Name = "_descriptionTextBox";
            this._descriptionTextBox.Size = new System.Drawing.Size(198, 20);
            this._descriptionTextBox.TabIndex = 2;
            this._descriptionTextBox.TextChanged += new System.EventHandler(this._descriptionTextBox_TextChanged);
            // 
            // _channelTypeLabel
            // 
            this._channelTypeLabel.AutoSize = true;
            this._channelTypeLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this._channelTypeLabel.Location = new System.Drawing.Point(15, 81);
            this._channelTypeLabel.Name = "_channelTypeLabel";
            this._channelTypeLabel.Size = new System.Drawing.Size(76, 13);
            this._channelTypeLabel.TabIndex = 5;
            this._channelTypeLabel.Text = "Channel Type:";
            // 
            // _parserLabel
            // 
            this._parserLabel.AutoSize = true;
            this._parserLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this._parserLabel.Location = new System.Drawing.Point(15, 107);
            this._parserLabel.Name = "_parserLabel";
            this._parserLabel.Size = new System.Drawing.Size(40, 13);
            this._parserLabel.TabIndex = 7;
            this._parserLabel.Text = "Parser:";
            // 
            // _parserTypeComboBox
            // 
            this._parserTypeComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._parserTypeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._parserTypeComboBox.ForeColor = System.Drawing.Color.White;
            this._parserTypeComboBox.FormattingEnabled = true;
            this._parserTypeComboBox.Location = new System.Drawing.Point(109, 104);
            this._parserTypeComboBox.Name = "_parserTypeComboBox";
            this._parserTypeComboBox.Size = new System.Drawing.Size(198, 21);
            this._parserTypeComboBox.TabIndex = 8;
            this._parserTypeComboBox.SelectedIndexChanged += new System.EventHandler(this._parserTypeComboBox_SelectedIndexChanged);
            // 
            // _channelTypeComboBox
            // 
            this._channelTypeComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._channelTypeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._channelTypeComboBox.ForeColor = System.Drawing.Color.White;
            this._channelTypeComboBox.FormattingEnabled = true;
            this._channelTypeComboBox.Items.AddRange(new object[] {
            "Number",
            "Text"});
            this._channelTypeComboBox.Location = new System.Drawing.Point(109, 77);
            this._channelTypeComboBox.Name = "_channelTypeComboBox";
            this._channelTypeComboBox.Size = new System.Drawing.Size(198, 21);
            this._channelTypeComboBox.TabIndex = 9;
            this._channelTypeComboBox.SelectedIndexChanged += new System.EventHandler(this._channelTypeComboBox_SelectedIndexChanged);
            // 
            // ChannelFragment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.Controls.Add(this._channelTypeComboBox);
            this.Controls.Add(this._parserTypeComboBox);
            this.Controls.Add(this._parserLabel);
            this.Controls.Add(this._channelTypeLabel);
            this.Controls.Add(this._descriptionTypeLabel);
            this.Controls.Add(this._descriptionTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this._nameTextBox);
            this.Name = "ChannelFragment";
            this.Size = new System.Drawing.Size(446, 391);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label _descriptionTypeLabel;
        private System.Windows.Forms.TextBox _descriptionTextBox;
        private System.Windows.Forms.Label _channelTypeLabel;
        private System.Windows.Forms.Label _parserLabel;
        private System.Windows.Forms.ComboBox _parserTypeComboBox;
        private System.Windows.Forms.ComboBox _channelTypeComboBox;
    }
}
