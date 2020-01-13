// Generated by Haxe 4.1.0-rc.1+cd0f0219b

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.zip {
	public class FlushMode : global::haxe.lang.Enum {
		
		protected FlushMode(int index) : base(index) {
		}
		
		
		public static readonly global::haxe.zip.FlushMode NO = new global::haxe.zip.FlushMode_NO();
		
		public static readonly global::haxe.zip.FlushMode SYNC = new global::haxe.zip.FlushMode_SYNC();
		
		public static readonly global::haxe.zip.FlushMode FULL = new global::haxe.zip.FlushMode_FULL();
		
		public static readonly global::haxe.zip.FlushMode FINISH = new global::haxe.zip.FlushMode_FINISH();
		
		public static readonly global::haxe.zip.FlushMode BLOCK = new global::haxe.zip.FlushMode_BLOCK();
		
		protected static readonly string[] __hx_constructs = new string[]{"NO", "SYNC", "FULL", "FINISH", "BLOCK"};
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.zip {
	public sealed class FlushMode_NO : global::haxe.zip.FlushMode {
		
		public FlushMode_NO() : base(0) {
		}
		
		
		public override string getTag() {
			#line 26 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\FlushMode.hx"
			return "NO";
		}
		#line default
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.zip {
	public sealed class FlushMode_SYNC : global::haxe.zip.FlushMode {
		
		public FlushMode_SYNC() : base(1) {
		}
		
		
		public override string getTag() {
			#line 27 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\FlushMode.hx"
			return "SYNC";
		}
		#line default
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.zip {
	public sealed class FlushMode_FULL : global::haxe.zip.FlushMode {
		
		public FlushMode_FULL() : base(2) {
		}
		
		
		public override string getTag() {
			#line 28 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\FlushMode.hx"
			return "FULL";
		}
		#line default
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.zip {
	public sealed class FlushMode_FINISH : global::haxe.zip.FlushMode {
		
		public FlushMode_FINISH() : base(3) {
		}
		
		
		public override string getTag() {
			#line 29 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\FlushMode.hx"
			return "FINISH";
		}
		#line default
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.zip {
	public sealed class FlushMode_BLOCK : global::haxe.zip.FlushMode {
		
		public FlushMode_BLOCK() : base(4) {
		}
		
		
		public override string getTag() {
			#line 30 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\FlushMode.hx"
			return "BLOCK";
		}
		#line default
		
	}
}


