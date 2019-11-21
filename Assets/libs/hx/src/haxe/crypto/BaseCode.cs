// Generated by Haxe 4.1.0-rc.1+0d88c583b
using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.crypto {
	public class BaseCode : global::haxe.lang.HxObject {
		
		public BaseCode(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public BaseCode(global::haxe.io.Bytes @base) {
			global::haxe.crypto.BaseCode.__hx_ctor_haxe_crypto_BaseCode(this, @base);
		}
		
		
		protected static void __hx_ctor_haxe_crypto_BaseCode(global::haxe.crypto.BaseCode __hx_this, global::haxe.io.Bytes @base) {
			unchecked {
				int len = @base.length;
				int nbits = 1;
				while (( len > ( 1 << nbits ) )) {
					 ++ nbits;
				}
				
				if (( ( nbits > 8 ) || ( len != ( 1 << nbits ) ) )) {
					throw global::haxe.lang.HaxeException.wrap("BaseCode : base length must be a power of two.");
				}
				
				__hx_this.@base = @base;
				__hx_this.nbits = nbits;
			}
		}
		
		
		public static string encode(string s, string @base) {
			global::haxe.crypto.BaseCode b = new global::haxe.crypto.BaseCode(((global::haxe.io.Bytes) (global::haxe.io.Bytes.ofString(@base, null)) ));
			return b.encodeString(s);
		}
		
		
		public static string decode(string s, string @base) {
			global::haxe.crypto.BaseCode b = new global::haxe.crypto.BaseCode(((global::haxe.io.Bytes) (global::haxe.io.Bytes.ofString(@base, null)) ));
			return b.decodeString(s);
		}
		
		
		public global::haxe.io.Bytes @base;
		
		public int nbits;
		
		public global::haxe.root.Array tbl;
		
		public virtual global::haxe.io.Bytes encodeBytes(global::haxe.io.Bytes b) {
			unchecked {
				int nbits = this.nbits;
				global::haxe.io.Bytes @base = this.@base;
				int size = ( ( b.length * 8 ) / nbits );
				global::haxe.io.Bytes @out = global::haxe.io.Bytes.alloc(( size + (( (( ( ( b.length * 8 ) % nbits ) == 0 )) ? (0) : (1) )) ));
				int buf = 0;
				int curbits = 0;
				int mask = ( (( 1 << nbits )) - 1 );
				int pin = 0;
				int pout = 0;
				while (( pout < size )) {
					while (( curbits < nbits )) {
						curbits += 8;
						buf <<= 8;
						buf |= ((int) (((byte) (b.b[pin++]) )) );
					}
					
					curbits -= nbits;
					@out.b[pout++] = ((byte) (((int) (((byte) (@base.b[( ( buf >> curbits ) & mask )]) )) )) );
				}
				
				if (( curbits > 0 )) {
					@out.b[pout++] = ((byte) (((int) (((byte) (@base.b[( ( buf << ( nbits - curbits ) ) & mask )]) )) )) );
				}
				
				return @out;
			}
		}
		
		
		public virtual void initTable() {
			unchecked {
				global::haxe.root.Array tbl = new global::haxe.root.Array();
				{
					int _g = 0;
					while (( _g < 256 )) {
						int i = _g++;
						int __temp_expr1 = ((int) (global::haxe.lang.Runtime.toInt(tbl.__set(i, -1))) );
					}
					
				}
				
				{
					int _g1 = 0;
					int _g2 = this.@base.length;
					while (( _g1 < _g2 )) {
						int i1 = _g1++;
						int __temp_expr2 = ((int) (global::haxe.lang.Runtime.toInt(tbl.__set(((int) (((byte) (this.@base.b[i1]) )) ), i1))) );
					}
					
				}
				
				this.tbl = tbl;
			}
		}
		
		
		public virtual global::haxe.io.Bytes decodeBytes(global::haxe.io.Bytes b) {
			unchecked {
				int nbits = this.nbits;
				global::haxe.io.Bytes @base = this.@base;
				if (( this.tbl == null )) {
					this.initTable();
				}
				
				global::haxe.root.Array tbl = this.tbl;
				int size = ( ( b.length * nbits ) >> 3 );
				global::haxe.io.Bytes @out = global::haxe.io.Bytes.alloc(size);
				int buf = 0;
				int curbits = 0;
				int pin = 0;
				int pout = 0;
				while (( pout < size )) {
					while (( curbits < 8 )) {
						curbits += nbits;
						buf <<= nbits;
						int i = ((int) (global::haxe.lang.Runtime.toInt(tbl.__get(((int) (((byte) (b.b[pin++]) )) )))) );
						if (( i == -1 )) {
							throw global::haxe.lang.HaxeException.wrap("BaseCode : invalid encoded char");
						}
						
						buf |= i;
					}
					
					curbits -= 8;
					@out.b[pout++] = ((byte) (( ( buf >> curbits ) & 255 )) );
				}
				
				return @out;
			}
		}
		
		
		public virtual string encodeString(string s) {
			return this.encodeBytes(global::haxe.io.Bytes.ofString(s, null)).toString();
		}
		
		
		public virtual string decodeString(string s) {
			return this.decodeBytes(global::haxe.io.Bytes.ofString(s, null)).toString();
		}
		
		
		public override double __hx_setField_f(string field, int hash, double @value, bool handleProperties) {
			unchecked {
				switch (hash) {
					case 388680308:
					{
						this.nbits = ((int) (@value) );
						return @value;
					}
					
					
					default:
					{
						return base.__hx_setField_f(field, hash, @value, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override object __hx_setField(string field, int hash, object @value, bool handleProperties) {
			unchecked {
				switch (hash) {
					case 5790526:
					{
						this.tbl = ((global::haxe.root.Array) (@value) );
						return @value;
					}
					
					
					case 388680308:
					{
						this.nbits = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 1091627025:
					{
						this.@base = ((global::haxe.io.Bytes) (@value) );
						return @value;
					}
					
					
					default:
					{
						return base.__hx_setField(field, hash, @value, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties) {
			unchecked {
				switch (hash) {
					case 1601245343:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "decodeString", 1601245343)) );
					}
					
					
					case 688014215:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "encodeString", 688014215)) );
					}
					
					
					case 95523933:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "decodeBytes", 95523933)) );
					}
					
					
					case 645255902:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "initTable", 645255902)) );
					}
					
					
					case 1227765365:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "encodeBytes", 1227765365)) );
					}
					
					
					case 5790526:
					{
						return this.tbl;
					}
					
					
					case 388680308:
					{
						return this.nbits;
					}
					
					
					case 1091627025:
					{
						return this.@base;
					}
					
					
					default:
					{
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override double __hx_getField_f(string field, int hash, bool throwErrors, bool handleProperties) {
			unchecked {
				switch (hash) {
					case 388680308:
					{
						return ((double) (this.nbits) );
					}
					
					
					default:
					{
						return base.__hx_getField_f(field, hash, throwErrors, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override object __hx_invokeField(string field, int hash, object[] dynargs) {
			unchecked {
				switch (hash) {
					case 1601245343:
					{
						return this.decodeString(global::haxe.lang.Runtime.toString(((object) (dynargs[0]) )));
					}
					
					
					case 688014215:
					{
						return this.encodeString(global::haxe.lang.Runtime.toString(((object) (dynargs[0]) )));
					}
					
					
					case 95523933:
					{
						return this.decodeBytes(((global::haxe.io.Bytes) (((object) (dynargs[0]) )) ));
					}
					
					
					case 645255902:
					{
						this.initTable();
						break;
					}
					
					
					case 1227765365:
					{
						return this.encodeBytes(((global::haxe.io.Bytes) (((object) (dynargs[0]) )) ));
					}
					
					
					default:
					{
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
				return null;
			}
		}
		
		
		public override void __hx_getFields(global::haxe.root.Array baseArr) {
			baseArr.push("tbl");
			baseArr.push("nbits");
			baseArr.push("base");
			base.__hx_getFields(baseArr);
		}
		
		
	}
}


