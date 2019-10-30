// Generated by Haxe 4.0.0+ef18b627e
using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.io {
	public class FPHelper : global::haxe.lang.HxObject {
		
		public FPHelper(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public FPHelper() {
			#line 29 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\FPHelper.hx"
			global::haxe.io.FPHelper.__hx_ctor_haxe_io_FPHelper(this);
		}
		#line default
		
		protected static void __hx_ctor_haxe_io_FPHelper(global::haxe.io.FPHelper __hx_this) {
		}
		
		
		public static double i32ToFloat(int i) {
			unchecked {
				#line 150 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\FPHelper.hx"
				global::haxe.io._FPHelper.SingleHelper helper = new global::haxe.io._FPHelper.SingleHelper(((float) (0) ));
				if (global::System.BitConverter.IsLittleEndian) {
					#line 152 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\FPHelper.hx"
					helper.i = i;
				}
				else {
					#line 154 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\FPHelper.hx"
					helper.i = ( ( ( ( ((int) (( ((uint) (i) ) >> 24 )) ) & 255 ) | ( (( ( i >> 16 ) & 255 )) << 8 ) ) | ( (( ( i >> 8 ) & 255 )) << 16 ) ) | ( (( i & 255 )) << 24 ) );
				}
				
				#line 157 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\FPHelper.hx"
				return ((double) (helper.f) );
			}
			#line default
		}
		
		
		public static int floatToI32(double f) {
			unchecked {
				#line 188 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\FPHelper.hx"
				global::haxe.io._FPHelper.SingleHelper helper = new global::haxe.io._FPHelper.SingleHelper(((float) (f) ));
				if (global::System.BitConverter.IsLittleEndian) {
					#line 190 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\FPHelper.hx"
					return helper.i;
				}
				else {
					#line 192 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\FPHelper.hx"
					int i = helper.i;
					return ( ( ( ( ((int) (( ((uint) (i) ) >> 24 )) ) & 255 ) | ( (( ( i >> 16 ) & 255 )) << 8 ) ) | ( (( ( i >> 8 ) & 255 )) << 16 ) ) | ( (( i & 255 )) << 24 ) );
				}
				
			}
			#line default
		}
		
		
		public static double i64ToDouble(int low, int high) {
			unchecked {
				#line 235 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\FPHelper.hx"
				global::haxe.io._FPHelper.FloatHelper helper = new global::haxe.io._FPHelper.FloatHelper(((double) (0) ));
				if (global::System.BitConverter.IsLittleEndian) {
					#line 237 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\FPHelper.hx"
					long this1 = ((long) (( ((long) (( ((long) (high) ) << 32 )) ) | ((long) (( ((long) (low) ) & ((long) (0xffffffffL) ) )) ) )) );
					#line 237 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\FPHelper.hx"
					helper.i = ((long) (this1) );
				}
				else {
					#line 239 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\FPHelper.hx"
					int i1 = high;
					#line 239 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\FPHelper.hx"
					int i2 = low;
					int j2 = ( ( ( ( ((int) (( ((uint) (i1) ) >> 24 )) ) & 255 ) | ( (( ( i1 >> 16 ) & 255 )) << 8 ) ) | ( (( ( i1 >> 8 ) & 255 )) << 16 ) ) | ( (( i1 & 255 )) << 24 ) );
					#line 241 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\FPHelper.hx"
					int j1 = ( ( ( ( ((int) (( ((uint) (i2) ) >> 24 )) ) & 255 ) | ( (( ( i2 >> 16 ) & 255 )) << 8 ) ) | ( (( ( i2 >> 8 ) & 255 )) << 16 ) ) | ( (( i2 & 255 )) << 24 ) );
					long this2 = ((long) (( ((long) (( ((long) (j1) ) << 32 )) ) | ((long) (( ((long) (j2) ) & ((long) (0xffffffffL) ) )) ) )) );
					helper.i = ((long) (this2) );
				}
				
				#line 244 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\FPHelper.hx"
				return helper.f;
			}
			#line default
		}
		
		
		public static long doubleToI64(double v) {
			unchecked {
				#line 300 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\FPHelper.hx"
				global::haxe.io._FPHelper.FloatHelper helper = new global::haxe.io._FPHelper.FloatHelper(v);
				if (global::System.BitConverter.IsLittleEndian) {
					#line 302 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\FPHelper.hx"
					return helper.i;
				}
				else {
					#line 304 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\FPHelper.hx"
					long i = helper.i;
					int i1 = ((int) (((long) (( ((long) (i) ) >> 32 )) )) );
					int i2 = ((int) (((long) (i) )) );
					#line 306 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\FPHelper.hx"
					int j2 = ((int) (( ((int) (( ((int) (( ((int) (( ((int) (((int) (( ((uint) (i1) ) >> 24 )) )) ) & 255 )) ) | ((int) (( (((int) (( ((int) (( i1 >> 16 )) ) & 255 )) )) << 8 )) ) )) ) | ((int) (( (((int) (( ((int) (( i1 >> 8 )) ) & 255 )) )) << 16 )) ) )) ) | ((int) (( (((int) (( i1 & 255 )) )) << 24 )) ) )) );
					int j1 = ((int) (( ((int) (( ((int) (( ((int) (( ((int) (((int) (( ((uint) (i2) ) >> 24 )) )) ) & 255 )) ) | ((int) (( (((int) (( ((int) (( i2 >> 16 )) ) & 255 )) )) << 8 )) ) )) ) | ((int) (( (((int) (( ((int) (( i2 >> 8 )) ) & 255 )) )) << 16 )) ) )) ) | ((int) (( (((int) (( i2 & 255 )) )) << 24 )) ) )) );
					#line 309 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\FPHelper.hx"
					long this1 = ((long) (( ((long) (( ((long) (j1) ) << 32 )) ) | ((long) (( ((long) (j2) ) & ((long) (0xffffffffL) ) )) ) )) );
					#line 309 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\FPHelper.hx"
					return ((long) (this1) );
				}
				
			}
			#line default
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.io._FPHelper {
	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct SingleHelper {
		
		public SingleHelper(float f) {
			#line 345 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\FPHelper.hx"
			this.i = 0;
			this.f = f;
		}
		#line default
		
		[System.Runtime.InteropServices.FieldOffset(0)]
		public int i;
		
		[System.Runtime.InteropServices.FieldOffset(0)]
		public float f;
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.io._FPHelper {
	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct FloatHelper {
		
		public FloatHelper(double f) {
			#line 358 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\FPHelper.hx"
			this.i = ((long) (0) );
			this.f = f;
		}
		#line default
		
		[System.Runtime.InteropServices.FieldOffset(0)]
		public long i;
		
		[System.Runtime.InteropServices.FieldOffset(0)]
		public double f;
		
	}
}


