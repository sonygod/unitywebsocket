// Generated by Haxe 4.0.2+606b176a3
using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
public class Client {
	
	public Client() {
		unchecked {
			#line 61 "C:\\projects\\BCGAME\\sangong\\src\\Client.hx"
			global::haxe.Log.trace.__hx_invoke2_o(default(double), "\u662f\u5426\u6211\u7684\u7248\u672c\uff1f", default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"new", "Client", "src/Client.hx"}, new int[]{1981972957}, new double[]{((double) (61) )}));
			#line 63 "C:\\projects\\BCGAME\\sangong\\src\\Client.hx"
			global::utils.AES_Test.test();
			object a = new global::haxe.lang.DynamicObject(new int[]{97}, new object[]{"\u4e2d\u6587\u6d4b\u8bd5"}, new int[]{}, new double[]{});
			#line 66 "C:\\projects\\BCGAME\\sangong\\src\\Client.hx"
			global::Client.testThread();
			#line 68 "C:\\projects\\BCGAME\\sangong\\src\\Client.hx"
			global::haxe.io.Bytes b = global::org.msgpack.MsgPack.encode(a);
			object c = global::org.msgpack.MsgPack.decode(b, null);
			#line 71 "C:\\projects\\BCGAME\\sangong\\src\\Client.hx"
			global::haxe.Log.trace.__hx_invoke2_o(default(double), global::haxe.lang.Runtime.getField(c, "a", 97, true), default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"new", "Client", "src/Client.hx"}, new int[]{1981972957}, new double[]{((double) (71) )}));
			#line 75 "C:\\projects\\BCGAME\\sangong\\src\\Client.hx"
			global::haxe.lang.Function replacer = null;
			#line 75 "C:\\projects\\BCGAME\\sangong\\src\\Client.hx"
			string space = null;
			#line 75 "C:\\projects\\BCGAME\\sangong\\src\\Client.hx"
			string a1 = global::haxe.format.JsonPrinter.print(((object) (a) ), replacer, space);
			object b1 = new global::haxe.format.JsonParser(((string) (a1) )).doParse();
			#line 79 "C:\\projects\\BCGAME\\sangong\\src\\Client.hx"
			global::web.proto.WebEventDispatch.getInstance().addEventListener(((string) ("error") ), ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "onErrorFromServer", 1415277398)) ), default(object), default(object), default(object));
			#line 81 "C:\\projects\\BCGAME\\sangong\\src\\Client.hx"
			this.code = global::haxe.root.Random.@string(32, null);
		}
		#line default
	}
	
	
	public static void main() {
		#line 57 "C:\\projects\\BCGAME\\sangong\\src\\Client.hx"
		new global::Client();
	}
	#line default
	
	public static void testThread() {
		unchecked {
			#line 94 "C:\\projects\\BCGAME\\sangong\\src\\Client.hx"
			global::sys.thread._Thread.HaxeThread this1 = global::sys.thread._Thread.HaxeThread.@get(global::System.Threading.Thread.CurrentThread);
			#line 94 "C:\\projects\\BCGAME\\sangong\\src\\Client.hx"
			global::sys.thread._Thread.HaxeThread me = ((global::sys.thread._Thread.HaxeThread) (this1) );
			global::sys.thread._Thread.Thread_Impl_.create(new global::Client_testThread_95__Fun(me));
			#line 100 "C:\\projects\\BCGAME\\sangong\\src\\Client.hx"
			string result = global::haxe.lang.Runtime.toString(global::sys.thread._Thread.Thread_Impl_.readMessage(true));
			global::haxe.Log.trace.__hx_invoke2_o(default(double), global::haxe.lang.Runtime.concat("\u7ebf\u7a0b", result), default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"testThread", "Client", "src/Client.hx"}, new int[]{1981972957}, new double[]{((double) (101) )}));
			#line 103 "C:\\projects\\BCGAME\\sangong\\src\\Client.hx"
			if (( result == null )) {
				#line 104 "C:\\projects\\BCGAME\\sangong\\src\\Client.hx"
				throw global::haxe.lang.HaxeException.wrap("\u4e0d\u652f\u6301\u7ebf\u7a0b");
			}
			
			#line 107 "C:\\projects\\BCGAME\\sangong\\src\\Client.hx"
			global::haxe.MainLoop.addThread(( (( global::Client_testThread_107__Fun.__hx_current != null )) ? (global::Client_testThread_107__Fun.__hx_current) : (global::Client_testThread_107__Fun.__hx_current = ((global::Client_testThread_107__Fun) (new global::Client_testThread_107__Fun()) )) ));
		}
		#line default
	}
	
	
	public event global::System.Action<int> eventTest;
	
	public global::client.RoomCS xx;
	
	public global::client.HallCS hall;
	
	public global::System.Action onSocketOpenCS;
	
	public global::System.Action onSocketCloseCS;
	
	public global::System.Action<object> onSocketErrorCS;
	
	public global::System.Action<global::web.proto.HallEvent> onLoginCS;
	
	public global::System.Action<global::web.proto.HallEvent> onRegCS;
	
	public global::System.Action<global::web.proto.ErrorEventCS> onGlobalError;
	
	public global::client.PlayerCS testPlayer;
	
	public string code;
	
	public virtual void testConvert(global::web.TinyPlayerCS p) {
		unchecked {
			#line 85 "C:\\projects\\BCGAME\\sangong\\src\\Client.hx"
			global::haxe.Log.trace.__hx_invoke2_o(default(double), "hello unity ?", default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"testConvert", "Client", "src/Client.hx"}, new int[]{1981972957}, new double[]{((double) (85) )}));
			global::haxe.Log.trace.__hx_invoke2_o(default(double), global::haxe.lang.Runtime.concat("haxe convert", global::haxe.root.Std.@string(p.id)), default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"testConvert", "Client", "src/Client.hx"}, new int[]{1981972957}, new double[]{((double) (86) )}));
			#line 88 "C:\\projects\\BCGAME\\sangong\\src\\Client.hx"
			object pp = ((object) (p) );
			#line 90 "C:\\projects\\BCGAME\\sangong\\src\\Client.hx"
			global::haxe.Log.trace.__hx_invoke2_o(default(double), global::haxe.lang.Runtime.concat("after", global::haxe.root.Std.@string(global::haxe.lang.Runtime.getField(pp, "id", 23515, true))), default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"testConvert", "Client", "src/Client.hx"}, new int[]{1981972957}, new double[]{((double) (90) )}));
		}
		#line default
	}
	
	
	public virtual void onErrorFromServer(global::web.proto.ErrorEventCS e) {
		#line 116 "C:\\projects\\BCGAME\\sangong\\src\\Client.hx"
		this.onGlobalError.Invoke(((global::web.proto.ErrorEventCS) (e) ));
	}
	#line default
	
	public virtual void connectWithIP(string ip, int port) {
		unchecked {
			#line 119 "C:\\projects\\BCGAME\\sangong\\src\\Client.hx"
			global::Client _gthis = this;
			global::haxe.Log.trace.__hx_invoke2_o(default(double), global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("", ip), ":"), global::haxe.lang.Runtime.toString(port)), default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"connectWithIP", "Client", "src/Client.hx"}, new int[]{1981972957}, new double[]{((double) (120) )}));
			#line 122 "C:\\projects\\BCGAME\\sangong\\src\\Client.hx"
			global::haxe.MainLoop.addThread(new global::Client_connectWithIP_122__Fun(port, ip, _gthis));
		}
		#line default
	}
	
	
	public virtual void quit() {
		#line 131 "C:\\projects\\BCGAME\\sangong\\src\\Client.hx"
		global::web.SocketAsync.socket.close();
		global::web.SocketAsync.socket = null;
	}
	#line default
	
	public virtual void onOpen() {
		unchecked {
			#line 141 "C:\\projects\\BCGAME\\sangong\\src\\Client.hx"
			global::haxe.Log.trace.__hx_invoke2_o(default(double), "\u63e1\u624b", default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"onOpen", "Client", "src/Client.hx"}, new int[]{1981972957}, new double[]{((double) (141) )}));
			this.onSocketOpenCS.Invoke();
		}
		#line default
	}
	
	
	public virtual void onClose() {
		unchecked {
			#line 150 "C:\\projects\\BCGAME\\sangong\\src\\Client.hx"
			global::haxe.Log.trace.__hx_invoke2_o(default(double), "oncloese", default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"onClose", "Client", "src/Client.hx"}, new int[]{1981972957}, new double[]{((double) (150) )}));
			this.onSocketCloseCS.Invoke();
		}
		#line default
	}
	
	
	public virtual void onError(string e) {
		unchecked {
			#line 155 "C:\\projects\\BCGAME\\sangong\\src\\Client.hx"
			global::haxe.Log.trace.__hx_invoke2_o(default(double), "onError", default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"onError", "Client", "src/Client.hx"}, new int[]{1981972957}, new double[]{((double) (155) )}));
			#line 157 "C:\\projects\\BCGAME\\sangong\\src\\Client.hx"
			this.onSocketErrorCS.Invoke(((object) (e) ));
		}
		#line default
	}
	
	
}



#pragma warning disable 109, 114, 219, 429, 168, 162
public class Client_connectWithIP_122__Fun : global::haxe.lang.Function {
	
	public Client_connectWithIP_122__Fun(int port, string ip, global::Client _gthis) : base(0, 0) {
		#line 123 "C:\\projects\\BCGAME\\sangong\\src\\Client.hx"
		this.port = port;
		#line 123 "C:\\projects\\BCGAME\\sangong\\src\\Client.hx"
		this.ip = ip;
		#line 123 "C:\\projects\\BCGAME\\sangong\\src\\Client.hx"
		this._gthis = _gthis;
	}
	#line default
	
	public override object __hx_invoke0_o() {
		#line 123 "C:\\projects\\BCGAME\\sangong\\src\\Client.hx"
		global::web.SocketAsync.installSocket(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("", this.ip), ":"), global::haxe.lang.Runtime.toString(this.port)), ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this._gthis, "onOpen", 1816005769)) ), ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this._gthis, "onClose", 1587590681)) ), ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this._gthis, "onError", 157772329)) ), null);
		#line 123 "C:\\projects\\BCGAME\\sangong\\src\\Client.hx"
		return null;
	}
	#line default
	
	public int port;
	
	public string ip;
	
	public global::Client _gthis;
	
}



#pragma warning disable 109, 114, 219, 429, 168, 162
public class Client_testThread_95__Fun : global::haxe.lang.Function {
	
	public Client_testThread_95__Fun(global::sys.thread._Thread.HaxeThread me) : base(0, 0) {
		#line 95 "C:\\projects\\BCGAME\\sangong\\src\\Client.hx"
		this.me = me;
	}
	#line default
	
	public override object __hx_invoke0_o() {
		#line 97 "C:\\projects\\BCGAME\\sangong\\src\\Client.hx"
		{
			#line 97 "C:\\projects\\BCGAME\\sangong\\src\\Client.hx"
			global::haxe.lang.Function replacer = null;
			#line 97 "C:\\projects\\BCGAME\\sangong\\src\\Client.hx"
			string space = null;
			#line 97 "C:\\projects\\BCGAME\\sangong\\src\\Client.hx"
			global::haxe.format.JsonPrinter.print(((object) ("xxxxx") ), replacer, space);
		}
		
		#line 98 "C:\\projects\\BCGAME\\sangong\\src\\Client.hx"
		((global::sys.thread._Thread.HaxeThread) (this.me) ).sendMessage(((object) ("Done") ));
		#line 95 "C:\\projects\\BCGAME\\sangong\\src\\Client.hx"
		return null;
	}
	#line default
	
	public global::sys.thread._Thread.HaxeThread me;
	
}



#pragma warning disable 109, 114, 219, 429, 168, 162
public class Client_testThread_107__Fun : global::haxe.lang.Function {
	
	public Client_testThread_107__Fun() : base(0, 0) {
	}
	
	
	public static global::Client_testThread_107__Fun __hx_current;
	
	public override object __hx_invoke0_o() {
		unchecked {
			#line 108 "C:\\projects\\BCGAME\\sangong\\src\\Client.hx"
			{
				#line 108 "C:\\projects\\BCGAME\\sangong\\src\\Client.hx"
				global::haxe.lang.Function replacer1 = null;
				#line 108 "C:\\projects\\BCGAME\\sangong\\src\\Client.hx"
				string space1 = null;
				#line 108 "C:\\projects\\BCGAME\\sangong\\src\\Client.hx"
				global::haxe.format.JsonPrinter.print(((object) ("xxxxx") ), replacer1, space1);
			}
			
			#line 110 "C:\\projects\\BCGAME\\sangong\\src\\Client.hx"
			global::haxe.Log.trace.__hx_invoke2_o(default(double), "\u652f\u6301\u7ebf\u7a0b\u5417\uff1f", default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"testThread", "Client", "src/Client.hx"}, new int[]{1981972957}, new double[]{((double) (110) )}));
			#line 107 "C:\\projects\\BCGAME\\sangong\\src\\Client.hx"
			return null;
		}
		#line default
	}
	
	
}


