// Generated by Haxe 4.0.0+ef18b627e
using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace sys.thread {
	public class Mutex : global::haxe.lang.HxObject {
		
		public Mutex(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public Mutex() {
			#line 30 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Mutex.hx"
			global::sys.thread.Mutex.__hx_ctor_sys_thread_Mutex(this);
		}
		#line default
		
		protected static void __hx_ctor_sys_thread_Mutex(global::sys.thread.Mutex __hx_this) {
			#line 28 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Mutex.hx"
			__hx_this.native = new global::System.Threading.Mutex();
			#line 30 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Mutex.hx"
			{
			}
			
		}
		#line default
		
		public global::System.Threading.Mutex native;
		
		public virtual void acquire() {
			#line 33 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Mutex.hx"
			( this.native as global::System.Threading.WaitHandle ).WaitOne();
		}
		#line default
		
		public virtual bool tryAcquire() {
			#line 37 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Mutex.hx"
			return ( this.native as global::System.Threading.WaitHandle ).WaitOne(((int) (0) ));
		}
		#line default
		
		public virtual void release() {
			#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Mutex.hx"
			this.native.ReleaseMutex();
		}
		#line default
		
		public override object __hx_setField(string field, int hash, object @value, bool handleProperties) {
			unchecked {
				#line 27 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Mutex.hx"
				switch (hash) {
					case 572311959:
					{
						#line 27 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Mutex.hx"
						this.native = ((global::System.Threading.Mutex) (@value) );
						#line 27 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Mutex.hx"
						return @value;
					}
					
					
					default:
					{
						#line 27 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Mutex.hx"
						return base.__hx_setField(field, hash, @value, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties) {
			unchecked {
				#line 27 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Mutex.hx"
				switch (hash) {
					case 1491961287:
					{
						#line 27 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Mutex.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "release", 1491961287)) );
					}
					
					
					case 474773467:
					{
						#line 27 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Mutex.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "tryAcquire", 474773467)) );
					}
					
					
					case 887376854:
					{
						#line 27 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Mutex.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "acquire", 887376854)) );
					}
					
					
					case 572311959:
					{
						#line 27 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Mutex.hx"
						return this.native;
					}
					
					
					default:
					{
						#line 27 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Mutex.hx"
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_invokeField(string field, int hash, object[] dynargs) {
			unchecked {
				#line 27 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Mutex.hx"
				switch (hash) {
					case 1491961287:
					{
						#line 27 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Mutex.hx"
						this.release();
						#line 27 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Mutex.hx"
						break;
					}
					
					
					case 474773467:
					{
						#line 27 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Mutex.hx"
						return this.tryAcquire();
					}
					
					
					case 887376854:
					{
						#line 27 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Mutex.hx"
						this.acquire();
						#line 27 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Mutex.hx"
						break;
					}
					
					
					default:
					{
						#line 27 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Mutex.hx"
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
				#line 27 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Mutex.hx"
				return null;
			}
			#line default
		}
		
		
		public override void __hx_getFields(global::haxe.root.Array baseArr) {
			#line 27 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Mutex.hx"
			baseArr.push("native");
			#line 27 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Mutex.hx"
			base.__hx_getFields(baseArr);
		}
		#line default
		
	}
}


