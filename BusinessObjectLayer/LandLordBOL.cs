using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessObjectLayer
{
    public class LandLordBOL
    {
        private int? id;
        private int? personalInfoId;
        private string firstName;
        private string lastName;
        private decimal? share;
        private int? estateId;
        private string title;
        private int? purchaseLetterId;
        private bool? type;
        private bool? isLandLord;
       
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
        public decimal? Share
        {
            get { return this.share; }
            set { this.share = value; }
        }
        public int? EstateId
        {
            get { return this.estateId; }
            set { this.estateId = value; }
        }
        public string Title
        {
            get { return this.title; }
            set { this.title = value; }
        }
     
        public bool? Type
        {
            get { return this.type; }
            set { this.type = value; }
        }
        public bool? IsLandLord
        {
            get { return this.isLandLord; }
            set { this.isLandLord = value; }
        }

        
        public LandLordBOL() { }
        public LandLordBOL(int? Id, int? PersonalInfoId, string FirstName, string LastName, byte? Share, int? EstateId, string Title, bool? Type, bool? IsLandLord)
        {
            this.Id = Id;
            this.PersonalInfoId = PersonalInfoId;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Share = Share;
            this.EstateId = EstateId;
            this.Title = Title;
            this.Type = Type;
            this.IsLandLord = IsLandLord;
        
        }
    }
}