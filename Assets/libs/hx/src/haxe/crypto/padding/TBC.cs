// Generated by Haxe 4.0.0+ef18b627e
using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.crypto.padding {
	public class TBC : global::haxe.lang.HxObject {
		
		public TBC(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public TBC() {
			#line 6 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\padding\\TBC.hx"
			global::haxe.crypto.padding.TBC.__hx_ctor_haxe_crypto_padding_TBC(this);
		}
		#line default
		
		protected static void __hx_ctor_haxe_crypto_padding_TBC(global::haxe.crypto.padding.TBC __hx_this) {
		}
		
		
		public static global::haxe.io.Bytes pad(global::haxe.io.Bytes ciphertext, int blockSize) {
			unchecked {
				#line 10 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\padding\\TBC.hx"
				int tb = ( ((int) (((byte) (ciphertext.b[( ciphertext.length - 1 )]) )) ) & 1 );
				int paddingByte = ( (( tb == 1 )) ? (0) : (255) );
				#line 12 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\padding\\TBC.hx"
				global::haxe.io.BytesBuffer buffer = new global::haxe.io.BytesBuffer();
				{
					#line 13 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\padding\\TBC.hx"
					int len = ciphertext.length;
					#line 13 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\padding\\TBC.hx"
					if (( ( len < 0 ) || ( len > ciphertext.length ) )) {
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\padding\\TBC.hx"
						throw global::haxe.lang.HaxeException.wrap(global::haxe.io.Error.OutsideBounds);
					}
					
					#line 13 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\padding\\TBC.hx"
					( buffer.b as global::System.IO.Stream ).Write(((byte[]) (ciphertext.b) ), ((int) (0) ), ((int) (len) ));
				}
				
				#line 14 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\padding\\TBC.hx"
				int padding = ( blockSize - ( ciphertext.length % blockSize ) );
				{
					#line 15 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\padding\\TBC.hx"
					int _g = 0;
					#line 15 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\padding\\TBC.hx"
					int _g1 = padding;
					#line 15 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\padding\\TBC.hx"
					while (( _g < _g1 )) {
						#line 15 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\padding\\TBC.hx"
						int i = _g++;
						( buffer.b as global::System.IO.Stream ).WriteByte(((byte) (paddingByte) ));
					}
					
				}
				
				#line 18 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\padding\\TBC.hx"
				return buffer.getBytes();
			}
			#line default
		}
		
		
		public static global::haxe.io.Bytes unpad(global::haxe.io.Bytes encrypt) {
			unchecked {
				#line 23 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\padding\\TBC.hx"
				int pos = ( encrypt.length - 1 );
				int paddingByte = ((int) (((byte) (encrypt.b[pos]) )) );
				#line 25 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\padding\\TBC.hx"
				int padding = paddingByte;
				while (( ( padding == paddingByte ) && ( pos > -1 ) )) {
					#line 27 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\padding\\TBC.hx"
					 -- pos;
					padding = ((int) (((byte) (encrypt.b[pos]) )) );
				}
				
				#line 30 "C:\\HaxeToolkit\\haxe\\lib\\crypto\\0,3,0\\src\\haxe\\crypto\\padding\\TBC.hx"
				return encrypt.sub(0, ( pos + 1 ));
			}
			#line default
		}
		
		
	}
}


