// Generated by Haxe 4.1.0-rc.1+cd0f0219b
using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.crypto {
	public class Base64 : global::haxe.lang.HxObject {
		
		static Base64() {
			#line 29 "C:\\HaxeToolkit\\haxe\\std\\haxe\\crypto\\Base64.hx"
			global::haxe.crypto.Base64.CHARS = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/";
			global::haxe.crypto.Base64.BYTES = global::haxe.io.Bytes.ofString(global::haxe.crypto.Base64.CHARS, null);
			#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\crypto\\Base64.hx"
			global::haxe.crypto.Base64.URL_CHARS = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789-_";
			global::haxe.crypto.Base64.URL_BYTES = global::haxe.io.Bytes.ofString(global::haxe.crypto.Base64.URL_CHARS, null);
		}
		#line default
		
		public Base64(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public Base64() {
			#line 28 "C:\\HaxeToolkit\\haxe\\std\\haxe\\crypto\\Base64.hx"
			global::haxe.crypto.Base64.__hx_ctor_haxe_crypto_Base64(this);
		}
		#line default
		
		protected static void __hx_ctor_haxe_crypto_Base64(global::haxe.crypto.Base64 __hx_this) {
		}
		
		
		public static string CHARS;
		
		public static global::haxe.io.Bytes BYTES;
		
		public static string URL_CHARS;
		
		public static global::haxe.io.Bytes URL_BYTES;
		
		public static string encode(global::haxe.io.Bytes bytes, object complement) {
			unchecked {
				#line 35 "C:\\HaxeToolkit\\haxe\\std\\haxe\\crypto\\Base64.hx"
				bool complement1 = ( (( complement == default(object) )) ? (true) : (global::haxe.lang.Runtime.toBool(complement)) );
				string str = new global::haxe.crypto.BaseCode(((global::haxe.io.Bytes) (global::haxe.crypto.Base64.BYTES) )).encodeBytes(bytes).toString();
				#line 37 "C:\\HaxeToolkit\\haxe\\std\\haxe\\crypto\\Base64.hx"
				if (complement1) {
					#line 38 "C:\\HaxeToolkit\\haxe\\std\\haxe\\crypto\\Base64.hx"
					switch (( bytes.length % 3 )) {
						case 1:
						{
							#line 40 "C:\\HaxeToolkit\\haxe\\std\\haxe\\crypto\\Base64.hx"
							str = global::haxe.lang.Runtime.concat(str, "==");
							#line 40 "C:\\HaxeToolkit\\haxe\\std\\haxe\\crypto\\Base64.hx"
							break;
						}
						
						
						case 2:
						{
							#line 42 "C:\\HaxeToolkit\\haxe\\std\\haxe\\crypto\\Base64.hx"
							str = global::haxe.lang.Runtime.concat(str, "=");
							#line 42 "C:\\HaxeToolkit\\haxe\\std\\haxe\\crypto\\Base64.hx"
							break;
						}
						
						
						default:
						{
							#line 43 "C:\\HaxeToolkit\\haxe\\std\\haxe\\crypto\\Base64.hx"
							break;
						}
						
					}
					
				}
				
				#line 45 "C:\\HaxeToolkit\\haxe\\std\\haxe\\crypto\\Base64.hx"
				return str;
			}
			#line default
		}
		
		
		public static global::haxe.io.Bytes decode(string str, object complement) {
			unchecked {
				#line 48 "C:\\HaxeToolkit\\haxe\\std\\haxe\\crypto\\Base64.hx"
				bool complement1 = ( (( complement == default(object) )) ? (true) : (global::haxe.lang.Runtime.toBool(complement)) );
				if (complement1) {
					#line 50 "C:\\HaxeToolkit\\haxe\\std\\haxe\\crypto\\Base64.hx"
					while (global::haxe.lang.Runtime.eq(global::haxe.lang.StringExt.charCodeAt(str, ( str.Length - 1 )), 61)) {
						#line 51 "C:\\HaxeToolkit\\haxe\\std\\haxe\\crypto\\Base64.hx"
						str = global::haxe.lang.StringExt.substr(str, 0, -1);
					}
					
				}
				
				#line 52 "C:\\HaxeToolkit\\haxe\\std\\haxe\\crypto\\Base64.hx"
				return new global::haxe.crypto.BaseCode(((global::haxe.io.Bytes) (global::haxe.crypto.Base64.BYTES) )).decodeBytes(global::haxe.io.Bytes.ofString(str, null));
			}
			#line default
		}
		
		
		public static string urlEncode(global::haxe.io.Bytes bytes, object complement) {
			unchecked {
				#line 55 "C:\\HaxeToolkit\\haxe\\std\\haxe\\crypto\\Base64.hx"
				bool complement1 = ( (( complement == default(object) )) ? (false) : (global::haxe.lang.Runtime.toBool(complement)) );
				string str = new global::haxe.crypto.BaseCode(((global::haxe.io.Bytes) (global::haxe.crypto.Base64.URL_BYTES) )).encodeBytes(bytes).toString();
				#line 57 "C:\\HaxeToolkit\\haxe\\std\\haxe\\crypto\\Base64.hx"
				if (complement1) {
					#line 58 "C:\\HaxeToolkit\\haxe\\std\\haxe\\crypto\\Base64.hx"
					switch (( bytes.length % 3 )) {
						case 1:
						{
							#line 60 "C:\\HaxeToolkit\\haxe\\std\\haxe\\crypto\\Base64.hx"
							str = global::haxe.lang.Runtime.concat(str, "==");
							#line 60 "C:\\HaxeToolkit\\haxe\\std\\haxe\\crypto\\Base64.hx"
							break;
						}
						
						
						case 2:
						{
							#line 62 "C:\\HaxeToolkit\\haxe\\std\\haxe\\crypto\\Base64.hx"
							str = global::haxe.lang.Runtime.concat(str, "=");
							#line 62 "C:\\HaxeToolkit\\haxe\\std\\haxe\\crypto\\Base64.hx"
							break;
						}
						
						
						default:
						{
							#line 63 "C:\\HaxeToolkit\\haxe\\std\\haxe\\crypto\\Base64.hx"
							break;
						}
						
					}
					
				}
				
				#line 65 "C:\\HaxeToolkit\\haxe\\std\\haxe\\crypto\\Base64.hx"
				return str;
			}
			#line default
		}
		
		
		public static global::haxe.io.Bytes urlDecode(string str, object complement) {
			unchecked {
				#line 68 "C:\\HaxeToolkit\\haxe\\std\\haxe\\crypto\\Base64.hx"
				bool complement1 = ( (( complement == default(object) )) ? (false) : (global::haxe.lang.Runtime.toBool(complement)) );
				if (complement1) {
					#line 70 "C:\\HaxeToolkit\\haxe\\std\\haxe\\crypto\\Base64.hx"
					while (global::haxe.lang.Runtime.eq(global::haxe.lang.StringExt.charCodeAt(str, ( str.Length - 1 )), 61)) {
						#line 71 "C:\\HaxeToolkit\\haxe\\std\\haxe\\crypto\\Base64.hx"
						str = global::haxe.lang.StringExt.substr(str, 0, -1);
					}
					
				}
				
				#line 72 "C:\\HaxeToolkit\\haxe\\std\\haxe\\crypto\\Base64.hx"
				return new global::haxe.crypto.BaseCode(((global::haxe.io.Bytes) (global::haxe.crypto.Base64.URL_BYTES) )).decodeBytes(global::haxe.io.Bytes.ofString(str, null));
			}
			#line default
		}
		
		
	}
}


