// Generated by Haxe 4.1.0-rc.1+0d88c583b
using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace openfl.events {
	public class TextEvent : global::openfl.events.Event {
		
		static TextEvent() {
			#line 28 "D:\\project\\sangong\\sangong\\src\\openfl\\events\\TextEvent.hx"
			global::openfl.events.TextEvent.LINK = ((string) ("link") );
			#line 46 "D:\\project\\sangong\\sangong\\src\\openfl\\events\\TextEvent.hx"
			global::openfl.events.TextEvent.TEXT_INPUT = ((string) ("textInput") );
		}
		#line default
		
		public TextEvent(global::haxe.lang.EmptyObject empty) : base(global::haxe.lang.EmptyObject.EMPTY) {
		}
		
		
		public TextEvent(string type, object bubbles, object cancelable, string text) : base(global::haxe.lang.EmptyObject.EMPTY) {
			#line 78 "D:\\project\\sangong\\sangong\\src\\openfl\\events\\TextEvent.hx"
			global::openfl.events.TextEvent.__hx_ctor_openfl_events_TextEvent(this, type, bubbles, cancelable, text);
		}
		#line default
		
		protected static void __hx_ctor_openfl_events_TextEvent(global::openfl.events.TextEvent __hx_this, string type, object bubbles, object cancelable, string text) {
			#line 77 "D:\\project\\sangong\\sangong\\src\\openfl\\events\\TextEvent.hx"
			if (( text == null )) {
				#line 77 "D:\\project\\sangong\\sangong\\src\\openfl\\events\\TextEvent.hx"
				text = "";
			}
			
			#line 77 "D:\\project\\sangong\\sangong\\src\\openfl\\events\\TextEvent.hx"
			bool cancelable1 = ( (( cancelable == default(object) )) ? (false) : (global::haxe.lang.Runtime.toBool(cancelable)) );
			#line 77 "D:\\project\\sangong\\sangong\\src\\openfl\\events\\TextEvent.hx"
			bool bubbles1 = ( (( bubbles == default(object) )) ? (false) : (global::haxe.lang.Runtime.toBool(bubbles)) );
			global::openfl.events.Event.__hx_ctor_openfl_events_Event(__hx_this, type, bubbles1, cancelable1);
			#line 80 "D:\\project\\sangong\\sangong\\src\\openfl\\events\\TextEvent.hx"
			__hx_this.text = text;
		}
		#line default
		
		public static string LINK;
		
		public static string TEXT_INPUT;
		
		public string text;
		
		public override global::openfl.events.Event clone() {
			#line 85 "D:\\project\\sangong\\sangong\\src\\openfl\\events\\TextEvent.hx"
			global::openfl.events.TextEvent @event = new global::openfl.events.TextEvent(this.type, this.bubbles, this.cancelable, this.text);
			@event.target = this.target;
			#line 87 "D:\\project\\sangong\\sangong\\src\\openfl\\events\\TextEvent.hx"
			@event.currentTarget = this.currentTarget;
			@event.eventPhase = this.eventPhase;
			#line 89 "D:\\project\\sangong\\sangong\\src\\openfl\\events\\TextEvent.hx"
			return @event;
		}
		#line default
		
		public override string toString() {
			#line 94 "D:\\project\\sangong\\sangong\\src\\openfl\\events\\TextEvent.hx"
			return this.__formatToString("TextEvent", new global::haxe.root.Array(new object[]{"type", "bubbles", "cancelable", "text"}));
		}
		#line default
		
		public override object __hx_setField(string field, int hash, object @value, bool handleProperties) {
			unchecked {
				#line 14 "D:\\project\\sangong\\sangong\\src\\openfl\\events\\TextEvent.hx"
				switch (hash) {
					case 1291439277:
					{
						#line 14 "D:\\project\\sangong\\sangong\\src\\openfl\\events\\TextEvent.hx"
						this.text = global::haxe.lang.Runtime.toString(@value);
						#line 14 "D:\\project\\sangong\\sangong\\src\\openfl\\events\\TextEvent.hx"
						return @value;
					}
					
					
					default:
					{
						#line 14 "D:\\project\\sangong\\sangong\\src\\openfl\\events\\TextEvent.hx"
						return base.__hx_setField(field, hash, @value, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties) {
			unchecked {
				#line 14 "D:\\project\\sangong\\sangong\\src\\openfl\\events\\TextEvent.hx"
				switch (hash) {
					case 946786476:
					{
						#line 14 "D:\\project\\sangong\\sangong\\src\\openfl\\events\\TextEvent.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "toString", 946786476)) );
					}
					
					
					case 1214452573:
					{
						#line 14 "D:\\project\\sangong\\sangong\\src\\openfl\\events\\TextEvent.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "clone", 1214452573)) );
					}
					
					
					case 1291439277:
					{
						#line 14 "D:\\project\\sangong\\sangong\\src\\openfl\\events\\TextEvent.hx"
						return this.text;
					}
					
					
					default:
					{
						#line 14 "D:\\project\\sangong\\sangong\\src\\openfl\\events\\TextEvent.hx"
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override void __hx_getFields(global::haxe.root.Array baseArr) {
			#line 14 "D:\\project\\sangong\\sangong\\src\\openfl\\events\\TextEvent.hx"
			baseArr.push("text");
			#line 14 "D:\\project\\sangong\\sangong\\src\\openfl\\events\\TextEvent.hx"
			base.__hx_getFields(baseArr);
		}
		#line default
		
	}
}


