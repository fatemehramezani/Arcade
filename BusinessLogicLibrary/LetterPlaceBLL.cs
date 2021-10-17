using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer
{
    using BusinessObjectLayer;
    using DataAccessLayer;
    using DataObjectLayer;

    public class LetterPlaceBLL
    {
        public LetterPlaceBOL[] Select()
        {
            LetterPlaceDAL _LetterPlaceDAL = new LetterPlaceDAL(LetterPlaceDOL.QueryStatus.Select);
            return _LetterPlaceDAL.Select();
        }
        public void Insert(LetterPlaceBOL _LetterPlaceBOL)
        {
            LetterPlaceDAL _LetterPlaceDAL = new LetterPlaceDAL(LetterPlaceDOL.QueryStatus.Insert, _LetterPlaceBOL);
            _LetterPlaceDAL.Insert();
        }
        public void Update(LetterPlaceBOL _LetterPlaceBOL)
        {
            LetterPlaceDAL _LetterPlaceDAL = new LetterPlaceDAL(LetterPlaceDOL.QueryStatus.Update, _LetterPlaceBOL);
            _LetterPlaceDAL.Update();
        }
        public void Delete(LetterPlaceBOL _LetterPlaceBOL)
        {
            LetterPlaceDAL _LetterPlaceDAL = new LetterPlaceDAL(LetterPlaceDOL.QueryStatus.Delete, _LetterPlaceBOL);
            _LetterPlaceDAL.Delete();
        }
        public long? SelectMaxId()
        {
            LetterPlaceDAL _LetterPlaceDAL = new LetterPlaceDAL(LetterPlaceDOL.QueryStatus.SelectMaxId);
            return _LetterPlaceDAL.SelectMaxId();
        }
        public LetterPlaceBOL[] SelectComboBox()
        {
            LetterPlaceDAL _LetterPlaceDAL = new LetterPlaceDAL(LetterPlaceDOL.QueryStatus.SelectComboBox);
            return _LetterPlaceDAL.SelectComboBox();
        }
    }
}
