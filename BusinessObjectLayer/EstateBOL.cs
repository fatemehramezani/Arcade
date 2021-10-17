using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessObjectLayer
{
    public class EstateBOL
    {
        private int? id;
        private string zipCode;
        private int? area;
        private string facilities;
        private byte? floor;
        private string address;
        private string phone;
        private byte? estateTypeId;
        private string estateTypeTitle;
        private string name;
        private string title;

        public int? Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public string ZipCode
        {
            get { return this.zipCode; }
            set { this.zipCode = value; }
        }
        public int? Area
        {
            get { return this.area; }
            set { this.area = value; }
        }
        public string Facilities
        {
            get { return this.facilities; }
            set { this.facilities = value; }
        }
        public byte? Floor
        {
            get { return this.floor; }
            set { this.floor = value; }
        }
        public string Address
        {
            get { return this.address; }
            set { this.address = value; }
        }
        public string Phone
        {
            get { return this.phone; }
            set { this.phone = value; }
        }
        public byte? EstateTypeId
        {
            get { return this.estateTypeId; }
            set { this.estateTypeId = value; }
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public string Title
        {
            get { return this.title; }
            set { this.title = value; }
        }
        public string EstateTypeTitle
        {
            get { return this.estateTypeTitle; }
            set { this.estateTypeTitle = value; }
        }
        public EstateBOL(int? Id, string Title)
        {
            this.Id = Id;
            this.Title = Title;
        }
        public EstateBOL() { }
        public EstateBOL(int? Id, string ZipCode, int? Area, string Facilities, byte? Floor, string Address, string Phone, byte? EstateTypeId, string EstateTypeTitle, string Name)
        {
            this.Id = Id;
            this.ZipCode = ZipCode;
            this.Area = Area;
            this.Facilities = Facilities;
            this.Floor = Floor;
            this.Address = Address;
            this.Phone = Phone;
            this.EstateTypeId = EstateTypeId;
            this.EstateTypeTitle = EstateTypeTitle;
            this.Name = Name;
        }
    }
}
