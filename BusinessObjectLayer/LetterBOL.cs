using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessObjectLayer
{
    public class LetterBOL
    {
        private int? id;
        private int? personalInfoId;
        private string letterNumber;
        private DateTime? letterDate;
        private byte? letterPlaceId;
        private string letterPlaceTitle;
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
        public string LetterNumber
        {
            get { return this.letterNumber; }
            set { this.letterNumber = value; }
        }
        public DateTime? LetterDate
        {
            get { return this.letterDate; }
            set { this.letterDate = value; }
        }
        public byte? LetterPlaceId
        {
            get { return this.letterPlaceId; }
            set { this.letterPlaceId = value; }
        }
        public string LetterPlaceTitle
        {
            get { return this.letterPlaceTitle; }
            set { this.letterPlaceTitle = value; }
        }
        public LetterBOL() { }
        public LetterBOL(int? Id,int? PersonalInfoId, string LetterNumber,DateTime? LetterDate,byte? LetterPlaceId,string LetterPlaceTitle)
        {
            this.Id = Id;
            this.PersonalInfoId = PersonalInfoId;
            this.LetterNumber = LetterNumber;
            this.LetterDate = LetterDate;
            this.LetterPlaceId = LetterPlaceId;
            this.LetterPlaceTitle = LetterPlaceTitle;
        }
    }
}
