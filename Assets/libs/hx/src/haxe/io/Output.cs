// Generated by Haxe 4.1.0-rc.1+0d88c583b
using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.io {
	public class Output : global::haxe.lang.HxObject {
		
		public Output(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public Output() {
			#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
			global::haxe.io.Output.__hx_ctor_haxe_io_Output(this);
		}
		#line default
		
		protected static void __hx_ctor_haxe_io_Output(global::haxe.io.Output __hx_this) {
		}
		
		
		public bool bigEndian;
		
		public virtual void writeByte(int c) {
			#line 47 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
			throw global::haxe.lang.HaxeException.wrap("Not implemented");
		}
		#line default
		
		public virtual int writeBytes(global::haxe.io.Bytes s, int pos, int len) {
			#line 59 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
			if (( ( ( pos < 0 ) || ( len < 0 ) ) || ( ( pos + len ) > s.length ) )) {
				#line 60 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
				throw global::haxe.lang.HaxeException.wrap(global::haxe.io.Error.OutsideBounds);
			}
			
			#line 62 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
			byte[] b = s.b;
			int k = len;
			#line 64 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
			while (( k > 0 )) {
				#line 74 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
				this.writeByte(((int) (b[pos]) ));
				#line 76 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
				 ++ pos;
				 -- k;
			}
			
			#line 79 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
			return len;
		}
		#line default
		
		public virtual void flush() {
		}
		
		
		public virtual void close() {
		}
		
		
		public virtual bool set_bigEndian(bool b) {
			#line 95 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
			this.bigEndian = b;
			return b;
		}
		#line default
		
		public virtual void write(global::haxe.io.Bytes s) {
			#line 104 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
			int l = s.length;
			int p = 0;
			#line 106 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
			while (( l > 0 )) {
				#line 107 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
				int k = this.writeBytes(s, p, l);
				if (( k == 0 )) {
					#line 109 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
					throw global::haxe.lang.HaxeException.wrap(global::haxe.io.Error.Blocked);
				}
				
				#line 110 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
				p += k;
				l -= k;
			}
			
		}
		#line default
		
		public virtual void writeFullBytes(global::haxe.io.Bytes s, int pos, int len) {
			#line 121 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
			while (( len > 0 )) {
				#line 122 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
				int k = this.writeBytes(s, pos, len);
				pos += k;
				#line 124 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
				len -= k;
			}
			
		}
		#line default
		
		public virtual void writeFloat(double x) {
			#line 134 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
			this.writeInt32(global::haxe.io.FPHelper.floatToI32(x));
		}
		#line default
		
		public virtual void writeDouble(double x) {
			unchecked {
				#line 143 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
				long i64 = global::haxe.io.FPHelper.doubleToI64(x);
				if (this.bigEndian) {
					#line 145 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
					this.writeInt32(((int) (( ((long) (i64) ) >> 32 )) ));
					this.writeInt32(((int) (((long) (i64) )) ));
				}
				else {
					#line 148 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
					this.writeInt32(((int) (((long) (i64) )) ));
					this.writeInt32(((int) (( ((long) (i64) ) >> 32 )) ));
				}
				
			}
			#line default
		}
		
		
		public virtual void writeInt8(int x) {
			unchecked {
				#line 157 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
				if (( ( x < -128 ) || ( x >= 128 ) )) {
					#line 158 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
					throw global::haxe.lang.HaxeException.wrap(global::haxe.io.Error.Overflow);
				}
				
				#line 159 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
				this.writeByte(( x & 255 ));
			}
			#line default
		}
		
		
		public virtual void writeInt16(int x) {
			unchecked {
				#line 168 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
				if (( ( x < -32768 ) || ( x >= 32768 ) )) {
					#line 169 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
					throw global::haxe.lang.HaxeException.wrap(global::haxe.io.Error.Overflow);
				}
				
				#line 170 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
				this.writeUInt16(( x & 65535 ));
			}
			#line default
		}
		
		
		public virtual void writeUInt16(int x) {
			unchecked {
				#line 179 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
				if (( ( x < 0 ) || ( x >= 65536 ) )) {
					#line 180 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
					throw global::haxe.lang.HaxeException.wrap(global::haxe.io.Error.Overflow);
				}
				
				#line 181 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
				if (this.bigEndian) {
					#line 182 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
					this.writeByte(( x >> 8 ));
					this.writeByte(( x & 255 ));
				}
				else {
					#line 185 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
					this.writeByte(( x & 255 ));
					this.writeByte(( x >> 8 ));
				}
				
			}
			#line default
		}
		
		
		public virtual void writeInt24(int x) {
			unchecked {
				#line 196 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
				if (( ( x < -8388608 ) || ( x >= 8388608 ) )) {
					#line 197 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
					throw global::haxe.lang.HaxeException.wrap(global::haxe.io.Error.Overflow);
				}
				
				#line 198 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
				this.writeUInt24(( x & 16777215 ));
			}
			#line default
		}
		
		
		public virtual void writeUInt24(int x) {
			unchecked {
				#line 207 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
				if (( ( x < 0 ) || ( x >= 16777216 ) )) {
					#line 208 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
					throw global::haxe.lang.HaxeException.wrap(global::haxe.io.Error.Overflow);
				}
				
				#line 209 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
				if (this.bigEndian) {
					#line 210 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
					this.writeByte(( x >> 16 ));
					this.writeByte(( ( x >> 8 ) & 255 ));
					#line 212 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
					this.writeByte(( x & 255 ));
				}
				else {
					#line 214 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
					this.writeByte(( x & 255 ));
					this.writeByte(( ( x >> 8 ) & 255 ));
					#line 216 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
					this.writeByte(( x >> 16 ));
				}
				
			}
			#line default
		}
		
		
		public virtual void writeInt32(int x) {
			unchecked {
				#line 226 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
				if (this.bigEndian) {
					#line 227 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
					this.writeByte(((int) (( ((uint) (x) ) >> 24 )) ));
					this.writeByte(( ( x >> 16 ) & 255 ));
					#line 229 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
					this.writeByte(( ( x >> 8 ) & 255 ));
					this.writeByte(( x & 255 ));
				}
				else {
					#line 232 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
					this.writeByte(( x & 255 ));
					this.writeByte(( ( x >> 8 ) & 255 ));
					#line 234 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
					this.writeByte(( ( x >> 16 ) & 255 ));
					this.writeByte(((int) (( ((uint) (x) ) >> 24 )) ));
				}
				
			}
			#line default
		}
		
		
		public virtual void prepare(int nbytes) {
		}
		
		
		public virtual void writeInput(global::haxe.io.Input i, object bufsize) {
			unchecked {
				#line 255 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
				if (( bufsize == default(object) )) {
					#line 256 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
					bufsize = 4096;
				}
				
				#line 257 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
				global::haxe.io.Bytes buf = global::haxe.io.Bytes.alloc(((int) (global::haxe.lang.Runtime.toInt(bufsize)) ));
				#line 259 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
				try {
					#line 259 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
					while (true) {
						#line 260 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
						int len = i.readBytes(buf, 0, ((int) (global::haxe.lang.Runtime.toInt(bufsize)) ));
						if (( len == 0 )) {
							#line 262 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
							throw global::haxe.lang.HaxeException.wrap(global::haxe.io.Error.Blocked);
						}
						
						#line 263 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
						int p = 0;
						while (( len > 0 )) {
							#line 265 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
							int k = this.writeBytes(buf, p, len);
							if (( k == 0 )) {
								#line 267 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
								throw global::haxe.lang.HaxeException.wrap(global::haxe.io.Error.Blocked);
							}
							
							#line 268 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
							p += k;
							len -= k;
						}
						
					}
					
				}
				catch (global::System.Exception catchallException){
					#line 258 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
					global::haxe.lang.Exceptions.exception = catchallException;
					#line 272 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
					object realException = ( (( catchallException is global::haxe.lang.HaxeException )) ? (((global::haxe.lang.HaxeException) (catchallException) ).obj) : ((object) (catchallException) ) );
					#line 272 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
					if (( realException is global::haxe.io.Eof )) {
						#line 272 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
						global::haxe.io.Eof e = ((global::haxe.io.Eof) (realException) );
					}
					else {
						#line 272 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
						throw;
					}
					
				}
				
				
			}
			#line default
		}
		
		
		public virtual void writeString(string s, global::haxe.io.Encoding encoding) {
			#line 282 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
			global::haxe.io.Bytes b = global::haxe.io.Bytes.ofString(s, encoding);
			#line 284 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
			this.writeFullBytes(b, 0, b.length);
		}
		#line default
		
		public override object __hx_setField(string field, int hash, object @value, bool handleProperties) {
			unchecked {
				#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
				switch (hash) {
					case 542823803:
					{
						#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
						if (handleProperties) {
							#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
							this.set_bigEndian(global::haxe.lang.Runtime.toBool(@value));
							#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
							return @value;
						}
						else {
							#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
							this.bigEndian = global::haxe.lang.Runtime.toBool(@value);
							#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
							return @value;
						}
						
					}
					
					
					default:
					{
						#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
						return base.__hx_setField(field, hash, @value, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties) {
			unchecked {
				#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
				switch (hash) {
					case 640252688:
					{
						#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "writeString", 640252688)) );
					}
					
					
					case 1390395051:
					{
						#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "writeInput", 1390395051)) );
					}
					
					
					case 937267591:
					{
						#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "prepare", 937267591)) );
					}
					
					
					case 1390579183:
					{
						#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "writeInt32", 1390579183)) );
					}
					
					
					case 772312059:
					{
						#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "writeUInt24", 772312059)) );
					}
					
					
					case 1390578962:
					{
						#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "writeInt24", 1390578962)) );
					}
					
					
					case 772311838:
					{
						#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "writeUInt16", 772311838)) );
					}
					
					
					case 1390578741:
					{
						#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "writeInt16", 1390578741)) );
					}
					
					
					case 1315911912:
					{
						#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "writeInt8", 1315911912)) );
					}
					
					
					case 1204059472:
					{
						#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "writeDouble", 1204059472)) );
					}
					
					
					case 391692349:
					{
						#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "writeFloat", 391692349)) );
					}
					
					
					case 610723709:
					{
						#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "writeFullBytes", 610723709)) );
					}
					
					
					case 1348037855:
					{
						#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "write", 1348037855)) );
					}
					
					
					case 650414942:
					{
						#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "set_bigEndian", 650414942)) );
					}
					
					
					case 1214453688:
					{
						#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "close", 1214453688)) );
					}
					
					
					case 43737796:
					{
						#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "flush", 43737796)) );
					}
					
					
					case 1381630732:
					{
						#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "writeBytes", 1381630732)) );
					}
					
					
					case 1238832007:
					{
						#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "writeByte", 1238832007)) );
					}
					
					
					case 542823803:
					{
						#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
						return this.bigEndian;
					}
					
					
					default:
					{
						#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_invokeField(string field, int hash, object[] dynargs) {
			unchecked {
				#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
				switch (hash) {
					case 640252688:
					{
						#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
						this.writeString(global::haxe.lang.Runtime.toString(((object) (dynargs[0]) )), ((global::haxe.io.Encoding) (((object) (dynargs[1]) )) ));
						#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
						break;
					}
					
					
					case 1390395051:
					{
						#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
						this.writeInput(((global::haxe.io.Input) (((object) (dynargs[0]) )) ), ((object) (dynargs[1]) ));
						#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
						break;
					}
					
					
					case 937267591:
					{
						#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
						this.prepare(((int) (global::haxe.lang.Runtime.toInt(((object) (dynargs[0]) ))) ));
						#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
						break;
					}
					
					
					case 1390579183:
					{
						#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
						this.writeInt32(((int) (global::haxe.lang.Runtime.toInt(((object) (dynargs[0]) ))) ));
						#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
						break;
					}
					
					
					case 772312059:
					{
						#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
						this.writeUInt24(((int) (global::haxe.lang.Runtime.toInt(((object) (dynargs[0]) ))) ));
						#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
						break;
					}
					
					
					case 1390578962:
					{
						#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
						this.writeInt24(((int) (global::haxe.lang.Runtime.toInt(((object) (dynargs[0]) ))) ));
						#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
						break;
					}
					
					
					case 772311838:
					{
						#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
						this.writeUInt16(((int) (global::haxe.lang.Runtime.toInt(((object) (dynargs[0]) ))) ));
						#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
						break;
					}
					
					
					case 1390578741:
					{
						#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
						this.writeInt16(((int) (global::haxe.lang.Runtime.toInt(((object) (dynargs[0]) ))) ));
						#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
						break;
					}
					
					
					case 1315911912:
					{
						#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
						this.writeInt8(((int) (global::haxe.lang.Runtime.toInt(((object) (dynargs[0]) ))) ));
						#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
						break;
					}
					
					
					case 1204059472:
					{
						#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
						this.writeDouble(((double) (global::haxe.lang.Runtime.toDouble(((object) (dynargs[0]) ))) ));
						#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
						break;
					}
					
					
					case 391692349:
					{
						#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
						this.writeFloat(((double) (global::haxe.lang.Runtime.toDouble(((object) (dynargs[0]) ))) ));
						#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
						break;
					}
					
					
					case 610723709:
					{
						#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
						this.writeFullBytes(((global::haxe.io.Bytes) (((object) (dynargs[0]) )) ), ((int) (global::haxe.lang.Runtime.toInt(((object) (dynargs[1]) ))) ), ((int) (global::haxe.lang.Runtime.toInt(((object) (dynargs[2]) ))) ));
						#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
						break;
					}
					
					
					case 1348037855:
					{
						#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
						this.write(((global::haxe.io.Bytes) (((object) (dynargs[0]) )) ));
						#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
						break;
					}
					
					
					case 650414942:
					{
						#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
						return this.set_bigEndian(global::haxe.lang.Runtime.toBool(((object) (dynargs[0]) )));
					}
					
					
					case 1214453688:
					{
						#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
						this.close();
						#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
						break;
					}
					
					
					case 43737796:
					{
						#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
						this.flush();
						#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
						break;
					}
					
					
					case 1381630732:
					{
						#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
						return this.writeBytes(((global::haxe.io.Bytes) (((object) (dynargs[0]) )) ), ((int) (global::haxe.lang.Runtime.toInt(((object) (dynargs[1]) ))) ), ((int) (global::haxe.lang.Runtime.toInt(((object) (dynargs[2]) ))) ));
					}
					
					
					case 1238832007:
					{
						#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
						this.writeByte(((int) (global::haxe.lang.Runtime.toInt(((object) (dynargs[0]) ))) ));
						#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
						break;
					}
					
					
					default:
					{
						#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
				#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
				return null;
			}
			#line default
		}
		
		
		public override void __hx_getFields(global::haxe.root.Array baseArr) {
			#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
			baseArr.push("bigEndian");
			#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
			base.__hx_getFields(baseArr);
		}
		#line default
		
	}
}


