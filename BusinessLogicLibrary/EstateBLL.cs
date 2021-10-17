using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogicLayer
{
    using BusinessObjectLayer;
    using DataAccessLayer;
    using DataObjectLayer;

    public class EstateBLL
    {
        public EstateBOL[] Select(EstateBOL _EstateBOL)
        {
            EstateDAL _EstateDAL = new EstateDAL(EstateDOL.QueryStatus.Select, _EstateBOL);
            return _EstateDAL.Select();
        }
        public void Insert(EstateBOL _EstateBOL)
        {
            EstateDAL _EstateDAL = new EstateDAL(EstateDOL.QueryStatus.Insert, _EstateBOL);
            _EstateDAL.Insert();
        }
        public void Update(EstateBOL _EstateBOL)
        {
            EstateDAL _EstateDAL = new EstateDAL(EstateDOL.QueryStatus.Update, _EstateBOL);
            _EstateDAL.Update();
        }
        public void Delete(EstateBOL _EstateBOL)
        {
            EstateDAL _EstateDAL = new EstateDAL(EstateDOL.QueryStatus.Delete, _EstateBOL);
            _EstateDAL.Delete();
        }
        public byte? SelectMaxId()
        {
            EstateDAL _EstateDAL = new EstateDAL(EstateDOL.QueryStatus.SelectMaxId);
            return _EstateDAL.SelectMaxId();
        }
        public EstateBOL[] SelectComboBox()
        {
            EstateDAL _EstateDAL = new EstateDAL(EstateDOL.QueryStatus.SelectComboBox);
            return _EstateDAL.SelectComboBox();
        }
        public EstateBOL[] SelectComboBoxLandLord(int? PersonalInfoId)
        {
            EstateDAL _EstateDAL = new EstateDAL(EstateDOL.QueryStatus.SelectComboBoxLandLord);
            return _EstateDAL.SelectComboBoxLandLord(PersonalInfoId);
        }
    }
}
