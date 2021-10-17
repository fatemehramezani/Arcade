using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer
{
    using BusinessObjectLayer;
    using DataAccessLayer;
    using DataObjectLayer;

    public class DegreeBLL
    {
        public DegreeBOL[] Select()
        {
            DegreeDAL _DegreeDAL = new DegreeDAL(DegreeDOL.QueryStatus.Select);
            return _DegreeDAL.Select();
        }
        public void Insert(DegreeBOL _DegreeBOL)
        {
            DegreeDAL _DegreeDAL = new DegreeDAL(DegreeDOL.QueryStatus.Insert, _DegreeBOL);
            _DegreeDAL.Insert();
        }
        public void Update(DegreeBOL _DegreeBOL)
        {
            DegreeDAL _DegreeDAL = new DegreeDAL(DegreeDOL.QueryStatus.Update, _DegreeBOL);
            _DegreeDAL.Update();
        }
        public void Delete(DegreeBOL _DegreeBOL)
        {
            DegreeDAL _DegreeDAL = new DegreeDAL(DegreeDOL.QueryStatus.Delete, _DegreeBOL);
            _DegreeDAL.Delete();
        }
        public long? SelectMaxId()
        {
            DegreeDAL _DegreeDAL = new DegreeDAL(DegreeDOL.QueryStatus.SelectMaxId);
            return _DegreeDAL.SelectMaxId();
        }
        public DegreeBOL[] SelectComboBox()
        {
            DegreeDAL _DegreeDAL = new DegreeDAL(DegreeDOL.QueryStatus.SelectComboBox);
            return _DegreeDAL.SelectComboBox();
        }
    }
}
