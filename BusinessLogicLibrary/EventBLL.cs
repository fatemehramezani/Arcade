using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogicLayer
{
    using BusinessObjectLayer;
    using DataAccessLayer;
    using DataObjectLayer;

    public class EventBLL
    {
        public EventBOL[] Select(EventBOL _EventBOL)
        {
            EventDAL _EventDAL = new EventDAL(EventDOL.QueryStatus.Select, _EventBOL);
            return _EventDAL.Select();
        }
        public void Insert(EventBOL _EventBOL)
        {
            EventDAL _EventDAL = new EventDAL(EventDOL.QueryStatus.Insert, _EventBOL);
            _EventDAL.Insert();
        }
        public void Update(EventBOL _EventBOL)
        {
            EventDAL _EventDAL = new EventDAL(EventDOL.QueryStatus.Update, _EventBOL);
            _EventDAL.Update();
        }
        public void Delete(EventBOL _EventBOL)
        {
            EventDAL _EventDAL = new EventDAL(EventDOL.QueryStatus.Delete, _EventBOL);
            _EventDAL.Delete();
        }
        public byte? SelectMaxId()
        {
            EventDAL _EventDAL = new EventDAL(EventDOL.QueryStatus.SelectMaxId);
            return _EventDAL.SelectMaxId();
        }
        public EventBOL[] SelectComboBox()
        {
            EventDAL _EventDAL = new EventDAL(EventDOL.QueryStatus.SelectComboBox);
            return _EventDAL.SelectComboBox();
        }
    }
}
