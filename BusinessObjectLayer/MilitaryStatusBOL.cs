using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessObjectLayer
{
    public class MilitaryStatusBOL
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
        public MilitaryStatusBOL() {}
        public MilitaryStatusBOL(byte? Id)
        {
            this.Id = Id;
        }
        public MilitaryStatusBOL(byte? Id, string Title)
        {
            this.Id =  Id;
            this.Title =  Title;
        }
    }
}
