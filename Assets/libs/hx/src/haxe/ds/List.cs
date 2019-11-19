// Generated by Haxe 4.1.0-rc.1+0d88c583b
using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.ds {
	public class List : global::haxe.lang.HxObject {
		
		public List(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public List() {
			#line 44 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
			global::haxe.ds.List.__hx_ctor_haxe_ds_List(((global::haxe.ds.List) (this) ));
		}
		#line default
		
		protected static void __hx_ctor_haxe_ds_List(global::haxe.ds.List __hx_this) {
			#line 45 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
			__hx_this.length = 0;
		}
		#line default
		
		public global::haxe.ds._List.ListNode h;
		
		public global::haxe.ds._List.ListNode q;
		
		public int length;
		
		public virtual void @add(object item) {
			#line 54 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
			global::haxe.ds._List.ListNode next = null;
			#line 54 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
			global::haxe.ds._List.ListNode x = new global::haxe.ds._List.ListNode(item, next);
			if (( this.h == null )) {
				#line 56 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
				this.h = x;
			}
			else {
				#line 58 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
				this.q.next = x;
			}
			
			#line 59 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
			this.q = x;
			this.length++;
		}
		#line default
		
		public virtual void push(object item) {
			#line 69 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
			global::haxe.ds._List.ListNode x = new global::haxe.ds._List.ListNode(item, this.h);
			this.h = x;
			#line 71 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
			if (( this.q == null )) {
				#line 72 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
				this.q = x;
			}
			
			#line 73 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
			this.length++;
		}
		#line default
		
		public virtual object first() {
			#line 82 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
			if (( this.h == null )) {
				#line 82 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
				return null;
			}
			else {
				#line 82 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
				return this.h.item;
			}
			
		}
		#line default
		
		public virtual object last() {
			#line 91 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
			if (( this.q == null )) {
				#line 91 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
				return null;
			}
			else {
				#line 91 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
				return this.q.item;
			}
			
		}
		#line default
		
		public virtual object pop() {
			#line 100 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
			if (( this.h == null )) {
				#line 101 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
				return null;
			}
			
			#line 102 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
			object x = this.h.item;
			this.h = this.h.next;
			#line 104 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
			if (( this.h == null )) {
				#line 105 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
				this.q = null;
			}
			
			#line 106 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
			this.length--;
			return x;
		}
		#line default
		
		public virtual bool isEmpty() {
			#line 114 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
			return ( this.h == null );
		}
		#line default
		
		public virtual void clear() {
			#line 124 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
			this.h = null;
			this.q = null;
			#line 126 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
			this.length = 0;
		}
		#line default
		
		public virtual bool @remove(object v) {
			#line 138 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
			global::haxe.ds._List.ListNode prev = null;
			global::haxe.ds._List.ListNode l = this.h;
			#line 140 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
			while (( l != null )) {
				#line 141 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
				if (global::haxe.lang.Runtime.eq(l.item, v)) {
					#line 142 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
					if (( prev == null )) {
						#line 143 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
						this.h = l.next;
					}
					else {
						#line 145 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
						prev.next = l.next;
					}
					
					#line 146 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
					if (( this.q == l )) {
						#line 147 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
						this.q = prev;
					}
					
					#line 148 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
					this.length--;
					return true;
				}
				
				#line 151 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
				prev = l;
				l = l.next;
			}
			
			#line 154 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
			return false;
		}
		#line default
		
		public global::haxe.ds._List.ListIterator iterator() {
			#line 161 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
			return new global::haxe.ds._List.ListIterator(((global::haxe.ds._List.ListNode) (this.h) ));
		}
		#line default
		
		public global::haxe.ds._List.ListKeyValueIterator keyValueIterator() {
			#line 168 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
			return new global::haxe.ds._List.ListKeyValueIterator(((global::haxe.ds._List.ListNode) (this.h) ));
		}
		#line default
		
		public virtual string toString() {
			#line 178 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
			global::System.Text.StringBuilder s_b = new global::System.Text.StringBuilder();
			bool first = true;
			#line 180 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
			global::haxe.ds._List.ListNode l = this.h;
			s_b.Append(((string) ("{") ));
			#line 182 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
			while (( l != null )) {
				#line 183 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
				if (first) {
					#line 184 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
					first = false;
				}
				else {
					#line 186 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
					s_b.Append(((string) (", ") ));
				}
				
				#line 187 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
				s_b.Append(((string) (global::haxe.root.Std.@string(global::haxe.root.Std.@string(l.item))) ));
				l = l.next;
			}
			
			#line 190 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
			s_b.Append(((string) ("}") ));
			return s_b.ToString();
		}
		#line default
		
		public virtual string @join(string sep) {
			#line 199 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
			global::System.Text.StringBuilder s_b = new global::System.Text.StringBuilder();
			bool first = true;
			#line 201 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
			global::haxe.ds._List.ListNode l = this.h;
			while (( l != null )) {
				#line 203 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
				if (first) {
					#line 204 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
					first = false;
				}
				else {
					#line 206 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
					s_b.Append(((string) (global::haxe.root.Std.@string(sep)) ));
				}
				
				#line 207 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
				s_b.Append(((string) (global::haxe.root.Std.@string(l.item)) ));
				l = l.next;
			}
			
			#line 210 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
			return s_b.ToString();
		}
		#line default
		
		public virtual global::haxe.ds.List filter(global::haxe.lang.Function f) {
			#line 218 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
			global::haxe.ds.List l2 = new global::haxe.ds.List();
			global::haxe.ds._List.ListNode l = this.h;
			#line 220 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
			while (( l != null )) {
				#line 221 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
				object v = l.item;
				l = l.next;
				#line 223 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
				if (global::haxe.lang.Runtime.toBool(f.__hx_invoke1_o(default(double), v))) {
					#line 224 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
					l2.@add(v);
				}
				
			}
			
			#line 226 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
			return l2;
		}
		#line default
		
		public virtual global::haxe.ds.List map(global::haxe.lang.Function f) {
			#line 234 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
			global::haxe.ds.List b = new global::haxe.ds.List();
			global::haxe.ds._List.ListNode l = this.h;
			#line 236 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
			while (( l != null )) {
				#line 237 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
				object v = l.item;
				l = l.next;
				#line 239 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
				b.@add(((object) (f.__hx_invoke1_o(default(double), v)) ));
			}
			
			#line 241 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
			return b;
		}
		#line default
		
		public override double __hx_setField_f(string field, int hash, double @value, bool handleProperties) {
			unchecked {
				#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
				switch (hash) {
					case 520590566:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
						this.length = ((int) (@value) );
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
						return @value;
					}
					
					
					default:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
						return base.__hx_setField_f(field, hash, @value, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_setField(string field, int hash, object @value, bool handleProperties) {
			unchecked {
				#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
				switch (hash) {
					case 520590566:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
						this.length = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
						return @value;
					}
					
					
					case 113:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
						this.q = ((global::haxe.ds._List.ListNode) (@value) );
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
						return @value;
					}
					
					
					case 104:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
						this.h = ((global::haxe.ds._List.ListNode) (@value) );
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
						return @value;
					}
					
					
					default:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
						return base.__hx_setField(field, hash, @value, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties) {
			unchecked {
				#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
				switch (hash) {
					case 5442204:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "map", 5442204)) );
					}
					
					
					case 87367608:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "filter", 87367608)) );
					}
					
					
					case 1181037546:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "join", 1181037546)) );
					}
					
					
					case 946786476:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "toString", 946786476)) );
					}
					
					
					case 1257164128:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "keyValueIterator", 1257164128)) );
					}
					
					
					case 328878574:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "iterator", 328878574)) );
					}
					
					
					case 76061764:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "remove", 76061764)) );
					}
					
					
					case 1213952397:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "clear", 1213952397)) );
					}
					
					
					case 207609411:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "isEmpty", 207609411)) );
					}
					
					
					case 5594513:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "pop", 5594513)) );
					}
					
					
					case 1202522710:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "last", 1202522710)) );
					}
					
					
					case 10319920:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "first", 10319920)) );
					}
					
					
					case 1247875546:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "push", 1247875546)) );
					}
					
					
					case 4846113:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "add", 4846113)) );
					}
					
					
					case 520590566:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
						return this.length;
					}
					
					
					case 113:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
						return this.q;
					}
					
					
					case 104:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
						return this.h;
					}
					
					
					default:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override double __hx_getField_f(string field, int hash, bool throwErrors, bool handleProperties) {
			unchecked {
				#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
				switch (hash) {
					case 520590566:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
						return ((double) (this.length) );
					}
					
					
					default:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
						return base.__hx_getField_f(field, hash, throwErrors, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_invokeField(string field, int hash, object[] dynargs) {
			unchecked {
				#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
				switch (hash) {
					case 5442204:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
						return this.map(((global::haxe.lang.Function) (((object) (dynargs[0]) )) ));
					}
					
					
					case 87367608:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
						return this.filter(((global::haxe.lang.Function) (((object) (dynargs[0]) )) ));
					}
					
					
					case 1181037546:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
						return this.@join(global::haxe.lang.Runtime.toString(((object) (dynargs[0]) )));
					}
					
					
					case 946786476:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
						return this.toString();
					}
					
					
					case 1257164128:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
						return this.keyValueIterator();
					}
					
					
					case 328878574:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
						return this.iterator();
					}
					
					
					case 76061764:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
						return this.@remove(((object) (dynargs[0]) ));
					}
					
					
					case 1213952397:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
						this.clear();
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
						break;
					}
					
					
					case 207609411:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
						return this.isEmpty();
					}
					
					
					case 5594513:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
						return this.pop();
					}
					
					
					case 1202522710:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
						return this.last();
					}
					
					
					case 10319920:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
						return this.first();
					}
					
					
					case 1247875546:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
						this.push(((object) (dynargs[0]) ));
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
						break;
					}
					
					
					case 4846113:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
						this.@add(((object) (dynargs[0]) ));
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
						break;
					}
					
					
					default:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
				#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
				return null;
			}
			#line default
		}
		
		
		public override void __hx_getFields(global::haxe.root.Array baseArr) {
			#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
			baseArr.push("length");
			#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
			baseArr.push("q");
			#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
			baseArr.push("h");
			#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
			base.__hx_getFields(baseArr);
		}
		#line default
		
		public override string ToString(){
			return this.toString();
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.ds._List {
	public class ListNode : global::haxe.lang.HxObject {
		
		public ListNode(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public ListNode(object item, global::haxe.ds._List.ListNode next) {
			#line 266 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
			global::haxe.ds._List.ListNode.__hx_ctor_haxe_ds__List_ListNode(((global::haxe.ds._List.ListNode) (this) ), ((object) (item) ), ((global::haxe.ds._List.ListNode) (next) ));
		}
		#line default
		
		protected static void __hx_ctor_haxe_ds__List_ListNode(global::haxe.ds._List.ListNode __hx_this, object item, global::haxe.ds._List.ListNode next) {
			#line 267 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
			__hx_this.item = item;
			__hx_this.next = next;
		}
		#line default
		
		public object item;
		
		public global::haxe.ds._List.ListNode next;
		
		public override double __hx_setField_f(string field, int hash, double @value, bool handleProperties) {
			unchecked {
				#line 262 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
				switch (hash) {
					case 1170195731:
					{
						#line 262 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
						this.item = ((object) (@value) );
						#line 262 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
						return ((double) (global::haxe.lang.Runtime.toDouble(((object) (@value) ))) );
					}
					
					
					default:
					{
						#line 262 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
						return base.__hx_setField_f(field, hash, @value, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_setField(string field, int hash, object @value, bool handleProperties) {
			unchecked {
				#line 262 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
				switch (hash) {
					case 1224901875:
					{
						#line 262 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
						this.next = ((global::haxe.ds._List.ListNode) (@value) );
						#line 262 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
						return @value;
					}
					
					
					case 1170195731:
					{
						#line 262 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
						this.item = ((object) (@value) );
						#line 262 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
						return @value;
					}
					
					
					default:
					{
						#line 262 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
						return base.__hx_setField(field, hash, @value, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties) {
			unchecked {
				#line 262 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
				switch (hash) {
					case 1224901875:
					{
						#line 262 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
						return this.next;
					}
					
					
					case 1170195731:
					{
						#line 262 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
						return this.item;
					}
					
					
					default:
					{
						#line 262 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override double __hx_getField_f(string field, int hash, bool throwErrors, bool handleProperties) {
			unchecked {
				#line 262 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
				switch (hash) {
					case 1170195731:
					{
						#line 262 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
						return ((double) (global::haxe.lang.Runtime.toDouble(((object) (this.item) ))) );
					}
					
					
					default:
					{
						#line 262 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
						return base.__hx_getField_f(field, hash, throwErrors, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override void __hx_getFields(global::haxe.root.Array baseArr) {
			#line 262 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
			baseArr.push("next");
			#line 262 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
			baseArr.push("item");
			#line 262 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
			base.__hx_getFields(baseArr);
		}
		#line default
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.ds._List {
	public class ListIterator : global::haxe.lang.HxObject {
		
		public ListIterator(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public ListIterator(global::haxe.ds._List.ListNode head) {
			#line 280 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
			global::haxe.ds._List.ListIterator.__hx_ctor_haxe_ds__List_ListIterator(((global::haxe.ds._List.ListIterator) (this) ), ((global::haxe.ds._List.ListNode) (head) ));
		}
		#line default
		
		protected static void __hx_ctor_haxe_ds__List_ListIterator(global::haxe.ds._List.ListIterator __hx_this, global::haxe.ds._List.ListNode head) {
			#line 281 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
			__hx_this.head = head;
		}
		#line default
		
		public global::haxe.ds._List.ListNode head;
		
		public bool hasNext() {
			#line 285 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
			return ( this.head != null );
		}
		#line default
		
		public object next() {
			#line 289 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
			object val = this.head.item;
			this.head = this.head.next;
			#line 291 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
			return val;
		}
		#line default
		
		public override object __hx_setField(string field, int hash, object @value, bool handleProperties) {
			unchecked {
				#line 277 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
				switch (hash) {
					case 1158359328:
					{
						#line 277 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
						this.head = ((global::haxe.ds._List.ListNode) (@value) );
						#line 277 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
						return @value;
					}
					
					
					default:
					{
						#line 277 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
						return base.__hx_setField(field, hash, @value, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties) {
			unchecked {
				#line 277 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
				switch (hash) {
					case 1224901875:
					{
						#line 277 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "next", 1224901875)) );
					}
					
					
					case 407283053:
					{
						#line 277 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "hasNext", 407283053)) );
					}
					
					
					case 1158359328:
					{
						#line 277 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
						return this.head;
					}
					
					
					default:
					{
						#line 277 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_invokeField(string field, int hash, object[] dynargs) {
			unchecked {
				#line 277 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
				switch (hash) {
					case 1224901875:
					{
						#line 277 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
						return this.next();
					}
					
					
					case 407283053:
					{
						#line 277 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
						return this.hasNext();
					}
					
					
					default:
					{
						#line 277 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override void __hx_getFields(global::haxe.root.Array baseArr) {
			#line 277 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
			baseArr.push("head");
			#line 277 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
			base.__hx_getFields(baseArr);
		}
		#line default
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.ds._List {
	public class ListKeyValueIterator : global::haxe.lang.HxObject {
		
		public ListKeyValueIterator(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public ListKeyValueIterator(global::haxe.ds._List.ListNode head) {
			#line 299 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
			global::haxe.ds._List.ListKeyValueIterator.__hx_ctor_haxe_ds__List_ListKeyValueIterator(((global::haxe.ds._List.ListKeyValueIterator) (this) ), ((global::haxe.ds._List.ListNode) (head) ));
		}
		#line default
		
		protected static void __hx_ctor_haxe_ds__List_ListKeyValueIterator(global::haxe.ds._List.ListKeyValueIterator __hx_this, global::haxe.ds._List.ListNode head) {
			#line 300 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
			__hx_this.head = head;
			__hx_this.idx = 0;
		}
		#line default
		
		public int idx;
		
		public global::haxe.ds._List.ListNode head;
		
		public bool hasNext() {
			#line 305 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
			return ( this.head != null );
		}
		#line default
		
		public object next() {
			#line 309 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
			object val = this.head.item;
			this.head = this.head.next;
			#line 311 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
			{
				#line 311 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
				int __temp_odecl1 = this.idx++;
				#line 311 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
				return new global::haxe.lang.DynamicObject(new int[]{834174833}, new object[]{val}, new int[]{5343647}, new double[]{((double) (__temp_odecl1) )});
			}
			
		}
		#line default
		
		public override double __hx_setField_f(string field, int hash, double @value, bool handleProperties) {
			unchecked {
				#line 295 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
				switch (hash) {
					case 5243965:
					{
						#line 295 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
						this.idx = ((int) (@value) );
						#line 295 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
						return @value;
					}
					
					
					default:
					{
						#line 295 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
						return base.__hx_setField_f(field, hash, @value, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_setField(string field, int hash, object @value, bool handleProperties) {
			unchecked {
				#line 295 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
				switch (hash) {
					case 1158359328:
					{
						#line 295 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
						this.head = ((global::haxe.ds._List.ListNode) (@value) );
						#line 295 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
						return @value;
					}
					
					
					case 5243965:
					{
						#line 295 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
						this.idx = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						#line 295 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
						return @value;
					}
					
					
					default:
					{
						#line 295 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
						return base.__hx_setField(field, hash, @value, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties) {
			unchecked {
				#line 295 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
				switch (hash) {
					case 1224901875:
					{
						#line 295 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "next", 1224901875)) );
					}
					
					
					case 407283053:
					{
						#line 295 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "hasNext", 407283053)) );
					}
					
					
					case 1158359328:
					{
						#line 295 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
						return this.head;
					}
					
					
					case 5243965:
					{
						#line 295 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
						return this.idx;
					}
					
					
					default:
					{
						#line 295 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override double __hx_getField_f(string field, int hash, bool throwErrors, bool handleProperties) {
			unchecked {
				#line 295 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
				switch (hash) {
					case 5243965:
					{
						#line 295 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
						return ((double) (this.idx) );
					}
					
					
					default:
					{
						#line 295 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
						return base.__hx_getField_f(field, hash, throwErrors, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_invokeField(string field, int hash, object[] dynargs) {
			unchecked {
				#line 295 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
				switch (hash) {
					case 1224901875:
					{
						#line 295 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
						return this.next();
					}
					
					
					case 407283053:
					{
						#line 295 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
						return this.hasNext();
					}
					
					
					default:
					{
						#line 295 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override void __hx_getFields(global::haxe.root.Array baseArr) {
			#line 295 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
			baseArr.push("head");
			#line 295 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
			baseArr.push("idx");
			#line 295 "C:\\HaxeToolkit\\haxe\\std\\haxe\\ds\\List.hx"
			base.__hx_getFields(baseArr);
		}
		#line default
		
	}
}


