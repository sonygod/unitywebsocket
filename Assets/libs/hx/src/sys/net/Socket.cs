// Generated by Haxe 4.1.0-rc.1+cd0f0219b
using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace sys.net {
	public class Socket : global::haxe.lang.HxObject {
		
		public Socket(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public Socket() {
			#line 51 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
			global::sys.net.Socket.__hx_ctor_sys_net_Socket(this);
		}
		#line default
		
		protected static void __hx_ctor_sys_net_Socket(global::sys.net.Socket __hx_this) {
			#line 43 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
			__hx_this.sock = null;
			#line 51 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
			{
				#line 52 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
				__hx_this.sock = new global::System.Net.Sockets.Socket(global::System.Net.Sockets.AddressFamily.InterNetwork, global::System.Net.Sockets.SocketType.Stream, global::System.Net.Sockets.ProtocolType.Tcp);
				__hx_this.sock.Blocking = ((bool) (true) );
			}
			
		}
		#line default
		
		public static object @select(global::haxe.root.Array read, global::haxe.root.Array write, global::haxe.root.Array others, object timeout) {
			unchecked {
				#line 142 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
				global::haxe.ds.IntMap map = new global::haxe.ds.IntMap();
				#line 165 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
				if (( read != null )) {
					#line 165 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
					int _g = 0;
					#line 165 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
					while (( _g < read.length )) {
						#line 165 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
						global::sys.net.Socket s = ((global::sys.net.Socket) (read.__get(_g)) );
						#line 165 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
						 ++ _g;
						#line 165 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
						map.@set(((int) (s.sock.Handle.ToInt32()) ), ((object) (s) ));
					}
					
				}
				
				#line 166 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
				if (( write != null )) {
					#line 166 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
					int _g1 = 0;
					#line 166 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
					while (( _g1 < write.length )) {
						#line 166 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
						global::sys.net.Socket s1 = ((global::sys.net.Socket) (write.__get(_g1)) );
						#line 166 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
						 ++ _g1;
						#line 166 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
						map.@set(((int) (s1.sock.Handle.ToInt32()) ), ((object) (s1) ));
					}
					
				}
				
				#line 167 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
				if (( others != null )) {
					#line 167 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
					int _g2 = 0;
					#line 167 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
					while (( _g2 < others.length )) {
						#line 167 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
						global::sys.net.Socket s2 = ((global::sys.net.Socket) (others.__get(_g2)) );
						#line 167 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
						 ++ _g2;
						#line 167 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
						map.@set(((int) (s2.sock.Handle.ToInt32()) ), ((object) (s2) ));
					}
					
				}
				
				#line 170 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
				global::System.Collections.ArrayList a = new global::System.Collections.ArrayList(((int) (( (( read == null )) ? (0) : (read.length) )) ));
				#line 170 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
				if (( read != null )) {
					#line 170 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
					int _g3 = 0;
					#line 170 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
					while (( _g3 < read.length )) {
						#line 170 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
						global::sys.net.Socket s3 = ((global::sys.net.Socket) (read.__get(_g3)) );
						#line 170 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
						 ++ _g3;
						#line 170 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
						a.Add(((object) (s3.sock) ));
					}
					
				}
				
				#line 170 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
				global::System.Collections.ArrayList rawRead = a;
				global::System.Collections.ArrayList a1 = new global::System.Collections.ArrayList(((int) (( (( write == null )) ? (0) : (write.length) )) ));
				if (( write != null )) {
					#line 171 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
					int _g4 = 0;
					#line 171 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
					while (( _g4 < write.length )) {
						#line 171 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
						global::sys.net.Socket s4 = ((global::sys.net.Socket) (write.__get(_g4)) );
						#line 171 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
						 ++ _g4;
						#line 171 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
						a1.Add(((object) (s4.sock) ));
					}
					
				}
				
				#line 170 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
				global::System.Collections.ArrayList rawWrite = a1;
				#line 172 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
				global::System.Collections.ArrayList a2 = new global::System.Collections.ArrayList(((int) (( (( others == null )) ? (0) : (others.length) )) ));
				#line 172 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
				if (( others != null )) {
					#line 172 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
					int _g5 = 0;
					#line 172 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
					while (( _g5 < others.length )) {
						#line 172 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
						global::sys.net.Socket s5 = ((global::sys.net.Socket) (others.__get(_g5)) );
						#line 172 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
						 ++ _g5;
						#line 172 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
						a2.Add(((object) (s5.sock) ));
					}
					
				}
				
				#line 170 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
				global::System.Collections.ArrayList rawOthers = a2;
				#line 173 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
				int microsec = ( (( timeout == default(object) )) ? (-1) : (((int) (( ((double) (global::haxe.lang.Runtime.toDouble(timeout)) ) * ((double) (1000000) ) )) )) );
				global::System.Net.Sockets.Socket.Select(((global::System.Collections.IList) (rawRead) ), ((global::System.Collections.IList) (rawWrite) ), ((global::System.Collections.IList) (rawOthers) ), ((int) (microsec) ));
				#line 177 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
				global::haxe.root.Array a3 = new global::haxe.root.Array(new object[]{});
				#line 177 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
				{
					#line 177 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
					int _g6 = 0;
					#line 177 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
					int _g11 = rawRead.Count;
					#line 177 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
					while (( _g6 < _g11 )) {
						#line 177 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
						int i = _g6++;
						#line 177 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
						global::System.Net.Sockets.Socket s6 = ((global::System.Net.Sockets.Socket) (rawRead[i]) );
						#line 177 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
						a3.push(((global::sys.net.Socket) (map.@get(((int) (s6.Handle.ToInt32()) ))) ));
					}
					
				}
				
				#line 177 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
				global::haxe.root.Array tmp = a3;
				global::haxe.root.Array a4 = new global::haxe.root.Array(new object[]{});
				{
					#line 178 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
					int _g7 = 0;
					#line 178 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
					int _g12 = rawWrite.Count;
					#line 178 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
					while (( _g7 < _g12 )) {
						#line 178 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
						int i1 = _g7++;
						#line 178 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
						global::System.Net.Sockets.Socket s7 = ((global::System.Net.Sockets.Socket) (rawWrite[i1]) );
						#line 178 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
						a4.push(((global::sys.net.Socket) (map.@get(((int) (s7.Handle.ToInt32()) ))) ));
					}
					
				}
				
				#line 178 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
				global::haxe.root.Array tmp1 = a4;
				global::haxe.root.Array a5 = new global::haxe.root.Array(new object[]{});
				{
					#line 179 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
					int _g8 = 0;
					#line 179 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
					int _g13 = rawOthers.Count;
					#line 179 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
					while (( _g8 < _g13 )) {
						#line 179 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
						int i2 = _g8++;
						#line 179 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
						global::System.Net.Sockets.Socket s8 = ((global::System.Net.Sockets.Socket) (rawOthers[i2]) );
						#line 179 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
						a5.push(((global::sys.net.Socket) (map.@get(((int) (s8.Handle.ToInt32()) ))) ));
					}
					
				}
				
				#line 176 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
				return new global::haxe.lang.DynamicObject(new int[]{1269254998, 1348037855, 1898155939}, new object[]{tmp, tmp1, a5}, new int[]{}, new double[]{});
			}
			#line default
		}
		
		
		public global::System.Net.Sockets.Socket sock;
		
		public global::haxe.io.Input input;
		
		public global::haxe.io.Output output;
		
		public object custom;
		
		public virtual void close() {
			#line 57 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
			this.sock.Close();
			this.input = null;
			#line 59 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
			this.output = null;
		}
		#line default
		
		public virtual string read() {
			#line 63 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
			return this.input.readAll(null).toString();
		}
		#line default
		
		public virtual void write(string content) {
			#line 67 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
			this.output.writeString(content, null);
		}
		#line default
		
		public virtual void connect(global::sys.net.Host host, int port) {
			#line 71 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
			this.sock.Connect(((global::System.Net.IPAddress) (host.ipAddress) ), ((int) (port) ));
			if (this.sock.Connected) {
				#line 73 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
				this.output = new global::cs.io.NativeOutput(((global::System.IO.Stream) (new global::System.Net.Sockets.NetworkStream(this.sock)) ));
				this.input = new global::cs.io.NativeInput(((global::System.IO.Stream) (new global::System.Net.Sockets.NetworkStream(this.sock)) ));
			}
			else {
				#line 76 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
				throw global::haxe.lang.HaxeException.wrap("Connection failed.");
			}
			
		}
		#line default
		
		public virtual void listen(int connections) {
			#line 81 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
			this.sock.Listen(((int) (connections) ));
		}
		#line default
		
		public virtual void shutdown(bool read, bool write) {
			#line 85 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
			if (( read && write )) {
				#line 86 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
				this.sock.Shutdown(((global::System.Net.Sockets.SocketShutdown) (global::System.Net.Sockets.SocketShutdown.Both) ));
				this.input = null;
				#line 88 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
				this.output = null;
			}
			else if (read) {
				#line 90 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
				this.sock.Shutdown(((global::System.Net.Sockets.SocketShutdown) (global::System.Net.Sockets.SocketShutdown.Receive) ));
				this.input = null;
			}
			else if (write) {
				#line 93 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
				this.sock.Shutdown(((global::System.Net.Sockets.SocketShutdown) (global::System.Net.Sockets.SocketShutdown.Send) ));
				this.output = null;
			}
			
		}
		#line default
		
		public virtual void bind(global::sys.net.Host host, int port) {
			#line 99 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
			this.sock = new global::System.Net.Sockets.Socket(global::System.Net.Sockets.AddressFamily.InterNetwork, global::System.Net.Sockets.SocketType.Stream, global::System.Net.Sockets.ProtocolType.Tcp);
			this.sock.Bind(((global::System.Net.EndPoint) (new global::System.Net.IPEndPoint(((global::System.Net.IPAddress) (host.ipAddress) ), ((int) (port) ))) ));
		}
		#line default
		
		public virtual global::sys.net.Socket accept() {
			#line 104 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
			global::sys.net.Socket r = new global::sys.net.Socket();
			r.sock = this.sock.Accept();
			#line 106 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
			r.output = new global::cs.io.NativeOutput(((global::System.IO.Stream) (new global::System.Net.Sockets.NetworkStream(r.sock)) ));
			r.input = new global::cs.io.NativeInput(((global::System.IO.Stream) (new global::System.Net.Sockets.NetworkStream(r.sock)) ));
			#line 108 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
			return r;
		}
		#line default
		
		public virtual object peer() {
			#line 112 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
			global::System.Net.IPEndPoint remoteIP = ((global::System.Net.IPEndPoint) (this.sock.RemoteEndPoint) );
			global::sys.net.Host tmp = new global::sys.net.Host(((string) (remoteIP.Address.ToString()) ));
			{
				#line 113 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
				int __temp_odecl1 = remoteIP.Port;
				#line 113 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
				return new global::haxe.lang.DynamicObject(new int[]{1158860648}, new object[]{tmp}, new int[]{1247576961}, new double[]{((double) (__temp_odecl1) )});
			}
			
		}
		#line default
		
		public virtual object host() {
			#line 117 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
			global::System.Net.IPEndPoint localIP = ((global::System.Net.IPEndPoint) (this.sock.LocalEndPoint) );
			global::sys.net.Host tmp = new global::sys.net.Host(((string) (localIP.Address.ToString()) ));
			{
				#line 118 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
				int __temp_odecl1 = localIP.Port;
				#line 118 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
				return new global::haxe.lang.DynamicObject(new int[]{1158860648}, new object[]{tmp}, new int[]{1247576961}, new double[]{((double) (__temp_odecl1) )});
			}
			
		}
		#line default
		
		public virtual void setTimeout(double timeout) {
			unchecked {
				#line 122 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
				this.sock.ReceiveTimeout = ((int) (this.sock.SendTimeout = ((int) (global::haxe.root.Math.round(( timeout * 1000 ))) )) );
			}
			#line default
		}
		
		
		public virtual void waitForRead() {
			unchecked {
				#line 126 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
				global::haxe.root.Date _this = new global::haxe.root.Date(((global::System.DateTime) (global::System.DateTime.Now) ));
				#line 126 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
				double end = ( ( ((double) (((long) (( ((long) (global::System.TimeZone.CurrentTimeZone.ToUniversalTime(((global::System.DateTime) (_this.date) )).Ticks) ) - ((long) (global::haxe.root.Date.epochTicks) ) )) )) ) / ((double) (global::System.TimeSpan.TicksPerMillisecond) ) ) + (( (( this.sock.ReceiveTimeout <= 0 )) ? (global::haxe.root.Math.POSITIVE_INFINITY) : (((double) (this.sock.ReceiveTimeout) )) )) );
				while (true) {
					#line 127 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
					bool tmp = default(bool);
					#line 127 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
					if (( this.sock.Available == 0 )) {
						#line 127 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
						global::haxe.root.Date _this1 = new global::haxe.root.Date(((global::System.DateTime) (global::System.DateTime.Now) ));
						#line 127 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
						tmp = ( ( ((double) (((long) (( ((long) (global::System.TimeZone.CurrentTimeZone.ToUniversalTime(((global::System.DateTime) (_this1.date) )).Ticks) ) - ((long) (global::haxe.root.Date.epochTicks) ) )) )) ) / ((double) (global::System.TimeSpan.TicksPerMillisecond) ) ) < end );
					}
					else {
						#line 127 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
						tmp = false;
					}
					
					#line 127 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
					if ( ! (tmp) ) {
						#line 127 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
						break;
					}
					
					#line 128 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
					global::System.Threading.Thread.Sleep(((int) (5) ));
				}
				
			}
			#line default
		}
		
		
		public virtual void setBlocking(bool b) {
			#line 133 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
			this.sock.Blocking = ((bool) (b) );
		}
		#line default
		
		public virtual void setFastSend(bool b) {
			#line 137 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
			this.sock.NoDelay = ((bool) (b) );
		}
		#line default
		
		public override double __hx_setField_f(string field, int hash, double @value, bool handleProperties) {
			unchecked {
				#line 42 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
				switch (hash) {
					case 1066567601:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
						this.custom = ((object) (@value) );
						#line 42 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
						return @value;
					}
					
					
					default:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
						return base.__hx_setField_f(field, hash, @value, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_setField(string field, int hash, object @value, bool handleProperties) {
			unchecked {
				#line 42 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
				switch (hash) {
					case 1066567601:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
						this.custom = ((object) (@value) );
						#line 42 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
						return @value;
					}
					
					
					case 209784577:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
						this.output = ((global::haxe.io.Output) (@value) );
						#line 42 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
						return @value;
					}
					
					
					case 1042138122:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
						this.input = ((global::haxe.io.Input) (@value) );
						#line 42 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
						return @value;
					}
					
					
					case 1280842308:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
						this.sock = ((global::System.Net.Sockets.Socket) (@value) );
						#line 42 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
						return @value;
					}
					
					
					default:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
						return base.__hx_setField(field, hash, @value, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties) {
			unchecked {
				#line 42 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
				switch (hash) {
					case 952878022:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "setFastSend", 952878022)) );
					}
					
					
					case 1242623863:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "setBlocking", 1242623863)) );
					}
					
					
					case 1311059210:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "waitForRead", 1311059210)) );
					}
					
					
					case 735461151:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "setTimeout", 735461151)) );
					}
					
					
					case 1158860648:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "host", 1158860648)) );
					}
					
					
					case 1247076770:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "peer", 1247076770)) );
					}
					
					
					case 184980232:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "accept", 184980232)) );
					}
					
					
					case 1092023741:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "bind", 1092023741)) );
					}
					
					
					case 1795947670:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "shutdown", 1795947670)) );
					}
					
					
					case 1878640711:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "listen", 1878640711)) );
					}
					
					
					case 360725482:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "connect", 360725482)) );
					}
					
					
					case 1348037855:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "write", 1348037855)) );
					}
					
					
					case 1269254998:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "read", 1269254998)) );
					}
					
					
					case 1214453688:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "close", 1214453688)) );
					}
					
					
					case 1066567601:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
						return this.custom;
					}
					
					
					case 209784577:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
						return this.output;
					}
					
					
					case 1042138122:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
						return this.input;
					}
					
					
					case 1280842308:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
						return this.sock;
					}
					
					
					default:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override double __hx_getField_f(string field, int hash, bool throwErrors, bool handleProperties) {
			unchecked {
				#line 42 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
				switch (hash) {
					case 1066567601:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
						return ((double) (global::haxe.lang.Runtime.toDouble(this.custom)) );
					}
					
					
					default:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
						return base.__hx_getField_f(field, hash, throwErrors, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_invokeField(string field, int hash, object[] dynargs) {
			unchecked {
				#line 42 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
				switch (hash) {
					case 952878022:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
						this.setFastSend(global::haxe.lang.Runtime.toBool(((object) (dynargs[0]) )));
						#line 42 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
						break;
					}
					
					
					case 1242623863:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
						this.setBlocking(global::haxe.lang.Runtime.toBool(((object) (dynargs[0]) )));
						#line 42 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
						break;
					}
					
					
					case 1311059210:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
						this.waitForRead();
						#line 42 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
						break;
					}
					
					
					case 735461151:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
						this.setTimeout(((double) (global::haxe.lang.Runtime.toDouble(((object) (dynargs[0]) ))) ));
						#line 42 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
						break;
					}
					
					
					case 1158860648:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
						return this.host();
					}
					
					
					case 1247076770:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
						return this.peer();
					}
					
					
					case 184980232:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
						return this.accept();
					}
					
					
					case 1092023741:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
						this.bind(((global::sys.net.Host) (((object) (dynargs[0]) )) ), ((int) (global::haxe.lang.Runtime.toInt(((object) (dynargs[1]) ))) ));
						#line 42 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
						break;
					}
					
					
					case 1795947670:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
						this.shutdown(global::haxe.lang.Runtime.toBool(((object) (dynargs[0]) )), global::haxe.lang.Runtime.toBool(((object) (dynargs[1]) )));
						#line 42 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
						break;
					}
					
					
					case 1878640711:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
						this.listen(((int) (global::haxe.lang.Runtime.toInt(((object) (dynargs[0]) ))) ));
						#line 42 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
						break;
					}
					
					
					case 360725482:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
						this.connect(((global::sys.net.Host) (((object) (dynargs[0]) )) ), ((int) (global::haxe.lang.Runtime.toInt(((object) (dynargs[1]) ))) ));
						#line 42 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
						break;
					}
					
					
					case 1348037855:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
						this.write(global::haxe.lang.Runtime.toString(((object) (dynargs[0]) )));
						#line 42 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
						break;
					}
					
					
					case 1269254998:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
						return this.read();
					}
					
					
					case 1214453688:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
						this.close();
						#line 42 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
						break;
					}
					
					
					default:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
				#line 42 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
				return null;
			}
			#line default
		}
		
		
		public override void __hx_getFields(global::haxe.root.Array baseArr) {
			#line 42 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
			baseArr.push("custom");
			#line 42 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
			baseArr.push("output");
			#line 42 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
			baseArr.push("input");
			#line 42 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
			baseArr.push("sock");
			#line 42 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\net\\Socket.hx"
			base.__hx_getFields(baseArr);
		}
		#line default
		
	}
}


