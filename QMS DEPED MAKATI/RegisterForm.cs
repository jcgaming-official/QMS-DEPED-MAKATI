using Google.Cloud.Firestore;
using QMS_DEPED_MAKATI.Classes;
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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label2.Text = DateTime.Now.ToLongDateString();
            label3.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 form = new Form1();
            form.ShowDialog();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var db = FirestoreHelper.Database;
            if (CheckIfUserAlreadyExist())
            {
                MessageBox.Show("User Already Exist");
                return;
            }
            var data = GetWriteData();
            DocumentReference docRef = db.Collection("UserData").Document(data.Username);
            docRef.SetAsync(data);
            MessageBox.Show("Success");
        }
        private UserData GetWriteData()
        {

            string fullname = Convert.ToString(textBox3.Text);
            string username = textBox1.Text.Trim();
            string password = Security.Encrypt(textBox2.Text);
            string gender = comboBox1.Text.Trim();
            int phonenumber = (int)Convert.ToInt64(textBox4.Text);

            return new UserData()
            {
                Fullname = fullname,
                Username = username,
                Password = password,
                Gender = gender,
                Phonenumber = phonenumber
            };
        }

        private bool CheckIfUserAlreadyExist(){

            string username = textBox1.Text.Trim();

            var db = FirestoreHelper.Database;
            DocumentReference docRef = db.Collection("UserData").Document(username);
            UserData data = docRef.GetSnapshotAsync().Result.ConvertTo<UserData>();

            if (data != null)
            {
                return true;

            }
            return false;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
