using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessObjectLayer
{
    public class AccessDBBOL
    {
        int? Id;
        int? code;
        bool? isMale;
        DateTime? formationDate ;
        string firstName ;
        string lastName ;
        string fatherName;
        DateTime? birthDate;
        string certificate ;
        string issuancePlace;
        byte? sectId ;
        byte? militaryStatusId ;
        byte? ostan ;
        byte? cityCode;
        string address;
        byte? degreeId;
        string field;
        string degreeAddress;
        bool? statusId;
        string aliasesFirstName ;
        string aliasesLastName ;
        bool? isAlive ;
        bool? isforeigner;
        string serial;
        byte? religionId;
                
        public int? Code
        {
            get { return this.code; }
            set { this.code= value; }
        }
        public bool? IsMale
        {
            get { return this.isMale; }
            set { this.isMale= value; }
        }

        public DateTime? FormationDate
        {
            get { return this.formationDate; }
            set { this.formationDate= value; }
        }

        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName= value; }
        }

        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName= value; }
        }
        public string FatherName
        {
            get { return this.fatherName; }
            set { this.fatherName= value; }
        }

        public DateTime? BirthDate
        {
            get { return this.birthDate; }
            set { this.birthDate= value; }
        }

        public string Serial
        {
            get { return this.serial; }
            set { this.serial = value; }
        }
        public string Certificate
        {
            get { return this.certificate; }
            set { this.certificate= value; }
        }
        public string IssuancePlace
        {
            get { return this.issuancePlace; }
            set { this.issuancePlace = value; }
        }

        public byte? ReligionId
        {
            get { return this.religionId; }
            set { this.religionId = value; }
        }

        public byte? SectId
        {
            get { return this.sectId; }
            set { this.sectId= value; }
        }

        public byte? MilitaryStatusId
        {
            get { return this.militaryStatusId; }
            set { this.militaryStatusId = value; }
        }

        public byte?  Ostan
        {
            get { return this.ostan; }
            set { this.ostan = value; }
        }

        public byte? CityCode
        {
            get { return this.cityCode; }
            set { this.cityCode = value; }
        }

        public string Address
        {
            get { return this.address; }
            set { this.address = value; }
        }

        public byte? DegreeId
        {
            get { return this.degreeId; }
            set { this.degreeId = value; }
        }

        public string Field
        {
            get { return this.field; }
            set { this.field= value; }
        }

        public string DegreeAddress
        {
            get { return this.degreeAddress; }
            set { this.degreeAddress = value; }
        }

        public bool? StatusId
        {
            get { return this.statusId; }
            set { this.statusId = value; }
        }

        public string AliasesFirstName
        {
            get { return this.aliasesFirstName; }
            set { this.aliasesFirstName = value; }
        }

        public bool? Isforeigner
        {
            get { return this.isforeigner; }
            set { this.isforeigner = value; }
        }
        
                
        public string AliasesLastName
        {
            get { return this.aliasesFirstName; }
            set { this.aliasesFirstName = value; }
        }

        public AccessDBBOL() {}
        public AccessDBBOL(int? Id)
        {
            this.Id = Id;
        }
        public AccessDBBOL(int? Id,int? Code,bool? IsMale,DateTime? FormationDate,string FirstName,string LastName,
        string FatherName,DateTime? BirthDate,string Certificate,string IssuancePlace,byte? SectId,byte? MilitaryStatusId,
        byte? Ostan, byte? CityCode,string Address,byte? DegreeId,string Field,string DegreeAddress,bool? StatusId,
        string AliasesFirstName,string AliasesLastName,bool? IsAlive,bool? Isforeigner,string Serial)//,byte? ReligionId)
        {
            this.Id=Id;
            this.Code=Code;
            this.IsMale=IsMale;
            this.FormationDate=formationDate;
            this.FirstName=FirstName;
            this.LastName=LastName;
            this.FatherName=FirstName;
            this.BirthDate=BirthDate;
            this.Certificate=Certificate;
            this.IssuancePlace=IssuancePlace;
            this.SectId=SectId;
            this.MilitaryStatusId=MilitaryStatusId;
            this.Ostan=Ostan;
            this.CityCode=CityCode;
            this.Address=Address;
            this.DegreeAddress=DegreeAddress;
            this.Field=Field;
            this.DegreeAddress=DegreeAddress;
            this.StatusId=StatusId;
            this.AliasesFirstName=AliasesFirstName;
            this.AliasesLastName=AliasesLastName;
            this.Isforeigner=Isforeigner;
            this.Serial=Serial;
            this.ReligionId= ReligionId;
        }
    }
}
