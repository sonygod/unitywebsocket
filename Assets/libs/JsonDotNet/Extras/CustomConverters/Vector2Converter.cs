using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using UnityEngine;

namespace JsonDotNet.Extras.CustomConverters
{
	public class Vector2Converter : JsonConverter
	{
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			JToken t = JToken.FromObject(new MMVector2((Vector2)value));

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
			return objectType == typeof(Vector2);
		}
	}
}

public class MMVector2
{
    // 摘要: 
    //     X component of the vector.
    public float x;
    //
    // 摘要: 
    //     Y component of the vector.
    public float y;

    //
    // 摘要: 
    //     Constructs a new vector with given x, y components.
    //
    // 参数: 
    //   x:
    //
    //   y:
    public MMVector2(float x, float y)
    {
        this.x = x;
        this.y = y;
    }

    public MMVector2(Vector2 v)
    {
        this.x = v.x;
        this.y = v.y;

    }
}