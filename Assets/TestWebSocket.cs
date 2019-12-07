using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Reflection;
using client;
using com.huaqian;
using gameRoom;
using haxe.lang;
using UnityEngine;
using haxe.root;
using web.proto;
using Event = openfl.events.Event;
using UnityThreading;
using haxe.root;
using Newtonsoft.Json;
using utils;
using web;
using LitJson;

public class TestWebSocket : MonoBehaviour
{
    public string Text;

    private Client client;


    private PlayerCS self; //自己.
    private HallCS hall;
    private bool socketConnect;
    private Dictionary<int, PlayerCS> dic; //退出房间要删除。

    public TinyPlayerCS currentPlayer { get; private set; }
    public RoomCS currentRoom { get; private set; }

    // Use this for initialization
    void Start()
    {
        TestPackBuilder.main(); //初始化
        UnityThreadHelper.EnsureHelper(); //线程初始化,这个必须要在开始定义.

        CustomTrace.close(true); //关闭输出。关闭框架输出，如果影响调试。

        TinyPlayerCS pp = new TinyPlayerCS();

        pp.id = 2009;


        client = new Client();

        client.testUint((uint) 3312);

        //client.testPlayer.addEventListener("onOpen", onCSOpen);

        Debug.Log("是否解决了?");
        client.onSocketCloseCS = onSocketClose;
        client.onSocketOpenCS = onSocketOpen;
        client.onSocketErrorCS = onSocketError;
        //client.connectWithIP("144.48.4.186", 9003); //这里改成你自己的ip
        client.connectWithIP("127.0.0.1", 9003); //这里改成你自己的ip
        //  client.connectWithIP("144.48.4.186", 9003); //这里改成你自己的ip
        client.onGlobalError = onGlobalError;
        // client.testPlayer.dispatchEvent(new CEvent("onOpen"),this );


        self = new PlayerCS(null);
        self.addEvent(); //这里添加倾听器,如果要移除用off
        self.addEventListener(HallEvent.LOGIN, onLogin);

        self.addEventListener(HallEvent.OnReg, onReg);

        self.addEventListener(PlayerEvent.GET_USER_INFO, onGetuserInfo);

        self.addEventListener(PlayerEvent.GET_TEARM_INCOME, onGetIncome);
        self.addEventListener(ShoppingEvent.GET_BUY_LIST,onGetBuyList);
        self.addEventListener(ShoppingEvent.GET_CHARGE_LIST, onGetChargeList);
        TestEventDispathFromHaxe();


        //---------------新增-------------------
        hall = new HallCS(); //创建大厅
        hall.addEvent(); //这个一定不能删除。//todo:不能其他人登陆会影响到这里。
        hall.addEventListener(RoomEvent.CREATE_ROOM, onCreateRoom);
        hall.addEventListener(RoomEvent.JOIN_ROOM, onJoinRoom);
        hall.addEventListener(CMDEvent.RESULT, onCMDResult);
    }

    private void onGetChargeList(CEvent evt)
    {
        ShoppingEvent e = (ShoppingEvent)evt.eventParams;

        var data = e.data;

        TinyChargeCS[] pp = ConvertTool.ConvertData<TinyChargeCS[]>(e.data);


        Debug.Log(JsonConvert.SerializeObject(pp));
    }

    private void onGetBuyList(CEvent evt)
    {
        ShoppingEvent e = (ShoppingEvent)evt.eventParams;

        TinyBuyItemCS[] pp = ConvertTool.ConvertData<TinyBuyItemCS[]>(e.data);

        Debug.Log(JsonConvert.SerializeObject(pp));
        //  throw new NotImplementedException();
    }

    //收益 2019-12-5
    private void onGetIncome(CEvent evt)
    {

        var playerEvent = (PlayerEvent) evt.eventParams;


        var p = playerEvent.player;
        Debug.Log("获取收益CS");



        TinyPlayerCS pp = ConvertTool.ConvertPlayer<TinyPlayerCS>(playerEvent.player);

        Debug.Log(JsonConvert.SerializeObject(pp));

    }

    private void onGetuserInfo(CEvent evt)
    {
        var playerEvent = (PlayerEvent) evt.eventParams;



        TinyPlayerCS pp = ConvertTool.ConvertPlayer<TinyPlayerCS>(playerEvent.player);

        //  currentPlayer = pp;

        // self.installData(e.player); //这一定要设置。

        Debug.Log("pp=" + pp.money);

    }

    private void onCMDResult(CEvent evt)
    {
        CMDEvent e = (CMDEvent) evt.eventParams;

        TinyCMDCS c = ConvertTool.ConvertCMD(e.cmd);


        var info = JsonConvert.SerializeObject(c);

        Debug.Log("调用系统命令返回" + info);
    }

    private void onCreateRoom(CEvent evt)
    {
        UnityThreadHelper.Dispatcher.Dispatch(() =>
        {
            Debug.Log("创建房间成功" + evt.eventParams);
            //  var c = (TinyRoomCS)evt.eventParams;

            RoomEvent e = (RoomEvent) evt.eventParams;

            TinyRoomCS c = ConvertTool.ConvertRoom(e.room);


            if (currentRoom != null)
            {
                TinyRoomCS c2 = ConvertTool.ConvertRoom(currentRoom.data);
                if (c.id == c2.id)
                {
                    Debug.LogError("不能重复创建房间");
                    return;
                }
            }

            Debug.Log(c);

            var room = new RoomCS(e.room);
            room.addEvent(); //这里是内部倾听，不能删除，否则所有事件无效。
            room.addEventListener(RoomEvent.JOIN_ROOM, onJoinRoom);
            room.addEventListener(RoomEvent.DESTORY, onDestoryRoom); //删除和退出一样。
            room.addEventListener(RoomEvent.LEAVE_ROOM, onDestoryRoom);
            room.addEventListener(RoomEvent.GET_ROOM_INFO, onGetRoomInfo);
            room.addEventListener(RoomEvent.JOIN_ROOM, onJoinRoom);
            hall.removeEventListener(RoomEvent.JOIN_ROOM, onJoinRoom);
            room.addEventListener(RoomEvent.DISPATCH, onDispath);
            room.addEventListener(RoomEvent.RESULT, onGetResult);


            currentRoom = room;
        });

        //room.addEventListener(RoomEvent, onDispath);
        //room.addEventListener(RoomEvent.);
    }

    private void onGetResult(CEvent evt)
    {
        //  throw new NotImplementedException();

        UnityThreadHelper.Dispatcher.Dispatch(() =>
        {
            //            var parms = evt.eventParams;
            //
            //            Debug.Log("完成一局，结果返回" + JsonConvert.SerializeObject(parms));


            RoomEvent parms = (RoomEvent) evt.eventParams;

            var room = parms.room;


            TinyRoomCS ts = ConvertTool.ConvertRoom(room);


            Debug.Log("房间发牌" + JsonConvert.SerializeObject(ts));
        });
    }


    //发牌 准备
    private void onDispath(CEvent evt)
    {
        UnityThreadHelper.Dispatcher.Dispatch(() =>
        {
            //  throw new NotImplementedException();

            RoomEvent parms = (RoomEvent) evt.eventParams;

            var room = parms.room;


            TinyRoomCS ts = ConvertTool.ConvertRoom(room);


            Debug.Log("房间发牌" + JsonConvert.SerializeObject(ts));
        });
    }

    private void onGetRoomInfo(CEvent evt)
    {
        UnityThreadHelper.Dispatcher.Dispatch(() =>
        {
            RoomEvent parms = (RoomEvent) evt.eventParams;

            var room = parms.room;


            Debug.Log("room" + room);
            TinyRoomCS ts = ConvertTool.ConvertRoom(room);


            var idle = 0; // 空闲;
            var ready = 1; // 准备状态
            var playing = 2; // 玩;
            var start = 2;
            var dispath = 3;
            var qiangzhuang = 4; // 抢庄
            var settingZhuang = 5; //设置庄
            var gamebling = 6; // 下注
            var switchTimes = 7; ////设置倍数。如：两点一倍，炸弹四倍
            var roundFinish = 8; // 一局结束
            var over = 9; // 游戏结束;






            Debug.Log("获取信息房间" + JsonConvert.SerializeObject(ts));

            switch (ts.status)
            {
                case 0:
                    Debug.Log("<color=#9400D3>空闲</color>");
                    break;
                case 1:
                    Debug.Log("<color=#9400D3>准备</color>");
                    break;
                case 2:
                    Debug.Log("<color=#9400D3>开始</color>");
                    break;
                case 3:
                    Debug.Log("<color=#9400D3>发牌</color>");
                    break;
                case 4:
                    Debug.Log("<color=#9400D3>抢庄</color>");
                    break;
                case 5:
                    Debug.Log("<color=#9400D3>设置庄</color>");
                    break;
                case 6:
                    Debug.Log("<color=#9400D3>下注</color>");
                    break;

                case 7:
                    Debug.Log("<color=#9400D3>设置倍数</color>"); //用于开房间，一共有几局
                    break;

                case 8:
                    Debug.Log("<color=#9400D3>本轮结束</color>"); //用于开房间，一共有几局
                    break;
                case 9:
                    Debug.Log("<color=#9400D3>游戏结束</color>"); //用于开房间，一共有几局
                    break;
            }


            var ps = ts.players;
            //2019-11-27
            foreach (TinyPlayerCS cs in ps)
            {

                if (dic == null)
                {
                    dic = new Dictionary<int, PlayerCS>();
                }

                if (!dic.ContainsKey(cs.id))
                {
                    dic[cs.id] = new PlayerCS(null);




                    var player = dic[cs.id];


                    if (player.data == null)
                    {
                        player.installDataCS(JsonConvert.SerializeObject(cs));
                    }

                    player.addEvent();

                    player.addEventListener(PlayerEvent.ADD_BET, onAddBet); //倾听下注，还可以倾听用户 的表情，语音，等。

                }








            }
        });
    }

    //倾听下注
    private void onAddBet(CEvent evt)
    {
        UnityThreadHelper.Dispatcher.Dispatch(() =>
        {

            PlayerEvent playerEvent = (PlayerEvent) evt.eventParams;



            TinyBilingCS biling = ConvertTool.ConvertTinyBiling(playerEvent.bling);



            Debug.Log(" <color=#9400D3> 房间" + biling.roomID + " 玩家" + biling.playerID + " 下注= " + biling.bling +
                      "</color>");
        });


    }

    private void onDestoryRoom(CEvent evt)
    {
        UnityThreadHelper.Dispatcher.Dispatch(() =>
        {
            var parms = evt.eventParams;
            Debug.Log("删除房间");
            currentRoom = null;

            hall.addEventListener(RoomEvent.JOIN_ROOM, onJoinRoom); //这里补回到大厅。
        });
    }

    private void onJoinRoom(CEvent evt)
    {
        UnityThreadHelper.Dispatcher.Dispatch(() =>
        {
            RoomEvent parms = (RoomEvent) evt.eventParams;

            var room = parms.room;


            TinyRoomCS ts = ConvertTool.ConvertRoom(room);


            Debug.Log("加入房间" + JsonConvert.SerializeObject(ts));
        });
    }

    private void onReg(CEvent evt)
    {

    }

    private void onLogin(CEvent evt)
    {
        UnityThreadHelper.Dispatcher.Dispatch(() =>
        {
            HallEvent e = (HallEvent) evt.eventParams;
            Debug.Log("unity 登陆成功");
            Debug.Log(e);


            TinyPlayerCS pp = ConvertTool.ConvertPlayer<TinyPlayerCS>(e.player);

            currentPlayer = pp;

            self.installData(e.player); //这一定要设置。
            Debug.Log(JsonConvert.SerializeObject(pp));
        });
    }

    private void TestEventDispathFromHaxe()
    {
        var p = new PlayerCS(null);

        p.addEventListener("1", onTestEventList);

        p.dispath();
    }

    private void onTestEventList(CEvent evt)
    {
        Debug.Log("收到事件拉." + evt.eventParams);
    }

    private void onGlobalError(ErrorEventCS obj)
    {
        Debug.Log("服务器返回错误" + obj.text); //你需要在这里switch 一下各种事件的处理.


        if (obj.text == "0")
        {
        }
    }

    private void onCSOpen(CEvent evt)
    {
        var ps = evt.eventParams;

        Debug.Log("事件听到了?" + ps);
    }

    //socket错误
    private void onSocketError(object obj)
    {
        Debug.LogError("socket error" + obj.ToString());
    }
    //首次链接上服务器.

    private void onSocketOpen()
    {
        Debug.Log("链接成功了");


        //尝试登陆.

        Debug.Log("尝试登陆"); //这里可以正式开始了


        UnityThreadHelper.Dispatcher.Dispatch(() => { readyStart(); }); //注意,这里是socket线程切换到主线程
    }
    //这里才真正开始.

    private void readyStart()
    {
        Debug.Log("从这里开始...");


        // self.Login("13060669337", "123456");

        //  self.regist()注册
        // self.forgotpassWord()忘记密码
        //self.changeUserInfo()//换头像

        socketConnect = true;
    }

    private void onSocketClose()
    {
        Debug.Log("被远程关闭 ");
        socketConnect = false;
    }

    void OnApplicationQuit()
    {
        socketConnect = false;
        client.quit(); //退出登录,退出socket,切换账号.
    }


    void OnGUI()
    {
        if (socketConnect == false)
        {
            return;
        }

        //进入/创建机器人房间
        if (GUI.Button(new Rect(0, 0, 50, 50), "creat"))
        {
            if (currentPlayer != null)
            {
                TinyRoomCS room = new TinyRoomCS();

                room.gameID = 2001; //机器人三公，参考文档
                room.gambling = 10; // // 底注 不同房间准入不同,要计算player还有多少money.
                room.threshold = 1; //准入.


                room.owerID = (int) currentPlayer.id; //这个是当前玩家的id.这里测试随便填。


                self.createRoom(ConvertTool.ToHaxeRoom(room));
            }
            else
            {
                Debug.Log("请登录");
            }
        }

        //开始游戏
        if (GUI.Button(new Rect(60, 0, 50, 50), "start"))
        {
            if (currentRoom != null)
            {
                currentRoom.start();
            }
            else
            {
                Debug.Log("请创建room");
            }
        }


        if (GUI.Button(new Rect(120, 0, 50, 50), "getinfo"))
        {
            if (currentRoom != null)
            {
                currentRoom.getInfo();
            }
            else
            {
                Debug.Log("请创建room");
            }
        }
        //退出游戏


        //下注
        if (GUI.Button(new Rect(0, 60, 50, 50), "addbet"))
        {
            if (currentPlayer != null)
            {
                var data = currentRoom.data;
                self.gameAddBetCS(2); //这里是倍数。
            }
            else
            {
                Debug.Log("请登陆");
            }
        }


        //下注
        if (GUI.Button(new Rect(60, 60, 50, 50), "quite"))
        {
            if (currentPlayer != null && currentRoom != null)
            {
                var data = currentRoom.data;


                TinyRoomCS c = ConvertTool.ConvertRoom(data);

                if ((int) c.status > 2)
                {
                    Debug.Log("游戏进行中不能退出");

                    return;
                }

                if (self.data == null)
                {
                    Debug.Log("请self.install data");
                    return;
                }

                self.leaveRoom((uint) c.id);
            }
            else
            {
                Debug.Log("请登陆和创建房间");
            }
        }

        //获取用户信息，没有登陆的情况下 不要频繁调用
        if (GUI.Button(new Rect(160, 60, 50, 50), "getinfo"))
        {
            JsonData cmd = new JsonData();
            //demo.SetJsonType(JsonType.Object);
            // demo["id"] = 3302;
            cmd["openid"] =
                haxe.root.Random.@string(32, "123456789abcdefghijklnmopqrstuvwxyz"); //"01234567891234567891234567891";

            cmd["cmd"] = 4002;
            var d = cmd.ToJson();
            hall.excuteCMD(d);
        }

        if (GUI.Button(new Rect(260, 60, 50, 50), "insertOpenid"))
        {
            //先查找是否存在，后插入。

            JsonData cmd = new JsonData();
            //demo.SetJsonType(JsonType.Object);
            // demo["id"] = 3302;
            //   cmd["openid"] = haxe.root.Random.@string(32, "123456789abcdefghijklnmopqrstuvwxyz"); //"01234567891234567891234567891";

            cmd["cmd"] = 4005;

            JsonData player = new JsonData();

            cmd["player"] = player;

            player["openID"] = haxe.root.Random.@string(32, "123456789abcdefghijklnmopqrstuvwxyz"); //填入真实的openid.
            player["referenceID"] = 0; //推荐人ID.//注册。

            player["avatar"] = "1.jpg";
            player["nick_name"] = "新用户"; //插入用户昵称


            hall.excuteCMD(cmd.ToJson());
        }


        if (GUI.Button(new Rect(360, 60, 50, 50), "login"))
        {
            //先查找是否存在，后插入。
            self.Login("13060669337", "123456");
        }

        //充值，从交易所充入来

        if (GUI.Button(new Rect(6, 160, 50, 50), "charge"))
        {
            //先查找是否存在，后插入。


            JsonData cmd = new JsonData();
            cmd["cmd"] = 4006;

            JsonData player = new JsonData();

            cmd["player"] = player;
            cmd["value"] = 100; //充值金额

            player["id"] = 3302; // haxe.root.Random.@string(32, "123456789abcdefghijklnmopqrstuvwxyz");//填入真实的openid.


            hall.excuteCMD(cmd.ToJson());
        }

        //购买道具，充值入游戏
        if (GUI.Button(new Rect(100, 160, 50, 50), "buy"))
        {
            //先查找是否存在，后插入。


            JsonData cmd = new JsonData();
            cmd["cmd"] = 4007;

            JsonData player = new JsonData();

            cmd["value"] = 1; //这里是传索引 [100,200,500]  1是200
            cmd["nums"] = 1; //购买多少次

            player["id"] = 3302; // haxe.root.Random.@string(32, "123456789abcdefghijklnmopqrstuvwxyz");//填入真实的openid.
            cmd["player"] = player;

            hall.excuteCMD(cmd.ToJson());
        }


        //提取
        if (GUI.Button(new Rect(200, 160, 50, 50), "draw"))
        {
            //先查找是否存在，后插入。


            JsonData cmd = new JsonData();
            cmd["cmd"] = 4008;

            JsonData player = new JsonData();

            cmd["value"] = 100; //要提取多少币？


            player["id"] = 3302; // haxe.root.Random.@string(32, "123456789abcdefghijklnmopqrstuvwxyz");//填入真实的openid.
            cmd["player"] = player;

            hall.excuteCMD(cmd.ToJson());
        }


        if (GUI.Button(new Rect(260, 160, 50, 50), "getinfo"))
        {
            //先查找是否存在，后插入。


            self.getUserInfo();
        }

        if (GUI.Button(new Rect(360, 160, 50, 50), "tearm"))
        {
            //先查找是否存在，后插入。


            self.getUserIncomeAndSize();




            //
        }

        if (GUI.Button(new Rect(360, 260, 50, 50), "getBuyList"))
        {
            //获取购买游戏币历史


            self.getBuyList();
        }

        if (GUI.Button(new Rect(460, 260, 50, 50), "getChargeList"))
        {
            //获取购买游戏币历史


            self.getChargeList();
        }
    }
}