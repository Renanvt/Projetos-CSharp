
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace System
{
   static class DateTimeExtensions
    {
        //extension methods
        public static string ElapsedTime(this DateTime thisObj)
            //ElapsedTime está extendendo um tipo DateTime, This é uma referencia para o próprio objeto
        {
            //Transforma a data em uma duração em data ou em dias em relação ao instante atual
            TimeSpan duration = DateTime.Now.Subtract(thisObj);
            if(duration.TotalHours < 24.0)
            {
                return duration.TotalHours.ToString("F1", CultureInfo.InvariantCulture) + " hours";
            }
            else
            {
                return duration.TotalDays.ToString("f1", CultureInfo.InvariantCulture) + " days";
            }
        }
    }
}
