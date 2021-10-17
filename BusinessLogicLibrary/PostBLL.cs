using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogicLayer
{
    using BusinessObjectLayer;
    using DataAccessLayer;
    using DataObjectLayer;

    public class PostBLL
    {
        public PostBOL[] Select(PostBOL _PostBOL)
        {
            PostDAL _PostDAL = new PostDAL(PostDOL.QueryStatus.Select, _PostBOL);
            return _PostDAL.Select();
        }
        public void Insert(PostBOL _PostBOL)
        {
            PostDAL _PostDAL = new PostDAL(PostDOL.QueryStatus.Insert, _PostBOL);
            _PostDAL.Insert();
        }
        public void Update(PostBOL _PostBOL)
        {
            PostDAL _PostDAL = new PostDAL(PostDOL.QueryStatus.Update, _PostBOL);
            _PostDAL.Update();
        }
        public void Delete(PostBOL _PostBOL)
        {
            PostDAL _PostDAL = new PostDAL(PostDOL.QueryStatus.Delete, _PostBOL);
            _PostDAL.Delete();
        }
        public byte? SelectMaxId()
        {
            PostDAL _PostDAL = new PostDAL(PostDOL.QueryStatus.SelectMaxId);
            return _PostDAL.SelectMaxId();
        }
        public PostBOL[] SelectComboBox()
        {
            PostDAL _PostDAL = new PostDAL(PostDOL.QueryStatus.SelectComboBox);
            return _PostDAL.SelectComboBox();
        }
    }
}
