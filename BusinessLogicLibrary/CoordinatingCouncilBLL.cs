using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer
{
    using BusinessObjectLayer;
    using DataAccessLayer;
    using DataObjectLayer;

    public class CoordinatingCouncilBLL
    {
        public CoordinatingCouncilBOL[] Select()
        {
            CoordinatingCouncilDAL _CoordinatingCouncilDAL = new CoordinatingCouncilDAL(CoordinatingCouncilDOL.QueryStatus.Select);
            return _CoordinatingCouncilDAL.Select();
        }
        public CoordinatingCouncilBOL[] Select(CoordinatingCouncilBOL _CoordinatingCouncilBOL)
        {
            CoordinatingCouncilDAL _CoordinatingCouncilDAL = new CoordinatingCouncilDAL(CoordinatingCouncilDOL.QueryStatus.Select,_CoordinatingCouncilBOL);
            return _CoordinatingCouncilDAL.Select();
        }
        public void Insert(CoordinatingCouncilBOL _CoordinatingCouncilBOL)
        {
            CoordinatingCouncilDAL _CoordinatingCouncilDAL = new CoordinatingCouncilDAL(CoordinatingCouncilDOL.QueryStatus.Insert, _CoordinatingCouncilBOL);
            _CoordinatingCouncilDAL.Insert();
        }
        public void Update(CoordinatingCouncilBOL _CoordinatingCouncilBOL)
        {
            CoordinatingCouncilDAL _CoordinatingCouncilDAL = new CoordinatingCouncilDAL(CoordinatingCouncilDOL.QueryStatus.Update, _CoordinatingCouncilBOL);
            _CoordinatingCouncilDAL.Update();
        }
        public void Delete(CoordinatingCouncilBOL _CoordinatingCouncilBOL)
        {
            CoordinatingCouncilDAL _CoordinatingCouncilDAL = new CoordinatingCouncilDAL(CoordinatingCouncilDOL.QueryStatus.Delete, _CoordinatingCouncilBOL);
            _CoordinatingCouncilDAL.Delete();
        }
        public int? SelectMaxId()
        {
            CoordinatingCouncilDAL _CoordinatingCouncilDAL = new CoordinatingCouncilDAL(CoordinatingCouncilDOL.QueryStatus.SelectMaxId);
            return _CoordinatingCouncilDAL.SelectMaxId();
        }
    }
}
