// Generated by Haxe 4.1.0-rc.1+0d88c583b
using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace openfl.events {
	public class ErrorEvent : global::openfl.events.TextEvent {
		
		static ErrorEvent() {
			#line 40 "D:\\project\\sangong\\sangong\\src\\openfl\\events\\ErrorEvent.hx"
			global::openfl.events.ErrorEvent.ERROR = ((string) ("error") );
		}
		#line default
		
		public ErrorEvent(global::haxe.lang.EmptyObject empty) : base(global::haxe.lang.EmptyObject.EMPTY) {
		}
		
		
		public ErrorEvent(string type, object bubbles, object cancelable, string text, object id) : base(global::haxe.lang.EmptyObject.EMPTY) {
			#line 71 "D:\\project\\sangong\\sangong\\src\\openfl\\events\\ErrorEvent.hx"
			global::openfl.events.ErrorEvent.__hx_ctor_openfl_events_ErrorEvent(this, type, bubbles, cancelable, text, id);
		}
		#line default
		
		protected static void __hx_ctor_openfl_events_ErrorEvent(global::openfl.events.ErrorEvent __hx_this, string type, object bubbles, object cancelable, string text, object id) {
			#line 70 "D:\\project\\sangong\\sangong\\src\\openfl\\events\\ErrorEvent.hx"
			int id1 = ( (( id == default(object) )) ? (0) : (((int) (global::haxe.lang.Runtime.toInt(id)) )) );
			#line 70 "D:\\project\\sangong\\sangong\\src\\openfl\\events\\ErrorEvent.hx"
			if (( text == null )) {
				#line 70 "D:\\project\\sangong\\sangong\\src\\openfl\\events\\ErrorEvent.hx"
				text = "";
			}
			
			#line 70 "D:\\project\\sangong\\sangong\\src\\openfl\\events\\ErrorEvent.hx"
			bool cancelable1 = ( (( cancelable == default(object) )) ? (false) : (global::haxe.lang.Runtime.toBool(cancelable)) );
			#line 70 "D:\\project\\sangong\\sangong\\src\\openfl\\events\\ErrorEvent.hx"
			bool bubbles1 = ( (( bubbles == default(object) )) ? (false) : (global::haxe.lang.Runtime.toBool(bubbles)) );
			global::openfl.events.TextEvent.__hx_ctor_openfl_events_TextEvent(__hx_this, type, bubbles1, cancelable1, text);
			#line 72 "D:\\project\\sangong\\sangong\\src\\openfl\\events\\ErrorEvent.hx"
			__hx_this.errorID = id1;
		}
		#line default
		
		public static string ERROR;
		
		public int errorID;
		
		public override global::openfl.events.Event clone() {
			#line 77 "D:\\project\\sangong\\sangong\\src\\openfl\\events\\ErrorEvent.hx"
			global::openfl.events.ErrorEvent @event = new global::openfl.events.ErrorEvent(this.type, this.bubbles, this.cancelable, this.text, this.errorID);
			@event.target = this.target;
			#line 79 "D:\\project\\sangong\\sangong\\src\\openfl\\events\\ErrorEvent.hx"
			@event.currentTarget = this.currentTarget;
			@event.eventPhase = this.eventPhase;
			#line 81 "D:\\project\\sangong\\sangong\\src\\openfl\\events\\ErrorEvent.hx"
			return @event;
		}
		#line default
		
		public override string toString() {
			#line 86 "D:\\project\\sangong\\sangong\\src\\openfl\\events\\ErrorEvent.hx"
			return this.__formatToString("ErrorEvent", new global::haxe.root.Array(new object[]{"type", "bubbles", "cancelable", "text", "errorID"}));
		}
		#line default
		
		public override double __hx_setField_f(string field, int hash, double @value, bool handleProperties) {
			unchecked {
				#line 26 "D:\\project\\sangong\\sangong\\src\\openfl\\events\\ErrorEvent.hx"
				switch (hash) {
					case 1779076515:
					{
						#line 26 "D:\\project\\sangong\\sangong\\src\\openfl\\events\\ErrorEvent.hx"
						this.errorID = ((int) (@value) );
						#line 26 "D:\\project\\sangong\\sangong\\src\\openfl\\events\\ErrorEvent.hx"
						return @value;
					}
					
					
					default:
					{
						#line 26 "D:\\project\\sangong\\sangong\\src\\openfl\\events\\ErrorEvent.hx"
						return base.__hx_setField_f(field, hash, @value, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_setField(string field, int hash, object @value, bool handleProperties) {
			unchecked {
				#line 26 "D:\\project\\sangong\\sangong\\src\\openfl\\events\\ErrorEvent.hx"
				switch (hash) {
					case 1779076515:
					{
						#line 26 "D:\\project\\sangong\\sangong\\src\\openfl\\events\\ErrorEvent.hx"
						this.errorID = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						#line 26 "D:\\project\\sangong\\sangong\\src\\openfl\\events\\ErrorEvent.hx"
						return @value;
					}
					
					
					default:
					{
						#line 26 "D:\\project\\sangong\\sangong\\src\\openfl\\events\\ErrorEvent.hx"
						return base.__hx_setField(field, hash, @value, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties) {
			unchecked {
				#line 26 "D:\\project\\sangong\\sangong\\src\\openfl\\events\\ErrorEvent.hx"
				switch (hash) {
					case 946786476:
					{
						#line 26 "D:\\project\\sangong\\sangong\\src\\openfl\\events\\ErrorEvent.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "toString", 946786476)) );
					}
					
					
					case 1214452573:
					{
						#line 26 "D:\\project\\sangong\\sangong\\src\\openfl\\events\\ErrorEvent.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "clone", 1214452573)) );
					}
					
					
					case 1779076515:
					{
						#line 26 "D:\\project\\sangong\\sangong\\src\\openfl\\events\\ErrorEvent.hx"
						return this.errorID;
					}
					
					
					default:
					{
						#line 26 "D:\\project\\sangong\\sangong\\src\\openfl\\events\\ErrorEvent.hx"
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override double __hx_getField_f(string field, int hash, bool throwErrors, bool handleProperties) {
			unchecked {
				#line 26 "D:\\project\\sangong\\sangong\\src\\openfl\\events\\ErrorEvent.hx"
				switch (hash) {
					case 1779076515:
					{
						#line 26 "D:\\project\\sangong\\sangong\\src\\openfl\\events\\ErrorEvent.hx"
						return ((double) (this.errorID) );
					}
					
					
					default:
					{
						#line 26 "D:\\project\\sangong\\sangong\\src\\openfl\\events\\ErrorEvent.hx"
						return base.__hx_getField_f(field, hash, throwErrors, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override void __hx_getFields(global::haxe.root.Array baseArr) {
			#line 26 "D:\\project\\sangong\\sangong\\src\\openfl\\events\\ErrorEvent.hx"
			baseArr.push("errorID");
			#line 26 "D:\\project\\sangong\\sangong\\src\\openfl\\events\\ErrorEvent.hx"
			base.__hx_getFields(baseArr);
		}
		#line default
		
	}
}


