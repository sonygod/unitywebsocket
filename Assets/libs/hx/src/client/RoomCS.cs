// Generated by Haxe 4.1.0-rc.1+0d88c583b
using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace client {
	public class RoomCS : global::CEventDispatcher {
		
		public RoomCS(object data) : base() {
			unchecked {
				this.wd = global::web.proto.WebEventDispatch.getInstance();
				this.events = new global::haxe.root.Array(new object[]{});
				{
					this.data = data;
					this.events = new global::haxe.root.Array(new object[]{((string) ("create_room") ), ((string) ("get_room_info") ), ((string) ("join_room") ), ((string) ("leave_room") ), ((string) ("dispatch") ), ((string) ("destory") ), ((string) ("updateRoomUsers") ), ((string) ("result") )});
					global::haxe.Log.trace.__hx_invoke2_o(default(double), "\u623f\u95f4\u521b\u5efa\u6210\u529f\uff0c\u8bf7\u8c03\u7528addEvent() \u5f00\u542f\u503e\u542c", default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"new", "client.RoomCS", "src/client/RoomCS.hx"}, new int[]{1981972957}, new double[]{((double) (46) )}));
				}
				
			}
		}
		
		
		public object data;
		
		public global::haxe.root.Array events;
		
		public global::web.proto.WebEventDispatch wd;
		
		public global::client.ConvertCSHX cs;
		
		public virtual global::haxe.root.Array createPlayers() {
			return null;
		}
		
		
		public virtual void addEvent() {
			unchecked {
				global::web.proto.WebEventDispatch wd = global::web.proto.WebEventDispatch.getInstance();
				wd.@on(((string) ("create_room") ), ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "onCreateRoom", 914379062)) ), default(object), default(object), default(object));
				wd.@on(((string) ("get_room_info") ), ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "onGetRoomInfo", 1577180160)) ), default(object), default(object), default(object));
				wd.@on(((string) ("join_room") ), ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "onJoinRoom", 477978468)) ), default(object), default(object), default(object));
				wd.@on(((string) ("leave_room") ), ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "onLeaveRoom", 2126608787)) ), default(object), default(object), default(object));
				wd.@on(((string) ("dispatch") ), ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "onDispath", 317495956)) ), default(object), default(object), default(object));
				wd.@on(((string) ("destory") ), ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "onRoomDestory", 1765542170)) ), default(object), default(object), default(object));
				wd.@on(((string) ("updateRoomUsers") ), ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "onUpdateRoomUsers", 620069381)) ), default(object), default(object), default(object));
				global::haxe.Log.trace.__hx_invoke2_o(default(double), "\u623f\u95f4\u6dfb\u52a0\u7a83\u542c\u5668\u5b8c\u6bd5", default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"addEvent", "client.RoomCS", "src/client/RoomCS.hx"}, new int[]{1981972957}, new double[]{((double) (69) )}));
			}
		}
		
		
		public virtual void off() {
			global::web.proto.WebEventDispatch wd = global::web.proto.WebEventDispatch.getInstance();
			wd.off(((string) ("create_room") ), ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "onCreateRoom", 914379062)) ), default(object));
			wd.off(((string) ("get_room_info") ), ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "onGetRoomInfo", 1577180160)) ), default(object));
			wd.off(((string) ("join_room") ), ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "onJoinRoom", 477978468)) ), default(object));
			wd.off(((string) ("leave_room") ), ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "onLeaveRoom", 2126608787)) ), default(object));
			wd.off(((string) ("dispatch") ), ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "onDispath", 317495956)) ), default(object));
			wd.off(((string) ("destory") ), ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "onRoomDestory", 1765542170)) ), default(object));
			wd.off(((string) ("updateRoomUsers") ), ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "onUpdateRoomUsers", 620069381)) ), default(object));
		}
		
		
		public virtual void onCreateRoom(global::web.proto.RoomEvent e) {
			( this as global::CEventDispatcher ).dispatchEvent(((global::CEvent) (new global::CEvent(e.type, e)) ), ((object) (this) ));
		}
		
		
		public virtual void onGetRoomInfo(global::web.proto.RoomEvent e) {
			unchecked {
				global::haxe.Log.trace.__hx_invoke2_o(default(double), "roomcs \u83b7\u53d6\u623f\u95f4\u4fe1\u606f", default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"onGetRoomInfo", "client.RoomCS", "src/client/RoomCS.hx"}, new int[]{1981972957}, new double[]{((double) (91) )}));
				( this as global::CEventDispatcher ).dispatchEvent(((global::CEvent) (new global::CEvent(e.type, e)) ), ((object) (this) ));
			}
		}
		
		
		public virtual void onJoinRoom(global::web.proto.RoomEvent e) {
			( this as global::CEventDispatcher ).dispatchEvent(((global::CEvent) (new global::CEvent(e.type, e)) ), ((object) (this) ));
		}
		
		
		public virtual void onDispath(global::web.proto.RoomEvent e) {
			( this as global::CEventDispatcher ).dispatchEvent(((global::CEvent) (new global::CEvent(e.type, e)) ), ((object) (this) ));
		}
		
		
		public virtual void onRoomDestory(global::web.proto.RoomEvent e) {
			( this as global::CEventDispatcher ).dispatchEvent(((global::CEvent) (new global::CEvent(e.type, e)) ), ((object) (this) ));
		}
		
		
		public virtual void onLeaveRoom(global::web.proto.RoomEvent e) {
			( this as global::CEventDispatcher ).dispatchEvent(((global::CEvent) (new global::CEvent(e.type, e)) ), ((object) (this) ));
		}
		
		
		public virtual void onUpdateRoomUsers(global::web.proto.RoomEvent e) {
			( this as global::CEventDispatcher ).dispatchEvent(((global::CEvent) (new global::CEvent(e.type, e)) ), ((object) (this) ));
		}
		
		
		public virtual void transEvent(object e) {
			unchecked {
				global::haxe.Log.trace.__hx_invoke2_o(default(double), global::haxe.lang.Runtime.concat("cs:\u6536\u5230\u56de\u8c03\uff0c\u5e76\u53d1\u9001", global::haxe.root.Std.@string(((object) (global::haxe.lang.Runtime.callField(e, "field", 9671866, new object[]{"type"})) ))), default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"transEvent", "client.RoomCS", "src/client/RoomCS.hx"}, new int[]{1981972957}, new double[]{((double) (117) )}));
				( this as global::CEventDispatcher ).dispatchEvent(((global::CEvent) (new global::CEvent(global::haxe.lang.Runtime.toString(((object) (global::haxe.lang.Runtime.callField(e, "field", 9671866, new object[]{"type"})) )), e)) ), ((object) (this) ));
			}
		}
		
		
		public virtual void removeEvent() {
			unchecked {
				global::haxe.Log.trace.__hx_invoke2_o(default(double), "\u5220\u9664\u623f\u95f4\u7a83\u542c\u5668", default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"removeEvent", "client.RoomCS", "src/client/RoomCS.hx"}, new int[]{1981972957}, new double[]{((double) (124) )}));
				{
					int _g = 0;
					global::haxe.root.Array _g1 = this.events;
					while (( _g < _g1.length )) {
						string e = global::haxe.lang.Runtime.toString(_g1.__get(_g));
						 ++ _g;
						this.wd.removeEventListener(((string) (e) ), ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "transEvent", 529665746)) ), default(object));
					}
					
				}
				
			}
		}
		
		
		public virtual void start() {
			unchecked {
				object r = null;
				{
					object __temp_odecl1 = global::haxe.lang.Runtime.getField(this.data, "id", 23515, true);
					r = new global::haxe.lang.DynamicObject(new int[]{23515}, new object[]{__temp_odecl1}, new int[]{}, new double[]{});
				}
				
				global::web.SocketAsync.sendCS(((int) (((uint) (1) )) ), ((int) (32) ), ((int) (global::haxe.lang.Runtime.toInt(global::haxe.lang.Runtime.getField(this.data, "owerID", 694510256, true))) ), global::org.msgpack.MsgPack.encode(r), null);
			}
		}
		
		
		public virtual void getInfo() {
			unchecked {
				object r = null;
				{
					object __temp_odecl1 = global::haxe.lang.Runtime.getField(this.data, "id", 23515, true);
					r = new global::haxe.lang.DynamicObject(new int[]{23515}, new object[]{__temp_odecl1}, new int[]{}, new double[]{});
				}
				
				global::web.SocketAsync.sendCS(((int) (((uint) (1) )) ), ((int) (16) ), ((int) (global::haxe.lang.Runtime.toInt(global::haxe.lang.Runtime.getField(this.data, "owerID", 694510256, true))) ), global::org.msgpack.MsgPack.encode(r), null);
			}
		}
		
		
	}
}


