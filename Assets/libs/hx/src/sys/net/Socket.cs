// Generated by Haxe 4.1.0-rc.1+0d88c583b
using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace sys.net {
	public class Socket : global::haxe.lang.HxObject {
		
		public Socket(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public Socket() {
			global::sys.net.Socket.__hx_ctor_sys_net_Socket(this);
		}
		
		
		protected static void __hx_ctor_sys_net_Socket(global::sys.net.Socket __hx_this) {
			__hx_this.sock = null;
			{
				__hx_this.sock = new global::System.Net.Sockets.Socket(global::System.Net.Sockets.AddressFamily.InterNetwork, global::System.Net.Sockets.SocketType.Stream, global::System.Net.Sockets.ProtocolType.Tcp);
				__hx_this.sock.Blocking = ((bool) (true) );
			}
			
		}
		
		
		public static object @select(global::haxe.root.Array read, global::haxe.root.Array write, global::haxe.root.Array others, object timeout) {
			unchecked {
				global::haxe.ds.IntMap map = new global::haxe.ds.IntMap();
				if (( read != null )) {
					int _g = 0;
					while (( _g < read.length )) {
						global::sys.net.Socket s = ((global::sys.net.Socket) (read.__get(_g)) );
						 ++ _g;
						map.@set(((int) (s.sock.Handle.ToInt32()) ), ((object) (s) ));
					}
					
				}
				
				if (( write != null )) {
					int _g1 = 0;
					while (( _g1 < write.length )) {
						global::sys.net.Socket s1 = ((global::sys.net.Socket) (write.__get(_g1)) );
						 ++ _g1;
						map.@set(((int) (s1.sock.Handle.ToInt32()) ), ((object) (s1) ));
					}
					
				}
				
				if (( others != null )) {
					int _g2 = 0;
					while (( _g2 < others.length )) {
						global::sys.net.Socket s2 = ((global::sys.net.Socket) (others.__get(_g2)) );
						 ++ _g2;
						map.@set(((int) (s2.sock.Handle.ToInt32()) ), ((object) (s2) ));
					}
					
				}
				
				global::System.Collections.ArrayList a = new global::System.Collections.ArrayList(((int) (( (( read == null )) ? (0) : (read.length) )) ));
				if (( read != null )) {
					int _g3 = 0;
					while (( _g3 < read.length )) {
						global::sys.net.Socket s3 = ((global::sys.net.Socket) (read.__get(_g3)) );
						 ++ _g3;
						a.Add(((object) (s3.sock) ));
					}
					
				}
				
				global::System.Collections.ArrayList rawRead = a;
				global::System.Collections.ArrayList a1 = new global::System.Collections.ArrayList(((int) (( (( write == null )) ? (0) : (write.length) )) ));
				if (( write != null )) {
					int _g4 = 0;
					while (( _g4 < write.length )) {
						global::sys.net.Socket s4 = ((global::sys.net.Socket) (write.__get(_g4)) );
						 ++ _g4;
						a1.Add(((object) (s4.sock) ));
					}
					
				}
				
				global::System.Collections.ArrayList rawWrite = a1;
				global::System.Collections.ArrayList a2 = new global::System.Collections.ArrayList(((int) (( (( others == null )) ? (0) : (others.length) )) ));
				if (( others != null )) {
					int _g5 = 0;
					while (( _g5 < others.length )) {
						global::sys.net.Socket s5 = ((global::sys.net.Socket) (others.__get(_g5)) );
						 ++ _g5;
						a2.Add(((object) (s5.sock) ));
					}
					
				}
				
				global::System.Collections.ArrayList rawOthers = a2;
				int microsec = ( (( timeout == default(object) )) ? (-1) : (((int) (( ((double) (global::haxe.lang.Runtime.toDouble(timeout)) ) * ((double) (1000000) ) )) )) );
				global::System.Net.Sockets.Socket.Select(((global::System.Collections.IList) (rawRead) ), ((global::System.Collections.IList) (rawWrite) ), ((global::System.Collections.IList) (rawOthers) ), ((int) (microsec) ));
				global::haxe.root.Array a3 = new global::haxe.root.Array(new object[]{});
				{
					int _g6 = 0;
					int _g11 = rawRead.Count;
					while (( _g6 < _g11 )) {
						int i = _g6++;
						global::System.Net.Sockets.Socket s6 = ((global::System.Net.Sockets.Socket) (rawRead[i]) );
						a3.push(((global::sys.net.Socket) (map.@get(((int) (s6.Handle.ToInt32()) ))) ));
					}
					
				}
				
				global::haxe.root.Array tmp = a3;
				global::haxe.root.Array a4 = new global::haxe.root.Array(new object[]{});
				{
					int _g7 = 0;
					int _g12 = rawWrite.Count;
					while (( _g7 < _g12 )) {
						int i1 = _g7++;
						global::System.Net.Sockets.Socket s7 = ((global::System.Net.Sockets.Socket) (rawWrite[i1]) );
						a4.push(((global::sys.net.Socket) (map.@get(((int) (s7.Handle.ToInt32()) ))) ));
					}
					
				}
				
				global::haxe.root.Array tmp1 = a4;
				global::haxe.root.Array a5 = new global::haxe.root.Array(new object[]{});
				{
					int _g8 = 0;
					int _g13 = rawOthers.Count;
					while (( _g8 < _g13 )) {
						int i2 = _g8++;
						global::System.Net.Sockets.Socket s8 = ((global::System.Net.Sockets.Socket) (rawOthers[i2]) );
						a5.push(((global::sys.net.Socket) (map.@get(((int) (s8.Handle.ToInt32()) ))) ));
					}
					
				}
				
				return new global::haxe.lang.DynamicObject(new int[]{1269254998, 1348037855, 1898155939}, new object[]{tmp, tmp1, a5}, new int[]{}, new double[]{});
			}
		}
		
		
		public global::System.Net.Sockets.Socket sock;
		
		public global::haxe.io.Input input;
		
		public global::haxe.io.Output output;
		
		public object custom;
		
		public virtual void close() {
			this.sock.Close();
			this.input = null;
			this.output = null;
		}
		
		
		public virtual string read() {
			return this.input.readAll(null).toString();
		}
		
		
		public virtual void write(string content) {
			this.output.writeString(content, null);
		}
		
		
		public virtual void connect(global::sys.net.Host host, int port) {
			this.sock.Connect(((global::System.Net.IPAddress) (host.ipAddress) ), ((int) (port) ));
			if (this.sock.Connected) {
				this.output = new global::cs.io.NativeOutput(((global::System.IO.Stream) (new global::System.Net.Sockets.NetworkStream(this.sock)) ));
				this.input = new global::cs.io.NativeInput(((global::System.IO.Stream) (new global::System.Net.Sockets.NetworkStream(this.sock)) ));
			}
			else {
				throw global::haxe.lang.HaxeException.wrap("Connection failed.");
			}
			
		}
		
		
		public virtual void listen(int connections) {
			this.sock.Listen(((int) (connections) ));
		}
		
		
		public virtual void shutdown(bool read, bool write) {
			if (( read && write )) {
				this.sock.Shutdown(((global::System.Net.Sockets.SocketShutdown) (global::System.Net.Sockets.SocketShutdown.Both) ));
				this.input = null;
				this.output = null;
			}
			else if (read) {
				this.sock.Shutdown(((global::System.Net.Sockets.SocketShutdown) (global::System.Net.Sockets.SocketShutdown.Receive) ));
				this.input = null;
			}
			else if (write) {
				this.sock.Shutdown(((global::System.Net.Sockets.SocketShutdown) (global::System.Net.Sockets.SocketShutdown.Send) ));
				this.output = null;
			}
			
		}
		
		
		public virtual void bind(global::sys.net.Host host, int port) {
			this.sock = new global::System.Net.Sockets.Socket(global::System.Net.Sockets.AddressFamily.InterNetwork, global::System.Net.Sockets.SocketType.Stream, global::System.Net.Sockets.ProtocolType.Tcp);
			this.sock.Bind(((global::System.Net.EndPoint) (new global::System.Net.IPEndPoint(((global::System.Net.IPAddress) (host.ipAddress) ), ((int) (port) ))) ));
		}
		
		
		public virtual global::sys.net.Socket accept() {
			global::sys.net.Socket r = new global::sys.net.Socket();
			r.sock = this.sock.Accept();
			r.output = new global::cs.io.NativeOutput(((global::System.IO.Stream) (new global::System.Net.Sockets.NetworkStream(r.sock)) ));
			r.input = new global::cs.io.NativeInput(((global::System.IO.Stream) (new global::System.Net.Sockets.NetworkStream(r.sock)) ));
			return r;
		}
		
		
		public virtual object peer() {
			global::System.Net.IPEndPoint remoteIP = ((global::System.Net.IPEndPoint) (this.sock.RemoteEndPoint) );
			global::sys.net.Host tmp = new global::sys.net.Host(((string) (remoteIP.Address.ToString()) ));
			{
				int __temp_odecl1 = remoteIP.Port;
				return new global::haxe.lang.DynamicObject(new int[]{1158860648}, new object[]{tmp}, new int[]{1247576961}, new double[]{((double) (__temp_odecl1) )});
			}
			
		}
		
		
		public virtual object host() {
			global::System.Net.IPEndPoint localIP = ((global::System.Net.IPEndPoint) (this.sock.LocalEndPoint) );
			global::sys.net.Host tmp = new global::sys.net.Host(((string) (localIP.Address.ToString()) ));
			{
				int __temp_odecl1 = localIP.Port;
				return new global::haxe.lang.DynamicObject(new int[]{1158860648}, new object[]{tmp}, new int[]{1247576961}, new double[]{((double) (__temp_odecl1) )});
			}
			
		}
		
		
		public virtual void setTimeout(double timeout) {
			unchecked {
				this.sock.ReceiveTimeout = ((int) (this.sock.SendTimeout = ((int) (global::haxe.root.Math.round(( timeout * 1000 ))) )) );
			}
		}
		
		
		public virtual void waitForRead() {
			unchecked {
				global::haxe.root.Date _this = new global::haxe.root.Date(((global::System.DateTime) (global::System.DateTime.Now) ));
				double end = ( ( ((double) (((long) (( ((long) (global::System.TimeZone.CurrentTimeZone.ToUniversalTime(((global::System.DateTime) (_this.date) )).Ticks) ) - ((long) (global::haxe.root.Date.epochTicks) ) )) )) ) / ((double) (global::System.TimeSpan.TicksPerMillisecond) ) ) + (( (( this.sock.ReceiveTimeout <= 0 )) ? (global::haxe.root.Math.POSITIVE_INFINITY) : (((double) (this.sock.ReceiveTimeout) )) )) );
				while (true) {
					bool tmp = default(bool);
					if (( this.sock.Available == 0 )) {
						global::haxe.root.Date _this1 = new global::haxe.root.Date(((global::System.DateTime) (global::System.DateTime.Now) ));
						tmp = ( ( ((double) (((long) (( ((long) (global::System.TimeZone.CurrentTimeZone.ToUniversalTime(((global::System.DateTime) (_this1.date) )).Ticks) ) - ((long) (global::haxe.root.Date.epochTicks) ) )) )) ) / ((double) (global::System.TimeSpan.TicksPerMillisecond) ) ) < end );
					}
					else {
						tmp = false;
					}
					
					if ( ! (tmp) ) {
						break;
					}
					
					global::System.Threading.Thread.Sleep(((int) (5) ));
				}
				
			}
		}
		
		
		public virtual void setBlocking(bool b) {
			this.sock.Blocking = ((bool) (b) );
		}
		
		
		public virtual void setFastSend(bool b) {
			this.sock.NoDelay = ((bool) (b) );
		}
		
		
		public override double __hx_setField_f(string field, int hash, double @value, bool handleProperties) {
			unchecked {
				switch (hash) {
					case 1066567601:
					{
						this.custom = ((object) (@value) );
						return @value;
					}
					
					
					default:
					{
						return base.__hx_setField_f(field, hash, @value, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override object __hx_setField(string field, int hash, object @value, bool handleProperties) {
			unchecked {
				switch (hash) {
					case 1066567601:
					{
						this.custom = ((object) (@value) );
						return @value;
					}
					
					
					case 209784577:
					{
						this.output = ((global::haxe.io.Output) (@value) );
						return @value;
					}
					
					
					case 1042138122:
					{
						this.input = ((global::haxe.io.Input) (@value) );
						return @value;
					}
					
					
					case 1280842308:
					{
						this.sock = ((global::System.Net.Sockets.Socket) (@value) );
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
					case 952878022:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "setFastSend", 952878022)) );
					}
					
					
					case 1242623863:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "setBlocking", 1242623863)) );
					}
					
					
					case 1311059210:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "waitForRead", 1311059210)) );
					}
					
					
					case 735461151:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "setTimeout", 735461151)) );
					}
					
					
					case 1158860648:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "host", 1158860648)) );
					}
					
					
					case 1247076770:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "peer", 1247076770)) );
					}
					
					
					case 184980232:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "accept", 184980232)) );
					}
					
					
					case 1092023741:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "bind", 1092023741)) );
					}
					
					
					case 1795947670:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "shutdown", 1795947670)) );
					}
					
					
					case 1878640711:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "listen", 1878640711)) );
					}
					
					
					case 360725482:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "connect", 360725482)) );
					}
					
					
					case 1348037855:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "write", 1348037855)) );
					}
					
					
					case 1269254998:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "read", 1269254998)) );
					}
					
					
					case 1214453688:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "close", 1214453688)) );
					}
					
					
					case 1066567601:
					{
						return this.custom;
					}
					
					
					case 209784577:
					{
						return this.output;
					}
					
					
					case 1042138122:
					{
						return this.input;
					}
					
					
					case 1280842308:
					{
						return this.sock;
					}
					
					
					default:
					{
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override double __hx_getField_f(string field, int hash, bool throwErrors, bool handleProperties) {
			unchecked {
				switch (hash) {
					case 1066567601:
					{
						return ((double) (global::haxe.lang.Runtime.toDouble(this.custom)) );
					}
					
					
					default:
					{
						return base.__hx_getField_f(field, hash, throwErrors, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override object __hx_invokeField(string field, int hash, object[] dynargs) {
			unchecked {
				switch (hash) {
					case 952878022:
					{
						this.setFastSend(global::haxe.lang.Runtime.toBool(((object) (dynargs[0]) )));
						break;
					}
					
					
					case 1242623863:
					{
						this.setBlocking(global::haxe.lang.Runtime.toBool(((object) (dynargs[0]) )));
						break;
					}
					
					
					case 1311059210:
					{
						this.waitForRead();
						break;
					}
					
					
					case 735461151:
					{
						this.setTimeout(((double) (global::haxe.lang.Runtime.toDouble(((object) (dynargs[0]) ))) ));
						break;
					}
					
					
					case 1158860648:
					{
						return this.host();
					}
					
					
					case 1247076770:
					{
						return this.peer();
					}
					
					
					case 184980232:
					{
						return this.accept();
					}
					
					
					case 1092023741:
					{
						this.bind(((global::sys.net.Host) (((object) (dynargs[0]) )) ), ((int) (global::haxe.lang.Runtime.toInt(((object) (dynargs[1]) ))) ));
						break;
					}
					
					
					case 1795947670:
					{
						this.shutdown(global::haxe.lang.Runtime.toBool(((object) (dynargs[0]) )), global::haxe.lang.Runtime.toBool(((object) (dynargs[1]) )));
						break;
					}
					
					
					case 1878640711:
					{
						this.listen(((int) (global::haxe.lang.Runtime.toInt(((object) (dynargs[0]) ))) ));
						break;
					}
					
					
					case 360725482:
					{
						this.connect(((global::sys.net.Host) (((object) (dynargs[0]) )) ), ((int) (global::haxe.lang.Runtime.toInt(((object) (dynargs[1]) ))) ));
						break;
					}
					
					
					case 1348037855:
					{
						this.write(global::haxe.lang.Runtime.toString(((object) (dynargs[0]) )));
						break;
					}
					
					
					case 1269254998:
					{
						return this.read();
					}
					
					
					case 1214453688:
					{
						this.close();
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
			baseArr.push("custom");
			baseArr.push("output");
			baseArr.push("input");
			baseArr.push("sock");
			base.__hx_getFields(baseArr);
		}
		
		
	}
}


