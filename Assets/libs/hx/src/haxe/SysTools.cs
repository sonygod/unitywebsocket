// Generated by Haxe 4.1.0-rc.1+0d88c583b
using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe {
	public class SysTools : global::haxe.lang.HxObject {
		
		static SysTools() {
			unchecked{
				#line 9 "C:\\HaxeToolkit\\haxe\\std\\haxe\\SysTools.hx"
				global::haxe.SysTools.winMetaCharacters = ((global::haxe.root.Array) (new global::haxe.root.Array(new object[]{32, 40, 41, 37, 33, 94, 34, 60, 62, 38, 124, 10, 13, 44, 59})) );
			}
		}
		#line default
		
		public SysTools(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public SysTools() {
			#line 5 "C:\\HaxeToolkit\\haxe\\std\\haxe\\SysTools.hx"
			global::haxe.SysTools.__hx_ctor_haxe_SysTools(this);
		}
		#line default
		
		protected static void __hx_ctor_haxe_SysTools(global::haxe.SysTools __hx_this) {
		}
		
		
		public static global::haxe.root.Array winMetaCharacters;
		
		public static string quoteUnixArg(string argument) {
			#line 22 "C:\\HaxeToolkit\\haxe\\std\\haxe\\SysTools.hx"
			if (( argument == "" )) {
				#line 23 "C:\\HaxeToolkit\\haxe\\std\\haxe\\SysTools.hx"
				return "\'\'";
			}
			
			#line 25 "C:\\HaxeToolkit\\haxe\\std\\haxe\\SysTools.hx"
			if ( ! (new global::haxe.root.EReg("[^a-zA-Z0-9_@%+=:,./-]", "").match(argument)) ) {
				#line 26 "C:\\HaxeToolkit\\haxe\\std\\haxe\\SysTools.hx"
				return argument;
			}
			
			#line 30 "C:\\HaxeToolkit\\haxe\\std\\haxe\\SysTools.hx"
			return global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("\'", global::haxe.root.StringTools.replace(argument, "\'", "\'\"\'\"\'")), "\'");
		}
		#line default
		
		public static string quoteWinArg(string argument, bool escapeMetaCharacters) {
			unchecked {
				#line 48 "C:\\HaxeToolkit\\haxe\\std\\haxe\\SysTools.hx"
				if ( ! (new global::haxe.root.EReg("^[^ \t\\\\\"]+$", "").match(argument)) ) {
					#line 52 "C:\\HaxeToolkit\\haxe\\std\\haxe\\SysTools.hx"
					global::haxe.root.StringBuf result = new global::haxe.root.StringBuf();
					bool needquote = ( ( ( global::haxe.lang.StringExt.indexOf(argument, " ", null) != -1 ) || ( global::haxe.lang.StringExt.indexOf(argument, "\t", null) != -1 ) ) || ( argument == "" ) );
					#line 55 "C:\\HaxeToolkit\\haxe\\std\\haxe\\SysTools.hx"
					if (needquote) {
						#line 56 "C:\\HaxeToolkit\\haxe\\std\\haxe\\SysTools.hx"
						result.b.Append(((string) ("\"") ));
					}
					
					#line 58 "C:\\HaxeToolkit\\haxe\\std\\haxe\\SysTools.hx"
					global::haxe.root.StringBuf bs_buf = new global::haxe.root.StringBuf();
					{
						#line 59 "C:\\HaxeToolkit\\haxe\\std\\haxe\\SysTools.hx"
						int _g = 0;
						#line 59 "C:\\HaxeToolkit\\haxe\\std\\haxe\\SysTools.hx"
						int _g1 = argument.Length;
						#line 59 "C:\\HaxeToolkit\\haxe\\std\\haxe\\SysTools.hx"
						while (( _g < _g1 )) {
							#line 59 "C:\\HaxeToolkit\\haxe\\std\\haxe\\SysTools.hx"
							int i = _g++;
							{
								#line 60 "C:\\HaxeToolkit\\haxe\\std\\haxe\\SysTools.hx"
								object _g2 = global::haxe.lang.StringExt.charCodeAt(argument, i);
								#line 60 "C:\\HaxeToolkit\\haxe\\std\\haxe\\SysTools.hx"
								if (( _g2 == default(object) )) {
									#line 71 "C:\\HaxeToolkit\\haxe\\std\\haxe\\SysTools.hx"
									object c = _g2;
									#line 71 "C:\\HaxeToolkit\\haxe\\std\\haxe\\SysTools.hx"
									{
										#line 73 "C:\\HaxeToolkit\\haxe\\std\\haxe\\SysTools.hx"
										if (( bs_buf.b.Length > 0 )) {
											#line 74 "C:\\HaxeToolkit\\haxe\\std\\haxe\\SysTools.hx"
											{
												#line 74 "C:\\HaxeToolkit\\haxe\\std\\haxe\\SysTools.hx"
												string x = bs_buf.b.ToString();
												#line 74 "C:\\HaxeToolkit\\haxe\\std\\haxe\\SysTools.hx"
												result.b.Append(((string) (global::haxe.root.Std.@string(x)) ));
											}
											
											#line 75 "C:\\HaxeToolkit\\haxe\\std\\haxe\\SysTools.hx"
											bs_buf = new global::haxe.root.StringBuf();
										}
										
										#line 77 "C:\\HaxeToolkit\\haxe\\std\\haxe\\SysTools.hx"
										result.addChar(((int) (global::haxe.lang.Runtime.toInt(c)) ));
									}
									
								}
								else {
									#line 60 "C:\\HaxeToolkit\\haxe\\std\\haxe\\SysTools.hx"
									switch (((int) (global::haxe.lang.Runtime.toInt((_g2))) )) {
										case 34:
										{
											#line 66 "C:\\HaxeToolkit\\haxe\\std\\haxe\\SysTools.hx"
											string bs = bs_buf.b.ToString();
											result.b.Append(((string) (global::haxe.root.Std.@string(bs)) ));
											#line 68 "C:\\HaxeToolkit\\haxe\\std\\haxe\\SysTools.hx"
											result.b.Append(((string) (global::haxe.root.Std.@string(bs)) ));
											bs_buf = new global::haxe.root.StringBuf();
											#line 70 "C:\\HaxeToolkit\\haxe\\std\\haxe\\SysTools.hx"
											result.b.Append(((string) ("\\\"") ));
											#line 64 "C:\\HaxeToolkit\\haxe\\std\\haxe\\SysTools.hx"
											break;
										}
										
										
										case 92:
										{
											#line 63 "C:\\HaxeToolkit\\haxe\\std\\haxe\\SysTools.hx"
											bs_buf.b.Append(((string) ("\\") ));
											#line 63 "C:\\HaxeToolkit\\haxe\\std\\haxe\\SysTools.hx"
											break;
										}
										
										
										default:
										{
											#line 71 "C:\\HaxeToolkit\\haxe\\std\\haxe\\SysTools.hx"
											object c1 = _g2;
											#line 71 "C:\\HaxeToolkit\\haxe\\std\\haxe\\SysTools.hx"
											{
												#line 73 "C:\\HaxeToolkit\\haxe\\std\\haxe\\SysTools.hx"
												if (( bs_buf.b.Length > 0 )) {
													#line 74 "C:\\HaxeToolkit\\haxe\\std\\haxe\\SysTools.hx"
													{
														#line 74 "C:\\HaxeToolkit\\haxe\\std\\haxe\\SysTools.hx"
														string x1 = bs_buf.b.ToString();
														#line 74 "C:\\HaxeToolkit\\haxe\\std\\haxe\\SysTools.hx"
														result.b.Append(((string) (global::haxe.root.Std.@string(x1)) ));
													}
													
													#line 75 "C:\\HaxeToolkit\\haxe\\std\\haxe\\SysTools.hx"
													bs_buf = new global::haxe.root.StringBuf();
												}
												
												#line 77 "C:\\HaxeToolkit\\haxe\\std\\haxe\\SysTools.hx"
												result.addChar(((int) (global::haxe.lang.Runtime.toInt(c1)) ));
											}
											
											#line 71 "C:\\HaxeToolkit\\haxe\\std\\haxe\\SysTools.hx"
											break;
										}
										
									}
									
								}
								
							}
							
						}
						
					}
					
					#line 82 "C:\\HaxeToolkit\\haxe\\std\\haxe\\SysTools.hx"
					{
						#line 82 "C:\\HaxeToolkit\\haxe\\std\\haxe\\SysTools.hx"
						string x2 = bs_buf.b.ToString();
						#line 82 "C:\\HaxeToolkit\\haxe\\std\\haxe\\SysTools.hx"
						result.b.Append(((string) (global::haxe.root.Std.@string(x2)) ));
					}
					
					#line 84 "C:\\HaxeToolkit\\haxe\\std\\haxe\\SysTools.hx"
					if (needquote) {
						#line 85 "C:\\HaxeToolkit\\haxe\\std\\haxe\\SysTools.hx"
						{
							#line 85 "C:\\HaxeToolkit\\haxe\\std\\haxe\\SysTools.hx"
							string x3 = bs_buf.b.ToString();
							#line 85 "C:\\HaxeToolkit\\haxe\\std\\haxe\\SysTools.hx"
							result.b.Append(((string) (global::haxe.root.Std.@string(x3)) ));
						}
						
						#line 86 "C:\\HaxeToolkit\\haxe\\std\\haxe\\SysTools.hx"
						result.b.Append(((string) ("\"") ));
					}
					
					#line 89 "C:\\HaxeToolkit\\haxe\\std\\haxe\\SysTools.hx"
					argument = result.b.ToString();
				}
				
				#line 92 "C:\\HaxeToolkit\\haxe\\std\\haxe\\SysTools.hx"
				if (escapeMetaCharacters) {
					#line 93 "C:\\HaxeToolkit\\haxe\\std\\haxe\\SysTools.hx"
					global::haxe.root.StringBuf result1 = new global::haxe.root.StringBuf();
					{
						#line 94 "C:\\HaxeToolkit\\haxe\\std\\haxe\\SysTools.hx"
						int _g3 = 0;
						#line 94 "C:\\HaxeToolkit\\haxe\\std\\haxe\\SysTools.hx"
						int _g11 = argument.Length;
						#line 94 "C:\\HaxeToolkit\\haxe\\std\\haxe\\SysTools.hx"
						while (( _g3 < _g11 )) {
							#line 94 "C:\\HaxeToolkit\\haxe\\std\\haxe\\SysTools.hx"
							int i1 = _g3++;
							object c2 = global::haxe.lang.StringExt.charCodeAt(argument, i1);
							#line 96 "C:\\HaxeToolkit\\haxe\\std\\haxe\\SysTools.hx"
							if (( global::haxe.SysTools.winMetaCharacters.indexOf(c2, null) >= 0 )) {
								#line 97 "C:\\HaxeToolkit\\haxe\\std\\haxe\\SysTools.hx"
								result1.addChar(94);
							}
							
							#line 99 "C:\\HaxeToolkit\\haxe\\std\\haxe\\SysTools.hx"
							result1.addChar(((int) (global::haxe.lang.Runtime.toInt(c2)) ));
						}
						
					}
					
					#line 101 "C:\\HaxeToolkit\\haxe\\std\\haxe\\SysTools.hx"
					return result1.b.ToString();
				}
				else {
					#line 103 "C:\\HaxeToolkit\\haxe\\std\\haxe\\SysTools.hx"
					return argument;
				}
				
			}
			#line default
		}
		
		
	}
}


