using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QMS_DEPED_MAKATI.Classes
{
    internal static class FirestoreHelper
    {
        static string fireconfig = @"
        {
          // your Google Cloud Console key here
        } ";
        static string filepath = "";
        public static FirestoreDb? Database { get; private set; }

        public static void SetEnvironmentVariable()
        {
            filepath = Path.Combine(Path.GetTempPath(), Path.GetFileNameWithoutExtension(Path.GetRandomFileName())) + ".json";
            File.WriteAllText(filepath, fireconfig);
            File.SetAttributes(filepath, FileAttributes.Hidden);
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", filepath);
            Database = FirestoreDb.Create("qms-deped-makati");
            File.Delete(filepath);
        }

        public static async Task<List<string>> GetQueueNumbersAsync()
        {
            List<string> queueNumbers = new List<string>();

            Query queueQuery = Database.Collection("QueueNo.");
            QuerySnapshot queueQuerySnapshot = await queueQuery.GetSnapshotAsync();

            foreach (DocumentSnapshot documentSnapshot in queueQuerySnapshot.Documents)
            {
                if (documentSnapshot.Exists)
                {
                    Dictionary<string, object> queueNo = documentSnapshot.ToDictionary();
                    queueNumbers.Add(queueNo["Data"].ToString()); // Assuming the field name is "queue_number"
                }
            }

            return queueNumbers;
        }
    }
}