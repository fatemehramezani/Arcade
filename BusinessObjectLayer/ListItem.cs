using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessObjectLayer
{
   public class ListItem
    {
       public readonly int? Id;
       public readonly string Value;
       public ListItem(int? id, string value)
       {
           this.Id = id;
           this.Value = value;
       }
       public override string ToString()
       {
           return Value;
       }
    }
}
