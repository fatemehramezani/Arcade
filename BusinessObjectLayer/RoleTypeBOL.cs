using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessObjectLayer
{
    public class RoleTypeBOL
    {
        private byte?  id;
        private string  title;
        public byte? Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public string Title
        {
            get { return this.title; }
            set { this.title = value; }
        }
        public RoleTypeBOL() {}
        public RoleTypeBOL(byte? Id)
        {
            this.Id = Id;
        }
        public RoleTypeBOL(byte? Id, string Title)
        {
            this.Id =  Id;
            this.Title =  Title;
        }
    }
}
