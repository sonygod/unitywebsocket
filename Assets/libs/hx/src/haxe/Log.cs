// Generated by Haxe 4.0.2+606b176a3
using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe {
	public class Log : global::haxe.lang.HxObject {
		
		static Log() {
			#line 62 "C:\\HaxeToolkit\\haxe\\std\\haxe\\Log.hx"
			global::haxe.Log.trace = ( (( global::haxe.Log_Anon_62__Fun.__hx_current != null )) ? (global::haxe.Log_Anon_62__Fun.__hx_current) : (global::haxe.Log_Anon_62__Fun.__hx_current = ((global::haxe.Log_Anon_62__Fun) (new global::haxe.Log_Anon_62__Fun()) )) );
		}
		#line default
		
		public Log(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public Log() {
			#line 29 "C:\\HaxeToolkit\\haxe\\std\\haxe\\Log.hx"
			global::haxe.Log.__hx_ctor_haxe_Log(this);
		}
		#line default
		
		protected static void __hx_ctor_haxe_Log(global::haxe.Log __hx_this) {
		}
		
		
		public static string formatOutput(object v, object infos) {
			#line 34 "C:\\HaxeToolkit\\haxe\\std\\haxe\\Log.hx"
			string str = global::haxe.root.Std.@string(v);
			if (( infos == null )) {
				#line 36 "C:\\HaxeToolkit\\haxe\\std\\haxe\\Log.hx"
				return str;
			}
			
			#line 37 "C:\\HaxeToolkit\\haxe\\std\\haxe\\Log.hx"
			string pstr = global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.toString(global::haxe.lang.Runtime.getField(infos, "fileName", 1648581351, true)), ":"), global::haxe.lang.Runtime.toString(((int) (global::haxe.lang.Runtime.getField_f(infos, "lineNumber", 1981972957, true)) )));
			if (( ((global::haxe.root.Array) (global::haxe.lang.Runtime.getField(infos, "customParams", 1830310359, true)) ) != null )) {
				#line 39 "C:\\HaxeToolkit\\haxe\\std\\haxe\\Log.hx"
				int _g = 0;
				#line 39 "C:\\HaxeToolkit\\haxe\\std\\haxe\\Log.hx"
				global::haxe.root.Array _g1 = ((global::haxe.root.Array) (global::haxe.lang.Runtime.getField(infos, "customParams", 1830310359, true)) );
				#line 39 "C:\\HaxeToolkit\\haxe\\std\\haxe\\Log.hx"
				while (( _g < _g1.length )) {
					#line 39 "C:\\HaxeToolkit\\haxe\\std\\haxe\\Log.hx"
					object v1 = _g1.__get(_g);
					#line 39 "C:\\HaxeToolkit\\haxe\\std\\haxe\\Log.hx"
					 ++ _g;
					str = global::haxe.lang.Runtime.concat(str, global::haxe.lang.Runtime.concat(", ", global::haxe.root.Std.@string(v1)));
				}
				
			}
			
			#line 41 "C:\\HaxeToolkit\\haxe\\std\\haxe\\Log.hx"
			return global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(pstr, ": "), str);
		}
		#line default
		
		public static global::haxe.lang.Function trace;
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe {
	public class Log_Anon_62__Fun : global::haxe.lang.Function {
		
		public Log_Anon_62__Fun() : base(2, 0) {
		}
		
		
		public static global::haxe.Log_Anon_62__Fun __hx_current;
		
		public override object __hx_invoke2_o(double __fn_float1, object __fn_dyn1, double __fn_float2, object __fn_dyn2) {
			#line 62 "C:\\HaxeToolkit\\haxe\\std\\haxe\\Log.hx"
			object infos = ( (( __fn_dyn2 == global::haxe.lang.Runtime.undefined )) ? (((object) (__fn_float2) )) : (( (( __fn_dyn2 == null )) ? (null) : (((object) (__fn_dyn2) )) )) );
			#line 62 "C:\\HaxeToolkit\\haxe\\std\\haxe\\Log.hx"
			object v = ( (( __fn_dyn1 == global::haxe.lang.Runtime.undefined )) ? (((object) (__fn_float1) )) : (((object) (__fn_dyn1) )) );
			string str = global::haxe.Log.formatOutput(v, infos);
			#line 70 "C:\\HaxeToolkit\\haxe\\std\\haxe\\Log.hx"
			global::System.Console.WriteLine(((object) (str) ));
			#line 62 "C:\\HaxeToolkit\\haxe\\std\\haxe\\Log.hx"
			return null;
		}
		#line default
		
	}
}


