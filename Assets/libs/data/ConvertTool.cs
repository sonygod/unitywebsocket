using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using client;
using gameRoom;
using Newtonsoft.Json;
using web;
using UnityEngine;
namespace com.huaqian
{
    class ConvertTool
    {

        //转换服务器传过来的数据。

        public static T ConvertPlayer<T>(object player,bool print=false)
        {

            if (print)
            {
                Debug.Log(haxe.Json.stringify(player,null,null));
            }
            string playerString = haxe.Json.stringify(player, null, null);
            JsonSerializerSettings settings=new JsonSerializerSettings();
            settings.NullValueHandling = NullValueHandling.Ignore;
            settings.DefaultValueHandling = DefaultValueHandling.Ignore;
            var pp = JsonConvert.DeserializeObject<T>(playerString,settings);

            return pp;
        }

        public static TinyRoomCS ConvertRoom (object room, bool print = false)
        {

            if (print)
            {
                Debug.Log(haxe.Json.stringify(room, null, null));
            }
            string playerString = haxe.Json.stringify(room, null, null);

            JsonSerializerSettings settings = new JsonSerializerSettings();
            settings.NullValueHandling = NullValueHandling.Ignore;

            var  pp = JsonConvert.DeserializeObject<TinyRoomCS>(playerString,settings);


           // pp.players=

            return pp;
        }


        public static T ConvertData<T>(object data, bool print = false)
        {

            if (print)
            {
                Debug.Log(haxe.Json.stringify(data, null, null));
            }
            string playerString = haxe.Json.stringify(data, null, null);

            JsonSerializerSettings settings = new JsonSerializerSettings();
            settings.NullValueHandling = NullValueHandling.Ignore;

            var pp = JsonConvert.DeserializeObject<T>(playerString, settings);


            // pp.players=

            return pp;
        }
        public static object ToHaxeRoom(TinyRoomCS room)
        {
            //var s=JsonConvert.SerializeObject(room);
           

            var json =JsonConvert.SerializeObject(room);


            return ConvertCSHX.convertRoomData(json);
        }

        public static TinyCMDCS ConvertCMD(object eCmd)
        {
            string playerString = haxe.Json.stringify(eCmd, null, null);

            JsonSerializerSettings settings = new JsonSerializerSettings();
            settings.NullValueHandling = NullValueHandling.Ignore;

            var pp = JsonConvert.DeserializeObject<TinyCMDCS>(playerString,settings);

            return pp;
        }

        public static TinyBilingCS ConvertTinyBiling(object playerEventBling)
        {
            string playerString = haxe.Json.stringify(playerEventBling, null, null);
            JsonSerializerSettings settings = new JsonSerializerSettings();
            settings.NullValueHandling = NullValueHandling.Ignore;


            var pp = JsonConvert.DeserializeObject<TinyBilingCS>(playerString,settings);


            // pp.players=

            return pp;

        }
    }
}
