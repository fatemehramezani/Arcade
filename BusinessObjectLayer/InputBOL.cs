using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessObjectLayer
{
    public class InputBOL
    {
        private int? id;
        private int? estateId;
        private int? eventId;
        private string title;
        private string eventTitle;
        private decimal? price;
        private DateTime? date;
        private string description;




        public int? Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public int? EstateId
        {
            get { return this.estateId; }
            set { this.estateId = value; }
        }
        public string Title
        {
            get { return this.title; }
            set { this.title = value; }
        }
        public int? EventId
        {
            get { return this.eventId; }
            set { this.eventId = value; }
        }
        
        public string EventTitle
        {
            get { return this.eventTitle; }
            set { this.eventTitle = value; }
        }
        public decimal? Price
        {
            get { return this.price; }
            set { this.price = value; }
        }
        public DateTime? Date
        {
            get { return this.date; }
            set { this.date = value; }
        }
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }
        public InputBOL() { }
        public InputBOL(int? Id, int? EstateId,string Title, int? EventId,string EventTitle,decimal? Price,DateTime? Date,string Description)
        {
            this.Id = Id;
            this.EstateId = EstateId;
            this.Title = Title;
            this.EventId = EventId;
            this.EventTitle = EventTitle;
            this.Price = Price;
            this.Date = Date;
            this.Description = Description;
        }
       
    }
}
