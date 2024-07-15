using Google.Cloud.Firestore;
using QMS_DEPED_MAKATI.Classes;

namespace QMS_DEPED_MAKATI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Subscribe to the KeyDown event for textBox2
            textBox2.KeyDown += new KeyEventHandler(textBox2_KeyDown);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label3.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim();
            string password = textBox2.Text;

            var db = FirestoreHelper.Database;
            DocumentReference docRef = db.Collection("UserData").Document(username);
            UserData data = docRef.GetSnapshotAsync().Result.ConvertTo<UserData>();

            if (data != null)
            {
                if (password == Security.Decrypt(data.Password))
                {
                    MessageBox.Show("Login Success");
                    Form2 f2 = new Form2();
                    f2.ShowDialog();
                    Close();
                }

                else
                {
                    MessageBox.Show("Login Failed");
                }
            }

            else
            {
                MessageBox.Show("Login Failed");
            }


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        // KeyDown event handler for textBox2
        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Suppress the beep sound on Enter key press
                e.SuppressKeyPress = true;
                // Programmatically click the login button
                button1.PerformClick();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            RegisterForm form = new RegisterForm();
            form.ShowDialog();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = "";
        }
    }
}