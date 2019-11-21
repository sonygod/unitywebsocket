// Generated by Haxe 4.1.0-rc.1+0d88c583b
using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace hx.ws.cs {
	public class NonBlockingSocket : global::sys.net.Socket {
		
		public NonBlockingSocket(global::haxe.lang.EmptyObject empty) : base(global::haxe.lang.EmptyObject.EMPTY) {
		}
		
		
		public NonBlockingSocket() : base(global::haxe.lang.EmptyObject.EMPTY) {
			global::hx.ws.cs.NonBlockingSocket.__hx_ctor_hx_ws_cs_NonBlockingSocket(this);
		}
		
		
		protected static void __hx_ctor_hx_ws_cs_NonBlockingSocket(global::hx.ws.cs.NonBlockingSocket __hx_this) {
			__hx_this._socketAsyncEventArgs = null;
			__hx_this._acceptedSockets = new global::haxe.root.Array(new object[]{});
			global::sys.net.Socket.__hx_ctor_sys_net_Socket(__hx_this);
			{
				__hx_this.setBlocking(false);
			}
			
		}
		
		
		public static new object @select(global::haxe.root.Array read, global::haxe.root.Array write, global::haxe.root.Array others, object timeout) {
			return global::sys.net.Socket.@select(read, write, others, timeout);
		}
		
		
		public global::haxe.root.Array _acceptedSockets;
		
		public global::System.Net.Sockets.SocketAsyncEventArgs _socketAsyncEventArgs;
		
		public override global::sys.net.Socket accept() {
			if (( this._acceptedSockets.length > 0 )) {
				global::System.Net.Sockets.Socket n = ((global::System.Net.Sockets.Socket) (this._acceptedSockets.shift()) );
				global::hx.ws.cs.NonBlockingSocket r = new global::hx.ws.cs.NonBlockingSocket();
				r.sock = n;
				r.output = new global::cs.io.NativeOutput(((global::System.IO.Stream) (new global::System.Net.Sockets.NetworkStream(r.sock)) ));
				r.input = new global::cs.io.NativeInput(((global::System.IO.Stream) (new global::System.Net.Sockets.NetworkStream(r.sock)) ));
				return r;
			}
			
			if (( this._socketAsyncEventArgs == null )) {
				this._socketAsyncEventArgs = new global::System.Net.Sockets.SocketAsyncEventArgs();
				this._socketAsyncEventArgs.Completed += ((global::System.EventHandler<global::System.Net.Sockets.SocketAsyncEventArgs>) (this.onAcceptCompleted) );
				this.sock.AcceptAsync(((global::System.Net.Sockets.SocketAsyncEventArgs) (this._socketAsyncEventArgs) ));
			}
			
			throw global::haxe.lang.HaxeException.wrap("Blocking");
		}
		
		
		public virtual void onAcceptCompleted(object sender, global::System.Net.Sockets.SocketAsyncEventArgs e) {
			this._acceptedSockets.push(e.AcceptSocket);
			this._socketAsyncEventArgs = null;
		}
		
		
		public override object __hx_setField(string field, int hash, object @value, bool handleProperties) {
			unchecked {
				switch (hash) {
					case 867683501:
					{
						this._socketAsyncEventArgs = ((global::System.Net.Sockets.SocketAsyncEventArgs) (@value) );
						return @value;
					}
					
					
					case 1241114938:
					{
						this._acceptedSockets = ((global::haxe.root.Array) (@value) );
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
					case 1499729668:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "onAcceptCompleted", 1499729668)) );
					}
					
					
					case 184980232:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "accept", 184980232)) );
					}
					
					
					case 867683501:
					{
						return this._socketAsyncEventArgs;
					}
					
					
					case 1241114938:
					{
						return this._acceptedSockets;
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
					case 184980232:
					{
						return global::haxe.lang.Runtime.slowCallField(this, field, dynargs);
					}
					
					
					case 1499729668:
					{
						this.onAcceptCompleted(((object) (dynargs[0]) ), ((global::System.Net.Sockets.SocketAsyncEventArgs) (((object) (dynargs[1]) )) ));
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
			baseArr.push("_socketAsyncEventArgs");
			baseArr.push("_acceptedSockets");
			base.__hx_getFields(baseArr);
		}
		
		
	}
}


