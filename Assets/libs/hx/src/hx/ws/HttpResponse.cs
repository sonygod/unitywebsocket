// Generated by Haxe 4.1.0-rc.1+0d88c583b
using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace hx.ws {
	public class HttpResponse : global::haxe.lang.HxObject {
		
		public HttpResponse(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public HttpResponse() {
			#line 10 "d:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpResponse.hx"
			global::hx.ws.HttpResponse.__hx_ctor_hx_ws_HttpResponse(this);
		}
		#line default
		
		protected static void __hx_ctor_hx_ws_HttpResponse(global::hx.ws.HttpResponse __hx_this) {
			unchecked {
				#line 8 "d:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpResponse.hx"
				__hx_this.headers = new global::haxe.ds.StringMap();
				#line 6 "d:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpResponse.hx"
				__hx_this.text = "";
				#line 5 "d:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpResponse.hx"
				__hx_this.code = -1;
				#line 4 "d:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpResponse.hx"
				__hx_this.httpVersion = "HTTP/1.1";
				#line 10 "d:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpResponse.hx"
				{
				}
				
			}
			#line default
		}
		
		
		public string httpVersion;
		
		public int code;
		
		public string text;
		
		public global::haxe.ds.StringMap headers;
		
		public virtual void addLine(string line) {
			unchecked {
				#line 14 "d:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpResponse.hx"
				if (( this.code == -1 )) {
					#line 15 "d:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpResponse.hx"
					global::haxe.root.Array parts = global::haxe.lang.StringExt.split(line, " ");
					this.httpVersion = global::haxe.lang.Runtime.toString(parts.__get(0));
					#line 17 "d:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpResponse.hx"
					this.code = ((int) (global::haxe.lang.Runtime.toInt(global::haxe.root.Std.parseInt(global::haxe.lang.Runtime.toString(parts.__get(1))))) );
					this.text = global::haxe.lang.Runtime.toString(parts.__get(2));
				}
				else {
					#line 20 "d:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpResponse.hx"
					int n = global::haxe.lang.StringExt.indexOf(line, ":", null);
					string name = global::haxe.lang.StringExt.substr(line, 0, n);
					#line 22 "d:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpResponse.hx"
					string @value = global::haxe.lang.StringExt.substr(line, ( n + 1 ), line.Length);
					((global::haxe.ds.StringMap) (((global::haxe.IMap) (this.headers) )) ).@set(((string) (name.Trim()) ), ((object) (@value.Trim()) ));
				}
				
			}
			#line default
		}
		
		
		public virtual string build() {
			#line 28 "d:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpResponse.hx"
			global::System.Text.StringBuilder sb_b = new global::System.Text.StringBuilder();
			#line 30 "d:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpResponse.hx"
			sb_b.Append(((string) (global::haxe.root.Std.@string(this.httpVersion)) ));
			sb_b.Append(((string) (" ") ));
			#line 32 "d:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpResponse.hx"
			sb_b.Append(((string) (global::haxe.root.Std.@string(this.code)) ));
			if (( this.text != "" )) {
				#line 34 "d:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpResponse.hx"
				sb_b.Append(((string) (" ") ));
				sb_b.Append(((string) (global::haxe.root.Std.@string(this.text)) ));
			}
			
			#line 37 "d:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpResponse.hx"
			sb_b.Append(((string) ("\r\n") ));
			#line 39 "d:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpResponse.hx"
			{
				#line 39 "d:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpResponse.hx"
				object header = ((object) (new global::haxe.ds._StringMap.StringMapKeyIterator(((global::haxe.ds.StringMap) (((global::haxe.IMap) (this.headers) )) ))) );
				#line 39 "d:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpResponse.hx"
				while (global::haxe.lang.Runtime.toBool(global::haxe.lang.Runtime.callField(header, "hasNext", 407283053, null))) {
					#line 39 "d:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpResponse.hx"
					string header1 = global::haxe.lang.Runtime.toString(global::haxe.lang.Runtime.callField(header, "next", 1224901875, null));
					sb_b.Append(((string) (global::haxe.root.Std.@string(header1)) ));
					#line 41 "d:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpResponse.hx"
					sb_b.Append(((string) (": ") ));
					sb_b.Append(((string) (global::haxe.root.Std.@string(global::haxe.lang.Runtime.toString(((global::haxe.ds.StringMap) (((global::haxe.IMap) (this.headers) )) ).@get(((string) (header1) ))))) ));
					#line 43 "d:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpResponse.hx"
					sb_b.Append(((string) ("\r\n") ));
				}
				
			}
			
			#line 46 "d:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpResponse.hx"
			sb_b.Append(((string) ("\r\n") ));
			return sb_b.ToString();
		}
		#line default
		
		public virtual string toString() {
			#line 51 "d:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpResponse.hx"
			return this.build();
		}
		#line default
		
		public override double __hx_setField_f(string field, int hash, double @value, bool handleProperties) {
			unchecked {
				#line 3 "d:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpResponse.hx"
				switch (hash) {
					case 1103409453:
					{
						#line 3 "d:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpResponse.hx"
						this.code = ((int) (@value) );
						#line 3 "d:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpResponse.hx"
						return @value;
					}
					
					
					default:
					{
						#line 3 "d:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpResponse.hx"
						return base.__hx_setField_f(field, hash, @value, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_setField(string field, int hash, object @value, bool handleProperties) {
			unchecked {
				#line 3 "d:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpResponse.hx"
				switch (hash) {
					case 1661489734:
					{
						#line 3 "d:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpResponse.hx"
						this.headers = ((global::haxe.ds.StringMap) (@value) );
						#line 3 "d:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpResponse.hx"
						return @value;
					}
					
					
					case 1291439277:
					{
						#line 3 "d:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpResponse.hx"
						this.text = global::haxe.lang.Runtime.toString(@value);
						#line 3 "d:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpResponse.hx"
						return @value;
					}
					
					
					case 1103409453:
					{
						#line 3 "d:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpResponse.hx"
						this.code = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						#line 3 "d:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpResponse.hx"
						return @value;
					}
					
					
					case 1641182320:
					{
						#line 3 "d:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpResponse.hx"
						this.httpVersion = global::haxe.lang.Runtime.toString(@value);
						#line 3 "d:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpResponse.hx"
						return @value;
					}
					
					
					default:
					{
						#line 3 "d:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpResponse.hx"
						return base.__hx_setField(field, hash, @value, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties) {
			unchecked {
				#line 3 "d:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpResponse.hx"
				switch (hash) {
					case 946786476:
					{
						#line 3 "d:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpResponse.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "toString", 946786476)) );
					}
					
					
					case 988470062:
					{
						#line 3 "d:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpResponse.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "build", 988470062)) );
					}
					
					
					case 66083509:
					{
						#line 3 "d:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpResponse.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "addLine", 66083509)) );
					}
					
					
					case 1661489734:
					{
						#line 3 "d:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpResponse.hx"
						return this.headers;
					}
					
					
					case 1291439277:
					{
						#line 3 "d:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpResponse.hx"
						return this.text;
					}
					
					
					case 1103409453:
					{
						#line 3 "d:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpResponse.hx"
						return this.code;
					}
					
					
					case 1641182320:
					{
						#line 3 "d:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpResponse.hx"
						return this.httpVersion;
					}
					
					
					default:
					{
						#line 3 "d:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpResponse.hx"
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override double __hx_getField_f(string field, int hash, bool throwErrors, bool handleProperties) {
			unchecked {
				#line 3 "d:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpResponse.hx"
				switch (hash) {
					case 1103409453:
					{
						#line 3 "d:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpResponse.hx"
						return ((double) (this.code) );
					}
					
					
					default:
					{
						#line 3 "d:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpResponse.hx"
						return base.__hx_getField_f(field, hash, throwErrors, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_invokeField(string field, int hash, object[] dynargs) {
			unchecked {
				#line 3 "d:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpResponse.hx"
				switch (hash) {
					case 946786476:
					{
						#line 3 "d:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpResponse.hx"
						return this.toString();
					}
					
					
					case 988470062:
					{
						#line 3 "d:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpResponse.hx"
						return this.build();
					}
					
					
					case 66083509:
					{
						#line 3 "d:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpResponse.hx"
						this.addLine(global::haxe.lang.Runtime.toString(((object) (dynargs[0]) )));
						#line 3 "d:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpResponse.hx"
						break;
					}
					
					
					default:
					{
						#line 3 "d:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpResponse.hx"
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
				#line 3 "d:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpResponse.hx"
				return null;
			}
			#line default
		}
		
		
		public override void __hx_getFields(global::haxe.root.Array baseArr) {
			#line 3 "d:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpResponse.hx"
			baseArr.push("headers");
			#line 3 "d:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpResponse.hx"
			baseArr.push("text");
			#line 3 "d:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpResponse.hx"
			baseArr.push("code");
			#line 3 "d:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpResponse.hx"
			baseArr.push("httpVersion");
			#line 3 "d:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpResponse.hx"
			base.__hx_getFields(baseArr);
		}
		#line default
		
		public override string ToString(){
			return this.toString();
		}
		
		
	}
}


