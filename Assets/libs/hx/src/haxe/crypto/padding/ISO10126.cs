// Generated by Haxe 4.1.0-rc.1+0d88c583b
using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.crypto.padding {
	public class ISO10126 : global::haxe.lang.HxObject {
		
		public ISO10126(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public ISO10126() {
			#line 6 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\padding\\ISO10126.hx"
			global::haxe.crypto.padding.ISO10126.__hx_ctor_haxe_crypto_padding_ISO10126(this);
		}
		#line default
		
		protected static void __hx_ctor_haxe_crypto_padding_ISO10126(global::haxe.crypto.padding.ISO10126 __hx_this) {
		}
		
		
		public static global::haxe.io.Bytes pad(global::haxe.io.Bytes ciphertext, int blockSize) {
			unchecked {
				#line 10 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\padding\\ISO10126.hx"
				global::haxe.io.BytesBuffer buffer = new global::haxe.io.BytesBuffer();
				{
					#line 11 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\padding\\ISO10126.hx"
					int len = ciphertext.length;
					#line 11 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\padding\\ISO10126.hx"
					if (( ( len < 0 ) || ( len > ciphertext.length ) )) {
						#line 11 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\padding\\ISO10126.hx"
						throw global::haxe.lang.HaxeException.wrap(global::haxe.io.Error.OutsideBounds);
					}
					
					#line 11 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\padding\\ISO10126.hx"
					( buffer.b as global::System.IO.Stream ).Write(((byte[]) (ciphertext.b) ), ((int) (0) ), ((int) (len) ));
				}
				
				#line 12 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\padding\\ISO10126.hx"
				int padding = ( ( blockSize - ( ciphertext.length % blockSize ) ) - 1 );
				{
					#line 13 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\padding\\ISO10126.hx"
					int _g = 0;
					#line 13 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\padding\\ISO10126.hx"
					int _g1 = padding;
					#line 13 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\padding\\ISO10126.hx"
					while (( _g < _g1 )) {
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\padding\\ISO10126.hx"
						int i = _g++;
						{
							#line 14 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\padding\\ISO10126.hx"
							int @byte = global::haxe.root.Std.random(255);
							#line 14 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\padding\\ISO10126.hx"
							( buffer.b as global::System.IO.Stream ).WriteByte(((byte) (@byte) ));
						}
						
					}
					
				}
				
				#line 16 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\padding\\ISO10126.hx"
				( buffer.b as global::System.IO.Stream ).WriteByte(((byte) (( padding + 1 )) ));
				return buffer.getBytes();
			}
			#line default
		}
		
		
		public static global::haxe.io.Bytes unpad(global::haxe.io.Bytes encrypt) {
			unchecked {
				#line 22 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\padding\\ISO10126.hx"
				int padding = ((int) (((byte) (encrypt.b[( encrypt.length - 1 )]) )) );
				return encrypt.sub(0, ( encrypt.length - padding ));
			}
			#line default
		}
		
		
	}
}


