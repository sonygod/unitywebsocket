// Generated by Haxe 4.0.2+606b176a3
using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.crypto.mode {
	public class ECB : global::haxe.lang.HxObject {
		
		public ECB(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public ECB() {
			#line 5 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\mode\\ECB.hx"
			global::haxe.crypto.mode.ECB.__hx_ctor_haxe_crypto_mode_ECB(this);
		}
		#line default
		
		protected static void __hx_ctor_haxe_crypto_mode_ECB(global::haxe.crypto.mode.ECB __hx_this) {
		}
		
		
		public static void encrypt(global::haxe.io.Bytes src, int blockSize, global::haxe.lang.Function encryptBlock) {
			#line 9 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\mode\\ECB.hx"
			int i = 0;
			int len = src.length;
			#line 11 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\mode\\ECB.hx"
			while (( i < len )) {
				#line 13 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\mode\\ECB.hx"
				encryptBlock.__hx_invoke4_o(default(double), src, ((double) (i) ), global::haxe.lang.Runtime.undefined, default(double), src, ((double) (i) ), global::haxe.lang.Runtime.undefined);
				i += blockSize;
			}
			
		}
		#line default
		
		public static void decrypt(global::haxe.io.Bytes src, int blockSize, global::haxe.lang.Function decryptBlock) {
			#line 20 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\mode\\ECB.hx"
			int i = 0;
			int len = src.length;
			#line 22 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\mode\\ECB.hx"
			while (( i < len )) {
				#line 24 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\mode\\ECB.hx"
				decryptBlock.__hx_invoke4_o(default(double), src, ((double) (i) ), global::haxe.lang.Runtime.undefined, default(double), src, ((double) (i) ), global::haxe.lang.Runtime.undefined);
				i += blockSize;
			}
			
		}
		#line default
		
	}
}


