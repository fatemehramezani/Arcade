using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessObjectLayer
{
    public class MaritalStatusBOL
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
        public MaritalStatusBOL() {}
        public MaritalStatusBOL(byte? Id)
        {
            this.Id = Id;
        }
        public MaritalStatusBOL(byte? Id, string Title)
        {
            this.Id =  Id;
            this.Title =  Title;
        }
    }
}
