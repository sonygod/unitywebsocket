using System;
using System.Collections;
using System.Collections.Generic;
using haxe.lang;
using UnityEngine;

using haxe.root;
using UnityEditor.Callbacks;
using UnityEngine.UI;
using web.proto;

public class TestWebSocket : MonoBehaviour {
   

    public string Text;
    // Use this for initialization
	void Start ()
    {

    TestPackBuilder.main();


      Client.main();
     

    }

    
  
}
