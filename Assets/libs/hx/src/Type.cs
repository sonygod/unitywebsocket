// Generated by Haxe 4.1.0-rc.1+cd0f0219b

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.root {
	public class ValueType : global::haxe.lang.Enum {
		
		protected ValueType(int index) : base(index) {
		}
		
		
		public static readonly global::haxe.root.ValueType TNull = new global::haxe.root.ValueType_TNull();
		
		public static readonly global::haxe.root.ValueType TInt = new global::haxe.root.ValueType_TInt();
		
		public static readonly global::haxe.root.ValueType TFloat = new global::haxe.root.ValueType_TFloat();
		
		public static readonly global::haxe.root.ValueType TBool = new global::haxe.root.ValueType_TBool();
		
		public static readonly global::haxe.root.ValueType TObject = new global::haxe.root.ValueType_TObject();
		
		public static readonly global::haxe.root.ValueType TFunction = new global::haxe.root.ValueType_TFunction();
		
		public static global::haxe.root.ValueType TClass(global::System.Type c) {
			#line 40 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
			return new global::haxe.root.ValueType_TClass(c);
		}
		#line default
		
		public static global::haxe.root.ValueType TEnum(global::System.Type e) {
			#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
			return new global::haxe.root.ValueType_TEnum(e);
		}
		#line default
		
		public static readonly global::haxe.root.ValueType TUnknown = new global::haxe.root.ValueType_TUnknown();
		
		protected static readonly string[] __hx_constructs = new string[]{"TNull", "TInt", "TFloat", "TBool", "TObject", "TFunction", "TClass", "TEnum", "TUnknown"};
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.root {
	public sealed class ValueType_TNull : global::haxe.root.ValueType {
		
		public ValueType_TNull() : base(0) {
		}
		
		
		public override string getTag() {
			#line 34 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
			return "TNull";
		}
		#line default
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.root {
	public sealed class ValueType_TInt : global::haxe.root.ValueType {
		
		public ValueType_TInt() : base(1) {
		}
		
		
		public override string getTag() {
			#line 35 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
			return "TInt";
		}
		#line default
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.root {
	public sealed class ValueType_TFloat : global::haxe.root.ValueType {
		
		public ValueType_TFloat() : base(2) {
		}
		
		
		public override string getTag() {
			#line 36 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
			return "TFloat";
		}
		#line default
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.root {
	public sealed class ValueType_TBool : global::haxe.root.ValueType {
		
		public ValueType_TBool() : base(3) {
		}
		
		
		public override string getTag() {
			#line 37 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
			return "TBool";
		}
		#line default
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.root {
	public sealed class ValueType_TObject : global::haxe.root.ValueType {
		
		public ValueType_TObject() : base(4) {
		}
		
		
		public override string getTag() {
			#line 38 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
			return "TObject";
		}
		#line default
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.root {
	public sealed class ValueType_TFunction : global::haxe.root.ValueType {
		
		public ValueType_TFunction() : base(5) {
		}
		
		
		public override string getTag() {
			#line 39 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
			return "TFunction";
		}
		#line default
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.root {
	public sealed class ValueType_TClass : global::haxe.root.ValueType {
		
		public ValueType_TClass(global::System.Type c) : base(6) {
			#line 40 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
			this.c = c;
		}
		#line default
		
		public override global::haxe.root.Array getParams() {
			#line 40 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
			return new global::haxe.root.Array(new object[]{this.c});
		}
		#line default
		
		public override string getTag() {
			#line 40 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
			return "TClass";
		}
		#line default
		
		public override int GetHashCode() {
			unchecked {
				#line 40 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				return global::haxe.lang.Enum.paramsGetHashCode(6, new object[]{this.c});
			}
			#line default
		}
		
		
		public override bool Equals(object other) {
			#line 40 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
			if (global::System.Object.ReferenceEquals(((object) (this) ), ((object) (other) ))) {
				#line 40 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				return true;
			}
			
			#line 40 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
			global::haxe.root.ValueType_TClass en = ( other as global::haxe.root.ValueType_TClass );
			#line 40 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
			if (( en == null )) {
				#line 40 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				return false;
			}
			
			#line 40 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
			if ( ! (global::haxe.root.Type.enumEq(((object) (this.c) ), ((object) (en.c) ))) ) {
				#line 40 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				return false;
			}
			
			#line 40 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
			return true;
		}
		#line default
		
		public override string toString() {
			#line 40 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
			return global::haxe.lang.Enum.paramsToString("TClass", new object[]{this.c});
		}
		#line default
		
		public readonly global::System.Type c;
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.root {
	public sealed class ValueType_TEnum : global::haxe.root.ValueType {
		
		public ValueType_TEnum(global::System.Type e) : base(7) {
			#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
			this.e = e;
		}
		#line default
		
		public override global::haxe.root.Array getParams() {
			#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
			return new global::haxe.root.Array(new object[]{this.e});
		}
		#line default
		
		public override string getTag() {
			#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
			return "TEnum";
		}
		#line default
		
		public override int GetHashCode() {
			unchecked {
				#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				return global::haxe.lang.Enum.paramsGetHashCode(7, new object[]{this.e});
			}
			#line default
		}
		
		
		public override bool Equals(object other) {
			#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
			if (global::System.Object.ReferenceEquals(((object) (this) ), ((object) (other) ))) {
				#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				return true;
			}
			
			#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
			global::haxe.root.ValueType_TEnum en = ( other as global::haxe.root.ValueType_TEnum );
			#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
			if (( en == null )) {
				#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				return false;
			}
			
			#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
			if ( ! (global::haxe.root.Type.enumEq(((object) (this.e) ), ((object) (en.e) ))) ) {
				#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				return false;
			}
			
			#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
			return true;
		}
		#line default
		
		public override string toString() {
			#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
			return global::haxe.lang.Enum.paramsToString("TEnum", new object[]{this.e});
		}
		#line default
		
		public readonly global::System.Type e;
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.root {
	public sealed class ValueType_TUnknown : global::haxe.root.ValueType {
		
		public ValueType_TUnknown() : base(8) {
		}
		
		
		public override string getTag() {
			#line 42 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
			return "TUnknown";
		}
		#line default
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.root {
	public class Type : global::haxe.lang.HxObject {
		
		public Type(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public Type() {
			#line 45 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
			global::haxe.root.Type.__hx_ctor__Type(this);
		}
		#line default
		
		protected static void __hx_ctor__Type(global::haxe.root.Type __hx_this) {
		}
		
		
		public static global::System.Type getClass(object o) {
			#line 47 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
			if (( ( global::System.Object.ReferenceEquals(((object) (o) ), default(object)) || ( o is global::haxe.lang.DynamicObject ) ) || ( o is global::System.Type ) )) {
				#line 48 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				return null;
			}
			
			#line 50 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
			return ((global::System.Type) (((object) (o) ).GetType()) );
		}
		#line default
		
		public static global::System.Type getEnum(object o) {
			#line 54 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
			if (( o is global::haxe.lang.Enum )) {
				#line 55 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				return ((global::System.Type) (((object) (o) ).GetType().BaseType) );
			}
			else if (( o is global::System.Enum )) {
				#line 57 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				return ((global::System.Type) (((object) (o) ).GetType()) );
			}
			
			#line 58 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
			return null;
		}
		#line default
		
		public static global::System.Type getSuperClass(global::System.Type c) {
			#line 62 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
			global::System.Type @base = ((global::System.Type) (c) ).BaseType;
			if (( ( global::System.Object.ReferenceEquals(((object) (@base) ), default(object)) || ( ( @base as global::System.Reflection.MemberInfo ).ToString() == "haxe.lang.HxObject" ) ) || ( ( @base as global::System.Reflection.MemberInfo ).ToString() == "System.Object" ) )) {
				#line 64 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				return null;
			}
			
			#line 65 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
			return ((global::System.Type) (@base) );
		}
		#line default
		
		public static string getClassName(global::System.Type c) {
			unchecked {
				#line 69 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				string ret = ( ((global::System.Type) (c) ) as global::System.Reflection.MemberInfo ).ToString();
				#line 71 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				if (( ( ret.Length > 10 ) && ret.StartsWith("haxe.root.") )) {
					#line 72 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
					ret = global::haxe.lang.StringExt.substr(ret, 10, null);
				}
				
				#line 75 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				switch (ret) {
					case "System.Boolean":
					{
						#line 80 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
						return "Bool";
					}
					
					
					case "System.Double":
					{
						#line 78 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
						return "Float";
					}
					
					
					case "System.Int32":
					{
						#line 77 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
						return "Int";
					}
					
					
					case "System.Object":
					{
						#line 81 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
						return "Dynamic";
					}
					
					
					case "System.String":
					{
						#line 79 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
						return "String";
					}
					
					
					case "System.Type":
					{
						#line 82 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
						return "Class";
					}
					
					
					default:
					{
						#line 83 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
						return ((string) ((((global::System.String) (((object) (ret) )) )).Split(((char[]) (new char[]{((char) (96) )}) ))[0]) );
					}
					
				}
				
			}
			#line default
		}
		
		
		public static string getEnumName(global::System.Type e) {
			unchecked {
				#line 88 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				string ret = ( ((global::System.Type) (e) ) as global::System.Reflection.MemberInfo ).ToString();
				#line 90 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				if (( ( ret.Length > 10 ) && ret.StartsWith("haxe.root.") )) {
					#line 91 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
					ret = global::haxe.lang.StringExt.substr(ret, 10, null);
				}
				
				#line 93 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				return ret;
			}
			#line default
		}
		
		
		public static global::System.Type resolveClass(string name) {
			unchecked {
				#line 98 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				if (( global::haxe.lang.StringExt.indexOf(name, ".", null) == -1 )) {
					#line 99 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
					name = global::haxe.lang.Runtime.concat("haxe.root.", name);
				}
				
				#line 101 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				global::System.Type t = global::System.Type.GetType(((string) (name) ));
				#line 103 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				if (global::System.Object.ReferenceEquals(((object) (t) ), default(object))) {
					#line 104 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
					global::System.Collections.IEnumerator all = ( global::System.AppDomain.CurrentDomain.GetAssemblies() as global::System.Array ).GetEnumerator();
					while (all.MoveNext()) {
						#line 106 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
						global::System.Reflection.Assembly t2 = ((global::System.Reflection.Assembly) (all.Current) );
						t = t2.GetType(((string) (name) ));
						#line 108 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
						if ( ! (global::System.Object.ReferenceEquals(((object) (t) ), default(object))) ) {
							#line 109 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
							break;
						}
						
					}
					
				}
				
				#line 113 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				if (global::System.Object.ReferenceEquals(((object) (t) ), default(object))) {
					#line 114 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
					switch (name) {
						case "haxe.root.Bool":
						{
							#line 126 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
							return ((global::System.Type) (typeof(bool)) );
						}
						
						
						case "haxe.root.Class":
						{
							#line 120 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
							return ((global::System.Type) (typeof(global::System.Type)) );
						}
						
						
						case "haxe.root.Dynamic":
						{
							#line 122 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
							return ((global::System.Type) (typeof(object)) );
						}
						
						
						case "haxe.root.Float":
						{
							#line 118 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
							return ((global::System.Type) (typeof(double)) );
						}
						
						
						case "haxe.root.Int":
						{
							#line 116 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
							return ((global::System.Type) (typeof(int)) );
						}
						
						
						case "haxe.root.String":
						{
							#line 124 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
							return ((global::System.Type) (typeof(string)) );
						}
						
						
						default:
						{
							#line 128 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
							return null;
						}
						
					}
					
				}
				else {
					#line 142 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
					return ((global::System.Type) (t) );
				}
				
			}
			#line default
		}
		
		
		public static global::System.Type resolveEnum(string name) {
			#line 147 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
			global::System.Type t = global::haxe.root.Type.resolveClass(name);
			if ((  ! (global::System.Object.ReferenceEquals(((object) (t) ), default(object)))  && (( t.BaseType.Equals(((global::System.Type) (typeof(global::System.Enum)) )) || ((global::System.Type) (typeof(global::haxe.lang.Enum)) ).IsAssignableFrom(((global::System.Type) (t) )) )) )) {
				#line 150 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				return ((global::System.Type) (t) );
			}
			
			#line 151 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
			return null;
		}
		#line default
		
		public static object createInstance(global::System.Type cl, global::haxe.root.Array args) {
			#line 155 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
			if (global::System.Object.ReferenceEquals(((object) (cl) ), ((object) (typeof(string)) ))) {
				#line 156 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				return args.__get(0);
			}
			
			#line 157 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
			global::System.Type t = ((global::System.Type) (cl) );
			if (t.IsInterface) {
				#line 160 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				t = global::haxe.root.Type.resolveClass(global::haxe.root.Type.getClassName(cl));
			}
			
			#line 162 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
			global::System.Reflection.ConstructorInfo[] ctors = t.GetConstructors();
			int tmp = ( ctors as global::System.Array ).Length;
			object[] ret = new object[args.length];
			{
				#line 163 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				int _g = 0;
				#line 163 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				int _g1 = args.length;
				#line 163 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				while (( _g < _g1 )) {
					#line 163 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
					int i = _g++;
					#line 163 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
					ret[i] = args.__get(i);
				}
				
			}
			
			#line 163 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
			return global::haxe.lang.Runtime.callMethod(null, ((global::System.Reflection.MethodBase[]) (ctors) ), tmp, ret);
		}
		#line default
		
		protected static readonly object[] __createEmptyInstance_EMPTY_ARGS = new object[]{((object) (global::haxe.lang.EmptyObject.EMPTY) )};
		
		public static object createEmptyInstance(global::System.Type cl) {
			#line 170 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
			global::System.Type t = ((global::System.Type) (cl) );
			#line 172 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
			if (global::System.Object.ReferenceEquals(((object) (t) ), ((object) (typeof(string)) ))) {
				#line 174 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				return "";
			}
			
			#line 179 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
			object res = default(object);
			#line 179 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
			try {
				#line 179 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				res = global::System.Activator.CreateInstance(((global::System.Type) (t) ), ((object[]) (global::haxe.root.Type.__createEmptyInstance_EMPTY_ARGS) ));
			}
			catch (global::System.MissingMemberException _){
				#line 180 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				global::haxe.lang.Exceptions.exception = _;
				#line 179 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				res = global::System.Activator.CreateInstance(((global::System.Type) (t) ));
			}
			
			
			#line 183 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
			return res;
		}
		#line default
		
		public static object createEnum(global::System.Type e, string constr, global::haxe.root.Array @params) {
			#line 190 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
			if (( ( @params == null ) || ( @params.length == 0 ) )) {
				#line 191 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				object ret = global::haxe.lang.Runtime.slowGetField(e, constr, true);
				if (( ((object) (ret) ) is global::haxe.lang.Function )) {
					#line 193 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
					throw global::haxe.lang.HaxeException.wrap(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("Constructor ", constr), " needs parameters"));
				}
				
				#line 194 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				return ret;
			}
			else {
				#line 196 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				object[] ret1 = new object[@params.length];
				#line 196 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				{
					#line 196 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
					int _g = 0;
					#line 196 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
					int _g1 = @params.length;
					#line 196 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
					while (( _g < _g1 )) {
						#line 196 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
						int i = _g++;
						#line 196 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
						ret1[i] = @params.__get(i);
					}
					
				}
				
				#line 196 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				return global::haxe.lang.Runtime.slowCallField(e, constr, ret1);
			}
			
		}
		#line default
		
		public static object createEnumIndex(global::System.Type e, int index, global::haxe.root.Array @params) {
			#line 201 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
			global::haxe.root.Array constr = global::haxe.root.Type.getEnumConstructs(e);
			return global::haxe.root.Type.createEnum(((global::System.Type) (e) ), global::haxe.lang.Runtime.toString(constr.__get(index)), ((global::haxe.root.Array) (@params) ));
		}
		#line default
		
		public static global::haxe.root.Array getInstanceFields(global::System.Type c) {
			unchecked {
				#line 206 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				if (global::haxe.lang.Runtime.refEq(c, typeof(string))) {
					#line 207 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
					return global::haxe.lang.StringRefl.fields;
				}
				
				#line 209 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				global::System.Type c1 = ((global::System.Type) (c) );
				global::haxe.root.Array ret = new global::haxe.root.Array(new object[]{});
				#line 211 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				object initial = global::System.Reflection.BindingFlags.Public;
				#line 211 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				global::System.Reflection.BindingFlags this1 = ( (( initial == default(object) )) ? (default(global::System.Reflection.BindingFlags)) : (((global::System.Reflection.BindingFlags) (initial) )) );
				#line 211 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				object initial1 = ((global::System.Reflection.BindingFlags) (( ((global::System.Reflection.BindingFlags) (this1) ) | ((global::System.Reflection.BindingFlags) (global::System.Reflection.BindingFlags.Instance) ) )) );
				#line 211 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				global::System.Reflection.BindingFlags this2 = ( (( initial1 == default(object) )) ? (default(global::System.Reflection.BindingFlags)) : (((global::System.Reflection.BindingFlags) (initial1) )) );
				#line 211 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				object initial2 = ((global::System.Reflection.BindingFlags) (( ((global::System.Reflection.BindingFlags) (this2) ) | ((global::System.Reflection.BindingFlags) (global::System.Reflection.BindingFlags.FlattenHierarchy) ) )) );
				#line 211 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				global::System.Reflection.BindingFlags this3 = ( (( initial2 == default(object) )) ? (default(global::System.Reflection.BindingFlags)) : (((global::System.Reflection.BindingFlags) (initial2) )) );
				#line 211 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				global::System.Reflection.MemberInfo[] mis = c1.GetMembers(((global::System.Reflection.BindingFlags) (this3) ));
				{
					#line 212 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
					int _g = 0;
					#line 212 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
					int _g1 = ( mis as global::System.Array ).Length;
					#line 212 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
					while (( _g < _g1 )) {
						#line 212 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
						int i = _g++;
						global::System.Reflection.MemberInfo i1 = ((global::System.Reflection.MemberInfo) (mis[i]) );
						#line 214 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
						if (( i1 is global::System.Reflection.PropertyInfo )) {
							#line 215 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
							continue;
						}
						
						#line 216 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
						string n = i1.Name;
						if ((  ! (n.StartsWith("__hx_"))  && ( (( (((bool) (( ((uint) (0) ) < n.Length )) )) ? (((int) (n[0]) )) : (-1) )) != 46 ) )) {
							#line 218 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
							switch (n) {
								case "Equals":
								case "GetHashCode":
								case "GetType":
								case "ToString":
								{
									#line 219 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
									break;
								}
								
								
								default:
								{
									#line 221 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
									ret.push(n);
									#line 221 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
									break;
								}
								
							}
							
						}
						
					}
					
				}
				
				#line 225 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				return ret;
			}
			#line default
		}
		
		
		public static global::haxe.root.Array getClassFields(global::System.Type c) {
			#line 229 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
			if (global::System.Object.ReferenceEquals(((object) (c) ), ((object) (typeof(string)) ))) {
				#line 230 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				return new global::haxe.root.Array(new object[]{"fromCharCode"});
			}
			
			#line 233 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
			global::haxe.root.Array ret = new global::haxe.root.Array(new object[]{});
			object initial = global::System.Reflection.BindingFlags.Public;
			global::System.Reflection.BindingFlags this1 = ( (( initial == default(object) )) ? (default(global::System.Reflection.BindingFlags)) : (((global::System.Reflection.BindingFlags) (initial) )) );
			object initial1 = ((global::System.Reflection.BindingFlags) (( ((global::System.Reflection.BindingFlags) (this1) ) | ((global::System.Reflection.BindingFlags) (global::System.Reflection.BindingFlags.Static) ) )) );
			global::System.Reflection.BindingFlags this2 = ( (( initial1 == default(object) )) ? (default(global::System.Reflection.BindingFlags)) : (((global::System.Reflection.BindingFlags) (initial1) )) );
			global::System.Reflection.MemberInfo[] infos = ((global::System.Type) (c) ).GetMembers(((global::System.Reflection.BindingFlags) (this2) ));
			#line 235 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
			{
				#line 235 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				int _g = 0;
				#line 235 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				int _g1 = ( infos as global::System.Array ).Length;
				#line 235 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				while (( _g < _g1 )) {
					#line 235 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
					int i = _g++;
					string name = ((global::System.Reflection.MemberInfo) (infos[i]) ).Name;
					#line 237 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
					if ( ! (name.StartsWith("__hx_")) ) {
						#line 238 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
						ret.push(name);
					}
					
				}
				
			}
			
			#line 241 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
			return ret;
		}
		#line default
		
		public static global::haxe.root.Array getEnumConstructs(global::System.Type e) {
			#line 245 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
			global::System.Type t = ((global::System.Type) (( ((object) (e) ) as global::System.Type )) );
			object initial = global::System.Reflection.BindingFlags.Static;
			global::System.Reflection.BindingFlags this1 = ( (( initial == default(object) )) ? (default(global::System.Reflection.BindingFlags)) : (((global::System.Reflection.BindingFlags) (initial) )) );
			object initial1 = ((global::System.Reflection.BindingFlags) (( ((global::System.Reflection.BindingFlags) (this1) ) | ((global::System.Reflection.BindingFlags) (global::System.Reflection.BindingFlags.NonPublic) ) )) );
			global::System.Reflection.BindingFlags this2 = ( (( initial1 == default(object) )) ? (default(global::System.Reflection.BindingFlags)) : (((global::System.Reflection.BindingFlags) (initial1) )) );
			global::System.Reflection.FieldInfo f = t.GetField(((string) ("__hx_constructs") ), ((global::System.Reflection.BindingFlags) (this2) ));
			#line 247 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
			if (( f != null )) {
				#line 248 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				global::System.Array values = ((global::System.Array) (f.GetValue(default(object))) );
				string[] copy = new string[values.Length];
				#line 250 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				global::System.Array.Copy(((global::System.Array) (values) ), ((global::System.Array) (copy) ), ((int) (values.Length) ));
				object[] ret = new object[( copy as global::System.Array ).Length];
				{
					#line 251 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
					int _g = 0;
					#line 251 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
					int _g1 = ( copy as global::System.Array ).Length;
					#line 251 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
					while (( _g < _g1 )) {
						#line 251 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
						int i = _g++;
						#line 251 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
						ret[i] = ((string) (copy[i]) );
					}
					
				}
				
				#line 251 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				object[] dyn = ret;
				#line 251 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				return new global::haxe.root.Array(((object[]) (dyn) ));
			}
			else {
				#line 253 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				string[] native = global::System.Enum.GetNames(((global::System.Type) (t) ));
				#line 253 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				object[] ret1 = new object[( native as global::System.Array ).Length];
				#line 253 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				{
					#line 253 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
					int _g2 = 0;
					#line 253 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
					int _g11 = ( native as global::System.Array ).Length;
					#line 253 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
					while (( _g2 < _g11 )) {
						#line 253 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
						int i1 = _g2++;
						#line 253 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
						ret1[i1] = ((string) (native[i1]) );
					}
					
				}
				
				#line 253 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				object[] dyn1 = ret1;
				#line 253 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				return new global::haxe.root.Array(((object[]) (dyn1) ));
			}
			
		}
		#line default
		
		public static global::haxe.root.ValueType @typeof(object v) {
			#line 257 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
			if (( v == null )) {
				#line 258 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				return global::haxe.root.ValueType.TNull;
			}
			
			#line 260 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
			global::System.Type t = ((global::System.Type) (( v as global::System.Type )) );
			if ( ! (global::System.Object.ReferenceEquals(((object) (t) ), default(object))) ) {
				#line 263 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				return global::haxe.root.ValueType.TObject;
			}
			
			#line 266 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
			t = ((global::System.Type) (v.GetType()) );
			if (t.IsEnum) {
				#line 268 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				return global::haxe.root.ValueType.TEnum(((global::System.Type) (t) ));
			}
			
			#line 269 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
			if (( v is global::haxe.lang.Enum )) {
				#line 270 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				return global::haxe.root.ValueType.TEnum(((global::System.Type) (t.BaseType) ));
			}
			
			#line 271 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
			if (t.IsValueType) {
				#line 272 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				global::System.IConvertible vc = ((global::System.IConvertible) (( ((object) (v) ) as global::System.IConvertible )) );
				if (( vc != null )) {
					#line 274 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
					switch (vc.GetTypeCode()) {
						case global::System.TypeCode.Boolean:
						{
							#line 276 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
							return global::haxe.root.ValueType.TBool;
						}
						
						
						case global::System.TypeCode.Int32:
						{
							#line 284 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
							return global::haxe.root.ValueType.TInt;
						}
						
						
						case global::System.TypeCode.Double:
						{
							#line 278 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
							double d = vc.ToDouble(default(global::System.IFormatProvider));
							if (( ( ( d >= global::System.Int32.MinValue ) && ( d <= global::System.Int32.MaxValue ) ) && ( d == vc.ToInt32(default(global::System.IFormatProvider)) ) )) {
								#line 280 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
								return global::haxe.root.ValueType.TInt;
							}
							else {
								#line 282 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
								return global::haxe.root.ValueType.TFloat;
							}
							
						}
						
						
						default:
						{
							#line 286 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
							return global::haxe.root.ValueType.TClass(((global::System.Type) (t) ));
						}
						
					}
					
				}
				else {
					#line 289 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
					return global::haxe.root.ValueType.TClass(((global::System.Type) (t) ));
				}
				
			}
			
			#line 293 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
			if (( v is global::haxe.lang.IHxObject )) {
				#line 294 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				if (( v is global::haxe.lang.DynamicObject )) {
					#line 295 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
					return global::haxe.root.ValueType.TObject;
				}
				
				#line 296 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				return global::haxe.root.ValueType.TClass(((global::System.Type) (t) ));
			}
			else if (( v is global::haxe.lang.Function )) {
				#line 298 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				return global::haxe.root.ValueType.TFunction;
			}
			else {
				#line 300 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				return global::haxe.root.ValueType.TClass(((global::System.Type) (t) ));
			}
			
		}
		#line default
		
		public static bool enumEq(object a, object b) {
			#line 306 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
			if (global::haxe.lang.Runtime.eq(a, null)) {
				#line 307 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				return global::haxe.lang.Runtime.eq(b, null);
			}
			else if (global::haxe.lang.Runtime.eq(b, null)) {
				#line 309 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				return false;
			}
			else {
				#line 311 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				return a.Equals(b);
			}
			
		}
		#line default
		
		public static string enumConstructor(object e) {
			#line 315 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
			if (( e is global::System.Enum )) {
				#line 315 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				return ( (((global::System.Enum) (e) )) as global::System.ValueType ).ToString();
			}
			else {
				#line 315 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				return (((global::haxe.lang.Enum) (e) )).getTag();
			}
			
		}
		#line default
		
		public static global::haxe.root.Array enumParameters(object e) {
			#line 319 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
			if (( e is global::System.Enum )) {
				#line 319 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				return new global::haxe.root.Array(new object[]{});
			}
			else {
				#line 319 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				return (((global::haxe.lang.Enum) (e) )).getParams();
			}
			
		}
		#line default
		
		public static int enumIndex(object e) {
			#line 325 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
			if (( e is global::System.Enum )) {
				#line 326 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				global::System.Array values = global::System.Enum.GetValues(((global::System.Type) (((object) (e) ).GetType()) ));
				return global::System.Array.IndexOf(((global::System.Array) (values) ), ((object) (e) ));
			}
			else {
				#line 329 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				return (((global::haxe.lang.Enum) (e) ))._hx_index;
			}
			
		}
		#line default
		
		public static global::haxe.root.Array allEnums(global::System.Type e) {
			#line 334 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
			global::haxe.root.Array ctors = global::haxe.root.Type.getEnumConstructs(e);
			global::haxe.root.Array ret = new global::haxe.root.Array(new object[]{});
			#line 336 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
			{
				#line 336 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				int _g = 0;
				#line 336 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				while (( _g < ctors.length )) {
					#line 336 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
					string ctor = global::haxe.lang.Runtime.toString(ctors.__get(_g));
					#line 336 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
					 ++ _g;
					object v = global::haxe.root.Reflect.field(e, ctor);
					#line 338 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
					if (global::haxe.root.Std.isOfType(v, e)) {
						#line 339 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
						ret.push(v);
					}
					
				}
				
			}
			
			#line 342 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
			return ret;
		}
		#line default
		
	}
}


