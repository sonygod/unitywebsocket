// Generated by Haxe 4.0.0+ef18b627e
using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace hx.ws {
	public class WebSocket : global::hx.ws.WebSocketCommon {
		
		public WebSocket(global::haxe.lang.EmptyObject empty) : base(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) )) {
		}
		
		
		public WebSocket(string uri) : base(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) )) {
			#line 142 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
			global::hx.ws.WebSocket.__hx_ctor_hx_ws_WebSocket(this, uri);
		}
		#line default
		
		protected static void __hx_ctor_hx_ws_WebSocket(global::hx.ws.WebSocket __hx_this, string uri) {
			unchecked {
				#line 121 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
				__hx_this._encodedKey = "wskey";
				#line 120 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
				__hx_this._key = "wskey";
				#line 125 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
				{
					#line 126 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
					global::haxe.root.EReg uriRegExp = new global::haxe.root.EReg("^(\\w+?)://([\\w\\.-]+)(:(\\d+))?(/.*)?$", "");
					#line 128 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
					if ( ! (uriRegExp.match(uri)) ) {
						#line 129 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
						throw global::haxe.lang.HaxeException.wrap(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("Uri not matching websocket uri \"", uri), "\""));
					}
					
					#line 131 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
					string proto = uriRegExp.matched(1);
					if (( proto == "wss" )) {
						#line 134 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
						throw global::haxe.lang.HaxeException.wrap("Secure sockets not implemented");
					}
					else if (( proto == "ws" )) {
						#line 141 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
						__hx_this._port = 80;
						global::hx.ws.WebSocketCommon.__hx_ctor_hx_ws_WebSocketCommon(__hx_this, null);
					}
					else {
						#line 144 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
						throw global::haxe.lang.HaxeException.wrap(global::haxe.lang.Runtime.concat("Unknown protocol ", proto));
					}
					
					#line 147 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
					__hx_this._host = uriRegExp.matched(2);
					object parsedPort = global::haxe.root.Std.parseInt(uriRegExp.matched(4));
					#line 149 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
					if (( ((int) (global::haxe.lang.Runtime.toInt(parsedPort)) ) > 0 )) {
						#line 150 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
						__hx_this._port = ((int) (global::haxe.lang.Runtime.toInt(parsedPort)) );
					}
					
					#line 152 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
					__hx_this._uri = uriRegExp.matched(5);
					if (( ( __hx_this._uri == null ) || ( __hx_this._uri.Length == 0 ) )) {
						#line 154 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
						__hx_this._uri = "/";
					}
					
					#line 156 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
					__hx_this._socket.setBlocking(true);
					global::haxe.Log.trace.__hx_invoke2_o(default(double), "socket connect()", default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"new", "hx.ws.WebSocket", "src/hx/ws/WebSocket.hx"}, new int[]{1981972957}, new double[]{((double) (157) )}));
					#line 158 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
					__hx_this._socket.connect(new global::sys.net.Host(((string) (__hx_this._host) )), __hx_this._port);
					global::haxe.Log.trace.__hx_invoke2_o(default(double), "finish socket connect()", default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"new", "hx.ws.WebSocket", "src/hx/ws/WebSocket.hx"}, new int[]{1981972957}, new double[]{((double) (159) )}));
					#line 161 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
					__hx_this._socket.setBlocking(false);
					global::haxe.Log.trace.__hx_invoke2_o(default(double), "debug test 162", default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"new", "hx.ws.WebSocket", "src/hx/ws/WebSocket.hx"}, new int[]{1981972957}, new double[]{((double) (162) )}));
					#line 163 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
					__hx_this._processThread = global::sys.thread._Thread.Thread_Impl_.create(((global::haxe.lang.Function) (new global::haxe.lang.Closure(__hx_this, "processThread", 1695321753)) ));
					global::haxe.Log.trace.__hx_invoke2_o(default(double), "debug test 164", default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"new", "hx.ws.WebSocket", "src/hx/ws/WebSocket.hx"}, new int[]{1981972957}, new double[]{((double) (164) )}));
					#line 165 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
					((global::sys.thread._Thread.HaxeThread) (__hx_this._processThread) ).sendMessage(((object) (__hx_this) ));
					#line 167 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
					global::haxe.Log.trace.__hx_invoke2_o(default(double), "debug test 167", default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"new", "hx.ws.WebSocket", "src/hx/ws/WebSocket.hx"}, new int[]{1981972957}, new double[]{((double) (167) )}));
					#line 169 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
					global::haxe.Log.trace.__hx_invoke2_o(default(double), "socket ready hand shake()", default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"new", "hx.ws.WebSocket", "src/hx/ws/WebSocket.hx"}, new int[]{1981972957}, new double[]{((double) (169) )}));
					__hx_this.sendHandshake();
					#line 171 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
					global::haxe.Log.trace.__hx_invoke2_o(default(double), "socket hand shake()", default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"new", "hx.ws.WebSocket", "src/hx/ws/WebSocket.hx"}, new int[]{1981972957}, new double[]{((double) (171) )}));
				}
				
			}
			#line default
		}
		
		
		public string _host;
		
		public int _port;
		
		public string _uri;
		
		public global::sys.thread._Thread.HaxeThread _processThread;
		
		public string _key;
		
		public string _encodedKey;
		
		public string binaryType;
		
		public virtual void processThread() {
			unchecked {
				#line 176 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
				global::haxe.Log.trace.__hx_invoke2_o(default(double), "\u7ebf\u7a0b\u662f\u5426\u6267\u884c?", default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"processThread", "hx.ws.WebSocket", "src/hx/ws/WebSocket.hx"}, new int[]{1981972957}, new double[]{((double) (176) )}));
				global::hx.ws.WebSocket ws = ((global::hx.ws.WebSocket) (global::sys.thread._Thread.Thread_Impl_.readMessage(true)) );
				#line 178 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
				global::haxe.Log.trace.__hx_invoke2_o(default(double), "\u7ebf\u7a0b\u662f\u5426\u6267\u884c?2", default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"processThread", "hx.ws.WebSocket", "src/hx/ws/WebSocket.hx"}, new int[]{1981972957}, new double[]{((double) (178) )}));
				global::hx.ws.Log.debug("Thread started", ws.id);
				#line 180 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
				global::haxe.Log.trace.__hx_invoke2_o(default(double), "\u7ebf\u7a0b\u662f\u5426\u6267\u884c?23", default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"processThread", "hx.ws.WebSocket", "src/hx/ws/WebSocket.hx"}, new int[]{1981972957}, new double[]{((double) (180) )}));
				#line 182 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
				int i = 1;
				while (( ws.state != global::hx.ws.State.Closed )) {
					#line 184 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
					 ++ i;
					if (( i < 3 )) {
						#line 186 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
						global::haxe.Log.trace.__hx_invoke2_o(default(double), "b\u6d4b\u8bd5\u6d4b\u8bd5\u3002\u3002\u3002\u3002", default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"processThread", "hx.ws.WebSocket", "src/hx/ws/WebSocket.hx"}, new int[]{1981972957}, new double[]{((double) (186) )}));
					}
					
					#line 188 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
					ws.process();
					#line 190 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
					if (( i < 3 )) {
						#line 191 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
						global::haxe.Log.trace.__hx_invoke2_o(default(double), "\u6d4b\u8bd5\u6d4b\u8bd5\u3002\u3002\u3002\u3002", default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"processThread", "hx.ws.WebSocket", "src/hx/ws/WebSocket.hx"}, new int[]{1981972957}, new double[]{((double) (191) )}));
					}
					
					#line 193 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
					global::System.Threading.Thread.Sleep(((int) (10) ));
				}
				
				#line 195 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
				global::hx.ws.Log.debug("Thread ended", ws.id);
			}
			#line default
		}
		
		
		public virtual void sendHandshake() {
			#line 199 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
			global::hx.ws.HttpRequest httpRequest = new global::hx.ws.HttpRequest();
			httpRequest.method = "GET";
			#line 201 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
			httpRequest.uri = this._uri;
			httpRequest.httpVersion = "HTTP/1.1";
			#line 204 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
			((global::haxe.ds.StringMap) (((global::haxe.IMap) (httpRequest.headers) )) ).@set(((string) ("Host") ), ((object) (global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(this._host, ":"), global::haxe.lang.Runtime.toString(this._port))) ));
			((global::haxe.ds.StringMap) (((global::haxe.IMap) (httpRequest.headers) )) ).@set(((string) ("User-Agent") ), ((object) ("hxWebSockets") ));
			#line 206 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
			((global::haxe.ds.StringMap) (((global::haxe.IMap) (httpRequest.headers) )) ).@set(((string) ("Sec-WebSocket-Version") ), ((object) ("13") ));
			((global::haxe.ds.StringMap) (((global::haxe.IMap) (httpRequest.headers) )) ).@set(((string) ("Upgrade") ), ((object) ("websocket") ));
			#line 208 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
			((global::haxe.ds.StringMap) (((global::haxe.IMap) (httpRequest.headers) )) ).@set(((string) ("Connection") ), ((object) ("Upgrade") ));
			((global::haxe.ds.StringMap) (((global::haxe.IMap) (httpRequest.headers) )) ).@set(((string) ("Pragma") ), ((object) ("no-cache") ));
			#line 210 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
			((global::haxe.ds.StringMap) (((global::haxe.IMap) (httpRequest.headers) )) ).@set(((string) ("Cache-Control") ), ((object) ("no-cache") ));
			((global::haxe.ds.StringMap) (((global::haxe.IMap) (httpRequest.headers) )) ).@set(((string) ("Origin") ), ((object) (global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(((global::sys.net.Host) (global::haxe.lang.Runtime.getField(this._socket.host(), "host", 1158860648, true)) ).toString(), ":"), global::haxe.lang.Runtime.toString(((int) (global::haxe.lang.Runtime.getField_f(this._socket.host(), "port", 1247576961, true)) )))) ));
			#line 212 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
			this._encodedKey = global::haxe.crypto.Base64.encode(global::hx.ws.Utf8Encoder.encode(this._key), null);
			((global::haxe.ds.StringMap) (((global::haxe.IMap) (httpRequest.headers) )) ).@set(((string) ("Sec-WebSocket-Key") ), ((object) (this._encodedKey) ));
			#line 215 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
			this.sendHttpRequest(httpRequest);
		}
		#line default
		
		public override void handleData() {
			unchecked {
				#line 219 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
				if (( this.state._hx_index == 0 )) {
					#line 221 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
					global::hx.ws.HttpResponse httpResponse = this.recvHttpResponse();
					if (( httpResponse == null )) {
						#line 223 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
						return;
					}
					
					#line 226 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
					this.handshake(httpResponse);
					this.handleData();
				}
				else {
					#line 230 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
					global::haxe.Log.trace.__hx_invoke2_o(default(double), "handdata?", default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"handleData", "hx.ws.WebSocket", "src/hx/ws/WebSocket.hx"}, new int[]{1981972957}, new double[]{((double) (230) )}));
					base.handleData();
				}
				
			}
			#line default
		}
		
		
		public virtual void handshake(global::hx.ws.HttpResponse httpResponse) {
			unchecked {
				#line 236 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
				global::haxe.Log.trace.__hx_invoke2_o(default(double), httpResponse.toString(), default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"handshake", "hx.ws.WebSocket", "src/hx/ws/WebSocket.hx"}, new int[]{1981972957}, new double[]{((double) (236) )}));
				if (( httpResponse.code != 101 )) {
					#line 238 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
					if (( this.onerror != null )) {
						#line 239 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
						this.onerror.__hx_invoke1_o(default(double), global::haxe.lang.Runtime.toString(((global::haxe.ds.StringMap) (((global::haxe.IMap) (httpResponse.headers) )) ).@get(((string) ("X-WebSocket-Reject-Reason") ))));
					}
					
					#line 241 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
					this.close();
					return;
				}
				
				#line 245 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
				string secKey = global::haxe.lang.Runtime.toString(((global::haxe.ds.StringMap) (((global::haxe.IMap) (httpResponse.headers) )) ).@get(((string) ("Sec-WebSocket-Accept") )));
				if (( secKey != global::haxe.crypto.Base64.encode(global::haxe.crypto.Sha1.make(global::haxe.io.Bytes.ofString(global::haxe.lang.Runtime.concat(this._encodedKey, "258EAFA5-E914-47DA-95CA-C5AB0DC85B11"), null)), null) )) {
					#line 247 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
					if (( this.onerror != null )) {
						#line 248 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
						this.onerror.__hx_invoke1_o(default(double), "Error during WebSocket handshake: Incorrect \'Sec-WebSocket-Accept\' header value");
					}
					
					#line 250 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
					this.close();
					return;
				}
				
				#line 254 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
				this._onopenCalled = false;
				this.state = global::hx.ws.State.Head;
				#line 256 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
				global::haxe.Log.trace.__hx_invoke2_o(default(double), "get head ok", default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"handshake", "hx.ws.WebSocket", "src/hx/ws/WebSocket.hx"}, new int[]{1981972957}, new double[]{((double) (256) )}));
			}
			#line default
		}
		
		
		public override double __hx_setField_f(string field, int hash, double @value, bool handleProperties) {
			unchecked {
				#line 114 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
				switch (hash) {
					case 2104336224:
					{
						#line 114 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
						this._port = ((int) (@value) );
						#line 114 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
						return @value;
					}
					
					
					default:
					{
						#line 114 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
						return base.__hx_setField_f(field, hash, @value, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_setField(string field, int hash, object @value, bool handleProperties) {
			unchecked {
				#line 114 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
				switch (hash) {
					case 1860333403:
					{
						#line 114 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
						this.binaryType = global::haxe.lang.Runtime.toString(@value);
						#line 114 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
						return @value;
					}
					
					
					case 1601313232:
					{
						#line 114 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
						this._encodedKey = global::haxe.lang.Runtime.toString(@value);
						#line 114 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
						return @value;
					}
					
					
					case 1058852512:
					{
						#line 114 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
						this._key = global::haxe.lang.Runtime.toString(@value);
						#line 114 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
						return @value;
					}
					
					
					case 593395418:
					{
						#line 114 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
						this._processThread = ((global::sys.thread._Thread.HaxeThread) (@value) );
						#line 114 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
						return @value;
					}
					
					
					case 1059352685:
					{
						#line 114 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
						this._uri = global::haxe.lang.Runtime.toString(@value);
						#line 114 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
						return @value;
					}
					
					
					case 2104336224:
					{
						#line 114 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
						this._port = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						#line 114 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
						return @value;
					}
					
					
					case 2015619911:
					{
						#line 114 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
						this._host = global::haxe.lang.Runtime.toString(@value);
						#line 114 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
						return @value;
					}
					
					
					default:
					{
						#line 114 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
						return base.__hx_setField(field, hash, @value, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties) {
			unchecked {
				#line 114 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
				switch (hash) {
					case 875946231:
					{
						#line 114 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "handshake", 875946231)) );
					}
					
					
					case 1627978226:
					{
						#line 114 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "handleData", 1627978226)) );
					}
					
					
					case 414206607:
					{
						#line 114 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "sendHandshake", 414206607)) );
					}
					
					
					case 1695321753:
					{
						#line 114 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "processThread", 1695321753)) );
					}
					
					
					case 1860333403:
					{
						#line 114 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
						return this.binaryType;
					}
					
					
					case 1601313232:
					{
						#line 114 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
						return this._encodedKey;
					}
					
					
					case 1058852512:
					{
						#line 114 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
						return this._key;
					}
					
					
					case 593395418:
					{
						#line 114 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
						return this._processThread;
					}
					
					
					case 1059352685:
					{
						#line 114 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
						return this._uri;
					}
					
					
					case 2104336224:
					{
						#line 114 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
						return this._port;
					}
					
					
					case 2015619911:
					{
						#line 114 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
						return this._host;
					}
					
					
					default:
					{
						#line 114 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override double __hx_getField_f(string field, int hash, bool throwErrors, bool handleProperties) {
			unchecked {
				#line 114 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
				switch (hash) {
					case 2104336224:
					{
						#line 114 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
						return ((double) (this._port) );
					}
					
					
					default:
					{
						#line 114 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
						return base.__hx_getField_f(field, hash, throwErrors, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_invokeField(string field, int hash, object[] dynargs) {
			unchecked {
				#line 114 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
				switch (hash) {
					case 1627978226:
					{
						#line 114 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
						return global::haxe.lang.Runtime.slowCallField(this, field, dynargs);
					}
					
					
					case 875946231:
					{
						#line 114 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
						this.handshake(((global::hx.ws.HttpResponse) (((object) (dynargs[0]) )) ));
						#line 114 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
						break;
					}
					
					
					case 414206607:
					{
						#line 114 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
						this.sendHandshake();
						#line 114 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
						break;
					}
					
					
					case 1695321753:
					{
						#line 114 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
						this.processThread();
						#line 114 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
						break;
					}
					
					
					default:
					{
						#line 114 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
				#line 114 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
				return null;
			}
			#line default
		}
		
		
		public override void __hx_getFields(global::haxe.root.Array baseArr) {
			#line 114 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
			baseArr.push("binaryType");
			#line 114 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
			baseArr.push("_encodedKey");
			#line 114 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
			baseArr.push("_key");
			#line 114 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
			baseArr.push("_processThread");
			#line 114 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
			baseArr.push("_uri");
			#line 114 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
			baseArr.push("_port");
			#line 114 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
			baseArr.push("_host");
			#line 114 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\WebSocket.hx"
			base.__hx_getFields(baseArr);
		}
		#line default
		
	}
}


