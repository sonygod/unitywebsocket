// Generated by Haxe 4.1.0-rc.1+cd0f0219b
using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.root {
	public class Std {
		
		public Std() {
		}
		
		
		public static bool @is(object v, object t) {
			#line 29 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
			return global::haxe.root.Std.isOfType(v, t);
		}
		#line default
		
		public static bool isOfType(object v, object t) {
			#line 33 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
			if (( v == null )) {
				#line 34 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
				return false;
			}
			
			#line 35 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
			if (( t == null )) {
				#line 36 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
				return false;
			}
			
			#line 37 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
			global::System.Type clt = ((global::System.Type) (( t as global::System.Type )) );
			if (global::haxe.lang.Runtime.typeEq(clt, null)) {
				#line 39 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
				return false;
			}
			
			#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
			switch (( clt as global::System.Reflection.MemberInfo ).ToString()) {
				case "System.Boolean":
				{
					#line 47 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
					return v is bool;
				}
				
				
				case "System.Double":
				{
					#line 43 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
					return v is double || v is int;
				}
				
				
				case "System.Int32":
				{
					#line 45 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
					return global::haxe.lang.Runtime.isInt(v);
				}
				
				
				case "System.Object":
				{
					#line 49 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
					return true;
				}
				
				
			}
			
			#line 52 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
			global::System.Type vt = v.GetType();
			#line 54 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
			if (clt.IsAssignableFrom(((global::System.Type) (vt) ))) {
				#line 55 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
				return true;
			}
			
			#line 66 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
			return false;
		}
		#line default
		
		public static string @string(object s) {
			#line 70 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
			if (( s == null )) {
				#line 71 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
				return "null";
			}
			
			#line 72 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
			if (( s is bool )) {
				#line 73 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
				if (global::haxe.lang.Runtime.toBool(s)) {
					#line 73 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
					return "true";
				}
				else {
					#line 73 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
					return "false";
				}
				
			}
			
			#line 75 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
			return s.ToString();
		}
		#line default
		
		public static int @int(double x) {
			#line 79 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
			return ((int) (x) );
		}
		#line default
		
		public static object parseInt(string x) {
			unchecked {
				#line 83 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
				if (( x == null )) {
					#line 84 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
					return null;
				}
				
				#line 86 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
				int @base = 10;
				int len = x.Length;
				#line 88 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
				int foundCount = 0;
				int sign = 0;
				#line 90 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
				int firstDigitIndex = 0;
				int lastDigitIndex = -1;
				#line 92 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
				int previous = 0;
				#line 94 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
				{
					#line 94 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
					int _g = 0;
					#line 94 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
					int _g1 = len;
					#line 94 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
					while (( _g < _g1 )) {
						#line 94 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
						int i = _g++;
						int c = ( (((bool) (( ((uint) (i) ) < x.Length )) )) ? (((int) (x[i]) )) : (-1) );
						#line 96 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
						if (( ( ( c > 8 ) && ( c < 14 ) ) || ( c == 32 ) )) {
							#line 98 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
							if (( foundCount > 0 )) {
								#line 99 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
								return null;
							}
							
							#line 101 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
							continue;
						}
						else {
							#line 96 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
							switch (c) {
								case 43:
								{
									#line 104 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
									if (( foundCount == 0 )) {
										#line 105 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
										sign = 1;
									}
									else if (( ( 48 <= c ) && ( c <= 57 ) )) {
									}
									else if (( ( @base == 16 ) && (( ( ( 97 <= c ) && ( c <= 122 ) ) || ( ( 65 <= c ) && ( c <= 90 ) ) )) )) {
									}
									else {
										#line 112 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
										goto label1;
									}
									
									#line 104 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
									break;
								}
								
								
								case 45:
								{
									#line 102 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
									if (( foundCount == 0 )) {
										#line 103 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
										sign = -1;
									}
									else if (( ( 48 <= c ) && ( c <= 57 ) )) {
									}
									else if (( ( @base == 16 ) && (( ( ( 97 <= c ) && ( c <= 122 ) ) || ( ( 65 <= c ) && ( c <= 90 ) ) )) )) {
									}
									else {
										#line 112 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
										goto label1;
									}
									
									#line 102 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
									break;
								}
								
								
								case 48:
								{
									#line 106 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
									if (( ( foundCount == 0 ) || ( ( foundCount == 1 ) && ( sign != 0 ) ) )) {
									}
									else if (( ( 48 <= c ) && ( c <= 57 ) )) {
									}
									else if (( ( @base == 16 ) && (( ( ( 97 <= c ) && ( c <= 122 ) ) || ( ( 65 <= c ) && ( c <= 90 ) ) )) )) {
									}
									else {
										#line 112 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
										goto label1;
									}
									
									#line 106 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
									break;
								}
								
								
								case 88:
								case 120:
								{
									#line 107 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
									if (( ( previous == 48 ) && (( ( ( foundCount == 1 ) && ( sign == 0 ) ) || ( ( foundCount == 2 ) && ( sign != 0 ) ) )) )) {
										#line 108 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
										@base = 16;
									}
									else if (( ( 48 <= c ) && ( c <= 57 ) )) {
									}
									else if (( ( @base == 16 ) && (( ( ( 97 <= c ) && ( c <= 122 ) ) || ( ( 65 <= c ) && ( c <= 90 ) ) )) )) {
									}
									else {
										#line 112 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
										goto label1;
									}
									
									#line 107 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
									break;
								}
								
								
								default:
								{
									#line 109 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
									if (( ( 48 <= c ) && ( c <= 57 ) )) {
									}
									else if (( ( @base == 16 ) && (( ( ( 97 <= c ) && ( c <= 122 ) ) || ( ( 65 <= c ) && ( c <= 90 ) ) )) )) {
									}
									else {
										#line 112 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
										goto label1;
									}
									
									#line 109 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
									break;
								}
								
							}
							
						}
						
						#line 114 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
						if (( ( ( foundCount == 0 ) && ( sign == 0 ) ) || ( ( foundCount == 1 ) && ( sign != 0 ) ) )) {
							#line 115 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
							firstDigitIndex = i;
						}
						
						#line 117 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
						 ++ foundCount;
						lastDigitIndex = i;
						#line 119 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
						previous = c;
					}
					label1: {};
				}
				
				#line 121 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
				if (( firstDigitIndex <= lastDigitIndex )) {
					#line 122 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
					string digits = global::haxe.lang.StringExt.substring(x, firstDigitIndex, ( lastDigitIndex + 1 ));
					#line 124 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
					try {
						#line 124 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
						return ( (( (( sign == -1 )) ? (-1) : (1) )) * global::System.Convert.ToInt32(((string) (digits) ), ((int) (@base) )) );
					}
					catch (global::System.FormatException e){
						#line 126 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
						global::haxe.lang.Exceptions.exception = e;
						#line 126 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
						return null;
					}
					
					
				}
				
				#line 129 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
				return null;
			}
			#line default
		}
		
		
		public static double parseFloat(string x) {
			unchecked {
				#line 133 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
				if (( x == null )) {
					#line 134 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
					return global::haxe.root.Math.NaN;
				}
				
				#line 135 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
				x = x.TrimStart();
				bool found = false;
				bool hasDot = false;
				bool hasSign = false;
				bool hasE = false;
				bool hasESign = false;
				bool hasEData = false;
				#line 142 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
				int i = -1;
				#line 146 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
				while ((  ++ i < x.Length )) {
					#line 147 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
					int chr = ((int) (((global::System.String) (x) )[i]) );
					if (( ( chr >= 48 ) && ( chr <= 57 ) )) {
						#line 149 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
						if (hasE) {
							#line 150 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
							hasEData = true;
						}
						
						#line 152 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
						found = true;
					}
					else {
						#line 154 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
						switch (chr) {
							case 43:
							case 45:
							{
								#line 159 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
								if ((  ! (found)  &&  ! (hasSign)  )) {
									#line 160 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
									hasSign = true;
								}
								else if (( ( ( found &&  ! (hasESign)  ) && hasE ) &&  ! (hasEData)  )) {
									#line 162 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
									hasESign = true;
								}
								else {
									#line 164 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
									goto label1;
								}
								
								#line 159 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
								break;
							}
							
							
							case 46:
							{
								#line 157 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
								if ( ! (hasDot) ) {
									#line 158 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
									hasDot = true;
								}
								else {
									#line 164 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
									goto label1;
								}
								
								#line 157 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
								break;
							}
							
							
							case 69:
							case 101:
							{
								#line 155 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
								if ( ! (hasE) ) {
									#line 156 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
									hasE = true;
								}
								else {
									#line 164 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
									goto label1;
								}
								
								#line 155 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
								break;
							}
							
							
							default:
							{
								#line 164 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
								goto label1;
							}
							
						}
						
					}
					
				}
				label1: {};
				#line 167 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
				if (( hasE &&  ! (hasEData)  )) {
					#line 168 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
					 -- i;
					if (hasESign) {
						#line 170 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
						 -- i;
					}
					
				}
				
				#line 172 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
				if (( i != x.Length )) {
					#line 173 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
					x = global::haxe.lang.StringExt.substr(x, 0, i);
				}
				
				#line 175 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
				try {
					#line 175 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
					return global::System.Double.Parse(((string) (x) ), ((global::System.IFormatProvider) (global::System.Globalization.CultureInfo.InvariantCulture) ));
				}
				catch (global::System.Exception catchallException){
					#line 175 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
					global::haxe.lang.Exceptions.exception = catchallException;
					#line 175 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
					object e = ( (( catchallException is global::haxe.lang.HaxeException )) ? (((global::haxe.lang.HaxeException) (catchallException) ).obj) : ((object) (catchallException) ) );
					#line 175 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
					return global::haxe.root.Math.NaN;
				}
				
				
			}
			#line default
		}
		
		
		public static int random(int x) {
			#line 188 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
			if (( x <= 0 )) {
				#line 189 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
				return 0;
			}
			
			#line 190 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
			return global::haxe.root.Math.rand.Next(((int) (x) ));
		}
		#line default
		
	}
}


