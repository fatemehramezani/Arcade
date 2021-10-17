using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessObjectLayer
{
    public class CheckBOL
    {
        private int?  id;
        private string  number;
        private string accountNumber;
        private string accountName;
        private DateTime? date;
        private decimal? price;
        private string bankName;
        private string forWhom;

        public int? Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public string Number
        {
            get { return this.number; }
            set { this.number = value; }
        }

        public string AccountNumber
        {
            get { return this.accountNumber; }
            set { this.accountNumber = value; }
        }

        public DateTime? Date
        {
            get { return this.date; }
            set { this.date = value; }
        }

        public string AccountName
        {
            get { return this.accountName; }
            set { this.accountName = value; }
        }

        public decimal? Price
        {
            get { return this.price; }
            set { this.price = value; }
        }

        public string BankName
        {
            get { return this.bankName; }
            set { this.bankName = value; }
        }
        public string ForWhom
        {
            get { return this.forWhom; }
            set { this.forWhom = value; }
        }

        public CheckBOL() {}
        public CheckBOL(int? Id)
        {
            this.Id = Id;
        }
        public CheckBOL(int? Id, string Number,string AccountNumber,DateTime? Date,string AccountName,decimal? Price,string BankName,string ForWhom)
        {
            this.Id =  Id;
            this.Number =  Number;
            this.AccountNumber = AccountNumber;
            this.AccountName = AccountName;
            this.Date = Date;
            this.Price = Price;
            this.BankName = BankName;
            this.ForWhom = ForWhom;
        }
    }
}
