// Generated by Haxe 4.1.0-rc.1+0d88c583b
using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace hx.ws.cs {
	public class NonBlockingSocket : global::sys.net.Socket {
		
		public NonBlockingSocket(global::haxe.lang.EmptyObject empty) : base(global::haxe.lang.EmptyObject.EMPTY) {
		}
		
		
		public NonBlockingSocket() : base(global::haxe.lang.EmptyObject.EMPTY) {
			#line 13 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\cs\\NonBlockingSocket.hx"
			global::hx.ws.cs.NonBlockingSocket.__hx_ctor_hx_ws_cs_NonBlockingSocket(this);
		}
		#line default
		
		protected static void __hx_ctor_hx_ws_cs_NonBlockingSocket(global::hx.ws.cs.NonBlockingSocket __hx_this) {
			#line 10 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\cs\\NonBlockingSocket.hx"
			__hx_this._socketAsyncEventArgs = null;
			#line 9 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\cs\\NonBlockingSocket.hx"
			__hx_this._acceptedSockets = new global::haxe.root.Array(new object[]{});
			#line 13 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\cs\\NonBlockingSocket.hx"
			global::sys.net.Socket.__hx_ctor_sys_net_Socket(__hx_this);
			#line 12 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\cs\\NonBlockingSocket.hx"
			{
				#line 14 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\cs\\NonBlockingSocket.hx"
				__hx_this.setBlocking(false);
			}
			
		}
		#line default
		
		public static new object @select(global::haxe.root.Array read, global::haxe.root.Array write, global::haxe.root.Array others, object timeout) {
			#line 42 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\cs\\NonBlockingSocket.hx"
			return global::sys.net.Socket.@select(read, write, others, timeout);
		}
		#line default
		
		public global::haxe.root.Array _acceptedSockets;
		
		public global::System.Net.Sockets.SocketAsyncEventArgs _socketAsyncEventArgs;
		
		public override global::sys.net.Socket accept() {
			#line 19 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\cs\\NonBlockingSocket.hx"
			if (( this._acceptedSockets.length > 0 )) {
				#line 20 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\cs\\NonBlockingSocket.hx"
				global::System.Net.Sockets.Socket n = ((global::System.Net.Sockets.Socket) (this._acceptedSockets.shift()) );
				global::hx.ws.cs.NonBlockingSocket r = new global::hx.ws.cs.NonBlockingSocket();
				#line 22 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\cs\\NonBlockingSocket.hx"
				r.sock = n;
				r.output = new global::cs.io.NativeOutput(((global::System.IO.Stream) (new global::System.Net.Sockets.NetworkStream(r.sock)) ));
				#line 24 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\cs\\NonBlockingSocket.hx"
				r.input = new global::cs.io.NativeInput(((global::System.IO.Stream) (new global::System.Net.Sockets.NetworkStream(r.sock)) ));
				return r;
			}
			
			#line 28 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\cs\\NonBlockingSocket.hx"
			if (( this._socketAsyncEventArgs == null )) {
				#line 29 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\cs\\NonBlockingSocket.hx"
				this._socketAsyncEventArgs = new global::System.Net.Sockets.SocketAsyncEventArgs();
				this._socketAsyncEventArgs.Completed += ((global::System.EventHandler<global::System.Net.Sockets.SocketAsyncEventArgs>) (this.onAcceptCompleted) );
				#line 31 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\cs\\NonBlockingSocket.hx"
				this.sock.AcceptAsync(((global::System.Net.Sockets.SocketAsyncEventArgs) (this._socketAsyncEventArgs) ));
			}
			
			#line 33 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\cs\\NonBlockingSocket.hx"
			throw global::haxe.lang.HaxeException.wrap("Blocking");
		}
		#line default
		
		public virtual void onAcceptCompleted(object sender, global::System.Net.Sockets.SocketAsyncEventArgs e) {
			#line 37 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\cs\\NonBlockingSocket.hx"
			this._acceptedSockets.push(e.AcceptSocket);
			this._socketAsyncEventArgs = null;
		}
		#line default
		
		public override object __hx_setField(string field, int hash, object @value, bool handleProperties) {
			unchecked {
				#line 8 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\cs\\NonBlockingSocket.hx"
				switch (hash) {
					case 867683501:
					{
						#line 8 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\cs\\NonBlockingSocket.hx"
						this._socketAsyncEventArgs = ((global::System.Net.Sockets.SocketAsyncEventArgs) (@value) );
						#line 8 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\cs\\NonBlockingSocket.hx"
						return @value;
					}
					
					
					case 1241114938:
					{
						#line 8 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\cs\\NonBlockingSocket.hx"
						this._acceptedSockets = ((global::haxe.root.Array) (@value) );
						#line 8 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\cs\\NonBlockingSocket.hx"
						return @value;
					}
					
					
					default:
					{
						#line 8 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\cs\\NonBlockingSocket.hx"
						return base.__hx_setField(field, hash, @value, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties) {
			unchecked {
				#line 8 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\cs\\NonBlockingSocket.hx"
				switch (hash) {
					case 1499729668:
					{
						#line 8 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\cs\\NonBlockingSocket.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "onAcceptCompleted", 1499729668)) );
					}
					
					
					case 184980232:
					{
						#line 8 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\cs\\NonBlockingSocket.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "accept", 184980232)) );
					}
					
					
					case 867683501:
					{
						#line 8 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\cs\\NonBlockingSocket.hx"
						return this._socketAsyncEventArgs;
					}
					
					
					case 1241114938:
					{
						#line 8 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\cs\\NonBlockingSocket.hx"
						return this._acceptedSockets;
					}
					
					
					default:
					{
						#line 8 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\cs\\NonBlockingSocket.hx"
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_invokeField(string field, int hash, object[] dynargs) {
			unchecked {
				#line 8 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\cs\\NonBlockingSocket.hx"
				switch (hash) {
					case 184980232:
					{
						#line 8 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\cs\\NonBlockingSocket.hx"
						return global::haxe.lang.Runtime.slowCallField(this, field, dynargs);
					}
					
					
					case 1499729668:
					{
						#line 8 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\cs\\NonBlockingSocket.hx"
						this.onAcceptCompleted(((object) (dynargs[0]) ), ((global::System.Net.Sockets.SocketAsyncEventArgs) (((object) (dynargs[1]) )) ));
						#line 8 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\cs\\NonBlockingSocket.hx"
						break;
					}
					
					
					default:
					{
						#line 8 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\cs\\NonBlockingSocket.hx"
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
				#line 8 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\cs\\NonBlockingSocket.hx"
				return null;
			}
			#line default
		}
		
		
		public override void __hx_getFields(global::haxe.root.Array baseArr) {
			#line 8 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\cs\\NonBlockingSocket.hx"
			baseArr.push("_socketAsyncEventArgs");
			#line 8 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\cs\\NonBlockingSocket.hx"
			baseArr.push("_acceptedSockets");
			#line 8 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\cs\\NonBlockingSocket.hx"
			base.__hx_getFields(baseArr);
		}
		#line default
		
	}
}


