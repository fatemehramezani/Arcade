using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer
{
    using BusinessObjectLayer;
    using DataAccessLayer;
    using DataObjectLayer;

    public class InputBLL
    {
        public InputBOL[] Select()
        {
            InputDAL _InputDAL = new InputDAL(InputDOL.QueryStatus.Select);
            return _InputDAL.Select();
        }
        public InputBOL[] Select(InputBOL _InputBOL)
        {
            InputDAL _InputDAL = new InputDAL(InputDOL.QueryStatus.Select, _InputBOL);
            return _InputDAL.Select();
        }
        public void Insert(InputBOL _InputBOL)
        {
            InputDAL _InputDAL = new InputDAL(InputDOL.QueryStatus.Insert, _InputBOL);
            _InputDAL.Insert();
        }
        public void Update(InputBOL _InputBOL)
        {
            InputDAL _InputDAL = new InputDAL(InputDOL.QueryStatus.Update, _InputBOL);
            _InputDAL.Update();
        }
        public void Delete(InputBOL _InputBOL)
        {
            InputDAL _InputDAL = new InputDAL(InputDOL.QueryStatus.Delete, _InputBOL);
            _InputDAL.Delete();
        }
        public int? SelectMaxId()
        {
            InputDAL _InputDAL = new InputDAL(InputDOL.QueryStatus.SelectMaxId);
            return _InputDAL.SelectMaxId();
        }
        
    }
}
