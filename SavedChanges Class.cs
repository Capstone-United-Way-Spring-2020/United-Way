using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppDraft
{
    class SavedChanges
    {
        private string changeId;
        private string userId;
        private DateTime changeTime;

        public SavedChanges()
        {
        }

        public SavedChanges(string changeId, string userId, DateTime changeTime)
        {
            this.changeId = changeId;
            this.userId = userId;
            this.changeTime = changeTime;
        }

        public string ChangeId { get => changeId; }
        public string UserId { get => userId; }
        public DateTime ChangeTime { get => changeTime; }
    }
}
