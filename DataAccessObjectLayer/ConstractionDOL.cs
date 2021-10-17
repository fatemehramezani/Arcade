using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataObjectLayer
{
    public class ConstractionDOL
    {
        public const string Select = @"SELECT     System.Constraction.Id, System.Constraction.StartDate, System.Constraction.DeliveryDate, System.Constraction.EstateTypeId, System.Constraction.UnitNumber, System.Constraction.EstateId, System.Constraction.ConstractorName, System.Estate.Floor AS EstateFloor, Basic.EstateType.Title AS EstateTypeTitle FROM         System.Constraction LEFT OUTER JOIN System.Estate ON System.Constraction.EstateId = System.Estate.Id LEFT OUTER JOIN Basic.EstateType ON System.Constraction.EstateTypeId = Basic.EstateType.Id";
        public const string Insert = @"INSERT INTO System.Constraction (Id, StartDate, DeliveryDate, EstateTypeId, UnitNumber, EstateId, ConstractorName) VALUES (@Id,@StartDate,@DeliveryDate,@EstateTypeId,@UnitNumber,@EstateId,@ConstractorName)";
        public const string SelectComboBox = @"SELECT Id, Title FROM System.Constraction UNION (SELECT ID AS Id, TEXT AS Title FROM NOSELECTION)";
        public const string Delete = "DELETE FROM System.Constraction WHERE(Id = @Id)";
        public const string Update = "UPDATE    System.Constraction SET StartDate = @StartDate, DeliveryDate = @DeliveryDate, EstateTypeId = @EstateTypeId, UnitNumber = @UnitNumber, EstateId = @EstateId, ConstractorName = @ConstractorName WHERE (Id = @Id)";
        public const string SelectMaxId = "SELECT ISNULL(MAX(Id),0)+1 AS MAX_ID FROM System.Constraction";
        public enum QueryStatus { Select, SelectComboBox, Insert, Delete, Update, SelectMaxId };
    }
}
