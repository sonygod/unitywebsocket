// Generated by Haxe 4.1.0-rc.1+0d88c583b
using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace web.proto {
	public sealed class RoomEvent : global::openfl.events.Event {
		
		static RoomEvent() {
			global::web.proto.RoomEvent.CREATE_ROOM = ((string) ("create_room") );
			global::web.proto.RoomEvent.GET_ROOM_INFO = ((string) ("get_room_info") );
			global::web.proto.RoomEvent.JOIN_ROOM = ((string) ("join_room") );
			global::web.proto.RoomEvent.LEAVE_ROOM = ((string) ("leave_room") );
			global::web.proto.RoomEvent.DISPATCH = ((string) ("dispatch") );
			global::web.proto.RoomEvent.RESULT = ((string) ("result") );
			global::web.proto.RoomEvent.DESTORY = ((string) ("destory") );
			global::web.proto.RoomEvent.ROOM_CHANGE_STATUS = ((string) ("room_change_status") );
			global::web.proto.RoomEvent.UPDATE_ROOM_USERS = ((string) ("updateRoomUsers") );
			global::web.proto.RoomEvent.KILL_BANK = ((string) ("room_kill_banker") );
			global::web.proto.RoomEvent.START = ((string) ("room_start_game") );
		}
		
		
		public RoomEvent(global::haxe.lang.EmptyObject empty) : base(global::haxe.lang.EmptyObject.EMPTY) {
		}
		
		
		public RoomEvent(string type, object room, object player, global::server.IHander hander, object result, object bubbles, object cancelable) : base(global::haxe.lang.EmptyObject.EMPTY) {
			global::web.proto.RoomEvent.__hx_ctor_web_proto_RoomEvent(this, type, room, player, hander, result, bubbles, cancelable);
		}
		
		
		private static void __hx_ctor_web_proto_RoomEvent(global::web.proto.RoomEvent __hx_this, string type, object room, object player, global::server.IHander hander, object result, object bubbles, object cancelable) {
			bool cancelable1 = ( (( cancelable == default(object) )) ? (false) : (global::haxe.lang.Runtime.toBool(cancelable)) );
			bool bubbles1 = ( (( bubbles == default(object) )) ? (true) : (global::haxe.lang.Runtime.toBool(bubbles)) );
			global::openfl.events.Event.__hx_ctor_openfl_events_Event(__hx_this, type, bubbles1, cancelable1);
			__hx_this.room = room;
			__hx_this.player = player;
			__hx_this.hander = hander;
			__hx_this.result = result;
		}
		
		
		public static string CREATE_ROOM;
		
		public static string GET_ROOM_INFO;
		
		public static string JOIN_ROOM;
		
		public static string LEAVE_ROOM;
		
		public static string DISPATCH;
		
		public static string RESULT;
		
		public static string DESTORY;
		
		public static string ROOM_CHANGE_STATUS;
		
		public static string UPDATE_ROOM_USERS;
		
		public static string KILL_BANK;
		
		public static string START;
		
		public object room;
		
		public object player;
		
		public global::server.IHander hander;
		
		public object result;
		
		public override global::openfl.events.Event clone() {
			global::web.proto.RoomEvent @event = new global::web.proto.RoomEvent(this.type, this.room, this.player, this.hander, this.result, this.bubbles, this.cancelable);
			@event.target = this.target;
			@event.currentTarget = this.currentTarget;
			@event.eventPhase = this.eventPhase;
			@event.room = this.room;
			@event.player = this.player;
			@event.hander = this.hander;
			@event.result = this.result;
			return @event;
		}
		
		
		public override double __hx_setField_f(string field, int hash, double @value, bool handleProperties) {
			unchecked {
				switch (hash) {
					case 142895325:
					{
						this.result = ((object) (@value) );
						return @value;
					}
					
					
					case 934865761:
					{
						this.player = ((object) (@value) );
						return @value;
					}
					
					
					case 1269755419:
					{
						this.room = ((object) (@value) );
						return @value;
					}
					
					
					default:
					{
						return base.__hx_setField_f(field, hash, @value, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override object __hx_setField(string field, int hash, object @value, bool handleProperties) {
			unchecked {
				switch (hash) {
					case 142895325:
					{
						this.result = ((object) (@value) );
						return @value;
					}
					
					
					case 939359644:
					{
						this.hander = ((global::server.IHander) (@value) );
						return @value;
					}
					
					
					case 934865761:
					{
						this.player = ((object) (@value) );
						return @value;
					}
					
					
					case 1269755419:
					{
						this.room = ((object) (@value) );
						return @value;
					}
					
					
					default:
					{
						return base.__hx_setField(field, hash, @value, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties) {
			unchecked {
				switch (hash) {
					case 1214452573:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "clone", 1214452573)) );
					}
					
					
					case 142895325:
					{
						return this.result;
					}
					
					
					case 939359644:
					{
						return this.hander;
					}
					
					
					case 934865761:
					{
						return this.player;
					}
					
					
					case 1269755419:
					{
						return this.room;
					}
					
					
					default:
					{
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override double __hx_getField_f(string field, int hash, bool throwErrors, bool handleProperties) {
			unchecked {
				switch (hash) {
					case 142895325:
					{
						return ((double) (global::haxe.lang.Runtime.toDouble(this.result)) );
					}
					
					
					case 934865761:
					{
						return ((double) (global::haxe.lang.Runtime.toDouble(this.player)) );
					}
					
					
					case 1269755419:
					{
						return ((double) (global::haxe.lang.Runtime.toDouble(this.room)) );
					}
					
					
					default:
					{
						return base.__hx_getField_f(field, hash, throwErrors, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override void __hx_getFields(global::haxe.root.Array baseArr) {
			baseArr.push("result");
			baseArr.push("hander");
			baseArr.push("player");
			baseArr.push("room");
			base.__hx_getFields(baseArr);
		}
		
		
	}
}


