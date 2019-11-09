// Generated by Haxe 4.0.0+ef18b627e
using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.crypto.mode {
	public class CTR : global::haxe.lang.HxObject {
		
		public CTR(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public CTR() {
			#line 5 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\mode\\CTR.hx"
			global::haxe.crypto.mode.CTR.__hx_ctor_haxe_crypto_mode_CTR(this);
		}
		#line default
		
		protected static void __hx_ctor_haxe_crypto_mode_CTR(global::haxe.crypto.mode.CTR __hx_this) {
		}
		
		
		public static void encrypt(global::haxe.io.Bytes src, global::haxe.io.Bytes iv, int blockSize, global::haxe.lang.Function encryptBlock) {
			unchecked {
				#line 9 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\mode\\CTR.hx"
				global::haxe.io.Bytes vector = null;
				global::haxe.io.Bytes vkey = iv.sub(0, iv.length);
				#line 11 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\mode\\CTR.hx"
				int i = 0;
				int len = src.length;
				#line 13 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\mode\\CTR.hx"
				while (( i < len )) {
					#line 15 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\mode\\CTR.hx"
					vector = vkey.sub(0, vkey.length);
					encryptBlock.__hx_invoke4_o(default(double), vector, ((double) (0) ), global::haxe.lang.Runtime.undefined, default(double), vector, ((double) (0) ), global::haxe.lang.Runtime.undefined);
					#line 18 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\mode\\CTR.hx"
					int block = ( (( ( i + blockSize ) > len )) ? (( len - i )) : (blockSize) );
					{
						#line 19 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\mode\\CTR.hx"
						int _g = 0;
						#line 19 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\mode\\CTR.hx"
						int _g1 = block;
						#line 19 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\mode\\CTR.hx"
						while (( _g < _g1 )) {
							#line 19 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\mode\\CTR.hx"
							int j = _g++;
							#line 21 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\mode\\CTR.hx"
							src.b[( i + j )] = ((byte) (( ((int) (((byte) (src.b[( i + j )]) )) ) ^ ((int) (((byte) (vector.b[j]) )) ) )) );
						}
						
					}
					
					#line 24 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\mode\\CTR.hx"
					int j1 = blockSize;
					while (( j1-- >= 0 )) {
						#line 26 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\mode\\CTR.hx"
						vkey.b[j1] = ((byte) (( ((int) (((byte) (vkey.b[j1]) )) ) + 1 )) );
						if (( ((int) (((byte) (vkey.b[j1]) )) ) != 0 )) {
							#line 27 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\mode\\CTR.hx"
							break;
						}
						
					}
					
					#line 30 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\mode\\CTR.hx"
					i += blockSize;
				}
				
			}
			#line default
		}
		
		
		public static void decrypt(global::haxe.io.Bytes src, global::haxe.io.Bytes iv, int blockSize, global::haxe.lang.Function decryptBlock) {
			#line 36 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\mode\\CTR.hx"
			global::haxe.crypto.mode.CTR.encrypt(src, iv, blockSize, decryptBlock);
		}
		#line default
		
	}
}

