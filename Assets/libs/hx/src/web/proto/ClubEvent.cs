// Generated by Haxe 4.1.0-rc.1+0d88c583b
using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace web.proto {
	public class ClubEvent : global::openfl.events.Event {
		
		static ClubEvent() {
			#line 19 "d:\\project\\sangong\\sangong\\src\\web\\proto\\ClubEvent.hx"
			global::web.proto.ClubEvent.CREATE_CLUB = ((string) ("create_club") );
			#line 21 "d:\\project\\sangong\\sangong\\src\\web\\proto\\ClubEvent.hx"
			global::web.proto.ClubEvent.REMOVE_CLUB = ((string) ("remove_club") );
			#line 24 "d:\\project\\sangong\\sangong\\src\\web\\proto\\ClubEvent.hx"
			global::web.proto.ClubEvent.JOIN_CLUB = ((string) ("join_club") );
			global::web.proto.ClubEvent.Apply_CLUB = ((string) ("apply_club") );
			#line 27 "d:\\project\\sangong\\sangong\\src\\web\\proto\\ClubEvent.hx"
			global::web.proto.ClubEvent.Quite_CLUB = ((string) ("quite_club") );
			#line 29 "d:\\project\\sangong\\sangong\\src\\web\\proto\\ClubEvent.hx"
			global::web.proto.ClubEvent.Get_Club_INFO = ((string) ("club_Get_Club_Info") );
			global::web.proto.ClubEvent.Leave_Club = ((string) ("leave_Club") );
			#line 33 "d:\\project\\sangong\\sangong\\src\\web\\proto\\ClubEvent.hx"
			global::web.proto.ClubEvent.AGREE = ((string) ("agreeJoin_club") );
			#line 35 "d:\\project\\sangong\\sangong\\src\\web\\proto\\ClubEvent.hx"
			global::web.proto.ClubEvent.REFUCE = ((string) ("refuce_club") );
		}
		#line default
		
		public ClubEvent(global::haxe.lang.EmptyObject empty) : base(global::haxe.lang.EmptyObject.EMPTY) {
		}
		
		
		public ClubEvent(string type, object club, global::server.IHander hander, global::haxe.root.Array list, object bubbles, object cancelable) : base(global::haxe.lang.EmptyObject.EMPTY) {
			#line 46 "d:\\project\\sangong\\sangong\\src\\web\\proto\\ClubEvent.hx"
			global::web.proto.ClubEvent.__hx_ctor_web_proto_ClubEvent(this, type, club, hander, list, bubbles, cancelable);
		}
		#line default
		
		protected static void __hx_ctor_web_proto_ClubEvent(global::web.proto.ClubEvent __hx_this, string type, object club, global::server.IHander hander, global::haxe.root.Array list, object bubbles, object cancelable) {
			#line 45 "d:\\project\\sangong\\sangong\\src\\web\\proto\\ClubEvent.hx"
			bool cancelable1 = ( (( cancelable == default(object) )) ? (false) : (global::haxe.lang.Runtime.toBool(cancelable)) );
			#line 45 "d:\\project\\sangong\\sangong\\src\\web\\proto\\ClubEvent.hx"
			bool bubbles1 = ( (( bubbles == default(object) )) ? (true) : (global::haxe.lang.Runtime.toBool(bubbles)) );
			global::openfl.events.Event.__hx_ctor_openfl_events_Event(__hx_this, type, bubbles1, cancelable1);
			#line 48 "d:\\project\\sangong\\sangong\\src\\web\\proto\\ClubEvent.hx"
			__hx_this.club = club;
			__hx_this.hander = hander;
			#line 50 "d:\\project\\sangong\\sangong\\src\\web\\proto\\ClubEvent.hx"
			__hx_this.list = list;
		}
		#line default
		
		public static string CREATE_CLUB;
		
		public static string REMOVE_CLUB;
		
		public static string JOIN_CLUB;
		
		public static string Apply_CLUB;
		
		public static string Quite_CLUB;
		
		public static string Get_Club_INFO;
		
		public static string Leave_Club;
		
		public static string AGREE;
		
		public static string REFUCE;
		
		public object club;
		
		public object player;
		
		public global::haxe.root.Array list;
		
		public global::server.IHander hander;
		
		public override global::openfl.events.Event clone() {
			#line 54 "d:\\project\\sangong\\sangong\\src\\web\\proto\\ClubEvent.hx"
			global::web.proto.ClubEvent @event = new global::web.proto.ClubEvent(this.type, this.club, this.hander, this.list, this.bubbles, this.cancelable);
			@event.target = this.target;
			#line 56 "d:\\project\\sangong\\sangong\\src\\web\\proto\\ClubEvent.hx"
			@event.currentTarget = this.currentTarget;
			@event.eventPhase = this.eventPhase;
			#line 58 "d:\\project\\sangong\\sangong\\src\\web\\proto\\ClubEvent.hx"
			@event.club = this.club;
			@event.hander = this.hander;
			#line 60 "d:\\project\\sangong\\sangong\\src\\web\\proto\\ClubEvent.hx"
			@event.list = this.list;
			return @event;
		}
		#line default
		
		public override double __hx_setField_f(string field, int hash, double @value, bool handleProperties) {
			unchecked {
				#line 15 "d:\\project\\sangong\\sangong\\src\\web\\proto\\ClubEvent.hx"
				switch (hash) {
					case 934865761:
					{
						#line 15 "d:\\project\\sangong\\sangong\\src\\web\\proto\\ClubEvent.hx"
						this.player = ((object) (@value) );
						#line 15 "d:\\project\\sangong\\sangong\\src\\web\\proto\\ClubEvent.hx"
						return @value;
					}
					
					
					case 1103264054:
					{
						#line 15 "d:\\project\\sangong\\sangong\\src\\web\\proto\\ClubEvent.hx"
						this.club = ((object) (@value) );
						#line 15 "d:\\project\\sangong\\sangong\\src\\web\\proto\\ClubEvent.hx"
						return @value;
					}
					
					
					default:
					{
						#line 15 "d:\\project\\sangong\\sangong\\src\\web\\proto\\ClubEvent.hx"
						return base.__hx_setField_f(field, hash, @value, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_setField(string field, int hash, object @value, bool handleProperties) {
			unchecked {
				#line 15 "d:\\project\\sangong\\sangong\\src\\web\\proto\\ClubEvent.hx"
				switch (hash) {
					case 939359644:
					{
						#line 15 "d:\\project\\sangong\\sangong\\src\\web\\proto\\ClubEvent.hx"
						this.hander = ((global::server.IHander) (@value) );
						#line 15 "d:\\project\\sangong\\sangong\\src\\web\\proto\\ClubEvent.hx"
						return @value;
					}
					
					
					case 1202920542:
					{
						#line 15 "d:\\project\\sangong\\sangong\\src\\web\\proto\\ClubEvent.hx"
						this.list = ((global::haxe.root.Array) (@value) );
						#line 15 "d:\\project\\sangong\\sangong\\src\\web\\proto\\ClubEvent.hx"
						return @value;
					}
					
					
					case 934865761:
					{
						#line 15 "d:\\project\\sangong\\sangong\\src\\web\\proto\\ClubEvent.hx"
						this.player = ((object) (@value) );
						#line 15 "d:\\project\\sangong\\sangong\\src\\web\\proto\\ClubEvent.hx"
						return @value;
					}
					
					
					case 1103264054:
					{
						#line 15 "d:\\project\\sangong\\sangong\\src\\web\\proto\\ClubEvent.hx"
						this.club = ((object) (@value) );
						#line 15 "d:\\project\\sangong\\sangong\\src\\web\\proto\\ClubEvent.hx"
						return @value;
					}
					
					
					default:
					{
						#line 15 "d:\\project\\sangong\\sangong\\src\\web\\proto\\ClubEvent.hx"
						return base.__hx_setField(field, hash, @value, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties) {
			unchecked {
				#line 15 "d:\\project\\sangong\\sangong\\src\\web\\proto\\ClubEvent.hx"
				switch (hash) {
					case 1214452573:
					{
						#line 15 "d:\\project\\sangong\\sangong\\src\\web\\proto\\ClubEvent.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "clone", 1214452573)) );
					}
					
					
					case 939359644:
					{
						#line 15 "d:\\project\\sangong\\sangong\\src\\web\\proto\\ClubEvent.hx"
						return this.hander;
					}
					
					
					case 1202920542:
					{
						#line 15 "d:\\project\\sangong\\sangong\\src\\web\\proto\\ClubEvent.hx"
						return this.list;
					}
					
					
					case 934865761:
					{
						#line 15 "d:\\project\\sangong\\sangong\\src\\web\\proto\\ClubEvent.hx"
						return this.player;
					}
					
					
					case 1103264054:
					{
						#line 15 "d:\\project\\sangong\\sangong\\src\\web\\proto\\ClubEvent.hx"
						return this.club;
					}
					
					
					default:
					{
						#line 15 "d:\\project\\sangong\\sangong\\src\\web\\proto\\ClubEvent.hx"
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override double __hx_getField_f(string field, int hash, bool throwErrors, bool handleProperties) {
			unchecked {
				#line 15 "d:\\project\\sangong\\sangong\\src\\web\\proto\\ClubEvent.hx"
				switch (hash) {
					case 934865761:
					{
						#line 15 "d:\\project\\sangong\\sangong\\src\\web\\proto\\ClubEvent.hx"
						return ((double) (global::haxe.lang.Runtime.toDouble(this.player)) );
					}
					
					
					case 1103264054:
					{
						#line 15 "d:\\project\\sangong\\sangong\\src\\web\\proto\\ClubEvent.hx"
						return ((double) (global::haxe.lang.Runtime.toDouble(this.club)) );
					}
					
					
					default:
					{
						#line 15 "d:\\project\\sangong\\sangong\\src\\web\\proto\\ClubEvent.hx"
						return base.__hx_getField_f(field, hash, throwErrors, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override void __hx_getFields(global::haxe.root.Array baseArr) {
			#line 15 "d:\\project\\sangong\\sangong\\src\\web\\proto\\ClubEvent.hx"
			baseArr.push("hander");
			#line 15 "d:\\project\\sangong\\sangong\\src\\web\\proto\\ClubEvent.hx"
			baseArr.push("list");
			#line 15 "d:\\project\\sangong\\sangong\\src\\web\\proto\\ClubEvent.hx"
			baseArr.push("player");
			#line 15 "d:\\project\\sangong\\sangong\\src\\web\\proto\\ClubEvent.hx"
			baseArr.push("club");
			#line 15 "d:\\project\\sangong\\sangong\\src\\web\\proto\\ClubEvent.hx"
			base.__hx_getFields(baseArr);
		}
		#line default
		
	}
}


