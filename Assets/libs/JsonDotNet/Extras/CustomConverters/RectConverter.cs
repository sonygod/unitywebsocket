using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using UnityEngine;

namespace JsonDotNet.Extras.CustomConverters
{
	public class RectConverter : JsonConverter
	{
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
            JToken t = JToken.FromObject(new Rect2((Rect)value));

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
			return objectType == typeof(Rect);
		}
	}
}

public class Rect2
{
    // 摘要: 
    //     X component of the vector.
    public float x;
    //
    // 摘要: 
    //     Y component of the vector.
    public float y;

    public float width;

    public float height;

    //
    // 摘要: 
    //     Constructs a new vector with given x, y components.
    //
    // 参数: 
    //   x:
    //
    //   y:
    public Rect2(float x, float y)
    {
        this.x = x;
        this.y = y;
    }

    public Rect2(Rect v)
    {
        this.x = v.x;
        this.y = v.y;

        this.width = v.width;
        this.height = v.height;

    }
}