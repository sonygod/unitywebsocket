// Generated by Haxe 4.1.0-rc.1+0d88c583b
using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.root {
	public class Sys : global::haxe.lang.HxObject {
		
		public Sys(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public Sys() {
			#line 28 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Sys.hx"
			global::haxe.root.Sys.__hx_ctor__Sys(this);
		}
		#line default
		
		protected static void __hx_ctor__Sys(global::haxe.root.Sys __hx_this) {
		}
		
		
		public static global::haxe.ds.StringMap _env;
		
		public static global::haxe.root.Array _args;
		
		public static void print(object v) {
			#line 33 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Sys.hx"
			global::System.Console.Write(((object) (v) ));
		}
		#line default
		
		public static void println(object v) {
			#line 37 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Sys.hx"
			global::System.Console.WriteLine(((object) (v) ));
		}
		#line default
		
		public static global::haxe.root.Array args() {
			#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Sys.hx"
			if (( global::haxe.root.Sys._args == null )) {
				#line 42 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Sys.hx"
				string[] native = global::System.Environment.GetCommandLineArgs();
				#line 42 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Sys.hx"
				object[] ret = new object[( native as global::System.Array ).Length];
				#line 42 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Sys.hx"
				{
					#line 42 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Sys.hx"
					int _g = 0;
					#line 42 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Sys.hx"
					int _g1 = ( native as global::System.Array ).Length;
					#line 42 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Sys.hx"
					while (( _g < _g1 )) {
						#line 42 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Sys.hx"
						int i = _g++;
						#line 42 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Sys.hx"
						ret[i] = ((string) (native[i]) );
					}
					
				}
				
				#line 42 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Sys.hx"
				object[] dyn = ret;
				#line 42 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Sys.hx"
				global::haxe.root.Array ret1 = new global::haxe.root.Array(((object[]) (dyn) ));
				string __temp_expr1 = global::haxe.lang.Runtime.toString(ret1.shift());
				#line 44 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Sys.hx"
				global::haxe.root.Sys._args = ret1;
			}
			
			#line 46 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Sys.hx"
			return global::haxe.root.Sys._args.copy();
		}
		#line default
		
		public static string getEnv(string s) {
			#line 50 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Sys.hx"
			return global::System.Environment.GetEnvironmentVariable(((string) (s) ));
		}
		#line default
		
		public static void putEnv(string s, string v) {
			#line 54 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Sys.hx"
			global::System.Environment.SetEnvironmentVariable(((string) (s) ), ((string) (v) ));
			if (( global::haxe.root.Sys._env != null )) {
				#line 56 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Sys.hx"
				global::haxe.root.Sys._env.@set(((string) (s) ), ((object) (v) ));
			}
			
		}
		#line default
		
		public static global::haxe.ds.StringMap environment() {
			#line 60 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Sys.hx"
			if (( global::haxe.root.Sys._env == null )) {
				#line 61 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Sys.hx"
				global::haxe.ds.StringMap e = global::haxe.root.Sys._env = new global::haxe.ds.StringMap();
				global::System.Collections.IDictionaryEnumerator nenv = ((global::System.Collections.IDictionaryEnumerator) (( global::System.Environment.GetEnvironmentVariables() as global::System.Collections.IEnumerable ).GetEnumerator()) );
				#line 63 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Sys.hx"
				while (( nenv as global::System.Collections.IEnumerator ).MoveNext()) {
					#line 64 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Sys.hx"
					e.@set(global::haxe.lang.Runtime.toString(nenv.Key), ((object) (nenv.Value) ));
				}
				
			}
			
			#line 68 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Sys.hx"
			return ((global::haxe.ds.StringMap) (global::haxe.root.Sys._env) );
		}
		#line default
		
		public static void sleep(double seconds) {
			unchecked {
				#line 72 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Sys.hx"
				global::System.Threading.Thread.Sleep(((int) (((int) (( seconds * 1000 )) )) ));
			}
			#line default
		}
		
		
		public static bool setTimeLocale(string loc) {
			#line 77 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Sys.hx"
			return false;
		}
		#line default
		
		public static string getCwd() {
			#line 81 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Sys.hx"
			return global::System.IO.Directory.GetCurrentDirectory();
		}
		#line default
		
		public static void setCwd(string s) {
			#line 85 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Sys.hx"
			global::System.IO.Directory.SetCurrentDirectory(((string) (s) ));
		}
		#line default
		
		public static string systemName() {
			unchecked {
				#line 90 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Sys.hx"
				switch (global::haxe.lang.Runtime.concat(global::haxe.root.Std.@string(global::System.Environment.OSVersion.Platform), "")) {
					case "MacOSX":
					{
						#line 96 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Sys.hx"
						return "Mac";
					}
					
					
					case "Unix":
					{
						#line 92 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Sys.hx"
						return "Linux";
					}
					
					
					case "Xbox":
					{
						#line 94 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Sys.hx"
						return "Xbox";
					}
					
					
					default:
					{
						#line 98 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Sys.hx"
						int ver = ((int) (global::haxe.lang.Runtime.toInt(((object) (global::System.Environment.OSVersion.Platform) ))) );
						if (( ( ( ver == 4 ) || ( ver == 6 ) ) || ( ver == 128 ) )) {
							#line 100 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Sys.hx"
							return "Linux";
						}
						
						#line 101 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Sys.hx"
						return "Windows";
					}
					
				}
				
			}
			#line default
		}
		
		
		public static int command(string cmd, global::haxe.root.Array args) {
			#line 106 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Sys.hx"
			global::System.Diagnostics.Process proc = global::sys.io.Process.createNativeProcess(cmd, args);
			global::System.Diagnostics.DataReceivedEventHandler this1 = ((global::System.Diagnostics.DataReceivedEventHandler) (( (( global::Sys_command_107__Fun.__hx_current != null )) ? (global::Sys_command_107__Fun.__hx_current) : (global::Sys_command_107__Fun.__hx_current = ((global::Sys_command_107__Fun) (new global::Sys_command_107__Fun()) )) ).Delegate) );
			proc.OutputDataReceived += ((global::System.Diagnostics.DataReceivedEventHandler) (this1) );
			#line 112 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Sys.hx"
			global::haxe.io.Output stderr = ((global::haxe.io.Output) (new global::cs.io.NativeOutput(((global::System.IO.Stream) (global::System.Console.OpenStandardError()) ))) );
			global::System.Diagnostics.DataReceivedEventHandler this2 = ((global::System.Diagnostics.DataReceivedEventHandler) (new global::Sys_command_113__Fun(stderr).Delegate) );
			proc.ErrorDataReceived += ((global::System.Diagnostics.DataReceivedEventHandler) (this2) );
			#line 118 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Sys.hx"
			proc.Start();
			proc.BeginOutputReadLine();
			#line 120 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Sys.hx"
			proc.BeginErrorReadLine();
			proc.WaitForExit();
			#line 122 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Sys.hx"
			int exitCode = proc.ExitCode;
			( proc as global::System.ComponentModel.Component ).Dispose();
			#line 124 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Sys.hx"
			return exitCode;
		}
		#line default
		
		public static void exit(int code) {
			#line 128 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Sys.hx"
			global::System.Environment.Exit(((int) (code) ));
		}
		#line default
		
		public static readonly long epochTicks = new global::System.DateTime(1970, 1, 1).Ticks;
		
		public static double time() {
			#line 134 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Sys.hx"
			return ( ((double) (((long) (( ((long) (global::System.DateTime.UtcNow.Ticks) ) - ((long) (global::haxe.root.Sys.epochTicks) ) )) )) ) / ((double) (global::System.TimeSpan.TicksPerSecond) ) );
		}
		#line default
		
		public static double cpuTime() {
			unchecked {
				#line 138 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Sys.hx"
				return ( ((double) (global::System.Environment.TickCount) ) / 1000 );
			}
			#line default
		}
		
		
		public static string executablePath() {
			#line 142 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Sys.hx"
			return global::System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase;
		}
		#line default
		
		public static string programPath() {
			#line 146 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Sys.hx"
			return global::System.Reflection.Assembly.GetExecutingAssembly().Location;
		}
		#line default
		
		public static int getChar(bool echo) {
			#line 151 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Sys.hx"
			return ((int) (global::System.Console.ReadKey(((bool) ( ! (echo) ) )).KeyChar) );
		}
		#line default
		
		public static global::haxe.io.Input stdin() {
			#line 159 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Sys.hx"
			return new global::cs.io.NativeInput(((global::System.IO.Stream) (global::System.Console.OpenStandardInput()) ));
		}
		#line default
		
		public static global::haxe.io.Output stdout() {
			#line 167 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Sys.hx"
			return new global::cs.io.NativeOutput(((global::System.IO.Stream) (global::System.Console.OpenStandardOutput()) ));
		}
		#line default
		
		public static global::haxe.io.Output stderr() {
			#line 175 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Sys.hx"
			return new global::cs.io.NativeOutput(((global::System.IO.Stream) (global::System.Console.OpenStandardError()) ));
		}
		#line default
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
public class Sys_command_107__Fun : global::haxe.lang.Function {
	
	public Sys_command_107__Fun() : base(2, 0) {
	}
	
	
	public static global::Sys_command_107__Fun __hx_current;
	
	public override object __hx_invoke2_o(double __fn_float1, object __fn_dyn1, double __fn_float2, object __fn_dyn2) {
		#line 107 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Sys.hx"
		global::System.Diagnostics.DataReceivedEventArgs evtArgs = ( (( __fn_dyn2 == global::haxe.lang.Runtime.undefined )) ? (((global::System.Diagnostics.DataReceivedEventArgs) (((object) (__fn_float2) )) )) : (((global::System.Diagnostics.DataReceivedEventArgs) (__fn_dyn2) )) );
		#line 107 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Sys.hx"
		object p = ( (( __fn_dyn1 == global::haxe.lang.Runtime.undefined )) ? (((object) (__fn_float1) )) : (((object) (__fn_dyn1) )) );
		#line 107 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Sys.hx"
		this.Delegate(p, evtArgs);
		#line 107 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Sys.hx"
		return null;
	}
	#line default
	
	public void Delegate(object p, global::System.Diagnostics.DataReceivedEventArgs evtArgs) {
		#line 108 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Sys.hx"
		string data = evtArgs.Data;
		if (( (( data != null )) ? (( data != "" )) : (false) )) {
			#line 110 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Sys.hx"
			global::System.Console.WriteLine(((object) (data) ));
		}
		
	}
	#line default
	
}



#pragma warning disable 109, 114, 219, 429, 168, 162
public class Sys_command_113__Fun : global::haxe.lang.Function {
	
	public Sys_command_113__Fun(global::haxe.io.Output stderr) : base(2, 0) {
		#line 113 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Sys.hx"
		this.stderr = stderr;
	}
	#line default
	
	public override object __hx_invoke2_o(double __fn_float1, object __fn_dyn1, double __fn_float2, object __fn_dyn2) {
		#line 113 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Sys.hx"
		global::System.Diagnostics.DataReceivedEventArgs evtArgs1 = ( (( __fn_dyn2 == global::haxe.lang.Runtime.undefined )) ? (((global::System.Diagnostics.DataReceivedEventArgs) (((object) (__fn_float2) )) )) : (((global::System.Diagnostics.DataReceivedEventArgs) (__fn_dyn2) )) );
		#line 113 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Sys.hx"
		object p1 = ( (( __fn_dyn1 == global::haxe.lang.Runtime.undefined )) ? (((object) (__fn_float1) )) : (((object) (__fn_dyn1) )) );
		#line 113 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Sys.hx"
		this.Delegate(p1, evtArgs1);
		#line 113 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Sys.hx"
		return null;
	}
	#line default
	
	public void Delegate(object p1, global::System.Diagnostics.DataReceivedEventArgs evtArgs1) {
		#line 114 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Sys.hx"
		string data1 = evtArgs1.Data;
		if (( (( data1 != null )) ? (( data1 != "" )) : (false) )) {
			#line 116 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Sys.hx"
			this.stderr.writeString(global::haxe.lang.Runtime.concat(data1, "\n"), null);
		}
		
	}
	#line default
	
	public global::haxe.io.Output stderr;
	
}


