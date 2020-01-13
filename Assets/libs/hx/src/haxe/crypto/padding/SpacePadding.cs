// Generated by Haxe 4.1.0-rc.1+0d88c583b
using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.crypto.padding {
	public class SpacePadding : global::haxe.lang.HxObject {
		
		public SpacePadding(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public SpacePadding() {
			#line 6 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\padding\\SpacePadding.hx"
			global::haxe.crypto.padding.SpacePadding.__hx_ctor_haxe_crypto_padding_SpacePadding(this);
		}
		#line default
		
		protected static void __hx_ctor_haxe_crypto_padding_SpacePadding(global::haxe.crypto.padding.SpacePadding __hx_this) {
		}
		
		
		public static global::haxe.io.Bytes pad(global::haxe.io.Bytes ciphertext, int blockSize) {
			unchecked {
				#line 10 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\padding\\SpacePadding.hx"
				global::haxe.io.BytesBuffer buffer = new global::haxe.io.BytesBuffer();
				{
					#line 11 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\padding\\SpacePadding.hx"
					int len = ciphertext.length;
					#line 11 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\padding\\SpacePadding.hx"
					if (( ( len < 0 ) || ( len > ciphertext.length ) )) {
						#line 11 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\padding\\SpacePadding.hx"
						throw global::haxe.lang.HaxeException.wrap(global::haxe.io.Error.OutsideBounds);
					}
					
					#line 11 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\padding\\SpacePadding.hx"
					( buffer.b as global::System.IO.Stream ).Write(((byte[]) (ciphertext.b) ), ((int) (0) ), ((int) (len) ));
				}
				
				#line 12 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\padding\\SpacePadding.hx"
				int padding = ( blockSize - ( ciphertext.length % blockSize ) );
				{
					#line 13 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\padding\\SpacePadding.hx"
					int _g = 0;
					#line 13 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\padding\\SpacePadding.hx"
					int _g1 = padding;
					#line 13 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\padding\\SpacePadding.hx"
					while (( _g < _g1 )) {
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\padding\\SpacePadding.hx"
						int i = _g++;
						( buffer.b as global::System.IO.Stream ).WriteByte(((byte) (32) ));
					}
					
				}
				
				#line 16 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\padding\\SpacePadding.hx"
				return buffer.getBytes();
			}
			#line default
		}
		
		
		public static global::haxe.io.Bytes unpad(global::haxe.io.Bytes encrypt) {
			unchecked {
				#line 21 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\padding\\SpacePadding.hx"
				int padding = 32;
				int pos = encrypt.length;
				#line 23 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\padding\\SpacePadding.hx"
				while (( ( padding == 32 ) && ( pos > 0 ) )) {
					#line 24 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\padding\\SpacePadding.hx"
					 -- pos;
					padding = ((int) (((byte) (encrypt.b[pos]) )) );
				}
				
				#line 27 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\padding\\SpacePadding.hx"
				return encrypt.sub(0, ( pos + 1 ));
			}
			#line default
		}
		
		
	}
}


