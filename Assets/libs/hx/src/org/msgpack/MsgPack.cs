// Generated by Haxe 4.1.0-rc.1+0d88c583b
using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace org.msgpack {
	public class MsgPack : global::haxe.lang.HxObject {
		
		public MsgPack(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public MsgPack() {
			global::org.msgpack.MsgPack.__hx_ctor_org_msgpack_MsgPack(this);
		}
		
		
		protected static void __hx_ctor_org_msgpack_MsgPack(global::org.msgpack.MsgPack __hx_this) {
		}
		
		
		public static global::haxe.io.Bytes encode(object d) {
			return new global::org.msgpack.Encoder(((object) (d) )).o.getBytes();
		}
		
		
		public static object decode(global::haxe.io.Bytes b, global::org.msgpack.DecodeOption option) {
			if (( option == null )) {
				option = global::org.msgpack.DecodeOption.AsObject;
			}
			
			return new global::org.msgpack.Decoder(b, option).o;
		}
		
		
	}
}


