namespace WinFormsApp1
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
            label1 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            label6 = new Label();
            button1 = new Button();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            listBox3 = new ListBox();
            label7 = new Label();
            label2 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Sitka Small", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(442, 35);
            label1.Name = "label1";
            label1.Size = new Size(341, 64);
            label1.TabIndex = 0;
            label1.Text = "Task manager";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Small", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(147, 294);
            label3.Name = "label3";
            label3.Size = new Size(201, 44);
            label3.TabIndex = 2;
            label3.Text = "Task status";
            label3.Click += label3_Click;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(374, 179);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(509, 53);
            textBox1.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.Info;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Finished", "Pending", "in Progress" });
            comboBox1.Location = new Point(374, 294);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(509, 45);
            comboBox1.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Perpetua Titling MT", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(968, 527);
            label6.Name = "label6";
            label6.Size = new Size(319, 36);
            label6.TabIndex = 7;
            label6.Text = "Task in Progress";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(518, 399);
            button1.Name = "button1";
            button1.Size = new Size(169, 68);
            button1.TabIndex = 8;
            button1.Text = "SAVE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 37;
            listBox1.Location = new Point(114, 584);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(270, 226);
            listBox1.TabIndex = 9;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 37;
            listBox2.Location = new Point(534, 584);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(270, 226);
            listBox2.TabIndex = 10;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 37;
            listBox3.Location = new Point(968, 584);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(270, 226);
            listBox3.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sitka Small", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(147, 168);
            label7.Name = "label7";
            label7.Size = new Size(193, 44);
            label7.TabIndex = 12;
            label7.Text = "Task Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Perpetua Titling MT", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(534, 527);
            label2.Name = "label2";
            label2.Size = new Size(257, 36);
            label2.TabIndex = 13;
            label2.Text = "Task Pending";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Perpetua Titling MT", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(114, 536);
            label8.Name = "label8";
            label8.Size = new Size(276, 36);
            label8.TabIndex = 14;
            label8.Text = "Task Finishing";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1390, 849);
            Controls.Add(label8);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(listBox3);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Task manager";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Label label6;
        private Button button1;
        private ListBox listBox1;
        private ListBox listBox2;
        private ListBox listBox3;
        private Label label7;
        private Label label2;
        private Label label8;
    }
}