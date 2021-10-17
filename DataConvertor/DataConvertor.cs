using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Globalization;
using System.Drawing;
using System.Net;

namespace DataConvertor
{
    public class DataConvertor
    {
        public static Image ConvertToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
        public static byte[] ConvertToByteArray(object Value)
        {
            byte[] result;
            result = (Value == DBNull.Value ? (byte[])null : (byte[])Value);
            return result;
        }
        public static string ConvertToString(object Value)
        {
            string result;
            result = (Value == DBNull.Value || Value == null ? null : Convert.ToString(Value));
            return result;
        }
        public static long? ConvertToLong(object Value)
        {
            long? result;
            if (Value == DBNull.Value || Value == null || Value == string.Empty)
                result = null;
            else
                result = Convert.ToInt64(Value);
            return result;
        }
        public static bool? ConvertToBoolean(object Value)
        {
            bool? result;
            if (Value == DBNull.Value || Value == null || Value == string.Empty)
                result = null;
            else
                result = Convert.ToBoolean(Value);
            return result;
        }
        public static short? ConvertToShort(object Value)
        {
            short? result;
            if (Value == DBNull.Value || Value == null || Value == string.Empty)
                result = null;
            else
                result = Convert.ToInt16(Value);
            return result;
        }
        public static decimal? ConvertToDecimal(object Value)
        {
            decimal? result;
            if (Value == DBNull.Value || Value == null || Value == string.Empty)
                result = null;
            else
                result = Convert.ToDecimal(Value);
            return result;
        }
        public static DateTime? ConvertToDateTime(object Value)
        {
            DateTime? result;
            if (Value == DBNull.Value || Value == null || Value == string.Empty)
                result = null;
            else
                result = Convert.ToDateTime(Value);
            return result;
        }
        public static TimeSpan? ConvertToTimeSpan(object Value)
        {
            TimeSpan? result;
            if (Value == DBNull.Value || Value == null || Value == string.Empty)
                result = null;
            else
                result = TimeSpan.Parse(Value.ToString());
            return result;
        }
        public static int? ConvertToInt(object Value)
        {
            int? result;
            if (Value == DBNull.Value || Value == null || Value == string.Empty)
                result = null;
            else
                result = Convert.ToInt32(Value);
            return result;
        }
        public static byte? ConvertToByte(object Value)
        {
            byte? result;
            if (Value == DBNull.Value || Value == null || Value == string.Empty)
                result = null;
            else
                result = Convert.ToByte(Value);
            return result;
        }
        public static Guid? ConvertToGuid(object Value)
        {
            Guid? result;
            if (Value == DBNull.Value || Value == null || Value == string.Empty)
                result = null;
            else
                result = (Guid)Value;
            return result;
        }
        public static string ConvertToPersianDate(DateTime? dateTime)
        {
            if (dateTime == null)
                return string.Empty;
            PersianCalendar persianCalendar = new PersianCalendar();
            //            return String.Format("{3}:{4}-{0}/{1}/{2}", persianCalendar.GetYear((DateTime)dateTime).ToString(), persianCalendar.GetMonth((DateTime)dateTime).ToString("00"), persianCalendar.GetDayOfMonth((DateTime)dateTime).ToString("00"), persianCalendar.GetHour((DateTime)dateTime).ToString("00"), persianCalendar.GetMinute((DateTime)dateTime).ToString("00"));
            return String.Format("{0}/{1}/{2}", persianCalendar.GetYear((DateTime)dateTime).ToString(), persianCalendar.GetMonth((DateTime)dateTime).ToString("00"), persianCalendar.GetDayOfMonth((DateTime)dateTime).ToString("00"));
        }
        public static string ConvertCharArabicToPersian(string Input)
        {
            string Output = Input.Trim().Replace((char)1610, (char)1740);
            return Output.Replace((char)1603, (char)1705);
        }
    }
}
