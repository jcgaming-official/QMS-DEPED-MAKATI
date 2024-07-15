using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QMS_DEPED_MAKATI.Classes
{
    [FirestoreData]
    internal class UserData
    {
        [FirestoreProperty]
        public string Fullname { get; set; }

        [FirestoreProperty]
        public string Username { get; set; }

        [FirestoreProperty]
        public string Password { get; set; }

        [FirestoreProperty]
        public string Gender { get; set; }

        [FirestoreProperty]
        public int Phonenumber { get; set; }

    }
}
