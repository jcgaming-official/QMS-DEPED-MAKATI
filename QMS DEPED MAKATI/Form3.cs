using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Google.Cloud.Firestore;
using System.IO;
using QMS_DEPED_MAKATI.Classes;

namespace QMS_DEPED_MAKATI
{
    public partial class Form3 : Form
    {
        private FirestoreDb _database;

        public Form3()
        {
            InitializeComponent();
            InitializeFirestore();
        }

        private void InitializeFirestore()
        {
            FirestoreHelper.SetEnvironmentVariable();
            _database = FirestoreHelper.Database;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int number))
            {
                await AddDataToFirestore(number);
                textBox1.Clear();
                await LoadDataFromFirestore();
            }
            else
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }

        private async Task AddDataToFirestore(int data)
        {
            CollectionReference collection = _database.Collection("QueueNo.");
            Dictionary<string, object> newData = new Dictionary<string, object>
            {
                { "Data", data }
            };
            await collection.AddAsync(newData);
        }

        private async Task LoadDataFromFirestore()
        {
            listBox1.Items.Clear();
            CollectionReference collection = _database.Collection("QueueNo.");
            QuerySnapshot snapshot = await collection.GetSnapshotAsync();
            foreach (DocumentSnapshot document in snapshot.Documents)
            {
                if (document.Exists)
                {
                    Dictionary<string, object> docData = document.ToDictionary();
                    if (docData.ContainsKey("Data") && int.TryParse(docData["Data"].ToString(), out int number))
                    {
                        listBox1.Items.Add(number);
                    }
                }
            }
        }

        private async Task RemoveDataFromFirestore(int data)
        {
            CollectionReference collection = _database.Collection("QueueNo.");
            Query query = collection.WhereEqualTo("Data", data);
            QuerySnapshot snapshot = await query.GetSnapshotAsync();

            foreach (DocumentSnapshot document in snapshot.Documents)
            {
                if (document.Exists)
                {
                    await document.Reference.DeleteAsync();
                }
            }
        }

        private async Task RemoveAllDataFromFirestore()
        {
            CollectionReference collection = _database.Collection("QueueNo.");
            QuerySnapshot snapshot = await collection.GetSnapshotAsync();

            foreach (DocumentSnapshot document in snapshot.Documents)
            {
                if (document.Exists)
                {
                    await document.Reference.DeleteAsync();
                }
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                int selectedData = (int)listBox1.SelectedItem;
                await RemoveDataFromFirestore(selectedData);
                await LoadDataFromFirestore();
            }
            else
            {
                MessageBox.Show("Please select an item to remove.");
            }
        }

        private async void button5_Click(object sender, EventArgs e)
        {
            await LoadDataFromFirestore();
        }

        private async void button6_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to remove all items?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                await RemoveAllDataFromFirestore();
                await LoadDataFromFirestore();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
            this.Hide();
        }
    }
}