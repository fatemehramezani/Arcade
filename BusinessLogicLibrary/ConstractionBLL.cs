using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogicLayer
{
    using BusinessObjectLayer;
    using DataAccessLayer;
    using DataObjectLayer;

    public class ConstractionBLL
    { 
        public ConstractionBOL[] Select(ConstractionBOL _ConstractionBOL)
        {
            ConstractionDAL _ConstractionDAL = new ConstractionDAL(ConstractionDOL.QueryStatus.Select, _ConstractionBOL);
            return _ConstractionDAL.Select();
        }
        public void Insert(ConstractionBOL _ConstractionBOL)
        {
            ConstractionDAL _ConstractionDAL = new ConstractionDAL(ConstractionDOL.QueryStatus.Insert, _ConstractionBOL);
            _ConstractionDAL.Insert();
        }
        public void Update(ConstractionBOL _ConstractionBOL)
        {
            ConstractionDAL _ConstractionDAL = new ConstractionDAL(ConstractionDOL.QueryStatus.Update, _ConstractionBOL);
            _ConstractionDAL.Update();
        }
        public void Delete(ConstractionBOL _ConstractionBOL)
        {
            ConstractionDAL _ConstractionDAL = new ConstractionDAL(ConstractionDOL.QueryStatus.Delete, _ConstractionBOL);
            _ConstractionDAL.Delete();
        }
        public int? SelectMaxId()
        {
            ConstractionDAL _ConstractionDAL = new ConstractionDAL(ConstractionDOL.QueryStatus.SelectMaxId);
            return _ConstractionDAL.SelectMaxId();
        }
        public ConstractionBOL[] SelectComboBox()
        {
            ConstractionDAL _ConstractionDAL = new ConstractionDAL(ConstractionDOL.QueryStatus.SelectComboBox);
            return _ConstractionDAL.SelectComboBox();
        }
    }
}
