// Generated by Haxe 4.1.0-rc.1+0d88c583b
using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe {
	public class Timer : global::haxe.lang.HxObject {
		
		public Timer(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public Timer(int time_ms) {
			#line 60 "C:\\HaxeToolkit\\haxe\\std\\haxe\\Timer.hx"
			global::haxe.Timer.__hx_ctor_haxe_Timer(this, time_ms);
		}
		#line default
		
		protected static void __hx_ctor_haxe_Timer(global::haxe.Timer __hx_this, int time_ms) {
			unchecked {
				#line 128 "C:\\HaxeToolkit\\haxe\\std\\haxe\\Timer.hx"
				__hx_this.run = ( (( global::haxe.Timer___hx_ctor_haxe_Timer_128__Fun.__hx_current != null )) ? (global::haxe.Timer___hx_ctor_haxe_Timer_128__Fun.__hx_current) : (global::haxe.Timer___hx_ctor_haxe_Timer_128__Fun.__hx_current = ((global::haxe.Timer___hx_ctor_haxe_Timer_128__Fun) (new global::haxe.Timer___hx_ctor_haxe_Timer_128__Fun()) )) );
				#line 60 "C:\\HaxeToolkit\\haxe\\std\\haxe\\Timer.hx"
				{
					#line 60 "C:\\HaxeToolkit\\haxe\\std\\haxe\\Timer.hx"
					global::haxe.Timer _gthis = __hx_this;
					#line 73 "C:\\HaxeToolkit\\haxe\\std\\haxe\\Timer.hx"
					double dt = ( ((double) (time_ms) ) / 1000 );
					__hx_this.@event = global::haxe.MainLoop.@add(new global::haxe.Timer___hx_ctor_haxe_Timer_74__Fun(dt, _gthis), null);
					#line 78 "C:\\HaxeToolkit\\haxe\\std\\haxe\\Timer.hx"
					__hx_this.@event.delay(dt);
				}
				
			}
			#line default
		}
		
		
		public static global::haxe.Timer delay(global::haxe.lang.Function f, int time_ms) {
			#line 140 "C:\\HaxeToolkit\\haxe\\std\\haxe\\Timer.hx"
			global::haxe.Timer t = new global::haxe.Timer(((int) (time_ms) ));
			t.run = new global::haxe.Timer_delay_141__Fun(t, f);
			#line 145 "C:\\HaxeToolkit\\haxe\\std\\haxe\\Timer.hx"
			return t;
		}
		#line default
		
		public static object measure(global::haxe.lang.Function f, object pos) {
			#line 160 "C:\\HaxeToolkit\\haxe\\std\\haxe\\Timer.hx"
			double t0 = global::haxe.root.Sys.time();
			object r = ((object) (f.__hx_invoke0_o()) );
			#line 162 "C:\\HaxeToolkit\\haxe\\std\\haxe\\Timer.hx"
			global::haxe.Log.trace.__hx_invoke2_o(default(double), global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.toString(( global::haxe.root.Sys.time() - t0 )), "s"), default(double), pos);
			return r;
		}
		#line default
		
		public static double stamp() {
			#line 184 "C:\\HaxeToolkit\\haxe\\std\\haxe\\Timer.hx"
			return global::haxe.root.Sys.time();
		}
		#line default
		
		public global::haxe.MainEvent @event;
		
		public virtual void stop() {
			#line 107 "C:\\HaxeToolkit\\haxe\\std\\haxe\\Timer.hx"
			if (( this.@event != null )) {
				#line 108 "C:\\HaxeToolkit\\haxe\\std\\haxe\\Timer.hx"
				this.@event.stop();
				this.@event = null;
			}
			
		}
		#line default
		
		public global::haxe.lang.Function run;
		
		public override object __hx_setField(string field, int hash, object @value, bool handleProperties) {
			unchecked {
				#line 39 "C:\\HaxeToolkit\\haxe\\std\\haxe\\Timer.hx"
				switch (hash) {
					case 5695307:
					{
						#line 39 "C:\\HaxeToolkit\\haxe\\std\\haxe\\Timer.hx"
						this.run = ((global::haxe.lang.Function) (@value) );
						#line 39 "C:\\HaxeToolkit\\haxe\\std\\haxe\\Timer.hx"
						return @value;
					}
					
					
					case 1975830554:
					{
						#line 39 "C:\\HaxeToolkit\\haxe\\std\\haxe\\Timer.hx"
						this.@event = ((global::haxe.MainEvent) (@value) );
						#line 39 "C:\\HaxeToolkit\\haxe\\std\\haxe\\Timer.hx"
						return @value;
					}
					
					
					default:
					{
						#line 39 "C:\\HaxeToolkit\\haxe\\std\\haxe\\Timer.hx"
						return base.__hx_setField(field, hash, @value, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties) {
			unchecked {
				#line 39 "C:\\HaxeToolkit\\haxe\\std\\haxe\\Timer.hx"
				switch (hash) {
					case 5695307:
					{
						#line 39 "C:\\HaxeToolkit\\haxe\\std\\haxe\\Timer.hx"
						return this.run;
					}
					
					
					case 1281093634:
					{
						#line 39 "C:\\HaxeToolkit\\haxe\\std\\haxe\\Timer.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "stop", 1281093634)) );
					}
					
					
					case 1975830554:
					{
						#line 39 "C:\\HaxeToolkit\\haxe\\std\\haxe\\Timer.hx"
						return this.@event;
					}
					
					
					default:
					{
						#line 39 "C:\\HaxeToolkit\\haxe\\std\\haxe\\Timer.hx"
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_invokeField(string field, int hash, object[] dynargs) {
			unchecked {
				#line 39 "C:\\HaxeToolkit\\haxe\\std\\haxe\\Timer.hx"
				switch (hash) {
					case 1281093634:
					{
						#line 39 "C:\\HaxeToolkit\\haxe\\std\\haxe\\Timer.hx"
						this.stop();
						#line 39 "C:\\HaxeToolkit\\haxe\\std\\haxe\\Timer.hx"
						break;
					}
					
					
					default:
					{
						#line 39 "C:\\HaxeToolkit\\haxe\\std\\haxe\\Timer.hx"
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
				#line 39 "C:\\HaxeToolkit\\haxe\\std\\haxe\\Timer.hx"
				return null;
			}
			#line default
		}
		
		
		public override void __hx_getFields(global::haxe.root.Array baseArr) {
			#line 39 "C:\\HaxeToolkit\\haxe\\std\\haxe\\Timer.hx"
			baseArr.push("run");
			#line 39 "C:\\HaxeToolkit\\haxe\\std\\haxe\\Timer.hx"
			baseArr.push("event");
			#line 39 "C:\\HaxeToolkit\\haxe\\std\\haxe\\Timer.hx"
			base.__hx_getFields(baseArr);
		}
		#line default
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe {
	public class Timer___hx_ctor_haxe_Timer_128__Fun : global::haxe.lang.Function {
		
		public Timer___hx_ctor_haxe_Timer_128__Fun() : base(0, 0) {
		}
		
		
		public static global::haxe.Timer___hx_ctor_haxe_Timer_128__Fun __hx_current;
		
		public override object __hx_invoke0_o() {
			#line 128 "C:\\HaxeToolkit\\haxe\\std\\haxe\\Timer.hx"
			return null;
		}
		#line default
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe {
	public class Timer___hx_ctor_haxe_Timer_74__Fun : global::haxe.lang.Function {
		
		public Timer___hx_ctor_haxe_Timer_74__Fun(double dt, global::haxe.Timer _gthis) : base(0, 0) {
			#line 74 "C:\\HaxeToolkit\\haxe\\std\\haxe\\Timer.hx"
			this.dt = dt;
			#line 74 "C:\\HaxeToolkit\\haxe\\std\\haxe\\Timer.hx"
			this._gthis = _gthis;
		}
		#line default
		
		public override object __hx_invoke0_o() {
			#line 75 "C:\\HaxeToolkit\\haxe\\std\\haxe\\Timer.hx"
			this._gthis.@event.nextRun += this.dt;
			this._gthis.run.__hx_invoke0_o();
			#line 74 "C:\\HaxeToolkit\\haxe\\std\\haxe\\Timer.hx"
			return null;
		}
		#line default
		
		public double dt;
		
		public global::haxe.Timer _gthis;
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe {
	public class Timer_delay_141__Fun : global::haxe.lang.Function {
		
		public Timer_delay_141__Fun(global::haxe.Timer t, global::haxe.lang.Function f) : base(0, 0) {
			#line 141 "C:\\HaxeToolkit\\haxe\\std\\haxe\\Timer.hx"
			this.t = t;
			#line 141 "C:\\HaxeToolkit\\haxe\\std\\haxe\\Timer.hx"
			this.f = f;
		}
		#line default
		
		public override object __hx_invoke0_o() {
			#line 142 "C:\\HaxeToolkit\\haxe\\std\\haxe\\Timer.hx"
			this.t.stop();
			this.f.__hx_invoke0_o();
			#line 141 "C:\\HaxeToolkit\\haxe\\std\\haxe\\Timer.hx"
			return null;
		}
		#line default
		
		public global::haxe.Timer t;
		
		public global::haxe.lang.Function f;
		
	}
}


