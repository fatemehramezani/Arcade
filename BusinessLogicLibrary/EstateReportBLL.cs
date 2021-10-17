using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace BusinessLogicLayer
{
    using BusinessObjectLayer;
    using DataAccessLayer;
    using DataObjectLayer;
    using System.Data;

    public class EstateReportBLL
    {
        public DataTable Select(EstateReportBOL _EstateReportBOL)
        {
            EstateReportDAL _EstateReportDAL = new EstateReportDAL(EstateReportDOL.QueryStatus.Select, _EstateReportBOL);
            return _EstateReportDAL.Select();
        }
        public void Insert(EstateReportBOL _EstateReportBOL)
        {
            EstateReportDAL _EstateReportDAL = new EstateReportDAL(EstateReportDOL.QueryStatus.Insert, _EstateReportBOL);
            _EstateReportDAL.Insert();
        }
        public void Update(EstateReportBOL _EstateReportBOL)
        {
            EstateReportDAL _EstateReportDAL = new EstateReportDAL(EstateReportDOL.QueryStatus.Update, _EstateReportBOL);
            _EstateReportDAL.Update();
        }
        public void Delete(EstateReportBOL _EstateReportBOL)
        {
            EstateReportDAL _EstateReportDAL = new EstateReportDAL(EstateReportDOL.QueryStatus.Delete, _EstateReportBOL);
            _EstateReportDAL.Delete();
        }
        public byte? SelectMaxId()
        {
            EstateReportDAL _EstateReportDAL = new EstateReportDAL(EstateReportDOL.QueryStatus.SelectMaxId);
            return _EstateReportDAL.SelectMaxId();
        }
        //public EstateReportBOL[] SelectComboBox()
        //{
        //    EstateReportDAL _EstateReportDAL = new EstateReportDAL(EstateReportDOL.QueryStatus.SelectComboBox);
        //    //return _EstateReportDAL.SelectComboBox();
        //}
    }
}
