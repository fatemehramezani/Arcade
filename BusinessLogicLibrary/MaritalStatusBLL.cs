using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogicLayer
{
    using BusinessObjectLayer;
    using DataAccessLayer;
    using DataObjectLayer;

    public class MaritalStatusBLL
    {
        public MaritalStatusBOL[] Select(MaritalStatusBOL _MaritalStatusBOL)
        {
            MaritalStatusDAL _MaritalStatusDAL = new MaritalStatusDAL(MaritalStatusDOL.QueryStatus.Select, _MaritalStatusBOL);
            return _MaritalStatusDAL.Select();
        }
        public void Insert(MaritalStatusBOL _MaritalStatusBOL)
        {
            MaritalStatusDAL _MaritalStatusDAL = new MaritalStatusDAL(MaritalStatusDOL.QueryStatus.Insert, _MaritalStatusBOL);
            _MaritalStatusDAL.Insert();
        }
        public void Update(MaritalStatusBOL _MaritalStatusBOL)
        {
            MaritalStatusDAL _MaritalStatusDAL = new MaritalStatusDAL(MaritalStatusDOL.QueryStatus.Update, _MaritalStatusBOL);
            _MaritalStatusDAL.Update();
        }
        public void Delete(MaritalStatusBOL _MaritalStatusBOL)
        {
            MaritalStatusDAL _MaritalStatusDAL = new MaritalStatusDAL(MaritalStatusDOL.QueryStatus.Delete, _MaritalStatusBOL);
            _MaritalStatusDAL.Delete();
        }
        public byte? SelectMaxId()
        {
            MaritalStatusDAL _MaritalStatusDAL = new MaritalStatusDAL(MaritalStatusDOL.QueryStatus.SelectMaxId);
            return _MaritalStatusDAL.SelectMaxId();
        }
        public MaritalStatusBOL[] SelectComboBox()
        {
            MaritalStatusDAL _MaritalStatusDAL = new MaritalStatusDAL(MaritalStatusDOL.QueryStatus.SelectComboBox);
            return _MaritalStatusDAL.SelectComboBox();
        }
    }
}
