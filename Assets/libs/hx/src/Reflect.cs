// Generated by Haxe 4.0.2+606b176a3
using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.root {
	public class Reflect : global::haxe.lang.HxObject {
		
		public Reflect(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public Reflect() {
			#line 33 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Reflect.hx"
			global::haxe.root.Reflect.__hx_ctor__Reflect(this);
		}
		#line default
		
		protected static void __hx_ctor__Reflect(global::haxe.root.Reflect __hx_this) {
		}
		
		
		public static bool hasField(object o, string field) {
			#line 35 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Reflect.hx"
			global::haxe.lang.IHxObject ihx = ((global::haxe.lang.IHxObject) (( o as global::haxe.lang.IHxObject )) );
			if (( ihx != null )) {
				#line 37 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Reflect.hx"
				return ( ihx.__hx_getField(field, global::haxe.lang.FieldLookup.hash(field), false, true, false) != global::haxe.lang.Runtime.undefined );
			}
			
			#line 39 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Reflect.hx"
			return global::haxe.lang.Runtime.slowHasField(o, field);
		}
		#line default
		
		public static object field(object o, string field) {
			#line 44 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Reflect.hx"
			global::haxe.lang.IHxObject ihx = ((global::haxe.lang.IHxObject) (( o as global::haxe.lang.IHxObject )) );
			if (( ihx != null )) {
				#line 46 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Reflect.hx"
				return ihx.__hx_getField(field, global::haxe.lang.FieldLookup.hash(field), false, false, false);
			}
			
			#line 48 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Reflect.hx"
			return global::haxe.lang.Runtime.slowGetField(o, field, false);
		}
		#line default
		
		public static void setField(object o, string field, object @value) {
			#line 53 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Reflect.hx"
			global::haxe.lang.IHxObject ihx = ((global::haxe.lang.IHxObject) (( o as global::haxe.lang.IHxObject )) );
			if (( ihx != null )) {
				#line 55 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Reflect.hx"
				ihx.__hx_setField(field, global::haxe.lang.FieldLookup.hash(field), @value, false);
			}
			else {
				#line 57 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Reflect.hx"
				global::haxe.lang.Runtime.slowSetField(o, field, @value);
			}
			
		}
		#line default
		
		public static object getProperty(object o, string field) {
			#line 61 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Reflect.hx"
			global::haxe.lang.IHxObject ihx = ((global::haxe.lang.IHxObject) (( o as global::haxe.lang.IHxObject )) );
			if (( ihx != null )) {
				#line 63 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Reflect.hx"
				return ihx.__hx_getField(field, global::haxe.lang.FieldLookup.hash(field), false, false, true);
			}
			
			#line 65 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Reflect.hx"
			if (global::haxe.lang.Runtime.slowHasField(o, global::haxe.lang.Runtime.concat("get_", field))) {
				#line 66 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Reflect.hx"
				return global::haxe.lang.Runtime.slowCallField(o, global::haxe.lang.Runtime.concat("get_", field), null);
			}
			
			#line 68 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Reflect.hx"
			return global::haxe.lang.Runtime.slowGetField(o, field, false);
		}
		#line default
		
		public static void setProperty(object o, string field, object @value) {
			#line 72 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Reflect.hx"
			global::haxe.lang.IHxObject ihx = ((global::haxe.lang.IHxObject) (( o as global::haxe.lang.IHxObject )) );
			if (( ihx != null )) {
				#line 74 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Reflect.hx"
				ihx.__hx_setField(field, global::haxe.lang.FieldLookup.hash(field), @value, true);
			}
			else if (global::haxe.lang.Runtime.slowHasField(o, global::haxe.lang.Runtime.concat("set_", field))) {
				#line 76 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Reflect.hx"
				global::haxe.lang.Runtime.slowCallField(o, global::haxe.lang.Runtime.concat("set_", field), new object[]{((object) (@value) )});
			}
			else {
				#line 78 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Reflect.hx"
				global::haxe.lang.Runtime.slowSetField(o, field, @value);
			}
			
		}
		#line default
		
		public static object callMethod(object o, object func, global::haxe.root.Array args) {
			#line 82 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Reflect.hx"
			object[] ret = new object[args.length];
			#line 82 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Reflect.hx"
			{
				#line 82 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Reflect.hx"
				int _g = 0;
				#line 82 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Reflect.hx"
				int _g1 = args.length;
				#line 82 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Reflect.hx"
				while (( _g < _g1 )) {
					#line 82 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Reflect.hx"
					int i = _g++;
					#line 82 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Reflect.hx"
					ret[i] = args.__get(i);
				}
				
			}
			
			#line 82 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Reflect.hx"
			object[] args1 = ret;
			return (((global::haxe.lang.Function) (func) )).__hx_invokeDynamic(args1);
		}
		#line default
		
		public static global::haxe.root.Array fields(object o) {
			#line 88 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Reflect.hx"
			global::haxe.lang.IHxObject ihx = ((global::haxe.lang.IHxObject) (( o as global::haxe.lang.IHxObject )) );
			if (( ihx != null )) {
				#line 90 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Reflect.hx"
				global::haxe.root.Array ret = new global::haxe.root.Array(new object[]{});
				ihx.__hx_getFields(ret);
				#line 92 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Reflect.hx"
				return ret;
			}
			else if (( o is global::System.Type )) {
				#line 94 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Reflect.hx"
				return global::haxe.root.Type.getClassFields(((global::System.Type) (o) ));
			}
			else {
				#line 96 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Reflect.hx"
				return global::haxe.root.Reflect.instanceFields(o.GetType());
			}
			
		}
		#line default
		
		public static global::haxe.root.Array instanceFields(global::System.Type c) {
			#line 101 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Reflect.hx"
			global::System.Type c1 = ((global::System.Type) (c) );
			global::haxe.root.Array ret = new global::haxe.root.Array(new object[]{});
			#line 103 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Reflect.hx"
			object initial = global::System.Reflection.BindingFlags.Public;
			#line 103 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Reflect.hx"
			global::System.Reflection.BindingFlags this1 = ( (( initial == default(object) )) ? (default(global::System.Reflection.BindingFlags)) : (((global::System.Reflection.BindingFlags) (initial) )) );
			#line 103 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Reflect.hx"
			object initial1 = ((global::System.Reflection.BindingFlags) (( ((global::System.Reflection.BindingFlags) (this1) ) | ((global::System.Reflection.BindingFlags) (global::System.Reflection.BindingFlags.Instance) ) )) );
			#line 103 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Reflect.hx"
			global::System.Reflection.BindingFlags this2 = ( (( initial1 == default(object) )) ? (default(global::System.Reflection.BindingFlags)) : (((global::System.Reflection.BindingFlags) (initial1) )) );
			#line 103 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Reflect.hx"
			object initial2 = ((global::System.Reflection.BindingFlags) (( ((global::System.Reflection.BindingFlags) (this2) ) | ((global::System.Reflection.BindingFlags) (global::System.Reflection.BindingFlags.FlattenHierarchy) ) )) );
			#line 103 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Reflect.hx"
			global::System.Reflection.BindingFlags this3 = ( (( initial2 == default(object) )) ? (default(global::System.Reflection.BindingFlags)) : (((global::System.Reflection.BindingFlags) (initial2) )) );
			#line 103 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Reflect.hx"
			global::System.Reflection.FieldInfo[] mis = c1.GetFields(((global::System.Reflection.BindingFlags) (this3) ));
			{
				#line 104 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Reflect.hx"
				int _g = 0;
				#line 104 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Reflect.hx"
				int _g1 = ( mis as global::System.Array ).Length;
				#line 104 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Reflect.hx"
				while (( _g < _g1 )) {
					#line 104 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Reflect.hx"
					int i = _g++;
					global::System.Reflection.FieldInfo i1 = ((global::System.Reflection.FieldInfo) (mis[i]) );
					#line 106 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Reflect.hx"
					ret.push(( i1 as global::System.Reflection.MemberInfo ).Name);
				}
				
			}
			
			#line 108 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Reflect.hx"
			return ret;
		}
		#line default
		
		public static bool isFunction(object f) {
			#line 112 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Reflect.hx"
			return ( f is global::haxe.lang.Function );
		}
		#line default
		
		public static int compare(object a, object b) {
			#line 116 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Reflect.hx"
			return global::haxe.lang.Runtime.compare(a, b);
		}
		#line default
		
		public static bool compareMethods(object f1, object f2) {
			#line 121 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Reflect.hx"
			if (global::haxe.lang.Runtime.eq(f1, f2)) {
				#line 122 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Reflect.hx"
				return true;
			}
			
			#line 124 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Reflect.hx"
			if (( ( f1 is global::haxe.lang.Closure ) && ( f2 is global::haxe.lang.Closure ) )) {
				#line 125 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Reflect.hx"
				global::haxe.lang.Closure f1c = ((global::haxe.lang.Closure) (f1) );
				global::haxe.lang.Closure f2c = ((global::haxe.lang.Closure) (f2) );
				#line 128 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Reflect.hx"
				if (global::haxe.lang.Runtime.refEq(f1c.obj, f2c.obj)) {
					#line 128 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Reflect.hx"
					return ( f1c.field == f2c.field );
				}
				else {
					#line 128 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Reflect.hx"
					return false;
				}
				
			}
			
			#line 131 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Reflect.hx"
			return false;
		}
		#line default
		
		public static bool isObject(object v) {
			#line 135 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Reflect.hx"
			if (( v != null )) {
				#line 135 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Reflect.hx"
				return  ! ((( ( ( v is global::haxe.lang.Enum ) || ( v is global::haxe.lang.Function ) ) || ( v is global::System.ValueType ) ))) ;
			}
			else {
				#line 135 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Reflect.hx"
				return false;
			}
			
		}
		#line default
		
		public static bool isEnumValue(object v) {
			#line 139 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Reflect.hx"
			if (( v != null )) {
				#line 139 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Reflect.hx"
				if ( ! (( v is global::haxe.lang.Enum )) ) {
					#line 139 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Reflect.hx"
					return ( v is global::System.Enum );
				}
				else {
					#line 139 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Reflect.hx"
					return true;
				}
				
			}
			else {
				#line 139 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Reflect.hx"
				return false;
			}
			
		}
		#line default
		
		public static bool deleteField(object o, string field) {
			#line 143 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Reflect.hx"
			global::haxe.lang.DynamicObject ihx = ((global::haxe.lang.DynamicObject) (( o as global::haxe.lang.DynamicObject )) );
			if (( ihx != null )) {
				#line 145 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Reflect.hx"
				return ihx.__hx_deleteField(field, global::haxe.lang.FieldLookup.hash(field));
			}
			
			#line 146 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Reflect.hx"
			return false;
		}
		#line default
		
		public static object copy(object o) {
			#line 150 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Reflect.hx"
			if (global::haxe.lang.Runtime.eq(o, null)) {
				#line 151 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Reflect.hx"
				return null;
			}
			
			#line 152 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Reflect.hx"
			object o2 = new global::haxe.lang.DynamicObject(new int[]{}, new object[]{}, new int[]{}, new double[]{});
			{
				#line 153 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Reflect.hx"
				int _g = 0;
				#line 153 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Reflect.hx"
				global::haxe.root.Array _g1 = global::haxe.root.Reflect.fields(o);
				#line 153 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Reflect.hx"
				while (( _g < _g1.length )) {
					#line 153 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Reflect.hx"
					string f = global::haxe.lang.Runtime.toString(_g1.__get(_g));
					#line 153 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Reflect.hx"
					 ++ _g;
					global::haxe.root.Reflect.setField(o2, f, global::haxe.root.Reflect.field(o, f));
				}
				
			}
			
			#line 155 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Reflect.hx"
			return ((object) (o2) );
		}
		#line default
		
		public static object makeVarArgs(global::haxe.lang.Function f) {
			#line 160 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Reflect.hx"
			return new global::haxe.lang.VarArgsFunction(f);
		}
		#line default
		
	}
}


