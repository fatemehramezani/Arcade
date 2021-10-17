using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer
{
    using BusinessObjectLayer;
    using DataAccessLayer;
    using DataObjectLayer;

    public class InsuranceStatusBLL
    {
        public InsuranceStatusBOL[] Select()
        {
            InsuranceStatusDAL _InsuranceStatusDAL = new InsuranceStatusDAL(InsuranceStatusDOL.QueryStatus.Select);
            return _InsuranceStatusDAL.Select();
        }
        public void Insert(InsuranceStatusBOL _InsuranceStatusBOL)
        {
            InsuranceStatusDAL _InsuranceStatusDAL = new InsuranceStatusDAL(InsuranceStatusDOL.QueryStatus.Insert, _InsuranceStatusBOL);
            _InsuranceStatusDAL.Insert();
        }
        public void Update(InsuranceStatusBOL _InsuranceStatusBOL)
        {
            InsuranceStatusDAL _InsuranceStatusDAL = new InsuranceStatusDAL(InsuranceStatusDOL.QueryStatus.Update, _InsuranceStatusBOL);
            _InsuranceStatusDAL.Update();
        }
        public void Delete(InsuranceStatusBOL _InsuranceStatusBOL)
        {
            InsuranceStatusDAL _InsuranceStatusDAL = new InsuranceStatusDAL(InsuranceStatusDOL.QueryStatus.Delete, _InsuranceStatusBOL);
            _InsuranceStatusDAL.Delete();
        }
        public long? SelectMaxId()
        {
            InsuranceStatusDAL _InsuranceStatusDAL = new InsuranceStatusDAL(InsuranceStatusDOL.QueryStatus.SelectMaxId);
            return _InsuranceStatusDAL.SelectMaxId();
        }
        public InsuranceStatusBOL[] SelectComboBox()
        {
            InsuranceStatusDAL _InsuranceStatusDAL = new InsuranceStatusDAL(InsuranceStatusDOL.QueryStatus.SelectComboBox);
            return _InsuranceStatusDAL.SelectComboBox();
        }
    }
}
