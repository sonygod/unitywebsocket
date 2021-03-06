// Generated by Haxe 4.1.0-rc.1+0d88c583b
using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace sys.io {
	public class Process : global::haxe.lang.HxObject {
		
		public Process(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public Process(string cmd, global::haxe.root.Array args, object detached) {
			#line 39 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
			global::sys.io.Process.__hx_ctor_sys_io_Process(this, cmd, args, detached);
		}
		#line default
		
		protected static void __hx_ctor_sys_io_Process(global::sys.io.Process __hx_this, string cmd, global::haxe.root.Array args, object detached) {
			#line 40 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
			if (global::haxe.lang.Runtime.toBool((detached))) {
				#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
				throw global::haxe.lang.HaxeException.wrap("Detached process is not supported on this platform");
			}
			
			#line 42 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
			__hx_this.native = global::sys.io.Process.createNativeProcess(cmd, args);
			__hx_this.native.Start();
			#line 45 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
			__hx_this.stdout = new global::cs.io.NativeInput(((global::System.IO.Stream) (__hx_this.native.StandardOutput.BaseStream) ));
			__hx_this.stderr = new global::cs.io.NativeInput(((global::System.IO.Stream) (__hx_this.native.StandardError.BaseStream) ));
			#line 47 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
			__hx_this.stdin = new global::cs.io.NativeOutput(((global::System.IO.Stream) (__hx_this.native.StandardInput.BaseStream) ));
		}
		#line default
		
		public static global::System.Diagnostics.Process createNativeProcess(string cmd, global::haxe.root.Array args) {
			unchecked {
				#line 52 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
				global::System.Diagnostics.Process native = new global::System.Diagnostics.Process();
				native.StartInfo.CreateNoWindow = ((bool) (true) );
				#line 54 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
				native.StartInfo.RedirectStandardError = ((bool) (native.StartInfo.RedirectStandardInput = ((bool) (native.StartInfo.RedirectStandardOutput = ((bool) (true) )) )) );
				if (( args != null )) {
					#line 57 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
					if (( ( global::haxe.lang.StringExt.indexOf(cmd, "/", null) != -1 ) || ( global::haxe.lang.StringExt.indexOf(cmd, "\\", null) != -1 ) )) {
						#line 58 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
						cmd = global::sys.FileSystem.fullPath(cmd);
					}
					
					#line 59 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
					native.StartInfo.FileName = ((string) (cmd) );
					native.StartInfo.UseShellExecute = ((bool) (false) );
					#line 61 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
					native.StartInfo.Arguments = ((string) (global::sys.io.Process.buildArgumentsString(args)) );
				}
				else {
					#line 63 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
					if (( global::haxe.root.Sys.systemName() == "Windows" )) {
						#line 65 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
						global::System.Diagnostics.ProcessStartInfo tmp = native.StartInfo;
						#line 65 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
						string _g = global::System.Environment.GetEnvironmentVariable(((string) ("COMSPEC") ));
						#line 65 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
						string tmp1 = null;
						if (( _g == null )) {
							#line 65 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
							tmp1 = "cmd.exe";
						}
						else {
							#line 67 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
							string comspec = _g;
							#line 65 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
							tmp1 = comspec;
						}
						
						#line 65 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
						tmp.FileName = ((string) (tmp1) );
						#line 69 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
						native.StartInfo.Arguments = ((string) (global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("/C \"", cmd), "\"")) );
					}
					else {
						#line 71 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
						native.StartInfo.FileName = ((string) ("/bin/sh") );
						native.StartInfo.Arguments = ((string) (global::sys.io.Process.buildArgumentsString(new global::haxe.root.Array(new object[]{"-c", cmd}))) );
					}
					
					#line 74 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
					native.StartInfo.UseShellExecute = ((bool) (false) );
				}
				
				#line 76 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
				return native;
			}
			#line default
		}
		
		
		public static string buildArgumentsString(global::haxe.root.Array args) {
			unchecked {
				#line 80 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
				if (( global::haxe.root.Sys.systemName() == "Windows" )) {
					#line 82 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
					global::haxe.root.Array _g = new global::haxe.root.Array(new object[]{});
					{
						#line 83 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
						int _g1 = 0;
						#line 83 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
						while (( _g1 < args.length )) {
							#line 83 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
							string a = global::haxe.lang.Runtime.toString(args.__get(_g1));
							#line 83 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
							 ++ _g1;
							_g.push(global::haxe.SysTools.quoteWinArg(a, false));
						}
						
					}
					
					#line 82 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
					return _g.@join(" ");
				}
				else {
					#line 89 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
					global::haxe.root.Array _g2 = new global::haxe.root.Array(new object[]{});
					{
						#line 90 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
						int _g11 = 0;
						#line 90 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
						while (( _g11 < args.length )) {
							#line 90 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
							string arg = global::haxe.lang.Runtime.toString(args.__get(_g11));
							#line 90 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
							 ++ _g11;
							global::haxe.root.StringBuf b = new global::haxe.root.StringBuf();
							#line 92 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
							b.b.Append(((string) ("\"") ));
							{
								#line 93 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
								int _g12 = 0;
								#line 93 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
								int _g21 = arg.Length;
								#line 93 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
								while (( _g12 < _g21 )) {
									#line 93 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
									int i = _g12++;
									object c = global::haxe.lang.StringExt.charCodeAt(arg, i);
									#line 95 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
									if (( c == default(object) )) {
									}
									else {
										#line 95 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
										switch (((int) (global::haxe.lang.Runtime.toInt((c))) )) {
											case 34:
											case 92:
											{
												#line 97 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
												b.addChar(92);
												#line 97 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
												break;
											}
											
											
											default:
											{
												#line 98 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
												break;
											}
											
										}
										
									}
									
									#line 100 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
									b.addChar(((int) (global::haxe.lang.Runtime.toInt(c)) ));
								}
								
							}
							
							#line 102 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
							b.b.Append(((string) ("\"") ));
							_g2.push(b.b.ToString());
						}
						
					}
					
					#line 89 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
					return _g2.@join(" ");
				}
				
			}
			#line default
		}
		
		
		public global::haxe.io.Input stdout;
		
		public global::haxe.io.Input stderr;
		
		public global::haxe.io.Output stdin;
		
		public global::System.Diagnostics.Process native;
		
		public virtual int getPid() {
			#line 110 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
			return this.native.Id;
		}
		#line default
		
		public virtual object exitCode(object block) {
			#line 113 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
			bool block1 = ( (( block == default(object) )) ? (true) : (global::haxe.lang.Runtime.toBool(block)) );
			if (( ( block1 == false ) &&  ! (this.native.HasExited)  )) {
				#line 115 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
				return null;
			}
			
			#line 116 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
			this.native.WaitForExit();
			return this.native.ExitCode;
		}
		#line default
		
		public virtual void close() {
			#line 121 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
			this.native.Close();
		}
		#line default
		
		public virtual void kill() {
			#line 125 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
			this.native.Kill();
		}
		#line default
		
		public override object __hx_setField(string field, int hash, object @value, bool handleProperties) {
			unchecked {
				#line 32 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
				switch (hash) {
					case 572311959:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
						this.native = ((global::System.Diagnostics.Process) (@value) );
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
						return @value;
					}
					
					
					case 68006728:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
						this.stdin = ((global::haxe.io.Output) (@value) );
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
						return @value;
					}
					
					
					case 132916898:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
						this.stderr = ((global::haxe.io.Input) (@value) );
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
						return @value;
					}
					
					
					case 133414859:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
						this.stdout = ((global::haxe.io.Input) (@value) );
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
						return @value;
					}
					
					
					default:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
						return base.__hx_setField(field, hash, @value, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties) {
			unchecked {
				#line 32 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
				switch (hash) {
					case 1191829406:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "kill", 1191829406)) );
					}
					
					
					case 1214453688:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "close", 1214453688)) );
					}
					
					
					case 25738091:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "exitCode", 25738091)) );
					}
					
					
					case 589599061:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "getPid", 589599061)) );
					}
					
					
					case 572311959:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
						return this.native;
					}
					
					
					case 68006728:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
						return this.stdin;
					}
					
					
					case 132916898:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
						return this.stderr;
					}
					
					
					case 133414859:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
						return this.stdout;
					}
					
					
					default:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_invokeField(string field, int hash, object[] dynargs) {
			unchecked {
				#line 32 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
				switch (hash) {
					case 1191829406:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
						this.kill();
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
						break;
					}
					
					
					case 1214453688:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
						this.close();
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
						break;
					}
					
					
					case 25738091:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
						return this.exitCode(((object) (dynargs[0]) ));
					}
					
					
					case 589599061:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
						return this.getPid();
					}
					
					
					default:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
				#line 32 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
				return null;
			}
			#line default
		}
		
		
		public override void __hx_getFields(global::haxe.root.Array baseArr) {
			#line 32 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
			baseArr.push("native");
			#line 32 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
			baseArr.push("stdin");
			#line 32 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
			baseArr.push("stderr");
			#line 32 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
			baseArr.push("stdout");
			#line 32 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
			base.__hx_getFields(baseArr);
		}
		#line default
		
	}
}


