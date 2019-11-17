// Generated by Haxe 4.0.2+606b176a3
using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace web.proto {
	public sealed class PlayerEvent : global::openfl.events.Event {
		
		static PlayerEvent() {
			#line 19 "C:\\projects\\BCGAME\\sangong\\src\\web\\proto\\PlayerEvent.hx"
			global::web.proto.PlayerEvent.ADD_BET = ((string) ("add_bet") );
			#line 24 "C:\\projects\\BCGAME\\sangong\\src\\web\\proto\\PlayerEvent.hx"
			global::web.proto.PlayerEvent.STATIC_CHANGE = ((string) ("static_change") );
			#line 29 "C:\\projects\\BCGAME\\sangong\\src\\web\\proto\\PlayerEvent.hx"
			global::web.proto.PlayerEvent.BE_BANKER = ((string) ("be_banker") );
			#line 31 "C:\\projects\\BCGAME\\sangong\\src\\web\\proto\\PlayerEvent.hx"
			global::web.proto.PlayerEvent.TRY_TOBE_BANKER = ((string) ("try_tobe_banker") );
			#line 33 "C:\\projects\\BCGAME\\sangong\\src\\web\\proto\\PlayerEvent.hx"
			global::web.proto.PlayerEvent.UPDATE = ((string) ("update") );
			#line 35 "C:\\projects\\BCGAME\\sangong\\src\\web\\proto\\PlayerEvent.hx"
			global::web.proto.PlayerEvent.GET_USER_INFO = ((string) ("getuserInfo") );
			global::web.proto.PlayerEvent.Playerevent_socket_close = ((string) ("playerevent_socket_close") );
			#line 38 "C:\\projects\\BCGAME\\sangong\\src\\web\\proto\\PlayerEvent.hx"
			global::web.proto.PlayerEvent.GET_BASE_USER_INFO = ((string) ("get_base_user_Info") );
			#line 40 "C:\\projects\\BCGAME\\sangong\\src\\web\\proto\\PlayerEvent.hx"
			global::web.proto.PlayerEvent.SearchGameResult = ((string) ("player_SearchGameResult") );
			#line 42 "C:\\projects\\BCGAME\\sangong\\src\\web\\proto\\PlayerEvent.hx"
			global::web.proto.PlayerEvent.KILL_BANK = ((string) ("player_Kill_bank") );
			#line 45 "C:\\projects\\BCGAME\\sangong\\src\\web\\proto\\PlayerEvent.hx"
			global::web.proto.PlayerEvent.RE_CONNECT = ((string) ("player_RE_CONNECT") );
			#line 48 "C:\\projects\\BCGAME\\sangong\\src\\web\\proto\\PlayerEvent.hx"
			global::web.proto.PlayerEvent.REGIST = ((string) ("player_REGIST") );
			#line 50 "C:\\projects\\BCGAME\\sangong\\src\\web\\proto\\PlayerEvent.hx"
			global::web.proto.PlayerEvent.FORGOT_PASSWORD = ((string) ("player_forgot_passord") );
			#line 52 "C:\\projects\\BCGAME\\sangong\\src\\web\\proto\\PlayerEvent.hx"
			global::web.proto.PlayerEvent.MOD_USER_INFO = ((string) ("player_MOD_USER_INFO") );
		}
		#line default
		
		public PlayerEvent(global::haxe.lang.EmptyObject empty) : base(global::haxe.lang.EmptyObject.EMPTY) {
		}
		
		
		public PlayerEvent(string type, object player, object bling, global::server.IHander hander, object key, object bubbles, object cancelable) : base(global::haxe.lang.EmptyObject.EMPTY) {
			#line 67 "C:\\projects\\BCGAME\\sangong\\src\\web\\proto\\PlayerEvent.hx"
			global::web.proto.PlayerEvent.__hx_ctor_web_proto_PlayerEvent(this, type, player, bling, hander, key, bubbles, cancelable);
		}
		#line default
		
		private static void __hx_ctor_web_proto_PlayerEvent(global::web.proto.PlayerEvent __hx_this, string type, object player, object bling, global::server.IHander hander, object key, object bubbles, object cancelable) {
			unchecked {
				#line 66 "C:\\projects\\BCGAME\\sangong\\src\\web\\proto\\PlayerEvent.hx"
				bool cancelable1 = ( (( cancelable == default(object) )) ? (false) : (global::haxe.lang.Runtime.toBool(cancelable)) );
				#line 66 "C:\\projects\\BCGAME\\sangong\\src\\web\\proto\\PlayerEvent.hx"
				bool bubbles1 = ( (( bubbles == default(object) )) ? (true) : (global::haxe.lang.Runtime.toBool(bubbles)) );
				#line 66 "C:\\projects\\BCGAME\\sangong\\src\\web\\proto\\PlayerEvent.hx"
				int key1 = ( (( key == default(object) )) ? (-1) : (((int) (global::haxe.lang.Runtime.toInt(key)) )) );
				global::openfl.events.Event.__hx_ctor_openfl_events_Event(__hx_this, type, bubbles1, cancelable1);
				#line 69 "C:\\projects\\BCGAME\\sangong\\src\\web\\proto\\PlayerEvent.hx"
				__hx_this.player = player;
				__hx_this.bling = bling;
				#line 71 "C:\\projects\\BCGAME\\sangong\\src\\web\\proto\\PlayerEvent.hx"
				__hx_this.hander = hander;
				__hx_this.key = key1;
			}
			#line default
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
			#line 76 "C:\\projects\\BCGAME\\sangong\\src\\web\\proto\\PlayerEvent.hx"
			global::web.proto.PlayerEvent @event = new global::web.proto.PlayerEvent(this.type, this.player, this.bling, this.hander, null, this.bubbles, this.cancelable);
			@event.target = this.target;
			#line 78 "C:\\projects\\BCGAME\\sangong\\src\\web\\proto\\PlayerEvent.hx"
			@event.currentTarget = this.currentTarget;
			@event.eventPhase = this.eventPhase;
			#line 80 "C:\\projects\\BCGAME\\sangong\\src\\web\\proto\\PlayerEvent.hx"
			@event.hander = this.hander;
			return @event;
		}
		#line default
		
		public override double __hx_setField_f(string field, int hash, double @value, bool handleProperties) {
			unchecked {
				#line 15 "C:\\projects\\BCGAME\\sangong\\src\\web\\proto\\PlayerEvent.hx"
				switch (hash) {
					case 5343647:
					{
						#line 15 "C:\\projects\\BCGAME\\sangong\\src\\web\\proto\\PlayerEvent.hx"
						this.key = ((int) (@value) );
						#line 15 "C:\\projects\\BCGAME\\sangong\\src\\web\\proto\\PlayerEvent.hx"
						return @value;
					}
					
					
					case 888664408:
					{
						#line 15 "C:\\projects\\BCGAME\\sangong\\src\\web\\proto\\PlayerEvent.hx"
						this.bling = ((object) (@value) );
						#line 15 "C:\\projects\\BCGAME\\sangong\\src\\web\\proto\\PlayerEvent.hx"
						return @value;
					}
					
					
					case 934865761:
					{
						#line 15 "C:\\projects\\BCGAME\\sangong\\src\\web\\proto\\PlayerEvent.hx"
						this.player = ((object) (@value) );
						#line 15 "C:\\projects\\BCGAME\\sangong\\src\\web\\proto\\PlayerEvent.hx"
						return @value;
					}
					
					
					default:
					{
						#line 15 "C:\\projects\\BCGAME\\sangong\\src\\web\\proto\\PlayerEvent.hx"
						return base.__hx_setField_f(field, hash, @value, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_setField(string field, int hash, object @value, bool handleProperties) {
			unchecked {
				#line 15 "C:\\projects\\BCGAME\\sangong\\src\\web\\proto\\PlayerEvent.hx"
				switch (hash) {
					case 5343647:
					{
						#line 15 "C:\\projects\\BCGAME\\sangong\\src\\web\\proto\\PlayerEvent.hx"
						this.key = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						#line 15 "C:\\projects\\BCGAME\\sangong\\src\\web\\proto\\PlayerEvent.hx"
						return @value;
					}
					
					
					case 939359644:
					{
						#line 15 "C:\\projects\\BCGAME\\sangong\\src\\web\\proto\\PlayerEvent.hx"
						this.hander = ((global::server.IHander) (@value) );
						#line 15 "C:\\projects\\BCGAME\\sangong\\src\\web\\proto\\PlayerEvent.hx"
						return @value;
					}
					
					
					case 888664408:
					{
						#line 15 "C:\\projects\\BCGAME\\sangong\\src\\web\\proto\\PlayerEvent.hx"
						this.bling = ((object) (@value) );
						#line 15 "C:\\projects\\BCGAME\\sangong\\src\\web\\proto\\PlayerEvent.hx"
						return @value;
					}
					
					
					case 934865761:
					{
						#line 15 "C:\\projects\\BCGAME\\sangong\\src\\web\\proto\\PlayerEvent.hx"
						this.player = ((object) (@value) );
						#line 15 "C:\\projects\\BCGAME\\sangong\\src\\web\\proto\\PlayerEvent.hx"
						return @value;
					}
					
					
					default:
					{
						#line 15 "C:\\projects\\BCGAME\\sangong\\src\\web\\proto\\PlayerEvent.hx"
						return base.__hx_setField(field, hash, @value, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties) {
			unchecked {
				#line 15 "C:\\projects\\BCGAME\\sangong\\src\\web\\proto\\PlayerEvent.hx"
				switch (hash) {
					case 1214452573:
					{
						#line 15 "C:\\projects\\BCGAME\\sangong\\src\\web\\proto\\PlayerEvent.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "clone", 1214452573)) );
					}
					
					
					case 5343647:
					{
						#line 15 "C:\\projects\\BCGAME\\sangong\\src\\web\\proto\\PlayerEvent.hx"
						return this.key;
					}
					
					
					case 939359644:
					{
						#line 15 "C:\\projects\\BCGAME\\sangong\\src\\web\\proto\\PlayerEvent.hx"
						return this.hander;
					}
					
					
					case 888664408:
					{
						#line 15 "C:\\projects\\BCGAME\\sangong\\src\\web\\proto\\PlayerEvent.hx"
						return this.bling;
					}
					
					
					case 934865761:
					{
						#line 15 "C:\\projects\\BCGAME\\sangong\\src\\web\\proto\\PlayerEvent.hx"
						return this.player;
					}
					
					
					default:
					{
						#line 15 "C:\\projects\\BCGAME\\sangong\\src\\web\\proto\\PlayerEvent.hx"
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override double __hx_getField_f(string field, int hash, bool throwErrors, bool handleProperties) {
			unchecked {
				#line 15 "C:\\projects\\BCGAME\\sangong\\src\\web\\proto\\PlayerEvent.hx"
				switch (hash) {
					case 5343647:
					{
						#line 15 "C:\\projects\\BCGAME\\sangong\\src\\web\\proto\\PlayerEvent.hx"
						return ((double) (this.key) );
					}
					
					
					case 888664408:
					{
						#line 15 "C:\\projects\\BCGAME\\sangong\\src\\web\\proto\\PlayerEvent.hx"
						return ((double) (global::haxe.lang.Runtime.toDouble(this.bling)) );
					}
					
					
					case 934865761:
					{
						#line 15 "C:\\projects\\BCGAME\\sangong\\src\\web\\proto\\PlayerEvent.hx"
						return ((double) (global::haxe.lang.Runtime.toDouble(this.player)) );
					}
					
					
					default:
					{
						#line 15 "C:\\projects\\BCGAME\\sangong\\src\\web\\proto\\PlayerEvent.hx"
						return base.__hx_getField_f(field, hash, throwErrors, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override void __hx_getFields(global::haxe.root.Array baseArr) {
			#line 15 "C:\\projects\\BCGAME\\sangong\\src\\web\\proto\\PlayerEvent.hx"
			baseArr.push("key");
			#line 15 "C:\\projects\\BCGAME\\sangong\\src\\web\\proto\\PlayerEvent.hx"
			baseArr.push("hander");
			#line 15 "C:\\projects\\BCGAME\\sangong\\src\\web\\proto\\PlayerEvent.hx"
			baseArr.push("bling");
			#line 15 "C:\\projects\\BCGAME\\sangong\\src\\web\\proto\\PlayerEvent.hx"
			baseArr.push("player");
			#line 15 "C:\\projects\\BCGAME\\sangong\\src\\web\\proto\\PlayerEvent.hx"
			base.__hx_getFields(baseArr);
		}
		#line default
		
	}
}


