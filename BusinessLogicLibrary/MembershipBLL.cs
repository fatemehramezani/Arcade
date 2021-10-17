using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer
{
    using BusinessObjectLayer;
    using DataAccessLayer;
    using DataObjectLayer;

    public class MembershipBLL
    {
        public MembershipBOL[] Select()
        {
            MembershipDAL _MembershipDAL = new MembershipDAL(MembershipDOL.QueryStatus.Select);
            return _MembershipDAL.Select();
        }
        public MembershipBOL[] Select(MembershipBOL _MembershipBOL)
        {
            MembershipDAL _MembershipDAL = new MembershipDAL(MembershipDOL.QueryStatus.Select, _MembershipBOL);
            return _MembershipDAL.Select();
        }
        public void Insert(MembershipBOL _MembershipBOL)
        {
            MembershipDAL _MembershipDAL = new MembershipDAL(MembershipDOL.QueryStatus.Insert, _MembershipBOL);
            _MembershipDAL.Insert();
        }
        public void Update(MembershipBOL _MembershipBOL)
        {
            MembershipDAL _MembershipDAL = new MembershipDAL(MembershipDOL.QueryStatus.Update, _MembershipBOL);
            _MembershipDAL.Update();
        }
        public void Delete(MembershipBOL _MembershipBOL)
        {
            MembershipDAL _MembershipDAL = new MembershipDAL(MembershipDOL.QueryStatus.Delete, _MembershipBOL);
            _MembershipDAL.Delete();
        }
        public int? SelectMaxId()
        {
            MembershipDAL _MembershipDAL = new MembershipDAL(MembershipDOL.QueryStatus.SelectMaxId);
            return _MembershipDAL.SelectMaxId();
        }
    }
}
