using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer
{
    using BusinessObjectLayer;
    using DataAccessLayer;
    using DataObjectLayer;

    public class OutPutBLL
    {
        public OutPutBOL[] Select()
        {
            OutPutDAL _OutPutDAL = new OutPutDAL(OutPutDOL.QueryStatus.Select);
            return _OutPutDAL.Select();
        }
        public OutPutBOL[] Select(OutPutBOL _OutPutBOL)
        {
            OutPutDAL _OutPutDAL = new OutPutDAL(OutPutDOL.QueryStatus.Select, _OutPutBOL);
            return _OutPutDAL.Select();
        }
        public void Insert(OutPutBOL _OutPutBOL)
        {
            OutPutDAL _OutPutDAL = new OutPutDAL(OutPutDOL.QueryStatus.Insert, _OutPutBOL);
            _OutPutDAL.Insert();
        }
        public void Update(OutPutBOL _OutPutBOL)
        {
            OutPutDAL _OutPutDAL = new OutPutDAL(OutPutDOL.QueryStatus.Update, _OutPutBOL);
            _OutPutDAL.Update();
        }
        public void Delete(OutPutBOL _OutPutBOL)
        {
            OutPutDAL _OutPutDAL = new OutPutDAL(OutPutDOL.QueryStatus.Delete, _OutPutBOL);
            _OutPutDAL.Delete();
        }
        public int? SelectMaxId()
        {
            OutPutDAL _OutPutDAL = new OutPutDAL(OutPutDOL.QueryStatus.SelectMaxId);
            return _OutPutDAL.SelectMaxId();
        }
        
    }
}
