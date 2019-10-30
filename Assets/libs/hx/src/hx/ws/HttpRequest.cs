// Generated by Haxe 4.0.0+ef18b627e
using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace hx.ws {
	public class HttpRequest : global::haxe.lang.HxObject {
		
		public HttpRequest(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public HttpRequest() {
			#line 10 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpRequest.hx"
			global::hx.ws.HttpRequest.__hx_ctor_hx_ws_HttpRequest(this);
		}
		#line default
		
		protected static void __hx_ctor_hx_ws_HttpRequest(global::hx.ws.HttpRequest __hx_this) {
			#line 8 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpRequest.hx"
			__hx_this.headers = new global::haxe.ds.StringMap();
			#line 6 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpRequest.hx"
			__hx_this.httpVersion = null;
			#line 5 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpRequest.hx"
			__hx_this.uri = null;
			#line 4 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpRequest.hx"
			__hx_this.method = null;
			#line 10 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpRequest.hx"
			{
			}
			
		}
		#line default
		
		public string method;
		
		public string uri;
		
		public string httpVersion;
		
		public global::haxe.ds.StringMap headers;
		
		public virtual void addLine(string line) {
			unchecked {
				#line 14 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpRequest.hx"
				if (( this.method == null )) {
					#line 15 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpRequest.hx"
					global::haxe.root.Array parts = global::haxe.lang.StringExt.split(line, " ");
					this.method = global::haxe.lang.Runtime.toString(parts.__get(0));
					#line 17 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpRequest.hx"
					this.uri = global::haxe.lang.Runtime.toString(parts.__get(1));
					this.httpVersion = global::haxe.lang.Runtime.toString(parts.__get(2));
				}
				else {
					#line 20 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpRequest.hx"
					int n = global::haxe.lang.StringExt.indexOf(line, ":", null);
					string name = global::haxe.lang.StringExt.substr(line, 0, n);
					#line 22 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpRequest.hx"
					string @value = global::haxe.lang.StringExt.substr(line, ( n + 1 ), line.Length);
					((global::haxe.ds.StringMap) (((global::haxe.IMap) (this.headers) )) ).@set(((string) (name.Trim()) ), ((object) (@value.Trim()) ));
				}
				
			}
			#line default
		}
		
		
		public virtual string build() {
			#line 28 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpRequest.hx"
			global::System.Text.StringBuilder sb_b = new global::System.Text.StringBuilder();
			#line 30 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpRequest.hx"
			sb_b.Append(((string) (global::haxe.root.Std.@string(this.method)) ));
			sb_b.Append(((string) (" ") ));
			#line 32 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpRequest.hx"
			if (( this.uri != null )) {
				#line 33 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpRequest.hx"
				sb_b.Append(((string) (global::haxe.root.Std.@string(this.uri)) ));
				sb_b.Append(((string) (" ") ));
			}
			
			#line 36 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpRequest.hx"
			sb_b.Append(((string) (global::haxe.root.Std.@string(this.httpVersion)) ));
			sb_b.Append(((string) ("\r\n") ));
			#line 39 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpRequest.hx"
			{
				#line 39 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpRequest.hx"
				object header = ((object) (new global::haxe.ds._StringMap.StringMapKeyIterator(((global::haxe.ds.StringMap) (((global::haxe.IMap) (this.headers) )) ))) );
				#line 39 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpRequest.hx"
				while (global::haxe.lang.Runtime.toBool(global::haxe.lang.Runtime.callField(header, "hasNext", 407283053, null))) {
					#line 39 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpRequest.hx"
					string header1 = global::haxe.lang.Runtime.toString(global::haxe.lang.Runtime.callField(header, "next", 1224901875, null));
					sb_b.Append(((string) (global::haxe.root.Std.@string(header1)) ));
					#line 41 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpRequest.hx"
					sb_b.Append(((string) (": ") ));
					sb_b.Append(((string) (global::haxe.root.Std.@string(global::haxe.lang.Runtime.toString(((global::haxe.ds.StringMap) (((global::haxe.IMap) (this.headers) )) ).@get(((string) (header1) ))))) ));
					#line 43 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpRequest.hx"
					sb_b.Append(((string) ("\r\n") ));
				}
				
			}
			
			#line 46 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpRequest.hx"
			sb_b.Append(((string) ("\r\n") ));
			return sb_b.ToString();
		}
		#line default
		
		public virtual string toString() {
			#line 51 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpRequest.hx"
			return this.build();
		}
		#line default
		
		public override object __hx_setField(string field, int hash, object @value, bool handleProperties) {
			unchecked {
				#line 3 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpRequest.hx"
				switch (hash) {
					case 1661489734:
					{
						#line 3 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpRequest.hx"
						this.headers = ((global::haxe.ds.StringMap) (@value) );
						#line 3 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpRequest.hx"
						return @value;
					}
					
					
					case 1641182320:
					{
						#line 3 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpRequest.hx"
						this.httpVersion = global::haxe.lang.Runtime.toString(@value);
						#line 3 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpRequest.hx"
						return @value;
					}
					
					
					case 5843820:
					{
						#line 3 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpRequest.hx"
						this.uri = global::haxe.lang.Runtime.toString(@value);
						#line 3 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpRequest.hx"
						return @value;
					}
					
					
					case 156956385:
					{
						#line 3 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpRequest.hx"
						this.method = global::haxe.lang.Runtime.toString(@value);
						#line 3 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpRequest.hx"
						return @value;
					}
					
					
					default:
					{
						#line 3 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpRequest.hx"
						return base.__hx_setField(field, hash, @value, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties) {
			unchecked {
				#line 3 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpRequest.hx"
				switch (hash) {
					case 946786476:
					{
						#line 3 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpRequest.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "toString", 946786476)) );
					}
					
					
					case 988470062:
					{
						#line 3 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpRequest.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "build", 988470062)) );
					}
					
					
					case 66083509:
					{
						#line 3 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpRequest.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "addLine", 66083509)) );
					}
					
					
					case 1661489734:
					{
						#line 3 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpRequest.hx"
						return this.headers;
					}
					
					
					case 1641182320:
					{
						#line 3 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpRequest.hx"
						return this.httpVersion;
					}
					
					
					case 5843820:
					{
						#line 3 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpRequest.hx"
						return this.uri;
					}
					
					
					case 156956385:
					{
						#line 3 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpRequest.hx"
						return this.method;
					}
					
					
					default:
					{
						#line 3 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpRequest.hx"
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_invokeField(string field, int hash, object[] dynargs) {
			unchecked {
				#line 3 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpRequest.hx"
				switch (hash) {
					case 946786476:
					{
						#line 3 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpRequest.hx"
						return this.toString();
					}
					
					
					case 988470062:
					{
						#line 3 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpRequest.hx"
						return this.build();
					}
					
					
					case 66083509:
					{
						#line 3 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpRequest.hx"
						this.addLine(global::haxe.lang.Runtime.toString(((object) (dynargs[0]) )));
						#line 3 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpRequest.hx"
						break;
					}
					
					
					default:
					{
						#line 3 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpRequest.hx"
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
				#line 3 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpRequest.hx"
				return null;
			}
			#line default
		}
		
		
		public override void __hx_getFields(global::haxe.root.Array baseArr) {
			#line 3 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpRequest.hx"
			baseArr.push("headers");
			#line 3 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpRequest.hx"
			baseArr.push("httpVersion");
			#line 3 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpRequest.hx"
			baseArr.push("uri");
			#line 3 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpRequest.hx"
			baseArr.push("method");
			#line 3 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\HttpRequest.hx"
			base.__hx_getFields(baseArr);
		}
		#line default
		
		public override string ToString(){
			return this.toString();
		}
		
		
	}
}


