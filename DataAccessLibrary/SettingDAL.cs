using System;
using System.Collections.Generic;
using BusinessObjectLayer;
using System.Xml;
using DataAccessObjectLayer;
using DataAccessLayer;

namespace DataAccessLibrary
{
    public class SettingDAL
    {
        private static SettingDOL.CommandStatus commandStatus;
        private static SettingBOL _SettingBOL;
        public SettingDAL(SettingDOL.CommandStatus CommandStatus)
        {
            commandStatus = CommandStatus;
        }
        public SettingDAL(SettingDOL.CommandStatus CommandStatus, SettingBOL settingBOL)
        {
            commandStatus = CommandStatus;
            _SettingBOL = settingBOL;
        }
        public SettingBOL[] Select()
        {
            XmlDocument XmlDoc = new XmlDocument();
            XmlDoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            foreach (XmlElement xmlElement in XmlDoc.DocumentElement)
                if (xmlElement.Name == "appSettings")
                {
                    SettingBOL[] SettingBOLs = new SettingBOL[xmlElement.ChildNodes.Count];
                    for (int i = 0; i < xmlElement.ChildNodes.Count; i++)
                    {
                        SettingBOLs[i] = new SettingBOL(xmlElement.ChildNodes[i].Attributes[0].Value, xmlElement.ChildNodes[i].Attributes[1].Value, null);
                    }
                    return SettingBOLs;
                }
            return null;
        }
        public string ReadKey()
        {
            return ServerDAL.GetStringValue(_SettingBOL.Value);
        }
        public void WriteKey()
        {
            XmlDocument XmlDoc = new XmlDocument();
            XmlDoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            foreach (XmlElement xmlElement in XmlDoc.DocumentElement)
                if (xmlElement.Name == "appSettings")
                {
                    for (int i = 0; i < xmlElement.ChildNodes.Count; i++)
                    {
                        if (xmlElement.ChildNodes[i].Attributes[0].Value == _SettingBOL.Key)
                        {
                            xmlElement.ChildNodes[i].Attributes[1].Value = _SettingBOL.Value;
                            XmlDoc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
                            return;
                        }
                    }
                }
        }
        public void WriteConnectionString()
        {
            XmlDocument XmlDoc = new XmlDocument();
            XmlDoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            foreach (XmlElement xmlElement in XmlDoc.DocumentElement)
                if (xmlElement.Name == "connectionStrings")
                {
                    if (xmlElement.FirstChild.Attributes[0].Value == _SettingBOL.Key)
                    {
                        xmlElement.FirstChild.Attributes[1].Value = _SettingBOL.Value;
                        XmlDoc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
                        return;
                    }
                }
        }
        public string ReadConnectionString()
        {
            XmlDocument XmlDoc = new XmlDocument();
            XmlDoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            foreach (XmlElement xmlElement in XmlDoc.DocumentElement)
                if (xmlElement.Name == "connectionStrings")
                {
                    if (xmlElement.FirstChild.Attributes[0].Value == _SettingBOL.Key)
                        return xmlElement.FirstChild.Attributes[1].Value;
                }
            return string.Empty;
        }
    }
}
