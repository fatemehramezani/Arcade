using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessObjectLayer
{
    public class CoordinatingCouncilBOL
    {
        private int? id;
        private string firstName;
        private string lastName;
        private string fatherName;
        private DateTime? membershipDate;
        private string nationalCode;
        private DateTime? quitDate;

    
       

        public int? Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }
        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }
        public string FatherName
        {
            get { return this.fatherName; }
            set { this.fatherName = value; }
        }
        public string NationalCode
        {
            get { return this.nationalCode; }
            set { this.nationalCode = value; }
        }
       
        public DateTime? MembershipDate
        {
            get { return this.membershipDate; }
            set { this.membershipDate = value; }
        }
        public DateTime? QuitDate
        {
            get { return this.quitDate; }
            set { this.quitDate = value; }
        }
       
        public CoordinatingCouncilBOL() { }
        public CoordinatingCouncilBOL(int? Id, string FirstName, string LastName, string FatherName,DateTime? MembershipDate, string NationalCode, DateTime? QuitDate)
        {
            this.Id = Id;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.FatherName = FatherName;
            this.NationalCode = NationalCode;
            this.QuitDate = QuitDate;
            this.MembershipDate = MembershipDate;
           
        }
    }
}