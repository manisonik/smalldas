namespace SmallDAS
{
    partial class SerialPortConfigForm
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
            this._baudRateTextBox = new System.Windows.Forms.TextBox();
            this._baudRateLabel = new System.Windows.Forms.Label();
            this._parityLabel = new System.Windows.Forms.Label();
            this._parityTextBox = new System.Windows.Forms.TextBox();
            this._stopBitsLabel = new System.Windows.Forms.Label();
            this._stopBitsTextBox = new System.Windows.Forms.TextBox();
            this._dataBitsLabel = new System.Windows.Forms.Label();
            this._dataBitsTextBox = new System.Windows.Forms.TextBox();
            this._handShakeLabel = new System.Windows.Forms.Label();
            this._handShakeTextBox = new System.Windows.Forms.TextBox();
            this._rtsEnableCheckBox = new System.Windows.Forms.CheckBox();
            this._portLabel = new System.Windows.Forms.Label();
            this._acceptButton = new System.Windows.Forms.Button();
            this._cancelButton = new System.Windows.Forms.Button();
            this._portComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // _baudRateTextBox
            // 
            this._baudRateTextBox.Location = new System.Drawing.Point(84, 30);
            this._baudRateTextBox.Name = "_baudRateTextBox";
            this._baudRateTextBox.Size = new System.Drawing.Size(100, 20);
            this._baudRateTextBox.TabIndex = 0;
            this._baudRateTextBox.TextChanged += new System.EventHandler(this._baudRateTextBox_TextChanged);
            // 
            // _baudRateLabel
            // 
            this._baudRateLabel.AutoSize = true;
            this._baudRateLabel.Location = new System.Drawing.Point(12, 33);
            this._baudRateLabel.Name = "_baudRateLabel";
            this._baudRateLabel.Size = new System.Drawing.Size(56, 13);
            this._baudRateLabel.TabIndex = 1;
            this._baudRateLabel.Text = "Baud rate:";
            // 
            // _parityLabel
            // 
            this._parityLabel.AutoSize = true;
            this._parityLabel.Location = new System.Drawing.Point(12, 59);
            this._parityLabel.Name = "_parityLabel";
            this._parityLabel.Size = new System.Drawing.Size(36, 13);
            this._parityLabel.TabIndex = 3;
            this._parityLabel.Text = "Parity:";
            // 
            // _parityTextBox
            // 
            this._parityTextBox.Location = new System.Drawing.Point(84, 56);
            this._parityTextBox.Name = "_parityTextBox";
            this._parityTextBox.Size = new System.Drawing.Size(100, 20);
            this._parityTextBox.TabIndex = 2;
            this._parityTextBox.TextChanged += new System.EventHandler(this._parityTextBox_TextChanged);
            // 
            // _stopBitsLabel
            // 
            this._stopBitsLabel.AutoSize = true;
            this._stopBitsLabel.Location = new System.Drawing.Point(12, 85);
            this._stopBitsLabel.Name = "_stopBitsLabel";
            this._stopBitsLabel.Size = new System.Drawing.Size(51, 13);
            this._stopBitsLabel.TabIndex = 5;
            this._stopBitsLabel.Text = "Stop bits:";
            // 
            // _stopBitsTextBox
            // 
            this._stopBitsTextBox.Location = new System.Drawing.Point(84, 82);
            this._stopBitsTextBox.Name = "_stopBitsTextBox";
            this._stopBitsTextBox.Size = new System.Drawing.Size(100, 20);
            this._stopBitsTextBox.TabIndex = 4;
            this._stopBitsTextBox.TextChanged += new System.EventHandler(this._stopBitsTextBox_TextChanged);
            // 
            // _dataBitsLabel
            // 
            this._dataBitsLabel.AutoSize = true;
            this._dataBitsLabel.Location = new System.Drawing.Point(12, 111);
            this._dataBitsLabel.Name = "_dataBitsLabel";
            this._dataBitsLabel.Size = new System.Drawing.Size(52, 13);
            this._dataBitsLabel.TabIndex = 7;
            this._dataBitsLabel.Text = "Data bits:";
            // 
            // _dataBitsTextBox
            // 
            this._dataBitsTextBox.Location = new System.Drawing.Point(84, 108);
            this._dataBitsTextBox.Name = "_dataBitsTextBox";
            this._dataBitsTextBox.Size = new System.Drawing.Size(100, 20);
            this._dataBitsTextBox.TabIndex = 6;
            this._dataBitsTextBox.TextChanged += new System.EventHandler(this._dataBitsTextBox_TextChanged);
            // 
            // _handShakeLabel
            // 
            this._handShakeLabel.AutoSize = true;
            this._handShakeLabel.Location = new System.Drawing.Point(11, 137);
            this._handShakeLabel.Name = "_handShakeLabel";
            this._handShakeLabel.Size = new System.Drawing.Size(65, 13);
            this._handShakeLabel.TabIndex = 9;
            this._handShakeLabel.Text = "Handshake:";
            // 
            // _handShakeTextBox
            // 
            this._handShakeTextBox.Location = new System.Drawing.Point(84, 134);
            this._handShakeTextBox.Name = "_handShakeTextBox";
            this._handShakeTextBox.Size = new System.Drawing.Size(100, 20);
            this._handShakeTextBox.TabIndex = 8;
            this._handShakeTextBox.TextChanged += new System.EventHandler(this._handShakeTextBox_TextChanged);
            // 
            // _rtsEnableCheckBox
            // 
            this._rtsEnableCheckBox.AutoSize = true;
            this._rtsEnableCheckBox.Location = new System.Drawing.Point(205, 9);
            this._rtsEnableCheckBox.Name = "_rtsEnableCheckBox";
            this._rtsEnableCheckBox.Size = new System.Drawing.Size(78, 17);
            this._rtsEnableCheckBox.TabIndex = 10;
            this._rtsEnableCheckBox.Text = "Rts Enable";
            this._rtsEnableCheckBox.UseVisualStyleBackColor = true;
            this._rtsEnableCheckBox.CheckedChanged += new System.EventHandler(this._rtsEnableCheckBox_CheckedChanged);
            // 
            // _portLabel
            // 
            this._portLabel.AutoSize = true;
            this._portLabel.Location = new System.Drawing.Point(12, 9);
            this._portLabel.Name = "_portLabel";
            this._portLabel.Size = new System.Drawing.Size(29, 13);
            this._portLabel.TabIndex = 12;
            this._portLabel.Text = "Port:";
            // 
            // _acceptButton
            // 
            this._acceptButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._acceptButton.Location = new System.Drawing.Point(205, 106);
            this._acceptButton.Name = "_acceptButton";
            this._acceptButton.Size = new System.Drawing.Size(75, 23);
            this._acceptButton.TabIndex = 13;
            this._acceptButton.Text = "OK";
            this._acceptButton.UseVisualStyleBackColor = true;
            // 
            // _cancelButton
            // 
            this._cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._cancelButton.Location = new System.Drawing.Point(205, 131);
            this._cancelButton.Name = "_cancelButton";
            this._cancelButton.Size = new System.Drawing.Size(75, 23);
            this._cancelButton.TabIndex = 14;
            this._cancelButton.Text = "Cancel";
            this._cancelButton.UseVisualStyleBackColor = true;
            // 
            // _portComboBox
            // 
            this._portComboBox.FormattingEnabled = true;
            this._portComboBox.Location = new System.Drawing.Point(84, 5);
            this._portComboBox.Name = "_portComboBox";
            this._portComboBox.Size = new System.Drawing.Size(100, 21);
            this._portComboBox.TabIndex = 15;
            this._portComboBox.SelectedIndexChanged += new System.EventHandler(this._portComboBox_SelectedIndexChanged);
            // 
            // SerialPortConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 167);
            this.Controls.Add(this._portComboBox);
            this.Controls.Add(this._cancelButton);
            this.Controls.Add(this._acceptButton);
            this.Controls.Add(this._portLabel);
            this.Controls.Add(this._rtsEnableCheckBox);
            this.Controls.Add(this._handShakeLabel);
            this.Controls.Add(this._handShakeTextBox);
            this.Controls.Add(this._dataBitsLabel);
            this.Controls.Add(this._dataBitsTextBox);
            this.Controls.Add(this._stopBitsLabel);
            this.Controls.Add(this._stopBitsTextBox);
            this.Controls.Add(this._parityLabel);
            this.Controls.Add(this._parityTextBox);
            this.Controls.Add(this._baudRateLabel);
            this.Controls.Add(this._baudRateTextBox);
            this.Name = "SerialPortConfigForm";
            this.Text = "Serial Port Configuration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _baudRateTextBox;
        private System.Windows.Forms.Label _baudRateLabel;
        private System.Windows.Forms.Label _parityLabel;
        private System.Windows.Forms.TextBox _parityTextBox;
        private System.Windows.Forms.Label _stopBitsLabel;
        private System.Windows.Forms.TextBox _stopBitsTextBox;
        private System.Windows.Forms.Label _dataBitsLabel;
        private System.Windows.Forms.TextBox _dataBitsTextBox;
        private System.Windows.Forms.Label _handShakeLabel;
        private System.Windows.Forms.TextBox _handShakeTextBox;
        private System.Windows.Forms.CheckBox _rtsEnableCheckBox;
        private System.Windows.Forms.Label _portLabel;
        private System.Windows.Forms.Button _acceptButton;
        private System.Windows.Forms.Button _cancelButton;
        private System.Windows.Forms.ComboBox _portComboBox;
    }
}