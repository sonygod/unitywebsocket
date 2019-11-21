// Generated by Haxe 4.1.0-rc.1+0d88c583b
using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe {
	public class SysTools : global::haxe.lang.HxObject {
		
		static SysTools() {
			unchecked{
				global::haxe.SysTools.winMetaCharacters = ((global::haxe.root.Array) (new global::haxe.root.Array(new object[]{32, 40, 41, 37, 33, 94, 34, 60, 62, 38, 124, 10, 13, 44, 59})) );
			}
		}
		
		
		public SysTools(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public SysTools() {
			global::haxe.SysTools.__hx_ctor_haxe_SysTools(this);
		}
		
		
		protected static void __hx_ctor_haxe_SysTools(global::haxe.SysTools __hx_this) {
		}
		
		
		public static global::haxe.root.Array winMetaCharacters;
		
		public static string quoteUnixArg(string argument) {
			if (( argument == "" )) {
				return "\'\'";
			}
			
			if ( ! (new global::haxe.root.EReg("[^a-zA-Z0-9_@%+=:,./-]", "").match(argument)) ) {
				return argument;
			}
			
			return global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("\'", global::haxe.root.StringTools.replace(argument, "\'", "\'\"\'\"\'")), "\'");
		}
		
		
		public static string quoteWinArg(string argument, bool escapeMetaCharacters) {
			unchecked {
				if ( ! (new global::haxe.root.EReg("^[^ \t\\\\\"]+$", "").match(argument)) ) {
					global::haxe.root.StringBuf result = new global::haxe.root.StringBuf();
					bool needquote = ( ( ( global::haxe.lang.StringExt.indexOf(argument, " ", null) != -1 ) || ( global::haxe.lang.StringExt.indexOf(argument, "\t", null) != -1 ) ) || ( argument == "" ) );
					if (needquote) {
						result.b.Append(((string) ("\"") ));
					}
					
					global::haxe.root.StringBuf bs_buf = new global::haxe.root.StringBuf();
					{
						int _g = 0;
						int _g1 = argument.Length;
						while (( _g < _g1 )) {
							int i = _g++;
							{
								object _g2 = global::haxe.lang.StringExt.charCodeAt(argument, i);
								if (( _g2 == default(object) )) {
									object c = _g2;
									{
										if (( bs_buf.b.Length > 0 )) {
											{
												string x = bs_buf.b.ToString();
												result.b.Append(((string) (global::haxe.root.Std.@string(x)) ));
											}
											
											bs_buf = new global::haxe.root.StringBuf();
										}
										
										result.addChar(((int) (global::haxe.lang.Runtime.toInt(c)) ));
									}
									
								}
								else {
									switch (((int) (global::haxe.lang.Runtime.toInt((_g2))) )) {
										case 34:
										{
											string bs = bs_buf.b.ToString();
											result.b.Append(((string) (global::haxe.root.Std.@string(bs)) ));
											result.b.Append(((string) (global::haxe.root.Std.@string(bs)) ));
											bs_buf = new global::haxe.root.StringBuf();
											result.b.Append(((string) ("\\\"") ));
											break;
										}
										
										
										case 92:
										{
											bs_buf.b.Append(((string) ("\\") ));
											break;
										}
										
										
										default:
										{
											object c1 = _g2;
											{
												if (( bs_buf.b.Length > 0 )) {
													{
														string x1 = bs_buf.b.ToString();
														result.b.Append(((string) (global::haxe.root.Std.@string(x1)) ));
													}
													
													bs_buf = new global::haxe.root.StringBuf();
												}
												
												result.addChar(((int) (global::haxe.lang.Runtime.toInt(c1)) ));
											}
											
											break;
										}
										
									}
									
								}
								
							}
							
						}
						
					}
					
					{
						string x2 = bs_buf.b.ToString();
						result.b.Append(((string) (global::haxe.root.Std.@string(x2)) ));
					}
					
					if (needquote) {
						{
							string x3 = bs_buf.b.ToString();
							result.b.Append(((string) (global::haxe.root.Std.@string(x3)) ));
						}
						
						result.b.Append(((string) ("\"") ));
					}
					
					argument = result.b.ToString();
				}
				
				if (escapeMetaCharacters) {
					global::haxe.root.StringBuf result1 = new global::haxe.root.StringBuf();
					{
						int _g3 = 0;
						int _g11 = argument.Length;
						while (( _g3 < _g11 )) {
							int i1 = _g3++;
							object c2 = global::haxe.lang.StringExt.charCodeAt(argument, i1);
							if (( global::haxe.SysTools.winMetaCharacters.indexOf(c2, null) >= 0 )) {
								result1.addChar(94);
							}
							
							result1.addChar(((int) (global::haxe.lang.Runtime.toInt(c2)) ));
						}
						
					}
					
					return result1.b.ToString();
				}
				else {
					return argument;
				}
				
			}
		}
		
		
	}
}


