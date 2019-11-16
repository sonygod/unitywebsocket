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


    private PlayerCS self; //自己。

    // Use this for initialization
    void Start()
    {

      
        TestPackBuilder.main(); //初始化
        UnityThreadHelper.EnsureHelper(); //线程初始化，这个必须要在开始定义。



        TinyPlayerCS pp = new TinyPlayerCS();

        pp.id = 2009;

      

       
        client = new Client();

        //client.testPlayer.addEventListener("onOpen", onCSOpen);
        client.testConvert(pp);
        Debug.Log("是否解决了？");
        client.onSocketCloseCS = onSocketClose;
        client.onSocketOpenCS = onSocketOpen;
        client.onSocketErrorCS = onSocketError;
        client.connectWithIP("144.48.4.186", 9002); //这里改成你自己的ip

        client.onGlobalError = onGlobalError;
        // client.testPlayer.dispatchEvent(new CEvent("onOpen"),this );


        self = new PlayerCS(null);
        self.@on();//这里添加倾听器，如果要移除用off
        self.addEventListener(HallEvent.LOGIN, onLogin);

        self.addEventListener(HallEvent.OnReg, onReg);
        TestEventDispathFromHaxe();

      




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
        Debug.Log("收到事件拉。" + evt.eventParams);
    }

    private void onGlobalError(ErrorEventCS obj)
    {
        Debug.Log("服务器返回错误" + obj.text); //你需要在这里switch 一下各种事件的处理。
    }

    private void onCSOpen(CEvent evt)
    {
        var ps = evt.eventParams;

        Debug.Log("事件听到了？" + ps);
    }

    //socket错误
    private void onSocketError(object obj)
    {
        Debug.LogError("socket error" + obj.ToString());
    }
    //首次链接上服务器。

    private void onSocketOpen()
    {
        Debug.Log("链接成功了");


        //尝试登陆。

        Debug.Log("尝试登陆"); //这里可以正式开始了


        UnityThreadHelper.Dispatcher.Dispatch(() => { readyStart(); }); //注意，这里是socket线程切换到主线程
    }
    //这里才真正开始。

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
        //client.quit(); //退出登录，退出socket,切换账号。
    }
}