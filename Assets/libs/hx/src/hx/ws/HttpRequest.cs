// Generated by Haxe 4.1.0-rc.1+0d88c583b
using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace hx.ws {
	public class HttpRequest : global::haxe.lang.HxObject {
		
		public HttpRequest(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public HttpRequest() {
			global::hx.ws.HttpRequest.__hx_ctor_hx_ws_HttpRequest(this);
		}
		
		
		protected static void __hx_ctor_hx_ws_HttpRequest(global::hx.ws.HttpRequest __hx_this) {
			__hx_this.headers = new global::haxe.ds.StringMap();
			__hx_this.httpVersion = null;
			__hx_this.uri = null;
			__hx_this.method = null;
			{
			}
			
		}
		
		
		public string method;
		
		public string uri;
		
		public string httpVersion;
		
		public global::haxe.ds.StringMap headers;
		
		public virtual void addLine(string line) {
			unchecked {
				if (( this.method == null )) {
					global::haxe.root.Array parts = global::haxe.lang.StringExt.split(line, " ");
					this.method = global::haxe.lang.Runtime.toString(parts.__get(0));
					this.uri = global::haxe.lang.Runtime.toString(parts.__get(1));
					this.httpVersion = global::haxe.lang.Runtime.toString(parts.__get(2));
				}
				else {
					int n = global::haxe.lang.StringExt.indexOf(line, ":", null);
					string name = global::haxe.lang.StringExt.substr(line, 0, n);
					string @value = global::haxe.lang.StringExt.substr(line, ( n + 1 ), line.Length);
					((global::haxe.ds.StringMap) (((global::haxe.IMap) (this.headers) )) ).@set(((string) (name.Trim()) ), ((object) (@value.Trim()) ));
				}
				
			}
		}
		
		
		public virtual string build() {
			global::System.Text.StringBuilder sb_b = new global::System.Text.StringBuilder();
			sb_b.Append(((string) (global::haxe.root.Std.@string(this.method)) ));
			sb_b.Append(((string) (" ") ));
			if (( this.uri != null )) {
				sb_b.Append(((string) (global::haxe.root.Std.@string(this.uri)) ));
				sb_b.Append(((string) (" ") ));
			}
			
			sb_b.Append(((string) (global::haxe.root.Std.@string(this.httpVersion)) ));
			sb_b.Append(((string) ("\r\n") ));
			{
				object header = ((object) (new global::haxe.ds._StringMap.StringMapKeyIterator(((global::haxe.ds.StringMap) (((global::haxe.IMap) (this.headers) )) ))) );
				while (global::haxe.lang.Runtime.toBool(global::haxe.lang.Runtime.callField(header, "hasNext", 407283053, null))) {
					string header1 = global::haxe.lang.Runtime.toString(global::haxe.lang.Runtime.callField(header, "next", 1224901875, null));
					sb_b.Append(((string) (global::haxe.root.Std.@string(header1)) ));
					sb_b.Append(((string) (": ") ));
					sb_b.Append(((string) (global::haxe.root.Std.@string(global::haxe.lang.Runtime.toString(((global::haxe.ds.StringMap) (((global::haxe.IMap) (this.headers) )) ).@get(((string) (header1) ))))) ));
					sb_b.Append(((string) ("\r\n") ));
				}
				
			}
			
			sb_b.Append(((string) ("\r\n") ));
			return sb_b.ToString();
		}
		
		
		public virtual string toString() {
			return this.build();
		}
		
		
		public override object __hx_setField(string field, int hash, object @value, bool handleProperties) {
			unchecked {
				switch (hash) {
					case 1661489734:
					{
						this.headers = ((global::haxe.ds.StringMap) (@value) );
						return @value;
					}
					
					
					case 1641182320:
					{
						this.httpVersion = global::haxe.lang.Runtime.toString(@value);
						return @value;
					}
					
					
					case 5843820:
					{
						this.uri = global::haxe.lang.Runtime.toString(@value);
						return @value;
					}
					
					
					case 156956385:
					{
						this.method = global::haxe.lang.Runtime.toString(@value);
						return @value;
					}
					
					
					default:
					{
						return base.__hx_setField(field, hash, @value, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties) {
			unchecked {
				switch (hash) {
					case 946786476:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "toString", 946786476)) );
					}
					
					
					case 988470062:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "build", 988470062)) );
					}
					
					
					case 66083509:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "addLine", 66083509)) );
					}
					
					
					case 1661489734:
					{
						return this.headers;
					}
					
					
					case 1641182320:
					{
						return this.httpVersion;
					}
					
					
					case 5843820:
					{
						return this.uri;
					}
					
					
					case 156956385:
					{
						return this.method;
					}
					
					
					default:
					{
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override object __hx_invokeField(string field, int hash, object[] dynargs) {
			unchecked {
				switch (hash) {
					case 946786476:
					{
						return this.toString();
					}
					
					
					case 988470062:
					{
						return this.build();
					}
					
					
					case 66083509:
					{
						this.addLine(global::haxe.lang.Runtime.toString(((object) (dynargs[0]) )));
						break;
					}
					
					
					default:
					{
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
				return null;
			}
		}
		
		
		public override void __hx_getFields(global::haxe.root.Array baseArr) {
			baseArr.push("headers");
			baseArr.push("httpVersion");
			baseArr.push("uri");
			baseArr.push("method");
			base.__hx_getFields(baseArr);
		}
		
		
		public override string ToString(){
			return this.toString();
		}
		
		
	}
}


