// Generated by Haxe 4.1.0-rc.1+cd0f0219b
using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe {
	public class MainEvent : global::haxe.lang.HxObject {
		
		public MainEvent(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public MainEvent(global::haxe.lang.Function f, int p) {
			#line 18 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
			global::haxe.MainEvent.__hx_ctor_haxe_MainEvent(this, f, p);
		}
		#line default
		
		protected static void __hx_ctor_haxe_MainEvent(global::haxe.MainEvent __hx_this, global::haxe.lang.Function f, int p) {
			#line 13 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
			__hx_this.isBlocking = true;
			#line 18 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
			{
				#line 19 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
				__hx_this.f = f;
				__hx_this.priority = p;
				#line 21 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
				__hx_this.nextRun = global::haxe.root.Math.NEGATIVE_INFINITY;
			}
			
		}
		#line default
		
		public global::haxe.lang.Function f;
		
		public global::haxe.MainEvent prev;
		
		public global::haxe.MainEvent next;
		
		public bool isBlocking;
		
		public double nextRun;
		
		public int priority;
		
		public virtual void delay(object t) {
			#line 29 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
			this.nextRun = ( (( t == default(object) )) ? (global::haxe.root.Math.NEGATIVE_INFINITY) : (((double) (global::haxe.lang.Runtime.toDouble(global::haxe.lang.Runtime.plus(global::haxe.root.Sys.time(), t))) )) );
		}
		#line default
		
		public void call() {
			#line 36 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
			if (( this.f != null )) {
				#line 37 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
				this.f.__hx_invoke0_o();
			}
			
		}
		#line default
		
		public virtual void stop() {
			#line 44 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
			if (( this.f == null )) {
				#line 45 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
				return;
			}
			
			#line 46 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
			this.f = null;
			this.nextRun = global::haxe.root.Math.NEGATIVE_INFINITY;
			#line 48 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
			if (( this.prev == null )) {
				#line 49 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
				global::haxe.MainLoop.pending = this.next;
			}
			else {
				#line 51 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
				this.prev.next = this.next;
			}
			
			#line 52 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
			if (( this.next != null )) {
				#line 53 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
				this.next.prev = this.prev;
			}
			
		}
		#line default
		
		public override double __hx_setField_f(string field, int hash, double @value, bool handleProperties) {
			unchecked {
				#line 5 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
				switch (hash) {
					case 993950564:
					{
						#line 5 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
						this.priority = ((int) (@value) );
						#line 5 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
						return @value;
					}
					
					
					case 625308696:
					{
						#line 5 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
						this.nextRun = ((double) (@value) );
						#line 5 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
						return @value;
					}
					
					
					default:
					{
						#line 5 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
						return base.__hx_setField_f(field, hash, @value, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_setField(string field, int hash, object @value, bool handleProperties) {
			unchecked {
				#line 5 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
				switch (hash) {
					case 993950564:
					{
						#line 5 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
						this.priority = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						#line 5 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
						return @value;
					}
					
					
					case 625308696:
					{
						#line 5 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
						this.nextRun = ((double) (global::haxe.lang.Runtime.toDouble(@value)) );
						#line 5 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
						return @value;
					}
					
					
					case 341784511:
					{
						#line 5 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
						this.isBlocking = global::haxe.lang.Runtime.toBool(@value);
						#line 5 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
						return @value;
					}
					
					
					case 1224901875:
					{
						#line 5 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
						this.next = ((global::haxe.MainEvent) (@value) );
						#line 5 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
						return @value;
					}
					
					
					case 1247723251:
					{
						#line 5 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
						this.prev = ((global::haxe.MainEvent) (@value) );
						#line 5 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
						return @value;
					}
					
					
					case 102:
					{
						#line 5 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
						this.f = ((global::haxe.lang.Function) (@value) );
						#line 5 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
						return @value;
					}
					
					
					default:
					{
						#line 5 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
						return base.__hx_setField(field, hash, @value, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties) {
			unchecked {
				#line 5 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
				switch (hash) {
					case 1281093634:
					{
						#line 5 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "stop", 1281093634)) );
					}
					
					
					case 1102715038:
					{
						#line 5 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "call", 1102715038)) );
					}
					
					
					case 1462163331:
					{
						#line 5 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "delay", 1462163331)) );
					}
					
					
					case 993950564:
					{
						#line 5 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
						return this.priority;
					}
					
					
					case 625308696:
					{
						#line 5 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
						return this.nextRun;
					}
					
					
					case 341784511:
					{
						#line 5 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
						return this.isBlocking;
					}
					
					
					case 1224901875:
					{
						#line 5 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
						return this.next;
					}
					
					
					case 1247723251:
					{
						#line 5 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
						return this.prev;
					}
					
					
					case 102:
					{
						#line 5 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
						return this.f;
					}
					
					
					default:
					{
						#line 5 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override double __hx_getField_f(string field, int hash, bool throwErrors, bool handleProperties) {
			unchecked {
				#line 5 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
				switch (hash) {
					case 993950564:
					{
						#line 5 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
						return ((double) (this.priority) );
					}
					
					
					case 625308696:
					{
						#line 5 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
						return this.nextRun;
					}
					
					
					default:
					{
						#line 5 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
						return base.__hx_getField_f(field, hash, throwErrors, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_invokeField(string field, int hash, object[] dynargs) {
			unchecked {
				#line 5 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
				switch (hash) {
					case 1281093634:
					{
						#line 5 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
						this.stop();
						#line 5 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
						break;
					}
					
					
					case 1102715038:
					{
						#line 5 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
						this.call();
						#line 5 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
						break;
					}
					
					
					case 1462163331:
					{
						#line 5 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
						this.delay(((object) (dynargs[0]) ));
						#line 5 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
						break;
					}
					
					
					default:
					{
						#line 5 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
				#line 5 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
				return null;
			}
			#line default
		}
		
		
		public override void __hx_getFields(global::haxe.root.Array baseArr) {
			#line 5 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
			baseArr.push("priority");
			#line 5 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
			baseArr.push("nextRun");
			#line 5 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
			baseArr.push("isBlocking");
			#line 5 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
			baseArr.push("next");
			#line 5 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
			baseArr.push("prev");
			#line 5 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
			baseArr.push("f");
			#line 5 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
			base.__hx_getFields(baseArr);
		}
		#line default
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe {
	public class MainLoop : global::haxe.lang.HxObject {
		
		public MainLoop(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public MainLoop() {
			#line 58 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
			global::haxe.MainLoop.__hx_ctor_haxe_MainLoop(this);
		}
		#line default
		
		protected static void __hx_ctor_haxe_MainLoop(global::haxe.MainLoop __hx_this) {
		}
		
		
		public static global::haxe.MainEvent pending;
		
		
		
		public static int get_threadCount() {
			#line 64 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
			return global::haxe.EntryPoint.threadCount;
		}
		#line default
		
		public static bool hasEvents() {
			#line 67 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
			global::haxe.MainEvent p = global::haxe.MainLoop.pending;
			while (( p != null )) {
				#line 69 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
				if (p.isBlocking) {
					#line 70 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
					return true;
				}
				
				#line 71 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
				p = p.next;
			}
			
			#line 73 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
			return false;
		}
		#line default
		
		public static void addThread(global::haxe.lang.Function f) {
			#line 77 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
			global::haxe.EntryPoint.addThread(f);
		}
		#line default
		
		public static void runInMainThread(global::haxe.lang.Function f) {
			#line 81 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
			global::haxe.EntryPoint.runInMainThread(f);
		}
		#line default
		
		public static global::haxe.MainEvent @add(global::haxe.lang.Function f, object priority) {
			#line 87 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
			int priority1 = ( (( priority == default(object) )) ? (0) : (((int) (global::haxe.lang.Runtime.toInt(priority)) )) );
			if (( f == null )) {
				#line 89 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
				throw global::haxe.lang.HaxeException.wrap("Event function is null");
			}
			
			#line 90 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
			global::haxe.MainEvent e = new global::haxe.MainEvent(f, priority1);
			global::haxe.MainEvent head = global::haxe.MainLoop.pending;
			#line 92 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
			if (( head != null )) {
				#line 93 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
				head.prev = e;
			}
			
			#line 94 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
			e.next = head;
			global::haxe.MainLoop.pending = e;
			#line 96 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
			return e;
		}
		#line default
		
		public static void sortEvents() {
			unchecked {
				#line 103 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
				global::haxe.MainEvent list = global::haxe.MainLoop.pending;
				#line 105 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
				if (( list == null )) {
					#line 106 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
					return;
				}
				
				#line 108 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
				int insize = 1;
				#line 108 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
				int nmerges = default(int);
				#line 108 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
				int psize = 0;
				#line 108 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
				int qsize = 0;
				global::haxe.MainEvent p = null;
				global::haxe.MainEvent q = null;
				global::haxe.MainEvent e = null;
				global::haxe.MainEvent tail = null;
				#line 111 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
				while (true) {
					#line 112 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
					p = list;
					list = null;
					#line 114 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
					tail = null;
					nmerges = 0;
					#line 116 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
					while (( p != null )) {
						#line 117 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
						 ++ nmerges;
						q = p;
						#line 119 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
						psize = 0;
						{
							#line 120 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
							int _g = 0;
							#line 120 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
							int _g1 = insize;
							#line 120 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
							while (( _g < _g1 )) {
								#line 120 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
								int i = _g++;
								 ++ psize;
								#line 122 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
								q = q.next;
								if (( q == null )) {
									#line 124 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
									break;
								}
								
							}
							
						}
						
						#line 126 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
						qsize = insize;
						while (( ( psize > 0 ) || ( ( qsize > 0 ) && ( q != null ) ) )) {
							#line 128 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
							if (( psize == 0 )) {
								#line 129 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
								e = q;
								q = q.next;
								#line 131 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
								 -- qsize;
							}
							else if (( ( ( qsize == 0 ) || ( q == null ) ) || (( ( p.priority > q.priority ) || ( ( p.priority == q.priority ) && ( p.nextRun <= q.nextRun ) ) )) )) {
								#line 135 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
								e = p;
								p = p.next;
								#line 137 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
								 -- psize;
							}
							else {
								#line 139 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
								e = q;
								q = q.next;
								#line 141 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
								 -- qsize;
							}
							
							#line 143 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
							if (( tail != null )) {
								#line 144 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
								tail.next = e;
							}
							else {
								#line 146 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
								list = e;
							}
							
							#line 147 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
							e.prev = tail;
							tail = e;
						}
						
						#line 150 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
						p = q;
					}
					
					#line 152 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
					tail.next = null;
					if (( nmerges <= 1 )) {
						#line 154 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
						break;
					}
					
					#line 155 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
					insize *= 2;
				}
				
				#line 157 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
				list.prev = null;
				global::haxe.MainLoop.pending = list;
			}
			#line default
		}
		
		
		public static double tick() {
			#line 165 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
			global::haxe.MainLoop.sortEvents();
			global::haxe.MainEvent e = global::haxe.MainLoop.pending;
			#line 167 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
			double now = global::haxe.root.Sys.time();
			double wait = 1e9;
			#line 169 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
			while (( e != null )) {
				#line 170 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
				global::haxe.MainEvent next = e.next;
				double wt = ( e.nextRun - now );
				#line 172 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
				if (( wt <= 0 )) {
					#line 173 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
					wait = ((double) (0) );
					if (( e.f != null )) {
						#line 174 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
						e.f.__hx_invoke0_o();
					}
					
				}
				else if (( wait > wt )) {
					#line 176 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
					wait = wt;
				}
				
				#line 177 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
				e = next;
			}
			
			#line 179 "C:\\HaxeToolkit\\haxe\\std\\haxe\\MainLoop.hx"
			return wait;
		}
		#line default
		
	}
}


