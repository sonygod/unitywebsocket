using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Newtonsoft.Json
{
    //简化版扩展9.0版本
   public static class JsonReaderExtends
    {

       public static int? ReadAsInt32(this JsonReader reader)
       {
         

           int i = Convert.ToInt32(reader.Value, CultureInfo.InvariantCulture);

           return i;
       }

       public static string ReadAsString(this JsonReader reader)
       {



           return (string) reader.Value;
       }

       public static bool? ReadAsBoolean(this JsonReader reader)
       {



           return (bool)reader.Value;
       }


       public static byte[] ReadAsBytes(this JsonReader reader)
       {



           return (byte[])reader.Value;
       }

       public static double? ReadAsDouble(this JsonReader reader)
       {



           return (double)reader.Value;
       }

       public static string Path(this JsonReader reader)
       {
           return "";
       }
    }
}
