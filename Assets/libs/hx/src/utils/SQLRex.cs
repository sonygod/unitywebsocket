// Generated by Haxe 4.1.0-rc.1+0d88c583b
using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace utils {
	public class SQLRex : global::haxe.lang.HxObject {
		
		public SQLRex(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public SQLRex() {
			global::utils.SQLRex.__hx_ctor_utils_SQLRex(this);
		}
		
		
		protected static void __hx_ctor_utils_SQLRex(global::utils.SQLRex __hx_this) {
		}
		
		
		public static bool checkSQL(string content) {
			unchecked {
				if (( content == null )) {
					return false;
				}
				
				global::haxe.root.EReg r = new global::haxe.root.EReg("(delete)|(drop)|(;)|(--)|(insert)|(drop)|(count)|(\\*)|(select)|(where)|(when)|(\\s+)|(\\()|(\\))|(\")|(0x)|(,)|(offset)|(<)|(>)|(=)|(&)|(\\|)|(ike)|(%)|(!)|(CHAR)|(#)", "");
				bool result = r.match(content);
				if (result) {
					global::haxe.Log.trace.__hx_invoke2_o(default(double), global::haxe.lang.Runtime.concat("warning content\u6709\u6f0f\u6d1e", content), default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"checkSQL", "utils.SQLRex", "src/utils/SQLRex.hx"}, new int[]{1981972957}, new double[]{((double) (25) )}));
				}
				
				return result;
			}
		}
		
		
	}
}


