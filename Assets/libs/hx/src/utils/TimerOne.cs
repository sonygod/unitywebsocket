// Generated by Haxe 4.1.0-rc.1+cd0f0219b

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace utils {
	public class TimerOne : global::haxe.lang.HxObject {
		
		public TimerOne(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public TimerOne() {
			#line 29 "D:\\project\\sangong\\sangong\\src\\utils\\TimerOne.hx"
			global::utils.TimerOne.__hx_ctor_utils_TimerOne(this);
		}
		#line default
		
		protected static void __hx_ctor_utils_TimerOne(global::utils.TimerOne __hx_this) {
			unchecked {
				#line 19 "D:\\project\\sangong\\sangong\\src\\utils\\TimerOne.hx"
				__hx_this.totoal = ((uint) (0) );
				#line 18 "D:\\project\\sangong\\sangong\\src\\utils\\TimerOne.hx"
				__hx_this.t = 1000;
				#line 17 "D:\\project\\sangong\\sangong\\src\\utils\\TimerOne.hx"
				__hx_this.map = new global::haxe.ds.IntMap();
				#line 29 "D:\\project\\sangong\\sangong\\src\\utils\\TimerOne.hx"
				{
					#line 30 "D:\\project\\sangong\\sangong\\src\\utils\\TimerOne.hx"
					if (( global::utils.TimerOne._instance != null )) {
						#line 31 "D:\\project\\sangong\\sangong\\src\\utils\\TimerOne.hx"
						throw global::haxe.lang.HaxeException.wrap("webinstance eror!");
					}
					
					#line 35 "D:\\project\\sangong\\sangong\\src\\utils\\TimerOne.hx"
					__hx_this.timer = new global::haxe.Timer(((int) (__hx_this.t) ));
					#line 37 "D:\\project\\sangong\\sangong\\src\\utils\\TimerOne.hx"
					__hx_this.timer.run = ((global::haxe.lang.Function) (new global::haxe.lang.Closure(__hx_this, "run", 5695307)) );
				}
				
			}
			#line default
		}
		
		
		public static global::utils.TimerOne _instance;
		
		public static global::utils.TimerOne getInstance() {
			#line 22 "D:\\project\\sangong\\sangong\\src\\utils\\TimerOne.hx"
			if (( global::utils.TimerOne._instance == null )) {
				#line 23 "D:\\project\\sangong\\sangong\\src\\utils\\TimerOne.hx"
				global::utils.TimerOne._instance = new global::utils.TimerOne();
			}
			
			#line 26 "D:\\project\\sangong\\sangong\\src\\utils\\TimerOne.hx"
			return global::utils.TimerOne._instance;
		}
		#line default
		
		public global::haxe.Timer timer;
		
		public global::haxe.ds.IntMap map;
		
		public int t;
		
		public uint totoal;
		
		public virtual void run() {
			#line 43 "D:\\project\\sangong\\sangong\\src\\utils\\TimerOne.hx"
			object _g = ((object) (new global::haxe.iterators.MapKeyValueIterator(((global::haxe.IMap) (((global::haxe.ds.IntMap) (((global::haxe.IMap) (this.map) )) )) ))) );
			#line 43 "D:\\project\\sangong\\sangong\\src\\utils\\TimerOne.hx"
			while (global::haxe.lang.Runtime.toBool(global::haxe.lang.Runtime.callField(_g, "hasNext", 407283053, null))) {
				#line 43 "D:\\project\\sangong\\sangong\\src\\utils\\TimerOne.hx"
				object _g1 = ((object) (global::haxe.lang.Runtime.callField(_g, "next", 1224901875, null)) );
				#line 43 "D:\\project\\sangong\\sangong\\src\\utils\\TimerOne.hx"
				int key = ((int) (global::haxe.lang.Runtime.getField_f(_g1, "key", 5343647, true)) );
				#line 43 "D:\\project\\sangong\\sangong\\src\\utils\\TimerOne.hx"
				object v = global::haxe.lang.Runtime.getField(_g1, "value", 834174833, true);
				if (( v == null )) {
					#line 45 "D:\\project\\sangong\\sangong\\src\\utils\\TimerOne.hx"
					((global::haxe.ds.IntMap) (((global::haxe.IMap) (this.map) )) ).@remove(((int) (key) ));
				}
				else {
					#line 47 "D:\\project\\sangong\\sangong\\src\\utils\\TimerOne.hx"
					{
						#line 47 "D:\\project\\sangong\\sangong\\src\\utils\\TimerOne.hx"
						object __temp_dynop1 = v;
						#line 47 "D:\\project\\sangong\\sangong\\src\\utils\\TimerOne.hx"
						int __temp_expr1 = ((int) (global::haxe.lang.Runtime.setField_f(__temp_dynop1, "dt", 22416, ((double) (( ((int) (global::haxe.lang.Runtime.getField_f(__temp_dynop1, "dt", 22416, true)) ) + this.t )) ))) );
					}
					
					#line 48 "D:\\project\\sangong\\sangong\\src\\utils\\TimerOne.hx"
					if (( ((int) (global::haxe.lang.Runtime.getField_f(v, "dt", 22416, true)) ) >= ((int) (global::haxe.lang.Runtime.getField_f(v, "delay", 1462163331, true)) ) )) {
						#line 49 "D:\\project\\sangong\\sangong\\src\\utils\\TimerOne.hx"
						object __temp_expr2 = ((object) (global::haxe.lang.Runtime.callField(v, "func", 1136978756, null)) );
						if (( ! (global::haxe.lang.Runtime.toBool(global::haxe.lang.Runtime.getField(v, "keep", 1191628933, true))) )) {
							#line 51 "D:\\project\\sangong\\sangong\\src\\utils\\TimerOne.hx"
							((global::haxe.ds.IntMap) (((global::haxe.IMap) (this.map) )) ).@remove(((int) (key) ));
						}
						
						#line 53 "D:\\project\\sangong\\sangong\\src\\utils\\TimerOne.hx"
						int __temp_expr3 = ((int) (global::haxe.lang.Runtime.setField_f(v, "dt", 22416, ((double) (0) ))) );
					}
					
				}
				
			}
			
		}
		#line default
		
		public virtual void reg(global::haxe.lang.Function func, int delay, object keep) {
			unchecked {
				#line 65 "D:\\project\\sangong\\sangong\\src\\utils\\TimerOne.hx"
				bool keep1 = ( (( keep == default(object) )) ? (true) : (global::haxe.lang.Runtime.toBool(keep)) );
				object tc = new global::haxe.lang.DynamicObject(new int[]{1136978756, 1191628933}, new object[]{func, keep1}, new int[]{22416, 1462163331}, new double[]{((double) (0) ), ((double) (delay) )});
				#line 73 "D:\\project\\sangong\\sangong\\src\\utils\\TimerOne.hx"
				((global::haxe.ds.IntMap) (((global::haxe.IMap) (this.map) )) ).@set(((int) (this.totoal++) ), ((object) (tc) ));
				if (((bool) (( this.totoal > 1000000000 )) )) {
					#line 75 "D:\\project\\sangong\\sangong\\src\\utils\\TimerOne.hx"
					this.totoal = ((uint) (1000) );
				}
				
			}
			#line default
		}
		
		
		public virtual void unReg(global::haxe.lang.Function func) {
			#line 80 "D:\\project\\sangong\\sangong\\src\\utils\\TimerOne.hx"
			object _g = ((object) (new global::haxe.iterators.MapKeyValueIterator(((global::haxe.IMap) (((global::haxe.ds.IntMap) (((global::haxe.IMap) (this.map) )) )) ))) );
			#line 80 "D:\\project\\sangong\\sangong\\src\\utils\\TimerOne.hx"
			while (global::haxe.lang.Runtime.toBool(global::haxe.lang.Runtime.callField(_g, "hasNext", 407283053, null))) {
				#line 80 "D:\\project\\sangong\\sangong\\src\\utils\\TimerOne.hx"
				object _g1 = ((object) (global::haxe.lang.Runtime.callField(_g, "next", 1224901875, null)) );
				#line 80 "D:\\project\\sangong\\sangong\\src\\utils\\TimerOne.hx"
				int key = ((int) (global::haxe.lang.Runtime.getField_f(_g1, "key", 5343647, true)) );
				#line 80 "D:\\project\\sangong\\sangong\\src\\utils\\TimerOne.hx"
				object e = global::haxe.lang.Runtime.getField(_g1, "value", 834174833, true);
				if (( ((global::haxe.lang.Function) (global::haxe.lang.Runtime.getField(e, "func", 1136978756, true)) ) == func )) {
					#line 82 "D:\\project\\sangong\\sangong\\src\\utils\\TimerOne.hx"
					((global::haxe.ds.IntMap) (((global::haxe.IMap) (this.map) )) ).@remove(((int) (key) ));
				}
				
			}
			
		}
		#line default
		
		public virtual void delay(global::haxe.lang.Function func, int delay) {
			#line 88 "D:\\project\\sangong\\sangong\\src\\utils\\TimerOne.hx"
			this.reg(func, delay, false);
		}
		#line default
		
		public override double __hx_setField_f(string field, int hash, double @value, bool handleProperties) {
			unchecked {
				#line 13 "D:\\project\\sangong\\sangong\\src\\utils\\TimerOne.hx"
				switch (hash) {
					case 400657953:
					{
						#line 13 "D:\\project\\sangong\\sangong\\src\\utils\\TimerOne.hx"
						this.totoal = ((uint) (@value) );
						#line 13 "D:\\project\\sangong\\sangong\\src\\utils\\TimerOne.hx"
						return @value;
					}
					
					
					case 116:
					{
						#line 13 "D:\\project\\sangong\\sangong\\src\\utils\\TimerOne.hx"
						this.t = ((int) (@value) );
						#line 13 "D:\\project\\sangong\\sangong\\src\\utils\\TimerOne.hx"
						return @value;
					}
					
					
					default:
					{
						#line 13 "D:\\project\\sangong\\sangong\\src\\utils\\TimerOne.hx"
						return base.__hx_setField_f(field, hash, @value, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_setField(string field, int hash, object @value, bool handleProperties) {
			unchecked {
				#line 13 "D:\\project\\sangong\\sangong\\src\\utils\\TimerOne.hx"
				switch (hash) {
					case 400657953:
					{
						#line 13 "D:\\project\\sangong\\sangong\\src\\utils\\TimerOne.hx"
						this.totoal = ((uint) (global::haxe.lang.Runtime.toInt(@value)) );
						#line 13 "D:\\project\\sangong\\sangong\\src\\utils\\TimerOne.hx"
						return @value;
					}
					
					
					case 116:
					{
						#line 13 "D:\\project\\sangong\\sangong\\src\\utils\\TimerOne.hx"
						this.t = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						#line 13 "D:\\project\\sangong\\sangong\\src\\utils\\TimerOne.hx"
						return @value;
					}
					
					
					case 5442204:
					{
						#line 13 "D:\\project\\sangong\\sangong\\src\\utils\\TimerOne.hx"
						this.map = ((global::haxe.ds.IntMap) (@value) );
						#line 13 "D:\\project\\sangong\\sangong\\src\\utils\\TimerOne.hx"
						return @value;
					}
					
					
					case 271957957:
					{
						#line 13 "D:\\project\\sangong\\sangong\\src\\utils\\TimerOne.hx"
						this.timer = ((global::haxe.Timer) (@value) );
						#line 13 "D:\\project\\sangong\\sangong\\src\\utils\\TimerOne.hx"
						return @value;
					}
					
					
					default:
					{
						#line 13 "D:\\project\\sangong\\sangong\\src\\utils\\TimerOne.hx"
						return base.__hx_setField(field, hash, @value, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties) {
			unchecked {
				#line 13 "D:\\project\\sangong\\sangong\\src\\utils\\TimerOne.hx"
				switch (hash) {
					case 1462163331:
					{
						#line 13 "D:\\project\\sangong\\sangong\\src\\utils\\TimerOne.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "delay", 1462163331)) );
					}
					
					
					case 651552891:
					{
						#line 13 "D:\\project\\sangong\\sangong\\src\\utils\\TimerOne.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "unReg", 651552891)) );
					}
					
					
					case 5691732:
					{
						#line 13 "D:\\project\\sangong\\sangong\\src\\utils\\TimerOne.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "reg", 5691732)) );
					}
					
					
					case 5695307:
					{
						#line 13 "D:\\project\\sangong\\sangong\\src\\utils\\TimerOne.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "run", 5695307)) );
					}
					
					
					case 400657953:
					{
						#line 13 "D:\\project\\sangong\\sangong\\src\\utils\\TimerOne.hx"
						return this.totoal;
					}
					
					
					case 116:
					{
						#line 13 "D:\\project\\sangong\\sangong\\src\\utils\\TimerOne.hx"
						return this.t;
					}
					
					
					case 5442204:
					{
						#line 13 "D:\\project\\sangong\\sangong\\src\\utils\\TimerOne.hx"
						return this.map;
					}
					
					
					case 271957957:
					{
						#line 13 "D:\\project\\sangong\\sangong\\src\\utils\\TimerOne.hx"
						return this.timer;
					}
					
					
					default:
					{
						#line 13 "D:\\project\\sangong\\sangong\\src\\utils\\TimerOne.hx"
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override double __hx_getField_f(string field, int hash, bool throwErrors, bool handleProperties) {
			unchecked {
				#line 13 "D:\\project\\sangong\\sangong\\src\\utils\\TimerOne.hx"
				switch (hash) {
					case 400657953:
					{
						#line 13 "D:\\project\\sangong\\sangong\\src\\utils\\TimerOne.hx"
						return ((double) (this.totoal) );
					}
					
					
					case 116:
					{
						#line 13 "D:\\project\\sangong\\sangong\\src\\utils\\TimerOne.hx"
						return ((double) (this.t) );
					}
					
					
					default:
					{
						#line 13 "D:\\project\\sangong\\sangong\\src\\utils\\TimerOne.hx"
						return base.__hx_getField_f(field, hash, throwErrors, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_invokeField(string field, int hash, object[] dynargs) {
			unchecked {
				#line 13 "D:\\project\\sangong\\sangong\\src\\utils\\TimerOne.hx"
				switch (hash) {
					case 1462163331:
					{
						#line 13 "D:\\project\\sangong\\sangong\\src\\utils\\TimerOne.hx"
						this.delay(((global::haxe.lang.Function) (((object) (dynargs[0]) )) ), ((int) (global::haxe.lang.Runtime.toInt(((object) (dynargs[1]) ))) ));
						#line 13 "D:\\project\\sangong\\sangong\\src\\utils\\TimerOne.hx"
						break;
					}
					
					
					case 651552891:
					{
						#line 13 "D:\\project\\sangong\\sangong\\src\\utils\\TimerOne.hx"
						this.unReg(((global::haxe.lang.Function) (((object) (dynargs[0]) )) ));
						#line 13 "D:\\project\\sangong\\sangong\\src\\utils\\TimerOne.hx"
						break;
					}
					
					
					case 5691732:
					{
						#line 13 "D:\\project\\sangong\\sangong\\src\\utils\\TimerOne.hx"
						this.reg(((global::haxe.lang.Function) (((object) (dynargs[0]) )) ), ((int) (global::haxe.lang.Runtime.toInt(((object) (dynargs[1]) ))) ), ( (( dynargs.Length > 2 )) ? (((object) (dynargs[2]) )) : (null) ));
						#line 13 "D:\\project\\sangong\\sangong\\src\\utils\\TimerOne.hx"
						break;
					}
					
					
					case 5695307:
					{
						#line 13 "D:\\project\\sangong\\sangong\\src\\utils\\TimerOne.hx"
						this.run();
						#line 13 "D:\\project\\sangong\\sangong\\src\\utils\\TimerOne.hx"
						break;
					}
					
					
					default:
					{
						#line 13 "D:\\project\\sangong\\sangong\\src\\utils\\TimerOne.hx"
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
				#line 13 "D:\\project\\sangong\\sangong\\src\\utils\\TimerOne.hx"
				return null;
			}
			#line default
		}
		
		
		public override void __hx_getFields(global::haxe.root.Array baseArr) {
			#line 13 "D:\\project\\sangong\\sangong\\src\\utils\\TimerOne.hx"
			baseArr.push("totoal");
			#line 13 "D:\\project\\sangong\\sangong\\src\\utils\\TimerOne.hx"
			baseArr.push("t");
			#line 13 "D:\\project\\sangong\\sangong\\src\\utils\\TimerOne.hx"
			baseArr.push("map");
			#line 13 "D:\\project\\sangong\\sangong\\src\\utils\\TimerOne.hx"
			baseArr.push("timer");
			#line 13 "D:\\project\\sangong\\sangong\\src\\utils\\TimerOne.hx"
			base.__hx_getFields(baseArr);
		}
		#line default
		
	}
}


