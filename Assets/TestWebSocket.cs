using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Reflection;
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

    // Use this for initialization
    void Start()
    {

     
        TestPackBuilder.main(); //初始化
        UnityThreadHelper.EnsureHelper(); //线程初始化，这个必须要在开始定义。

        client = new Client();

        client.testPlayer.addEventListener("onOpen", onCSOpen);
        client.onLoginCS = onLogin;
        client.onRegCS = onReg;
        client.onSocketCloseCS = onSocketClose;
        client.onSocketOpenCS = onSocketOpen;
        client.onSocketErrorCS = onSocketError;
        client.connectWithIP("144.48.4.186", 9002);//这里改成你自己的ip

        client.onGlobalError = onGlobalError;
        client.testPlayer.dispatchEvent(new CEvent("onOpen"),this );

    }

    private void onGlobalError(ErrorEventCS obj)
    {
      
        Debug.Log("服务器返回错误"+obj.text);//你需要在这里switch 一下各种事件的处理。
    }

    private void onCSOpen(CEvent evt)
    {
        var ps = evt.eventParams;

        Debug.Log("事件听到了？"+ps);
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

        //reg();
        loginWithPass();



    }
    //注册

    void reg()
    {
      bool can=  client.regist("13060669789878","123456");

      if (!can)
      {
          Debug.Log("注册账号不合法");
      }
    }

    //用openid登陆
    void login()
    {
        client.LoginWithOpenID("o3-Lq5rodJ5LmZdNTZac8mHVvp48"); //用openid登陆。
    }


    void loginWithPass()
    {
        client.Login("13060669337","123456");
    }
    //socket关闭

    private void onSocketClose()
    {
        Debug.Log("被远程关闭 ");
    }

    //注册成功
    private void onReg(HallEvent HallEvent)
    {
        Debug.Log("注册发回消息");

        haxe.Json.stringify(HallEvent, null, null);


    }

    //登陆成功
    private void onLogin(HallEvent HallEvent)
    {
        // UnityThreadHelper.ma.Dispatch(() =>
        //切换到主线程才可以调用unity的函数。
        UnityThreadHelper.Dispatcher.Dispatch(() =>
        {
            Debug.Log("登陆成功");
            Debug.Log(HallEvent);


            TinyPlayerCS pp = ConvertTool.ConvertPlayer<TinyPlayerCS>(HallEvent.player);


            Debug.Log(JsonConvert.SerializeObject(pp));
        });
    }
}