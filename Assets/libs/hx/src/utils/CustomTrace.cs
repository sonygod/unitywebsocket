// Generated by Haxe 4.1.0-rc.1+0d88c583b
using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace utils {
	public class CustomTrace : global::haxe.lang.HxObject {
		
		static CustomTrace() {
			global::utils.CustomTrace.print = true;
		}
		
		
		public CustomTrace(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public CustomTrace() {
			global::utils.CustomTrace.__hx_ctor_utils_CustomTrace(this);
		}
		
		
		protected static void __hx_ctor_utils_CustomTrace(global::utils.CustomTrace __hx_this) {
		}
		
		
		public static void start() {
		}
		
		
		public static bool print;
		
		public static void close(bool _close) {
			global::utils.CustomTrace.print = _close;
		}
		
		
		public static void init() {
			global::haxe.lang.Function oldTrace = ((global::haxe.lang.Function) (new global::haxe.lang.Closure(typeof(global::UnityEngine.Debug), "Log", 3804260)) );
			global::haxe.Log.trace = new global::utils.CustomTrace_init_46__Fun(oldTrace);
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace utils {
	public class CustomTrace_init_46__Fun : global::haxe.lang.Function {
		
		public CustomTrace_init_46__Fun(global::haxe.lang.Function oldTrace) : base(2, 0) {
			this.oldTrace = oldTrace;
		}
		
		
		public override object __hx_invoke2_o(double __fn_float1, object __fn_dyn1, double __fn_float2, object __fn_dyn2) {
			object pos = ( (( __fn_dyn2 == global::haxe.lang.Runtime.undefined )) ? (((object) (__fn_float2) )) : (( (( __fn_dyn2 == null )) ? (null) : (((object) (__fn_dyn2) )) )) );
			object v = ( (( __fn_dyn1 == global::haxe.lang.Runtime.undefined )) ? (((object) (__fn_float1) )) : (((object) (__fn_dyn1) )) );
			string tmp = global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("[", new global::haxe.root.Date(((global::System.DateTime) (global::System.DateTime.Now) )).toString()), "] "), global::haxe.root.Std.@string(v)), global::haxe.root.Std.@string(pos));
			this.oldTrace.__hx_invoke1_o(default(double), tmp);
			return null;
		}
		
		
		public global::haxe.lang.Function oldTrace;
		
	}
}


