// Generated by Haxe 4.1.0-rc.1+0d88c583b
using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace client {
	public class ConvertCSHX {
		
		public ConvertCSHX() {
		}
		
		
		public static object convertRoomData(string data) {
			#line 22 "D:\\project\\sangong\\sangong\\src\\client\\ConvertCSHX.hx"
			object roomInfo = new global::haxe.format.JsonParser(((string) (data) )).doParse();
			#line 24 "D:\\project\\sangong\\sangong\\src\\client\\ConvertCSHX.hx"
			object result = new global::haxe.lang.DynamicObject(new int[]{}, new object[]{}, new int[]{}, new double[]{});
			#line 26 "D:\\project\\sangong\\sangong\\src\\client\\ConvertCSHX.hx"
			global::haxe.root.Array fs = global::haxe.root.Reflect.fields(roomInfo);
			#line 28 "D:\\project\\sangong\\sangong\\src\\client\\ConvertCSHX.hx"
			{
				#line 28 "D:\\project\\sangong\\sangong\\src\\client\\ConvertCSHX.hx"
				int _g = 0;
				#line 28 "D:\\project\\sangong\\sangong\\src\\client\\ConvertCSHX.hx"
				while (( _g < fs.length )) {
					#line 28 "D:\\project\\sangong\\sangong\\src\\client\\ConvertCSHX.hx"
					string f = global::haxe.lang.Runtime.toString(fs.__get(_g));
					#line 28 "D:\\project\\sangong\\sangong\\src\\client\\ConvertCSHX.hx"
					 ++ _g;
					if (( global::haxe.root.Reflect.field(roomInfo, f) != null )) {
						#line 30 "D:\\project\\sangong\\sangong\\src\\client\\ConvertCSHX.hx"
						global::haxe.root.Reflect.setField(result, f, global::haxe.root.Reflect.field(roomInfo, f));
					}
					
				}
				
			}
			
			#line 33 "D:\\project\\sangong\\sangong\\src\\client\\ConvertCSHX.hx"
			return result;
		}
		#line default
		
		public static object convertPlayerData(object data) {
			#line 42 "D:\\project\\sangong\\sangong\\src\\client\\ConvertCSHX.hx"
			object roomInfo = new global::haxe.lang.DynamicObject(new int[]{23515}, new object[]{((object) (0) )}, new int[]{}, new double[]{});
			#line 44 "D:\\project\\sangong\\sangong\\src\\client\\ConvertCSHX.hx"
			global::haxe.root.Array fs = global::haxe.root.Reflect.fields(data);
			#line 46 "D:\\project\\sangong\\sangong\\src\\client\\ConvertCSHX.hx"
			{
				#line 46 "D:\\project\\sangong\\sangong\\src\\client\\ConvertCSHX.hx"
				int _g = 0;
				#line 46 "D:\\project\\sangong\\sangong\\src\\client\\ConvertCSHX.hx"
				while (( _g < fs.length )) {
					#line 46 "D:\\project\\sangong\\sangong\\src\\client\\ConvertCSHX.hx"
					string f = global::haxe.lang.Runtime.toString(fs.__get(_g));
					#line 46 "D:\\project\\sangong\\sangong\\src\\client\\ConvertCSHX.hx"
					 ++ _g;
					object v = global::haxe.root.Reflect.field(data, f);
					#line 48 "D:\\project\\sangong\\sangong\\src\\client\\ConvertCSHX.hx"
					if (( v != null )) {
						#line 49 "D:\\project\\sangong\\sangong\\src\\client\\ConvertCSHX.hx"
						global::haxe.root.Reflect.setField(roomInfo, f, v);
					}
					
				}
				
			}
			
			#line 53 "D:\\project\\sangong\\sangong\\src\\client\\ConvertCSHX.hx"
			return roomInfo;
		}
		#line default
		
		public static object convertTinyCMD(string data) {
			unchecked {
				#line 63 "D:\\project\\sangong\\sangong\\src\\client\\ConvertCSHX.hx"
				object cmd = new global::haxe.format.JsonParser(((string) (data) )).doParse();
				#line 66 "D:\\project\\sangong\\sangong\\src\\client\\ConvertCSHX.hx"
				global::web.SocketAsync.sendCS(((int) (((uint) (1) )) ), ((int) (15) ), -1, global::org.msgpack.MsgPack.encode(cmd), null);
				#line 69 "D:\\project\\sangong\\sangong\\src\\client\\ConvertCSHX.hx"
				return cmd;
			}
			#line default
		}
		
		
	}
}


