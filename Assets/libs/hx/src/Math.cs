// Generated by Haxe 4.0.0+ef18b627e
using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.root {
	public class Math {
		
		public Math() {
		}
		
		
		public static readonly global::System.Random rand = new global::System.Random();
		
		public static readonly double PI = global::System.Math.PI;
		
		public static readonly double NaN = global::System.Double.NaN;
		
		public static readonly double NEGATIVE_INFINITY = global::System.Double.NegativeInfinity;
		
		public static readonly double POSITIVE_INFINITY = global::System.Double.PositiveInfinity;
		
		public static double abs(double v) {
			#line 36 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Math.hx"
			return global::System.Math.Abs(((double) (v) ));
		}
		#line default
		
		public static double min(double a, double b) {
			#line 40 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Math.hx"
			return global::System.Math.Min(((double) (a) ), ((double) (b) ));
		}
		#line default
		
		public static double max(double a, double b) {
			#line 44 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Math.hx"
			return global::System.Math.Max(((double) (a) ), ((double) (b) ));
		}
		#line default
		
		public static double sin(double v) {
			#line 48 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Math.hx"
			return global::System.Math.Sin(((double) (v) ));
		}
		#line default
		
		public static double cos(double v) {
			#line 52 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Math.hx"
			return global::System.Math.Cos(((double) (v) ));
		}
		#line default
		
		public static double atan2(double y, double x) {
			#line 56 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Math.hx"
			return global::System.Math.Atan2(((double) (y) ), ((double) (x) ));
		}
		#line default
		
		public static double tan(double v) {
			#line 60 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Math.hx"
			return global::System.Math.Tan(((double) (v) ));
		}
		#line default
		
		public static double exp(double v) {
			#line 64 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Math.hx"
			return global::System.Math.Exp(((double) (v) ));
		}
		#line default
		
		public static double log(double v) {
			#line 68 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Math.hx"
			return global::System.Math.Log(((double) (v) ));
		}
		#line default
		
		public static double sqrt(double v) {
			#line 72 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Math.hx"
			return global::System.Math.Sqrt(((double) (v) ));
		}
		#line default
		
		public static double fround(double v) {
			#line 76 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Math.hx"
			return global::System.Math.Floor(((double) (( v + 0.5 )) ));
		}
		#line default
		
		public static double ffloor(double v) {
			#line 80 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Math.hx"
			return global::System.Math.Floor(((double) (v) ));
		}
		#line default
		
		public static double fceil(double v) {
			#line 84 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Math.hx"
			return global::System.Math.Ceiling(((double) (v) ));
		}
		#line default
		
		public static int round(double v) {
			unchecked {
				#line 88 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Math.hx"
				int vint = ((int) (v) );
				double dec = ( v - vint );
				#line 90 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Math.hx"
				if (( ( dec >= 1 ) || ( dec <= -1 ) )) {
					#line 91 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Math.hx"
					return vint;
				}
				
				#line 92 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Math.hx"
				if (( dec >= .5 )) {
					#line 93 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Math.hx"
					return ( vint + 1 );
				}
				
				#line 94 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Math.hx"
				if (( dec < -.5 )) {
					#line 95 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Math.hx"
					return ( vint - 1 );
				}
				
				#line 96 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Math.hx"
				return vint;
			}
			#line default
		}
		
		
		public static int floor(double v) {
			#line 100 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Math.hx"
			return ((int) (global::System.Math.Floor(((double) (v) ))) );
		}
		#line default
		
		public static int ceil(double v) {
			#line 104 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Math.hx"
			return ((int) (global::System.Math.Ceiling(((double) (v) ))) );
		}
		#line default
		
		public static double atan(double v) {
			#line 108 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Math.hx"
			return global::System.Math.Atan(((double) (v) ));
		}
		#line default
		
		public static double asin(double v) {
			#line 112 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Math.hx"
			return global::System.Math.Asin(((double) (v) ));
		}
		#line default
		
		public static double acos(double v) {
			#line 116 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Math.hx"
			return global::System.Math.Acos(((double) (v) ));
		}
		#line default
		
		public static double pow(double v, double exp) {
			#line 120 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Math.hx"
			return global::System.Math.Pow(((double) (v) ), ((double) (exp) ));
		}
		#line default
		
		public static double random() {
			#line 124 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Math.hx"
			return global::haxe.root.Math.rand.NextDouble();
		}
		#line default
		
		public static bool isFinite(double f) {
			#line 128 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Math.hx"
			if ( ! (global::System.Double.IsInfinity(((double) (f) ))) ) {
				#line 128 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Math.hx"
				return  ! (global::System.Double.IsNaN(((double) (f) ))) ;
			}
			else {
				#line 128 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Math.hx"
				return false;
			}
			
		}
		#line default
		
		public static bool isNaN(double f) {
			#line 132 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Math.hx"
			return global::System.Double.IsNaN(((double) (f) ));
		}
		#line default
		
	}
}


