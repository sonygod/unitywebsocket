// Generated by Haxe 4.0.2+606b176a3

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace cs._NativeArray {
	public class NativeArrayIterator : global::haxe.lang.HxObject {
		
		public NativeArrayIterator(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public NativeArrayIterator(object[] arr) {
			#line 67 "C:\\HaxeToolkit\\haxe\\std\\cs\\NativeArray.hx"
			global::cs._NativeArray.NativeArrayIterator.__hx_ctor_cs__NativeArray_NativeArrayIterator(((global::cs._NativeArray.NativeArrayIterator) (this) ), ((object[]) (arr) ));
		}
		#line default
		
		protected static void __hx_ctor_cs__NativeArray_NativeArrayIterator(global::cs._NativeArray.NativeArrayIterator __hx_this, object[] arr) {
			#line 68 "C:\\HaxeToolkit\\haxe\\std\\cs\\NativeArray.hx"
			__hx_this.arr = arr;
			__hx_this.idx = ((uint) (0) );
		}
		#line default
		
		public object[] arr;
		
		public uint idx;
		
		public bool hasNext() {
			#line 73 "C:\\HaxeToolkit\\haxe\\std\\cs\\NativeArray.hx"
			return ((bool) (( this.idx < ( this.arr as global::System.Array ).Length )) );
		}
		#line default
		
		public object next() {
			#line 76 "C:\\HaxeToolkit\\haxe\\std\\cs\\NativeArray.hx"
			return ((object) (this.arr[((int) (this.idx++) )]) );
		}
		#line default
		
		public override double __hx_setField_f(string field, int hash, double @value, bool handleProperties) {
			unchecked {
				#line 63 "C:\\HaxeToolkit\\haxe\\std\\cs\\NativeArray.hx"
				switch (hash) {
					case 5243965:
					{
						#line 63 "C:\\HaxeToolkit\\haxe\\std\\cs\\NativeArray.hx"
						this.idx = ((uint) (@value) );
						#line 63 "C:\\HaxeToolkit\\haxe\\std\\cs\\NativeArray.hx"
						return @value;
					}
					
					
					default:
					{
						#line 63 "C:\\HaxeToolkit\\haxe\\std\\cs\\NativeArray.hx"
						return base.__hx_setField_f(field, hash, @value, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_setField(string field, int hash, object @value, bool handleProperties) {
			unchecked {
				#line 63 "C:\\HaxeToolkit\\haxe\\std\\cs\\NativeArray.hx"
				switch (hash) {
					case 5243965:
					{
						#line 63 "C:\\HaxeToolkit\\haxe\\std\\cs\\NativeArray.hx"
						this.idx = ((uint) (global::haxe.lang.Runtime.toInt(@value)) );
						#line 63 "C:\\HaxeToolkit\\haxe\\std\\cs\\NativeArray.hx"
						return @value;
					}
					
					
					case 4849249:
					{
						#line 63 "C:\\HaxeToolkit\\haxe\\std\\cs\\NativeArray.hx"
						this.arr = ((object[]) (@value) );
						#line 63 "C:\\HaxeToolkit\\haxe\\std\\cs\\NativeArray.hx"
						return @value;
					}
					
					
					default:
					{
						#line 63 "C:\\HaxeToolkit\\haxe\\std\\cs\\NativeArray.hx"
						return base.__hx_setField(field, hash, @value, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties) {
			unchecked {
				#line 63 "C:\\HaxeToolkit\\haxe\\std\\cs\\NativeArray.hx"
				switch (hash) {
					case 1224901875:
					{
						#line 63 "C:\\HaxeToolkit\\haxe\\std\\cs\\NativeArray.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "next", 1224901875)) );
					}
					
					
					case 407283053:
					{
						#line 63 "C:\\HaxeToolkit\\haxe\\std\\cs\\NativeArray.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "hasNext", 407283053)) );
					}
					
					
					case 5243965:
					{
						#line 63 "C:\\HaxeToolkit\\haxe\\std\\cs\\NativeArray.hx"
						return this.idx;
					}
					
					
					case 4849249:
					{
						#line 63 "C:\\HaxeToolkit\\haxe\\std\\cs\\NativeArray.hx"
						return this.arr;
					}
					
					
					default:
					{
						#line 63 "C:\\HaxeToolkit\\haxe\\std\\cs\\NativeArray.hx"
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override double __hx_getField_f(string field, int hash, bool throwErrors, bool handleProperties) {
			unchecked {
				#line 63 "C:\\HaxeToolkit\\haxe\\std\\cs\\NativeArray.hx"
				switch (hash) {
					case 5243965:
					{
						#line 63 "C:\\HaxeToolkit\\haxe\\std\\cs\\NativeArray.hx"
						return ((double) (this.idx) );
					}
					
					
					default:
					{
						#line 63 "C:\\HaxeToolkit\\haxe\\std\\cs\\NativeArray.hx"
						return base.__hx_getField_f(field, hash, throwErrors, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_invokeField(string field, int hash, object[] dynargs) {
			unchecked {
				#line 63 "C:\\HaxeToolkit\\haxe\\std\\cs\\NativeArray.hx"
				switch (hash) {
					case 1224901875:
					{
						#line 63 "C:\\HaxeToolkit\\haxe\\std\\cs\\NativeArray.hx"
						return this.next();
					}
					
					
					case 407283053:
					{
						#line 63 "C:\\HaxeToolkit\\haxe\\std\\cs\\NativeArray.hx"
						return this.hasNext();
					}
					
					
					default:
					{
						#line 63 "C:\\HaxeToolkit\\haxe\\std\\cs\\NativeArray.hx"
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override void __hx_getFields(global::haxe.root.Array baseArr) {
			#line 63 "C:\\HaxeToolkit\\haxe\\std\\cs\\NativeArray.hx"
			baseArr.push("idx");
			#line 63 "C:\\HaxeToolkit\\haxe\\std\\cs\\NativeArray.hx"
			baseArr.push("arr");
			#line 63 "C:\\HaxeToolkit\\haxe\\std\\cs\\NativeArray.hx"
			base.__hx_getFields(baseArr);
		}
		#line default
		
	}
}


