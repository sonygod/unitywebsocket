using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JsonDotNet.Extras.CustomConverters;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using UnityEngine;

namespace Assets.JsonDotNet.Extras.CustomConverters
{
   public class MeshConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            JToken t = JToken.FromObject(new MMesh((Mesh)value));

            t.WriteTo(writer);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(Mesh);
        }
    }
}
public class MMesh
{
    public MMesh(Mesh mesh)
    {

        this.colors = mesh.colors;
        this.colors32 = mesh.colors32;
        this.name = mesh.name;
        this.normals = mesh.normals;
        this.triangles = mesh.triangles;
        this.tangents = mesh.tangents;
        this.vertices = mesh.vertices;
        this.uv = mesh.uv;
        this.uv2 = mesh.uv2;
       
        isReadable = true;
        this.bounds = mesh.bounds;
    }

    public Bounds bounds { get; set; }

    public bool isReadable { get; set; } 

    public string name { get; set; }

//
    // 摘要: 
    //     Vertex colors of the mesh.
    public Color[] colors { get; set; }
    //
    // 摘要: 
    //     Vertex colors of the mesh.
    public Color32[] colors32 { get; set; }
    //
    // 摘要: 
    //     Returns state of the Read/Write Enabled checkbox when model was imported.

    //
    // 摘要: 
    //     The normals of the mesh.
    public Vector3[] normals { get; set; }

    //
    // 摘要: 
    //     The tangents of the mesh.
    public Vector4[] tangents { get; set; }
    //
    // 摘要: 
    //     An array containing all triangles in the mesh.
    public int[] triangles { get; set; }
    //
    // 摘要: 
    //     The base texture coordinates of the mesh.
    public Vector2[] uv { get; set; }

    //
    // 摘要: 
    //     The second texture coordinate set of the mesh, if present.
    public Vector2[] uv2 { get; set; }
   
    //
    // 摘要: 

    //
    // 摘要: 
    //     Returns a copy of the vertex positions or assigns a new vertex positions
    //     array.
    public Vector3[] vertices { get; set; }

}
/**

http://blog.csdn.net/angelsmiles/article/details/50464369

**/