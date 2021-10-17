using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessObjectLayer
{
    public class MembershipBOL
    {
        private int? id;
        private int? personalInfoId;
        private string registrationNumber;
        private decimal? dues;
        private DateTime? registrationDate;
        public int? Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public int? PersonalInfoId
        {
            get { return this.personalInfoId; }
            set { this.personalInfoId = value; }
        }
        public string RegistrationNumber
        {
            get { return this.registrationNumber; }
            set { this.registrationNumber = value; }
        }
        public decimal? Dues
        {
            get { return this.dues; }
            set { this.dues = value; }
        }
        public DateTime? RegistrationDate
        {
            get { return this.registrationDate; }
            set { this.registrationDate = value; }
        }
        public MembershipBOL() { }
        public MembershipBOL(int? Id,int? PersonalInfoId, string RegistrationNumber,  decimal? Dues, DateTime? RegistrationDate)
        {
            this.Id = Id;
            this.PersonalInfoId = PersonalInfoId;
            this.RegistrationNumber = RegistrationNumber;
            this.Dues = Dues;
            this.registrationDate = RegistrationDate;
        }
    }
}
