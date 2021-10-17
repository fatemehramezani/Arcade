namespace BusinessObjectLayer
{
    public class SettingBOL
    {
        string key;
        public string Key
        {
            get { return key; }
            set { key = value; }
        }
        string value;
        public string Value
        {
            get { return value; }
            set { value = this.value; }
        }
        string description;
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public SettingBOL() { }
        public SettingBOL(string key, string value, string description)
        {
            this.key = key;
            this.value = value;
            this.description = description;
        }
        public SettingBOL(string Key)
        {
            this.key = Key;
        }
    }
}
