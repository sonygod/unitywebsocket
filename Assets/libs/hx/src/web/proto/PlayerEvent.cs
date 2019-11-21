// Generated by Haxe 4.1.0-rc.1+0d88c583b
using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace web.proto {
	public sealed class PlayerEvent : global::openfl.events.Event {
		
		static PlayerEvent() {
			global::web.proto.PlayerEvent.ADD_BET = ((string) ("add_bet") );
			global::web.proto.PlayerEvent.STATIC_CHANGE = ((string) ("static_change") );
			global::web.proto.PlayerEvent.BE_BANKER = ((string) ("be_banker") );
			global::web.proto.PlayerEvent.TRY_TOBE_BANKER = ((string) ("try_tobe_banker") );
			global::web.proto.PlayerEvent.UPDATE = ((string) ("update") );
			global::web.proto.PlayerEvent.GET_USER_INFO = ((string) ("getuserInfo") );
			global::web.proto.PlayerEvent.Playerevent_socket_close = ((string) ("playerevent_socket_close") );
			global::web.proto.PlayerEvent.GET_BASE_USER_INFO = ((string) ("get_base_user_Info") );
			global::web.proto.PlayerEvent.SearchGameResult = ((string) ("player_SearchGameResult") );
			global::web.proto.PlayerEvent.KILL_BANK = ((string) ("player_Kill_bank") );
			global::web.proto.PlayerEvent.RE_CONNECT = ((string) ("player_RE_CONNECT") );
			global::web.proto.PlayerEvent.REGIST = ((string) ("player_REGIST") );
			global::web.proto.PlayerEvent.FORGOT_PASSWORD = ((string) ("player_forgot_passord") );
			global::web.proto.PlayerEvent.MOD_USER_INFO = ((string) ("player_MOD_USER_INFO") );
		}
		
		
		public PlayerEvent(global::haxe.lang.EmptyObject empty) : base(global::haxe.lang.EmptyObject.EMPTY) {
		}
		
		
		public PlayerEvent(string type, object player, object bling, global::server.IHander hander, object key, object bubbles, object cancelable) : base(global::haxe.lang.EmptyObject.EMPTY) {
			global::web.proto.PlayerEvent.__hx_ctor_web_proto_PlayerEvent(this, type, player, bling, hander, key, bubbles, cancelable);
		}
		
		
		private static void __hx_ctor_web_proto_PlayerEvent(global::web.proto.PlayerEvent __hx_this, string type, object player, object bling, global::server.IHander hander, object key, object bubbles, object cancelable) {
			unchecked {
				bool cancelable1 = ( (( cancelable == default(object) )) ? (false) : (global::haxe.lang.Runtime.toBool(cancelable)) );
				bool bubbles1 = ( (( bubbles == default(object) )) ? (true) : (global::haxe.lang.Runtime.toBool(bubbles)) );
				int key1 = ( (( key == default(object) )) ? (-1) : (((int) (global::haxe.lang.Runtime.toInt(key)) )) );
				global::openfl.events.Event.__hx_ctor_openfl_events_Event(__hx_this, type, bubbles1, cancelable1);
				__hx_this.player = player;
				__hx_this.bling = bling;
				__hx_this.hander = hander;
				__hx_this.key = key1;
			}
		}
		
		
		public static string ADD_BET;
		
		public static string STATIC_CHANGE;
		
		public static string BE_BANKER;
		
		public static string TRY_TOBE_BANKER;
		
		public static string UPDATE;
		
		public static string GET_USER_INFO;
		
		public static string Playerevent_socket_close;
		
		public static string GET_BASE_USER_INFO;
		
		public static string SearchGameResult;
		
		public static string KILL_BANK;
		
		public static string RE_CONNECT;
		
		public static string REGIST;
		
		public static string FORGOT_PASSWORD;
		
		public static string MOD_USER_INFO;
		
		public object player;
		
		public object bling;
		
		public global::server.IHander hander;
		
		public int key;
		
		public override global::openfl.events.Event clone() {
			global::web.proto.PlayerEvent @event = new global::web.proto.PlayerEvent(this.type, this.player, this.bling, this.hander, null, this.bubbles, this.cancelable);
			@event.target = this.target;
			@event.currentTarget = this.currentTarget;
			@event.eventPhase = this.eventPhase;
			@event.hander = this.hander;
			return @event;
		}
		
		
		public override double __hx_setField_f(string field, int hash, double @value, bool handleProperties) {
			unchecked {
				switch (hash) {
					case 5343647:
					{
						this.key = ((int) (@value) );
						return @value;
					}
					
					
					case 888664408:
					{
						this.bling = ((object) (@value) );
						return @value;
					}
					
					
					case 934865761:
					{
						this.player = ((object) (@value) );
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
					case 5343647:
					{
						this.key = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 939359644:
					{
						this.hander = ((global::server.IHander) (@value) );
						return @value;
					}
					
					
					case 888664408:
					{
						this.bling = ((object) (@value) );
						return @value;
					}
					
					
					case 934865761:
					{
						this.player = ((object) (@value) );
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
					
					
					case 5343647:
					{
						return this.key;
					}
					
					
					case 939359644:
					{
						return this.hander;
					}
					
					
					case 888664408:
					{
						return this.bling;
					}
					
					
					case 934865761:
					{
						return this.player;
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
					case 5343647:
					{
						return ((double) (this.key) );
					}
					
					
					case 888664408:
					{
						return ((double) (global::haxe.lang.Runtime.toDouble(this.bling)) );
					}
					
					
					case 934865761:
					{
						return ((double) (global::haxe.lang.Runtime.toDouble(this.player)) );
					}
					
					
					default:
					{
						return base.__hx_getField_f(field, hash, throwErrors, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override void __hx_getFields(global::haxe.root.Array baseArr) {
			baseArr.push("key");
			baseArr.push("hander");
			baseArr.push("bling");
			baseArr.push("player");
			base.__hx_getFields(baseArr);
		}
		
		
	}
}


