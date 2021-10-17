using DataAccessLibrary;
using System.Data;

namespace BusinessLogicLayer
{
    public class DatabaseBLL
    {
        public bool BackUp(string Path, string Name)
        {
            return new DatabaseDAL().BackUp(Path, Name);
        }
        public bool RestoreBackUp(string Path, string Name)
        {
            return new DatabaseDAL().RestoreBackUp(Path, Name);
        }
        public DataTable Select(string ConnectionString)
        {
            return new DatabaseDAL().Select(ConnectionString);
        }
    }
}