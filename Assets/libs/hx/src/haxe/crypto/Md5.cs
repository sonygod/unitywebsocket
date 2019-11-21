// Generated by Haxe 4.1.0-rc.1+0d88c583b
using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.crypto {
	public class Md5 : global::haxe.lang.HxObject {
		
		public Md5(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public Md5() {
			global::haxe.crypto.Md5.__hx_ctor_haxe_crypto_Md5(this);
		}
		
		
		protected static void __hx_ctor_haxe_crypto_Md5(global::haxe.crypto.Md5 __hx_this) {
		}
		
		
		public static string encode(string s) {
			global::haxe.crypto.Md5 m = new global::haxe.crypto.Md5();
			global::haxe.root.Array h = m.doEncode(global::haxe.crypto.Md5.str2blks(s));
			return m.hex(h);
		}
		
		
		public static global::haxe.io.Bytes make(global::haxe.io.Bytes b) {
			unchecked {
				global::haxe.root.Array h = new global::haxe.crypto.Md5().doEncode(global::haxe.crypto.Md5.bytes2blks(b));
				global::haxe.io.Bytes @out = global::haxe.io.Bytes.alloc(16);
				int p = 0;
				{
					{
						@out.b[p++] = ((byte) (( ((int) (global::haxe.lang.Runtime.toInt(h.__get(0))) ) & 255 )) );
						@out.b[p++] = ((byte) (( ( ((int) (global::haxe.lang.Runtime.toInt(h.__get(0))) ) >> 8 ) & 255 )) );
						@out.b[p++] = ((byte) (( ( ((int) (global::haxe.lang.Runtime.toInt(h.__get(0))) ) >> 16 ) & 255 )) );
						@out.b[p++] = ((byte) (((int) (( ((uint) (((int) (global::haxe.lang.Runtime.toInt(h.__get(0))) )) ) >> 24 )) )) );
					}
					
					{
						@out.b[p++] = ((byte) (( ((int) (global::haxe.lang.Runtime.toInt(h.__get(1))) ) & 255 )) );
						@out.b[p++] = ((byte) (( ( ((int) (global::haxe.lang.Runtime.toInt(h.__get(1))) ) >> 8 ) & 255 )) );
						@out.b[p++] = ((byte) (( ( ((int) (global::haxe.lang.Runtime.toInt(h.__get(1))) ) >> 16 ) & 255 )) );
						@out.b[p++] = ((byte) (((int) (( ((uint) (((int) (global::haxe.lang.Runtime.toInt(h.__get(1))) )) ) >> 24 )) )) );
					}
					
					{
						@out.b[p++] = ((byte) (( ((int) (global::haxe.lang.Runtime.toInt(h.__get(2))) ) & 255 )) );
						@out.b[p++] = ((byte) (( ( ((int) (global::haxe.lang.Runtime.toInt(h.__get(2))) ) >> 8 ) & 255 )) );
						@out.b[p++] = ((byte) (( ( ((int) (global::haxe.lang.Runtime.toInt(h.__get(2))) ) >> 16 ) & 255 )) );
						@out.b[p++] = ((byte) (((int) (( ((uint) (((int) (global::haxe.lang.Runtime.toInt(h.__get(2))) )) ) >> 24 )) )) );
					}
					
					{
						@out.b[p++] = ((byte) (( ((int) (global::haxe.lang.Runtime.toInt(h.__get(3))) ) & 255 )) );
						@out.b[p++] = ((byte) (( ( ((int) (global::haxe.lang.Runtime.toInt(h.__get(3))) ) >> 8 ) & 255 )) );
						@out.b[p++] = ((byte) (( ( ((int) (global::haxe.lang.Runtime.toInt(h.__get(3))) ) >> 16 ) & 255 )) );
						@out.b[p++] = ((byte) (((int) (( ((uint) (((int) (global::haxe.lang.Runtime.toInt(h.__get(3))) )) ) >> 24 )) )) );
					}
					
				}
				
				return @out;
			}
		}
		
		
		public static global::haxe.root.Array bytes2blks(global::haxe.io.Bytes b) {
			unchecked {
				int nblk = ( (( ( b.length + 8 ) >> 6 )) + 1 );
				global::haxe.root.Array blks = new global::haxe.root.Array();
				int blksSize = ( nblk * 16 );
				int __temp_expr1 = ((int) (global::haxe.lang.Runtime.toInt(blks.__set(( blksSize - 1 ), 0))) );
				int i = 0;
				while (( i < b.length )) {
					{
						int __temp_index1 = ( i >> 2 );
						int __temp_expr2 = ((int) (global::haxe.lang.Runtime.toInt(blks.__set(__temp_index1, ( ((int) (global::haxe.lang.Runtime.toInt(blks.__get(__temp_index1))) ) | ( ((int) (((byte) (b.b[i]) )) ) << (( (( ( (( b.length << 3 )) + i ) & 3 )) << 3 )) ) )))) );
					}
					
					 ++ i;
				}
				
				{
					int __temp_index2 = ( i >> 2 );
					int __temp_expr3 = ((int) (global::haxe.lang.Runtime.toInt(blks.__set(__temp_index2, ( ((int) (global::haxe.lang.Runtime.toInt(blks.__get(__temp_index2))) ) | ( 128 << ( ( (( ( b.length * 8 ) + i )) % 4 ) * 8 ) ) )))) );
				}
				
				int l = ( b.length * 8 );
				int k = ( ( nblk * 16 ) - 2 );
				int __temp_expr4 = ((int) (global::haxe.lang.Runtime.toInt(blks.__set(k, ( l & 255 )))) );
				int __temp_expr5 = ((int) (global::haxe.lang.Runtime.toInt(blks.__set(k, ( ((int) (global::haxe.lang.Runtime.toInt(blks.__get(k))) ) | ( (( ((int) (( ((uint) (l) ) >> 8 )) ) & 255 )) << 8 ) )))) );
				int __temp_expr6 = ((int) (global::haxe.lang.Runtime.toInt(blks.__set(k, ( ((int) (global::haxe.lang.Runtime.toInt(blks.__get(k))) ) | ( (( ((int) (( ((uint) (l) ) >> 16 )) ) & 255 )) << 16 ) )))) );
				int __temp_expr7 = ((int) (global::haxe.lang.Runtime.toInt(blks.__set(k, ( ((int) (global::haxe.lang.Runtime.toInt(blks.__get(k))) ) | ( (( ((int) (( ((uint) (l) ) >> 24 )) ) & 255 )) << 24 ) )))) );
				return blks;
			}
		}
		
		
		public static global::haxe.root.Array str2blks(string str) {
			unchecked {
				global::haxe.io.Bytes str1 = global::haxe.io.Bytes.ofString(str, null);
				int nblk = ( (( ( str1.length + 8 ) >> 6 )) + 1 );
				global::haxe.root.Array blks = new global::haxe.root.Array();
				int blksSize = ( nblk * 16 );
				int __temp_expr1 = ((int) (global::haxe.lang.Runtime.toInt(blks.__set(( blksSize - 1 ), 0))) );
				int i = 0;
				int max = str1.length;
				int l = ( max * 8 );
				while (( i < max )) {
					{
						int __temp_index1 = ( i >> 2 );
						int __temp_expr2 = ((int) (global::haxe.lang.Runtime.toInt(blks.__set(__temp_index1, ( ((int) (global::haxe.lang.Runtime.toInt(blks.__get(__temp_index1))) ) | ( ((int) (((byte) (str1.b[i]) )) ) << ( ( (( l + i )) % 4 ) * 8 ) ) )))) );
					}
					
					 ++ i;
				}
				
				{
					int __temp_index2 = ( i >> 2 );
					int __temp_expr3 = ((int) (global::haxe.lang.Runtime.toInt(blks.__set(__temp_index2, ( ((int) (global::haxe.lang.Runtime.toInt(blks.__get(__temp_index2))) ) | ( 128 << ( ( (( l + i )) % 4 ) * 8 ) ) )))) );
				}
				
				int k = ( ( nblk * 16 ) - 2 );
				int __temp_expr4 = ((int) (global::haxe.lang.Runtime.toInt(blks.__set(k, ( l & 255 )))) );
				int __temp_expr5 = ((int) (global::haxe.lang.Runtime.toInt(blks.__set(k, ( ((int) (global::haxe.lang.Runtime.toInt(blks.__get(k))) ) | ( (( ((int) (( ((uint) (l) ) >> 8 )) ) & 255 )) << 8 ) )))) );
				int __temp_expr6 = ((int) (global::haxe.lang.Runtime.toInt(blks.__set(k, ( ((int) (global::haxe.lang.Runtime.toInt(blks.__get(k))) ) | ( (( ((int) (( ((uint) (l) ) >> 16 )) ) & 255 )) << 16 ) )))) );
				int __temp_expr7 = ((int) (global::haxe.lang.Runtime.toInt(blks.__set(k, ( ((int) (global::haxe.lang.Runtime.toInt(blks.__get(k))) ) | ( (( ((int) (( ((uint) (l) ) >> 24 )) ) & 255 )) << 24 ) )))) );
				return blks;
			}
		}
		
		
		public virtual int bitOR(int a, int b) {
			unchecked {
				int lsb = ( ( a & 1 ) | ( b & 1 ) );
				int msb31 = ( ((int) (( ((uint) (a) ) >> 1 )) ) | ((int) (( ((uint) (b) ) >> 1 )) ) );
				return ( ( msb31 << 1 ) | lsb );
			}
		}
		
		
		public virtual int bitXOR(int a, int b) {
			unchecked {
				int lsb = ( ( a & 1 ) ^ ( b & 1 ) );
				int msb31 = ( ((int) (( ((uint) (a) ) >> 1 )) ) ^ ((int) (( ((uint) (b) ) >> 1 )) ) );
				return ( ( msb31 << 1 ) | lsb );
			}
		}
		
		
		public virtual int bitAND(int a, int b) {
			unchecked {
				int lsb = ( ( a & 1 ) & (( b & 1 )) );
				int msb31 = ( ((int) (( ((uint) (a) ) >> 1 )) ) & ((int) (( ((uint) (b) ) >> 1 )) ) );
				return ( ( msb31 << 1 ) | lsb );
			}
		}
		
		
		public virtual int addme(int x, int y) {
			unchecked {
				int lsw = ( (( x & 65535 )) + (( y & 65535 )) );
				int msw = ( ( (( x >> 16 )) + (( y >> 16 )) ) + (( lsw >> 16 )) );
				return ( ( msw << 16 ) | ( lsw & 65535 ) );
			}
		}
		
		
		public virtual string hex(global::haxe.root.Array a) {
			unchecked {
				string str = "";
				string hex_chr = "0123456789abcdef";
				{
					int _g = 0;
					while (( _g < a.length )) {
						int num = ((int) (global::haxe.lang.Runtime.toInt(a.__get(_g))) );
						 ++ _g;
						{
							str = global::haxe.lang.Runtime.concat(str, global::haxe.lang.Runtime.concat(global::haxe.lang.StringExt.charAt(hex_chr, ( ( num >> 4 ) & 15 )), global::haxe.lang.StringExt.charAt(hex_chr, ( num & 15 ))));
							str = global::haxe.lang.Runtime.concat(str, global::haxe.lang.Runtime.concat(global::haxe.lang.StringExt.charAt(hex_chr, ( ( num >> 12 ) & 15 )), global::haxe.lang.StringExt.charAt(hex_chr, ( ( num >> 8 ) & 15 ))));
							str = global::haxe.lang.Runtime.concat(str, global::haxe.lang.Runtime.concat(global::haxe.lang.StringExt.charAt(hex_chr, ( ( num >> 20 ) & 15 )), global::haxe.lang.StringExt.charAt(hex_chr, ( ( num >> 16 ) & 15 ))));
							str = global::haxe.lang.Runtime.concat(str, global::haxe.lang.Runtime.concat(global::haxe.lang.StringExt.charAt(hex_chr, ( ( num >> 28 ) & 15 )), global::haxe.lang.StringExt.charAt(hex_chr, ( ( num >> 24 ) & 15 ))));
						}
						
					}
					
				}
				
				return str;
			}
		}
		
		
		public virtual int rol(int num, int cnt) {
			unchecked {
				return ( ( num << cnt ) | ((int) (( ((uint) (num) ) >> ( 32 - cnt ) )) ) );
			}
		}
		
		
		public virtual int cmn(int q, int a, int b, int x, int s, int t) {
			return this.addme(this.rol(this.addme(this.addme(a, q), this.addme(x, t)), s), b);
		}
		
		
		public virtual int ff(int a, int b, int c, int d, int x, int s, int t) {
			return this.cmn(this.bitOR(this.bitAND(b, c), this.bitAND( ~ (b) , d)), a, b, x, s, t);
		}
		
		
		public virtual int gg(int a, int b, int c, int d, int x, int s, int t) {
			return this.cmn(this.bitOR(this.bitAND(b, d), this.bitAND(c,  ~ (d) )), a, b, x, s, t);
		}
		
		
		public virtual int hh(int a, int b, int c, int d, int x, int s, int t) {
			return this.cmn(this.bitXOR(this.bitXOR(b, c), d), a, b, x, s, t);
		}
		
		
		public virtual int ii(int a, int b, int c, int d, int x, int s, int t) {
			return this.cmn(this.bitXOR(c, this.bitOR(b,  ~ (d) )), a, b, x, s, t);
		}
		
		
		public virtual global::haxe.root.Array doEncode(global::haxe.root.Array x) {
			unchecked {
				int a = 1732584193;
				int b = -271733879;
				int c = -1732584194;
				int d = 271733878;
				int step = default(int);
				int i = 0;
				while (( i < x.length )) {
					int olda = a;
					int oldb = b;
					int oldc = c;
					int oldd = d;
					step = 0;
					a = this.ff(a, b, c, d, ((int) (global::haxe.lang.Runtime.toInt(x.__get(i))) ), 7, -680876936);
					d = this.ff(d, a, b, c, ((int) (global::haxe.lang.Runtime.toInt(x.__get(( i + 1 )))) ), 12, -389564586);
					c = this.ff(c, d, a, b, ((int) (global::haxe.lang.Runtime.toInt(x.__get(( i + 2 )))) ), 17, 606105819);
					b = this.ff(b, c, d, a, ((int) (global::haxe.lang.Runtime.toInt(x.__get(( i + 3 )))) ), 22, -1044525330);
					a = this.ff(a, b, c, d, ((int) (global::haxe.lang.Runtime.toInt(x.__get(( i + 4 )))) ), 7, -176418897);
					d = this.ff(d, a, b, c, ((int) (global::haxe.lang.Runtime.toInt(x.__get(( i + 5 )))) ), 12, 1200080426);
					c = this.ff(c, d, a, b, ((int) (global::haxe.lang.Runtime.toInt(x.__get(( i + 6 )))) ), 17, -1473231341);
					b = this.ff(b, c, d, a, ((int) (global::haxe.lang.Runtime.toInt(x.__get(( i + 7 )))) ), 22, -45705983);
					a = this.ff(a, b, c, d, ((int) (global::haxe.lang.Runtime.toInt(x.__get(( i + 8 )))) ), 7, 1770035416);
					d = this.ff(d, a, b, c, ((int) (global::haxe.lang.Runtime.toInt(x.__get(( i + 9 )))) ), 12, -1958414417);
					c = this.ff(c, d, a, b, ((int) (global::haxe.lang.Runtime.toInt(x.__get(( i + 10 )))) ), 17, -42063);
					b = this.ff(b, c, d, a, ((int) (global::haxe.lang.Runtime.toInt(x.__get(( i + 11 )))) ), 22, -1990404162);
					a = this.ff(a, b, c, d, ((int) (global::haxe.lang.Runtime.toInt(x.__get(( i + 12 )))) ), 7, 1804603682);
					d = this.ff(d, a, b, c, ((int) (global::haxe.lang.Runtime.toInt(x.__get(( i + 13 )))) ), 12, -40341101);
					c = this.ff(c, d, a, b, ((int) (global::haxe.lang.Runtime.toInt(x.__get(( i + 14 )))) ), 17, -1502002290);
					b = this.ff(b, c, d, a, ((int) (global::haxe.lang.Runtime.toInt(x.__get(( i + 15 )))) ), 22, 1236535329);
					a = this.gg(a, b, c, d, ((int) (global::haxe.lang.Runtime.toInt(x.__get(( i + 1 )))) ), 5, -165796510);
					d = this.gg(d, a, b, c, ((int) (global::haxe.lang.Runtime.toInt(x.__get(( i + 6 )))) ), 9, -1069501632);
					c = this.gg(c, d, a, b, ((int) (global::haxe.lang.Runtime.toInt(x.__get(( i + 11 )))) ), 14, 643717713);
					b = this.gg(b, c, d, a, ((int) (global::haxe.lang.Runtime.toInt(x.__get(i))) ), 20, -373897302);
					a = this.gg(a, b, c, d, ((int) (global::haxe.lang.Runtime.toInt(x.__get(( i + 5 )))) ), 5, -701558691);
					d = this.gg(d, a, b, c, ((int) (global::haxe.lang.Runtime.toInt(x.__get(( i + 10 )))) ), 9, 38016083);
					c = this.gg(c, d, a, b, ((int) (global::haxe.lang.Runtime.toInt(x.__get(( i + 15 )))) ), 14, -660478335);
					b = this.gg(b, c, d, a, ((int) (global::haxe.lang.Runtime.toInt(x.__get(( i + 4 )))) ), 20, -405537848);
					a = this.gg(a, b, c, d, ((int) (global::haxe.lang.Runtime.toInt(x.__get(( i + 9 )))) ), 5, 568446438);
					d = this.gg(d, a, b, c, ((int) (global::haxe.lang.Runtime.toInt(x.__get(( i + 14 )))) ), 9, -1019803690);
					c = this.gg(c, d, a, b, ((int) (global::haxe.lang.Runtime.toInt(x.__get(( i + 3 )))) ), 14, -187363961);
					b = this.gg(b, c, d, a, ((int) (global::haxe.lang.Runtime.toInt(x.__get(( i + 8 )))) ), 20, 1163531501);
					a = this.gg(a, b, c, d, ((int) (global::haxe.lang.Runtime.toInt(x.__get(( i + 13 )))) ), 5, -1444681467);
					d = this.gg(d, a, b, c, ((int) (global::haxe.lang.Runtime.toInt(x.__get(( i + 2 )))) ), 9, -51403784);
					c = this.gg(c, d, a, b, ((int) (global::haxe.lang.Runtime.toInt(x.__get(( i + 7 )))) ), 14, 1735328473);
					b = this.gg(b, c, d, a, ((int) (global::haxe.lang.Runtime.toInt(x.__get(( i + 12 )))) ), 20, -1926607734);
					a = this.hh(a, b, c, d, ((int) (global::haxe.lang.Runtime.toInt(x.__get(( i + 5 )))) ), 4, -378558);
					d = this.hh(d, a, b, c, ((int) (global::haxe.lang.Runtime.toInt(x.__get(( i + 8 )))) ), 11, -2022574463);
					c = this.hh(c, d, a, b, ((int) (global::haxe.lang.Runtime.toInt(x.__get(( i + 11 )))) ), 16, 1839030562);
					b = this.hh(b, c, d, a, ((int) (global::haxe.lang.Runtime.toInt(x.__get(( i + 14 )))) ), 23, -35309556);
					a = this.hh(a, b, c, d, ((int) (global::haxe.lang.Runtime.toInt(x.__get(( i + 1 )))) ), 4, -1530992060);
					d = this.hh(d, a, b, c, ((int) (global::haxe.lang.Runtime.toInt(x.__get(( i + 4 )))) ), 11, 1272893353);
					c = this.hh(c, d, a, b, ((int) (global::haxe.lang.Runtime.toInt(x.__get(( i + 7 )))) ), 16, -155497632);
					b = this.hh(b, c, d, a, ((int) (global::haxe.lang.Runtime.toInt(x.__get(( i + 10 )))) ), 23, -1094730640);
					a = this.hh(a, b, c, d, ((int) (global::haxe.lang.Runtime.toInt(x.__get(( i + 13 )))) ), 4, 681279174);
					d = this.hh(d, a, b, c, ((int) (global::haxe.lang.Runtime.toInt(x.__get(i))) ), 11, -358537222);
					c = this.hh(c, d, a, b, ((int) (global::haxe.lang.Runtime.toInt(x.__get(( i + 3 )))) ), 16, -722521979);
					b = this.hh(b, c, d, a, ((int) (global::haxe.lang.Runtime.toInt(x.__get(( i + 6 )))) ), 23, 76029189);
					a = this.hh(a, b, c, d, ((int) (global::haxe.lang.Runtime.toInt(x.__get(( i + 9 )))) ), 4, -640364487);
					d = this.hh(d, a, b, c, ((int) (global::haxe.lang.Runtime.toInt(x.__get(( i + 12 )))) ), 11, -421815835);
					c = this.hh(c, d, a, b, ((int) (global::haxe.lang.Runtime.toInt(x.__get(( i + 15 )))) ), 16, 530742520);
					b = this.hh(b, c, d, a, ((int) (global::haxe.lang.Runtime.toInt(x.__get(( i + 2 )))) ), 23, -995338651);
					a = this.ii(a, b, c, d, ((int) (global::haxe.lang.Runtime.toInt(x.__get(i))) ), 6, -198630844);
					d = this.ii(d, a, b, c, ((int) (global::haxe.lang.Runtime.toInt(x.__get(( i + 7 )))) ), 10, 1126891415);
					c = this.ii(c, d, a, b, ((int) (global::haxe.lang.Runtime.toInt(x.__get(( i + 14 )))) ), 15, -1416354905);
					b = this.ii(b, c, d, a, ((int) (global::haxe.lang.Runtime.toInt(x.__get(( i + 5 )))) ), 21, -57434055);
					a = this.ii(a, b, c, d, ((int) (global::haxe.lang.Runtime.toInt(x.__get(( i + 12 )))) ), 6, 1700485571);
					d = this.ii(d, a, b, c, ((int) (global::haxe.lang.Runtime.toInt(x.__get(( i + 3 )))) ), 10, -1894986606);
					c = this.ii(c, d, a, b, ((int) (global::haxe.lang.Runtime.toInt(x.__get(( i + 10 )))) ), 15, -1051523);
					b = this.ii(b, c, d, a, ((int) (global::haxe.lang.Runtime.toInt(x.__get(( i + 1 )))) ), 21, -2054922799);
					a = this.ii(a, b, c, d, ((int) (global::haxe.lang.Runtime.toInt(x.__get(( i + 8 )))) ), 6, 1873313359);
					d = this.ii(d, a, b, c, ((int) (global::haxe.lang.Runtime.toInt(x.__get(( i + 15 )))) ), 10, -30611744);
					c = this.ii(c, d, a, b, ((int) (global::haxe.lang.Runtime.toInt(x.__get(( i + 6 )))) ), 15, -1560198380);
					b = this.ii(b, c, d, a, ((int) (global::haxe.lang.Runtime.toInt(x.__get(( i + 13 )))) ), 21, 1309151649);
					a = this.ii(a, b, c, d, ((int) (global::haxe.lang.Runtime.toInt(x.__get(( i + 4 )))) ), 6, -145523070);
					d = this.ii(d, a, b, c, ((int) (global::haxe.lang.Runtime.toInt(x.__get(( i + 11 )))) ), 10, -1120210379);
					c = this.ii(c, d, a, b, ((int) (global::haxe.lang.Runtime.toInt(x.__get(( i + 2 )))) ), 15, 718787259);
					b = this.ii(b, c, d, a, ((int) (global::haxe.lang.Runtime.toInt(x.__get(( i + 9 )))) ), 21, -343485551);
					a = this.addme(a, olda);
					b = this.addme(b, oldb);
					c = this.addme(c, oldc);
					d = this.addme(d, oldd);
					i += 16;
				}
				
				return new global::haxe.root.Array(new object[]{a, b, c, d});
			}
		}
		
		
		public override object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties) {
			unchecked {
				switch (hash) {
					case 234584065:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "doEncode", 234584065)) );
					}
					
					
					case 23520:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "ii", 23520)) );
					}
					
					
					case 23296:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "hh", 23296)) );
					}
					
					
					case 23072:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "gg", 23072)) );
					}
					
					
					case 22848:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "ff", 22848)) );
					}
					
					
					case 4947588:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "cmn", 4947588)) );
					}
					
					
					case 5693967:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "rol", 5693967)) );
					}
					
					
					case 5194459:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "hex", 5194459)) );
					}
					
					
					case 474209209:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "addme", 474209209)) );
					}
					
					
					case 1894423562:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "bitAND", 1894423562)) );
					}
					
					
					case 1895567566:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "bitXOR", 1895567566)) );
					}
					
					
					case 855935792:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "bitOR", 855935792)) );
					}
					
					
					default:
					{
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override object __hx_invokeField(string field, int hash, object[] dynargs) {
			unchecked {
				switch (hash) {
					case 234584065:
					{
						return this.doEncode(((global::haxe.root.Array) (((object) (dynargs[0]) )) ));
					}
					
					
					case 23520:
					{
						return this.ii(((int) (global::haxe.lang.Runtime.toInt(((object) (dynargs[0]) ))) ), ((int) (global::haxe.lang.Runtime.toInt(((object) (dynargs[1]) ))) ), ((int) (global::haxe.lang.Runtime.toInt(((object) (dynargs[2]) ))) ), ((int) (global::haxe.lang.Runtime.toInt(((object) (dynargs[3]) ))) ), ((int) (global::haxe.lang.Runtime.toInt(((object) (dynargs[4]) ))) ), ((int) (global::haxe.lang.Runtime.toInt(((object) (dynargs[5]) ))) ), ((int) (global::haxe.lang.Runtime.toInt(((object) (dynargs[6]) ))) ));
					}
					
					
					case 23296:
					{
						return this.hh(((int) (global::haxe.lang.Runtime.toInt(((object) (dynargs[0]) ))) ), ((int) (global::haxe.lang.Runtime.toInt(((object) (dynargs[1]) ))) ), ((int) (global::haxe.lang.Runtime.toInt(((object) (dynargs[2]) ))) ), ((int) (global::haxe.lang.Runtime.toInt(((object) (dynargs[3]) ))) ), ((int) (global::haxe.lang.Runtime.toInt(((object) (dynargs[4]) ))) ), ((int) (global::haxe.lang.Runtime.toInt(((object) (dynargs[5]) ))) ), ((int) (global::haxe.lang.Runtime.toInt(((object) (dynargs[6]) ))) ));
					}
					
					
					case 23072:
					{
						return this.gg(((int) (global::haxe.lang.Runtime.toInt(((object) (dynargs[0]) ))) ), ((int) (global::haxe.lang.Runtime.toInt(((object) (dynargs[1]) ))) ), ((int) (global::haxe.lang.Runtime.toInt(((object) (dynargs[2]) ))) ), ((int) (global::haxe.lang.Runtime.toInt(((object) (dynargs[3]) ))) ), ((int) (global::haxe.lang.Runtime.toInt(((object) (dynargs[4]) ))) ), ((int) (global::haxe.lang.Runtime.toInt(((object) (dynargs[5]) ))) ), ((int) (global::haxe.lang.Runtime.toInt(((object) (dynargs[6]) ))) ));
					}
					
					
					case 22848:
					{
						return this.ff(((int) (global::haxe.lang.Runtime.toInt(((object) (dynargs[0]) ))) ), ((int) (global::haxe.lang.Runtime.toInt(((object) (dynargs[1]) ))) ), ((int) (global::haxe.lang.Runtime.toInt(((object) (dynargs[2]) ))) ), ((int) (global::haxe.lang.Runtime.toInt(((object) (dynargs[3]) ))) ), ((int) (global::haxe.lang.Runtime.toInt(((object) (dynargs[4]) ))) ), ((int) (global::haxe.lang.Runtime.toInt(((object) (dynargs[5]) ))) ), ((int) (global::haxe.lang.Runtime.toInt(((object) (dynargs[6]) ))) ));
					}
					
					
					case 4947588:
					{
						return this.cmn(((int) (global::haxe.lang.Runtime.toInt(((object) (dynargs[0]) ))) ), ((int) (global::haxe.lang.Runtime.toInt(((object) (dynargs[1]) ))) ), ((int) (global::haxe.lang.Runtime.toInt(((object) (dynargs[2]) ))) ), ((int) (global::haxe.lang.Runtime.toInt(((object) (dynargs[3]) ))) ), ((int) (global::haxe.lang.Runtime.toInt(((object) (dynargs[4]) ))) ), ((int) (global::haxe.lang.Runtime.toInt(((object) (dynargs[5]) ))) ));
					}
					
					
					case 5693967:
					{
						return this.rol(((int) (global::haxe.lang.Runtime.toInt(((object) (dynargs[0]) ))) ), ((int) (global::haxe.lang.Runtime.toInt(((object) (dynargs[1]) ))) ));
					}
					
					
					case 5194459:
					{
						return this.hex(((global::haxe.root.Array) (((object) (dynargs[0]) )) ));
					}
					
					
					case 474209209:
					{
						return this.addme(((int) (global::haxe.lang.Runtime.toInt(((object) (dynargs[0]) ))) ), ((int) (global::haxe.lang.Runtime.toInt(((object) (dynargs[1]) ))) ));
					}
					
					
					case 1894423562:
					{
						return this.bitAND(((int) (global::haxe.lang.Runtime.toInt(((object) (dynargs[0]) ))) ), ((int) (global::haxe.lang.Runtime.toInt(((object) (dynargs[1]) ))) ));
					}
					
					
					case 1895567566:
					{
						return this.bitXOR(((int) (global::haxe.lang.Runtime.toInt(((object) (dynargs[0]) ))) ), ((int) (global::haxe.lang.Runtime.toInt(((object) (dynargs[1]) ))) ));
					}
					
					
					case 855935792:
					{
						return this.bitOR(((int) (global::haxe.lang.Runtime.toInt(((object) (dynargs[0]) ))) ), ((int) (global::haxe.lang.Runtime.toInt(((object) (dynargs[1]) ))) ));
					}
					
					
					default:
					{
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
			}
		}
		
		
	}
}


