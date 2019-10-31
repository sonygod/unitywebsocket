using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using UnityEngine;

namespace JsonDotNet.Extras.CustomConverters
{
    public class TransformConverter : JsonConverter
	{
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
            JToken t = JToken.FromObject(new MyTransform((Transform)value));

            t.WriteTo(writer);

			/*JToken t = JToken.FromObject(value);

			if (t.Type != JTokenType.Object)
			{
				t.WriteTo(writer);
			}
			else
			{
				var o = (JObject)t;
				IList<string> propertyNames = o.Properties().Where(p => p.Name == "x" || p.Name == "y").Select(p => p.Name).ToList();

				o.AddFirst(new JProperty("Keys", new JArray(propertyNames)));
				o.WriteTo(writer);
			}*/
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
			return objectType == typeof(Transform);
		}
	}

    public class MyTransform
    {
          //
        // 摘要: 
        //     Position of the transform relative to the parent transform.
        public Vector3 localPosition { get; set; }
        //
        // 摘要: 
        //     The rotation of the transform relative to the parent transform's rotation.
        public Quaternion localRotation { get; set; }
        //
        // 摘要: 
        //     The scale of the transform relative to the parent.
        public Vector3 localScale { get; set; }


        public string tag { get; set; }

        public int layer { get; set; }
        public MyTransform(Transform v)
        {


            localPosition = v.localPosition;
            localRotation = v.localRotation;
            localScale = v.localScale;

            this.tag = v.tag;
            this.layer = v.gameObject.layer;
        }
    }
}
