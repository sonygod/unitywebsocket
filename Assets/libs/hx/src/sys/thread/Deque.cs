// Generated by Haxe 4.0.0+ef18b627e
using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace sys.thread {
	public class Deque : global::haxe.lang.HxObject {
		
		public Deque(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public Deque() {
			#line 33 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Deque.hx"
			global::sys.thread.Deque.__hx_ctor_sys_thread_Deque(((global::sys.thread.Deque) (this) ));
		}
		#line default
		
		protected static void __hx_ctor_sys_thread_Deque(global::sys.thread.Deque __hx_this) {
			#line 31 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Deque.hx"
			__hx_this.addEvent = new global::System.Threading.ManualResetEvent(false);
			#line 30 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Deque.hx"
			__hx_this.lockObj = new global::haxe.lang.DynamicObject(new int[]{}, new object[]{}, new int[]{}, new double[]{});
			#line 29 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Deque.hx"
			__hx_this.storage = new global::haxe.root.Array(new object[]{});
			#line 33 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Deque.hx"
			{
			}
			
		}
		#line default
		
		public global::haxe.root.Array storage;
		
		public object lockObj;
		
		public global::System.Threading.ManualResetEvent addEvent;
		
		public virtual void @add(object i) {
			#line 36 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Deque.hx"
			lock(this.lockObj){
				#line 37 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Deque.hx"
				this.storage.push(i);
				( this.addEvent as global::System.Threading.EventWaitHandle ).Set();
			}
			;
		}
		#line default
		
		public virtual void push(object i) {
			#line 43 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Deque.hx"
			lock(this.lockObj){
				#line 44 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Deque.hx"
				this.storage.unshift(i);
				( this.addEvent as global::System.Threading.EventWaitHandle ).Set();
			}
			;
		}
		#line default
		
		public virtual object pop(bool block) {
			#line 50 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Deque.hx"
			while (true) {
				#line 51 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Deque.hx"
				lock(this.lockObj){
					#line 52 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Deque.hx"
					if (( this.storage.length > 0 )) {
						#line 53 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Deque.hx"
						return this.storage.shift();
					}
					
					#line 55 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Deque.hx"
					( this.addEvent as global::System.Threading.EventWaitHandle ).Reset();
				}
				;
				#line 50 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Deque.hx"
				if ( ! ((( block && ( this.addEvent as global::System.Threading.WaitHandle ).WaitOne() ))) ) {
					#line 50 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Deque.hx"
					break;
				}
				
			}
			
			#line 58 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Deque.hx"
			return null;
		}
		#line default
		
		public override double __hx_setField_f(string field, int hash, double @value, bool handleProperties) {
			unchecked {
				#line 28 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Deque.hx"
				switch (hash) {
					case 877441228:
					{
						#line 28 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Deque.hx"
						this.lockObj = ((object) (@value) );
						#line 28 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Deque.hx"
						return @value;
					}
					
					
					default:
					{
						#line 28 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Deque.hx"
						return base.__hx_setField_f(field, hash, @value, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_setField(string field, int hash, object @value, bool handleProperties) {
			unchecked {
				#line 28 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Deque.hx"
				switch (hash) {
					case 1864494649:
					{
						#line 28 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Deque.hx"
						this.addEvent = ((global::System.Threading.ManualResetEvent) (@value) );
						#line 28 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Deque.hx"
						return @value;
					}
					
					
					case 877441228:
					{
						#line 28 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Deque.hx"
						this.lockObj = ((object) (@value) );
						#line 28 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Deque.hx"
						return @value;
					}
					
					
					case 1151917883:
					{
						#line 28 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Deque.hx"
						this.storage = ((global::haxe.root.Array) (@value) );
						#line 28 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Deque.hx"
						return @value;
					}
					
					
					default:
					{
						#line 28 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Deque.hx"
						return base.__hx_setField(field, hash, @value, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties) {
			unchecked {
				#line 28 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Deque.hx"
				switch (hash) {
					case 5594513:
					{
						#line 28 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Deque.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "pop", 5594513)) );
					}
					
					
					case 1247875546:
					{
						#line 28 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Deque.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "push", 1247875546)) );
					}
					
					
					case 4846113:
					{
						#line 28 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Deque.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "add", 4846113)) );
					}
					
					
					case 1864494649:
					{
						#line 28 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Deque.hx"
						return this.addEvent;
					}
					
					
					case 877441228:
					{
						#line 28 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Deque.hx"
						return this.lockObj;
					}
					
					
					case 1151917883:
					{
						#line 28 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Deque.hx"
						return this.storage;
					}
					
					
					default:
					{
						#line 28 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Deque.hx"
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override double __hx_getField_f(string field, int hash, bool throwErrors, bool handleProperties) {
			unchecked {
				#line 28 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Deque.hx"
				switch (hash) {
					case 877441228:
					{
						#line 28 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Deque.hx"
						return ((double) (global::haxe.lang.Runtime.toDouble(this.lockObj)) );
					}
					
					
					default:
					{
						#line 28 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Deque.hx"
						return base.__hx_getField_f(field, hash, throwErrors, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_invokeField(string field, int hash, object[] dynargs) {
			unchecked {
				#line 28 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Deque.hx"
				switch (hash) {
					case 5594513:
					{
						#line 28 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Deque.hx"
						return this.pop(global::haxe.lang.Runtime.toBool(((object) (dynargs[0]) )));
					}
					
					
					case 1247875546:
					{
						#line 28 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Deque.hx"
						this.push(((object) (dynargs[0]) ));
						#line 28 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Deque.hx"
						break;
					}
					
					
					case 4846113:
					{
						#line 28 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Deque.hx"
						this.@add(((object) (dynargs[0]) ));
						#line 28 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Deque.hx"
						break;
					}
					
					
					default:
					{
						#line 28 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Deque.hx"
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
				#line 28 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Deque.hx"
				return null;
			}
			#line default
		}
		
		
		public override void __hx_getFields(global::haxe.root.Array baseArr) {
			#line 28 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Deque.hx"
			baseArr.push("addEvent");
			#line 28 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Deque.hx"
			baseArr.push("lockObj");
			#line 28 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Deque.hx"
			baseArr.push("storage");
			#line 28 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Deque.hx"
			base.__hx_getFields(baseArr);
		}
		#line default
		
	}
}


