using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using UnityEngine;

namespace JsonDotNet.Extras.CustomConverters
{
	public class Vector4Converter : JsonConverter
	{
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			JToken t = JToken.FromObject(new MMVector4((Vector4)value));

			
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
			return objectType == typeof(Vector4);
		}
	}
}
public class MMVector4
{
    // 摘要: 
    //     X component of the vector.
    public float x;
    //
    // 摘要: 
    //     Y component of the vector.
    public float y;

    public float z;

    public float w;

    //
    // 摘要: 
    //     Constructs a new vector with given x, y components.
    //
    // 参数: 
    //   x:
    //
    //   y:


    public MMVector4(Vector4 v)
    {
        this.x = v.x;
        this.y = v.y;
        this.z = v.z;
        this.w = v.w;


    }
}