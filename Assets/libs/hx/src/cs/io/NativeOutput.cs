// Generated by Haxe 4.1.0-rc.1+0d88c583b
using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace cs.io {
	public class NativeOutput : global::haxe.io.Output {
		
		public NativeOutput(global::haxe.lang.EmptyObject empty) : base(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) )) {
		}
		
		
		public NativeOutput(global::System.IO.Stream stream) {
			global::cs.io.NativeOutput.__hx_ctor_cs_io_NativeOutput(this, stream);
		}
		
		
		protected static void __hx_ctor_cs_io_NativeOutput(global::cs.io.NativeOutput __hx_this, global::System.IO.Stream stream) {
			__hx_this.stream = stream;
			if ( ! (stream.CanWrite) ) {
				throw global::haxe.lang.HaxeException.wrap("Read-only stream");
			}
			
		}
		
		
		
		
		public global::System.IO.Stream stream;
		
		public override void writeByte(int c) {
			this.stream.WriteByte(((byte) (c) ));
		}
		
		
		public override void close() {
			this.stream.Close();
		}
		
		
		public override void flush() {
			this.stream.Flush();
		}
		
		
		public override void prepare(int nbytes) {
			this.stream.SetLength(((long) (( ((long) (this.stream.Length) ) + ((long) (nbytes) ) )) ));
		}
		
		
		public bool get_canSeek() {
			return this.stream.CanSeek;
		}
		
		
		public virtual void seek(int p, global::sys.io.FileSeek pos) {
			unchecked {
				global::System.IO.SeekOrigin pos1 = default(global::System.IO.SeekOrigin);
				switch (pos._hx_index) {
					case 0:
					{
						pos1 = global::System.IO.SeekOrigin.Begin;
						break;
					}
					
					
					case 1:
					{
						pos1 = global::System.IO.SeekOrigin.Current;
						break;
					}
					
					
					case 2:
					{
						pos1 = global::System.IO.SeekOrigin.End;
						break;
					}
					
					
				}
				
				this.stream.Seek(((long) (p) ), ((global::System.IO.SeekOrigin) (pos1) ));
			}
		}
		
		
		public virtual int tell() {
			return ((int) (this.stream.Position) );
		}
		
		
		public override object __hx_setField(string field, int hash, object @value, bool handleProperties) {
			unchecked {
				switch (hash) {
					case 288167040:
					{
						this.stream = ((global::System.IO.Stream) (@value) );
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
					case 1291436593:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "tell", 1291436593)) );
					}
					
					
					case 1280345464:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "seek", 1280345464)) );
					}
					
					
					case 1889717695:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "get_canSeek", 1889717695)) );
					}
					
					
					case 937267591:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "prepare", 937267591)) );
					}
					
					
					case 43737796:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "flush", 43737796)) );
					}
					
					
					case 1214453688:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "close", 1214453688)) );
					}
					
					
					case 1238832007:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "writeByte", 1238832007)) );
					}
					
					
					case 288167040:
					{
						return this.stream;
					}
					
					
					case 1789423016:
					{
						return this.get_canSeek();
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
					case 1238832007:
					case 1214453688:
					case 43737796:
					case 937267591:
					{
						return global::haxe.lang.Runtime.slowCallField(this, field, dynargs);
					}
					
					
					case 1291436593:
					{
						return this.tell();
					}
					
					
					case 1280345464:
					{
						this.seek(((int) (global::haxe.lang.Runtime.toInt(((object) (dynargs[0]) ))) ), ((global::sys.io.FileSeek) (((object) (dynargs[1]) )) ));
						break;
					}
					
					
					case 1889717695:
					{
						return this.get_canSeek();
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
			baseArr.push("stream");
			baseArr.push("canSeek");
			base.__hx_getFields(baseArr);
		}
		
		
	}
}


