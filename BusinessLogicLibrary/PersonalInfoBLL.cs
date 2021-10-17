using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer
{
    using BusinessObjectLayer;
    using DataAccessLayer;
    using DataObjectLayer;
    using System.Data;

    public class PersonalInfoBLL
    {
        public PersonalInfoBOL[] Select()
        {
            PersonalInfoDAL _PersonalInfoDAL = new PersonalInfoDAL(PersonalInfoDOL.QueryStatus.Select);
            return _PersonalInfoDAL.Select();
        }
        public PersonalInfoBOL[] Select(PersonalInfoBOL _PersonalInfoBOL)
        {
            PersonalInfoDAL _PersonalInfoDAL = new PersonalInfoDAL(PersonalInfoDOL.QueryStatus.Select, _PersonalInfoBOL);
            return _PersonalInfoDAL.Select();
        }

        public PersonalInfoBOL[] SelectLandlord()
        {
            PersonalInfoDAL _PersonalInfoDAL = new PersonalInfoDAL(PersonalInfoDOL.QueryStatus.SelectLandlord);
            return _PersonalInfoDAL.SelectLandlord();
        }
        public PersonalInfoBOL[] SelectLandlord(PersonalInfoBOL _PersonalInfoBOL)
        {
            PersonalInfoDAL _PersonalInfoDAL = new PersonalInfoDAL(PersonalInfoDOL.QueryStatus.SelectLandlord, _PersonalInfoBOL);
            return _PersonalInfoDAL.SelectLandlord();
        }
        
        public void Insert(PersonalInfoBOL _PersonalInfoBOL)
        {
            PersonalInfoDAL _PersonalInfoDAL = new PersonalInfoDAL(PersonalInfoDOL.QueryStatus.Insert, _PersonalInfoBOL);
            _PersonalInfoDAL.Insert();
        }
        public void Update(PersonalInfoBOL _PersonalInfoBOL)
        {
            PersonalInfoDAL _PersonalInfoDAL = new PersonalInfoDAL(PersonalInfoDOL.QueryStatus.Update, _PersonalInfoBOL);
            _PersonalInfoDAL.Update();
        }
        public void Delete(PersonalInfoBOL _PersonalInfoBOL)
        {
            PersonalInfoDAL _PersonalInfoDAL = new PersonalInfoDAL(PersonalInfoDOL.QueryStatus.Delete, _PersonalInfoBOL);
            _PersonalInfoDAL.Delete();
        }
        public int? SelectMaxId()
        {
            PersonalInfoDAL _PersonalInfoDAL = new PersonalInfoDAL(PersonalInfoDOL.QueryStatus.SelectMaxId);
            return _PersonalInfoDAL.SelectMaxId();
        }
        public DataTable SelectReport()
        {
            PersonalInfoDAL _PersonalInfoDAL = new PersonalInfoDAL(PersonalInfoDOL.QueryStatus.SelectReport);
            return _PersonalInfoDAL.SelectReport();
        }
    }
}
