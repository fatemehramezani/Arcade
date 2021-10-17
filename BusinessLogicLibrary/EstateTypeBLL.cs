using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogicLayer
{
    using BusinessObjectLayer;
    using DataAccessLayer;
    using DataObjectLayer;

    public class EstateTypeBLL
    {
        public EstateTypeBOL[] Select(EstateTypeBOL _EstateTypeBOL)
        {
            EstateTypeDAL _EstateTypeDAL = new EstateTypeDAL(EstateTypeDOL.QueryStatus.Select, _EstateTypeBOL);
            return _EstateTypeDAL.Select();
        }
        public void Insert(EstateTypeBOL _EstateTypeBOL)
        {
            EstateTypeDAL _EstateTypeDAL = new EstateTypeDAL(EstateTypeDOL.QueryStatus.Insert, _EstateTypeBOL);
            _EstateTypeDAL.Insert();
        }
        public void Update(EstateTypeBOL _EstateTypeBOL)
        {
            EstateTypeDAL _EstateTypeDAL = new EstateTypeDAL(EstateTypeDOL.QueryStatus.Update, _EstateTypeBOL);
            _EstateTypeDAL.Update();
        }
        public void Delete(EstateTypeBOL _EstateTypeBOL)
        {
            EstateTypeDAL _EstateTypeDAL = new EstateTypeDAL(EstateTypeDOL.QueryStatus.Delete, _EstateTypeBOL);
            _EstateTypeDAL.Delete();
        }
        public byte? SelectMaxId()
        {
            EstateTypeDAL _EstateTypeDAL = new EstateTypeDAL(EstateTypeDOL.QueryStatus.SelectMaxId);
            return _EstateTypeDAL.SelectMaxId();
        }
        public EstateTypeBOL[] SelectComboBox()
        {
            EstateTypeDAL _EstateTypeDAL = new EstateTypeDAL(EstateTypeDOL.QueryStatus.SelectComboBox);
            return _EstateTypeDAL.SelectComboBox();
        }
    }
}
