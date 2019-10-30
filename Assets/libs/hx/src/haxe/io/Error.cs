// Generated by Haxe 4.0.0+ef18b627e

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.io {
	public class Error : global::haxe.lang.Enum {
		
		protected Error(int index) : base(index) {
		}
		
		
		public static readonly global::haxe.io.Error Blocked = new global::haxe.io.Error_Blocked();
		
		public static readonly global::haxe.io.Error Overflow = new global::haxe.io.Error_Overflow();
		
		public static readonly global::haxe.io.Error OutsideBounds = new global::haxe.io.Error_OutsideBounds();
		
		public static global::haxe.io.Error Custom(object e) {
			#line 39 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Error.hx"
			return new global::haxe.io.Error_Custom(e);
		}
		#line default
		
		protected static readonly string[] __hx_constructs = new string[]{"Blocked", "Overflow", "OutsideBounds", "Custom"};
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.io {
	public sealed class Error_Blocked : global::haxe.io.Error {
		
		public Error_Blocked() : base(0) {
		}
		
		
		public override string getTag() {
			#line 30 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Error.hx"
			return "Blocked";
		}
		#line default
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.io {
	public sealed class Error_Overflow : global::haxe.io.Error {
		
		public Error_Overflow() : base(1) {
		}
		
		
		public override string getTag() {
			#line 33 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Error.hx"
			return "Overflow";
		}
		#line default
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.io {
	public sealed class Error_OutsideBounds : global::haxe.io.Error {
		
		public Error_OutsideBounds() : base(2) {
		}
		
		
		public override string getTag() {
			#line 36 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Error.hx"
			return "OutsideBounds";
		}
		#line default
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.io {
	public sealed class Error_Custom : global::haxe.io.Error {
		
		public Error_Custom(object e) : base(3) {
			#line 39 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Error.hx"
			this.e = e;
		}
		#line default
		
		public override global::haxe.root.Array getParams() {
			#line 39 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Error.hx"
			return new global::haxe.root.Array(new object[]{this.e});
		}
		#line default
		
		public override string getTag() {
			#line 39 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Error.hx"
			return "Custom";
		}
		#line default
		
		public override int GetHashCode() {
			unchecked {
				#line 39 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Error.hx"
				return global::haxe.lang.Enum.paramsGetHashCode(3, new object[]{this.e});
			}
			#line default
		}
		
		
		public override bool Equals(object other) {
			#line 39 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Error.hx"
			if (global::System.Object.ReferenceEquals(((object) (this) ), ((object) (other) ))) {
				#line 39 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Error.hx"
				return true;
			}
			
			#line 39 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Error.hx"
			global::haxe.io.Error_Custom en = ( other as global::haxe.io.Error_Custom );
			#line 39 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Error.hx"
			if (( en == null )) {
				#line 39 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Error.hx"
				return false;
			}
			
			#line 39 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Error.hx"
			if ( ! (global::haxe.root.Type.enumEq(((object) (this.e) ), ((object) (en.e) ))) ) {
				#line 39 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Error.hx"
				return false;
			}
			
			#line 39 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Error.hx"
			return true;
		}
		#line default
		
		public override string toString() {
			#line 39 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Error.hx"
			return global::haxe.lang.Enum.paramsToString("Custom", new object[]{this.e});
		}
		#line default
		
		public readonly object e;
		
	}
}


