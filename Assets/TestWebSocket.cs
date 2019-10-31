using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using com.huaqian;
using gameRoom;
using haxe.lang;
using UnityEngine;
using haxe.root;
using UnityEditor.Callbacks;
using UnityEngine.UI;
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


        client.onLoginCS = onLogin;
        client.onRegCS = onReg;
        client.onSocketCloseCS = onSocketClose;
        client.onSocketOpenCS = onSocketOpen;
        client.onSocketErrorCS = onSocketError;
        client.connectWithIP("192.168.1.134", 9001);
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

        Debug.Log("尝试登陆");

        client.Login("o3-Lq5rodJ5LmZdNTZac8mHVvp48");
    }
    //socket关闭

    private void onSocketClose()
    {
        Debug.Log("被远程关闭 ");
    }

    //注册成功
    private void onReg(HallEvent HallEvent)
    {
        Debug.Log("注册成功");
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