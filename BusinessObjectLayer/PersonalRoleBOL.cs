using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessObjectLayer
{
    public class PersonalRoleBOL
    {
        private byte? id;
        private byte? roleTypeId;
        private string roleTypeTitle;
        private int? personalInfoId;
        private string firstName;
        private string lastName;

        public byte? Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public byte? RoleTypeId
        {
            get { return this.roleTypeId; }
            set { this.roleTypeId = value; }
        }
        public string RoleTypeTitle
        {
            get { return this.roleTypeTitle; }
            set { this.roleTypeTitle = value; }
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
        public PersonalRoleBOL() { }
        //public PersonalRoleBOL(byte? Id)
        //{
        //    this.Id = Id;
        //}
        public PersonalRoleBOL(byte? Id,byte? RoleTypeId,string RoleTypeTitle,int? PersonalInfoId, string FirstName,string LastName)
        {
            this.Id = Id;
            this.RoleTypeId = RoleTypeId ;
            this.RoleTypeTitle = RoleTypeTitle;
            this.PersonalInfoId = PersonalInfoId;
            this.FirstName = FirstName;
            this.LastName = LastName;
        }
    }
}
