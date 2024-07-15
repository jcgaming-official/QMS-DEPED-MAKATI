using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QMS_DEPED_MAKATI
{
    public partial class Form2 : Form
    {
        private Form4 form4Instance; // To hold an instance of Form4

        public Form2()
        {
            InitializeComponent();

           
        }

        private void CheckBoxTopMostForm2_CheckedChanged(object sender, EventArgs e)
        {
            // Ensure we have an instance of Form4
            if (form4Instance == null || form4Instance.IsDisposed)
            {
                form4Instance = new Form4();
            }


            // Show Form4 if it's not already visible
            if (!form4Instance.Visible)
            {
                form4Instance.Show();
            }
            else
            {
                form4Instance.Focus(); // Bring to front if already open
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show(); // Show Form3
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Ensure we have an instance of Form4
            if (form4Instance == null || form4Instance.IsDisposed)
            {
                form4Instance = new Form4();
            }


            // Show Form4 if it's not already visible
            if (!form4Instance.Visible)
            {
                form4Instance.Show();
            }
            else
            {
                form4Instance.Focus(); // Bring to front if already open
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Show a confirmation dialog
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Check the user's response
            if (result == DialogResult.Yes)
            {
                // Create and show Form1 (homepage)
                Form1 form1 = new Form1();
                form1.Show();

                // Close all open forms except Form1
                foreach (Form form in Application.OpenForms.Cast<Form>().ToList())
                {
                    if (form != form1)
                    {
                        form.Close();
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Additional button functionality (if any)
        }
    }
}