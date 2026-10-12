namespace WinFormsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            panel3 = new Panel();
            panel4 = new Panel();
            FileSizeDecLabel = new Label();
            FileSizeHexLabel = new Label();
            label7 = new Label();
            label6 = new Label();
            label2 = new Label();
            panel5 = new Panel();
            OffsetDecLabel = new Label();
            OffsetHexLabel = new Label();
            label11 = new Label();
            label10 = new Label();
            label5 = new Label();
            panel6 = new Panel();
            ValueInCharacter = new Label();
            Label = new Label();
            ValueInByteDec = new Label();
            ValueInByteHex = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            GotoAddressButton = new Button();
            GotoAddressTextBox = new TextBox();
            label4 = new Label();
            panel8 = new Panel();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            grid = new DataGridView();
            label1 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            FileName = new Label();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel8.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(12, 55);
            panel3.Name = "panel3";
            panel3.Size = new Size(118, 73);
            panel3.TabIndex = 5;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(FileSizeDecLabel);
            panel4.Controls.Add(FileSizeHexLabel);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(-2, -2);
            panel4.Name = "panel4";
            panel4.Size = new Size(118, 73);
            panel4.TabIndex = 6;
            // 
            // FileSizeDecLabel
            // 
            FileSizeDecLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            FileSizeDecLabel.ForeColor = Color.Indigo;
            FileSizeDecLabel.Location = new Point(37, 40);
            FileSizeDecLabel.Name = "FileSizeDecLabel";
            FileSizeDecLabel.Size = new Size(74, 20);
            FileSizeDecLabel.TabIndex = 13;
            FileSizeDecLabel.Text = "12345678";
            FileSizeDecLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FileSizeHexLabel
            // 
            FileSizeHexLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            FileSizeHexLabel.ForeColor = Color.Indigo;
            FileSizeHexLabel.Location = new Point(37, 20);
            FileSizeHexLabel.Name = "FileSizeHexLabel";
            FileSizeHexLabel.Size = new Size(74, 20);
            FileSizeHexLabel.TabIndex = 12;
            FileSizeHexLabel.Text = "12345678";
            FileSizeHexLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(0, 40);
            label7.Name = "label7";
            label7.Size = new Size(38, 20);
            label7.TabIndex = 11;
            label7.Text = "DEC:";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(0, 20);
            label6.Name = "label6";
            label6.Size = new Size(38, 20);
            label6.TabIndex = 10;
            label6.Text = "HEX:";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(118, 20);
            label2.TabIndex = 9;
            label2.Text = "FILE SIZE:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.Fixed3D;
            panel5.Controls.Add(OffsetDecLabel);
            panel5.Controls.Add(OffsetHexLabel);
            panel5.Controls.Add(label11);
            panel5.Controls.Add(label10);
            panel5.Controls.Add(label5);
            panel5.Location = new Point(12, 134);
            panel5.Name = "panel5";
            panel5.Size = new Size(118, 73);
            panel5.TabIndex = 7;
            // 
            // OffsetDecLabel
            // 
            OffsetDecLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            OffsetDecLabel.ForeColor = Color.Indigo;
            OffsetDecLabel.Location = new Point(37, 40);
            OffsetDecLabel.Name = "OffsetDecLabel";
            OffsetDecLabel.Size = new Size(74, 20);
            OffsetDecLabel.TabIndex = 15;
            OffsetDecLabel.Text = "12345678";
            OffsetDecLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // OffsetHexLabel
            // 
            OffsetHexLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            OffsetHexLabel.ForeColor = Color.Indigo;
            OffsetHexLabel.Location = new Point(37, 20);
            OffsetHexLabel.Name = "OffsetHexLabel";
            OffsetHexLabel.Size = new Size(74, 20);
            OffsetHexLabel.TabIndex = 14;
            OffsetHexLabel.Text = "12345678";
            OffsetHexLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(0, 40);
            label11.Name = "label11";
            label11.Size = new Size(38, 20);
            label11.TabIndex = 14;
            label11.Text = "DEC:";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(0, 20);
            label10.Name = "label10";
            label10.Size = new Size(38, 20);
            label10.TabIndex = 14;
            label10.Text = "HEX:";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(118, 20);
            label5.TabIndex = 10;
            label5.Text = "OFFSET:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.Fixed3D;
            panel6.Controls.Add(ValueInCharacter);
            panel6.Controls.Add(Label);
            panel6.Controls.Add(ValueInByteDec);
            panel6.Controls.Add(ValueInByteHex);
            panel6.Controls.Add(label16);
            panel6.Controls.Add(label15);
            panel6.Controls.Add(label14);
            panel6.Location = new Point(12, 213);
            panel6.Name = "panel6";
            panel6.Size = new Size(118, 86);
            panel6.TabIndex = 8;
            // 
            // ValueInCharacter
            // 
            ValueInCharacter.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            ValueInCharacter.ForeColor = Color.Indigo;
            ValueInCharacter.Location = new Point(72, 59);
            ValueInCharacter.Name = "ValueInCharacter";
            ValueInCharacter.Size = new Size(44, 20);
            ValueInCharacter.TabIndex = 20;
            ValueInCharacter.Text = "A";
            ValueInCharacter.TextAlign = ContentAlignment.MiddleCenter;
            ValueInCharacter.UseMnemonic = false;
            // 
            // Label
            // 
            Label.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label.Location = new Point(0, 60);
            Label.Name = "Label";
            Label.Size = new Size(76, 20);
            Label.TabIndex = 19;
            Label.Text = "CHARACTER:";
            Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ValueInByteDec
            // 
            ValueInByteDec.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            ValueInByteDec.ForeColor = Color.Indigo;
            ValueInByteDec.Location = new Point(72, 39);
            ValueInByteDec.Name = "ValueInByteDec";
            ValueInByteDec.Size = new Size(44, 20);
            ValueInByteDec.TabIndex = 18;
            ValueInByteDec.Text = "255";
            ValueInByteDec.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ValueInByteHex
            // 
            ValueInByteHex.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            ValueInByteHex.ForeColor = Color.Indigo;
            ValueInByteHex.Location = new Point(72, 20);
            ValueInByteHex.Name = "ValueInByteHex";
            ValueInByteHex.Size = new Size(44, 20);
            ValueInByteHex.TabIndex = 16;
            ValueInByteHex.Text = "0x00";
            ValueInByteHex.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            label16.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(0, 40);
            label16.Name = "label16";
            label16.Size = new Size(76, 20);
            label16.TabIndex = 17;
            label16.Text = "BYTE (DEC):";
            label16.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            label15.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(0, 20);
            label15.Name = "label15";
            label15.Size = new Size(76, 20);
            label15.TabIndex = 16;
            label15.Text = "BYTE (HEX):";
            label15.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            label14.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(-2, 0);
            label14.Name = "label14";
            label14.Size = new Size(118, 20);
            label14.TabIndex = 14;
            label14.Text = "VALUE:";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // GotoAddressButton
            // 
            GotoAddressButton.BackColor = Color.Transparent;
            GotoAddressButton.FlatAppearance.BorderColor = Color.DarkViolet;
            GotoAddressButton.FlatAppearance.BorderSize = 2;
            GotoAddressButton.FlatAppearance.MouseDownBackColor = Color.DarkViolet;
            GotoAddressButton.FlatAppearance.MouseOverBackColor = Color.DarkViolet;
            GotoAddressButton.Font = new Font("Segoe UI", 9F);
            GotoAddressButton.ImageAlign = ContentAlignment.TopCenter;
            GotoAddressButton.Location = new Point(17, 39);
            GotoAddressButton.Name = "GotoAddressButton";
            GotoAddressButton.Size = new Size(80, 23);
            GotoAddressButton.TabIndex = 8;
            GotoAddressButton.Text = "GO";
            GotoAddressButton.TextAlign = ContentAlignment.TopCenter;
            GotoAddressButton.UseVisualStyleBackColor = true;
            GotoAddressButton.Click += GotoAddressButton_Click;
            // 
            // GotoAddressTextBox
            // 
            GotoAddressTextBox.BackColor = SystemColors.Window;
            GotoAddressTextBox.Location = new Point(3, 15);
            GotoAddressTextBox.Name = "GotoAddressTextBox";
            GotoAddressTextBox.Size = new Size(108, 23);
            GotoAddressTextBox.TabIndex = 8;
            GotoAddressTextBox.TextChanged += textBox2_TextChanged;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            label4.Location = new Point(-1, -5);
            label4.Name = "label4";
            label4.Size = new Size(118, 20);
            label4.TabIndex = 8;
            label4.Text = "GOTO ADDRESS:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.Click += label4_Click;
            // 
            // panel8
            // 
            panel8.BorderStyle = BorderStyle.Fixed3D;
            panel8.Controls.Add(label4);
            panel8.Controls.Add(GotoAddressTextBox);
            panel8.Controls.Add(GotoAddressButton);
            panel8.Location = new Point(12, 305);
            panel8.Name = "panel8";
            panel8.Size = new Size(118, 67);
            panel8.TabIndex = 10;
            // 
            // toolStrip1
            // 
            toolStrip1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, toolStripButton3 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(710, 25);
            toolStrip1.TabIndex = 11;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(23, 22);
            toolStripButton1.Text = "toolStripButton1";
            toolStripButton1.ToolTipText = "Open File";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(23, 22);
            toolStripButton2.Text = "toolStripButton2";
            toolStripButton2.ToolTipText = "Save File";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(23, 22);
            toolStripButton3.Text = "Replace Byte (CTRL + R)";
            toolStripButton3.Click += toolStripButton3_Click;
            // 
            // grid
            // 
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.AllowUserToResizeColumns = false;
            grid.AllowUserToResizeRows = false;
            grid.BackgroundColor = SystemColors.ControlLight;
            grid.ColumnHeadersHeight = 25;
            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.BackColor = SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkViolet;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            grid.DefaultCellStyle = dataGridViewCellStyle1;
            grid.ImeMode = ImeMode.On;
            grid.Location = new Point(138, 57);
            grid.Name = "grid";
            grid.ReadOnly = true;
            grid.RowHeadersVisible = false;
            grid.RowHeadersWidth = 43;
            grid.Size = new Size(560, 456);
            grid.TabIndex = 13;
            grid.VirtualMode = true;
            grid.CellClick += grid_CellClick;
            grid.CellContentClick += grid_CellContentClick_1;
            grid.CellValueNeeded += grid_CellValueNeeded;
            grid.CurrentCellChanged += grid_CurrentCellChanged;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Indigo;
            label1.Location = new Point(138, 28);
            label1.Name = "label1";
            label1.Size = new Size(94, 27);
            label1.TabIndex = 14;
            label1.Text = "OFFSET";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Indigo;
            label3.Location = new Point(229, 28);
            label3.Name = "label3";
            label3.Size = new Size(455, 27);
            label3.TabIndex = 15;
            label3.Text = "00 01 02 03 04 05 06 07   08 09 0A 0B 0C 0D 0E 0F";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(17, 387);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(108, 126);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // FileName
            // 
            FileName.AutoSize = true;
            FileName.Font = new Font("Segoe UI", 13F);
            FileName.Location = new Point(138, 516);
            FileName.Name = "FileName";
            FileName.Size = new Size(153, 25);
            FileName.TabIndex = 17;
            FileName.Text = "Please open a file.";
            // 
            // Form1
            // 
            AccessibleRole = AccessibleRole.None;
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(710, 550);
            Controls.Add(FileName);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(grid);
            Controls.Add(panel8);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(toolStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            ImeMode = ImeMode.On;
            Name = "Form1";
            Text = " ";
            Load += Form1_Load;
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grid).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel8;
        private Label label4;
        private TextBox GotoAddressTextBox;
        private Button GotoAddressButton;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private Label label2;
        private Label label5;
        private Label FileSizeDecLabel;
        private Label FileSizeHexLabel;
        private Label label7;
        private Label label6;
        private Label OffsetDecLabel;
        private Label OffsetHexLabel;
        private Label label11;
        private Label label10;
        private Label label14;
        private Label label16;
        private Label label15;
        private Label ValueInCharacter;
        private Label Label;
        private Label ValueInByteDec;
        private Label ValueInByteHex;
        private DataGridView grid;
        private Label label1;
        private Label label3;
        private PictureBox pictureBox1;
        private ToolStripButton toolStripButton3;
        private Label FileName;
    }
}
