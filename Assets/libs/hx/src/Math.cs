// Generated by Haxe 4.1.0-rc.1+0d88c583b
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
			return global::System.Math.Abs(((double) (v) ));
		}
		
		
		public static double min(double a, double b) {
			return global::System.Math.Min(((double) (a) ), ((double) (b) ));
		}
		
		
		public static double max(double a, double b) {
			return global::System.Math.Max(((double) (a) ), ((double) (b) ));
		}
		
		
		public static double sin(double v) {
			return global::System.Math.Sin(((double) (v) ));
		}
		
		
		public static double cos(double v) {
			return global::System.Math.Cos(((double) (v) ));
		}
		
		
		public static double atan2(double y, double x) {
			return global::System.Math.Atan2(((double) (y) ), ((double) (x) ));
		}
		
		
		public static double tan(double v) {
			return global::System.Math.Tan(((double) (v) ));
		}
		
		
		public static double exp(double v) {
			return global::System.Math.Exp(((double) (v) ));
		}
		
		
		public static double log(double v) {
			return global::System.Math.Log(((double) (v) ));
		}
		
		
		public static double sqrt(double v) {
			return global::System.Math.Sqrt(((double) (v) ));
		}
		
		
		public static double fround(double v) {
			return global::System.Math.Floor(((double) (( v + 0.5 )) ));
		}
		
		
		public static double ffloor(double v) {
			return global::System.Math.Floor(((double) (v) ));
		}
		
		
		public static double fceil(double v) {
			return global::System.Math.Ceiling(((double) (v) ));
		}
		
		
		public static int round(double v) {
			unchecked {
				int vint = ((int) (v) );
				double dec = ( v - vint );
				if (( ( dec >= 1 ) || ( dec <= -1 ) )) {
					return vint;
				}
				
				if (( dec >= .5 )) {
					return ( vint + 1 );
				}
				
				if (( dec < -.5 )) {
					return ( vint - 1 );
				}
				
				return vint;
			}
		}
		
		
		public static int floor(double v) {
			return ((int) (global::System.Math.Floor(((double) (v) ))) );
		}
		
		
		public static int ceil(double v) {
			return ((int) (global::System.Math.Ceiling(((double) (v) ))) );
		}
		
		
		public static double atan(double v) {
			return global::System.Math.Atan(((double) (v) ));
		}
		
		
		public static double asin(double v) {
			return global::System.Math.Asin(((double) (v) ));
		}
		
		
		public static double acos(double v) {
			return global::System.Math.Acos(((double) (v) ));
		}
		
		
		public static double pow(double v, double exp) {
			return global::System.Math.Pow(((double) (v) ), ((double) (exp) ));
		}
		
		
		public static double random() {
			return global::haxe.root.Math.rand.NextDouble();
		}
		
		
		public static bool isFinite(double f) {
			if ( ! (global::System.Double.IsInfinity(((double) (f) ))) ) {
				return  ! (global::System.Double.IsNaN(((double) (f) ))) ;
			}
			else {
				return false;
			}
			
		}
		
		
		public static bool isNaN(double f) {
			return global::System.Double.IsNaN(((double) (f) ));
		}
		
		
	}
}


