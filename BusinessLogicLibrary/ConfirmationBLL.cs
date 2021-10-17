using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer
{
    using BusinessObjectLayer;
    using DataAccessLayer;
    using DataObjectLayer;

    public class ConfirmationBLL
    {
        public ConfirmationBOL[] Select()
        {
            ConfirmationDAL _ConfirmationDAL = new ConfirmationDAL(ConfirmationDOL.QueryStatus.Select);
            return _ConfirmationDAL.Select();
        }
        public void Insert(ConfirmationBOL _ConfirmationBOL)
        {
            ConfirmationDAL _ConfirmationDAL = new ConfirmationDAL(ConfirmationDOL.QueryStatus.Insert, _ConfirmationBOL);
            _ConfirmationDAL.Insert();
        }
        public void Update(ConfirmationBOL _ConfirmationBOL)
        {
            ConfirmationDAL _ConfirmationDAL = new ConfirmationDAL(ConfirmationDOL.QueryStatus.Update, _ConfirmationBOL);
            _ConfirmationDAL.Update();
        }
        public void Delete(ConfirmationBOL _ConfirmationBOL)
        {
            ConfirmationDAL _ConfirmationDAL = new ConfirmationDAL(ConfirmationDOL.QueryStatus.Delete, _ConfirmationBOL);
            _ConfirmationDAL.Delete();
        }
        public long? SelectMaxId()
        {
            ConfirmationDAL _ConfirmationDAL = new ConfirmationDAL(ConfirmationDOL.QueryStatus.SelectMaxId);
            return _ConfirmationDAL.SelectMaxId();
        }
        public ConfirmationBOL[] SelectComboBox()
        {
            ConfirmationDAL _ConfirmationDAL = new ConfirmationDAL(ConfirmationDOL.QueryStatus.SelectComboBox);
            return _ConfirmationDAL.SelectComboBox();
        }
    }
}
