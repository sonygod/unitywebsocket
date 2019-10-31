using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using UnityEngine;

namespace JsonDotNet.Extras.CustomConverters
{
   

    public class ColorConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            JToken t = JToken.FromObject(new MMColor((Color)value));

            t.WriteTo(writer);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException("Unnecessary because CanRead is false. The type will skip the converter.");
        }

        public override bool CanRead
        {
            get { return false; }
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(Color);
        }
    }

   
}
public class MMColor
{
    // 摘要: 
    //     X component of the vector.
    public float r;
    //
    // 摘要: 
    //     Y component of the vector.
    public float g;

    public float b;

    public float a;

    //
    // 摘要: 
    //     Constructs a new vector with given x, y components.
    //
    // 参数: 
    //   x:
    //
    //   y:


    public MMColor(Color v)
    {
        r = v.r;
        g = v.g;
        b = v.b;
        a = v.a;

    }
}