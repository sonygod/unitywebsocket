// Generated by Haxe 4.1.0-rc.1+0d88c583b
using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace web.proto {
	public class ShoppingEvent : global::openfl.events.Event {
		
		static ShoppingEvent() {
			#line 13 "D:\\project\\sangong\\sangong\\src\\web\\proto\\ShoppingEvent.hx"
			global::web.proto.ShoppingEvent.GET_BUY_LIST = ((string) ("ShoppingEvent_get_buy_list") );
			#line 15 "D:\\project\\sangong\\sangong\\src\\web\\proto\\ShoppingEvent.hx"
			global::web.proto.ShoppingEvent.GET_CHARGE_LIST = ((string) ("ShoppingEvent_get_charge_list") );
			#line 17 "D:\\project\\sangong\\sangong\\src\\web\\proto\\ShoppingEvent.hx"
			global::web.proto.ShoppingEvent.GET_DRAW_OUT_LIST = ((string) ("ShoppingEvent_get_draw_out_list") );
			#line 19 "D:\\project\\sangong\\sangong\\src\\web\\proto\\ShoppingEvent.hx"
			global::web.proto.ShoppingEvent.GET_LAST_CHARGE_TIME = ((string) ("ShoppingEvent_get_last_charge_time") );
			#line 22 "D:\\project\\sangong\\sangong\\src\\web\\proto\\ShoppingEvent.hx"
			global::web.proto.ShoppingEvent.GET_REATE = ((string) ("ShoppingEvent_get_rate") );
		}
		#line default
		
		public ShoppingEvent(global::haxe.lang.EmptyObject empty) : base(global::haxe.lang.EmptyObject.EMPTY) {
		}
		
		
		public ShoppingEvent(string type, global::haxe.root.Array chargeList, global::haxe.root.Array buyList, global::haxe.root.Array drawOutList, global::server.IHander hander, object result, object bubbles, object cancelable) : base(global::haxe.lang.EmptyObject.EMPTY) {
			#line 41 "D:\\project\\sangong\\sangong\\src\\web\\proto\\ShoppingEvent.hx"
			global::web.proto.ShoppingEvent.__hx_ctor_web_proto_ShoppingEvent(this, type, chargeList, buyList, drawOutList, hander, result, bubbles, cancelable);
		}
		#line default
		
		protected static void __hx_ctor_web_proto_ShoppingEvent(global::web.proto.ShoppingEvent __hx_this, string type, global::haxe.root.Array chargeList, global::haxe.root.Array buyList, global::haxe.root.Array drawOutList, global::server.IHander hander, object result, object bubbles, object cancelable) {
			#line 40 "D:\\project\\sangong\\sangong\\src\\web\\proto\\ShoppingEvent.hx"
			bool cancelable1 = ( (( cancelable == default(object) )) ? (false) : (global::haxe.lang.Runtime.toBool(cancelable)) );
			#line 40 "D:\\project\\sangong\\sangong\\src\\web\\proto\\ShoppingEvent.hx"
			bool bubbles1 = ( (( bubbles == default(object) )) ? (true) : (global::haxe.lang.Runtime.toBool(bubbles)) );
			global::openfl.events.Event.__hx_ctor_openfl_events_Event(__hx_this, type, bubbles1, cancelable1);
			#line 43 "D:\\project\\sangong\\sangong\\src\\web\\proto\\ShoppingEvent.hx"
			__hx_this.hander = hander;
			__hx_this.chargeList = chargeList;
			#line 45 "D:\\project\\sangong\\sangong\\src\\web\\proto\\ShoppingEvent.hx"
			__hx_this.buyList = buyList;
			__hx_this.drawOutList = drawOutList;
		}
		#line default
		
		public static string GET_BUY_LIST;
		
		public static string GET_CHARGE_LIST;
		
		public static string GET_DRAW_OUT_LIST;
		
		public static string GET_LAST_CHARGE_TIME;
		
		public static string GET_REATE;
		
		public global::haxe.root.Array chargeList;
		
		public global::haxe.root.Array buyList;
		
		public global::haxe.root.Array drawOutList;
		
		public double rate;
		
		public global::server.IHander hander;
		
		public override double __hx_setField_f(string field, int hash, double @value, bool handleProperties) {
			unchecked {
				#line 9 "D:\\project\\sangong\\sangong\\src\\web\\proto\\ShoppingEvent.hx"
				switch (hash) {
					case 1269060320:
					{
						#line 9 "D:\\project\\sangong\\sangong\\src\\web\\proto\\ShoppingEvent.hx"
						this.rate = ((double) (@value) );
						#line 9 "D:\\project\\sangong\\sangong\\src\\web\\proto\\ShoppingEvent.hx"
						return @value;
					}
					
					
					default:
					{
						#line 9 "D:\\project\\sangong\\sangong\\src\\web\\proto\\ShoppingEvent.hx"
						return base.__hx_setField_f(field, hash, @value, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_setField(string field, int hash, object @value, bool handleProperties) {
			unchecked {
				#line 9 "D:\\project\\sangong\\sangong\\src\\web\\proto\\ShoppingEvent.hx"
				switch (hash) {
					case 939359644:
					{
						#line 9 "D:\\project\\sangong\\sangong\\src\\web\\proto\\ShoppingEvent.hx"
						this.hander = ((global::server.IHander) (@value) );
						#line 9 "D:\\project\\sangong\\sangong\\src\\web\\proto\\ShoppingEvent.hx"
						return @value;
					}
					
					
					case 1269060320:
					{
						#line 9 "D:\\project\\sangong\\sangong\\src\\web\\proto\\ShoppingEvent.hx"
						this.rate = ((double) (global::haxe.lang.Runtime.toDouble(@value)) );
						#line 9 "D:\\project\\sangong\\sangong\\src\\web\\proto\\ShoppingEvent.hx"
						return @value;
					}
					
					
					case 366972008:
					{
						#line 9 "D:\\project\\sangong\\sangong\\src\\web\\proto\\ShoppingEvent.hx"
						this.drawOutList = ((global::haxe.root.Array) (@value) );
						#line 9 "D:\\project\\sangong\\sangong\\src\\web\\proto\\ShoppingEvent.hx"
						return @value;
					}
					
					
					case 285288132:
					{
						#line 9 "D:\\project\\sangong\\sangong\\src\\web\\proto\\ShoppingEvent.hx"
						this.buyList = ((global::haxe.root.Array) (@value) );
						#line 9 "D:\\project\\sangong\\sangong\\src\\web\\proto\\ShoppingEvent.hx"
						return @value;
					}
					
					
					case 1213345010:
					{
						#line 9 "D:\\project\\sangong\\sangong\\src\\web\\proto\\ShoppingEvent.hx"
						this.chargeList = ((global::haxe.root.Array) (@value) );
						#line 9 "D:\\project\\sangong\\sangong\\src\\web\\proto\\ShoppingEvent.hx"
						return @value;
					}
					
					
					default:
					{
						#line 9 "D:\\project\\sangong\\sangong\\src\\web\\proto\\ShoppingEvent.hx"
						return base.__hx_setField(field, hash, @value, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties) {
			unchecked {
				#line 9 "D:\\project\\sangong\\sangong\\src\\web\\proto\\ShoppingEvent.hx"
				switch (hash) {
					case 939359644:
					{
						#line 9 "D:\\project\\sangong\\sangong\\src\\web\\proto\\ShoppingEvent.hx"
						return this.hander;
					}
					
					
					case 1269060320:
					{
						#line 9 "D:\\project\\sangong\\sangong\\src\\web\\proto\\ShoppingEvent.hx"
						return this.rate;
					}
					
					
					case 366972008:
					{
						#line 9 "D:\\project\\sangong\\sangong\\src\\web\\proto\\ShoppingEvent.hx"
						return this.drawOutList;
					}
					
					
					case 285288132:
					{
						#line 9 "D:\\project\\sangong\\sangong\\src\\web\\proto\\ShoppingEvent.hx"
						return this.buyList;
					}
					
					
					case 1213345010:
					{
						#line 9 "D:\\project\\sangong\\sangong\\src\\web\\proto\\ShoppingEvent.hx"
						return this.chargeList;
					}
					
					
					default:
					{
						#line 9 "D:\\project\\sangong\\sangong\\src\\web\\proto\\ShoppingEvent.hx"
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override double __hx_getField_f(string field, int hash, bool throwErrors, bool handleProperties) {
			unchecked {
				#line 9 "D:\\project\\sangong\\sangong\\src\\web\\proto\\ShoppingEvent.hx"
				switch (hash) {
					case 1269060320:
					{
						#line 9 "D:\\project\\sangong\\sangong\\src\\web\\proto\\ShoppingEvent.hx"
						return this.rate;
					}
					
					
					default:
					{
						#line 9 "D:\\project\\sangong\\sangong\\src\\web\\proto\\ShoppingEvent.hx"
						return base.__hx_getField_f(field, hash, throwErrors, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override void __hx_getFields(global::haxe.root.Array baseArr) {
			#line 9 "D:\\project\\sangong\\sangong\\src\\web\\proto\\ShoppingEvent.hx"
			baseArr.push("hander");
			#line 9 "D:\\project\\sangong\\sangong\\src\\web\\proto\\ShoppingEvent.hx"
			baseArr.push("rate");
			#line 9 "D:\\project\\sangong\\sangong\\src\\web\\proto\\ShoppingEvent.hx"
			baseArr.push("drawOutList");
			#line 9 "D:\\project\\sangong\\sangong\\src\\web\\proto\\ShoppingEvent.hx"
			baseArr.push("buyList");
			#line 9 "D:\\project\\sangong\\sangong\\src\\web\\proto\\ShoppingEvent.hx"
			baseArr.push("chargeList");
			#line 9 "D:\\project\\sangong\\sangong\\src\\web\\proto\\ShoppingEvent.hx"
			base.__hx_getFields(baseArr);
		}
		#line default
		
	}
}


