// Generated by Haxe 4.1.0-rc.1+0d88c583b
using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.crypto.mode {
	public class OFB : global::haxe.lang.HxObject {
		
		public OFB(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public OFB() {
			#line 5 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\mode\\OFB.hx"
			global::haxe.crypto.mode.OFB.__hx_ctor_haxe_crypto_mode_OFB(this);
		}
		#line default
		
		protected static void __hx_ctor_haxe_crypto_mode_OFB(global::haxe.crypto.mode.OFB __hx_this) {
		}
		
		
		public static void encrypt(global::haxe.io.Bytes src, global::haxe.io.Bytes iv, int blockSize, global::haxe.lang.Function encryptBlock) {
			#line 9 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\mode\\OFB.hx"
			global::haxe.io.Bytes vector = iv.sub(0, iv.length);
			int i = 0;
			#line 11 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\mode\\OFB.hx"
			int len = src.length;
			global::haxe.io.Bytes chiperText = null;
			#line 13 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\mode\\OFB.hx"
			while (( i < len )) {
				#line 15 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\mode\\OFB.hx"
				encryptBlock.__hx_invoke4_o(default(double), vector, ((double) (0) ), global::haxe.lang.Runtime.undefined, default(double), vector, ((double) (0) ), global::haxe.lang.Runtime.undefined);
				chiperText = vector.sub(0, vector.length);
				#line 17 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\mode\\OFB.hx"
				int block = ( (( ( i + blockSize ) > len )) ? (( len - i )) : (blockSize) );
				{
					#line 18 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\mode\\OFB.hx"
					int _g = 0;
					#line 18 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\mode\\OFB.hx"
					int _g1 = block;
					#line 18 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\mode\\OFB.hx"
					while (( _g < _g1 )) {
						#line 18 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\mode\\OFB.hx"
						int j = _g++;
						#line 20 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\mode\\OFB.hx"
						src.b[( i + j )] = ((byte) (( ((int) (((byte) (src.b[( i + j )]) )) ) ^ ((int) (((byte) (vector.b[j]) )) ) )) );
					}
					
				}
				
				#line 22 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\mode\\OFB.hx"
				vector = chiperText.sub(0, chiperText.length);
				#line 24 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\mode\\OFB.hx"
				i += blockSize;
			}
			
		}
		#line default
		
		public static void decrypt(global::haxe.io.Bytes src, global::haxe.io.Bytes iv, int blockSize, global::haxe.lang.Function decryptBlock) {
			#line 30 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\mode\\OFB.hx"
			global::haxe.crypto.mode.OFB.encrypt(src, iv, blockSize, decryptBlock);
		}
		#line default
		
	}
}


