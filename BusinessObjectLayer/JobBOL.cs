using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessObjectLayer
{
    public class JobBOL
    {
        private byte? id;
        private string title;
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
        public JobBOL() { }
        public JobBOL(byte? Id)
        {
            this.Id = Id;
        }
        public JobBOL(byte? Id, string Title)
        {
            this.Id = Id;
            this.Title = Title;
        }
    }
}
