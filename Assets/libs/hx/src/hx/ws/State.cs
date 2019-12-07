// Generated by Haxe 4.1.0-rc.1+0d88c583b

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace hx.ws {
	public class State : global::haxe.lang.Enum {
		
		protected State(int index) : base(index) {
		}
		
		
		public static readonly global::hx.ws.State Handshake = new global::hx.ws.State_Handshake();
		
		public static readonly global::hx.ws.State Head = new global::hx.ws.State_Head();
		
		public static readonly global::hx.ws.State HeadExtraLength = new global::hx.ws.State_HeadExtraLength();
		
		public static readonly global::hx.ws.State HeadExtraMask = new global::hx.ws.State_HeadExtraMask();
		
		public static readonly global::hx.ws.State Body = new global::hx.ws.State_Body();
		
		public static readonly global::hx.ws.State Closed = new global::hx.ws.State_Closed();
		
		protected static readonly string[] __hx_constructs = new string[]{"Handshake", "Head", "HeadExtraLength", "HeadExtraMask", "Body", "Closed"};
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace hx.ws {
	public sealed class State_Handshake : global::hx.ws.State {
		
		public State_Handshake() : base(0) {
		}
		
		
		public override string getTag() {
			#line 4 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\State.hx"
			return "Handshake";
		}
		#line default
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace hx.ws {
	public sealed class State_Head : global::hx.ws.State {
		
		public State_Head() : base(1) {
		}
		
		
		public override string getTag() {
			#line 5 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\State.hx"
			return "Head";
		}
		#line default
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace hx.ws {
	public sealed class State_HeadExtraLength : global::hx.ws.State {
		
		public State_HeadExtraLength() : base(2) {
		}
		
		
		public override string getTag() {
			#line 6 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\State.hx"
			return "HeadExtraLength";
		}
		#line default
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace hx.ws {
	public sealed class State_HeadExtraMask : global::hx.ws.State {
		
		public State_HeadExtraMask() : base(3) {
		}
		
		
		public override string getTag() {
			#line 7 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\State.hx"
			return "HeadExtraMask";
		}
		#line default
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace hx.ws {
	public sealed class State_Body : global::hx.ws.State {
		
		public State_Body() : base(4) {
		}
		
		
		public override string getTag() {
			#line 8 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\State.hx"
			return "Body";
		}
		#line default
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace hx.ws {
	public sealed class State_Closed : global::hx.ws.State {
		
		public State_Closed() : base(5) {
		}
		
		
		public override string getTag() {
			#line 9 "D:\\project\\sangong\\sangong\\src\\hx\\ws\\State.hx"
			return "Closed";
		}
		#line default
		
	}
}


