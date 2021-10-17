using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessObjectLayer
{
    public class AddressBOL
    {
        private int? id;
        private int? personalInfoId;
        private string address;
        private DateTime? startDate;
        private DateTime? endDate;
        private byte? habitationId;
        private string habitationTitle;
        private string postalCode;
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
        public string Address
        {
            get { return this.address; }
            set { this.address = value; }
        }
        public DateTime? StartDate
        {
            get { return this.startDate; }
            set { this.startDate = value; }
        }
        public DateTime? EndDate
        {
            get { return this.endDate; }
            set { this.endDate = value; }
        }
        public byte? HabitationId
        {
            get { return this.habitationId; }
            set { this.habitationId = value; }
        }
        public string HabitationTitle
        {
            get { return this.habitationTitle; }
            set { this.habitationTitle = value; }
        }
        public string PostalCode
        {
            get { return this.postalCode; }
            set { this.postalCode = value; }
        }
        public AddressBOL() { }
        public AddressBOL(int? Id,int? PersonalInfoId,string Address,DateTime? StartDate,DateTime? EndDate,byte? HabitationId,string HabitationTitle,string PostalCode )
        {
            this.Id = Id;
            this.PersonalInfoId = PersonalInfoId;
            this.Address = Address;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.HabitationId = HabitationId;
            this.HabitationTitle = HabitationTitle;
            this.PostalCode = PostalCode;
        }
    }
}
