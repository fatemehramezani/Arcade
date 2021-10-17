using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogicLayer
{
    using BusinessObjectLayer;
    using DataAccessLayer;
    using DataObjectLayer;

    public class RoleTypeBLL
    {
        public RoleTypeBOL[] Select(RoleTypeBOL _RoleTypeBOL)
        {
            RoleTypeDAL _RoleTypeDAL = new RoleTypeDAL(RoleTypeDOL.QueryStatus.Select, _RoleTypeBOL);
            return _RoleTypeDAL.Select();
        }
        public void Insert(RoleTypeBOL _RoleTypeBOL)
        {
            RoleTypeDAL _RoleTypeDAL = new RoleTypeDAL(RoleTypeDOL.QueryStatus.Insert, _RoleTypeBOL);
            _RoleTypeDAL.Insert();
        }
        public void Update(RoleTypeBOL _RoleTypeBOL)
        {
            RoleTypeDAL _RoleTypeDAL = new RoleTypeDAL(RoleTypeDOL.QueryStatus.Update, _RoleTypeBOL);
            _RoleTypeDAL.Update();
        }
        public void Delete(RoleTypeBOL _RoleTypeBOL)
        {
            RoleTypeDAL _RoleTypeDAL = new RoleTypeDAL(RoleTypeDOL.QueryStatus.Delete, _RoleTypeBOL);
            _RoleTypeDAL.Delete();
        }
        public byte? SelectMaxId()
        {
            RoleTypeDAL _RoleTypeDAL = new RoleTypeDAL(RoleTypeDOL.QueryStatus.SelectMaxId);
            return _RoleTypeDAL.SelectMaxId();
        }
        public RoleTypeBOL[] SelectComboBox()
        {
            RoleTypeDAL _RoleTypeDAL = new RoleTypeDAL(RoleTypeDOL.QueryStatus.SelectComboBox);
            return _RoleTypeDAL.SelectComboBox();
        }
    }
}
