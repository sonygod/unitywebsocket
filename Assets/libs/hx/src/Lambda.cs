// Generated by Haxe 4.0.0+ef18b627e
using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.root {
	public class Lambda : global::haxe.lang.HxObject {
		
		public Lambda(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public Lambda() {
			#line 39 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
			global::haxe.root.Lambda.__hx_ctor__Lambda(this);
		}
		#line default
		
		protected static void __hx_ctor__Lambda(global::haxe.root.Lambda __hx_this) {
		}
		
		
		public static global::haxe.root.Array array(object it) {
			#line 46 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
			global::haxe.root.Array a = new global::haxe.root.Array();
			{
				#line 47 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
				object i = ((object) (global::haxe.lang.Runtime.callField(it, "iterator", 328878574, null)) );
				#line 47 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
				while (global::haxe.lang.Runtime.toBool(global::haxe.lang.Runtime.callField(i, "hasNext", 407283053, null))) {
					#line 47 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
					object i1 = ((object) (global::haxe.lang.Runtime.callField(i, "next", 1224901875, null)) );
					a.push(i1);
				}
				
			}
			
			#line 49 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
			return a;
		}
		#line default
		
		public static global::haxe.ds.List list(object it) {
			#line 58 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
			global::haxe.ds.List l = new global::haxe.ds.List();
			{
				#line 59 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
				object i = ((object) (global::haxe.lang.Runtime.callField(it, "iterator", 328878574, null)) );
				#line 59 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
				while (global::haxe.lang.Runtime.toBool(global::haxe.lang.Runtime.callField(i, "hasNext", 407283053, null))) {
					#line 59 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
					object i1 = ((object) (global::haxe.lang.Runtime.callField(i, "next", 1224901875, null)) );
					l.@add(i1);
				}
				
			}
			
			#line 61 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
			return l;
		}
		#line default
		
		public static global::haxe.root.Array map(object it, global::haxe.lang.Function f) {
			#line 70 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
			global::haxe.root.Array _g = new global::haxe.root.Array(new object[]{});
			#line 70 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
			{
				#line 70 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
				object x = ((object) (global::haxe.lang.Runtime.callField(it, "iterator", 328878574, null)) );
				#line 70 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
				while (global::haxe.lang.Runtime.toBool(global::haxe.lang.Runtime.callField(x, "hasNext", 407283053, null))) {
					#line 70 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
					object x1 = ((object) (global::haxe.lang.Runtime.callField(x, "next", 1224901875, null)) );
					#line 70 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
					_g.push(((object) (f.__hx_invoke1_o(default(double), x1)) ));
				}
				
			}
			
			#line 70 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
			return _g;
		}
		#line default
		
		public static global::haxe.root.Array mapi(object it, global::haxe.lang.Function f) {
			#line 79 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
			int i = 0;
			global::haxe.root.Array _g = new global::haxe.root.Array(new object[]{});
			{
				#line 80 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
				object x = ((object) (global::haxe.lang.Runtime.callField(it, "iterator", 328878574, null)) );
				#line 80 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
				while (global::haxe.lang.Runtime.toBool(global::haxe.lang.Runtime.callField(x, "hasNext", 407283053, null))) {
					#line 80 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
					object x1 = ((object) (global::haxe.lang.Runtime.callField(x, "next", 1224901875, null)) );
					#line 80 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
					_g.push(((object) (f.__hx_invoke2_o(((double) (i++) ), global::haxe.lang.Runtime.undefined, default(double), x1)) ));
				}
				
			}
			
			#line 80 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
			return _g;
		}
		#line default
		
		public static global::haxe.root.Array flatten(object it) {
			#line 88 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
			global::haxe.root.Array _g = new global::haxe.root.Array(new object[]{});
			#line 88 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
			{
				#line 88 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
				object e = ((object) (global::haxe.lang.Runtime.callField(it, "iterator", 328878574, null)) );
				#line 88 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
				while (global::haxe.lang.Runtime.toBool(global::haxe.lang.Runtime.callField(e, "hasNext", 407283053, null))) {
					#line 88 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
					object e1 = ((object) (global::haxe.lang.Runtime.callField(e, "next", 1224901875, null)) );
					#line 88 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
					{
						#line 88 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
						object x = ((object) (global::haxe.lang.Runtime.callField(e1, "iterator", 328878574, null)) );
						#line 88 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
						while (global::haxe.lang.Runtime.toBool(global::haxe.lang.Runtime.callField(x, "hasNext", 407283053, null))) {
							#line 88 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
							object x1 = ((object) (global::haxe.lang.Runtime.callField(x, "next", 1224901875, null)) );
							#line 88 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
							_g.push(x1);
						}
						
					}
					
				}
				
			}
			
			#line 88 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
			return _g;
		}
		#line default
		
		public static global::haxe.root.Array flatMap(object it, global::haxe.lang.Function f) {
			#line 97 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
			global::haxe.root.Array _g = new global::haxe.root.Array(new object[]{});
			#line 97 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
			{
				#line 97 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
				object x = ((object) (global::haxe.lang.Runtime.callField(it, "iterator", 328878574, null)) );
				#line 97 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
				while (global::haxe.lang.Runtime.toBool(global::haxe.lang.Runtime.callField(x, "hasNext", 407283053, null))) {
					#line 97 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
					object x1 = ((object) (global::haxe.lang.Runtime.callField(x, "next", 1224901875, null)) );
					#line 97 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
					_g.push(((object) (f.__hx_invoke1_o(default(double), x1)) ));
				}
				
			}
			
			#line 97 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
			global::haxe.root.Array _g1 = new global::haxe.root.Array(new object[]{});
			#line 97 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
			{
				#line 97 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
				object e = ((object) (global::haxe.lang.Runtime.callField(((object) (_g) ), "iterator", 328878574, null)) );
				#line 97 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
				while (global::haxe.lang.Runtime.toBool(global::haxe.lang.Runtime.callField(e, "hasNext", 407283053, null))) {
					#line 97 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
					object e1 = ((object) (global::haxe.lang.Runtime.callField(e, "next", 1224901875, null)) );
					#line 97 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
					{
						#line 97 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
						object x2 = ((object) (global::haxe.lang.Runtime.callField(e1, "iterator", 328878574, null)) );
						#line 97 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
						while (global::haxe.lang.Runtime.toBool(global::haxe.lang.Runtime.callField(x2, "hasNext", 407283053, null))) {
							#line 97 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
							object x3 = ((object) (global::haxe.lang.Runtime.callField(x2, "next", 1224901875, null)) );
							#line 97 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
							_g1.push(x3);
						}
						
					}
					
				}
				
			}
			
			#line 97 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
			return _g1;
		}
		#line default
		
		public static bool has(object it, object elt) {
			#line 109 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
			{
				#line 109 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
				object x = ((object) (global::haxe.lang.Runtime.callField(it, "iterator", 328878574, null)) );
				#line 109 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
				while (global::haxe.lang.Runtime.toBool(global::haxe.lang.Runtime.callField(x, "hasNext", 407283053, null))) {
					#line 109 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
					object x1 = ((object) (global::haxe.lang.Runtime.callField(x, "next", 1224901875, null)) );
					if (global::haxe.lang.Runtime.eq(x1, elt)) {
						#line 111 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
						return true;
					}
					
				}
				
			}
			
			#line 112 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
			return false;
		}
		#line default
		
		public static bool exists(object it, global::haxe.lang.Function f) {
			#line 126 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
			{
				#line 126 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
				object x = ((object) (global::haxe.lang.Runtime.callField(it, "iterator", 328878574, null)) );
				#line 126 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
				while (global::haxe.lang.Runtime.toBool(global::haxe.lang.Runtime.callField(x, "hasNext", 407283053, null))) {
					#line 126 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
					object x1 = ((object) (global::haxe.lang.Runtime.callField(x, "next", 1224901875, null)) );
					if (global::haxe.lang.Runtime.toBool(f.__hx_invoke1_o(default(double), x1))) {
						#line 128 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
						return true;
					}
					
				}
				
			}
			
			#line 129 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
			return false;
		}
		#line default
		
		public static bool @foreach(object it, global::haxe.lang.Function f) {
			#line 145 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
			{
				#line 145 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
				object x = ((object) (global::haxe.lang.Runtime.callField(it, "iterator", 328878574, null)) );
				#line 145 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
				while (global::haxe.lang.Runtime.toBool(global::haxe.lang.Runtime.callField(x, "hasNext", 407283053, null))) {
					#line 145 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
					object x1 = ((object) (global::haxe.lang.Runtime.callField(x, "next", 1224901875, null)) );
					if ( ! (global::haxe.lang.Runtime.toBool(f.__hx_invoke1_o(default(double), x1))) ) {
						#line 147 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
						return false;
					}
					
				}
				
			}
			
			#line 148 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
			return true;
		}
		#line default
		
		public static void iter(object it, global::haxe.lang.Function f) {
			#line 157 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
			object x = ((object) (global::haxe.lang.Runtime.callField(it, "iterator", 328878574, null)) );
			#line 157 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
			while (global::haxe.lang.Runtime.toBool(global::haxe.lang.Runtime.callField(x, "hasNext", 407283053, null))) {
				#line 157 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
				object x1 = ((object) (global::haxe.lang.Runtime.callField(x, "next", 1224901875, null)) );
				f.__hx_invoke1_o(default(double), x1);
			}
			
		}
		#line default
		
		public static global::haxe.root.Array filter(object it, global::haxe.lang.Function f) {
			#line 168 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
			global::haxe.root.Array _g = new global::haxe.root.Array(new object[]{});
			#line 168 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
			{
				#line 168 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
				object x = ((object) (global::haxe.lang.Runtime.callField(it, "iterator", 328878574, null)) );
				#line 168 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
				while (global::haxe.lang.Runtime.toBool(global::haxe.lang.Runtime.callField(x, "hasNext", 407283053, null))) {
					#line 168 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
					object x1 = ((object) (global::haxe.lang.Runtime.callField(x, "next", 1224901875, null)) );
					#line 168 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
					if (global::haxe.lang.Runtime.toBool(f.__hx_invoke1_o(default(double), x1))) {
						#line 168 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
						_g.push(x1);
					}
					
				}
				
			}
			
			#line 168 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
			return _g;
		}
		#line default
		
		public static object fold(object it, global::haxe.lang.Function f, object first) {
			#line 184 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
			{
				#line 184 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
				object x = ((object) (global::haxe.lang.Runtime.callField(it, "iterator", 328878574, null)) );
				#line 184 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
				while (global::haxe.lang.Runtime.toBool(global::haxe.lang.Runtime.callField(x, "hasNext", 407283053, null))) {
					#line 184 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
					object x1 = ((object) (global::haxe.lang.Runtime.callField(x, "next", 1224901875, null)) );
					first = ((object) (f.__hx_invoke2_o(default(double), x1, default(double), first)) );
				}
				
			}
			
			#line 186 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
			return first;
		}
		#line default
		
		public static int count(object it, global::haxe.lang.Function pred) {
			#line 196 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
			int n = 0;
			if (( pred == null )) {
				#line 198 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
				object _ = ((object) (global::haxe.lang.Runtime.callField(it, "iterator", 328878574, null)) );
				#line 198 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
				while (global::haxe.lang.Runtime.toBool(global::haxe.lang.Runtime.callField(_, "hasNext", 407283053, null))) {
					#line 198 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
					object _1 = ((object) (global::haxe.lang.Runtime.callField(_, "next", 1224901875, null)) );
					 ++ n;
				}
				
			}
			else {
				#line 201 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
				object x = ((object) (global::haxe.lang.Runtime.callField(it, "iterator", 328878574, null)) );
				#line 201 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
				while (global::haxe.lang.Runtime.toBool(global::haxe.lang.Runtime.callField(x, "hasNext", 407283053, null))) {
					#line 201 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
					object x1 = ((object) (global::haxe.lang.Runtime.callField(x, "next", 1224901875, null)) );
					if (global::haxe.lang.Runtime.toBool(((global::haxe.lang.Function) (pred) ).__hx_invoke1_o(default(double), x1))) {
						#line 203 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
						 ++ n;
					}
					
				}
				
			}
			
			#line 204 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
			return n;
		}
		#line default
		
		public static bool empty(object it) {
			#line 211 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
			return  ! (global::haxe.lang.Runtime.toBool(global::haxe.lang.Runtime.callField(((object) (global::haxe.lang.Runtime.callField(it, "iterator", 328878574, null)) ), "hasNext", 407283053, null))) ;
		}
		#line default
		
		public static int indexOf(object it, object v) {
			unchecked {
				#line 222 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
				int i = 0;
				{
					#line 223 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
					object v2 = ((object) (global::haxe.lang.Runtime.callField(it, "iterator", 328878574, null)) );
					#line 223 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
					while (global::haxe.lang.Runtime.toBool(global::haxe.lang.Runtime.callField(v2, "hasNext", 407283053, null))) {
						#line 223 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
						object v21 = ((object) (global::haxe.lang.Runtime.callField(v2, "next", 1224901875, null)) );
						if (global::haxe.lang.Runtime.eq(v, v21)) {
							#line 225 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
							return i;
						}
						
						#line 226 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
						 ++ i;
					}
					
				}
				
				#line 228 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
				return -1;
			}
			#line default
		}
		
		
		public static object find(object it, global::haxe.lang.Function f) {
			#line 242 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
			{
				#line 242 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
				object v = ((object) (global::haxe.lang.Runtime.callField(it, "iterator", 328878574, null)) );
				#line 242 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
				while (global::haxe.lang.Runtime.toBool(global::haxe.lang.Runtime.callField(v, "hasNext", 407283053, null))) {
					#line 242 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
					object v1 = ((object) (global::haxe.lang.Runtime.callField(v, "next", 1224901875, null)) );
					if (global::haxe.lang.Runtime.toBool(f.__hx_invoke1_o(default(double), v1))) {
						#line 244 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
						return v1;
					}
					
				}
				
			}
			
			#line 246 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
			return null;
		}
		#line default
		
		public static global::haxe.root.Array concat(object a, object b) {
			#line 256 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
			global::haxe.root.Array l = new global::haxe.root.Array();
			{
				#line 257 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
				object x = ((object) (global::haxe.lang.Runtime.callField(a, "iterator", 328878574, null)) );
				#line 257 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
				while (global::haxe.lang.Runtime.toBool(global::haxe.lang.Runtime.callField(x, "hasNext", 407283053, null))) {
					#line 257 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
					object x1 = ((object) (global::haxe.lang.Runtime.callField(x, "next", 1224901875, null)) );
					l.push(x1);
				}
				
			}
			
			#line 259 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
			{
				#line 259 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
				object x2 = ((object) (global::haxe.lang.Runtime.callField(b, "iterator", 328878574, null)) );
				#line 259 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
				while (global::haxe.lang.Runtime.toBool(global::haxe.lang.Runtime.callField(x2, "hasNext", 407283053, null))) {
					#line 259 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
					object x3 = ((object) (global::haxe.lang.Runtime.callField(x2, "next", 1224901875, null)) );
					l.push(x3);
				}
				
			}
			
			#line 261 "C:\\HaxeToolkit\\haxe\\std\\Lambda.hx"
			return l;
		}
		#line default
		
	}
}


