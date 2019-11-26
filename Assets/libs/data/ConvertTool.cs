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
            

            var pp = JsonConvert.DeserializeObject<T>(playerString);

            return pp;
        }

        public static TinyRoomCS ConvertRoom (object room, bool print = false)
        {

            if (print)
            {
                Debug.Log(haxe.Json.stringify(room, null, null));
            }
            string playerString = haxe.Json.stringify(room, null, null);


            var  pp = JsonConvert.DeserializeObject<TinyRoomCS>(playerString);


           // pp.players=

            return pp;
        }
        public static object ToHaxeRoom(TinyRoomCS room)
        {
            //var s=JsonConvert.SerializeObject(room);
            var json=JsonConvert.SerializeObject(room);


            return ConvertCSHX.convertRoomData(json);
        }

        public static TinyCMDCS ConvertCMD(object eCmd)
        {
            string playerString = haxe.Json.stringify(eCmd, null, null);

            var pp = JsonConvert.DeserializeObject<TinyCMDCS>(playerString);

            return pp;
        }
    }
}
