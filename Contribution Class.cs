using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppDraft
{
    class Contribution
    {
        private string contributionId;
        private string cwid;
        private string agencyId;
        private string uwType;
        private string checkNo = "";
        private bool monthly;
        private int months;
        private double contributionAmount;
        private DateTime uwDate;
        private int uwYear;

        public Contribution()
        {
        }

        public Contribution(string contributionId, string cwid, string agencyId, string uwType, string checkNo, bool monthly, int months, double contributionAmount, DateTime uwDate, int uwYear)
        {
            this.contributionId = contributionId;
            this.cwid = cwid;
            this.agencyId = agencyId;
            this.uwType = uwType;
            this.checkNo = checkNo;
            this.monthly = monthly;
            this.months = months;
            this.contributionAmount = contributionAmount;
            this.uwDate = uwDate;
            this.uwYear = uwYear;
        }

        public string ContributionId { get => contributionId; set => contributionId = value; }
        public string Cwid { get => cwid; set => cwid = value; }
        public string AgencyId { get => agencyId; set => agencyId = value; }
        public string UwType { get => uwType; set => uwType = value; }
        public string CheckNo { get => checkNo; set => checkNo = value; }
        public bool Monthly { get => monthly; set => monthly = value; }
        public int Months { get => months; set => months = value; }
        public double ContributionAmount { get => contributionAmount; set => contributionAmount = value; }
        public DateTime UwDate { get => uwDate; set => uwDate = value; }
        public int UwYear { get => uwYear; set => uwYear = value; }



    }
}
