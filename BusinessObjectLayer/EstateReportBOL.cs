using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessObjectLayer
{
    public class EstateReportBOL
    {
        decimal? price;
        string title ;
        DateTime? date;
        string firstName;
        string lastName ;
        string name ;
        string description;
        public decimal? Price
        {
            get { return this.price; }
            set { this.price= value; }
        }
        public string Title
        {
            get { return this.title; }
            set { this.title = value; }
        }
        public DateTime? Date
        {
            get { return this.date; }
            set { this.date = value; }
        }
        public string FitsName
        {
            get { return this.firstName; }
            set { this.firstName= value; }
        }

        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName= value; }
        }
        public string Name
        {
            get { return this.name; }
            set { this.name= value; }
        }
        public string Description
        {
            get { return this.description; }
            set { this.description= value; }
        }
        public EstateReportBOL() {}
       
        public EstateReportBOL(decimal? Price, string Title,DateTime? Date,string FirstName,string LastName,string Name ,string Description)
        {
            this.Price = Price;
            this.Title =  Title;
            this.Date = Date;
            this.FitsName = FirstName;
            this.LastName = LastName;
            this.Name = Name;
            this.Description = Description;
        }
    }
}
