using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer
{
    using BusinessObjectLayer;
    using DataAccessLayer;
    using DataObjectLayer;

    public class InspectionTypeBLL
    {
        public InspectionTypeBOL[] Select()
        {
            InspectionTypeDAL _InspectionTypeDAL = new InspectionTypeDAL(InspectionTypeDOL.QueryStatus.Select);
            return _InspectionTypeDAL.Select();
        }
        public void Insert(InspectionTypeBOL _InspectionTypeBOL)
        {
            InspectionTypeDAL _InspectionTypeDAL = new InspectionTypeDAL(InspectionTypeDOL.QueryStatus.Insert, _InspectionTypeBOL);
            _InspectionTypeDAL.Insert();
        }
        public void Update(InspectionTypeBOL _InspectionTypeBOL)
        {
            InspectionTypeDAL _InspectionTypeDAL = new InspectionTypeDAL(InspectionTypeDOL.QueryStatus.Update, _InspectionTypeBOL);
            _InspectionTypeDAL.Update();
        }
        public void Delete(InspectionTypeBOL _InspectionTypeBOL)
        {
            InspectionTypeDAL _InspectionTypeDAL = new InspectionTypeDAL(InspectionTypeDOL.QueryStatus.Delete, _InspectionTypeBOL);
            _InspectionTypeDAL.Delete();
        }
        public long? SelectMaxId()
        {
            InspectionTypeDAL _InspectionTypeDAL = new InspectionTypeDAL(InspectionTypeDOL.QueryStatus.SelectMaxId);
            return _InspectionTypeDAL.SelectMaxId();
        }
        public InspectionTypeBOL[] SelectComboBox()
        {
            InspectionTypeDAL _InspectionTypeDAL = new InspectionTypeDAL(InspectionTypeDOL.QueryStatus.SelectComboBox);
            return _InspectionTypeDAL.SelectComboBox();
        }
    }
}
