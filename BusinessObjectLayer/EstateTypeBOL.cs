using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessObjectLayer
{
    public class EstateTypeBOL
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
        public EstateTypeBOL() {}
        public EstateTypeBOL(byte? Id)
        {
            this.Id = Id;
        }
        public EstateTypeBOL(byte? Id, string Title)
        {
            this.Id =  Id;
            this.Title =  Title;
        }
    }
}
