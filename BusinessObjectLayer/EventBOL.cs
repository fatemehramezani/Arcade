using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessObjectLayer
{
    public class EventBOL
    {
        private int? id;
        private string title;
        private string description;
        private string estateIds;



        public int? Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public string Title
        {
            get { return this.title; }
            set { this.title = value; }
        }
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }
        public string EstateIds
        {
            get { return this.estateIds; }
            set { this.estateIds = value; }
        }
        public EventBOL() { }
        public EventBOL(int? Id, string Title, string Description,string EstateIds)
        {
            this.Id = Id;
            this.Title = Title;
            this.Description = Description;
            this.EstateIds = EstateIds;
        }
        //public EventBOL(int? Id, string Title)
        //{
        //    this.Id = Id;
        //    this.Title = Title;
        //}
    }
}
