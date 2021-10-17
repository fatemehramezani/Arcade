using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer
{
    using BusinessObjectLayer;
    using DataAccessLayer;
    using DataObjectLayer;

    public class HabitationBLL
    {
        public HabitationBOL[] Select()
        {
            HabitationDAL _HabitationDAL = new HabitationDAL(HabitationDOL.QueryStatus.Select);
            return _HabitationDAL.Select();
        }
        public void Insert(HabitationBOL _HabitationBOL)
        {
            HabitationDAL _HabitationDAL = new HabitationDAL(HabitationDOL.QueryStatus.Insert, _HabitationBOL);
            _HabitationDAL.Insert();
        }
        public void Update(HabitationBOL _HabitationBOL)
        {
            HabitationDAL _HabitationDAL = new HabitationDAL(HabitationDOL.QueryStatus.Update, _HabitationBOL);
            _HabitationDAL.Update();
        }
        public void Delete(HabitationBOL _HabitationBOL)
        {
            HabitationDAL _HabitationDAL = new HabitationDAL(HabitationDOL.QueryStatus.Delete, _HabitationBOL);
            _HabitationDAL.Delete();
        }
        public long? SelectMaxId()
        {
            HabitationDAL _HabitationDAL = new HabitationDAL(HabitationDOL.QueryStatus.SelectMaxId);
            return _HabitationDAL.SelectMaxId();
        }
        public HabitationBOL[] SelectComboBox()
        {
            HabitationDAL _HabitationDAL = new HabitationDAL(HabitationDOL.QueryStatus.SelectComboBox);
            return _HabitationDAL.SelectComboBox();
        }
    }
}
