using System;
using System.Collections.Generic;
namespace BusinessLogicLibrary
{
    using BusinessObjectLayer;
    using DataAccessLibrary;
    using DataAccessObjectLayer;

    public class SettingBLL
    {
        public SettingBOL[] Select()
        {
            SettingDAL _SettingDAL = new SettingDAL(SettingDOL.CommandStatus.Select);
            return _SettingDAL.Select();
        }
        public string ReadKey(SettingBOL _SettingBOL)
        {
            SettingDAL _SettingDAL = new SettingDAL(SettingDOL.CommandStatus.ReadKey, _SettingBOL);
            return _SettingDAL.ReadKey();
        }
        public void WriteKey(SettingBOL _SettingBOL)
        {
            SettingDAL _SettingDAL = new SettingDAL(SettingDOL.CommandStatus.WriteKey, _SettingBOL);
            _SettingDAL.WriteKey();
        }
    }
}
