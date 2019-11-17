// Generated by Haxe 4.0.2+606b176a3
using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.io {
	public class Input : global::haxe.lang.HxObject {
		
		public Input(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public Input() {
			#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
			global::haxe.io.Input.__hx_ctor_haxe_io_Input(this);
		}
		#line default
		
		protected static void __hx_ctor_haxe_io_Input(global::haxe.io.Input __hx_this) {
		}
		
		
		public bool bigEndian;
		
		public byte[] helper;
		
		public virtual int readByte() {
			#line 53 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
			throw global::haxe.lang.HaxeException.wrap("Not implemented");
		}
		#line default
		
		public virtual int readBytes(global::haxe.io.Bytes s, int pos, int len) {
			#line 65 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
			int k = len;
			byte[] b = s.b;
			#line 67 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
			if (( ( ( pos < 0 ) || ( len < 0 ) ) || ( ( pos + len ) > s.length ) )) {
				#line 68 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
				throw global::haxe.lang.HaxeException.wrap(global::haxe.io.Error.OutsideBounds);
			}
			
			#line 70 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
			try {
				#line 70 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
				while (( k > 0 )) {
					#line 78 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
					b[pos] = ((byte) (this.readByte()) );
					#line 80 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
					 ++ pos;
					 -- k;
				}
				
			}
			catch (global::System.Exception catchallException){
				#line 69 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
				global::haxe.lang.Exceptions.exception = catchallException;
				#line 83 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
				object realException = ( (( catchallException is global::haxe.lang.HaxeException )) ? (((global::haxe.lang.HaxeException) (catchallException) ).obj) : ((object) (catchallException) ) );
				#line 83 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
				if (( realException is global::haxe.io.Eof )) {
					#line 83 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
					global::haxe.io.Eof eof = ((global::haxe.io.Eof) (realException) );
				}
				else {
					#line 83 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
					throw;
				}
				
			}
			
			
			#line 84 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
			return ( len - k );
		}
		#line default
		
		public virtual void close() {
		}
		
		
		public virtual bool set_bigEndian(bool b) {
			#line 95 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
			this.bigEndian = b;
			return b;
		}
		#line default
		
		public virtual global::haxe.io.Bytes readAll(object bufsize) {
			unchecked {
				#line 107 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
				if (( bufsize == default(object) )) {
					#line 111 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
					bufsize = 16384;
				}
				
				#line 114 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
				global::haxe.io.Bytes buf = global::haxe.io.Bytes.alloc(((int) (global::haxe.lang.Runtime.toInt(bufsize)) ));
				global::haxe.io.BytesBuffer total = new global::haxe.io.BytesBuffer();
				#line 117 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
				try {
					#line 117 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
					while (true) {
						#line 118 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
						int len = this.readBytes(buf, 0, ((int) (global::haxe.lang.Runtime.toInt(bufsize)) ));
						if (( len == 0 )) {
							#line 120 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
							throw global::haxe.lang.HaxeException.wrap(global::haxe.io.Error.Blocked);
						}
						
						#line 121 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
						{
							#line 121 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
							if (( ( len < 0 ) || ( len > buf.length ) )) {
								#line 121 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
								throw global::haxe.lang.HaxeException.wrap(global::haxe.io.Error.OutsideBounds);
							}
							
							#line 121 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
							( total.b as global::System.IO.Stream ).Write(((byte[]) (buf.b) ), ((int) (0) ), ((int) (len) ));
						}
						
					}
					
				}
				catch (global::System.Exception catchallException){
					#line 116 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
					global::haxe.lang.Exceptions.exception = catchallException;
					#line 123 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
					object realException = ( (( catchallException is global::haxe.lang.HaxeException )) ? (((global::haxe.lang.HaxeException) (catchallException) ).obj) : ((object) (catchallException) ) );
					#line 123 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
					if (( realException is global::haxe.io.Eof )) {
						#line 123 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
						global::haxe.io.Eof e = ((global::haxe.io.Eof) (realException) );
					}
					else {
						#line 123 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
						throw;
					}
					
				}
				
				
				#line 124 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
				return total.getBytes();
			}
			#line default
		}
		
		
		public virtual void readFullBytes(global::haxe.io.Bytes s, int pos, int len) {
			#line 133 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
			while (( len > 0 )) {
				#line 134 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
				int k = this.readBytes(s, pos, len);
				if (( k == 0 )) {
					#line 136 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
					throw global::haxe.lang.HaxeException.wrap(global::haxe.io.Error.Blocked);
				}
				
				#line 137 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
				pos += k;
				len -= k;
			}
			
		}
		#line default
		
		public virtual global::haxe.io.Bytes read(int nbytes) {
			#line 146 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
			global::haxe.io.Bytes s = global::haxe.io.Bytes.alloc(nbytes);
			int p = 0;
			#line 148 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
			while (( nbytes > 0 )) {
				#line 149 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
				int k = this.readBytes(s, p, nbytes);
				if (( k == 0 )) {
					#line 151 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
					throw global::haxe.lang.HaxeException.wrap(global::haxe.io.Error.Blocked);
				}
				
				#line 152 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
				p += k;
				nbytes -= k;
			}
			
			#line 155 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
			return s;
		}
		#line default
		
		public virtual string readUntil(int end) {
			#line 164 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
			global::haxe.io.BytesBuffer buf = new global::haxe.io.BytesBuffer();
			int last = default(int);
			#line 166 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
			while (true) {
				#line 166 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
				last = this.readByte();
				#line 166 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
				if ( ! ((( last != end ))) ) {
					#line 166 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
					break;
				}
				
				#line 167 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
				( buf.b as global::System.IO.Stream ).WriteByte(((byte) (last) ));
			}
			
			#line 168 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
			return buf.getBytes().toString();
		}
		#line default
		
		public virtual string readLine() {
			unchecked {
				#line 177 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
				global::haxe.io.BytesBuffer buf = new global::haxe.io.BytesBuffer();
				int last = default(int);
				#line 179 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
				string s = null;
				try {
					#line 181 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
					while (true) {
						#line 181 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
						last = this.readByte();
						#line 181 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
						if ( ! ((( last != 10 ))) ) {
							#line 181 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
							break;
						}
						
						#line 182 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
						( buf.b as global::System.IO.Stream ).WriteByte(((byte) (last) ));
					}
					
					#line 183 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
					s = buf.getBytes().toString();
					if (global::haxe.lang.Runtime.eq(global::haxe.lang.StringExt.charCodeAt(s, ( s.Length - 1 )), 13)) {
						#line 185 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
						s = global::haxe.lang.StringExt.substr(s, 0, -1);
					}
					
				}
				catch (global::System.Exception catchallException){
					#line 180 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
					global::haxe.lang.Exceptions.exception = catchallException;
					#line 186 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
					object realException = ( (( catchallException is global::haxe.lang.HaxeException )) ? (((global::haxe.lang.HaxeException) (catchallException) ).obj) : ((object) (catchallException) ) );
					#line 186 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
					if (( realException is global::haxe.io.Eof )) {
						#line 186 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
						global::haxe.io.Eof e = ((global::haxe.io.Eof) (realException) );
						#line 186 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
						{
							#line 187 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
							s = buf.getBytes().toString();
							if (( s.Length == 0 )) {
								#line 189 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
								throw global::haxe.lang.HaxeException.wrap(e);
							}
							
						}
						
					}
					else {
						#line 186 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
						throw;
					}
					
				}
				
				
				#line 191 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
				return s;
			}
			#line default
		}
		
		
		public virtual double readFloat() {
			#line 200 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
			return global::haxe.io.FPHelper.i32ToFloat(this.readInt32());
		}
		#line default
		
		public virtual double readDouble() {
			#line 209 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
			int i1 = this.readInt32();
			int i2 = this.readInt32();
			#line 211 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
			if (this.bigEndian) {
				#line 211 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
				return global::haxe.io.FPHelper.i64ToDouble(i2, i1);
			}
			else {
				#line 211 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
				return global::haxe.io.FPHelper.i64ToDouble(i1, i2);
			}
			
		}
		#line default
		
		public virtual int readInt8() {
			unchecked {
				#line 218 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
				int n = this.readByte();
				if (( n >= 128 )) {
					#line 220 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
					return ( n - 256 );
				}
				
				#line 221 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
				return n;
			}
			#line default
		}
		
		
		public virtual int readInt16() {
			unchecked {
				#line 230 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
				int ch1 = this.readByte();
				int ch2 = this.readByte();
				#line 232 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
				int n = ( (this.bigEndian) ? (( ch2 | ( ch1 << 8 ) )) : (( ch1 | ( ch2 << 8 ) )) );
				if (( (( n & 32768 )) != 0 )) {
					#line 234 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
					return ( n - 65536 );
				}
				
				#line 235 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
				return n;
			}
			#line default
		}
		
		
		public virtual int readUInt16() {
			unchecked {
				#line 244 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
				int ch1 = this.readByte();
				int ch2 = this.readByte();
				#line 246 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
				if (this.bigEndian) {
					#line 246 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
					return ( ch2 | ( ch1 << 8 ) );
				}
				else {
					#line 246 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
					return ( ch1 | ( ch2 << 8 ) );
				}
				
			}
			#line default
		}
		
		
		public virtual int readInt24() {
			unchecked {
				#line 255 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
				int ch1 = this.readByte();
				int ch2 = this.readByte();
				#line 257 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
				int ch3 = this.readByte();
				int n = ( (this.bigEndian) ? (( ( ch3 | ( ch2 << 8 ) ) | ( ch1 << 16 ) )) : (( ( ch1 | ( ch2 << 8 ) ) | ( ch3 << 16 ) )) );
				#line 259 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
				if (( (( n & 8388608 )) != 0 )) {
					#line 260 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
					return ( n - 16777216 );
				}
				
				#line 261 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
				return n;
			}
			#line default
		}
		
		
		public virtual int readUInt24() {
			unchecked {
				#line 270 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
				int ch1 = this.readByte();
				int ch2 = this.readByte();
				#line 272 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
				int ch3 = this.readByte();
				if (this.bigEndian) {
					#line 273 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
					return ( ( ch3 | ( ch2 << 8 ) ) | ( ch1 << 16 ) );
				}
				else {
					#line 273 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
					return ( ( ch1 | ( ch2 << 8 ) ) | ( ch3 << 16 ) );
				}
				
			}
			#line default
		}
		
		
		public virtual int readInt32() {
			unchecked {
				#line 282 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
				int ch1 = this.readByte();
				int ch2 = this.readByte();
				#line 284 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
				int ch3 = this.readByte();
				int ch4 = this.readByte();
				#line 297 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
				if (this.bigEndian) {
					#line 297 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
					return ( ( ( ch4 | ( ch3 << 8 ) ) | ( ch2 << 16 ) ) | ( ch1 << 24 ) );
				}
				else {
					#line 297 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
					return ( ( ( ch1 | ( ch2 << 8 ) ) | ( ch3 << 16 ) ) | ( ch4 << 24 ) );
				}
				
			}
			#line default
		}
		
		
		public virtual string readString(int len, global::haxe.io.Encoding encoding) {
			#line 305 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
			global::haxe.io.Bytes b = global::haxe.io.Bytes.alloc(len);
			this.readFullBytes(b, 0, len);
			#line 310 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
			return b.getString(0, len, encoding);
		}
		#line default
		
		public override object __hx_setField(string field, int hash, object @value, bool handleProperties) {
			unchecked {
				#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
				switch (hash) {
					case 72252782:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
						this.helper = ((byte[]) (@value) );
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
						return @value;
					}
					
					
					case 542823803:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
						if (handleProperties) {
							#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
							this.set_bigEndian(global::haxe.lang.Runtime.toBool(@value));
							#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
							return @value;
						}
						else {
							#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
							this.bigEndian = global::haxe.lang.Runtime.toBool(@value);
							#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
							return @value;
						}
						
					}
					
					
					default:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
						return base.__hx_setField(field, hash, @value, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties) {
			unchecked {
				#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
				switch (hash) {
					case 179047623:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "readString", 179047623)) );
					}
					
					
					case 252174360:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "readInt32", 252174360)) );
					}
					
					
					case 311106994:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "readUInt24", 311106994)) );
					}
					
					
					case 252174139:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "readInt24", 252174139)) );
					}
					
					
					case 311106773:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "readUInt16", 311106773)) );
					}
					
					
					case 252173918:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "readInt16", 252173918)) );
					}
					
					
					case 1840455391:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "readInt8", 1840455391)) );
					}
					
					
					case 742854407:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "readDouble", 742854407)) );
					}
					
					
					case 1400771174:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "readFloat", 1400771174)) );
					}
					
					
					case 1873474154:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "readLine", 1873474154)) );
					}
					
					
					case 2010580328:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "readUntil", 2010580328)) );
					}
					
					
					case 1269254998:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "read", 1269254998)) );
					}
					
					
					case 1309344294:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "readFullBytes", 1309344294)) );
					}
					
					
					case 46374763:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "readAll", 46374763)) );
					}
					
					
					case 650414942:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "set_bigEndian", 650414942)) );
					}
					
					
					case 1214453688:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "close", 1214453688)) );
					}
					
					
					case 243225909:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "readBytes", 243225909)) );
					}
					
					
					case 1763375486:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "readByte", 1763375486)) );
					}
					
					
					case 72252782:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
						return this.helper;
					}
					
					
					case 542823803:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
						return this.bigEndian;
					}
					
					
					default:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_invokeField(string field, int hash, object[] dynargs) {
			unchecked {
				#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
				switch (hash) {
					case 179047623:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
						return this.readString(((int) (global::haxe.lang.Runtime.toInt(((object) (dynargs[0]) ))) ), ((global::haxe.io.Encoding) (((object) (dynargs[1]) )) ));
					}
					
					
					case 252174360:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
						return this.readInt32();
					}
					
					
					case 311106994:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
						return this.readUInt24();
					}
					
					
					case 252174139:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
						return this.readInt24();
					}
					
					
					case 311106773:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
						return this.readUInt16();
					}
					
					
					case 252173918:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
						return this.readInt16();
					}
					
					
					case 1840455391:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
						return this.readInt8();
					}
					
					
					case 742854407:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
						return this.readDouble();
					}
					
					
					case 1400771174:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
						return this.readFloat();
					}
					
					
					case 1873474154:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
						return this.readLine();
					}
					
					
					case 2010580328:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
						return this.readUntil(((int) (global::haxe.lang.Runtime.toInt(((object) (dynargs[0]) ))) ));
					}
					
					
					case 1269254998:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
						return this.read(((int) (global::haxe.lang.Runtime.toInt(((object) (dynargs[0]) ))) ));
					}
					
					
					case 1309344294:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
						this.readFullBytes(((global::haxe.io.Bytes) (((object) (dynargs[0]) )) ), ((int) (global::haxe.lang.Runtime.toInt(((object) (dynargs[1]) ))) ), ((int) (global::haxe.lang.Runtime.toInt(((object) (dynargs[2]) ))) ));
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
						break;
					}
					
					
					case 46374763:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
						return this.readAll(((object) (dynargs[0]) ));
					}
					
					
					case 650414942:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
						return this.set_bigEndian(global::haxe.lang.Runtime.toBool(((object) (dynargs[0]) )));
					}
					
					
					case 1214453688:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
						this.close();
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
						break;
					}
					
					
					case 243225909:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
						return this.readBytes(((global::haxe.io.Bytes) (((object) (dynargs[0]) )) ), ((int) (global::haxe.lang.Runtime.toInt(((object) (dynargs[1]) ))) ), ((int) (global::haxe.lang.Runtime.toInt(((object) (dynargs[2]) ))) ));
					}
					
					
					case 1763375486:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
						return this.readByte();
					}
					
					
					default:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
				#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
				return null;
			}
			#line default
		}
		
		
		public override void __hx_getFields(global::haxe.root.Array baseArr) {
			#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
			baseArr.push("helper");
			#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
			baseArr.push("bigEndian");
			#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
			base.__hx_getFields(baseArr);
		}
		#line default
		
	}
}


