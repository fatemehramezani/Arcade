using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer
{
    using BusinessObjectLayer;
    using DataAccessLayer;
    using DataObjectLayer;

    public class PurchaseLetterBLL 
    {
        public PurchaseLetterBOL[] Select()
        {
            PurchaseLetterDAL _PurchaseLetterDAL = new PurchaseLetterDAL(PurchaseLetterDOL.QueryStatus.Select);
            return _PurchaseLetterDAL.Select();
        }
        public PurchaseLetterBOL[] Select(PurchaseLetterBOL _PurchaseLetterBOL)
        {
            PurchaseLetterDAL _PurchaseLetterDAL = new PurchaseLetterDAL(PurchaseLetterDOL.QueryStatus.Select, _PurchaseLetterBOL);
            return _PurchaseLetterDAL.Select();
        }
        public void Insert(PurchaseLetterBOL _PurchaseLetterBOL)
        {
            PurchaseLetterDAL _PurchaseLetterDAL = new PurchaseLetterDAL(PurchaseLetterDOL.QueryStatus.Insert, _PurchaseLetterBOL);
            _PurchaseLetterDAL.Insert();
        }
        public void Update(PurchaseLetterBOL _PurchaseLetterBOL)
        {
            PurchaseLetterDAL _PurchaseLetterDAL = new PurchaseLetterDAL(PurchaseLetterDOL.QueryStatus.Update, _PurchaseLetterBOL);
            _PurchaseLetterDAL.Update();
        }
        public void Delete(PurchaseLetterBOL _PurchaseLetterBOL)
        {
            PurchaseLetterDAL _PurchaseLetterDAL = new PurchaseLetterDAL(PurchaseLetterDOL.QueryStatus.Delete, _PurchaseLetterBOL);
            _PurchaseLetterDAL.Delete();
        }
        public int? SelectMaxId()
        {
            PurchaseLetterDAL _PurchaseLetterDAL = new PurchaseLetterDAL(PurchaseLetterDOL.QueryStatus.SelectMaxId);
            return _PurchaseLetterDAL.SelectMaxId();
        }
    }
}
