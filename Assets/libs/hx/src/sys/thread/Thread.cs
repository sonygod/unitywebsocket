// Generated by Haxe 4.0.0+ef18b627e

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace sys.thread._Thread {
	public sealed class Thread_Impl_ {
		
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public static global::sys.thread._Thread.HaxeThread _new(global::sys.thread._Thread.HaxeThread thread) {
			#line 30 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Thread.hx"
			global::sys.thread._Thread.HaxeThread this1 = thread;
			#line 30 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Thread.hx"
			return ((global::sys.thread._Thread.HaxeThread) (this1) );
		}
		#line default
		
		public static global::sys.thread._Thread.HaxeThread create(global::haxe.lang.Function cb) {
			#line 35 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Thread.hx"
			global::System.Threading.Thread native = new global::System.Threading.Thread(((global::System.Threading.ThreadStart) (new global::sys.thread._Thread.Thread_Impl__create_35__Fun(cb).Delegate) ));
			native.IsBackground = ((bool) (true) );
			#line 37 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Thread.hx"
			global::sys.thread._Thread.HaxeThread hx = global::sys.thread._Thread.HaxeThread.allocate(native);
			native.Start();
			#line 40 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Thread.hx"
			global::sys.thread._Thread.HaxeThread this1 = hx;
			#line 40 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Thread.hx"
			return ((global::sys.thread._Thread.HaxeThread) (this1) );
		}
		#line default
		
		public static global::sys.thread._Thread.HaxeThread current() {
			#line 44 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Thread.hx"
			global::sys.thread._Thread.HaxeThread this1 = global::sys.thread._Thread.HaxeThread.@get(global::System.Threading.Thread.CurrentThread);
			#line 44 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Thread.hx"
			return ((global::sys.thread._Thread.HaxeThread) (this1) );
		}
		#line default
		
		public static object readMessage(bool block) {
			#line 48 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Thread.hx"
			global::sys.thread._Thread.HaxeThread this1 = global::sys.thread._Thread.HaxeThread.@get(global::System.Threading.Thread.CurrentThread);
			#line 48 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Thread.hx"
			return ((object) (((global::sys.thread._Thread.HaxeThread) (this1) ).messages.pop(block)) );
		}
		#line default
		
		public static void sendMessage(global::sys.thread._Thread.HaxeThread this1, object msg) {
			#line 52 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Thread.hx"
			this1.sendMessage(msg);
		}
		#line default
		
		public static object readMessageImpl(global::sys.thread._Thread.HaxeThread this1, bool block) {
			#line 56 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Thread.hx"
			return ((object) (this1.messages.pop(block)) );
		}
		#line default
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace sys.thread._Thread {
	public class Thread_Impl__create_35__Fun : global::haxe.lang.Function {
		
		public Thread_Impl__create_35__Fun(global::haxe.lang.Function cb) : base(0, 0) {
			#line 35 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Thread.hx"
			this.cb = cb;
		}
		#line default
		
		public override object __hx_invoke0_o() {
			#line 35 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Thread.hx"
			this.Delegate();
			#line 35 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Thread.hx"
			return null;
		}
		#line default
		
		public void Delegate() {
			#line 35 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Thread.hx"
			this.cb.__hx_invoke0_o();
		}
		#line default
		
		public global::haxe.lang.Function cb;
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace sys.thread._Thread {
	public class HaxeThread : global::haxe.lang.HxObject {
		
		static HaxeThread() {
			#line 61 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Thread.hx"
			global::sys.thread._Thread.HaxeThread.threads = new global::haxe.ds.IntMap();
			global::sys.thread._Thread.HaxeThread.allocateCount = 0;
		}
		#line default
		
		public HaxeThread(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public HaxeThread(global::System.Threading.Thread native) {
			#line 101 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Thread.hx"
			global::sys.thread._Thread.HaxeThread.__hx_ctor_sys_thread__Thread_HaxeThread(this, native);
		}
		#line default
		
		protected static void __hx_ctor_sys_thread__Thread_HaxeThread(global::sys.thread._Thread.HaxeThread __hx_this, global::System.Threading.Thread native) {
			#line 66 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Thread.hx"
			__hx_this.messages = new global::sys.thread.Deque();
			#line 102 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Thread.hx"
			{
				#line 102 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Thread.hx"
				__hx_this.native = native;
			}
			
		}
		#line default
		
		public static global::haxe.ds.IntMap threads;
		
		public static int allocateCount;
		
		public static global::sys.thread._Thread.HaxeThread @get(global::System.Threading.Thread native) {
			#line 69 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Thread.hx"
			global::System.Threading.Thread native1 = global::System.Threading.Thread.CurrentThread;
			global::System.WeakReference @ref = null;
			#line 71 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Thread.hx"
			lock(global::sys.thread._Thread.HaxeThread.threads){
				#line 72 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Thread.hx"
				int key = native1.ManagedThreadId;
				@ref = ((global::System.WeakReference) (global::sys.thread._Thread.HaxeThread.threads.@get(((int) (key) ))) );
			}
			;
			#line 75 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Thread.hx"
			if (( ( @ref == null ) ||  ! (@ref.IsAlive)  )) {
				#line 76 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Thread.hx"
				return global::sys.thread._Thread.HaxeThread.allocate(native1);
			}
			
			#line 78 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Thread.hx"
			return ((global::sys.thread._Thread.HaxeThread) (@ref.Target) );
		}
		#line default
		
		public static global::sys.thread._Thread.HaxeThread allocate(global::System.Threading.Thread native) {
			unchecked {
				#line 82 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Thread.hx"
				global::sys.thread._Thread.HaxeThread.allocateCount++;
				#line 92 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Thread.hx"
				global::sys.thread._Thread.HaxeThread hx = new global::sys.thread._Thread.HaxeThread(((global::System.Threading.Thread) (native) ));
				global::System.WeakReference @ref = new global::System.WeakReference(hx);
				#line 94 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Thread.hx"
				lock(global::sys.thread._Thread.HaxeThread.threads){
					#line 95 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Thread.hx"
					if (( ( global::sys.thread._Thread.HaxeThread.allocateCount % 100 ) == 0 )) {
						#line 95 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Thread.hx"
						object _g = ((object) (new global::haxe.iterators.MapKeyValueIterator(((global::haxe.IMap) (global::sys.thread._Thread.HaxeThread.threads) ))) );
						#line 95 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Thread.hx"
						while (true) {
							#line 95 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Thread.hx"
							if ( ! (global::haxe.lang.Runtime.toBool(global::haxe.lang.Runtime.callField(_g, "hasNext", 407283053, null))) ) {
								#line 95 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Thread.hx"
								break;
							}
							
							#line 95 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Thread.hx"
							object _g1 = ((object) (global::haxe.lang.Runtime.callField(_g, "next", 1224901875, null)) );
							#line 95 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Thread.hx"
							int key = ((int) (global::haxe.lang.Runtime.getField_f(_g1, "key", 5343647, true)) );
							#line 95 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Thread.hx"
							global::System.WeakReference ref1 = ((global::System.WeakReference) (global::haxe.lang.Runtime.getField(_g1, "value", 834174833, true)) );
							#line 95 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Thread.hx"
							if ( ! (ref1.IsAlive) ) {
								#line 95 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Thread.hx"
								global::sys.thread._Thread.HaxeThread.threads.@remove(((int) (key) ));
							}
							
						}
						
					}
					
					#line 96 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Thread.hx"
					{
						#line 96 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Thread.hx"
						int key1 = native.ManagedThreadId;
						#line 96 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Thread.hx"
						global::sys.thread._Thread.HaxeThread.threads.@set(((int) (key1) ), ((object) (@ref) ));
					}
					
				}
				;
				#line 98 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Thread.hx"
				return hx;
			}
			#line default
		}
		
		
		public global::System.Threading.Thread native;
		
		public global::sys.thread.Deque messages;
		
		public object readMessage(bool block) {
			#line 106 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Thread.hx"
			return this.messages.pop(block);
		}
		#line default
		
		public virtual void sendMessage(object msg) {
			#line 110 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Thread.hx"
			this.messages.@add(msg);
		}
		#line default
		
		public override object __hx_setField(string field, int hash, object @value, bool handleProperties) {
			unchecked {
				#line 60 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Thread.hx"
				switch (hash) {
					case 889051340:
					{
						#line 60 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Thread.hx"
						this.messages = ((global::sys.thread.Deque) (@value) );
						#line 60 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Thread.hx"
						return @value;
					}
					
					
					case 572311959:
					{
						#line 60 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Thread.hx"
						this.native = ((global::System.Threading.Thread) (@value) );
						#line 60 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Thread.hx"
						return @value;
					}
					
					
					default:
					{
						#line 60 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Thread.hx"
						return base.__hx_setField(field, hash, @value, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties) {
			unchecked {
				#line 60 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Thread.hx"
				switch (hash) {
					case 605915487:
					{
						#line 60 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Thread.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "sendMessage", 605915487)) );
					}
					
					
					case 1828505873:
					{
						#line 60 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Thread.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "readMessage", 1828505873)) );
					}
					
					
					case 889051340:
					{
						#line 60 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Thread.hx"
						return this.messages;
					}
					
					
					case 572311959:
					{
						#line 60 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Thread.hx"
						return this.native;
					}
					
					
					default:
					{
						#line 60 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Thread.hx"
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_invokeField(string field, int hash, object[] dynargs) {
			unchecked {
				#line 60 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Thread.hx"
				switch (hash) {
					case 605915487:
					{
						#line 60 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Thread.hx"
						this.sendMessage(((object) (dynargs[0]) ));
						#line 60 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Thread.hx"
						break;
					}
					
					
					case 1828505873:
					{
						#line 60 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Thread.hx"
						return this.readMessage(global::haxe.lang.Runtime.toBool(((object) (dynargs[0]) )));
					}
					
					
					default:
					{
						#line 60 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Thread.hx"
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
				#line 60 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Thread.hx"
				return null;
			}
			#line default
		}
		
		
		public override void __hx_getFields(global::haxe.root.Array baseArr) {
			#line 60 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Thread.hx"
			baseArr.push("messages");
			#line 60 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Thread.hx"
			baseArr.push("native");
			#line 60 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\thread\\Thread.hx"
			base.__hx_getFields(baseArr);
		}
		#line default
		
	}
}


