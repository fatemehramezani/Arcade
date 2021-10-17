using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogicLayer
{
    using BusinessObjectLayer;
    using DataAccessLayer;
    using DataObjectLayer;

    public class CheckBLL
    {
        public CheckBOL[] Select(CheckBOL _CheckBOL)
        {
            CheckDAL _CheckDAL = new CheckDAL(CheckDOL.QueryStatus.Select, _CheckBOL);
            return _CheckDAL.Select();
        }
        public void Insert(CheckBOL _CheckBOL)
        {
            CheckDAL _CheckDAL = new CheckDAL(CheckDOL.QueryStatus.Insert, _CheckBOL);
            _CheckDAL.Insert();
        }
        public void Update(CheckBOL _CheckBOL)
        {
            CheckDAL _CheckDAL = new CheckDAL(CheckDOL.QueryStatus.Update, _CheckBOL);
            _CheckDAL.Update();
        }
        public void Delete(CheckBOL _CheckBOL)
        {
            CheckDAL _CheckDAL = new CheckDAL(CheckDOL.QueryStatus.Delete, _CheckBOL);
            _CheckDAL.Delete();
        }
        public int? SelectMaxId()
        {
            CheckDAL _CheckDAL = new CheckDAL(CheckDOL.QueryStatus.SelectMaxId);
            return _CheckDAL.SelectMaxId();
        }
        //public CheckBOL[] SelectComboBox()
        //{
        //    CheckDAL _CheckDAL = new CheckDAL(CheckDOL.QueryStatus.SelectComboBox);
        //    return _CheckDAL.SelectComboBox();
        //}
    }
}
