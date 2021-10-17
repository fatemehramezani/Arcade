namespace DataObjectLayer
{
    public class UserDOL
    {
        public const string Select = @"SELECT [USER].USERID, [USER].USERNAME, [USER].PASSWORD, [USER].DESCRIPTION FROM [USER]";
        public const string Insert = @"INSERT INTO [USER] ( USERID,USERNAME, PASSWORD, DESCRIPTION) VALUES(@USERID,@USERNAME, @PASSWORD, @DESCRIPTION)";
        public const string Delete = "DELETE FROM [USER] WHERE USERID=@USERID";
        public const string Update = "UPDATE [USER] SET USERNAME = @USERNAME, PASSWORD = @PASSWORD, DESCRIPTION = @DESCRIPTION WHERE USERID=@USERID";
        public const string CheckUserValid = @"SELECT COUNT(*) FROM [USER] WHERE USERNAME = @USERNAME AND PASSWORD=@PASSWORD";
        public const string ChangePassword = @"UPDATE [USER] SET PASSWORD = @NEWPASSWORD WHERE USERNAME = @USERNAME";
        public const string LoadUserProfile = @"SELECT USERNAME, USERID, PASSWORD, DESCRIPTION FROM [USER] WHERE USERNAME = @USERNAME";
        public const string SelectMaxId = "SELECT ISNULL(MAX(USERID),0)+1 AS MAX_ROLE_ID FROM [USER]";
        public enum QueryStatus {Select, Insert, Delete, Update, SelectMaxId , CheckUserValid, ChangePassword, LoadUserProfile };
    }
}
