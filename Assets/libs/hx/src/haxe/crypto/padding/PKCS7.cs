// Generated by Haxe 4.1.0-rc.1+0d88c583b
using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.crypto.padding {
	public class PKCS7 : global::haxe.lang.HxObject {
		
		public PKCS7(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public PKCS7() {
			global::haxe.crypto.padding.PKCS7.__hx_ctor_haxe_crypto_padding_PKCS7(this);
		}
		
		
		protected static void __hx_ctor_haxe_crypto_padding_PKCS7(global::haxe.crypto.padding.PKCS7 __hx_this) {
		}
		
		
		public static global::haxe.io.Bytes pad(global::haxe.io.Bytes ciphertext, int blockSize) {
			unchecked {
				if (( blockSize > 255 )) {
					throw global::haxe.lang.HaxeException.wrap("PKCS#7 padding cannot be longer than 255 bytes");
				}
				
				if (( blockSize < 0 )) {
					throw global::haxe.lang.HaxeException.wrap("PKCS#7 padding size must be positive");
				}
				
				global::haxe.io.BytesBuffer buffer = new global::haxe.io.BytesBuffer();
				{
					int len = ciphertext.length;
					if (( ( len < 0 ) || ( len > ciphertext.length ) )) {
						throw global::haxe.lang.HaxeException.wrap(global::haxe.io.Error.OutsideBounds);
					}
					
					( buffer.b as global::System.IO.Stream ).Write(((byte[]) (ciphertext.b) ), ((int) (0) ), ((int) (len) ));
				}
				
				int padding = ( blockSize - ( ciphertext.length % blockSize ) );
				{
					int _g = 0;
					int _g1 = padding;
					while (( _g < _g1 )) {
						int i = _g++;
						( buffer.b as global::System.IO.Stream ).WriteByte(((byte) (( padding & 255 )) ));
					}
					
				}
				
				return buffer.getBytes();
			}
		}
		
		
		public static global::haxe.io.Bytes unpad(global::haxe.io.Bytes encrypt) {
			unchecked {
				int padding = ((int) (((byte) (encrypt.b[( encrypt.length - 1 )]) )) );
				if (( padding > encrypt.length )) {
					throw global::haxe.lang.HaxeException.wrap(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("Cannot remove ", global::haxe.lang.Runtime.toString(padding)), " bytes, because message is "), global::haxe.lang.Runtime.toString(encrypt.length)), " bytes"));
				}
				
				int block = ( encrypt.length - padding );
				{
					int _g = block;
					int _g1 = encrypt.length;
					while (( _g < _g1 )) {
						int i = _g++;
						if (( ((int) (((byte) (encrypt.b[i]) )) ) != padding )) {
							throw global::haxe.lang.HaxeException.wrap(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("Invalid padding value. Got ", global::haxe.lang.Runtime.toString(((int) (((byte) (encrypt.b[i]) )) ))), ", expected "), global::haxe.lang.Runtime.toString(padding)), " at position "), global::haxe.lang.Runtime.toString(i)));
						}
						
					}
					
				}
				
				return encrypt.sub(0, block);
			}
		}
		
		
	}
}


