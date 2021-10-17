using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer
{
    using BusinessObjectLayer;
    using DataAccessLayer;
    using DataObjectLayer;

    public class AddressBLL
    {
        public AddressBOL[] Select()
        {
            AddressDAL _AddressDAL = new AddressDAL(AddressDOL.QueryStatus.Select);
            return _AddressDAL.Select();
        }
        public AddressBOL[] Select(AddressBOL _AddressBOL)
        {
            AddressDAL _AddressDAL = new AddressDAL(AddressDOL.QueryStatus.Select,_AddressBOL);
            return _AddressDAL.Select();
        }
        public void Insert(AddressBOL _AddressBOL)
        {
            AddressDAL _AddressDAL = new AddressDAL(AddressDOL.QueryStatus.Insert, _AddressBOL);
            _AddressDAL.Insert();
        }
        public void Update(AddressBOL _AddressBOL)
        {
            AddressDAL _AddressDAL = new AddressDAL(AddressDOL.QueryStatus.Update, _AddressBOL);
            _AddressDAL.Update();
        }
        public void Delete(AddressBOL _AddressBOL)
        {
            AddressDAL _AddressDAL = new AddressDAL(AddressDOL.QueryStatus.Delete, _AddressBOL);
            _AddressDAL.Delete();
        }
        public int? SelectMaxId()
        {
            AddressDAL _AddressDAL = new AddressDAL(AddressDOL.QueryStatus.SelectMaxId);
            return _AddressDAL.SelectMaxId();
        }
    }
}
