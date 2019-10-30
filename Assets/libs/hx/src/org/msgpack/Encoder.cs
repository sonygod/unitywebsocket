// Generated by Haxe 4.0.0+ef18b627e
using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace org.msgpack {
	public class Encoder : global::haxe.lang.HxObject {
		
		static Encoder() {
			#line 16 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
			global::org.msgpack.Encoder.FLOAT_SINGLE_MIN = 1.40129846432481707e-45;
			global::org.msgpack.Encoder.FLOAT_SINGLE_MAX = 3.40282346638528860e+38;
			#line 19 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
			global::org.msgpack.Encoder.FLOAT_DOUBLE_MIN = 4.94065645841246544e-324;
			global::org.msgpack.Encoder.FLOAT_DOUBLE_MAX = 1.79769313486231570e+308;
		}
		#line default
		
		public Encoder(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public Encoder(object d) {
			#line 24 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
			global::org.msgpack.Encoder.__hx_ctor_org_msgpack_Encoder(this, d);
		}
		#line default
		
		protected static void __hx_ctor_org_msgpack_Encoder(global::org.msgpack.Encoder __hx_this, object d) {
			#line 25 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
			__hx_this.o = new global::haxe.io.BytesOutput();
			__hx_this.o.set_bigEndian(true);
			#line 28 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
			__hx_this.encode(d);
		}
		#line default
		
		public static double FLOAT_SINGLE_MIN;
		
		public static double FLOAT_SINGLE_MAX;
		
		public static double FLOAT_DOUBLE_MIN;
		
		public static double FLOAT_DOUBLE_MAX;
		
		public global::haxe.io.BytesOutput o;
		
		public virtual void encode(object d) {
			unchecked {
				#line 33 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
				global::haxe.root.ValueType _g = global::haxe.root.Type.@typeof(d);
				#line 33 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
				switch (_g._hx_index) {
					case 0:
					{
						#line 35 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
						this.o.writeByte(192);
						#line 35 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
						break;
					}
					
					
					case 1:
					{
						#line 39 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
						int d1 = ((int) (global::haxe.lang.Runtime.toInt(d)) );
						#line 39 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
						if (( d1 < -32 )) {
							#line 39 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
							if (( d1 < -32768 )) {
								#line 39 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
								this.o.writeByte(210);
								#line 39 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
								this.o.writeInt32(d1);
							}
							else if (( d1 < -128 )) {
								#line 39 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
								this.o.writeByte(209);
								#line 39 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
								this.o.writeInt16(d1);
							}
							else {
								#line 39 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
								this.o.writeByte(208);
								#line 39 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
								this.o.writeInt8(d1);
							}
							
						}
						else if (( d1 < 128 )) {
							#line 39 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
							this.o.writeByte(( d1 & 255 ));
						}
						else if (( d1 < 256 )) {
							#line 39 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
							this.o.writeByte(204);
							#line 39 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
							this.o.writeByte(d1);
						}
						else if (( d1 < 65536 )) {
							#line 39 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
							this.o.writeByte(205);
							#line 39 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
							this.o.writeUInt16(d1);
						}
						else {
							#line 39 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
							this.o.writeByte(206);
							#line 39 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
							global::haxe.io.BytesOutput buf2 = new global::haxe.io.BytesOutput();
							#line 39 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
							global::binary128.@internal.Leb128.writeUint32(buf2, ((uint) (d1) ));
						}
						
						#line 39 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
						break;
					}
					
					
					case 2:
					{
						#line 41 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
						double d2 = ((double) (global::haxe.lang.Runtime.toDouble(d)) );
						#line 41 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
						double a = global::System.Math.Abs(((double) (d2) ));
						#line 41 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
						if (( ( a > 1.40129846432481707e-45 ) && ( a < 3.40282346638528860e+38 ) )) {
							#line 41 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
							this.o.writeByte(202);
							#line 41 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
							this.o.writeFloat(d2);
						}
						else {
							#line 41 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
							this.o.writeByte(203);
							#line 41 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
							this.o.writeDouble(d2);
						}
						
						#line 41 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
						break;
					}
					
					
					case 3:
					{
						#line 37 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
						this.o.writeByte(( (global::haxe.lang.Runtime.toBool((d))) ? (195) : (194) ));
						#line 37 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
						break;
					}
					
					
					case 4:
					{
						#line 60 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
						global::haxe.root.Array f = global::haxe.root.Reflect.fields(d);
						#line 60 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
						{
							#line 60 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
							int length = global::haxe.root.Lambda.count(((object) (f) ), default(global::haxe.lang.Function));
							#line 60 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
							if (( length < 16 )) {
								#line 60 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
								this.o.writeByte(( 128 | length ));
							}
							else if (( length < 65536 )) {
								#line 60 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
								this.o.writeByte(222);
								#line 60 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
								this.o.writeUInt16(length);
							}
							else {
								#line 60 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
								this.o.writeByte(223);
								#line 60 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
								this.o.writeInt32(length);
							}
							
						}
						
						#line 60 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
						{
							#line 60 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
							int _g1 = 0;
							#line 60 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
							while (( _g1 < f.length )) {
								#line 60 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
								string k = global::haxe.lang.Runtime.toString(f.__get(_g1));
								#line 60 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
								 ++ _g1;
								#line 60 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
								this.encode(k);
								#line 60 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
								this.encode(global::haxe.root.Reflect.field(d, k));
							}
							
						}
						
						#line 60 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
						break;
					}
					
					
					case 5:
					{
						#line 64 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
						throw global::haxe.lang.HaxeException.wrap("Error: Function not supported");
					}
					
					
					case 6:
					{
						#line 43 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
						global::System.Type c = ( _g as global::haxe.root.ValueType_TClass ).c;
						#line 43 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
						{
							#line 44 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
							string __name = global::haxe.root.Type.getClassName(c);
							string _name = ( (( global::haxe.root.Std.@string(__name) == "true" )) ? ("String") : (__name) );
							#line 46 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
							switch (_name) {
								case "Array":
								{
									#line 50 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
									global::haxe.root.Array d3 = ((global::haxe.root.Array) (d) );
									#line 50 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
									int length1 = d3.length;
									#line 50 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
									if (( length1 < 16 )) {
										#line 50 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
										this.o.writeByte(( 144 | length1 ));
									}
									else if (( length1 < 65536 )) {
										#line 50 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
										this.o.writeByte(220);
										#line 50 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
										this.o.writeUInt16(length1);
									}
									else {
										#line 50 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
										this.o.writeByte(221);
										#line 50 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
										this.o.writeInt32(length1);
									}
									
									#line 50 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
									{
										#line 50 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
										int _g2 = 0;
										#line 50 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
										while (( _g2 < d3.length )) {
											#line 50 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
											object e = d3.__get(_g2);
											#line 50 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
											 ++ _g2;
											#line 50 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
											this.encode(e);
										}
										
									}
									
									#line 50 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
									break;
								}
								
								
								case "String":
								{
									#line 49 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
									global::haxe.io.Bytes b = global::haxe.io.Bytes.ofString(global::haxe.lang.Runtime.toString(d), null);
									#line 49 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
									int length2 = b.length;
									#line 49 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
									this.o.writeByte(217);
									#line 49 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
									this.o.writeInt32(length2);
									#line 49 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
									this.o.writeBytes(b, 0, b.length);
									#line 49 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
									break;
								}
								
								
								case "System.UInt32":
								{
									#line 54 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
									this.o.writeByte(206);
									#line 54 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
									global::binary128.@internal.Leb128.writeUint32(this.o, ((uint) (global::haxe.lang.Runtime.toInt(d)) ));
									#line 54 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
									break;
								}
								
								
								case "haxe._Int64.___Int64":
								{
									#line 47 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
									long d4 = global::haxe.lang.Runtime.toLong(d);
									#line 47 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
									this.o.writeByte(211);
									#line 47 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
									this.o.writeInt32(((int) (((long) (( ((long) (d4) ) >> 32 )) )) ));
									#line 47 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
									this.o.writeInt32(((int) (((long) (d4) )) ));
									#line 47 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
									break;
								}
								
								
								case "haxe.ds.IntMap":
								case "haxe.ds.StringMap":
								case "haxe.ds.UnsafeStringMap":
								{
									#line 52 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
									global::haxe.IMap d5 = ((global::haxe.IMap) (d) );
									#line 52 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
									int length3 = 0;
									#line 52 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
									{
										#line 52 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
										object k1 = d5.keys();
										#line 52 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
										while (global::haxe.lang.Runtime.toBool(global::haxe.lang.Runtime.callField(k1, "hasNext", 407283053, null))) {
											#line 52 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
											object k2 = ((object) (global::haxe.lang.Runtime.callField(k1, "next", 1224901875, null)) );
											#line 52 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
											 ++ length3;
										}
										
									}
									
									#line 52 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
									if (( length3 < 16 )) {
										#line 52 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
										this.o.writeByte(( 128 | length3 ));
									}
									else if (( length3 < 65536 )) {
										#line 52 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
										this.o.writeByte(222);
										#line 52 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
										this.o.writeUInt16(length3);
									}
									else {
										#line 52 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
										this.o.writeByte(223);
										#line 52 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
										this.o.writeInt32(length3);
									}
									
									#line 52 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
									{
										#line 52 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
										object k3 = d5.keys();
										#line 52 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
										while (global::haxe.lang.Runtime.toBool(global::haxe.lang.Runtime.callField(k3, "hasNext", 407283053, null))) {
											#line 52 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
											object k4 = ((object) (global::haxe.lang.Runtime.callField(k3, "next", 1224901875, null)) );
											#line 52 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
											this.encode(k4);
											#line 52 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
											this.encode(((object) (d5.@get(k4)) ));
										}
										
									}
									
									#line 52 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
									break;
								}
								
								
								case "haxe.io.Bytes":
								{
									#line 48 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
									global::haxe.io.Bytes b1 = ((global::haxe.io.Bytes) (d) );
									#line 48 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
									int length4 = b1.length;
									#line 48 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
									if (( length4 < 256 )) {
										#line 48 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
										this.o.writeByte(196);
										#line 48 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
										this.o.writeByte(length4);
									}
									else if (( length4 < 65536 )) {
										#line 48 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
										this.o.writeByte(197);
										#line 48 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
										this.o.writeUInt16(length4);
									}
									else {
										#line 48 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
										this.o.writeByte(198);
										#line 48 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
										this.o.writeInt32(length4);
									}
									
									#line 48 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
									this.o.write(b1);
									#line 48 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
									break;
								}
								
								
								default:
								{
									#line 56 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
									throw global::haxe.lang.HaxeException.wrap(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("Error: ", global::haxe.root.Type.getClassName(c)), " not supported"));
								}
								
							}
							
						}
						
						#line 43 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
						break;
					}
					
					
					case 7:
					{
						#line 61 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
						global::System.Type e1 = ( _g as global::haxe.root.ValueType_TEnum ).e;
						throw global::haxe.lang.HaxeException.wrap("Error: Enum not supported");
					}
					
					
					case 8:
					{
						#line 66 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
						throw global::haxe.lang.HaxeException.wrap("Error: Unknown Data Type");
					}
					
					
				}
				
			}
			#line default
		}
		
		
		public void writeInt64(long d) {
			unchecked {
				#line 71 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
				this.o.writeByte(211);
				this.o.writeInt32(((int) (((long) (( ((long) (d) ) >> 32 )) )) ));
				#line 73 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
				this.o.writeInt32(((int) (((long) (d) )) ));
			}
			#line default
		}
		
		
		public void writeUInt32(uint d) {
			unchecked {
				#line 79 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
				this.o.writeByte(206);
				global::binary128.@internal.Leb128.writeUint32(this.o, d);
			}
			#line default
		}
		
		
		public void writeInt(int d) {
			unchecked {
				#line 85 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
				if (( d < -32 )) {
					#line 87 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
					if (( d < -32768 )) {
						#line 89 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
						this.o.writeByte(210);
						this.o.writeInt32(d);
					}
					else if (( d < -128 )) {
						#line 93 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
						this.o.writeByte(209);
						this.o.writeInt16(d);
					}
					else {
						#line 97 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
						this.o.writeByte(208);
						this.o.writeInt8(d);
					}
					
				}
				else if (( d < 128 )) {
					#line 102 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
					this.o.writeByte(( d & 255 ));
				}
				else if (( d < 256 )) {
					#line 107 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
					this.o.writeByte(204);
					this.o.writeByte(d);
				}
				else if (( d < 65536 )) {
					#line 111 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
					this.o.writeByte(205);
					this.o.writeUInt16(d);
				}
				else {
					#line 120 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
					this.o.writeByte(206);
					global::haxe.io.BytesOutput buf2 = new global::haxe.io.BytesOutput();
					#line 123 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
					global::binary128.@internal.Leb128.writeUint32(buf2, ((uint) (d) ));
				}
				
			}
			#line default
		}
		
		
		public void writeFloat(double d) {
			unchecked {
				#line 135 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
				double a = global::System.Math.Abs(((double) (d) ));
				if (( ( a > 1.40129846432481707e-45 ) && ( a < 3.40282346638528860e+38 ) )) {
					#line 138 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
					this.o.writeByte(202);
					this.o.writeFloat(d);
				}
				else {
					#line 142 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
					this.o.writeByte(203);
					this.o.writeDouble(d);
				}
				
			}
			#line default
		}
		
		
		public void writeBinary(global::haxe.io.Bytes b) {
			unchecked {
				#line 148 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
				int length = b.length;
				if (( length < 256 )) {
					#line 151 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
					this.o.writeByte(196);
					this.o.writeByte(length);
				}
				else if (( length < 65536 )) {
					#line 155 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
					this.o.writeByte(197);
					this.o.writeUInt16(length);
				}
				else {
					#line 159 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
					this.o.writeByte(198);
					this.o.writeInt32(length);
				}
				
				#line 162 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
				this.o.write(b);
			}
			#line default
		}
		
		
		public void writeString(string s) {
			unchecked {
				#line 168 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
				int size = 0;
				#line 170 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
				global::haxe.io.Bytes b = global::haxe.io.Bytes.ofString(s, null);
				#line 172 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
				int length = b.length;
				#line 194 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
				this.o.writeByte(217);
				this.o.writeInt32(length);
				#line 196 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
				this.o.writeBytes(b, 0, b.length);
			}
			#line default
		}
		
		
		public void writeArray(global::haxe.root.Array d) {
			unchecked {
				#line 200 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
				int length = d.length;
				if (( length < 16 )) {
					#line 203 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
					this.o.writeByte(( 144 | length ));
				}
				else if (( length < 65536 )) {
					#line 206 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
					this.o.writeByte(220);
					this.o.writeUInt16(length);
				}
				else {
					#line 210 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
					this.o.writeByte(221);
					this.o.writeInt32(length);
				}
				
				#line 214 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
				{
					#line 214 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
					int _g = 0;
					#line 214 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
					while (( _g < d.length )) {
						#line 214 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
						object e = d.__get(_g);
						#line 214 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
						 ++ _g;
						this.encode(e);
					}
					
				}
				
			}
			#line default
		}
		
		
		public void writeMapLength(int length) {
			unchecked {
				#line 220 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
				if (( length < 16 )) {
					#line 222 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
					this.o.writeByte(( 128 | length ));
				}
				else if (( length < 65536 )) {
					#line 225 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
					this.o.writeByte(222);
					this.o.writeUInt16(length);
				}
				else {
					#line 229 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
					this.o.writeByte(223);
					this.o.writeInt32(length);
				}
				
			}
			#line default
		}
		
		
		public void writeMap(global::haxe.IMap d) {
			unchecked {
				#line 235 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
				int length = 0;
				{
					#line 236 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
					object k = d.keys();
					#line 236 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
					while (global::haxe.lang.Runtime.toBool(global::haxe.lang.Runtime.callField(k, "hasNext", 407283053, null))) {
						#line 236 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
						object k1 = ((object) (global::haxe.lang.Runtime.callField(k, "next", 1224901875, null)) );
						 ++ length;
					}
					
				}
				
				#line 239 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
				if (( length < 16 )) {
					#line 239 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
					this.o.writeByte(( 128 | length ));
				}
				else if (( length < 65536 )) {
					#line 239 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
					this.o.writeByte(222);
					#line 239 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
					this.o.writeUInt16(length);
				}
				else {
					#line 239 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
					this.o.writeByte(223);
					#line 239 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
					this.o.writeInt32(length);
				}
				
				#line 240 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
				{
					#line 240 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
					object k2 = d.keys();
					#line 240 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
					while (global::haxe.lang.Runtime.toBool(global::haxe.lang.Runtime.callField(k2, "hasNext", 407283053, null))) {
						#line 240 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
						object k3 = ((object) (global::haxe.lang.Runtime.callField(k2, "next", 1224901875, null)) );
						this.encode(k3);
						#line 242 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
						this.encode(((object) (d.@get(k3)) ));
					}
					
				}
				
			}
			#line default
		}
		
		
		public void writeObject(object d) {
			unchecked {
				#line 247 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
				global::haxe.root.Array f = global::haxe.root.Reflect.fields(d);
				#line 249 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
				{
					#line 249 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
					int length = global::haxe.root.Lambda.count(((object) (f) ), default(global::haxe.lang.Function));
					#line 249 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
					if (( length < 16 )) {
						#line 249 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
						this.o.writeByte(( 128 | length ));
					}
					else if (( length < 65536 )) {
						#line 249 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
						this.o.writeByte(222);
						#line 249 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
						this.o.writeUInt16(length);
					}
					else {
						#line 249 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
						this.o.writeByte(223);
						#line 249 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
						this.o.writeInt32(length);
					}
					
				}
				
				#line 250 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
				{
					#line 250 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
					int _g = 0;
					#line 250 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
					while (( _g < f.length )) {
						#line 250 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
						string k = global::haxe.lang.Runtime.toString(f.__get(_g));
						#line 250 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
						 ++ _g;
						this.encode(k);
						#line 252 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
						this.encode(global::haxe.root.Reflect.field(d, k));
					}
					
				}
				
			}
			#line default
		}
		
		
		public global::haxe.io.Bytes getBytes() {
			#line 257 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
			return this.o.getBytes();
		}
		#line default
		
		public override object __hx_setField(string field, int hash, object @value, bool handleProperties) {
			unchecked {
				#line 15 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
				switch (hash) {
					case 111:
					{
						#line 15 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
						this.o = ((global::haxe.io.BytesOutput) (@value) );
						#line 15 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
						return @value;
					}
					
					
					default:
					{
						#line 15 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
						return base.__hx_setField(field, hash, @value, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties) {
			unchecked {
				#line 15 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
				switch (hash) {
					case 493819893:
					{
						#line 15 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "getBytes", 493819893)) );
					}
					
					
					case 708366590:
					{
						#line 15 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "writeObject", 708366590)) );
					}
					
					
					case 603155197:
					{
						#line 15 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "writeMap", 603155197)) );
					}
					
					
					case 1806782403:
					{
						#line 15 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "writeMapLength", 1806782403)) );
					}
					
					
					case 978413626:
					{
						#line 15 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "writeArray", 978413626)) );
					}
					
					
					case 640252688:
					{
						#line 15 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "writeString", 640252688)) );
					}
					
					
					case 33885760:
					{
						#line 15 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "writeBinary", 33885760)) );
					}
					
					
					case 391692349:
					{
						#line 15 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "writeFloat", 391692349)) );
					}
					
					
					case 602959184:
					{
						#line 15 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "writeInt", 602959184)) );
					}
					
					
					case 772312280:
					{
						#line 15 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "writeUInt32", 772312280)) );
					}
					
					
					case 1390579854:
					{
						#line 15 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "writeInt64", 1390579854)) );
					}
					
					
					case 2044981782:
					{
						#line 15 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "encode", 2044981782)) );
					}
					
					
					case 111:
					{
						#line 15 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
						return this.o;
					}
					
					
					default:
					{
						#line 15 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_invokeField(string field, int hash, object[] dynargs) {
			unchecked {
				#line 15 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
				switch (hash) {
					case 493819893:
					{
						#line 15 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
						return this.getBytes();
					}
					
					
					case 708366590:
					{
						#line 15 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
						this.writeObject(((object) (dynargs[0]) ));
						#line 15 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
						break;
					}
					
					
					case 603155197:
					{
						#line 15 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
						this.writeMap(((global::haxe.IMap) (((object) (dynargs[0]) )) ));
						#line 15 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
						break;
					}
					
					
					case 1806782403:
					{
						#line 15 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
						this.writeMapLength(((int) (global::haxe.lang.Runtime.toInt(((object) (dynargs[0]) ))) ));
						#line 15 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
						break;
					}
					
					
					case 978413626:
					{
						#line 15 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
						this.writeArray(((global::haxe.root.Array) (((object) (dynargs[0]) )) ));
						#line 15 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
						break;
					}
					
					
					case 640252688:
					{
						#line 15 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
						this.writeString(global::haxe.lang.Runtime.toString(((object) (dynargs[0]) )));
						#line 15 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
						break;
					}
					
					
					case 33885760:
					{
						#line 15 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
						this.writeBinary(((global::haxe.io.Bytes) (((object) (dynargs[0]) )) ));
						#line 15 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
						break;
					}
					
					
					case 391692349:
					{
						#line 15 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
						this.writeFloat(((double) (global::haxe.lang.Runtime.toDouble(((object) (dynargs[0]) ))) ));
						#line 15 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
						break;
					}
					
					
					case 602959184:
					{
						#line 15 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
						this.writeInt(((int) (global::haxe.lang.Runtime.toInt(((object) (dynargs[0]) ))) ));
						#line 15 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
						break;
					}
					
					
					case 772312280:
					{
						#line 15 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
						this.writeUInt32(((uint) (global::haxe.lang.Runtime.toInt(((object) (dynargs[0]) ))) ));
						#line 15 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
						break;
					}
					
					
					case 1390579854:
					{
						#line 15 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
						this.writeInt64(global::haxe.lang.Runtime.toLong(((object) (dynargs[0]) )));
						#line 15 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
						break;
					}
					
					
					case 2044981782:
					{
						#line 15 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
						this.encode(((object) (dynargs[0]) ));
						#line 15 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
						break;
					}
					
					
					default:
					{
						#line 15 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
				#line 15 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
				return null;
			}
			#line default
		}
		
		
		public override void __hx_getFields(global::haxe.root.Array baseArr) {
			#line 15 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
			baseArr.push("o");
			#line 15 "D:\\project\\sangong\\sangong\\src\\org\\msgpack\\Encoder.hx"
			base.__hx_getFields(baseArr);
		}
		#line default
		
	}
}


