using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogicLayer
{
    using BusinessObjectLayer;
    using DataAccessLayer;
    using DataObjectLayer;

    public class MilitaryStatusBLL
    {
        public MilitaryStatusBOL[] Select(MilitaryStatusBOL _MilitaryStatusBOL)
        {
            MilitaryStatusDAL _MilitaryStatusDAL = new MilitaryStatusDAL(MilitaryStatusDOL.QueryStatus.Select, _MilitaryStatusBOL);
            return _MilitaryStatusDAL.Select();
        }
        public void Insert(MilitaryStatusBOL _MilitaryStatusBOL)
        {
            MilitaryStatusDAL _MilitaryStatusDAL = new MilitaryStatusDAL(MilitaryStatusDOL.QueryStatus.Insert, _MilitaryStatusBOL);
            _MilitaryStatusDAL.Insert();
        }
        public void Update(MilitaryStatusBOL _MilitaryStatusBOL)
        {
            MilitaryStatusDAL _MilitaryStatusDAL = new MilitaryStatusDAL(MilitaryStatusDOL.QueryStatus.Update, _MilitaryStatusBOL);
            _MilitaryStatusDAL.Update();
        }
        public void Delete(MilitaryStatusBOL _MilitaryStatusBOL)
        {
            MilitaryStatusDAL _MilitaryStatusDAL = new MilitaryStatusDAL(MilitaryStatusDOL.QueryStatus.Delete, _MilitaryStatusBOL);
            _MilitaryStatusDAL.Delete();
        }
        public byte? SelectMaxId()
        {
            MilitaryStatusDAL _MilitaryStatusDAL = new MilitaryStatusDAL(MilitaryStatusDOL.QueryStatus.SelectMaxId);
            return _MilitaryStatusDAL.SelectMaxId();
        }
        public MilitaryStatusBOL[] SelectComboBox()
        {
            MilitaryStatusDAL _MilitaryStatusDAL = new MilitaryStatusDAL(MilitaryStatusDOL.QueryStatus.SelectComboBox);
            return _MilitaryStatusDAL.SelectComboBox();
        }
    }
}
