using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer
{
    using BusinessObjectLayer;
    using DataAccessLayer;
    using DataObjectLayer;

    public class LetterBLL
    {
        public LetterBOL[] Select()
        {
            LetterDAL _LetterDAL = new LetterDAL(LetterDOL.QueryStatus.Select);
            return _LetterDAL.Select();
        }
        public LetterBOL[] Select(LetterBOL _LetterBOL)
        {
            LetterDAL _LetterDAL = new LetterDAL(LetterDOL.QueryStatus.Select,_LetterBOL);
            return _LetterDAL.Select();
        }
        public void Insert(LetterBOL _LetterBOL)
        {
            LetterDAL _LetterDAL = new LetterDAL(LetterDOL.QueryStatus.Insert, _LetterBOL);
            _LetterDAL.Insert();
        }
        public void Update(LetterBOL _LetterBOL)
        {
            LetterDAL _LetterDAL = new LetterDAL(LetterDOL.QueryStatus.Update, _LetterBOL);
            _LetterDAL.Update();
        }
        public void Delete(LetterBOL _LetterBOL)
        {
            LetterDAL _LetterDAL = new LetterDAL(LetterDOL.QueryStatus.Delete, _LetterBOL);
            _LetterDAL.Delete();
        }
        public int? SelectMaxId()
        {
            LetterDAL _LetterDAL = new LetterDAL(LetterDOL.QueryStatus.SelectMaxId);
            return _LetterDAL.SelectMaxId();
        }
    }
}
