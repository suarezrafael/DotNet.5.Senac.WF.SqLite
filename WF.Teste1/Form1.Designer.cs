namespace WF.Teste1
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
            button1 = new Button();
            comboBox1 = new ComboBox();
            button2 = new Button();
            hopeForm1 = new ReaLTaiizor.Forms.HopeForm();
            hopeComboBox1 = new ReaLTaiizor.Controls.HopeComboBox();
            dataGridView1 = new DataGridView();
            hopeTextBox1 = new ReaLTaiizor.Controls.HopeTextBox();
            hopeCheckBox1 = new ReaLTaiizor.Controls.HopeCheckBox();
            hopeNumeric1 = new ReaLTaiizor.Controls.HopeNumeric();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(142, 64);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Atualizar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(210, 117);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(23, 64);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 2;
            button2.Text = "Incluir";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // hopeForm1
            // 
            hopeForm1.ControlBoxColorH = Color.FromArgb(228, 231, 237);
            hopeForm1.ControlBoxColorHC = Color.FromArgb(245, 108, 108);
            hopeForm1.ControlBoxColorN = Color.White;
            hopeForm1.Dock = DockStyle.Top;
            hopeForm1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            hopeForm1.ForeColor = Color.FromArgb(242, 246, 252);
            hopeForm1.Image = (Image)resources.GetObject("hopeForm1.Image");
            hopeForm1.Location = new Point(0, 0);
            hopeForm1.Name = "hopeForm1";
            hopeForm1.Size = new Size(800, 40);
            hopeForm1.TabIndex = 3;
            hopeForm1.Text = "hopeForm1";
            hopeForm1.ThemeColor = Color.FromArgb(92, 173, 255);
            // 
            // hopeComboBox1
            // 
            hopeComboBox1.DrawMode = DrawMode.OwnerDrawFixed;
            hopeComboBox1.FlatStyle = FlatStyle.Flat;
            hopeComboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            hopeComboBox1.FormattingEnabled = true;
            hopeComboBox1.ItemHeight = 30;
            hopeComboBox1.Location = new Point(23, 117);
            hopeComboBox1.Name = "hopeComboBox1";
            hopeComboBox1.Size = new Size(151, 36);
            hopeComboBox1.TabIndex = 6;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(23, 203);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(473, 188);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;
            dataGridView1.CellEnter += dataGridView1_CellEnter;
            dataGridView1.CellPainting += dataGridView1_CellPainting;
            // 
            // hopeTextBox1
            // 
            hopeTextBox1.BackColor = Color.White;
            hopeTextBox1.BaseColor = Color.FromArgb(44, 55, 66);
            hopeTextBox1.BorderColorA = Color.FromArgb(64, 158, 255);
            hopeTextBox1.BorderColorB = Color.FromArgb(220, 223, 230);
            hopeTextBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            hopeTextBox1.ForeColor = Color.FromArgb(48, 49, 51);
            hopeTextBox1.Hint = "";
            hopeTextBox1.Location = new Point(547, 244);
            hopeTextBox1.MaxLength = 32767;
            hopeTextBox1.Multiline = false;
            hopeTextBox1.Name = "hopeTextBox1";
            hopeTextBox1.PasswordChar = '\0';
            hopeTextBox1.ScrollBars = ScrollBars.None;
            hopeTextBox1.SelectedText = "";
            hopeTextBox1.SelectionLength = 0;
            hopeTextBox1.SelectionStart = 0;
            hopeTextBox1.Size = new Size(148, 43);
            hopeTextBox1.TabIndex = 8;
            hopeTextBox1.TabStop = false;
            hopeTextBox1.UseSystemPasswordChar = false;
            // 
            // hopeCheckBox1
            // 
            hopeCheckBox1.AutoSize = true;
            hopeCheckBox1.CheckedColor = Color.FromArgb(64, 158, 255);
            hopeCheckBox1.DisabledColor = Color.FromArgb(196, 198, 202);
            hopeCheckBox1.DisabledStringColor = Color.FromArgb(186, 187, 189);
            hopeCheckBox1.Enable = true;
            hopeCheckBox1.EnabledCheckedColor = Color.FromArgb(64, 158, 255);
            hopeCheckBox1.EnabledStringColor = Color.FromArgb(153, 153, 153);
            hopeCheckBox1.EnabledUncheckedColor = Color.FromArgb(156, 158, 161);
            hopeCheckBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            hopeCheckBox1.ForeColor = Color.FromArgb(48, 49, 51);
            hopeCheckBox1.Location = new Point(547, 303);
            hopeCheckBox1.Name = "hopeCheckBox1";
            hopeCheckBox1.Size = new Size(177, 20);
            hopeCheckBox1.TabIndex = 9;
            hopeCheckBox1.Text = "hopeCheckBox1";
            hopeCheckBox1.UseVisualStyleBackColor = true;
            // 
            // hopeNumeric1
            // 
            hopeNumeric1.BackColor = Color.White;
            hopeNumeric1.BaseColor = Color.FromArgb(242, 246, 252);
            hopeNumeric1.BorderColorA = Color.FromArgb(192, 196, 204);
            hopeNumeric1.BorderColorB = Color.FromArgb(192, 196, 204);
            hopeNumeric1.BorderHoverColorA = Color.FromArgb(64, 158, 255);
            hopeNumeric1.ButtonTextColorA = Color.FromArgb(144, 147, 153);
            hopeNumeric1.ButtonTextColorB = Color.FromArgb(144, 147, 153);
            hopeNumeric1.EnterKey = true;
            hopeNumeric1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            hopeNumeric1.ForeColor = Color.Black;
            hopeNumeric1.HoverButtonTextColorA = Color.FromArgb(64, 158, 255);
            hopeNumeric1.HoverButtonTextColorB = Color.FromArgb(64, 158, 255);
            hopeNumeric1.Location = new Point(546, 197);
            hopeNumeric1.MaxNum = 10F;
            hopeNumeric1.MinNum = 0F;
            hopeNumeric1.Name = "hopeNumeric1";
            hopeNumeric1.Precision = 2;
            hopeNumeric1.Size = new Size(150, 32);
            hopeNumeric1.Step = 0.1F;
            hopeNumeric1.Style = ReaLTaiizor.Controls.HopeNumeric.NumericStyle.LeftRight;
            hopeNumeric1.TabIndex = 10;
            hopeNumeric1.Text = "hopeNumeric1";
            hopeNumeric1.ValueNumber = 0F;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(hopeNumeric1);
            Controls.Add(hopeCheckBox1);
            Controls.Add(hopeTextBox1);
            Controls.Add(dataGridView1);
            Controls.Add(hopeComboBox1);
            Controls.Add(hopeForm1);
            Controls.Add(button2);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(1920, 1030);
            MinimumSize = new Size(190, 40);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ComboBox comboBox1;
        private Button button2;
        private ReaLTaiizor.Forms.HopeForm hopeForm1;
        private ReaLTaiizor.Controls.HopeComboBox hopeComboBox1;
        private DataGridView dataGridView1;
        private ReaLTaiizor.Controls.HopeTextBox hopeTextBox1;
        private ReaLTaiizor.Controls.HopeCheckBox hopeCheckBox1;
        private ReaLTaiizor.Controls.HopeNumeric hopeNumeric1;
    }
}