// Generated by Haxe 4.1.0-rc.1+cd0f0219b
using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace web.proto {
	public class WebEventDispatch : global::openfl.events.EventDispatcher {
		
		public WebEventDispatch(global::haxe.lang.EmptyObject empty) : base(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) )) {
		}
		
		
		public WebEventDispatch(global::openfl.events.IEventDispatcher target) : base(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) )) {
			#line 26 "D:\\project\\sangong\\sangong\\src\\web\\proto\\WebEventDispatch.hx"
			global::web.proto.WebEventDispatch.__hx_ctor_web_proto_WebEventDispatch(this, target);
		}
		#line default
		
		protected static void __hx_ctor_web_proto_WebEventDispatch(global::web.proto.WebEventDispatch __hx_this, global::openfl.events.IEventDispatcher target) {
			#line 26 "D:\\project\\sangong\\sangong\\src\\web\\proto\\WebEventDispatch.hx"
			global::openfl.events.EventDispatcher.__hx_ctor_openfl_events_EventDispatcher(__hx_this, target);
			#line 28 "D:\\project\\sangong\\sangong\\src\\web\\proto\\WebEventDispatch.hx"
			if (( global::web.proto.WebEventDispatch._instance != null )) {
				#line 29 "D:\\project\\sangong\\sangong\\src\\web\\proto\\WebEventDispatch.hx"
				throw global::haxe.lang.HaxeException.wrap("webinstance eror!");
			}
			
		}
		#line default
		
		public static global::web.proto.WebEventDispatch _instance;
		
		public static global::web.proto.WebEventDispatch getInstance() {
			#line 18 "D:\\project\\sangong\\sangong\\src\\web\\proto\\WebEventDispatch.hx"
			if (( global::web.proto.WebEventDispatch._instance == null )) {
				#line 19 "D:\\project\\sangong\\sangong\\src\\web\\proto\\WebEventDispatch.hx"
				global::web.proto.WebEventDispatch._instance = new global::web.proto.WebEventDispatch(default(global::openfl.events.IEventDispatcher));
			}
			
			#line 22 "D:\\project\\sangong\\sangong\\src\\web\\proto\\WebEventDispatch.hx"
			return global::web.proto.WebEventDispatch._instance;
		}
		#line default
		
		public virtual void @on(string type, global::haxe.lang.Function listener, object useCapture, object priority, object useWeakReference) {
			#line 35 "D:\\project\\sangong\\sangong\\src\\web\\proto\\WebEventDispatch.hx"
			bool useWeakReference1 = ( (( useWeakReference == default(object) )) ? (false) : (global::haxe.lang.Runtime.toBool(useWeakReference)) );
			#line 35 "D:\\project\\sangong\\sangong\\src\\web\\proto\\WebEventDispatch.hx"
			int priority1 = ( (( priority == default(object) )) ? (0) : (((int) (global::haxe.lang.Runtime.toInt(priority)) )) );
			#line 35 "D:\\project\\sangong\\sangong\\src\\web\\proto\\WebEventDispatch.hx"
			bool useCapture1 = ( (( useCapture == default(object) )) ? (false) : (global::haxe.lang.Runtime.toBool(useCapture)) );
			#line 35 "D:\\project\\sangong\\sangong\\src\\web\\proto\\WebEventDispatch.hx"
			this.addEventListener(((string) (type) ), ((global::haxe.lang.Function) (listener) ), ((object) (useCapture1) ), ((object) (priority1) ), ((object) (useWeakReference1) ));
		}
		#line default
		
		public virtual void off(string type, global::haxe.lang.Function listener, object useCapture) {
			#line 39 "D:\\project\\sangong\\sangong\\src\\web\\proto\\WebEventDispatch.hx"
			bool useCapture1 = ( (( useCapture == default(object) )) ? (false) : (global::haxe.lang.Runtime.toBool(useCapture)) );
			#line 39 "D:\\project\\sangong\\sangong\\src\\web\\proto\\WebEventDispatch.hx"
			this.removeEventListener(((string) (type) ), ((global::haxe.lang.Function) (listener) ), ((object) (useCapture1) ));
		}
		#line default
		
		public override object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties) {
			unchecked {
				#line 14 "D:\\project\\sangong\\sangong\\src\\web\\proto\\WebEventDispatch.hx"
				switch (hash) {
					case 5542767:
					{
						#line 14 "D:\\project\\sangong\\sangong\\src\\web\\proto\\WebEventDispatch.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "off", 5542767)) );
					}
					
					
					case 24863:
					{
						#line 14 "D:\\project\\sangong\\sangong\\src\\web\\proto\\WebEventDispatch.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "on", 24863)) );
					}
					
					
					default:
					{
						#line 14 "D:\\project\\sangong\\sangong\\src\\web\\proto\\WebEventDispatch.hx"
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_invokeField(string field, int hash, object[] dynargs) {
			unchecked {
				#line 14 "D:\\project\\sangong\\sangong\\src\\web\\proto\\WebEventDispatch.hx"
				switch (hash) {
					case 5542767:
					{
						#line 14 "D:\\project\\sangong\\sangong\\src\\web\\proto\\WebEventDispatch.hx"
						this.off(global::haxe.lang.Runtime.toString(((object) (dynargs[0]) )), ((global::haxe.lang.Function) (((object) (dynargs[1]) )) ), ((object) (( (( dynargs.Length > 2 )) ? (((object) (dynargs[2]) )) : (null) )) ));
						#line 14 "D:\\project\\sangong\\sangong\\src\\web\\proto\\WebEventDispatch.hx"
						break;
					}
					
					
					case 24863:
					{
						#line 14 "D:\\project\\sangong\\sangong\\src\\web\\proto\\WebEventDispatch.hx"
						this.@on(global::haxe.lang.Runtime.toString(((object) (dynargs[0]) )), ((global::haxe.lang.Function) (((object) (dynargs[1]) )) ), ((object) (( (( dynargs.Length > 2 )) ? (((object) (dynargs[2]) )) : (null) )) ), ((object) (( (( dynargs.Length > 3 )) ? (((object) (dynargs[3]) )) : (null) )) ), ((object) (( (( dynargs.Length > 4 )) ? (((object) (dynargs[4]) )) : (null) )) ));
						#line 14 "D:\\project\\sangong\\sangong\\src\\web\\proto\\WebEventDispatch.hx"
						break;
					}
					
					
					default:
					{
						#line 14 "D:\\project\\sangong\\sangong\\src\\web\\proto\\WebEventDispatch.hx"
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
				#line 14 "D:\\project\\sangong\\sangong\\src\\web\\proto\\WebEventDispatch.hx"
				return null;
			}
			#line default
		}
		
		
	}
}


