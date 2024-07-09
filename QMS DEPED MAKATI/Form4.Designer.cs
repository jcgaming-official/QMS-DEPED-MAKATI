namespace QMS_DEPED_MAKATI
{
    partial class Form4
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            label1 = new Label();
            panel2 = new Panel();
            panel5 = new Panel();
            label4 = new Label();
            label3 = new Label();
            panel3 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel4 = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            panel6 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel6);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(301, 741);
            panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.BackgroundImageLayout = ImageLayout.None;
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 80);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(301, 661);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(76, 27);
            label1.Name = "label1";
            label1.Size = new Size(159, 33);
            label1.TabIndex = 0;
            label1.Text = "Queue List:";
            // 
            // panel2
            // 
            panel2.Controls.Add(panel5);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(301, 661);
            panel2.Name = "panel2";
            panel2.Size = new Size(982, 80);
            panel2.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.Controls.Add(label4);
            panel5.Controls.Add(label3);
            panel5.Dock = DockStyle.Right;
            panel5.Location = new Point(782, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(200, 80);
            panel5.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 17);
            label4.Name = "label4";
            label4.Size = new Size(50, 21);
            label4.TabIndex = 2;
            label4.Text = "Date";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(74, 50);
            label3.Name = "label3";
            label3.Size = new Size(46, 21);
            label3.TabIndex = 1;
            label3.Text = "Time";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Khaki;
            panel3.Controls.Add(label2);
            panel3.Controls.Add(pictureBox1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(301, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(982, 80);
            panel3.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(430, 31);
            label2.Name = "label2";
            label2.Size = new Size(251, 19);
            label2.TabIndex = 2;
            label2.Text = "DEPED MAKATI DIVISION OFFICE ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-2, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(85, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(301, 80);
            panel4.Name = "panel4";
            panel4.Size = new Size(982, 581);
            panel4.TabIndex = 3;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // panel6
            // 
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(301, 80);
            panel6.TabIndex = 0;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1283, 741);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form4";
            Text = "Form4";
            WindowState = FormWindowState.Maximized;
            Load += Form4_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private PictureBox pictureBox1;
        private Label label2;
        private Panel panel5;
        private Label label3;
        private System.Windows.Forms.Timer timer1;
        private Label label4;
        private GroupBox groupBox1;
        private Panel panel6;
    }
}