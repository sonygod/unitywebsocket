// Generated by Haxe 4.1.0-rc.1+0d88c583b
using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.root {
	public class IntIterator : global::haxe.lang.HxObject {
		
		public IntIterator(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public IntIterator(int min, int max) {
			#line 45 "C:\\HaxeToolkit\\haxe\\std\\IntIterator.hx"
			global::haxe.root.IntIterator.__hx_ctor__IntIterator(this, min, max);
		}
		#line default
		
		protected static void __hx_ctor__IntIterator(global::haxe.root.IntIterator __hx_this, int min, int max) {
			#line 46 "C:\\HaxeToolkit\\haxe\\std\\IntIterator.hx"
			__hx_this.min = min;
			__hx_this.max = max;
		}
		#line default
		
		public int min;
		
		public int max;
		
		public bool hasNext() {
			#line 54 "C:\\HaxeToolkit\\haxe\\std\\IntIterator.hx"
			return ( this.min < this.max );
		}
		#line default
		
		public int next() {
			#line 63 "C:\\HaxeToolkit\\haxe\\std\\IntIterator.hx"
			return this.min++;
		}
		#line default
		
		public override double __hx_setField_f(string field, int hash, double @value, bool handleProperties) {
			unchecked {
				#line 36 "C:\\HaxeToolkit\\haxe\\std\\IntIterator.hx"
				switch (hash) {
					case 5442212:
					{
						#line 36 "C:\\HaxeToolkit\\haxe\\std\\IntIterator.hx"
						this.max = ((int) (@value) );
						#line 36 "C:\\HaxeToolkit\\haxe\\std\\IntIterator.hx"
						return @value;
					}
					
					
					case 5443986:
					{
						#line 36 "C:\\HaxeToolkit\\haxe\\std\\IntIterator.hx"
						this.min = ((int) (@value) );
						#line 36 "C:\\HaxeToolkit\\haxe\\std\\IntIterator.hx"
						return @value;
					}
					
					
					default:
					{
						#line 36 "C:\\HaxeToolkit\\haxe\\std\\IntIterator.hx"
						return base.__hx_setField_f(field, hash, @value, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_setField(string field, int hash, object @value, bool handleProperties) {
			unchecked {
				#line 36 "C:\\HaxeToolkit\\haxe\\std\\IntIterator.hx"
				switch (hash) {
					case 5442212:
					{
						#line 36 "C:\\HaxeToolkit\\haxe\\std\\IntIterator.hx"
						this.max = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						#line 36 "C:\\HaxeToolkit\\haxe\\std\\IntIterator.hx"
						return @value;
					}
					
					
					case 5443986:
					{
						#line 36 "C:\\HaxeToolkit\\haxe\\std\\IntIterator.hx"
						this.min = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						#line 36 "C:\\HaxeToolkit\\haxe\\std\\IntIterator.hx"
						return @value;
					}
					
					
					default:
					{
						#line 36 "C:\\HaxeToolkit\\haxe\\std\\IntIterator.hx"
						return base.__hx_setField(field, hash, @value, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties) {
			unchecked {
				#line 36 "C:\\HaxeToolkit\\haxe\\std\\IntIterator.hx"
				switch (hash) {
					case 1224901875:
					{
						#line 36 "C:\\HaxeToolkit\\haxe\\std\\IntIterator.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "next", 1224901875)) );
					}
					
					
					case 407283053:
					{
						#line 36 "C:\\HaxeToolkit\\haxe\\std\\IntIterator.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "hasNext", 407283053)) );
					}
					
					
					case 5442212:
					{
						#line 36 "C:\\HaxeToolkit\\haxe\\std\\IntIterator.hx"
						return this.max;
					}
					
					
					case 5443986:
					{
						#line 36 "C:\\HaxeToolkit\\haxe\\std\\IntIterator.hx"
						return this.min;
					}
					
					
					default:
					{
						#line 36 "C:\\HaxeToolkit\\haxe\\std\\IntIterator.hx"
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override double __hx_getField_f(string field, int hash, bool throwErrors, bool handleProperties) {
			unchecked {
				#line 36 "C:\\HaxeToolkit\\haxe\\std\\IntIterator.hx"
				switch (hash) {
					case 5442212:
					{
						#line 36 "C:\\HaxeToolkit\\haxe\\std\\IntIterator.hx"
						return ((double) (this.max) );
					}
					
					
					case 5443986:
					{
						#line 36 "C:\\HaxeToolkit\\haxe\\std\\IntIterator.hx"
						return ((double) (this.min) );
					}
					
					
					default:
					{
						#line 36 "C:\\HaxeToolkit\\haxe\\std\\IntIterator.hx"
						return base.__hx_getField_f(field, hash, throwErrors, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_invokeField(string field, int hash, object[] dynargs) {
			unchecked {
				#line 36 "C:\\HaxeToolkit\\haxe\\std\\IntIterator.hx"
				switch (hash) {
					case 1224901875:
					{
						#line 36 "C:\\HaxeToolkit\\haxe\\std\\IntIterator.hx"
						return this.next();
					}
					
					
					case 407283053:
					{
						#line 36 "C:\\HaxeToolkit\\haxe\\std\\IntIterator.hx"
						return this.hasNext();
					}
					
					
					default:
					{
						#line 36 "C:\\HaxeToolkit\\haxe\\std\\IntIterator.hx"
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override void __hx_getFields(global::haxe.root.Array baseArr) {
			#line 36 "C:\\HaxeToolkit\\haxe\\std\\IntIterator.hx"
			baseArr.push("max");
			#line 36 "C:\\HaxeToolkit\\haxe\\std\\IntIterator.hx"
			baseArr.push("min");
			#line 36 "C:\\HaxeToolkit\\haxe\\std\\IntIterator.hx"
			base.__hx_getFields(baseArr);
		}
		#line default
		
	}
}


