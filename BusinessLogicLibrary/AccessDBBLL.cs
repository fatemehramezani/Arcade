using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogicLayer
{
    using BusinessObjectLayer;
    using DataAccessLayer;
    using DataObjectLayer;

    public class AccessDBBLL
    {
        public AccessDBBOL[] Select(AccessDBBOL _AccessDBBOL,string Path)
        {
            AccessDBDAL _AccessDBDAL = new AccessDBDAL(AccessDBDOL.QueryStatus.Select, _AccessDBBOL);
            return _AccessDBDAL.Select(Path);
        }
        public void Insert(AccessDBBOL _AccessDBBOL)
        {
            AccessDBDAL _AccessDBDAL = new AccessDBDAL(AccessDBDOL.QueryStatus.Insert, _AccessDBBOL);
            _AccessDBDAL.Insert();
        }
        public void Update(AccessDBBOL _AccessDBBOL)
        {
            AccessDBDAL _AccessDBDAL = new AccessDBDAL(AccessDBDOL.QueryStatus.Update, _AccessDBBOL);
            _AccessDBDAL.Update();
        }
        public void Delete(AccessDBBOL _AccessDBBOL)
        {
            AccessDBDAL _AccessDBDAL = new AccessDBDAL(AccessDBDOL.QueryStatus.Delete, _AccessDBBOL);
            _AccessDBDAL.Delete();
        }
        public int? SelectMaxId()
        {
            AccessDBDAL _AccessDBDAL = new AccessDBDAL(AccessDBDOL.QueryStatus.SelectMaxId);
            return _AccessDBDAL.SelectMaxId();
        }
        
    }
}
