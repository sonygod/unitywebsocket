// Generated by Haxe 4.1.0-rc.1+cd0f0219b
using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace web.proto {
	public sealed class ResultEvent : global::openfl.events.Event {
		
		static ResultEvent() {
			#line 16 "D:\\project\\sangong\\sangong\\src\\web\\proto\\ResultEvent.hx"
			global::web.proto.ResultEvent.GET_PLAYER_RESULTS = ((string) ("result_get_player_results") );
		}
		#line default
		
		public ResultEvent(global::haxe.lang.EmptyObject empty) : base(global::haxe.lang.EmptyObject.EMPTY) {
		}
		
		
		public ResultEvent(string type, global::haxe.root.Array results, global::server.IHander hander, object bubbles, object cancelable) : base(global::haxe.lang.EmptyObject.EMPTY) {
			#line 23 "D:\\project\\sangong\\sangong\\src\\web\\proto\\ResultEvent.hx"
			global::web.proto.ResultEvent.__hx_ctor_web_proto_ResultEvent(this, type, results, hander, bubbles, cancelable);
		}
		#line default
		
		private static void __hx_ctor_web_proto_ResultEvent(global::web.proto.ResultEvent __hx_this, string type, global::haxe.root.Array results, global::server.IHander hander, object bubbles, object cancelable) {
			#line 22 "D:\\project\\sangong\\sangong\\src\\web\\proto\\ResultEvent.hx"
			bool cancelable1 = ( (( cancelable == default(object) )) ? (false) : (global::haxe.lang.Runtime.toBool(cancelable)) );
			#line 22 "D:\\project\\sangong\\sangong\\src\\web\\proto\\ResultEvent.hx"
			bool bubbles1 = ( (( bubbles == default(object) )) ? (true) : (global::haxe.lang.Runtime.toBool(bubbles)) );
			global::openfl.events.Event.__hx_ctor_openfl_events_Event(__hx_this, type, bubbles1, cancelable1);
			#line 26 "D:\\project\\sangong\\sangong\\src\\web\\proto\\ResultEvent.hx"
			__hx_this.hander = hander;
			__hx_this.results = results;
		}
		#line default
		
		public static string GET_PLAYER_RESULTS;
		
		public global::haxe.root.Array results;
		
		public global::server.IHander hander;
		
		public override global::openfl.events.Event clone() {
			#line 31 "D:\\project\\sangong\\sangong\\src\\web\\proto\\ResultEvent.hx"
			global::web.proto.ResultEvent @event = new global::web.proto.ResultEvent(this.type, this.results, this.hander, this.bubbles, this.cancelable);
			@event.target = this.target;
			#line 33 "D:\\project\\sangong\\sangong\\src\\web\\proto\\ResultEvent.hx"
			@event.currentTarget = this.currentTarget;
			@event.eventPhase = this.eventPhase;
			#line 35 "D:\\project\\sangong\\sangong\\src\\web\\proto\\ResultEvent.hx"
			@event.results = this.results;
			#line 37 "D:\\project\\sangong\\sangong\\src\\web\\proto\\ResultEvent.hx"
			return @event;
		}
		#line default
		
		public override object __hx_setField(string field, int hash, object @value, bool handleProperties) {
			unchecked {
				#line 12 "D:\\project\\sangong\\sangong\\src\\web\\proto\\ResultEvent.hx"
				switch (hash) {
					case 939359644:
					{
						#line 12 "D:\\project\\sangong\\sangong\\src\\web\\proto\\ResultEvent.hx"
						this.hander = ((global::server.IHander) (@value) );
						#line 12 "D:\\project\\sangong\\sangong\\src\\web\\proto\\ResultEvent.hx"
						return @value;
					}
					
					
					case 1800886518:
					{
						#line 12 "D:\\project\\sangong\\sangong\\src\\web\\proto\\ResultEvent.hx"
						this.results = ((global::haxe.root.Array) (@value) );
						#line 12 "D:\\project\\sangong\\sangong\\src\\web\\proto\\ResultEvent.hx"
						return @value;
					}
					
					
					default:
					{
						#line 12 "D:\\project\\sangong\\sangong\\src\\web\\proto\\ResultEvent.hx"
						return base.__hx_setField(field, hash, @value, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties) {
			unchecked {
				#line 12 "D:\\project\\sangong\\sangong\\src\\web\\proto\\ResultEvent.hx"
				switch (hash) {
					case 1214452573:
					{
						#line 12 "D:\\project\\sangong\\sangong\\src\\web\\proto\\ResultEvent.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "clone", 1214452573)) );
					}
					
					
					case 939359644:
					{
						#line 12 "D:\\project\\sangong\\sangong\\src\\web\\proto\\ResultEvent.hx"
						return this.hander;
					}
					
					
					case 1800886518:
					{
						#line 12 "D:\\project\\sangong\\sangong\\src\\web\\proto\\ResultEvent.hx"
						return this.results;
					}
					
					
					default:
					{
						#line 12 "D:\\project\\sangong\\sangong\\src\\web\\proto\\ResultEvent.hx"
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override void __hx_getFields(global::haxe.root.Array baseArr) {
			#line 12 "D:\\project\\sangong\\sangong\\src\\web\\proto\\ResultEvent.hx"
			baseArr.push("hander");
			#line 12 "D:\\project\\sangong\\sangong\\src\\web\\proto\\ResultEvent.hx"
			baseArr.push("results");
			#line 12 "D:\\project\\sangong\\sangong\\src\\web\\proto\\ResultEvent.hx"
			base.__hx_getFields(baseArr);
		}
		#line default
		
	}
}


