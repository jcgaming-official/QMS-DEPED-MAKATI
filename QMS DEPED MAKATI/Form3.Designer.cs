﻿namespace QMS_DEPED_MAKATI
{
    partial class Form3
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
            panel1 = new Panel();
            button3 = new Button();
            textBox2 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            button2 = new Button();
            groupBox1 = new GroupBox();
            label3 = new Label();
            button4 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(343, 630);
            panel1.TabIndex = 0;
            // 
            // button3
            // 
            button3.BackColor = Color.SkyBlue;
            button3.Location = new Point(128, 517);
            button3.Name = "button3";
            button3.Size = new Size(103, 41);
            button3.TabIndex = 7;
            button3.Text = "Add";
            button3.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(70, 283);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(237, 203);
            textBox2.TabIndex = 6;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 286);
            label5.Name = "label5";
            label5.Size = new Size(47, 21);
            label5.TabIndex = 5;
            label5.Text = "Text:";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(84, 227);
            label4.Name = "label4";
            label4.Size = new Size(174, 21);
            label4.TabIndex = 2;
            label4.Text = "Add Announcement";
            // 
            // button1
            // 
            button1.BackColor = Color.SkyBlue;
            button1.Location = new Point(128, 151);
            button1.Name = "button1";
            button1.Size = new Size(103, 41);
            button1.TabIndex = 4;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(128, 94);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(179, 27);
            textBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 97);
            label2.Name = "label2";
            label2.Size = new Size(94, 21);
            label2.TabIndex = 2;
            label2.Text = "Queue No:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(128, 18);
            label1.Name = "label1";
            label1.Size = new Size(103, 21);
            label1.TabIndex = 1;
            label1.Text = "Add Queue";
            // 
            // panel2
            // 
            panel2.Controls.Add(button2);
            panel2.Controls.Add(groupBox1);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(641, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(502, 630);
            panel2.TabIndex = 1;
            // 
            // button2
            // 
            button2.BackColor = Color.OrangeRed;
            button2.Location = new Point(213, 563);
            button2.Name = "button2";
            button2.Size = new Size(103, 41);
            button2.TabIndex = 5;
            button2.Text = "Remove";
            button2.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(7, 42);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(483, 496);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(225, 18);
            label3.Name = "label3";
            label3.Size = new Size(91, 21);
            label3.TabIndex = 2;
            label3.Text = "Queue List";
            // 
            // button4
            // 
            button4.BackColor = Color.SkyBlue;
            button4.Location = new Point(445, 577);
            button4.Name = "button4";
            button4.Size = new Size(103, 41);
            button4.TabIndex = 8;
            button4.Text = "Back";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            ClientSize = new Size(1143, 630);
            Controls.Add(button4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form3";
            Text = "Form3";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Panel panel2;
        private Label label3;
        private Button button2;
        private GroupBox groupBox1;
        private TextBox textBox2;
        private Label label5;
        private Label label4;
        private Button button3;
        private Button button4;
    }
}