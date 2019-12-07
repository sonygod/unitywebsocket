// Generated by Haxe 4.1.0-rc.1+0d88c583b
using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace gameRoom {
	public class Hall : global::haxe.lang.HxObject {
		
		public Hall(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public Hall() {
			#line 66 "d:\\project\\sangong\\sangong\\src\\gameRoom\\Hall.hx"
			global::gameRoom.Hall.__hx_ctor_gameRoom_Hall(this);
		}
		#line default
		
		protected static void __hx_ctor_gameRoom_Hall(global::gameRoom.Hall __hx_this) {
			unchecked {
				#line 59 "d:\\project\\sangong\\sangong\\src\\gameRoom\\Hall.hx"
				__hx_this.gamesDLL = new global::haxe.root.Array(new object[]{});
				#line 57 "d:\\project\\sangong\\sangong\\src\\gameRoom\\Hall.hx"
				__hx_this.handerAndPlayer = new global::haxe.ds.IntMap();
				#line 55 "d:\\project\\sangong\\sangong\\src\\gameRoom\\Hall.hx"
				__hx_this.roomMap = new global::haxe.ds.IntMap();
				#line 53 "d:\\project\\sangong\\sangong\\src\\gameRoom\\Hall.hx"
				__hx_this.roomID = ((uint) (1000) );
				#line 66 "d:\\project\\sangong\\sangong\\src\\gameRoom\\Hall.hx"
				{
					#line 67 "d:\\project\\sangong\\sangong\\src\\gameRoom\\Hall.hx"
					__hx_this.webD = global::web.proto.WebEventDispatch.getInstance();
					__hx_this.handerAndPlayer = new global::haxe.ds.IntMap();
				}
				
			}
			#line default
		}
		
		
		public global::web.proto.WebEventDispatch webD;
		
		public uint roomID;
		
		public global::haxe.ds.IntMap roomMap;
		
		public global::haxe.ds.IntMap handerAndPlayer;
		
		public global::haxe.root.Array gamesDLL;
		
		public string sPath;
		
		public global::haxe.Timer heardTimder;
		
		public global::haxe.io.Bytes oneByte;
		
		public virtual void addEventListner() {
		}
		
		
		public virtual void onCreateRoomC(global::web.proto.RoomEvent e) {
			unchecked {
				#line 86 "d:\\project\\sangong\\sangong\\src\\Comments.hx"
				//  客户端收到创建房间成功，暂时没有时间限制释放？是否要时间释放？请解析这个data.json                                     ;
				#line 1112 "d:\\project\\sangong\\sangong\\src\\gameRoom\\Hall.hx"
				object data = e.room;
				#line 1114 "d:\\project\\sangong\\sangong\\src\\gameRoom\\Hall.hx"
				global::haxe.lang.Function replacer = null;
				#line 1114 "d:\\project\\sangong\\sangong\\src\\gameRoom\\Hall.hx"
				string space = null;
				#line 1114 "d:\\project\\sangong\\sangong\\src\\gameRoom\\Hall.hx"
				string data1 = global::haxe.format.JsonPrinter.print(((object) (data) ), replacer, space);
				#line 1116 "d:\\project\\sangong\\sangong\\src\\gameRoom\\Hall.hx"
				global::haxe.Log.trace.__hx_invoke2_o(default(double), global::haxe.lang.Runtime.concat("onCreateRoomC", data1), default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"onCreateRoomC", "gameRoom.Hall", "src/gameRoom/Hall.hx"}, new int[]{1981972957}, new double[]{((double) (1116) )}));
			}
			#line default
		}
		
		
		public virtual void onCreateClubC(global::web.proto.ClubEvent e) {
			#line 86 "d:\\project\\sangong\\sangong\\src\\Comments.hx"
			//  客户端收到创建俱乐部成功，请解析这个data.json                                                       ;
		}
		#line default
		
		public virtual void onLoginC(global::web.proto.HallEvent e) {
			unchecked {
				#line 86 "d:\\project\\sangong\\sangong\\src\\Comments.hx"
				//  用户登录成功，如果检测到player.roomid有值，跳对应的游戏房间。                                             ;
				#line 1125 "d:\\project\\sangong\\sangong\\src\\gameRoom\\Hall.hx"
				object player = e.player;
				global::haxe.Log.trace.__hx_invoke2_o(default(double), "\u767b\u9646\u6210\u529f", default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"onLoginC", "gameRoom.Hall", "src/gameRoom/Hall.hx"}, new int[]{1981972957}, new double[]{((double) (1126) )}));
				#line 1127 "d:\\project\\sangong\\sangong\\src\\gameRoom\\Hall.hx"
				global::haxe.lang.Function replacer = null;
				#line 1127 "d:\\project\\sangong\\sangong\\src\\gameRoom\\Hall.hx"
				string space = null;
				#line 1127 "d:\\project\\sangong\\sangong\\src\\gameRoom\\Hall.hx"
				global::haxe.Log.trace.__hx_invoke2_o(default(double), global::haxe.format.JsonPrinter.print(((object) (player) ), replacer, space), default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"onLoginC", "gameRoom.Hall", "src/gameRoom/Hall.hx"}, new int[]{1981972957}, new double[]{((double) (1127) )}));
				#line 1129 "d:\\project\\sangong\\sangong\\src\\gameRoom\\Hall.hx"
				object tiny_pay = ((object) (2) );
				#line 1129 "d:\\project\\sangong\\sangong\\src\\gameRoom\\Hall.hx"
				object tiny_owerID = global::haxe.lang.Runtime.getField(player, "id", 23515, true);
				#line 1129 "d:\\project\\sangong\\sangong\\src\\gameRoom\\Hall.hx"
				object tiny_playType = ((object) (0) );
				#line 1129 "d:\\project\\sangong\\sangong\\src\\gameRoom\\Hall.hx"
				object tiny_gameID = ((object) (1001) );
			}
			#line default
		}
		
		
		public virtual void createRoom(int userid, object data) {
			unchecked {
				#line 86 "d:\\project\\sangong\\sangong\\src\\Comments.hx"
				//  用户创建游戏房间 data 类型是 TinyData, 具体查看 TinyRoom.hx                                      ;
				#line 1145 "d:\\project\\sangong\\sangong\\src\\gameRoom\\Hall.hx"
				object tr = data;
				#line 1147 "d:\\project\\sangong\\sangong\\src\\gameRoom\\Hall.hx"
				global::web.SocketAsync.sendCS(((int) (((uint) (1) )) ), ((int) (1) ), userid, global::org.msgpack.MsgPack.encode(tr), null);
			}
			#line default
		}
		
		
		public virtual void onCMDResultC(global::web.proto.CMDEvent e) {
			unchecked {
				#line 86 "d:\\project\\sangong\\sangong\\src\\Comments.hx"
				//  调用系统命令回调                                                                          ;
				#line 1153 "d:\\project\\sangong\\sangong\\src\\gameRoom\\Hall.hx"
				object cmd = e.cmd;
				#line 1155 "d:\\project\\sangong\\sangong\\src\\gameRoom\\Hall.hx"
				switch (((int) (global::haxe.lang.Runtime.toInt((global::haxe.lang.Runtime.getField(cmd, "id", 23515, true)))) )) {
					case 4000:
					{
						#line 1160 "d:\\project\\sangong\\sangong\\src\\gameRoom\\Hall.hx"
						global::haxe.Log.trace.__hx_invoke2_o(default(double), "update fk bool", default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"onCMDResultC", "gameRoom.Hall", "src/gameRoom/Hall.hx"}, new int[]{1981972957}, new double[]{((double) (1160) )}));
						#line 1160 "d:\\project\\sangong\\sangong\\src\\gameRoom\\Hall.hx"
						break;
					}
					
					
					case 4001:
					{
						#line 1163 "d:\\project\\sangong\\sangong\\src\\gameRoom\\Hall.hx"
						global::haxe.Log.trace.__hx_invoke2_o(default(double), "update gm bool", default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"onCMDResultC", "gameRoom.Hall", "src/gameRoom/Hall.hx"}, new int[]{1981972957}, new double[]{((double) (1163) )}));
						#line 1163 "d:\\project\\sangong\\sangong\\src\\gameRoom\\Hall.hx"
						break;
					}
					
					
					case 4002:
					{
						#line 1157 "d:\\project\\sangong\\sangong\\src\\gameRoom\\Hall.hx"
						global::haxe.Log.trace.__hx_invoke2_o(default(double), "getuserinfo", default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"onCMDResultC", "gameRoom.Hall", "src/gameRoom/Hall.hx"}, new int[]{1981972957}, new double[]{((double) (1157) )}));
						#line 1157 "d:\\project\\sangong\\sangong\\src\\gameRoom\\Hall.hx"
						break;
					}
					
					
					case 4003:
					{
						#line 1166 "d:\\project\\sangong\\sangong\\src\\gameRoom\\Hall.hx"
						global::haxe.Log.trace.__hx_invoke2_o(default(double), "update gailv bool", default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"onCMDResultC", "gameRoom.Hall", "src/gameRoom/Hall.hx"}, new int[]{1981972957}, new double[]{((double) (1166) )}));
						#line 1166 "d:\\project\\sangong\\sangong\\src\\gameRoom\\Hall.hx"
						break;
					}
					
					
				}
				
			}
			#line default
		}
		
		
		public virtual void onGET_ROOM_INFOC(global::web.proto.RoomEvent e) {
			unchecked {
				#line 1171 "d:\\project\\sangong\\sangong\\src\\gameRoom\\Hall.hx"
				global::haxe.Log.trace.__hx_invoke2_o(default(double), "\u83b7\u53d6\u623f\u95f4\u4fe1\u606f", default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"onGET_ROOM_INFOC", "gameRoom.Hall", "src/gameRoom/Hall.hx"}, new int[]{1981972957}, new double[]{((double) (1171) )}));
				#line 1173 "d:\\project\\sangong\\sangong\\src\\gameRoom\\Hall.hx"
				object info = e.room;
			}
			#line default
		}
		
		
		public override double __hx_setField_f(string field, int hash, double @value, bool handleProperties) {
			unchecked {
				#line 50 "d:\\project\\sangong\\sangong\\src\\gameRoom\\Hall.hx"
				switch (hash) {
					case 1205545654:
					{
						#line 50 "d:\\project\\sangong\\sangong\\src\\gameRoom\\Hall.hx"
						this.roomID = ((uint) (@value) );
						#line 50 "d:\\project\\sangong\\sangong\\src\\gameRoom\\Hall.hx"
						return @value;
					}
					
					
					default:
					{
						#line 50 "d:\\project\\sangong\\sangong\\src\\gameRoom\\Hall.hx"
						return base.__hx_setField_f(field, hash, @value, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_setField(string field, int hash, object @value, bool handleProperties) {
			unchecked {
				#line 50 "d:\\project\\sangong\\sangong\\src\\gameRoom\\Hall.hx"
				switch (hash) {
					case 1451561102:
					{
						#line 50 "d:\\project\\sangong\\sangong\\src\\gameRoom\\Hall.hx"
						this.oneByte = ((global::haxe.io.Bytes) (@value) );
						#line 50 "d:\\project\\sangong\\sangong\\src\\gameRoom\\Hall.hx"
						return @value;
					}
					
					
					case 796168079:
					{
						#line 50 "d:\\project\\sangong\\sangong\\src\\gameRoom\\Hall.hx"
						this.heardTimder = ((global::haxe.Timer) (@value) );
						#line 50 "d:\\project\\sangong\\sangong\\src\\gameRoom\\Hall.hx"
						return @value;
					}
					
					
					case 1816119224:
					{
						#line 50 "d:\\project\\sangong\\sangong\\src\\gameRoom\\Hall.hx"
						this.sPath = global::haxe.lang.Runtime.toString(@value);
						#line 50 "d:\\project\\sangong\\sangong\\src\\gameRoom\\Hall.hx"
						return @value;
					}
					
					
					case 1300511267:
					{
						#line 50 "d:\\project\\sangong\\sangong\\src\\gameRoom\\Hall.hx"
						this.gamesDLL = ((global::haxe.root.Array) (@value) );
						#line 50 "d:\\project\\sangong\\sangong\\src\\gameRoom\\Hall.hx"
						return @value;
					}
					
					
					case 938763356:
					{
						#line 50 "d:\\project\\sangong\\sangong\\src\\gameRoom\\Hall.hx"
						this.handerAndPlayer = ((global::haxe.ds.IntMap) (@value) );
						#line 50 "d:\\project\\sangong\\sangong\\src\\gameRoom\\Hall.hx"
						return @value;
					}
					
					
					case 401430337:
					{
						#line 50 "d:\\project\\sangong\\sangong\\src\\gameRoom\\Hall.hx"
						this.roomMap = ((global::haxe.ds.IntMap) (@value) );
						#line 50 "d:\\project\\sangong\\sangong\\src\\gameRoom\\Hall.hx"
						return @value;
					}
					
					
					case 1205545654:
					{
						#line 50 "d:\\project\\sangong\\sangong\\src\\gameRoom\\Hall.hx"
						this.roomID = ((uint) (global::haxe.lang.Runtime.toInt(@value)) );
						#line 50 "d:\\project\\sangong\\sangong\\src\\gameRoom\\Hall.hx"
						return @value;
					}
					
					
					case 1324703024:
					{
						#line 50 "d:\\project\\sangong\\sangong\\src\\gameRoom\\Hall.hx"
						this.webD = ((global::web.proto.WebEventDispatch) (@value) );
						#line 50 "d:\\project\\sangong\\sangong\\src\\gameRoom\\Hall.hx"
						return @value;
					}
					
					
					default:
					{
						#line 50 "d:\\project\\sangong\\sangong\\src\\gameRoom\\Hall.hx"
						return base.__hx_setField(field, hash, @value, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties) {
			unchecked {
				#line 50 "d:\\project\\sangong\\sangong\\src\\gameRoom\\Hall.hx"
				switch (hash) {
					case 588879225:
					{
						#line 50 "d:\\project\\sangong\\sangong\\src\\gameRoom\\Hall.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "onGET_ROOM_INFOC", 588879225)) );
					}
					
					
					case 297493355:
					{
						#line 50 "d:\\project\\sangong\\sangong\\src\\gameRoom\\Hall.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "onCMDResultC", 297493355)) );
					}
					
					
					case 1581035319:
					{
						#line 50 "d:\\project\\sangong\\sangong\\src\\gameRoom\\Hall.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "createRoom", 1581035319)) );
					}
					
					
					case 1008163129:
					{
						#line 50 "d:\\project\\sangong\\sangong\\src\\gameRoom\\Hall.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "onLoginC", 1008163129)) );
					}
					
					
					case 1422715602:
					{
						#line 50 "d:\\project\\sangong\\sangong\\src\\gameRoom\\Hall.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "onCreateClubC", 1422715602)) );
					}
					
					
					case 2043067981:
					{
						#line 50 "d:\\project\\sangong\\sangong\\src\\gameRoom\\Hall.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "onCreateRoomC", 2043067981)) );
					}
					
					
					case 557884804:
					{
						#line 50 "d:\\project\\sangong\\sangong\\src\\gameRoom\\Hall.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "addEventListner", 557884804)) );
					}
					
					
					case 1451561102:
					{
						#line 50 "d:\\project\\sangong\\sangong\\src\\gameRoom\\Hall.hx"
						return this.oneByte;
					}
					
					
					case 796168079:
					{
						#line 50 "d:\\project\\sangong\\sangong\\src\\gameRoom\\Hall.hx"
						return this.heardTimder;
					}
					
					
					case 1816119224:
					{
						#line 50 "d:\\project\\sangong\\sangong\\src\\gameRoom\\Hall.hx"
						return this.sPath;
					}
					
					
					case 1300511267:
					{
						#line 50 "d:\\project\\sangong\\sangong\\src\\gameRoom\\Hall.hx"
						return this.gamesDLL;
					}
					
					
					case 938763356:
					{
						#line 50 "d:\\project\\sangong\\sangong\\src\\gameRoom\\Hall.hx"
						return this.handerAndPlayer;
					}
					
					
					case 401430337:
					{
						#line 50 "d:\\project\\sangong\\sangong\\src\\gameRoom\\Hall.hx"
						return this.roomMap;
					}
					
					
					case 1205545654:
					{
						#line 50 "d:\\project\\sangong\\sangong\\src\\gameRoom\\Hall.hx"
						return this.roomID;
					}
					
					
					case 1324703024:
					{
						#line 50 "d:\\project\\sangong\\sangong\\src\\gameRoom\\Hall.hx"
						return this.webD;
					}
					
					
					default:
					{
						#line 50 "d:\\project\\sangong\\sangong\\src\\gameRoom\\Hall.hx"
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override double __hx_getField_f(string field, int hash, bool throwErrors, bool handleProperties) {
			unchecked {
				#line 50 "d:\\project\\sangong\\sangong\\src\\gameRoom\\Hall.hx"
				switch (hash) {
					case 1205545654:
					{
						#line 50 "d:\\project\\sangong\\sangong\\src\\gameRoom\\Hall.hx"
						return ((double) (this.roomID) );
					}
					
					
					default:
					{
						#line 50 "d:\\project\\sangong\\sangong\\src\\gameRoom\\Hall.hx"
						return base.__hx_getField_f(field, hash, throwErrors, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_invokeField(string field, int hash, object[] dynargs) {
			unchecked {
				#line 50 "d:\\project\\sangong\\sangong\\src\\gameRoom\\Hall.hx"
				switch (hash) {
					case 588879225:
					{
						#line 50 "d:\\project\\sangong\\sangong\\src\\gameRoom\\Hall.hx"
						this.onGET_ROOM_INFOC(((global::web.proto.RoomEvent) (((object) (dynargs[0]) )) ));
						#line 50 "d:\\project\\sangong\\sangong\\src\\gameRoom\\Hall.hx"
						break;
					}
					
					
					case 297493355:
					{
						#line 50 "d:\\project\\sangong\\sangong\\src\\gameRoom\\Hall.hx"
						this.onCMDResultC(((global::web.proto.CMDEvent) (((object) (dynargs[0]) )) ));
						#line 50 "d:\\project\\sangong\\sangong\\src\\gameRoom\\Hall.hx"
						break;
					}
					
					
					case 1581035319:
					{
						#line 50 "d:\\project\\sangong\\sangong\\src\\gameRoom\\Hall.hx"
						this.createRoom(((int) (global::haxe.lang.Runtime.toInt(((object) (dynargs[0]) ))) ), ((object) (dynargs[1]) ));
						#line 50 "d:\\project\\sangong\\sangong\\src\\gameRoom\\Hall.hx"
						break;
					}
					
					
					case 1008163129:
					{
						#line 50 "d:\\project\\sangong\\sangong\\src\\gameRoom\\Hall.hx"
						this.onLoginC(((global::web.proto.HallEvent) (((object) (dynargs[0]) )) ));
						#line 50 "d:\\project\\sangong\\sangong\\src\\gameRoom\\Hall.hx"
						break;
					}
					
					
					case 1422715602:
					{
						#line 50 "d:\\project\\sangong\\sangong\\src\\gameRoom\\Hall.hx"
						this.onCreateClubC(((global::web.proto.ClubEvent) (((object) (dynargs[0]) )) ));
						#line 50 "d:\\project\\sangong\\sangong\\src\\gameRoom\\Hall.hx"
						break;
					}
					
					
					case 2043067981:
					{
						#line 50 "d:\\project\\sangong\\sangong\\src\\gameRoom\\Hall.hx"
						this.onCreateRoomC(((global::web.proto.RoomEvent) (((object) (dynargs[0]) )) ));
						#line 50 "d:\\project\\sangong\\sangong\\src\\gameRoom\\Hall.hx"
						break;
					}
					
					
					case 557884804:
					{
						#line 50 "d:\\project\\sangong\\sangong\\src\\gameRoom\\Hall.hx"
						this.addEventListner();
						#line 50 "d:\\project\\sangong\\sangong\\src\\gameRoom\\Hall.hx"
						break;
					}
					
					
					default:
					{
						#line 50 "d:\\project\\sangong\\sangong\\src\\gameRoom\\Hall.hx"
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
				#line 50 "d:\\project\\sangong\\sangong\\src\\gameRoom\\Hall.hx"
				return null;
			}
			#line default
		}
		
		
		public override void __hx_getFields(global::haxe.root.Array baseArr) {
			#line 50 "d:\\project\\sangong\\sangong\\src\\gameRoom\\Hall.hx"
			baseArr.push("oneByte");
			#line 50 "d:\\project\\sangong\\sangong\\src\\gameRoom\\Hall.hx"
			baseArr.push("heardTimder");
			#line 50 "d:\\project\\sangong\\sangong\\src\\gameRoom\\Hall.hx"
			baseArr.push("sPath");
			#line 50 "d:\\project\\sangong\\sangong\\src\\gameRoom\\Hall.hx"
			baseArr.push("gamesDLL");
			#line 50 "d:\\project\\sangong\\sangong\\src\\gameRoom\\Hall.hx"
			baseArr.push("handerAndPlayer");
			#line 50 "d:\\project\\sangong\\sangong\\src\\gameRoom\\Hall.hx"
			baseArr.push("roomMap");
			#line 50 "d:\\project\\sangong\\sangong\\src\\gameRoom\\Hall.hx"
			baseArr.push("roomID");
			#line 50 "d:\\project\\sangong\\sangong\\src\\gameRoom\\Hall.hx"
			baseArr.push("webD");
			#line 50 "d:\\project\\sangong\\sangong\\src\\gameRoom\\Hall.hx"
			base.__hx_getFields(baseArr);
		}
		#line default
		
	}
}


