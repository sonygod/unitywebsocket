// Generated by Haxe 4.1.0-rc.1+0d88c583b
using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace web.proto {
	public class ErrorEventCS : global::openfl.events.ErrorEvent {
		
		static ErrorEventCS() {
			#line 15 "D:\\project\\sangong\\sangong\\src\\web\\proto\\ErrorEventCS.hx"
			global::web.proto.ErrorEventCS.ERROR = ((string) ("error") );
		}
		#line default
		
		public ErrorEventCS(global::haxe.lang.EmptyObject empty) : base(global::haxe.lang.EmptyObject.EMPTY) {
		}
		
		
		public ErrorEventCS(string type, string text, object playerID, object bubbles, object cancelable, object id) : base(global::haxe.lang.EmptyObject.EMPTY) {
			#line 22 "D:\\project\\sangong\\sangong\\src\\web\\proto\\ErrorEventCS.hx"
			global::web.proto.ErrorEventCS.__hx_ctor_web_proto_ErrorEventCS(this, type, text, playerID, bubbles, cancelable, id);
		}
		#line default
		
		protected static void __hx_ctor_web_proto_ErrorEventCS(global::web.proto.ErrorEventCS __hx_this, string type, string text, object playerID, object bubbles, object cancelable, object id) {
			unchecked {
				#line 21 "D:\\project\\sangong\\sangong\\src\\web\\proto\\ErrorEventCS.hx"
				int id1 = ( (( id == default(object) )) ? (0) : (((int) (global::haxe.lang.Runtime.toInt(id)) )) );
				#line 21 "D:\\project\\sangong\\sangong\\src\\web\\proto\\ErrorEventCS.hx"
				bool cancelable1 = ( (( cancelable == default(object) )) ? (false) : (global::haxe.lang.Runtime.toBool(cancelable)) );
				#line 21 "D:\\project\\sangong\\sangong\\src\\web\\proto\\ErrorEventCS.hx"
				bool bubbles1 = ( (( bubbles == default(object) )) ? (false) : (global::haxe.lang.Runtime.toBool(bubbles)) );
				#line 21 "D:\\project\\sangong\\sangong\\src\\web\\proto\\ErrorEventCS.hx"
				int playerID1 = ( (( playerID == default(object) )) ? (-1) : (((int) (global::haxe.lang.Runtime.toInt(playerID)) )) );
				#line 21 "D:\\project\\sangong\\sangong\\src\\web\\proto\\ErrorEventCS.hx"
				if (( text == null )) {
					#line 21 "D:\\project\\sangong\\sangong\\src\\web\\proto\\ErrorEventCS.hx"
					text = "";
				}
				
				#line 22 "D:\\project\\sangong\\sangong\\src\\web\\proto\\ErrorEventCS.hx"
				global::openfl.events.ErrorEvent.__hx_ctor_openfl_events_ErrorEvent(__hx_this, type, bubbles1, cancelable1, text, id1);
				__hx_this.playerID = playerID1;
			}
			#line default
		}
		
		
		public static new string ERROR;
		
		public int playerID;
		
		public override double __hx_setField_f(string field, int hash, double @value, bool handleProperties) {
			unchecked {
				#line 13 "D:\\project\\sangong\\sangong\\src\\web\\proto\\ErrorEventCS.hx"
				switch (hash) {
					case 1213433212:
					{
						#line 13 "D:\\project\\sangong\\sangong\\src\\web\\proto\\ErrorEventCS.hx"
						this.playerID = ((int) (@value) );
						#line 13 "D:\\project\\sangong\\sangong\\src\\web\\proto\\ErrorEventCS.hx"
						return @value;
					}
					
					
					default:
					{
						#line 13 "D:\\project\\sangong\\sangong\\src\\web\\proto\\ErrorEventCS.hx"
						return base.__hx_setField_f(field, hash, @value, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_setField(string field, int hash, object @value, bool handleProperties) {
			unchecked {
				#line 13 "D:\\project\\sangong\\sangong\\src\\web\\proto\\ErrorEventCS.hx"
				switch (hash) {
					case 1213433212:
					{
						#line 13 "D:\\project\\sangong\\sangong\\src\\web\\proto\\ErrorEventCS.hx"
						this.playerID = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						#line 13 "D:\\project\\sangong\\sangong\\src\\web\\proto\\ErrorEventCS.hx"
						return @value;
					}
					
					
					default:
					{
						#line 13 "D:\\project\\sangong\\sangong\\src\\web\\proto\\ErrorEventCS.hx"
						return base.__hx_setField(field, hash, @value, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties) {
			unchecked {
				#line 13 "D:\\project\\sangong\\sangong\\src\\web\\proto\\ErrorEventCS.hx"
				switch (hash) {
					case 1213433212:
					{
						#line 13 "D:\\project\\sangong\\sangong\\src\\web\\proto\\ErrorEventCS.hx"
						return this.playerID;
					}
					
					
					default:
					{
						#line 13 "D:\\project\\sangong\\sangong\\src\\web\\proto\\ErrorEventCS.hx"
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override double __hx_getField_f(string field, int hash, bool throwErrors, bool handleProperties) {
			unchecked {
				#line 13 "D:\\project\\sangong\\sangong\\src\\web\\proto\\ErrorEventCS.hx"
				switch (hash) {
					case 1213433212:
					{
						#line 13 "D:\\project\\sangong\\sangong\\src\\web\\proto\\ErrorEventCS.hx"
						return ((double) (this.playerID) );
					}
					
					
					default:
					{
						#line 13 "D:\\project\\sangong\\sangong\\src\\web\\proto\\ErrorEventCS.hx"
						return base.__hx_getField_f(field, hash, throwErrors, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override void __hx_getFields(global::haxe.root.Array baseArr) {
			#line 13 "D:\\project\\sangong\\sangong\\src\\web\\proto\\ErrorEventCS.hx"
			baseArr.push("playerID");
			#line 13 "D:\\project\\sangong\\sangong\\src\\web\\proto\\ErrorEventCS.hx"
			base.__hx_getFields(baseArr);
		}
		#line default
		
	}
}


