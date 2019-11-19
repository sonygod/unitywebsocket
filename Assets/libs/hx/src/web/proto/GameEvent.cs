// Generated by Haxe 4.1.0-rc.1+0d88c583b
using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace web.proto {
	public sealed class GameEvent : global::openfl.events.Event {
		
		static GameEvent() {
			#line 16 "D:\\project\\sangong\\sangong\\src\\web\\proto\\GameEvent.hx"
			global::web.proto.GameEvent.GameOver = ((string) ("game_over") );
			#line 18 "D:\\project\\sangong\\sangong\\src\\web\\proto\\GameEvent.hx"
			global::web.proto.GameEvent.GameStart = ((string) ("game_start") );
			#line 20 "D:\\project\\sangong\\sangong\\src\\web\\proto\\GameEvent.hx"
			global::web.proto.GameEvent.GameStartBet = ((string) ("game_start_bet") );
			#line 22 "D:\\project\\sangong\\sangong\\src\\web\\proto\\GameEvent.hx"
			global::web.proto.GameEvent.GameEndBet = ((string) ("game_End_bet") );
			#line 24 "D:\\project\\sangong\\sangong\\src\\web\\proto\\GameEvent.hx"
			global::web.proto.GameEvent.GameDispatch = ((string) ("game_dispatch") );
			#line 26 "D:\\project\\sangong\\sangong\\src\\web\\proto\\GameEvent.hx"
			global::web.proto.GameEvent.GameReadyStart = ((string) ("game_ready_start") );
			#line 28 "D:\\project\\sangong\\sangong\\src\\web\\proto\\GameEvent.hx"
			global::web.proto.GameEvent.GameRoundResult = ((string) ("game_round_result") );
			#line 31 "D:\\project\\sangong\\sangong\\src\\web\\proto\\GameEvent.hx"
			global::web.proto.GameEvent.SearchGameResult = ((string) ("game_SearchGameResult") );
		}
		#line default
		
		public GameEvent(global::haxe.lang.EmptyObject empty) : base(global::haxe.lang.EmptyObject.EMPTY) {
		}
		
		
		public GameEvent(string type, object result, global::haxe.root.Array totalResult, object room, global::server.IHander hander, object bubbles, object cancelable) : base(global::haxe.lang.EmptyObject.EMPTY) {
			#line 43 "D:\\project\\sangong\\sangong\\src\\web\\proto\\GameEvent.hx"
			global::web.proto.GameEvent.__hx_ctor_web_proto_GameEvent(this, type, result, totalResult, room, hander, bubbles, cancelable);
		}
		#line default
		
		private static void __hx_ctor_web_proto_GameEvent(global::web.proto.GameEvent __hx_this, string type, object result, global::haxe.root.Array totalResult, object room, global::server.IHander hander, object bubbles, object cancelable) {
			#line 42 "D:\\project\\sangong\\sangong\\src\\web\\proto\\GameEvent.hx"
			bool cancelable1 = ( (( cancelable == default(object) )) ? (false) : (global::haxe.lang.Runtime.toBool(cancelable)) );
			#line 42 "D:\\project\\sangong\\sangong\\src\\web\\proto\\GameEvent.hx"
			bool bubbles1 = ( (( bubbles == default(object) )) ? (true) : (global::haxe.lang.Runtime.toBool(bubbles)) );
			global::openfl.events.Event.__hx_ctor_openfl_events_Event(__hx_this, type, bubbles1, cancelable1);
			#line 45 "D:\\project\\sangong\\sangong\\src\\web\\proto\\GameEvent.hx"
			__hx_this.result = result;
			__hx_this.totalResult = totalResult;
			#line 47 "D:\\project\\sangong\\sangong\\src\\web\\proto\\GameEvent.hx"
			__hx_this.room = room;
			__hx_this.hander = hander;
		}
		#line default
		
		public static string GameOver;
		
		public static string GameStart;
		
		public static string GameStartBet;
		
		public static string GameEndBet;
		
		public static string GameDispatch;
		
		public static string GameReadyStart;
		
		public static string GameRoundResult;
		
		public static string SearchGameResult;
		
		public object result;
		
		public global::haxe.root.Array totalResult;
		
		public object room;
		
		public global::server.IHander hander;
		
		public override double __hx_setField_f(string field, int hash, double @value, bool handleProperties) {
			unchecked {
				#line 12 "D:\\project\\sangong\\sangong\\src\\web\\proto\\GameEvent.hx"
				switch (hash) {
					case 1269755419:
					{
						#line 12 "D:\\project\\sangong\\sangong\\src\\web\\proto\\GameEvent.hx"
						this.room = ((object) (@value) );
						#line 12 "D:\\project\\sangong\\sangong\\src\\web\\proto\\GameEvent.hx"
						return @value;
					}
					
					
					case 142895325:
					{
						#line 12 "D:\\project\\sangong\\sangong\\src\\web\\proto\\GameEvent.hx"
						this.result = ((object) (@value) );
						#line 12 "D:\\project\\sangong\\sangong\\src\\web\\proto\\GameEvent.hx"
						return @value;
					}
					
					
					default:
					{
						#line 12 "D:\\project\\sangong\\sangong\\src\\web\\proto\\GameEvent.hx"
						return base.__hx_setField_f(field, hash, @value, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_setField(string field, int hash, object @value, bool handleProperties) {
			unchecked {
				#line 12 "D:\\project\\sangong\\sangong\\src\\web\\proto\\GameEvent.hx"
				switch (hash) {
					case 939359644:
					{
						#line 12 "D:\\project\\sangong\\sangong\\src\\web\\proto\\GameEvent.hx"
						this.hander = ((global::server.IHander) (@value) );
						#line 12 "D:\\project\\sangong\\sangong\\src\\web\\proto\\GameEvent.hx"
						return @value;
					}
					
					
					case 1269755419:
					{
						#line 12 "D:\\project\\sangong\\sangong\\src\\web\\proto\\GameEvent.hx"
						this.room = ((object) (@value) );
						#line 12 "D:\\project\\sangong\\sangong\\src\\web\\proto\\GameEvent.hx"
						return @value;
					}
					
					
					case 1320836033:
					{
						#line 12 "D:\\project\\sangong\\sangong\\src\\web\\proto\\GameEvent.hx"
						this.totalResult = ((global::haxe.root.Array) (@value) );
						#line 12 "D:\\project\\sangong\\sangong\\src\\web\\proto\\GameEvent.hx"
						return @value;
					}
					
					
					case 142895325:
					{
						#line 12 "D:\\project\\sangong\\sangong\\src\\web\\proto\\GameEvent.hx"
						this.result = ((object) (@value) );
						#line 12 "D:\\project\\sangong\\sangong\\src\\web\\proto\\GameEvent.hx"
						return @value;
					}
					
					
					default:
					{
						#line 12 "D:\\project\\sangong\\sangong\\src\\web\\proto\\GameEvent.hx"
						return base.__hx_setField(field, hash, @value, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties) {
			unchecked {
				#line 12 "D:\\project\\sangong\\sangong\\src\\web\\proto\\GameEvent.hx"
				switch (hash) {
					case 939359644:
					{
						#line 12 "D:\\project\\sangong\\sangong\\src\\web\\proto\\GameEvent.hx"
						return this.hander;
					}
					
					
					case 1269755419:
					{
						#line 12 "D:\\project\\sangong\\sangong\\src\\web\\proto\\GameEvent.hx"
						return this.room;
					}
					
					
					case 1320836033:
					{
						#line 12 "D:\\project\\sangong\\sangong\\src\\web\\proto\\GameEvent.hx"
						return this.totalResult;
					}
					
					
					case 142895325:
					{
						#line 12 "D:\\project\\sangong\\sangong\\src\\web\\proto\\GameEvent.hx"
						return this.result;
					}
					
					
					default:
					{
						#line 12 "D:\\project\\sangong\\sangong\\src\\web\\proto\\GameEvent.hx"
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override double __hx_getField_f(string field, int hash, bool throwErrors, bool handleProperties) {
			unchecked {
				#line 12 "D:\\project\\sangong\\sangong\\src\\web\\proto\\GameEvent.hx"
				switch (hash) {
					case 1269755419:
					{
						#line 12 "D:\\project\\sangong\\sangong\\src\\web\\proto\\GameEvent.hx"
						return ((double) (global::haxe.lang.Runtime.toDouble(this.room)) );
					}
					
					
					case 142895325:
					{
						#line 12 "D:\\project\\sangong\\sangong\\src\\web\\proto\\GameEvent.hx"
						return ((double) (global::haxe.lang.Runtime.toDouble(this.result)) );
					}
					
					
					default:
					{
						#line 12 "D:\\project\\sangong\\sangong\\src\\web\\proto\\GameEvent.hx"
						return base.__hx_getField_f(field, hash, throwErrors, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override void __hx_getFields(global::haxe.root.Array baseArr) {
			#line 12 "D:\\project\\sangong\\sangong\\src\\web\\proto\\GameEvent.hx"
			baseArr.push("hander");
			#line 12 "D:\\project\\sangong\\sangong\\src\\web\\proto\\GameEvent.hx"
			baseArr.push("room");
			#line 12 "D:\\project\\sangong\\sangong\\src\\web\\proto\\GameEvent.hx"
			baseArr.push("totalResult");
			#line 12 "D:\\project\\sangong\\sangong\\src\\web\\proto\\GameEvent.hx"
			baseArr.push("result");
			#line 12 "D:\\project\\sangong\\sangong\\src\\web\\proto\\GameEvent.hx"
			base.__hx_getFields(baseArr);
		}
		#line default
		
	}
}


