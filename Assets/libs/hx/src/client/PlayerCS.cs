// Generated by Haxe 4.1.0-rc.1+0d88c583b
using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace client {
	public class PlayerCS : global::CEventDispatcher {
		
		public PlayerCS(object data) : base() {
			unchecked {
				#line 27 "d:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				this.wasAdd = false;
				#line 29 "d:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				{
					#line 31 "d:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
					this.data = data;
					#line 33 "d:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
					this.code = global::haxe.root.Random.@string(32, null);
				}
				
			}
			#line default
		}
		
		
		public object data;
		
		public string code;
		
		public bool wasAdd;
		
		public virtual void dispath() {
			unchecked {
				#line 40 "d:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				( this as global::CEventDispatcher ).dispatchEvent(((global::CEvent) (new global::CEvent("1", 1)) ), ((object) (1) ));
			}
			#line default
		}
		
		
		public virtual void transEvent(object e) {
			#line 45 "d:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
			( this as global::CEventDispatcher ).dispatchEvent(((global::CEvent) (new global::CEvent(global::haxe.lang.Runtime.toString(global::haxe.lang.Runtime.getField(e, "type", 1292432058, false)), e)) ), ((object) (this) ));
		}
		#line default
		
		public virtual void addEvent() {
			unchecked {
				#line 52 "d:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				if (this.wasAdd) {
					#line 53 "d:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
					global::haxe.Log.trace.__hx_invoke2_o(default(double), "<color=#FFFF00>\u4e0d\u80fd\u91cd\u590d\u6dfb\u52a0\u7a83\u542c\u5668\u3002</color", default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"addEvent", "client.PlayerCS", "src/client/PlayerCS.hx"}, new int[]{1981972957}, new double[]{((double) (53) )}));
					return;
				}
				
				#line 56 "d:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				global::web.proto.WebEventDispatch wd = global::web.proto.WebEventDispatch.getInstance();
				#line 65 "d:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				wd.addEventListener(((string) ("getuserInfo") ), ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "onGetInfo", 1877516485)) ), default(object), default(object), default(object));
				wd.addEventListener(((string) ("add_bet") ), ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "onAddBet", 2124987439)) ), default(object), default(object), default(object));
				#line 67 "d:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				wd.addEventListener(((string) ("login") ), ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "onLogin", 254900170)) ), default(object), default(object), default(object));
				wd.addEventListener(((string) ("hall_Reg") ), ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "onReg", 846097781)) ), default(object), default(object), default(object));
				#line 69 "d:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				this.wasAdd = true;
			}
			#line default
		}
		
		
		public virtual void onGetInfo(global::web.proto.PlayerEvent e) {
			#line 73 "d:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
			if (( this.data != null )) {
				#line 74 "d:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				if (((bool) (global::haxe.lang.Runtime.eq(global::haxe.lang.Runtime.getField(this.data, "id", 23515, true), global::haxe.lang.Runtime.getField(e.player, "id", 23515, true))) )) {
					#line 75 "d:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
					this.transEvent(e);
				}
				
			}
			
		}
		#line default
		
		public virtual void onAddBet(global::web.proto.PlayerEvent e) {
			#line 81 "d:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
			if (( this.data != null )) {
				#line 82 "d:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				if (((bool) (global::haxe.lang.Runtime.eq(global::haxe.lang.Runtime.getField(this.data, "id", 23515, true), ((uint) (global::haxe.lang.Runtime.getField_f(e.bling, "playerID", 1213433212, true)) ))) )) {
					#line 83 "d:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
					this.transEvent(e);
				}
				
			}
			
		}
		#line default
		
		public virtual void onLogin(global::web.proto.HallEvent e) {
			#line 89 "d:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
			if (( this.data == null )) {
				#line 90 "d:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				this.transEvent(e);
			}
			
		}
		#line default
		
		public virtual void onReg(global::web.proto.HallEvent e) {
			#line 94 "d:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
			if (( this.data == null )) {
				#line 95 "d:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				this.transEvent(e);
			}
			
		}
		#line default
		
		public virtual void off() {
			#line 102 "d:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
			global::web.proto.WebEventDispatch wd = global::web.proto.WebEventDispatch.getInstance();
			global::haxe.root.Array events = new global::haxe.root.Array(new object[]{((string) ("getuserInfo") ), ((string) ("login") ), ((string) ("hall_Reg") ), ((string) ("add_bet") )});
			#line 105 "d:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
			{
				#line 105 "d:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				int _g = 0;
				#line 105 "d:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				while (( _g < events.length )) {
					#line 105 "d:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
					string e = global::haxe.lang.Runtime.toString(events.__get(_g));
					#line 105 "d:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
					 ++ _g;
					wd.removeEventListener(((string) (e) ), ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "transEvent", 529665746)) ), default(object));
				}
				
			}
			
			#line 108 "d:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
			this.wasAdd = false;
		}
		#line default
		
		public virtual void LoginWithOpenID(string openid) {
			unchecked {
				#line 112 "d:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				object tp = new global::haxe.lang.DynamicObject(new int[]{23515, 563366437}, new object[]{((object) (-1) ), openid}, new int[]{}, new double[]{});
				global::web.SocketAsync.sendCS(((int) (((uint) (1) )) ), ((int) (8) ), -1, global::org.msgpack.MsgPack.encode(tp), null);
			}
			#line default
		}
		
		
		public virtual void Login(string mobile, string password) {
			unchecked {
				#line 122 "d:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				object tp = null;
				#line 122 "d:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				{
					#line 122 "d:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
					string __temp_odecl1 = global::haxe.crypto.Md5.encode(password);
					#line 122 "d:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
					tp = new global::haxe.lang.DynamicObject(new int[]{1064807522, 1221600027}, new object[]{mobile, __temp_odecl1}, new int[]{}, new double[]{});
				}
				
				#line 123 "d:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				global::web.SocketAsync.sendCS(((int) (((uint) (1) )) ), ((int) (8) ), -1, global::org.msgpack.MsgPack.encode(tp), null);
			}
			#line default
		}
		
		
		public virtual bool forgotpassWord(string mobile, string password, string verificationCode) {
			unchecked {
				#line 134 "d:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				if (( verificationCode != this.code )) {
					#line 135 "d:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
					global::haxe.Log.trace.__hx_invoke2_o(default(double), "\u8bf7\u586b\u9a8c\u8bc1\u7801!", default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"forgotpassWord", "client.PlayerCS", "src/client/PlayerCS.hx"}, new int[]{1981972957}, new double[]{((double) (135) )}));
					return false;
				}
				
				#line 139 "d:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				if (global::utils.SQLRex.checkSQL(password)) {
					#line 140 "d:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
					return false;
				}
				
				#line 143 "d:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				object tp = null;
				#line 143 "d:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				{
					#line 143 "d:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
					string __temp_odecl1 = global::haxe.crypto.Md5.encode(password);
					#line 143 "d:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
					tp = new global::haxe.lang.DynamicObject(new int[]{1064807522, 1221600027}, new object[]{mobile, __temp_odecl1}, new int[]{}, new double[]{});
				}
				
				#line 145 "d:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				global::web.SocketAsync.sendCS(((int) (((uint) (1) )) ), ((int) (30) ), -1, global::org.msgpack.MsgPack.encode(tp), null);
				#line 147 "d:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				return true;
			}
			#line default
		}
		
		
		public virtual bool regist(string mobile, string ps) {
			#line 157 "d:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
			return this.regist(mobile, ps, 0);
		}
		#line default
		
		public virtual bool regist(string mobile, string ps, object refID) {
			unchecked {
				#line 157 "d:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				int refID1 = ( (( refID == default(object) )) ? (0) : (((int) (global::haxe.lang.Runtime.toInt(refID)) )) );
				global::haxe.root.EReg r = new global::haxe.root.EReg("1\\d{10}", "");
				#line 160 "d:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				bool b = r.match(mobile);
				if (( ( ( ( ( ps == null ) || ( mobile == null ) ) || ( mobile.Length != 11 ) ) || ( ps.Length < 6 ) ) ||  ! (b)  )) {
					#line 162 "d:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
					global::haxe.Log.trace.__hx_invoke2_o(default(double), "\u6ce8\u518c\u8d26\u53f7\u6216\u8005\u5bc6\u7801\u4e0d\u7b26\u5408\u6761\u4ef6", default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"regist", "client.PlayerCS", "src/client/PlayerCS.hx"}, new int[]{1981972957}, new double[]{((double) (162) )}));
					return false;
				}
				
				#line 166 "d:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				string password = global::haxe.crypto.Md5.encode(ps);
				object tp = new global::haxe.lang.DynamicObject(new int[]{1064807522, 1221600027, 1542393958}, new object[]{mobile, password, ((object) (refID1) )}, new int[]{}, new double[]{});
				#line 169 "d:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				global::web.SocketAsync.sendCS(((int) (((uint) (1) )) ), ((int) (9) ), -1, global::org.msgpack.MsgPack.encode(tp), null);
				#line 171 "d:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				return true;
			}
			#line default
		}
		
		
		public virtual bool changeUserInfo(string avatar) {
			unchecked {
				#line 179 "d:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				if (global::utils.SQLRex.checkSQL(avatar)) {
					#line 180 "d:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
					global::haxe.Log.trace.__hx_invoke2_o(default(double), "\u4e0d\u5408\u6cd5", default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"changeUserInfo", "client.PlayerCS", "src/client/PlayerCS.hx"}, new int[]{1981972957}, new double[]{((double) (180) )}));
					return false;
				}
				
				#line 183 "d:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				if (( this.data == null )) {
					#line 184 "d:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
					global::haxe.Log.trace.__hx_invoke2_o(default(double), "\u767b\u9646\u540e\u8bf7\u8d4b\u503c\u7ed9data", default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"changeUserInfo", "client.PlayerCS", "src/client/PlayerCS.hx"}, new int[]{1981972957}, new double[]{((double) (184) )}));
					return false;
				}
				
				#line 188 "d:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				object tp = null;
				#line 188 "d:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				{
					#line 188 "d:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
					object __temp_odecl1 = global::haxe.lang.Runtime.getField(this.data, "id", 23515, true);
					#line 188 "d:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
					tp = new global::haxe.lang.DynamicObject(new int[]{23515, 2052882457}, new object[]{__temp_odecl1, avatar}, new int[]{}, new double[]{});
				}
				
				#line 190 "d:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				global::haxe.lang.Function replacer = null;
				#line 190 "d:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				string space = null;
				#line 190 "d:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				global::haxe.Log.trace.__hx_invoke2_o(default(double), global::haxe.lang.Runtime.concat("\u4f20\u8f93", global::haxe.format.JsonPrinter.print(((object) (tp) ), replacer, space)), default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"changeUserInfo", "client.PlayerCS", "src/client/PlayerCS.hx"}, new int[]{1981972957}, new double[]{((double) (190) )}));
				#line 192 "d:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				global::web.SocketAsync.sendCS(((int) (((uint) (1) )) ), ((int) (31) ), -1, global::org.msgpack.MsgPack.encode(tp), null);
				#line 194 "d:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				return true;
			}
			#line default
		}
		
		
		public virtual bool createRoom(object data) {
			unchecked {
				#line 200 "d:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				global::haxe.lang.Function replacer = null;
				#line 200 "d:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				string space = null;
				#line 200 "d:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				global::haxe.Log.trace.__hx_invoke2_o(default(double), global::haxe.lang.Runtime.concat("\u521b\u5efa\u623f\u95f4", global::haxe.format.JsonPrinter.print(((object) (data) ), replacer, space)), default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"createRoom", "client.PlayerCS", "src/client/PlayerCS.hx"}, new int[]{1981972957}, new double[]{((double) (200) )}));
				#line 202 "d:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				global::haxe.Log.trace.__hx_invoke2_o(default(double), global::haxe.lang.Runtime.concat("ownerid=", global::haxe.root.Std.@string(global::haxe.lang.Runtime.getField(data, "owerID", 694510256, true))), default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"createRoom", "client.PlayerCS", "src/client/PlayerCS.hx"}, new int[]{1981972957}, new double[]{((double) (202) )}));
				#line 204 "d:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				global::haxe.root.ValueType t = global::haxe.root.Type.@typeof(global::haxe.lang.Runtime.getField(data, "owerID", 694510256, true));
				#line 206 "d:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				global::haxe.Log.trace.__hx_invoke2_o(default(double), global::haxe.lang.Runtime.concat("type", global::haxe.root.Std.@string(t)), default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"createRoom", "client.PlayerCS", "src/client/PlayerCS.hx"}, new int[]{1981972957}, new double[]{((double) (206) )}));
				if ( ! (global::haxe.root.Reflect.hasField(data, "gameID")) ) {
					#line 208 "d:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
					return false;
				}
				
				#line 210 "d:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				global::web.SocketAsync.sendCS(((int) (((uint) (1) )) ), ((int) (1) ), -1, global::org.msgpack.MsgPack.encode(data), null);
				#line 212 "d:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				return true;
			}
			#line default
		}
		
		
		public virtual void destryRoom() {
		}
		
		
		public virtual void getRoomInfo() {
		}
		
		
		public virtual void joinRoom() {
		}
		
		
		public virtual void changeStatus() {
			unchecked {
				#line 226 "d:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				global::haxe.Log.trace.__hx_invoke2_o(default(double), "\u4ec0\u4e48\u90fd\u4e0d\u505a\u4e0d\u8981\u8c03\u7528\u3002", default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"changeStatus", "client.PlayerCS", "src/client/PlayerCS.hx"}, new int[]{1981972957}, new double[]{((double) (226) )}));
			}
			#line default
		}
		
		
		public virtual void gameAddBetCS(uint times) {
			unchecked {
				#line 231 "d:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				object tb = null;
				#line 231 "d:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				{
					#line 231 "d:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
					object __temp_odecl1 = global::haxe.lang.Runtime.getField(this.data, "id", 23515, true);
					#line 231 "d:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
					tb = new global::haxe.lang.DynamicObject(new int[]{1213433212}, new object[]{__temp_odecl1}, new int[]{888664408}, new double[]{((double) (times) )});
				}
				
				#line 233 "d:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				global::web.SocketAsync.sendCS(((int) (((uint) (1) )) ), ((int) (4) ), ((int) (global::haxe.lang.Runtime.toInt(global::haxe.lang.Runtime.getField(this.data, "id", 23515, true))) ), global::org.msgpack.MsgPack.encode(tb), null);
			}
			#line default
		}
		
		
		public virtual void tryToBeBanker() {
			unchecked {
				#line 238 "d:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				object tb = null;
				#line 238 "d:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				{
					#line 238 "d:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
					object __temp_odecl1 = global::haxe.lang.Runtime.getField(this.data, "id", 23515, true);
					#line 238 "d:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
					tb = new global::haxe.lang.DynamicObject(new int[]{23515}, new object[]{__temp_odecl1}, new int[]{}, new double[]{});
				}
				
				#line 239 "d:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				global::web.SocketAsync.sendCS(((int) (((uint) (1) )) ), ((int) (5) ), ((int) (global::haxe.lang.Runtime.toInt(global::haxe.lang.Runtime.getField(this.data, "id", 23515, true))) ), global::org.msgpack.MsgPack.encode(tb), null);
			}
			#line default
		}
		
		
		public virtual void leaveRoom(uint roomID) {
			unchecked {
				#line 244 "d:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				object tb = new global::haxe.lang.DynamicObject(new int[]{23515}, new object[]{((object) (roomID) )}, new int[]{}, new double[]{});
				global::web.SocketAsync.sendCS(((int) (((uint) (1) )) ), ((int) (20) ), ((int) (global::haxe.lang.Runtime.toInt(global::haxe.lang.Runtime.getField(this.data, "id", 23515, true))) ), global::org.msgpack.MsgPack.encode(tb), null);
			}
			#line default
		}
		
		
		public virtual void installData(object data) {
			#line 249 "d:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
			this.data = data;
		}
		#line default
		
		public virtual void installDataCS(string data) {
			unchecked {
				#line 255 "d:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				this.data = ((object) (new global::haxe.format.JsonParser(((string) (data) )).doParse()) );
				#line 257 "d:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				global::haxe.Log.trace.__hx_invoke2_o(default(double), global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("<color=#9400D3> install tinycs id=", global::haxe.root.Std.@string(global::haxe.lang.Runtime.getField(this.data, "id", 23515, true))), "</color>"), default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"installDataCS", "client.PlayerCS", "src/client/PlayerCS.hx"}, new int[]{1981972957}, new double[]{((double) (257) )}));
			}
			#line default
		}
		
		
		public virtual void toChat() {
			unchecked {
				#line 263 "d:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				global::haxe.Log.trace.__hx_invoke2_o(default(double), "\u4ec0\u4e48\u90fd\u4e0d\u505a\u4e0d\u8981\u8c03\u7528\u3002", default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"toChat", "client.PlayerCS", "src/client/PlayerCS.hx"}, new int[]{1981972957}, new double[]{((double) (263) )}));
			}
			#line default
		}
		
		
		public virtual void createClub() {
			unchecked {
				#line 269 "d:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				global::haxe.Log.trace.__hx_invoke2_o(default(double), "\u4ec0\u4e48\u90fd\u4e0d\u505a\u4e0d\u8981\u8c03\u7528\u3002", default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"createClub", "client.PlayerCS", "src/client/PlayerCS.hx"}, new int[]{1981972957}, new double[]{((double) (269) )}));
			}
			#line default
		}
		
		
		public virtual void applyClub() {
			unchecked {
				#line 274 "d:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				global::haxe.Log.trace.__hx_invoke2_o(default(double), "\u4ec0\u4e48\u90fd\u4e0d\u505a\u4e0d\u8981\u8c03\u7528\u3002", default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"applyClub", "client.PlayerCS", "src/client/PlayerCS.hx"}, new int[]{1981972957}, new double[]{((double) (274) )}));
			}
			#line default
		}
		
		
		public virtual void agreeJoinClub() {
			unchecked {
				#line 279 "d:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				global::haxe.Log.trace.__hx_invoke2_o(default(double), "\u4ec0\u4e48\u90fd\u4e0d\u505a\u4e0d\u8981\u8c03\u7528\u3002", default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"agreeJoinClub", "client.PlayerCS", "src/client/PlayerCS.hx"}, new int[]{1981972957}, new double[]{((double) (279) )}));
			}
			#line default
		}
		
		
		public virtual void leaveClub() {
			unchecked {
				#line 284 "d:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				global::haxe.Log.trace.__hx_invoke2_o(default(double), "\u4ec0\u4e48\u90fd\u4e0d\u505a\u4e0d\u8981\u8c03\u7528\u3002", default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"leaveClub", "client.PlayerCS", "src/client/PlayerCS.hx"}, new int[]{1981972957}, new double[]{((double) (284) )}));
			}
			#line default
		}
		
		
		public virtual void refuseJoinClub() {
			unchecked {
				#line 288 "d:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				global::haxe.Log.trace.__hx_invoke2_o(default(double), "\u4ec0\u4e48\u90fd\u4e0d\u505a\u4e0d\u8981\u8c03\u7528\u3002", default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"refuseJoinClub", "client.PlayerCS", "src/client/PlayerCS.hx"}, new int[]{1981972957}, new double[]{((double) (288) )}));
			}
			#line default
		}
		
		
		public virtual void searchPlayerScore() {
			unchecked {
				#line 294 "d:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				global::haxe.Log.trace.__hx_invoke2_o(default(double), "\u4ec0\u4e48\u90fd\u4e0d\u505a\u4e0d\u8981\u8c03\u7528\u3002", default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"searchPlayerScore", "client.PlayerCS", "src/client/PlayerCS.hx"}, new int[]{1981972957}, new double[]{((double) (294) )}));
			}
			#line default
		}
		
		
		public virtual void getUserInfo() {
			unchecked {
				#line 302 "d:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				global::web.SocketAsync.sendCS(((int) (((uint) (1) )) ), ((int) (18) ), ((int) (global::haxe.lang.Runtime.toInt(global::haxe.lang.Runtime.getField(this.data, "id", 23515, true))) ), global::org.msgpack.MsgPack.encode(this.data), null);
			}
			#line default
		}
		
		
		public virtual void excuteCMD(int e) {
		}
		
		
		public virtual void dispose() {
			#line 311 "d:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
			this.off();
		}
		#line default
		
	}
}


