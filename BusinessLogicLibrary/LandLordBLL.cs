using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogicLayer
{
    using BusinessObjectLayer;
    using DataAccessLayer;
    using DataObjectLayer;

    public class LandLordBLL
    {
        public LandLordBOL[] Select(LandLordBOL _LandLordBOL)
        {
            LandLordDAL _LandLordDAL = new LandLordDAL(LandLordDOL.QueryStatus.Select, _LandLordBOL);
            return _LandLordDAL.Select();
        }
        public void Insert(LandLordBOL _LandLordBOL)
        {
            LandLordDAL _LandLordDAL = new LandLordDAL(LandLordDOL.QueryStatus.Insert, _LandLordBOL);
            _LandLordDAL.Insert();
        }
        public void Update(LandLordBOL _LandLordBOL)
        {
            LandLordDAL _LandLordDAL = new LandLordDAL(LandLordDOL.QueryStatus.Update, _LandLordBOL);
            _LandLordDAL.Update();
        }
        public void Delete(LandLordBOL _LandLordBOL)
        {
            LandLordDAL _LandLordDAL = new LandLordDAL(LandLordDOL.QueryStatus.Delete, _LandLordBOL);
            _LandLordDAL.Delete();
        }
        public byte? SelectMaxId()
        {
            LandLordDAL _LandLordDAL = new LandLordDAL(LandLordDOL.QueryStatus.SelectMaxId);
            return _LandLordDAL.SelectMaxId();
        }
   
    }
}
