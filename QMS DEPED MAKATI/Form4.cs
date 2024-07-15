using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QMS_DEPED_MAKATI.Classes;

namespace QMS_DEPED_MAKATI
{
    public partial class Form4 : Form
    {
        private CheckBox checkBoxTopMostForm4; // Unique name for Form4's checkbox

        public Form4()
        {
            InitializeComponent();

            // Initialize checkBoxTopMostForm4
            checkBoxTopMostForm4 = new CheckBox();
            checkBoxTopMostForm4.Text = "Keep Form4 on Top";
            checkBoxTopMostForm4.Location = new System.Drawing.Point(10, 10); // Adjust location as needed
            checkBoxTopMostForm4.CheckedChanged += CheckBoxTopMostForm4_CheckedChanged;

            // Add checkBoxTopMostForm4 to Form4 controls
            this.Controls.Add(checkBoxTopMostForm4);
        }

        private void CheckBoxTopMostForm4_CheckedChanged(object sender, EventArgs e)
        {
            // Toggle the TopMost property of Form4 based on checkbox state
            this.TopMost = checkBoxTopMostForm4.Checked;
        }

        private async void Form4_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label4.Text = DateTime.Now.ToLongDateString();
            label3.Text = DateTime.Now.ToLongTimeString();
            await LoadQueueNumbersAsync();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToLongTimeString();
        }

        private async Task LoadQueueNumbersAsync()
        {
            FirestoreHelper.SetEnvironmentVariable();
            listBox1.Enabled = false; // Disable listBox1 during loading
            List<string> queueNumbers = await FirestoreHelper.GetQueueNumbersAsync();
            listBox1.Items.Clear();
            foreach (var number in queueNumbers)
            {
                listBox1.Items.Add(number);
            }
            listBox1.Enabled = true; // Enable listBox1 after loading
        }
    }
}