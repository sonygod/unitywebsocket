// Generated by Haxe 4.1.0-rc.1+0d88c583b
using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.io {
	public class BytesBuffer : global::haxe.lang.HxObject {
		
		public BytesBuffer(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public BytesBuffer() {
			#line 45 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\BytesBuffer.hx"
			global::haxe.io.BytesBuffer.__hx_ctor_haxe_io_BytesBuffer(this);
		}
		#line default
		
		protected static void __hx_ctor_haxe_io_BytesBuffer(global::haxe.io.BytesBuffer __hx_this) {
			#line 54 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\BytesBuffer.hx"
			__hx_this.b = new global::System.IO.MemoryStream();
		}
		#line default
		
		public global::System.IO.MemoryStream b;
		
		
		
		public int get_length() {
			unchecked {
				#line 68 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\BytesBuffer.hx"
				long x = ( this.b as global::System.IO.Stream ).Length;
				#line 68 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\BytesBuffer.hx"
				if (( ((bool) (( ((long) (x) ) < -2147483648 )) ) || ((bool) (( ((long) (x) ) > 2147483647 )) ) )) {
					#line 68 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\BytesBuffer.hx"
					throw global::haxe.lang.HaxeException.wrap("Overflow");
				}
				
				#line 68 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\BytesBuffer.hx"
				return ((int) (((long) (x) )) );
			}
			#line default
		}
		
		
		public void addByte(int @byte) {
			#line 84 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\BytesBuffer.hx"
			( this.b as global::System.IO.Stream ).WriteByte(((byte) (@byte) ));
		}
		#line default
		
		public void @add(global::haxe.io.Bytes src) {
			#line 100 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\BytesBuffer.hx"
			( this.b as global::System.IO.Stream ).Write(((byte[]) (src.b) ), ((int) (0) ), ((int) (src.length) ));
		}
		#line default
		
		public void addString(string v, global::haxe.io.Encoding encoding) {
			#line 129 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\BytesBuffer.hx"
			global::haxe.io.Bytes src = global::haxe.io.Bytes.ofString(v, encoding);
			#line 129 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\BytesBuffer.hx"
			( this.b as global::System.IO.Stream ).Write(((byte[]) (src.b) ), ((int) (0) ), ((int) (src.length) ));
		}
		#line default
		
		public virtual void addInt32(int v) {
			unchecked {
				#line 137 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\BytesBuffer.hx"
				( this.b as global::System.IO.Stream ).WriteByte(((byte) (( v & 255 )) ));
				( this.b as global::System.IO.Stream ).WriteByte(((byte) (( ( v >> 8 ) & 255 )) ));
				#line 139 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\BytesBuffer.hx"
				( this.b as global::System.IO.Stream ).WriteByte(((byte) (( ( v >> 16 ) & 255 )) ));
				( this.b as global::System.IO.Stream ).WriteByte(((byte) (((int) (( ((uint) (v) ) >> 24 )) )) ));
			}
			#line default
		}
		
		
		public virtual void addInt64(long v) {
			unchecked {
				#line 145 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\BytesBuffer.hx"
				this.addInt32(((int) (((long) (v) )) ));
				this.addInt32(((int) (( ((long) (v) ) >> 32 )) ));
			}
			#line default
		}
		
		
		public void addFloat(double v) {
			#line 153 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\BytesBuffer.hx"
			this.addInt32(global::haxe.io.FPHelper.floatToI32(v));
		}
		#line default
		
		public void addDouble(double v) {
			#line 161 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\BytesBuffer.hx"
			this.addInt64(global::haxe.io.FPHelper.doubleToI64(v));
		}
		#line default
		
		public void addBytes(global::haxe.io.Bytes src, int pos, int len) {
			#line 167 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\BytesBuffer.hx"
			if (( ( ( pos < 0 ) || ( len < 0 ) ) || ( ( pos + len ) > src.length ) )) {
				#line 168 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\BytesBuffer.hx"
				throw global::haxe.lang.HaxeException.wrap(global::haxe.io.Error.OutsideBounds);
			}
			
			#line 179 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\BytesBuffer.hx"
			( this.b as global::System.IO.Stream ).Write(((byte[]) (src.b) ), ((int) (pos) ), ((int) (len) ));
		}
		#line default
		
		public virtual global::haxe.io.Bytes getBytes() {
			#line 210 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\BytesBuffer.hx"
			byte[] buf = this.b.GetBuffer();
			global::haxe.io.Bytes bytes = new global::haxe.io.Bytes(((int) (( this.b as global::System.IO.Stream ).Length) ), buf);
			#line 222 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\BytesBuffer.hx"
			this.b = null;
			return bytes;
		}
		#line default
		
		public override object __hx_setField(string field, int hash, object @value, bool handleProperties) {
			unchecked {
				#line 25 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\BytesBuffer.hx"
				switch (hash) {
					case 98:
					{
						#line 25 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\BytesBuffer.hx"
						this.b = ((global::System.IO.MemoryStream) (@value) );
						#line 25 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\BytesBuffer.hx"
						return @value;
					}
					
					
					default:
					{
						#line 25 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\BytesBuffer.hx"
						return base.__hx_setField(field, hash, @value, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties) {
			unchecked {
				#line 25 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\BytesBuffer.hx"
				switch (hash) {
					case 493819893:
					{
						#line 25 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\BytesBuffer.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "getBytes", 493819893)) );
					}
					
					
					case 922037898:
					{
						#line 25 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\BytesBuffer.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "addBytes", 922037898)) );
					}
					
					
					case 1794072594:
					{
						#line 25 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\BytesBuffer.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "addDouble", 1794072594)) );
					}
					
					
					case 2079583163:
					{
						#line 25 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\BytesBuffer.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "addFloat", 2079583163)) );
					}
					
					
					case 930987020:
					{
						#line 25 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\BytesBuffer.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "addInt64", 930987020)) );
					}
					
					
					case 930986349:
					{
						#line 25 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\BytesBuffer.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "addInt32", 930986349)) );
					}
					
					
					case 1230265810:
					{
						#line 25 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\BytesBuffer.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "addString", 1230265810)) );
					}
					
					
					case 4846113:
					{
						#line 25 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\BytesBuffer.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "add", 4846113)) );
					}
					
					
					case 2103468489:
					{
						#line 25 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\BytesBuffer.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "addByte", 2103468489)) );
					}
					
					
					case 261031087:
					{
						#line 25 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\BytesBuffer.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "get_length", 261031087)) );
					}
					
					
					case 520590566:
					{
						#line 25 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\BytesBuffer.hx"
						return this.get_length();
					}
					
					
					case 98:
					{
						#line 25 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\BytesBuffer.hx"
						return this.b;
					}
					
					
					default:
					{
						#line 25 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\BytesBuffer.hx"
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override double __hx_getField_f(string field, int hash, bool throwErrors, bool handleProperties) {
			unchecked {
				#line 25 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\BytesBuffer.hx"
				switch (hash) {
					case 520590566:
					{
						#line 25 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\BytesBuffer.hx"
						return ((double) (this.get_length()) );
					}
					
					
					default:
					{
						#line 25 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\BytesBuffer.hx"
						return base.__hx_getField_f(field, hash, throwErrors, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_invokeField(string field, int hash, object[] dynargs) {
			unchecked {
				#line 25 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\BytesBuffer.hx"
				switch (hash) {
					case 493819893:
					{
						#line 25 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\BytesBuffer.hx"
						return this.getBytes();
					}
					
					
					case 922037898:
					{
						#line 25 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\BytesBuffer.hx"
						this.addBytes(((global::haxe.io.Bytes) (((object) (dynargs[0]) )) ), ((int) (global::haxe.lang.Runtime.toInt(((object) (dynargs[1]) ))) ), ((int) (global::haxe.lang.Runtime.toInt(((object) (dynargs[2]) ))) ));
						#line 25 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\BytesBuffer.hx"
						break;
					}
					
					
					case 1794072594:
					{
						#line 25 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\BytesBuffer.hx"
						this.addDouble(((double) (global::haxe.lang.Runtime.toDouble(((object) (dynargs[0]) ))) ));
						#line 25 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\BytesBuffer.hx"
						break;
					}
					
					
					case 2079583163:
					{
						#line 25 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\BytesBuffer.hx"
						this.addFloat(((double) (global::haxe.lang.Runtime.toDouble(((object) (dynargs[0]) ))) ));
						#line 25 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\BytesBuffer.hx"
						break;
					}
					
					
					case 930987020:
					{
						#line 25 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\BytesBuffer.hx"
						this.addInt64(global::haxe.lang.Runtime.toLong(((object) (dynargs[0]) )));
						#line 25 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\BytesBuffer.hx"
						break;
					}
					
					
					case 930986349:
					{
						#line 25 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\BytesBuffer.hx"
						this.addInt32(((int) (global::haxe.lang.Runtime.toInt(((object) (dynargs[0]) ))) ));
						#line 25 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\BytesBuffer.hx"
						break;
					}
					
					
					case 1230265810:
					{
						#line 25 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\BytesBuffer.hx"
						this.addString(global::haxe.lang.Runtime.toString(((object) (dynargs[0]) )), ((global::haxe.io.Encoding) (((object) (dynargs[1]) )) ));
						#line 25 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\BytesBuffer.hx"
						break;
					}
					
					
					case 4846113:
					{
						#line 25 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\BytesBuffer.hx"
						this.@add(((global::haxe.io.Bytes) (((object) (dynargs[0]) )) ));
						#line 25 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\BytesBuffer.hx"
						break;
					}
					
					
					case 2103468489:
					{
						#line 25 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\BytesBuffer.hx"
						this.addByte(((int) (global::haxe.lang.Runtime.toInt(((object) (dynargs[0]) ))) ));
						#line 25 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\BytesBuffer.hx"
						break;
					}
					
					
					case 261031087:
					{
						#line 25 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\BytesBuffer.hx"
						return this.get_length();
					}
					
					
					default:
					{
						#line 25 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\BytesBuffer.hx"
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
				#line 25 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\BytesBuffer.hx"
				return null;
			}
			#line default
		}
		
		
		public override void __hx_getFields(global::haxe.root.Array baseArr) {
			#line 25 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\BytesBuffer.hx"
			baseArr.push("length");
			#line 25 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\BytesBuffer.hx"
			baseArr.push("b");
			#line 25 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\BytesBuffer.hx"
			base.__hx_getFields(baseArr);
		}
		#line default
		
	}
}


