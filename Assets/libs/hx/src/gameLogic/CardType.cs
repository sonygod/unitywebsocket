// Generated by Haxe 4.1.0-rc.1+0d88c583b

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace gameLogic {
	public class ____CardType : global::haxe.lang.Enum {
		
		protected ____CardType(int index) : base(index) {
		}
		
		
		public static readonly global::gameLogic.____CardType CT_ERROR = new global::gameLogic.____CardType_CT_ERROR();
		
		public static readonly global::gameLogic.____CardType CT_SanPai = new global::gameLogic.____CardType_CT_SanPai();
		
		public static readonly global::gameLogic.____CardType CT_SanGong = new global::gameLogic.____CardType_CT_SanGong();
		
		protected static readonly string[] __hx_constructs = new string[]{"CT_ERROR", "CT_SanPai", "CT_SanGong"};
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace gameLogic {
	public sealed class ____CardType_CT_ERROR : global::gameLogic.____CardType {
		
		public ____CardType_CT_ERROR() : base(0) {
		}
		
		
		public override string getTag() {
			#line 7 "D:\\project\\sangong\\sangong\\src\\gameLogic\\CardType.hx"
			return "CT_ERROR";
		}
		#line default
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace gameLogic {
	public sealed class ____CardType_CT_SanPai : global::gameLogic.____CardType {
		
		public ____CardType_CT_SanPai() : base(1) {
		}
		
		
		public override string getTag() {
			#line 8 "D:\\project\\sangong\\sangong\\src\\gameLogic\\CardType.hx"
			return "CT_SanPai";
		}
		#line default
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace gameLogic {
	public sealed class ____CardType_CT_SanGong : global::gameLogic.____CardType {
		
		public ____CardType_CT_SanGong() : base(2) {
		}
		
		
		public override string getTag() {
			#line 9 "D:\\project\\sangong\\sangong\\src\\gameLogic\\CardType.hx"
			return "CT_SanGong";
		}
		#line default
		
	}
}


