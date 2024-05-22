namespace SmallDAS
{
    partial class ParserFragment
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
            this._stxTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._etxTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this._terminatorTextBox = new System.Windows.Forms.TextBox();
            this._delimiterTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this._enableETXCheckBox = new System.Windows.Forms.CheckBox();
            this._enableSTXCheckBox = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _stxTextBox
            // 
            this._stxTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._stxTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._stxTextBox.ForeColor = System.Drawing.Color.White;
            this._stxTextBox.Location = new System.Drawing.Point(85, 12);
            this._stxTextBox.Name = "_stxTextBox";
            this._stxTextBox.Size = new System.Drawing.Size(100, 20);
            this._stxTextBox.TabIndex = 0;
            this._stxTextBox.TextChanged += new System.EventHandler(this._stxTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(11, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Start of text:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(11, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "End of text:";
            // 
            // _etxTextBox
            // 
            this._etxTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._etxTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._etxTextBox.ForeColor = System.Drawing.Color.White;
            this._etxTextBox.Location = new System.Drawing.Point(85, 38);
            this._etxTextBox.Name = "_etxTextBox";
            this._etxTextBox.Size = new System.Drawing.Size(100, 20);
            this._etxTextBox.TabIndex = 2;
            this._etxTextBox.TextChanged += new System.EventHandler(this._etxTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(11, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Terminator:";
            // 
            // _terminatorTextBox
            // 
            this._terminatorTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._terminatorTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._terminatorTextBox.ForeColor = System.Drawing.Color.White;
            this._terminatorTextBox.Location = new System.Drawing.Point(85, 90);
            this._terminatorTextBox.Name = "_terminatorTextBox";
            this._terminatorTextBox.Size = new System.Drawing.Size(100, 20);
            this._terminatorTextBox.TabIndex = 4;
            this._terminatorTextBox.TextChanged += new System.EventHandler(this._terminatorTextBox_TextChanged);
            // 
            // _delimiterTextBox
            // 
            this._delimiterTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._delimiterTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._delimiterTextBox.ForeColor = System.Drawing.Color.White;
            this._delimiterTextBox.Location = new System.Drawing.Point(85, 64);
            this._delimiterTextBox.Name = "_delimiterTextBox";
            this._delimiterTextBox.Size = new System.Drawing.Size(100, 20);
            this._delimiterTextBox.TabIndex = 6;
            this._delimiterTextBox.TextChanged += new System.EventHandler(this._delimiterTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(11, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Delimiter:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.Silver;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(640, 206);
            this.dataGridView1.TabIndex = 8;
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
            this.splitContainer1.Panel1.Controls.Add(this._enableETXCheckBox);
            this.splitContainer1.Panel1.Controls.Add(this._enableSTXCheckBox);
            this.splitContainer1.Panel1.Controls.Add(this.textBox1);
            this.splitContainer1.Panel1.Controls.Add(this._etxTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this._stxTextBox);
            this.splitContainer1.Panel1.Controls.Add(this._delimiterTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this._terminatorTextBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(640, 424);
            this.splitContainer1.SplitterDistance = 214;
            this.splitContainer1.TabIndex = 9;
            // 
            // _enableETXCheckBox
            // 
            this._enableETXCheckBox.AutoSize = true;
            this._enableETXCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._enableETXCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._enableETXCheckBox.Location = new System.Drawing.Point(191, 42);
            this._enableETXCheckBox.Name = "_enableETXCheckBox";
            this._enableETXCheckBox.Size = new System.Drawing.Size(12, 11);
            this._enableETXCheckBox.TabIndex = 10;
            this._enableETXCheckBox.UseVisualStyleBackColor = false;
            // 
            // _enableSTXCheckBox
            // 
            this._enableSTXCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._enableSTXCheckBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this._enableSTXCheckBox.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this._enableSTXCheckBox.FlatAppearance.BorderSize = 0;
            this._enableSTXCheckBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this._enableSTXCheckBox.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this._enableSTXCheckBox.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this._enableSTXCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._enableSTXCheckBox.Location = new System.Drawing.Point(191, 17);
            this._enableSTXCheckBox.Name = "_enableSTXCheckBox";
            this._enableSTXCheckBox.Size = new System.Drawing.Size(10, 10);
            this._enableSTXCheckBox.TabIndex = 9;
            this._enableSTXCheckBox.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox1.Location = new System.Drawing.Point(0, 194);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(640, 20);
            this.textBox1.TabIndex = 8;
            // 
            // ParserFragment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.splitContainer1);
            this.Name = "ParserFragment";
            this.Size = new System.Drawing.Size(640, 424);
            this.Load += new System.EventHandler(this.ParserFragment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox _stxTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _etxTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _terminatorTextBox;
        private System.Windows.Forms.TextBox _delimiterTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox _enableETXCheckBox;
        private System.Windows.Forms.CheckBox _enableSTXCheckBox;
    }
}
