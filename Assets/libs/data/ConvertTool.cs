using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    }
}
