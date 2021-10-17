using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessObjectLayer
{
    public class PostBOL
    {
        private int?  id;
        private int? roleTypeId;
        private int? personalInfoId;
        public int? Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public int? PostTypeId
        {
            get { return this.roleTypeId; }
            set { this.roleTypeId= value; }
        }

        public int? PersonalInfoId
        {
            get { return this.personalInfoId;}
            set { this.personalInfoId=value;}
        }
        public PostBOL() {}
        public PostBOL(int? Id)
        {
            this.Id = Id;
        }
        public PostBOL(int? Id, int? PostTypeId,int? PersonalInfoId)
        {
            this.Id =  Id;
            this.PostTypeId =  PostTypeId;
            this.PersonalInfoId = PersonalInfoId;
        }
    }
}
