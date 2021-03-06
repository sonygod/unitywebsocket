// Generated by Haxe 4.1.0-rc.1+0d88c583b

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.macro {
	public class Message : global::haxe.lang.Enum {
		
		protected Message(int index) : base(index) {
		}
		
		
		public static global::haxe.macro.Message Info(string msg, object pos) {
			#line 29 "C:\\HaxeToolkit\\haxe\\std\\haxe\\macro\\Context.hx"
			return new global::haxe.macro.Message_Info(msg, pos);
		}
		#line default
		
		public static global::haxe.macro.Message Warning(string msg, object pos) {
			#line 30 "C:\\HaxeToolkit\\haxe\\std\\haxe\\macro\\Context.hx"
			return new global::haxe.macro.Message_Warning(msg, pos);
		}
		#line default
		
		protected static readonly string[] __hx_constructs = new string[]{"Info", "Warning"};
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.macro {
	public sealed class Message_Info : global::haxe.macro.Message {
		
		public Message_Info(string msg, object pos) : base(0) {
			#line 29 "C:\\HaxeToolkit\\haxe\\std\\haxe\\macro\\Context.hx"
			this.msg = msg;
			#line 29 "C:\\HaxeToolkit\\haxe\\std\\haxe\\macro\\Context.hx"
			this.pos = pos;
		}
		#line default
		
		public override global::haxe.root.Array getParams() {
			#line 29 "C:\\HaxeToolkit\\haxe\\std\\haxe\\macro\\Context.hx"
			return new global::haxe.root.Array(new object[]{this.msg, this.pos});
		}
		#line default
		
		public override string getTag() {
			#line 29 "C:\\HaxeToolkit\\haxe\\std\\haxe\\macro\\Context.hx"
			return "Info";
		}
		#line default
		
		public override int GetHashCode() {
			#line 29 "C:\\HaxeToolkit\\haxe\\std\\haxe\\macro\\Context.hx"
			return global::haxe.lang.Enum.paramsGetHashCode(0, new object[]{this.msg, this.pos});
		}
		#line default
		
		public override bool Equals(object other) {
			#line 29 "C:\\HaxeToolkit\\haxe\\std\\haxe\\macro\\Context.hx"
			if (global::System.Object.ReferenceEquals(((object) (this) ), ((object) (other) ))) {
				#line 29 "C:\\HaxeToolkit\\haxe\\std\\haxe\\macro\\Context.hx"
				return true;
			}
			
			#line 29 "C:\\HaxeToolkit\\haxe\\std\\haxe\\macro\\Context.hx"
			global::haxe.macro.Message_Info en = ( other as global::haxe.macro.Message_Info );
			#line 29 "C:\\HaxeToolkit\\haxe\\std\\haxe\\macro\\Context.hx"
			if (( en == null )) {
				#line 29 "C:\\HaxeToolkit\\haxe\\std\\haxe\\macro\\Context.hx"
				return false;
			}
			
			#line 29 "C:\\HaxeToolkit\\haxe\\std\\haxe\\macro\\Context.hx"
			if ( ! (global::haxe.root.Type.enumEq(((object) (this.msg) ), ((object) (en.msg) ))) ) {
				#line 29 "C:\\HaxeToolkit\\haxe\\std\\haxe\\macro\\Context.hx"
				return false;
			}
			
			#line 29 "C:\\HaxeToolkit\\haxe\\std\\haxe\\macro\\Context.hx"
			if ( ! (global::haxe.root.Type.enumEq(((object) (this.pos) ), ((object) (en.pos) ))) ) {
				#line 29 "C:\\HaxeToolkit\\haxe\\std\\haxe\\macro\\Context.hx"
				return false;
			}
			
			#line 29 "C:\\HaxeToolkit\\haxe\\std\\haxe\\macro\\Context.hx"
			return true;
		}
		#line default
		
		public override string toString() {
			#line 29 "C:\\HaxeToolkit\\haxe\\std\\haxe\\macro\\Context.hx"
			return global::haxe.lang.Enum.paramsToString("Info", new object[]{this.msg, this.pos});
		}
		#line default
		
		public readonly string msg;
		
		public readonly object pos;
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.macro {
	public sealed class Message_Warning : global::haxe.macro.Message {
		
		public Message_Warning(string msg, object pos) : base(1) {
			#line 30 "C:\\HaxeToolkit\\haxe\\std\\haxe\\macro\\Context.hx"
			this.msg = msg;
			#line 30 "C:\\HaxeToolkit\\haxe\\std\\haxe\\macro\\Context.hx"
			this.pos = pos;
		}
		#line default
		
		public override global::haxe.root.Array getParams() {
			#line 30 "C:\\HaxeToolkit\\haxe\\std\\haxe\\macro\\Context.hx"
			return new global::haxe.root.Array(new object[]{this.msg, this.pos});
		}
		#line default
		
		public override string getTag() {
			#line 30 "C:\\HaxeToolkit\\haxe\\std\\haxe\\macro\\Context.hx"
			return "Warning";
		}
		#line default
		
		public override int GetHashCode() {
			unchecked {
				#line 30 "C:\\HaxeToolkit\\haxe\\std\\haxe\\macro\\Context.hx"
				return global::haxe.lang.Enum.paramsGetHashCode(1, new object[]{this.msg, this.pos});
			}
			#line default
		}
		
		
		public override bool Equals(object other) {
			#line 30 "C:\\HaxeToolkit\\haxe\\std\\haxe\\macro\\Context.hx"
			if (global::System.Object.ReferenceEquals(((object) (this) ), ((object) (other) ))) {
				#line 30 "C:\\HaxeToolkit\\haxe\\std\\haxe\\macro\\Context.hx"
				return true;
			}
			
			#line 30 "C:\\HaxeToolkit\\haxe\\std\\haxe\\macro\\Context.hx"
			global::haxe.macro.Message_Warning en = ( other as global::haxe.macro.Message_Warning );
			#line 30 "C:\\HaxeToolkit\\haxe\\std\\haxe\\macro\\Context.hx"
			if (( en == null )) {
				#line 30 "C:\\HaxeToolkit\\haxe\\std\\haxe\\macro\\Context.hx"
				return false;
			}
			
			#line 30 "C:\\HaxeToolkit\\haxe\\std\\haxe\\macro\\Context.hx"
			if ( ! (global::haxe.root.Type.enumEq(((object) (this.msg) ), ((object) (en.msg) ))) ) {
				#line 30 "C:\\HaxeToolkit\\haxe\\std\\haxe\\macro\\Context.hx"
				return false;
			}
			
			#line 30 "C:\\HaxeToolkit\\haxe\\std\\haxe\\macro\\Context.hx"
			if ( ! (global::haxe.root.Type.enumEq(((object) (this.pos) ), ((object) (en.pos) ))) ) {
				#line 30 "C:\\HaxeToolkit\\haxe\\std\\haxe\\macro\\Context.hx"
				return false;
			}
			
			#line 30 "C:\\HaxeToolkit\\haxe\\std\\haxe\\macro\\Context.hx"
			return true;
		}
		#line default
		
		public override string toString() {
			#line 30 "C:\\HaxeToolkit\\haxe\\std\\haxe\\macro\\Context.hx"
			return global::haxe.lang.Enum.paramsToString("Warning", new object[]{this.msg, this.pos});
		}
		#line default
		
		public readonly string msg;
		
		public readonly object pos;
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.macro {
	public class Context : global::haxe.lang.HxObject {
		
		public Context(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public Context() {
			#line 44 "C:\\HaxeToolkit\\haxe\\std\\haxe\\macro\\Context.hx"
			global::haxe.macro.Context.__hx_ctor_haxe_macro_Context(this);
		}
		#line default
		
		protected static void __hx_ctor_haxe_macro_Context(global::haxe.macro.Context __hx_this) {
		}
		
		
	}
}


