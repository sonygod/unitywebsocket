// Generated by Haxe 4.0.0+ef18b627e
using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.root {
	public class Random : global::haxe.lang.HxObject {
		
		public Random(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public Random() {
			#line 12 "C:\\HaxeToolkit\\haxe\\lib\\random\\1,4,1\\src\\Random.hx"
			global::haxe.root.Random.__hx_ctor__Random(this);
		}
		#line default
		
		protected static void __hx_ctor__Random(global::haxe.root.Random __hx_this) {
		}
		
		
		public static bool @bool() {
			#line 17 "C:\\HaxeToolkit\\haxe\\lib\\random\\1,4,1\\src\\Random.hx"
			return ( global::haxe.root.Math.rand.NextDouble() < 0.5 );
		}
		#line default
		
		public static int @int(int @from, int to) {
			unchecked {
				#line 23 "C:\\HaxeToolkit\\haxe\\lib\\random\\1,4,1\\src\\Random.hx"
				return ( @from + ((int) (global::System.Math.Floor(((double) (( (( ( to - @from ) + 1 )) * global::haxe.root.Math.rand.NextDouble() )) ))) ) );
			}
			#line default
		}
		
		
		public static double @float(double @from, double to) {
			#line 29 "C:\\HaxeToolkit\\haxe\\lib\\random\\1,4,1\\src\\Random.hx"
			return ( @from + ( (( to - @from )) * global::haxe.root.Math.rand.NextDouble() ) );
		}
		#line default
		
		public static string @string(int length, string charactersToUse) {
			unchecked {
				#line 35 "C:\\HaxeToolkit\\haxe\\lib\\random\\1,4,1\\src\\Random.hx"
				if (( charactersToUse == null )) {
					#line 35 "C:\\HaxeToolkit\\haxe\\lib\\random\\1,4,1\\src\\Random.hx"
					charactersToUse = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
				}
				
				#line 36 "C:\\HaxeToolkit\\haxe\\lib\\random\\1,4,1\\src\\Random.hx"
				string str = "";
				{
					#line 37 "C:\\HaxeToolkit\\haxe\\lib\\random\\1,4,1\\src\\Random.hx"
					int _g = 0;
					#line 37 "C:\\HaxeToolkit\\haxe\\lib\\random\\1,4,1\\src\\Random.hx"
					int _g1 = length;
					#line 37 "C:\\HaxeToolkit\\haxe\\lib\\random\\1,4,1\\src\\Random.hx"
					while (( _g < _g1 )) {
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\random\\1,4,1\\src\\Random.hx"
						int i = _g++;
						#line 39 "C:\\HaxeToolkit\\haxe\\lib\\random\\1,4,1\\src\\Random.hx"
						str = global::haxe.lang.Runtime.concat(str, global::haxe.lang.StringExt.charAt(charactersToUse, ((int) (global::System.Math.Floor(((double) (( (( ( charactersToUse.Length - 1 ) + 1 )) * global::haxe.root.Math.rand.NextDouble() )) ))) )));
					}
					
				}
				
				#line 41 "C:\\HaxeToolkit\\haxe\\lib\\random\\1,4,1\\src\\Random.hx"
				return str;
			}
			#line default
		}
		
		
		public static global::haxe.root.Date date(global::haxe.root.Date earliest, global::haxe.root.Date latest) {
			#line 47 "C:\\HaxeToolkit\\haxe\\lib\\random\\1,4,1\\src\\Random.hx"
			double @from = ( ((double) (((long) (( ((long) (global::System.TimeZone.CurrentTimeZone.ToUniversalTime(((global::System.DateTime) (earliest.date) )).Ticks) ) - ((long) (global::haxe.root.Date.epochTicks) ) )) )) ) / ((double) (global::System.TimeSpan.TicksPerMillisecond) ) );
			#line 47 "C:\\HaxeToolkit\\haxe\\lib\\random\\1,4,1\\src\\Random.hx"
			double t = ( @from + ( (( ( ((double) (((long) (( ((long) (global::System.TimeZone.CurrentTimeZone.ToUniversalTime(((global::System.DateTime) (latest.date) )).Ticks) ) - ((long) (global::haxe.root.Date.epochTicks) ) )) )) ) / ((double) (global::System.TimeSpan.TicksPerMillisecond) ) ) - @from )) * global::haxe.root.Math.rand.NextDouble() ) );
			#line 47 "C:\\HaxeToolkit\\haxe\\lib\\random\\1,4,1\\src\\Random.hx"
			return new global::haxe.root.Date(((global::System.DateTime) (global::System.TimeZone.CurrentTimeZone.ToLocalTime(((global::System.DateTime) (new global::System.DateTime(((long) (( ((long) (( t * ((double) (global::System.TimeSpan.TicksPerMillisecond) ) )) ) + ((long) (global::haxe.root.Date.epochTicks) ) )) ))) ))) ));
		}
		#line default
		
		public static object fromArray(global::haxe.root.Array arr) {
			unchecked {
				#line 53 "C:\\HaxeToolkit\\haxe\\lib\\random\\1,4,1\\src\\Random.hx"
				if (( ( arr != null ) && ( arr.length > 0 ) )) {
					#line 53 "C:\\HaxeToolkit\\haxe\\lib\\random\\1,4,1\\src\\Random.hx"
					return arr.__get(((int) (global::System.Math.Floor(((double) (( (( ( arr.length - 1 ) + 1 )) * global::haxe.root.Math.rand.NextDouble() )) ))) ));
				}
				else {
					#line 53 "C:\\HaxeToolkit\\haxe\\lib\\random\\1,4,1\\src\\Random.hx"
					return null;
				}
				
			}
			#line default
		}
		
		
		public static global::haxe.root.Array shuffle(global::haxe.root.Array arr) {
			unchecked {
				#line 60 "C:\\HaxeToolkit\\haxe\\lib\\random\\1,4,1\\src\\Random.hx"
				if (( arr != null )) {
					#line 61 "C:\\HaxeToolkit\\haxe\\lib\\random\\1,4,1\\src\\Random.hx"
					int _g = 0;
					#line 61 "C:\\HaxeToolkit\\haxe\\lib\\random\\1,4,1\\src\\Random.hx"
					int _g1 = arr.length;
					#line 61 "C:\\HaxeToolkit\\haxe\\lib\\random\\1,4,1\\src\\Random.hx"
					while (( _g < _g1 )) {
						#line 61 "C:\\HaxeToolkit\\haxe\\lib\\random\\1,4,1\\src\\Random.hx"
						int i = _g++;
						int j = ((int) (global::System.Math.Floor(((double) (( (( ( arr.length - 1 ) + 1 )) * global::haxe.root.Math.rand.NextDouble() )) ))) );
						#line 63 "C:\\HaxeToolkit\\haxe\\lib\\random\\1,4,1\\src\\Random.hx"
						object a = arr.__get(i);
						object b = arr.__get(j);
						#line 65 "C:\\HaxeToolkit\\haxe\\lib\\random\\1,4,1\\src\\Random.hx"
						arr.__set(i, b);
						arr.__set(j, a);
					}
					
				}
				
				#line 69 "C:\\HaxeToolkit\\haxe\\lib\\random\\1,4,1\\src\\Random.hx"
				return arr;
			}
			#line default
		}
		
		
		public static object fromIterable(object it) {
			unchecked {
				#line 75 "C:\\HaxeToolkit\\haxe\\lib\\random\\1,4,1\\src\\Random.hx"
				if (( it != null )) {
					#line 75 "C:\\HaxeToolkit\\haxe\\lib\\random\\1,4,1\\src\\Random.hx"
					global::haxe.root.Array arr = global::haxe.root.Lambda.array(((object) (it) ));
					#line 75 "C:\\HaxeToolkit\\haxe\\lib\\random\\1,4,1\\src\\Random.hx"
					if (( ( arr != null ) && ( arr.length > 0 ) )) {
						#line 75 "C:\\HaxeToolkit\\haxe\\lib\\random\\1,4,1\\src\\Random.hx"
						return arr.__get(((int) (global::System.Math.Floor(((double) (( (( ( arr.length - 1 ) + 1 )) * global::haxe.root.Math.rand.NextDouble() )) ))) ));
					}
					else {
						#line 75 "C:\\HaxeToolkit\\haxe\\lib\\random\\1,4,1\\src\\Random.hx"
						return null;
					}
					
				}
				else {
					#line 75 "C:\\HaxeToolkit\\haxe\\lib\\random\\1,4,1\\src\\Random.hx"
					return null;
				}
				
			}
			#line default
		}
		
		
		public static object enumConstructor(global::System.Type e) {
			unchecked {
				#line 81 "C:\\HaxeToolkit\\haxe\\lib\\random\\1,4,1\\src\\Random.hx"
				if ( ! (global::haxe.lang.Runtime.typeEq(e, null)) ) {
					#line 81 "C:\\HaxeToolkit\\haxe\\lib\\random\\1,4,1\\src\\Random.hx"
					global::haxe.root.Array arr = global::haxe.root.Type.allEnums(((global::System.Type) (e) ));
					#line 81 "C:\\HaxeToolkit\\haxe\\lib\\random\\1,4,1\\src\\Random.hx"
					if (( ( arr != null ) && ( arr.length > 0 ) )) {
						#line 81 "C:\\HaxeToolkit\\haxe\\lib\\random\\1,4,1\\src\\Random.hx"
						return arr.__get(((int) (global::System.Math.Floor(((double) (( (( ( arr.length - 1 ) + 1 )) * global::haxe.root.Math.rand.NextDouble() )) ))) ));
					}
					else {
						#line 81 "C:\\HaxeToolkit\\haxe\\lib\\random\\1,4,1\\src\\Random.hx"
						return null;
					}
					
				}
				else {
					#line 81 "C:\\HaxeToolkit\\haxe\\lib\\random\\1,4,1\\src\\Random.hx"
					return null;
				}
				
			}
			#line default
		}
		
		
	}
}


