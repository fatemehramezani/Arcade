using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessObjectLayer
{
    public class OutPutBOL
    {
        private int? id;
        private int? eventId;
        private string eventTitle;
        private decimal? price;
        private DateTime? date;
        private string description;




        public int? Id
        {
            get { return this.id; }
            set { this.id = value; }
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
        public OutPutBOL() { }
        public OutPutBOL(int? Id, int? EventId,string EventTitle,decimal? Price,DateTime? Date,string Description)
        {
            this.Id = Id;
            this.EventId = EventId;
            this.EventTitle = EventTitle;
            this.Price = Price;
            this.Date = Date;
            this.Description = Description;
        }
       
    }
}
