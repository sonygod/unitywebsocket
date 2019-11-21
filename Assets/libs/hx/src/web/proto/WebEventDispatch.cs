// Generated by Haxe 4.1.0-rc.1+0d88c583b
using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace web.proto {
	public class WebEventDispatch : global::openfl.events.EventDispatcher {
		
		public WebEventDispatch(global::haxe.lang.EmptyObject empty) : base(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) )) {
		}
		
		
		public WebEventDispatch(global::openfl.events.IEventDispatcher target) : base(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) )) {
			global::web.proto.WebEventDispatch.__hx_ctor_web_proto_WebEventDispatch(this, target);
		}
		
		
		protected static void __hx_ctor_web_proto_WebEventDispatch(global::web.proto.WebEventDispatch __hx_this, global::openfl.events.IEventDispatcher target) {
			global::openfl.events.EventDispatcher.__hx_ctor_openfl_events_EventDispatcher(__hx_this, target);
			if (( global::web.proto.WebEventDispatch._instance != null )) {
				throw global::haxe.lang.HaxeException.wrap("webinstance eror!");
			}
			
		}
		
		
		public static global::web.proto.WebEventDispatch _instance;
		
		public static global::web.proto.WebEventDispatch getInstance() {
			if (( global::web.proto.WebEventDispatch._instance == null )) {
				global::web.proto.WebEventDispatch._instance = new global::web.proto.WebEventDispatch(default(global::openfl.events.IEventDispatcher));
			}
			
			return global::web.proto.WebEventDispatch._instance;
		}
		
		
		public virtual void @on(string type, global::haxe.lang.Function listener, object useCapture, object priority, object useWeakReference) {
			bool useWeakReference1 = ( (( useWeakReference == default(object) )) ? (false) : (global::haxe.lang.Runtime.toBool(useWeakReference)) );
			int priority1 = ( (( priority == default(object) )) ? (0) : (((int) (global::haxe.lang.Runtime.toInt(priority)) )) );
			bool useCapture1 = ( (( useCapture == default(object) )) ? (false) : (global::haxe.lang.Runtime.toBool(useCapture)) );
			this.addEventListener(((string) (type) ), ((global::haxe.lang.Function) (listener) ), ((object) (useCapture1) ), ((object) (priority1) ), ((object) (useWeakReference1) ));
		}
		
		
		public virtual void off(string type, global::haxe.lang.Function listener, object useCapture) {
			bool useCapture1 = ( (( useCapture == default(object) )) ? (false) : (global::haxe.lang.Runtime.toBool(useCapture)) );
			this.removeEventListener(((string) (type) ), ((global::haxe.lang.Function) (listener) ), ((object) (useCapture1) ));
		}
		
		
		public override object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties) {
			unchecked {
				switch (hash) {
					case 5542767:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "off", 5542767)) );
					}
					
					
					case 24863:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "on", 24863)) );
					}
					
					
					default:
					{
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override object __hx_invokeField(string field, int hash, object[] dynargs) {
			unchecked {
				switch (hash) {
					case 5542767:
					{
						this.off(global::haxe.lang.Runtime.toString(((object) (dynargs[0]) )), ((global::haxe.lang.Function) (((object) (dynargs[1]) )) ), ((object) (dynargs[2]) ));
						break;
					}
					
					
					case 24863:
					{
						this.@on(global::haxe.lang.Runtime.toString(((object) (dynargs[0]) )), ((global::haxe.lang.Function) (((object) (dynargs[1]) )) ), ((object) (dynargs[2]) ), ((object) (dynargs[3]) ), ((object) (dynargs[4]) ));
						break;
					}
					
					
					default:
					{
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
				return null;
			}
		}
		
		
	}
}


