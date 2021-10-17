using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer
{
    using BusinessObjectLayer;
    using DataAccessLayer;
    using DataObjectLayer;

    public class PersonalRoleBLL
    {
        public PersonalRoleBOL[] Select()
        {
            PersonalRoleDAL _PersonalRoleDAL = new PersonalRoleDAL(PersonalRoleDOL.QueryStatus.Select);
            return _PersonalRoleDAL.Select();
        }
        public PersonalRoleBOL[] Select(PersonalRoleBOL _PersonalRoleBOL)
        {
            PersonalRoleDAL _PersonalRoleDAL = new PersonalRoleDAL(PersonalRoleDOL.QueryStatus.Select,_PersonalRoleBOL);
            return _PersonalRoleDAL.Select();
        }
        public void Insert(PersonalRoleBOL _PersonalRoleBOL)
        {
            PersonalRoleDAL _PersonalRoleDAL = new PersonalRoleDAL(PersonalRoleDOL.QueryStatus.Insert, _PersonalRoleBOL);
            _PersonalRoleDAL.Insert();
        }
        public void Update(PersonalRoleBOL _PersonalRoleBOL)
        {
            PersonalRoleDAL _PersonalRoleDAL = new PersonalRoleDAL(PersonalRoleDOL.QueryStatus.Update, _PersonalRoleBOL);
            _PersonalRoleDAL.Update();
        }
        public void Delete(PersonalRoleBOL _PersonalRoleBOL)
        {
            PersonalRoleDAL _PersonalRoleDAL = new PersonalRoleDAL(PersonalRoleDOL.QueryStatus.Delete, _PersonalRoleBOL);
            _PersonalRoleDAL.Delete();
        }
        public byte? SelectMaxId()
        {
            PersonalRoleDAL _PersonalRoleDAL = new PersonalRoleDAL(PersonalRoleDOL.QueryStatus.SelectMaxId);
            return _PersonalRoleDAL.SelectMaxId();
        }


        
    }
}
