// Generated by Haxe 4.0.0+ef18b627e
using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
public class Client {
	
	public Client() {
		unchecked {
			#line 41 "D:\\project\\sangong\\sangong\\src\\Client.hx"
			global::haxe.Log.trace.__hx_invoke2_o(default(double), "\u662f\u5426\u6211\u7684\u7248\u672c\uff1f", default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"new", "Client", "src/Client.hx"}, new int[]{1981972957}, new double[]{((double) (41) )}));
			#line 43 "D:\\project\\sangong\\sangong\\src\\Client.hx"
			object a = new global::haxe.lang.DynamicObject(new int[]{97}, new object[]{"\u4e2d\u6587\u6d4b\u8bd5"}, new int[]{}, new double[]{});
			#line 45 "D:\\project\\sangong\\sangong\\src\\Client.hx"
			global::haxe.io.Bytes b = global::org.msgpack.MsgPack.encode(a);
			object c = global::org.msgpack.MsgPack.decode(b, null);
			#line 48 "D:\\project\\sangong\\sangong\\src\\Client.hx"
			global::haxe.Log.trace.__hx_invoke2_o(default(double), global::haxe.lang.Runtime.getField(c, "a", 97, true), default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"new", "Client", "src/Client.hx"}, new int[]{1981972957}, new double[]{((double) (48) )}));
			#line 50 "D:\\project\\sangong\\sangong\\src\\Client.hx"
			global::haxe.lang.Function replacer = null;
			#line 50 "D:\\project\\sangong\\sangong\\src\\Client.hx"
			string space = null;
			#line 50 "D:\\project\\sangong\\sangong\\src\\Client.hx"
			string a1 = global::haxe.format.JsonPrinter.print(((object) (a) ), replacer, space);
			object b1 = new global::haxe.format.JsonParser(((string) (a1) )).doParse();
			#line 53 "D:\\project\\sangong\\sangong\\src\\Client.hx"
			global::web.proto.WebEventDispatch.getInstance().addEventListener(((string) ("login") ), ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "onLogin", 254900170)) ), default(object), default(object), default(object));
			global::web.proto.WebEventDispatch.getInstance().addEventListener(((string) ("hall_Reg") ), ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "onReg", 846097781)) ), default(object), default(object), default(object));
		}
		#line default
	}
	
	
	public static void main() {
		#line 37 "D:\\project\\sangong\\sangong\\src\\Client.hx"
		new global::Client();
	}
	#line default
	
	public global::System.Action onSocketOpenCS;
	
	public global::System.Action onSocketCloseCS;
	
	public global::System.Action<object> onSocketErrorCS;
	
	public global::System.Action<global::web.proto.HallEvent> onLoginCS;
	
	public global::System.Action<global::web.proto.HallEvent> onRegCS;
	
	public virtual void connectWithIP(string ip, int port) {
		unchecked {
			#line 58 "D:\\project\\sangong\\sangong\\src\\Client.hx"
			global::haxe.Log.trace.__hx_invoke2_o(default(double), global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("", ip), ":"), global::haxe.lang.Runtime.toString(port)), default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"connectWithIP", "Client", "src/Client.hx"}, new int[]{1981972957}, new double[]{((double) (58) )}));
			global::web.SocketAsync.installSocket(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("", ip), ":"), global::haxe.lang.Runtime.toString(port)), ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "onOpen", 1816005769)) ), ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "onClose", 1587590681)) ), ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "onError", 157772329)) ), null);
		}
		#line default
	}
	
	
	public virtual void onOpen() {
		unchecked {
			#line 68 "D:\\project\\sangong\\sangong\\src\\Client.hx"
			global::haxe.Log.trace.__hx_invoke2_o(default(double), "\u63e1\u624b", default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"onOpen", "Client", "src/Client.hx"}, new int[]{1981972957}, new double[]{((double) (68) )}));
			#line 77 "D:\\project\\sangong\\sangong\\src\\Client.hx"
			this.onSocketOpenCS.Invoke();
		}
		#line default
	}
	
	
	public virtual void LoginWithOpenID(string openid) {
		unchecked {
			#line 86 "D:\\project\\sangong\\sangong\\src\\Client.hx"
			object tp = new global::haxe.lang.DynamicObject(new int[]{23515, 563366437}, new object[]{((object) (-1) ), openid}, new int[]{}, new double[]{});
			global::web.SocketAsync.sendCS(((int) (((uint) (1) )) ), ((int) (8) ), -1, global::org.msgpack.MsgPack.encode(tp), null);
		}
		#line default
	}
	
	
	public virtual void Login(string mobile, string password) {
		unchecked {
			#line 96 "D:\\project\\sangong\\sangong\\src\\Client.hx"
			object tp = null;
			#line 96 "D:\\project\\sangong\\sangong\\src\\Client.hx"
			{
				#line 96 "D:\\project\\sangong\\sangong\\src\\Client.hx"
				string __temp_odecl1 = global::haxe.crypto.Md5.encode(password);
				#line 96 "D:\\project\\sangong\\sangong\\src\\Client.hx"
				tp = new global::haxe.lang.DynamicObject(new int[]{1064807522, 1221600027}, new object[]{mobile, __temp_odecl1}, new int[]{}, new double[]{});
			}
			
			#line 97 "D:\\project\\sangong\\sangong\\src\\Client.hx"
			global::web.SocketAsync.sendCS(((int) (((uint) (1) )) ), ((int) (8) ), -1, global::org.msgpack.MsgPack.encode(tp), null);
		}
		#line default
	}
	
	
	public virtual bool regist(string mobile, string ps) {
		unchecked {
			#line 105 "D:\\project\\sangong\\sangong\\src\\Client.hx"
			global::haxe.root.EReg r = new global::haxe.root.EReg("1\\d{10}", "");
			#line 107 "D:\\project\\sangong\\sangong\\src\\Client.hx"
			bool b = r.match(mobile);
			if (( ( ( ( ( ps == null ) || ( mobile == null ) ) || ( mobile.Length != 11 ) ) || ( ps.Length < 6 ) ) ||  ! (b)  )) {
				#line 109 "D:\\project\\sangong\\sangong\\src\\Client.hx"
				global::haxe.Log.trace.__hx_invoke2_o(default(double), "\u6ce8\u518c\u8d26\u53f7\u6216\u8005\u5bc6\u7801\u4e0d\u7b26\u5408\u6761\u4ef6", default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"regist", "Client", "src/Client.hx"}, new int[]{1981972957}, new double[]{((double) (109) )}));
				return false;
			}
			
			#line 113 "D:\\project\\sangong\\sangong\\src\\Client.hx"
			string password = global::haxe.crypto.Md5.encode(ps);
			object tp = new global::haxe.lang.DynamicObject(new int[]{1064807522, 1221600027}, new object[]{mobile, password}, new int[]{}, new double[]{});
			#line 116 "D:\\project\\sangong\\sangong\\src\\Client.hx"
			global::web.SocketAsync.sendCS(((int) (((uint) (1) )) ), ((int) (9) ), -1, global::org.msgpack.MsgPack.encode(tp), null);
			#line 118 "D:\\project\\sangong\\sangong\\src\\Client.hx"
			return true;
		}
		#line default
	}
	
	
	public virtual void onReg(global::web.proto.HallEvent e) {
		unchecked {
			#line 122 "D:\\project\\sangong\\sangong\\src\\Client.hx"
			global::haxe.lang.Function replacer = null;
			#line 122 "D:\\project\\sangong\\sangong\\src\\Client.hx"
			string space = null;
			#line 122 "D:\\project\\sangong\\sangong\\src\\Client.hx"
			global::haxe.Log.trace.__hx_invoke2_o(default(double), global::haxe.lang.Runtime.concat("\u6ce8\u518c\u6210\u529f ", global::haxe.format.JsonPrinter.print(((object) (e.player) ), replacer, space)), default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"onReg", "Client", "src/Client.hx"}, new int[]{1981972957}, new double[]{((double) (122) )}));
			this.onRegCS.Invoke(((global::web.proto.HallEvent) (e) ));
		}
		#line default
	}
	
	
	public virtual void onLogin(global::web.proto.HallEvent e) {
		unchecked {
			#line 127 "D:\\project\\sangong\\sangong\\src\\Client.hx"
			global::haxe.lang.Function replacer = null;
			#line 127 "D:\\project\\sangong\\sangong\\src\\Client.hx"
			string space = null;
			#line 127 "D:\\project\\sangong\\sangong\\src\\Client.hx"
			global::haxe.Log.trace.__hx_invoke2_o(default(double), global::haxe.lang.Runtime.concat("\u767b\u9646\u6210\u529f ", global::haxe.format.JsonPrinter.print(((object) (e.player) ), replacer, space)), default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"onLogin", "Client", "src/Client.hx"}, new int[]{1981972957}, new double[]{((double) (127) )}));
			#line 129 "D:\\project\\sangong\\sangong\\src\\Client.hx"
			object p = e.player;
			#line 131 "D:\\project\\sangong\\sangong\\src\\Client.hx"
			global::haxe.root.Array k = global::haxe.root.Reflect.fields(p);
			this.onLoginCS.Invoke(((global::web.proto.HallEvent) (e) ));
		}
		#line default
	}
	
	
	public virtual void onClose() {
		unchecked {
			#line 138 "D:\\project\\sangong\\sangong\\src\\Client.hx"
			global::haxe.Log.trace.__hx_invoke2_o(default(double), "oncloese", default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"onClose", "Client", "src/Client.hx"}, new int[]{1981972957}, new double[]{((double) (138) )}));
			this.onSocketCloseCS.Invoke();
		}
		#line default
	}
	
	
	public virtual void onError(string e) {
		unchecked {
			#line 143 "D:\\project\\sangong\\sangong\\src\\Client.hx"
			global::haxe.Log.trace.__hx_invoke2_o(default(double), "onError", default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"onError", "Client", "src/Client.hx"}, new int[]{1981972957}, new double[]{((double) (143) )}));
			#line 145 "D:\\project\\sangong\\sangong\\src\\Client.hx"
			this.onSocketErrorCS.Invoke(((object) (e) ));
		}
		#line default
	}
	
	
}


