using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessObjectLayer
{
    public class LetterPlaceBOL
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
        public LetterPlaceBOL() { }
        public LetterPlaceBOL(byte? Id, string Title)
        {
            this.Id = Id;
            this.Title = Title;
        }
    }
}
