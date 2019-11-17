// Generated by Haxe 4.0.2+606b176a3

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.io {
	public class Encoding : global::haxe.lang.Enum {
		
		protected Encoding(int index) : base(index) {
		}
		
		
		public static readonly global::haxe.io.Encoding UTF8 = new global::haxe.io.Encoding_UTF8();
		
		public static readonly global::haxe.io.Encoding RawNative = new global::haxe.io.Encoding_RawNative();
		
		protected static readonly string[] __hx_constructs = new string[]{"UTF8", "RawNative"};
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.io {
	public sealed class Encoding_UTF8 : global::haxe.io.Encoding {
		
		public Encoding_UTF8() : base(0) {
		}
		
		
		public override string getTag() {
			#line 29 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Encoding.hx"
			return "UTF8";
		}
		#line default
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.io {
	public sealed class Encoding_RawNative : global::haxe.io.Encoding {
		
		public Encoding_RawNative() : base(1) {
		}
		
		
		public override string getTag() {
			#line 34 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Encoding.hx"
			return "RawNative";
		}
		#line default
		
	}
}


