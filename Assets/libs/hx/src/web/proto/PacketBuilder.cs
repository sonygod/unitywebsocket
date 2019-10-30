// Generated by Haxe 4.0.0+ef18b627e

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace web.proto {
	public class Web_Error : global::haxe.lang.Enum {
		
		protected Web_Error(int index) : base(index) {
		}
		
		
		public static readonly global::web.proto.Web_Error OK = new global::web.proto.Web_Error_OK();
		
		public static readonly global::web.proto.Web_Error ERROR = new global::web.proto.Web_Error_ERROR();
		
		protected static readonly string[] __hx_constructs = new string[]{"OK", "ERROR"};
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace web.proto {
	public sealed class Web_Error_OK : global::web.proto.Web_Error {
		
		public Web_Error_OK() : base(0) {
		}
		
		
		public override string getTag() {
			#line 41 "D:\\project\\sangong\\sangong\\src\\web\\proto\\PacketBuilder.hx"
			return "OK";
		}
		#line default
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace web.proto {
	public sealed class Web_Error_ERROR : global::web.proto.Web_Error {
		
		public Web_Error_ERROR() : base(1) {
		}
		
		
		public override string getTag() {
			#line 42 "D:\\project\\sangong\\sangong\\src\\web\\proto\\PacketBuilder.hx"
			return "ERROR";
		}
		#line default
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace web.proto {
	public class PacketBuilder : global::haxe.lang.HxObject {
		
		static PacketBuilder() {
			unchecked{
				#line 220 "D:\\project\\sangong\\sangong\\src\\web\\proto\\PacketBuilder.hx"
				global::web.proto.PacketBuilder.HEADER_SIZE = 10;
			}
		}
		#line default
		
		public PacketBuilder(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public PacketBuilder() {
			#line 218 "D:\\project\\sangong\\sangong\\src\\web\\proto\\PacketBuilder.hx"
			global::web.proto.PacketBuilder.__hx_ctor_web_proto_PacketBuilder(this);
		}
		#line default
		
		protected static void __hx_ctor_web_proto_PacketBuilder(global::web.proto.PacketBuilder __hx_this) {
		}
		
		
		public static global::haxe.io.Bytes bytesBuff;
		
		public static int HEADER_SIZE;
		
		public static global::haxe.io.Bytes createPacket(uint mainID, uint sID, int userID, global::haxe.io.Bytes data, object compress) {
			unchecked {
				#line 231 "D:\\project\\sangong\\sangong\\src\\web\\proto\\PacketBuilder.hx"
				bool compress1 = ( (( compress == default(object) )) ? (false) : (global::haxe.lang.Runtime.toBool(compress)) );
				if (( data == null )) {
					#line 233 "D:\\project\\sangong\\sangong\\src\\web\\proto\\PacketBuilder.hx"
					data = global::org.msgpack.MsgPack.encode(0);
				}
				
				#line 235 "D:\\project\\sangong\\sangong\\src\\web\\proto\\PacketBuilder.hx"
				int len = data.length;
				int code = ( (( compress1 == true )) ? (1) : (0) );
				#line 237 "D:\\project\\sangong\\sangong\\src\\web\\proto\\PacketBuilder.hx"
				object _head = new global::haxe.lang.DynamicObject(new int[]{}, new object[]{}, new int[]{197623819, 363100693, 1042491189, 1386805980, 1655151068}, new double[]{((double) (((uint) (len) )) ), ((double) (((uint) (code) )) ), ((double) (sID) ), ((double) (((uint) (119) )) ), ((double) (mainID) )});
				#line 245 "D:\\project\\sangong\\sangong\\src\\web\\proto\\PacketBuilder.hx"
				object pk = new global::haxe.lang.DynamicObject(new int[]{1106197222, 1113806378, 1158359328}, new object[]{((object) (userID) ), data, _head}, new int[]{}, new double[]{});
				#line 248 "D:\\project\\sangong\\sangong\\src\\web\\proto\\PacketBuilder.hx"
				global::haxe.io.Bytes hb = global::org.msgpack.MsgPack.encode(pk);
				#line 250 "D:\\project\\sangong\\sangong\\src\\web\\proto\\PacketBuilder.hx"
				global::haxe.io.BytesOutput output = new global::haxe.io.BytesOutput();
				#line 252 "D:\\project\\sangong\\sangong\\src\\web\\proto\\PacketBuilder.hx"
				output.writeByte(90);
				output.writeByte(72);
				#line 254 "D:\\project\\sangong\\sangong\\src\\web\\proto\\PacketBuilder.hx"
				output.writeByte(89);
				output.writeByte(1);
				#line 256 "D:\\project\\sangong\\sangong\\src\\web\\proto\\PacketBuilder.hx"
				output.writeByte(0);
				output.writeByte(0);
				#line 260 "D:\\project\\sangong\\sangong\\src\\web\\proto\\PacketBuilder.hx"
				output.writeInt32(hb.length);
				#line 263 "D:\\project\\sangong\\sangong\\src\\web\\proto\\PacketBuilder.hx"
				output.write(hb);
				#line 265 "D:\\project\\sangong\\sangong\\src\\web\\proto\\PacketBuilder.hx"
				return output.getBytes();
			}
			#line default
		}
		
		
		public static bool checkKey(int z, int h, int y, int version1, int version2, int version3) {
			unchecked {
				#line 270 "D:\\project\\sangong\\sangong\\src\\web\\proto\\PacketBuilder.hx"
				if (( ( ( ( ( z == 90 ) && ( h == 72 ) ) && ( y == 89 ) ) && ( version1 == 1 ) ) && ( version2 == 0 ) )) {
					#line 270 "D:\\project\\sangong\\sangong\\src\\web\\proto\\PacketBuilder.hx"
					return ( version3 == 0 );
				}
				else {
					#line 270 "D:\\project\\sangong\\sangong\\src\\web\\proto\\PacketBuilder.hx"
					return false;
				}
				
			}
			#line default
		}
		
		
		public static void addBytes(global::haxe.io.Bytes bytes, global::server.IHander hander, global::haxe.lang.Function callBack) {
			unchecked {
				#line 277 "D:\\project\\sangong\\sangong\\src\\web\\proto\\PacketBuilder.hx"
				if (( hander != null )) {
					#line 278 "D:\\project\\sangong\\sangong\\src\\web\\proto\\PacketBuilder.hx"
					return;
				}
				
				#line 280 "D:\\project\\sangong\\sangong\\src\\web\\proto\\PacketBuilder.hx"
				if (( bytes == null )) {
					#line 281 "D:\\project\\sangong\\sangong\\src\\web\\proto\\PacketBuilder.hx"
					return;
				}
				
				#line 284 "D:\\project\\sangong\\sangong\\src\\web\\proto\\PacketBuilder.hx"
				if (( bytes.length > 1000 )) {
					#line 285 "D:\\project\\sangong\\sangong\\src\\web\\proto\\PacketBuilder.hx"
					callBack.__hx_invoke4_o(default(double), false, default(double), null, default(double), global::web.proto.Web_Error.ERROR, default(double), hander);
				}
				
				#line 288 "D:\\project\\sangong\\sangong\\src\\web\\proto\\PacketBuilder.hx"
				if (( global::web.proto.PacketBuilder.bytesBuff == null )) {
					#line 289 "D:\\project\\sangong\\sangong\\src\\web\\proto\\PacketBuilder.hx"
					global::web.proto.PacketBuilder.bytesBuff = bytes;
				}
				else {
					#line 291 "D:\\project\\sangong\\sangong\\src\\web\\proto\\PacketBuilder.hx"
					global::haxe.io.BytesBuffer buffer = new global::haxe.io.BytesBuffer();
					{
						#line 292 "D:\\project\\sangong\\sangong\\src\\web\\proto\\PacketBuilder.hx"
						global::haxe.io.Bytes src = global::web.proto.PacketBuilder.bytesBuff;
						#line 292 "D:\\project\\sangong\\sangong\\src\\web\\proto\\PacketBuilder.hx"
						( buffer.b as global::System.IO.Stream ).Write(((byte[]) (src.b) ), ((int) (0) ), ((int) (src.length) ));
					}
					
					#line 293 "D:\\project\\sangong\\sangong\\src\\web\\proto\\PacketBuilder.hx"
					( buffer.b as global::System.IO.Stream ).Write(((byte[]) (bytes.b) ), ((int) (0) ), ((int) (bytes.length) ));
					global::web.proto.PacketBuilder.bytesBuff = buffer.getBytes();
				}
				
				#line 296 "D:\\project\\sangong\\sangong\\src\\web\\proto\\PacketBuilder.hx"
				if (( ( global::web.proto.PacketBuilder.bytesBuff == null ) || ( global::web.proto.PacketBuilder.bytesBuff.length < 10 ) )) {
					#line 297 "D:\\project\\sangong\\sangong\\src\\web\\proto\\PacketBuilder.hx"
					return;
				}
				
				#line 299 "D:\\project\\sangong\\sangong\\src\\web\\proto\\PacketBuilder.hx"
				int available = global::web.proto.PacketBuilder.bytesBuff.length;
				global::haxe.io.BytesInput bi = new global::haxe.io.BytesInput(global::web.proto.PacketBuilder.bytesBuff, null, null);
				#line 301 "D:\\project\\sangong\\sangong\\src\\web\\proto\\PacketBuilder.hx"
				bi.set_bigEndian(false);
				while (( available >= 10 )) {
					#line 304 "D:\\project\\sangong\\sangong\\src\\web\\proto\\PacketBuilder.hx"
					int z = bi.readByte();
					int h = bi.readByte();
					#line 306 "D:\\project\\sangong\\sangong\\src\\web\\proto\\PacketBuilder.hx"
					int y = bi.readByte();
					int v1 = bi.readByte();
					#line 308 "D:\\project\\sangong\\sangong\\src\\web\\proto\\PacketBuilder.hx"
					int v2 = bi.readByte();
					int v3 = bi.readByte();
					#line 310 "D:\\project\\sangong\\sangong\\src\\web\\proto\\PacketBuilder.hx"
					int packetSize = bi.readInt32();
					available -= 10;
					#line 313 "D:\\project\\sangong\\sangong\\src\\web\\proto\\PacketBuilder.hx"
					if ( ! (global::web.proto.PacketBuilder.checkKey(z, h, y, v1, v2, v3)) ) {
						#line 314 "D:\\project\\sangong\\sangong\\src\\web\\proto\\PacketBuilder.hx"
						global::web.proto.PacketBuilder.bytesBuff = null;
						global::haxe.Log.trace.__hx_invoke2_o(default(double), "fuck you !!! error message", default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"addBytes", "web.proto.PacketBuilder", "src/web/proto/PacketBuilder.hx"}, new int[]{1981972957}, new double[]{((double) (315) )}));
						#line 316 "D:\\project\\sangong\\sangong\\src\\web\\proto\\PacketBuilder.hx"
						available = 0;
						callBack.__hx_invoke4_o(default(double), false, default(double), null, default(double), global::web.proto.Web_Error.ERROR, default(double), hander);
						#line 319 "D:\\project\\sangong\\sangong\\src\\web\\proto\\PacketBuilder.hx"
						break;
					}
					
					#line 322 "D:\\project\\sangong\\sangong\\src\\web\\proto\\PacketBuilder.hx"
					bool error = false;
					if (( packetSize <= available )) {
						#line 324 "D:\\project\\sangong\\sangong\\src\\web\\proto\\PacketBuilder.hx"
						available -= packetSize;
						global::haxe.io.Bytes msgBytes = bi.read(packetSize);
						#line 327 "D:\\project\\sangong\\sangong\\src\\web\\proto\\PacketBuilder.hx"
						try {
							#line 328 "D:\\project\\sangong\\sangong\\src\\web\\proto\\PacketBuilder.hx"
							object p = global::org.msgpack.MsgPack.decode(msgBytes, null);
							#line 330 "D:\\project\\sangong\\sangong\\src\\web\\proto\\PacketBuilder.hx"
							callBack.__hx_invoke4_o(default(double), true, default(double), p, default(double), global::web.proto.Web_Error.OK, default(double), hander);
						}
						catch (global::System.Exception catchallException){
							#line 327 "D:\\project\\sangong\\sangong\\src\\web\\proto\\PacketBuilder.hx"
							global::haxe.lang.Exceptions.exception = catchallException;
							#line 332 "D:\\project\\sangong\\sangong\\src\\web\\proto\\PacketBuilder.hx"
							{
								#line 332 "D:\\project\\sangong\\sangong\\src\\web\\proto\\PacketBuilder.hx"
								object e = ( (( catchallException is global::haxe.lang.HaxeException )) ? (((global::haxe.lang.HaxeException) (catchallException) ).obj) : ((object) (catchallException) ) );
								#line 332 "D:\\project\\sangong\\sangong\\src\\web\\proto\\PacketBuilder.hx"
								callBack.__hx_invoke4_o(default(double), false, default(double), null, default(double), global::web.proto.Web_Error.ERROR, default(double), hander);
							}
							
						}
						
						
						#line 334 "D:\\project\\sangong\\sangong\\src\\web\\proto\\PacketBuilder.hx"
						break;
					}
					else {
						#line 337 "D:\\project\\sangong\\sangong\\src\\web\\proto\\PacketBuilder.hx"
						available += 10;
						#line 339 "D:\\project\\sangong\\sangong\\src\\web\\proto\\PacketBuilder.hx"
						break;
					}
					
				}
				
				#line 342 "D:\\project\\sangong\\sangong\\src\\web\\proto\\PacketBuilder.hx"
				global::web.proto.PacketBuilder.bytesBuff = null;
				available = 0;
				#line 345 "D:\\project\\sangong\\sangong\\src\\web\\proto\\PacketBuilder.hx"
				return;
			}
			#line default
		}
		
		
	}
}


