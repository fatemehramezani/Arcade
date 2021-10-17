using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessObjectLayer
{
    public class ConstractionBOL
    {
        private int? id;
        private DateTime? startDate;
        private DateTime? deliveryDate;
        private int? unitNumber;
        private int? estateId;
        private byte? estateTypeId;
        private int? Estatefloor;
        private string constractorName;
        private string lastName;
        private string estateTypetitle;


        public int? Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public DateTime? StartDate
        {
            get { return this.startDate; }
            set { this.startDate = value; }
        }
        public DateTime? DeliveryDate
        {
            get { return this.deliveryDate; }
            set { this.deliveryDate = value; }
        }

        public int? UnitNumber
        {
            get { return this.unitNumber; }
            set { this.unitNumber = value; }
        }

        public int? EstateId
        {
            get { return this.estateId; }
            set { this.estateId = value; }
        }

        public byte? EstateTypeId
        {
            get { return this.estateTypeId; }
            set { this.estateTypeId = value; }
        }

        public int? Floor
        {
            get { return this.Estatefloor; }
            set { this.Estatefloor = value; }
        }


        public string ConstractorName
        {
            get { return this.constractorName; }
            set { this.constractorName = value; }
        }

        public string EstateTypeTitle
        {
            get { return this.estateTypetitle; }
            set { this.estateTypetitle = value; }
        }

       
        public ConstractionBOL() { }
        public ConstractionBOL(int? Id)
        {
            this.Id = Id;
        }

        public ConstractionBOL(int? Id, DateTime? StartDate, DateTime? DeliveryDate, int? UnitNumber, int? EstateId, byte? EstateTypeId, int? Floor, string ConstractorName, string EstateTypeTitle)
        {

            this.Id = Id;
            this.StartDate = StartDate;
            this.UnitNumber = UnitNumber;
            this.DeliveryDate = DeliveryDate;
            this.EstateId = EstateId;
            this.estateTypeId = EstateTypeId;
            this.Floor = Floor;
            this.ConstractorName = ConstractorName;
            this.estateTypetitle = EstateTypeTitle;
        }
    }
}
