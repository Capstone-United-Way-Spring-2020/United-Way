using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppDraft
{
    class User
    {
        private string userId;
        private string userStatus;
        private bool readAccess;
        private bool writeAccess;
        private bool deleteAccess;

        public User()
        {
        }

        public User(string userId, string userStatus, bool readAccess, bool writeAccess, bool deleteAccess)
        {
            this.userId = userId;
            this.userStatus = userStatus;
            this.readAccess = readAccess;
            this.writeAccess = writeAccess;
            this.deleteAccess = deleteAccess;
        }

        public string UserId { get => userId; set => userId = value; }
        public string UserStatus { get => userStatus; set => userStatus = value; }
        public bool ReadAccess { get => readAccess; set => readAccess = value; }
        public bool WriteAccess { get => writeAccess; set => writeAccess = value; }
        public bool DeleteAccess { get => deleteAccess; set => deleteAccess = value; }


    }
}
