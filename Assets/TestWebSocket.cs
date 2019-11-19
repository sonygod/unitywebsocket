
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
using web;

public class TestWebSocket : MonoBehaviour
{
    public string Text;

    private Client client;


    private PlayerCS self; //自己.
    private HallCS hall;

    public TinyPlayerCS currentPlayer { get; private set; }
    public RoomCS currentRoom { get; private set; }

    // Use this for initialization
    void Start()
    {


        TestPackBuilder.main(); //初始化
        UnityThreadHelper.EnsureHelper(); //线程初始化,这个必须要在开始定义.



        TinyPlayerCS pp = new TinyPlayerCS();

        pp.id = 2009;




        client = new Client();

        client.testUint((uint)3312);

        //client.testPlayer.addEventListener("onOpen", onCSOpen);
       
        Debug.Log("是否解决了?");
        client.onSocketCloseCS = onSocketClose;
        client.onSocketOpenCS = onSocketOpen;
        client.onSocketErrorCS = onSocketError;
        client.connectWithIP("192.168.1.134", 9003); //这里改成你自己的ip
                                                     ///  client.connectWithIP("127.0.0.1", 9003); //这里改成你自己的ip
        client.onGlobalError = onGlobalError;
        // client.testPlayer.dispatchEvent(new CEvent("onOpen"),this );


        self = new PlayerCS(null);
        self.addEvent();//这里添加倾听器,如果要移除用off
        self.addEventListener(HallEvent.LOGIN, onLogin);

        self.addEventListener(HallEvent.OnReg, onReg);
        TestEventDispathFromHaxe();


        //---------------新增-------------------
        hall = new HallCS();//创建大厅
        hall.addEvent();//这个一定不能删除。
        hall.addEventListener(RoomEvent.CREATE_ROOM, onCreateRoom);
        hall.addEventListener(RoomEvent.JOIN_ROOM,onJoinRoom);





    }

    private void onCreateRoom(CEvent evt)
    {
        UnityThreadHelper.Dispatcher.Dispatch(() =>
        {
            Debug.Log("创建房间成功" + evt.eventParams);
            //  var c = (TinyRoomCS)evt.eventParams;

            RoomEvent e = (RoomEvent)evt.eventParams;

            TinyRoomCS c = ConvertTool.ConvertRoom(e.room);


            Debug.Log(c);

            var room = new RoomCS(e.room);
            room.addEvent();//这里是内部倾听，不能删除，否则所有事件无效。
            room.addEventListener(RoomEvent.JOIN_ROOM, onJoinRoom);
            room.addEventListener(RoomEvent.DESTORY, onDestoryRoom);//删除和退出一样。
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
            var parms = evt.eventParams;

            Debug.Log("完成一局，结果返回" + JsonConvert.SerializeObject(parms));
        });
    }



    //发牌 准备
    private void onDispath(CEvent evt)
    {
        UnityThreadHelper.Dispatcher.Dispatch(() =>
        {
            //  throw new NotImplementedException();

            var parms = evt.eventParams;

            Debug.Log("开始发牌参数" + JsonConvert.SerializeObject(parms));
        });
    }

    private void onGetRoomInfo(CEvent evt)
    {
        UnityThreadHelper.Dispatcher.Dispatch(() =>
        {
            var parms = evt.eventParams;
            Debug.Log("房间参数" + JsonConvert.SerializeObject(parms));
        });
    }

    private void onDestoryRoom(CEvent evt)
    {
        UnityThreadHelper.Dispatcher.Dispatch(() =>
        {
            var parms = evt.eventParams;
            Debug.Log("删除房间" + JsonConvert.SerializeObject(parms));

            hall.addEventListener(RoomEvent.JOIN_ROOM, onJoinRoom); //这里补回到大厅。
        });
    }

    private void onJoinRoom(CEvent evt)
    {
        UnityThreadHelper.Dispatcher.Dispatch(() =>
        {
            RoomEvent parms =(RoomEvent) evt.eventParams;

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
            HallEvent e = (HallEvent)evt.eventParams;
            Debug.Log("unity 登陆成功");
            Debug.Log(e);


            TinyPlayerCS pp = ConvertTool.ConvertPlayer<TinyPlayerCS>(e.player);

            currentPlayer = pp;

            self.installData(e.player);//这一定要设置。
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


        self.Login("13060669337", "123456");

        //  self.regist()注册
        // self.forgotpassWord()忘记密码
        //self.changeUserInfo()//换头像
    }

    private void onSocketClose()
    {
        Debug.Log("被远程关闭 ");
    }

    void OnApplicationQuit()
    {
        //client.quit(); //退出登录,退出socket,切换账号.
    }


    void OnGUI()
    {
        //进入/创建机器人房间
        if (GUI.Button(new Rect(0, 0, 50, 50), "creat"))
        {


            if (currentPlayer != null)
            {
                TinyRoomCS room = new TinyRoomCS();

                room.gameID = 2001;//机器人三公，参考文档
                room.gambling = 1;// // 底注 不同房间准入不同,要计算player还有多少money.
                room.threshold = 1;//准入.


                room.owerID = (int)currentPlayer.id;//这个是当前玩家的id.这里测试随便填。


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


                var data=currentRoom.data;
                self.gameAddBetCS(2);//这里是倍数。
            }
            else
            {
                Debug.Log("请登陆");
            }


        }


        //下注
        if (GUI.Button(new Rect(60, 60, 50, 50), "quite"))
        {




            if (currentPlayer != null&&currentRoom!=null)
            {


                var data = currentRoom.data;


                TinyRoomCS c = ConvertTool.ConvertRoom(data);

                if ((int)c.status > 2)
                {
                    Debug.Log("游戏进行中不能退出");

                    return;
                }

                if (self.data == null)
                {
                    Debug.Log("请self.install data");
                    return;
                }

                self.leaveRoom((uint)c.id);
                currentRoom = null;
            }
            else
            {
                Debug.Log("请登陆和创建房间");
            }


        }

    }
}