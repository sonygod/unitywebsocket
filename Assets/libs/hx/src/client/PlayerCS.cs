// Generated by Haxe 4.1.0-rc.1+0d88c583b
using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace client {
	public class PlayerCS : global::CEventDispatcher {
		
		public PlayerCS(object data) : base() {
			unchecked {
				#line 27 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				this.wasAdd = false;
				#line 29 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				{
					#line 31 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
					this.data = data;
					#line 33 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
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
				#line 40 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				( this as global::CEventDispatcher ).dispatchEvent(((global::CEvent) (new global::CEvent("1", 1)) ), ((object) (1) ));
			}
			#line default
		}
		
		
		public virtual void transEvent(object e) {
			#line 45 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
			( this as global::CEventDispatcher ).dispatchEvent(((global::CEvent) (new global::CEvent(global::haxe.lang.Runtime.toString(global::haxe.lang.Runtime.getField(e, "type", 1292432058, false)), e)) ), ((object) (this) ));
		}
		#line default
		
		public virtual void addEvent() {
			unchecked {
				#line 52 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				if (this.wasAdd) {
					#line 53 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
					global::haxe.Log.trace.__hx_invoke2_o(default(double), "<color=#FFFF00>\u4e0d\u80fd\u91cd\u590d\u6dfb\u52a0\u7a83\u542c\u5668\u3002</color", default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"addEvent", "client.PlayerCS", "src/client/PlayerCS.hx"}, new int[]{1981972957}, new double[]{((double) (53) )}));
					return;
				}
				
				#line 56 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				global::web.proto.WebEventDispatch wd = global::web.proto.WebEventDispatch.getInstance();
				#line 65 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				wd.addEventListener(((string) ("getuserInfo") ), ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "onGetInfo", 1877516485)) ), default(object), default(object), default(object));
				wd.addEventListener(((string) ("add_bet") ), ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "onAddBet", 2124987439)) ), default(object), default(object), default(object));
				#line 67 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				wd.addEventListener(((string) ("login") ), ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "onLogin", 254900170)) ), default(object), default(object), default(object));
				wd.addEventListener(((string) ("hall_Reg") ), ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "onReg", 846097781)) ), default(object), default(object), default(object));
				#line 69 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				wd.addEventListener(((string) ("player_GET_TEARM_AND_INCOME") ), ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "onGetIncome", 837474176)) ), default(object), default(object), default(object));
				this.wasAdd = true;
			}
			#line default
		}
		
		
		public virtual void onGetIncome(global::web.proto.PlayerEvent e) {
			unchecked {
				#line 74 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				if (( this.data != null )) {
					#line 75 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
					global::haxe.Log.trace.__hx_invoke2_o(default(double), "\u83b7\u53d6\u6536\u76ca", default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"onGetIncome", "client.PlayerCS", "src/client/PlayerCS.hx"}, new int[]{1981972957}, new double[]{((double) (75) )}));
					if (((bool) (global::haxe.lang.Runtime.eq(global::haxe.lang.Runtime.getField(this.data, "id", 23515, true), global::haxe.lang.Runtime.getField(e.player, "id", 23515, true))) )) {
						#line 78 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
						global::haxe.Log.trace.__hx_invoke2_o(default(double), "\u8f6c\u53d1", default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"onGetIncome", "client.PlayerCS", "src/client/PlayerCS.hx"}, new int[]{1981972957}, new double[]{((double) (78) )}));
						this.transEvent(e);
					}
					else {
						#line 81 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
						global::haxe.Log.trace.__hx_invoke2_o(default(double), "\u6ca1\u6709id?", default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"onGetIncome", "client.PlayerCS", "src/client/PlayerCS.hx"}, new int[]{1981972957}, new double[]{((double) (81) )}));
					}
					
				}
				
			}
			#line default
		}
		
		
		public virtual void onGetInfo(global::web.proto.PlayerEvent e) {
			#line 88 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
			if (( this.data != null )) {
				#line 89 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				if (((bool) (global::haxe.lang.Runtime.eq(global::haxe.lang.Runtime.getField(this.data, "id", 23515, true), global::haxe.lang.Runtime.getField(e.player, "id", 23515, true))) )) {
					#line 90 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
					this.transEvent(e);
				}
				
			}
			
		}
		#line default
		
		public virtual void onAddBet(global::web.proto.PlayerEvent e) {
			#line 96 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
			if (( this.data != null )) {
				#line 97 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				if (((bool) (global::haxe.lang.Runtime.eq(global::haxe.lang.Runtime.getField(this.data, "id", 23515, true), ((uint) (global::haxe.lang.Runtime.getField_f(e.bling, "playerID", 1213433212, true)) ))) )) {
					#line 98 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
					this.transEvent(e);
				}
				
			}
			
		}
		#line default
		
		public virtual void onLogin(global::web.proto.HallEvent e) {
			#line 104 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
			if (( this.data == null )) {
				#line 105 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				this.transEvent(e);
			}
			
		}
		#line default
		
		public virtual void onReg(global::web.proto.HallEvent e) {
			#line 109 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
			if (( this.data == null )) {
				#line 110 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				this.transEvent(e);
			}
			
		}
		#line default
		
		public virtual void off() {
			#line 117 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
			global::web.proto.WebEventDispatch wd = global::web.proto.WebEventDispatch.getInstance();
			global::haxe.root.Array events = new global::haxe.root.Array(new object[]{((string) ("getuserInfo") ), ((string) ("login") ), ((string) ("hall_Reg") ), ((string) ("add_bet") )});
			#line 120 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
			{
				#line 120 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				int _g = 0;
				#line 120 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				while (( _g < events.length )) {
					#line 120 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
					string e = global::haxe.lang.Runtime.toString(events.__get(_g));
					#line 120 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
					 ++ _g;
					wd.removeEventListener(((string) (e) ), ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "transEvent", 529665746)) ), default(object));
				}
				
			}
			
			#line 123 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
			this.wasAdd = false;
		}
		#line default
		
		public virtual void LoginWithOpenID(string openid) {
			unchecked {
				#line 127 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				object tp = new global::haxe.lang.DynamicObject(new int[]{23515, 563366437}, new object[]{((object) (-1) ), openid}, new int[]{}, new double[]{});
				global::web.SocketAsync.sendCS(((int) (((uint) (1) )) ), ((int) (8) ), -1, global::org.msgpack.MsgPack.encode(tp), null);
			}
			#line default
		}
		
		
		public virtual void Login(string mobile, string password) {
			unchecked {
				#line 137 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				object tp = null;
				#line 137 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				{
					#line 137 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
					string __temp_odecl1 = global::haxe.crypto.Md5.encode(password);
					#line 137 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
					tp = new global::haxe.lang.DynamicObject(new int[]{1064807522, 1221600027}, new object[]{mobile, __temp_odecl1}, new int[]{}, new double[]{});
				}
				
				#line 138 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				global::web.SocketAsync.sendCS(((int) (((uint) (1) )) ), ((int) (8) ), -1, global::org.msgpack.MsgPack.encode(tp), null);
			}
			#line default
		}
		
		
		public virtual bool forgotpassWord(string mobile, string password, string verificationCode) {
			unchecked {
				#line 149 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				if (( verificationCode != this.code )) {
					#line 150 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
					global::haxe.Log.trace.__hx_invoke2_o(default(double), "\u8bf7\u586b\u9a8c\u8bc1\u7801!", default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"forgotpassWord", "client.PlayerCS", "src/client/PlayerCS.hx"}, new int[]{1981972957}, new double[]{((double) (150) )}));
					return false;
				}
				
				#line 154 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				if (global::utils.SQLRex.checkSQL(password)) {
					#line 155 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
					return false;
				}
				
				#line 158 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				object tp = null;
				#line 158 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				{
					#line 158 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
					string __temp_odecl1 = global::haxe.crypto.Md5.encode(password);
					#line 158 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
					tp = new global::haxe.lang.DynamicObject(new int[]{1064807522, 1221600027}, new object[]{mobile, __temp_odecl1}, new int[]{}, new double[]{});
				}
				
				#line 160 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				global::web.SocketAsync.sendCS(((int) (((uint) (1) )) ), ((int) (30) ), -1, global::org.msgpack.MsgPack.encode(tp), null);
				#line 162 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				return true;
			}
			#line default
		}
		
		
		public virtual bool regist(string mobile, string ps) {
			#line 172 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
			return this.regist(mobile, ps, 0);
		}
		#line default
		
		public virtual bool regist(string mobile, string ps, object refID) {
			unchecked {
				#line 172 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				int refID1 = ( (( refID == default(object) )) ? (0) : (((int) (global::haxe.lang.Runtime.toInt(refID)) )) );
				global::haxe.root.EReg r = new global::haxe.root.EReg("1\\d{10}", "");
				#line 175 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				bool b = r.match(mobile);
				if (( ( ( ( ( ps == null ) || ( mobile == null ) ) || ( mobile.Length != 11 ) ) || ( ps.Length < 6 ) ) ||  ! (b)  )) {
					#line 177 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
					global::haxe.Log.trace.__hx_invoke2_o(default(double), "\u6ce8\u518c\u8d26\u53f7\u6216\u8005\u5bc6\u7801\u4e0d\u7b26\u5408\u6761\u4ef6", default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"regist", "client.PlayerCS", "src/client/PlayerCS.hx"}, new int[]{1981972957}, new double[]{((double) (177) )}));
					return false;
				}
				
				#line 181 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				string password = global::haxe.crypto.Md5.encode(ps);
				object tp = new global::haxe.lang.DynamicObject(new int[]{1064807522, 1221600027, 1542393958}, new object[]{mobile, password, ((object) (refID1) )}, new int[]{}, new double[]{});
				#line 184 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				global::web.SocketAsync.sendCS(((int) (((uint) (1) )) ), ((int) (9) ), -1, global::org.msgpack.MsgPack.encode(tp), null);
				#line 186 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				return true;
			}
			#line default
		}
		
		
		public virtual bool changeUserInfo(string avatar) {
			unchecked {
				#line 194 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				if (global::utils.SQLRex.checkSQL(avatar)) {
					#line 195 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
					global::haxe.Log.trace.__hx_invoke2_o(default(double), "\u4e0d\u5408\u6cd5", default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"changeUserInfo", "client.PlayerCS", "src/client/PlayerCS.hx"}, new int[]{1981972957}, new double[]{((double) (195) )}));
					return false;
				}
				
				#line 198 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				if (( this.data == null )) {
					#line 199 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
					global::haxe.Log.trace.__hx_invoke2_o(default(double), "\u767b\u9646\u540e\u8bf7\u8d4b\u503c\u7ed9data", default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"changeUserInfo", "client.PlayerCS", "src/client/PlayerCS.hx"}, new int[]{1981972957}, new double[]{((double) (199) )}));
					return false;
				}
				
				#line 203 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				object tp = null;
				#line 203 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				{
					#line 203 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
					object __temp_odecl1 = global::haxe.lang.Runtime.getField(this.data, "id", 23515, true);
					#line 203 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
					tp = new global::haxe.lang.DynamicObject(new int[]{23515, 2052882457}, new object[]{__temp_odecl1, avatar}, new int[]{}, new double[]{});
				}
				
				#line 205 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				global::haxe.lang.Function replacer = null;
				#line 205 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				string space = null;
				#line 205 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				global::haxe.Log.trace.__hx_invoke2_o(default(double), global::haxe.lang.Runtime.concat("\u4f20\u8f93", global::haxe.format.JsonPrinter.print(((object) (tp) ), replacer, space)), default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"changeUserInfo", "client.PlayerCS", "src/client/PlayerCS.hx"}, new int[]{1981972957}, new double[]{((double) (205) )}));
				#line 207 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				global::web.SocketAsync.sendCS(((int) (((uint) (1) )) ), ((int) (31) ), -1, global::org.msgpack.MsgPack.encode(tp), null);
				#line 209 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				return true;
			}
			#line default
		}
		
		
		public virtual bool createRoom(object data) {
			unchecked {
				#line 215 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				global::haxe.lang.Function replacer = null;
				#line 215 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				string space = null;
				#line 215 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				global::haxe.Log.trace.__hx_invoke2_o(default(double), global::haxe.lang.Runtime.concat("\u521b\u5efa\u623f\u95f4", global::haxe.format.JsonPrinter.print(((object) (data) ), replacer, space)), default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"createRoom", "client.PlayerCS", "src/client/PlayerCS.hx"}, new int[]{1981972957}, new double[]{((double) (215) )}));
				#line 217 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				global::haxe.Log.trace.__hx_invoke2_o(default(double), global::haxe.lang.Runtime.concat("ownerid=", global::haxe.root.Std.@string(global::haxe.lang.Runtime.getField(data, "owerID", 694510256, true))), default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"createRoom", "client.PlayerCS", "src/client/PlayerCS.hx"}, new int[]{1981972957}, new double[]{((double) (217) )}));
				#line 219 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				global::haxe.root.ValueType t = global::haxe.root.Type.@typeof(global::haxe.lang.Runtime.getField(data, "owerID", 694510256, true));
				#line 221 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				global::haxe.Log.trace.__hx_invoke2_o(default(double), global::haxe.lang.Runtime.concat("type", global::haxe.root.Std.@string(t)), default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"createRoom", "client.PlayerCS", "src/client/PlayerCS.hx"}, new int[]{1981972957}, new double[]{((double) (221) )}));
				if ( ! (global::haxe.root.Reflect.hasField(data, "gameID")) ) {
					#line 223 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
					return false;
				}
				
				#line 225 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				global::web.SocketAsync.sendCS(((int) (((uint) (1) )) ), ((int) (1) ), -1, global::org.msgpack.MsgPack.encode(data), null);
				#line 227 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
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
				#line 241 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				global::haxe.Log.trace.__hx_invoke2_o(default(double), "\u4ec0\u4e48\u90fd\u4e0d\u505a\u4e0d\u8981\u8c03\u7528\u3002", default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"changeStatus", "client.PlayerCS", "src/client/PlayerCS.hx"}, new int[]{1981972957}, new double[]{((double) (241) )}));
			}
			#line default
		}
		
		
		public virtual void gameAddBetCS(uint times) {
			unchecked {
				#line 246 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				object tb = null;
				#line 246 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				{
					#line 246 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
					object __temp_odecl1 = global::haxe.lang.Runtime.getField(this.data, "id", 23515, true);
					#line 246 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
					tb = new global::haxe.lang.DynamicObject(new int[]{1213433212}, new object[]{__temp_odecl1}, new int[]{888664408}, new double[]{((double) (times) )});
				}
				
				#line 248 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				global::web.SocketAsync.sendCS(((int) (((uint) (1) )) ), ((int) (4) ), ((int) (global::haxe.lang.Runtime.toInt(global::haxe.lang.Runtime.getField(this.data, "id", 23515, true))) ), global::org.msgpack.MsgPack.encode(tb), null);
			}
			#line default
		}
		
		
		public virtual void tryToBeBanker() {
			unchecked {
				#line 253 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				object tb = null;
				#line 253 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				{
					#line 253 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
					object __temp_odecl1 = global::haxe.lang.Runtime.getField(this.data, "id", 23515, true);
					#line 253 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
					tb = new global::haxe.lang.DynamicObject(new int[]{23515}, new object[]{__temp_odecl1}, new int[]{}, new double[]{});
				}
				
				#line 254 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				global::web.SocketAsync.sendCS(((int) (((uint) (1) )) ), ((int) (5) ), ((int) (global::haxe.lang.Runtime.toInt(global::haxe.lang.Runtime.getField(this.data, "id", 23515, true))) ), global::org.msgpack.MsgPack.encode(tb), null);
			}
			#line default
		}
		
		
		public virtual void leaveRoom(uint roomID) {
			unchecked {
				#line 259 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				object tb = new global::haxe.lang.DynamicObject(new int[]{23515}, new object[]{((object) (roomID) )}, new int[]{}, new double[]{});
				global::web.SocketAsync.sendCS(((int) (((uint) (1) )) ), ((int) (20) ), ((int) (global::haxe.lang.Runtime.toInt(global::haxe.lang.Runtime.getField(this.data, "id", 23515, true))) ), global::org.msgpack.MsgPack.encode(tb), null);
			}
			#line default
		}
		
		
		public virtual void installData(object data) {
			#line 264 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
			this.data = data;
		}
		#line default
		
		public virtual void installDataCS(string data) {
			unchecked {
				#line 270 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				this.data = ((object) (new global::haxe.format.JsonParser(((string) (data) )).doParse()) );
				#line 272 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				global::haxe.Log.trace.__hx_invoke2_o(default(double), global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("<color=#9400D3> install tinycs id=", global::haxe.root.Std.@string(global::haxe.lang.Runtime.getField(this.data, "id", 23515, true))), "</color>"), default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"installDataCS", "client.PlayerCS", "src/client/PlayerCS.hx"}, new int[]{1981972957}, new double[]{((double) (272) )}));
			}
			#line default
		}
		
		
		public virtual void toChat() {
			unchecked {
				#line 278 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				global::haxe.Log.trace.__hx_invoke2_o(default(double), "\u4ec0\u4e48\u90fd\u4e0d\u505a\u4e0d\u8981\u8c03\u7528\u3002", default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"toChat", "client.PlayerCS", "src/client/PlayerCS.hx"}, new int[]{1981972957}, new double[]{((double) (278) )}));
			}
			#line default
		}
		
		
		public virtual void createClub() {
			unchecked {
				#line 284 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				global::haxe.Log.trace.__hx_invoke2_o(default(double), "\u4ec0\u4e48\u90fd\u4e0d\u505a\u4e0d\u8981\u8c03\u7528\u3002", default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"createClub", "client.PlayerCS", "src/client/PlayerCS.hx"}, new int[]{1981972957}, new double[]{((double) (284) )}));
			}
			#line default
		}
		
		
		public virtual void applyClub() {
			unchecked {
				#line 289 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				global::haxe.Log.trace.__hx_invoke2_o(default(double), "\u4ec0\u4e48\u90fd\u4e0d\u505a\u4e0d\u8981\u8c03\u7528\u3002", default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"applyClub", "client.PlayerCS", "src/client/PlayerCS.hx"}, new int[]{1981972957}, new double[]{((double) (289) )}));
			}
			#line default
		}
		
		
		public virtual void agreeJoinClub() {
			unchecked {
				#line 294 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				global::haxe.Log.trace.__hx_invoke2_o(default(double), "\u4ec0\u4e48\u90fd\u4e0d\u505a\u4e0d\u8981\u8c03\u7528\u3002", default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"agreeJoinClub", "client.PlayerCS", "src/client/PlayerCS.hx"}, new int[]{1981972957}, new double[]{((double) (294) )}));
			}
			#line default
		}
		
		
		public virtual void leaveClub() {
			unchecked {
				#line 299 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				global::haxe.Log.trace.__hx_invoke2_o(default(double), "\u4ec0\u4e48\u90fd\u4e0d\u505a\u4e0d\u8981\u8c03\u7528\u3002", default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"leaveClub", "client.PlayerCS", "src/client/PlayerCS.hx"}, new int[]{1981972957}, new double[]{((double) (299) )}));
			}
			#line default
		}
		
		
		public virtual void refuseJoinClub() {
			unchecked {
				#line 303 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				global::haxe.Log.trace.__hx_invoke2_o(default(double), "\u4ec0\u4e48\u90fd\u4e0d\u505a\u4e0d\u8981\u8c03\u7528\u3002", default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"refuseJoinClub", "client.PlayerCS", "src/client/PlayerCS.hx"}, new int[]{1981972957}, new double[]{((double) (303) )}));
			}
			#line default
		}
		
		
		public virtual void searchPlayerScore() {
			unchecked {
				#line 309 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				global::haxe.Log.trace.__hx_invoke2_o(default(double), "\u4ec0\u4e48\u90fd\u4e0d\u505a\u4e0d\u8981\u8c03\u7528\u3002", default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"searchPlayerScore", "client.PlayerCS", "src/client/PlayerCS.hx"}, new int[]{1981972957}, new double[]{((double) (309) )}));
			}
			#line default
		}
		
		
		public virtual void getUserInfo() {
			unchecked {
				#line 317 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				global::web.SocketAsync.sendCS(((int) (((uint) (1) )) ), ((int) (18) ), ((int) (global::haxe.lang.Runtime.toInt(global::haxe.lang.Runtime.getField(this.data, "id", 23515, true))) ), global::org.msgpack.MsgPack.encode(this.data), null);
			}
			#line default
		}
		
		
		public virtual void getUserIncomeAndSize() {
			unchecked {
				#line 324 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				int __temp_stmt2 = ((int) (((uint) (1) )) );
				#line 324 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				int __temp_stmt3 = ((int) (1004) );
				#line 324 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				int __temp_stmt4 = ((int) (global::haxe.lang.Runtime.toInt(global::haxe.lang.Runtime.getField(this.data, "id", 23515, true))) );
				#line 324 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				object __temp_stmt5 = null;
				#line 324 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				{
					#line 324 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
					object __temp_odecl1 = global::haxe.lang.Runtime.getField(this.data, "id", 23515, true);
					#line 324 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
					__temp_stmt5 = new global::haxe.lang.DynamicObject(new int[]{23515}, new object[]{__temp_odecl1}, new int[]{}, new double[]{});
				}
				
				#line 324 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
				global::web.SocketAsync.sendCS(__temp_stmt2, __temp_stmt3, __temp_stmt4, global::org.msgpack.MsgPack.encode(__temp_stmt5), null);
			}
			#line default
		}
		
		
		public virtual void excuteCMD(int e) {
		}
		
		
		public virtual void dispose() {
			#line 332 "D:\\project\\sangong\\sangong\\src\\client\\PlayerCS.hx"
			this.off();
		}
		#line default
		
	}
}


