// Generated by Haxe 4.0.2+606b176a3

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace sys.io {
	public class FileSeek : global::haxe.lang.Enum {
		
		protected FileSeek(int index) : base(index) {
		}
		
		
		public static readonly global::sys.io.FileSeek SeekBegin = new global::sys.io.FileSeek_SeekBegin();
		
		public static readonly global::sys.io.FileSeek SeekCur = new global::sys.io.FileSeek_SeekCur();
		
		public static readonly global::sys.io.FileSeek SeekEnd = new global::sys.io.FileSeek_SeekEnd();
		
		protected static readonly string[] __hx_constructs = new string[]{"SeekBegin", "SeekCur", "SeekEnd"};
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace sys.io {
	public sealed class FileSeek_SeekBegin : global::sys.io.FileSeek {
		
		public FileSeek_SeekBegin() : base(0) {
		}
		
		
		public override string getTag() {
			#line 26 "C:\\HaxeToolkit\\haxe\\std\\sys\\io\\FileSeek.hx"
			return "SeekBegin";
		}
		#line default
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace sys.io {
	public sealed class FileSeek_SeekCur : global::sys.io.FileSeek {
		
		public FileSeek_SeekCur() : base(1) {
		}
		
		
		public override string getTag() {
			#line 27 "C:\\HaxeToolkit\\haxe\\std\\sys\\io\\FileSeek.hx"
			return "SeekCur";
		}
		#line default
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace sys.io {
	public sealed class FileSeek_SeekEnd : global::sys.io.FileSeek {
		
		public FileSeek_SeekEnd() : base(2) {
		}
		
		
		public override string getTag() {
			#line 28 "C:\\HaxeToolkit\\haxe\\std\\sys\\io\\FileSeek.hx"
			return "SeekEnd";
		}
		#line default
		
	}
}


