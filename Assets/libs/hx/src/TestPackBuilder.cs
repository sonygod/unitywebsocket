// Generated by Haxe 4.0.2+606b176a3
using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.root {
	public class TestPackBuilder : global::haxe.lang.HxObject {
		
		public static void Main(){
			global::cs.Boot.init();
			{
				global::haxe.root.TestPackBuilder.main();
				global::haxe.EntryPoint.run();
			}
		}
		public TestPackBuilder(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public TestPackBuilder() {
			#line 8 "C:\\projects\\BCGAME\\sangong\\src\\TestPackBuilder.hx"
			global::haxe.root.TestPackBuilder.__hx_ctor__TestPackBuilder(this);
		}
		#line default
		
		protected static void __hx_ctor__TestPackBuilder(global::haxe.root.TestPackBuilder __hx_this) {
		}
		
		
		public static void main() {
			unchecked {
				#line 13 "C:\\projects\\BCGAME\\sangong\\src\\TestPackBuilder.hx"
				global::utils.CustomTrace.init();
				#line 15 "C:\\projects\\BCGAME\\sangong\\src\\TestPackBuilder.hx"
				global::haxe.Log.trace.__hx_invoke2_o(default(double), "haxe \u521d\u59cb\u5316\u5b8c\u6bd5\uff01", default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"main", "TestPackBuilder", "src/TestPackBuilder.hx"}, new int[]{1981972957}, new double[]{((double) (15) )}));
			}
			#line default
		}
		
		
		public global::Client c;
		
		public override object __hx_setField(string field, int hash, object @value, bool handleProperties) {
			unchecked {
				#line 8 "C:\\projects\\BCGAME\\sangong\\src\\TestPackBuilder.hx"
				switch (hash) {
					case 99:
					{
						#line 8 "C:\\projects\\BCGAME\\sangong\\src\\TestPackBuilder.hx"
						this.c = ((global::Client) (@value) );
						#line 8 "C:\\projects\\BCGAME\\sangong\\src\\TestPackBuilder.hx"
						return @value;
					}
					
					
					default:
					{
						#line 8 "C:\\projects\\BCGAME\\sangong\\src\\TestPackBuilder.hx"
						return base.__hx_setField(field, hash, @value, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties) {
			unchecked {
				#line 8 "C:\\projects\\BCGAME\\sangong\\src\\TestPackBuilder.hx"
				switch (hash) {
					case 99:
					{
						#line 8 "C:\\projects\\BCGAME\\sangong\\src\\TestPackBuilder.hx"
						return this.c;
					}
					
					
					default:
					{
						#line 8 "C:\\projects\\BCGAME\\sangong\\src\\TestPackBuilder.hx"
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override void __hx_getFields(global::haxe.root.Array baseArr) {
			#line 8 "C:\\projects\\BCGAME\\sangong\\src\\TestPackBuilder.hx"
			baseArr.push("c");
			#line 8 "C:\\projects\\BCGAME\\sangong\\src\\TestPackBuilder.hx"
			base.__hx_getFields(baseArr);
		}
		#line default
		
	}
}


