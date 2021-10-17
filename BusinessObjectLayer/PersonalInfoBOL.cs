using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessObjectLayer
{
    public class PersonalInfoBOL
    {
        private int? id;
        private string firstName;
        private string lastName;
        private string fatherName;
        private string nationalCode;
        private string cetificate;
        private string issuancePlace;
        private string birthPlace;
        private DateTime? birthday;
        private bool? isMale;
        private byte? maritalStatuseId;
        private string maritalStatuseTitle;
        private string phone;
        private string mobile;
        private byte? jobId;
        private string jobTitle;
        private byte[] image;
        private byte? militaryStatuseId;
        private string militaryStatuseTitle;
        private bool? isLegal;
        private string companyPhone;
        private string companyName;
        private string address;
        private string companyAddress;
        private string zipeCode;

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
        public string Cetificate
        {
            get { return this.cetificate; }
            set { this.cetificate = value; }
        }
        
        public string IssuancePlace
        {
            get { return this.issuancePlace; }
            set { this.issuancePlace = value; }
        }
        public string BirthPlace
        {
            get { return this.birthPlace; }
            set { this.birthPlace = value; }
        }
        public DateTime? Birthday
        {
            get { return this.birthday; }
            set { this.birthday = value; }
        }
        public bool? IsMale
        {
            get { return this.isMale; }
            set { this.isMale = value; }
        }
        public byte? MaritalStatuseId
        {
            get { return this.maritalStatuseId; }
            set { this.maritalStatuseId = value; }
        }
        public string MaritalStatuseTitle
        {
            get { return this.maritalStatuseTitle; }
            set { this.maritalStatuseTitle = value; }
        }
       
        public string Phone
        {
            get { return this.phone; }
            set { this.phone = value; }
        }
        public string Mobile
        {
            get { return this.mobile; }
            set { this.mobile = value; }
        }
        public byte? JobId
        {
            get { return this.jobId; }
            set { this.jobId = value; }
        }
        public string JobTitle
        {
            get { return this.jobTitle; }
            set { this.jobTitle = value; }
        }
        public byte[] Image
        {
            get { return this.image; }
            set { this.image = value; }
        }
        public byte? MilitaryStatuseId
        {
            get { return this.militaryStatuseId; }
            set { this.militaryStatuseId = value; }
        }
        public string MilitaryStatuseTitle
        {
            get { return this.militaryStatuseTitle; }
            set { this.militaryStatuseTitle = value; }
        }
       
        public bool? IsLegal
        {
            get { return this.isLegal; }
            set { this.isLegal = value; }
        }
      
        public string CompanyPhone
        {
            get { return this.companyPhone; }
            set { this.companyPhone = value; }
        }
        public string CompanyName
        {
            get { return this.companyName; }
            set { this.companyName = value; }
        }
        public string Address
        {
            get { return this.address; }
            set { this.address = value; }
        }
        public string CompanyAddress
        {
            get { return this.companyAddress; }
            set { this.companyAddress = value; }
        }
        public string ZipeCode
        {
            get { return this.zipeCode; }
            set { this.zipeCode = value; }
        }
        public PersonalInfoBOL() { }

        public PersonalInfoBOL(int? Id, string FirstName, string LastName, string FatherName, string NationalCode, string Cetificate, string IssuancePlace, string BirthPlace, DateTime? Birthday, bool? IsMale, byte? MaritalStatuseId, string MaritalStatuseTitle, string Phone, string Mobile, byte? MilitaryStatuseId, string MilitaryStatuseTitle, string Address, byte? JobId, string JobTitle, string CompanyName, string CompanyAddress, string CompanyPhone, bool? IsLegal, string ZipeCode)
        {
            this.Id = Id;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.FatherName = FatherName;
            this.NationalCode = NationalCode;
            this.Cetificate = Cetificate;
            this.IssuancePlace = IssuancePlace;
            this.BirthPlace = BirthPlace;
            this.Birthday = Birthday;
            this.IsMale = IsMale;
            this.MaritalStatuseId = MaritalStatuseId;
            this.MaritalStatuseTitle = MaritalStatuseTitle;
            this.Phone = Phone;
            this.Mobile = Mobile;
            this.JobId = JobId;
            this.JobTitle = JobTitle;
            this.MilitaryStatuseId = MilitaryStatuseId;
            this.MilitaryStatuseTitle = MilitaryStatuseTitle;
            this.IsLegal = IsLegal;
            this.CompanyPhone = CompanyPhone;
            this.CompanyName = CompanyName;
            this.Address = Address;
            this.CompanyAddress = CompanyAddress;
            this.ZipeCode = ZipeCode;
        }
        public PersonalInfoBOL(int? Id, string FirstName, string LastName, string FatherName, string NationalCode, string Cetificate, string IssuancePlace, string BirthPlace, DateTime? Birthday, bool? IsMale, byte? MaritalStatuseId, string MaritalStatuseTitle, string Phone, string Mobile, byte[] Image, byte? MilitaryStatuseId, string MilitaryStatuseTitle, string Address, byte? JobId, string JobTitle, string CompanyName, string CompanyAddress, string CompanyPhone, bool? IsLegal,string ZipeCode)
        {
            this.Id = Id;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.FatherName = FatherName;
            this.NationalCode = NationalCode;
            this.Cetificate = Cetificate;
            this.IssuancePlace = IssuancePlace;
            this.BirthPlace = BirthPlace;
            this.Birthday = Birthday;
            this.IsMale = IsMale;
            this.MaritalStatuseId = MaritalStatuseId;
            this.MaritalStatuseTitle = MaritalStatuseTitle;
            this.Phone = Phone;
            this.Mobile = Mobile;
            this.JobId = JobId;
            this.JobTitle = JobTitle;
            this.Image = Image;
            this.MilitaryStatuseId = MilitaryStatuseId;
            this.MilitaryStatuseTitle = MilitaryStatuseTitle;
            this.IsLegal = IsLegal;
           this.CompanyPhone = CompanyPhone;
            this.CompanyName = CompanyName;
            this.Address = Address;
            this.CompanyAddress = CompanyAddress;
            this.ZipeCode = ZipeCode;
        }
    }
}