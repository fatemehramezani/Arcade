using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer
{
    using BusinessObjectLayer;
    using DataAccessLayer;
    using DataObjectLayer;

    public class LeaseBLL 
    {
        public LeaseBOL[] Select()
        {
            LeaseDAL _LeaseDAL = new LeaseDAL(LeaseDOL.QueryStatus.Select);
            return _LeaseDAL.Select();
        }
        public LeaseBOL[] Select(LeaseBOL _LeaseBOL)
        {
            LeaseDAL _LeaseDAL = new LeaseDAL(LeaseDOL.QueryStatus.Select, _LeaseBOL);
            return _LeaseDAL.Select();
        }
        public void Insert(LeaseBOL _LeaseBOL)
        {
            LeaseDAL _LeaseDAL = new LeaseDAL(LeaseDOL.QueryStatus.Insert, _LeaseBOL);
            _LeaseDAL.Insert();
        }
        public void Update(LeaseBOL _LeaseBOL)
        {
            LeaseDAL _LeaseDAL = new LeaseDAL(LeaseDOL.QueryStatus.Update, _LeaseBOL);
            _LeaseDAL.Update();
        }
        public void Delete(LeaseBOL _LeaseBOL)
        {
            LeaseDAL _LeaseDAL = new LeaseDAL(LeaseDOL.QueryStatus.Delete, _LeaseBOL);
            _LeaseDAL.Delete();
        }
        public int? SelectMaxId()
        {
            LeaseDAL _LeaseDAL = new LeaseDAL(LeaseDOL.QueryStatus.SelectMaxId);
            return _LeaseDAL.SelectMaxId();
        }
    }
}
