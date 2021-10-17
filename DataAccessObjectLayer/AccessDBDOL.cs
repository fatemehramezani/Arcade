using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataObjectLayer
{
    public class AccessDBDOL
    {
        public const string Select = @"SELECT     n_parvandeh,jensiat,tar_tashkil_par,name,shohrat,nampedar,tar_tavalod,n_serial,n_shenasnameh,mahal_s,
                                seri_shenasnameh,tab_din.Din,TAB_MAZHAB.Mazhab,taahol,nezam,cod_ostan_s,cod_shahr_s,addres_s,TAB_MADRAK.name_madrak as DegreeTitle,reshte_t,cod_ostan_t,cod_shahr_t,
                                addres_t,n_p_n,vazeiyat_f,Bome,name_m,shohrat_m,ChForNumM,Life,atbaebigane FROM TAB_IDENT,TAB_MAZHAB,TAB_MADRAK,TAB_OSTAN,TAB_SHAHR,TAB_DIN";
        public const string Insert = @"";
        //public const string SelectComboBox = @"SELECT Id, Title FROM Basic.MilitaryStatus UNION (SELECT ID AS Id, TEXT AS Title FROM NOSELECTION)";
        public const string Delete = "";
        public const string Update = "";
        public const string SelectMaxId = "";
        public enum QueryStatus { Select, Insert, Delete, Update, SelectMaxId };
    }
}
