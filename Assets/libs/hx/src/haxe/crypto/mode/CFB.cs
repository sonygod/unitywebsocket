// Generated by Haxe 4.0.0+ef18b627e
using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.crypto.mode {
	public class CFB : global::haxe.lang.HxObject {
		
		public CFB(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public CFB() {
			#line 5 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\mode\\CFB.hx"
			global::haxe.crypto.mode.CFB.__hx_ctor_haxe_crypto_mode_CFB(this);
		}
		#line default
		
		protected static void __hx_ctor_haxe_crypto_mode_CFB(global::haxe.crypto.mode.CFB __hx_this) {
		}
		
		
		public static void encrypt(global::haxe.io.Bytes src, global::haxe.io.Bytes iv, int blockSize, global::haxe.lang.Function encryptBlock) {
			#line 9 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\mode\\CFB.hx"
			global::haxe.io.Bytes vector = iv.sub(0, iv.length);
			int i = 0;
			#line 11 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\mode\\CFB.hx"
			int len = src.length;
			while (( i < len )) {
				#line 14 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\mode\\CFB.hx"
				encryptBlock.__hx_invoke4_o(default(double), vector, ((double) (0) ), global::haxe.lang.Runtime.undefined, default(double), vector, ((double) (0) ), global::haxe.lang.Runtime.undefined);
				int block = ( (( ( i + blockSize ) > len )) ? (( len - i )) : (blockSize) );
				#line 16 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\mode\\CFB.hx"
				{
					#line 16 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\mode\\CFB.hx"
					int _g = 0;
					#line 16 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\mode\\CFB.hx"
					int _g1 = block;
					#line 16 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\mode\\CFB.hx"
					while (( _g < _g1 )) {
						#line 16 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\mode\\CFB.hx"
						int j = _g++;
						#line 18 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\mode\\CFB.hx"
						src.b[( i + j )] = ((byte) (( ((int) (((byte) (src.b[( i + j )]) )) ) ^ ((int) (((byte) (vector.b[j]) )) ) )) );
					}
					
				}
				
				#line 21 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\mode\\CFB.hx"
				vector = src.sub(i, block);
				i += blockSize;
			}
			
		}
		#line default
		
		public static void decrypt(global::haxe.io.Bytes src, global::haxe.io.Bytes iv, int blockSize, global::haxe.lang.Function decryptBlock) {
			#line 28 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\mode\\CFB.hx"
			global::haxe.io.Bytes vector = iv.sub(0, iv.length);
			int i = 0;
			#line 30 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\mode\\CFB.hx"
			int len = src.length;
			global::haxe.io.Bytes chiperText = null;
			#line 32 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\mode\\CFB.hx"
			while (( i < len )) {
				#line 34 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\mode\\CFB.hx"
				decryptBlock.__hx_invoke4_o(default(double), vector, ((double) (0) ), global::haxe.lang.Runtime.undefined, default(double), vector, ((double) (0) ), global::haxe.lang.Runtime.undefined);
				int block = ( (( ( i + blockSize ) > len )) ? (( len - i )) : (blockSize) );
				#line 36 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\mode\\CFB.hx"
				chiperText = src.sub(i, block);
				{
					#line 37 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\mode\\CFB.hx"
					int _g = 0;
					#line 37 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\mode\\CFB.hx"
					int _g1 = block;
					#line 37 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\mode\\CFB.hx"
					while (( _g < _g1 )) {
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\mode\\CFB.hx"
						int j = _g++;
						#line 39 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\mode\\CFB.hx"
						src.b[( i + j )] = ((byte) (( ((int) (((byte) (src.b[( i + j )]) )) ) ^ ((int) (((byte) (vector.b[j]) )) ) )) );
					}
					
				}
				
				#line 42 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\mode\\CFB.hx"
				vector = chiperText.sub(0, chiperText.length);
				i += blockSize;
			}
			
		}
		#line default
		
	}
}


