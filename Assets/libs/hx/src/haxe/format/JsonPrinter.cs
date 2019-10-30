// Generated by Haxe 4.0.0+ef18b627e
using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.format {
	public class JsonPrinter : global::haxe.lang.HxObject {
		
		public JsonPrinter(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public JsonPrinter(global::haxe.lang.Function replacer, string space) {
			#line 56 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
			global::haxe.format.JsonPrinter.__hx_ctor_haxe_format_JsonPrinter(this, replacer, space);
		}
		#line default
		
		protected static void __hx_ctor_haxe_format_JsonPrinter(global::haxe.format.JsonPrinter __hx_this, global::haxe.lang.Function replacer, string space) {
			#line 57 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
			__hx_this.replacer = replacer;
			__hx_this.indent = space;
			#line 59 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
			__hx_this.pretty = ( space != null );
			__hx_this.nind = 0;
			#line 67 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
			__hx_this.buf = new global::haxe.root.StringBuf();
		}
		#line default
		
		public static string print(object o, global::haxe.lang.Function replacer, string space) {
			#line 45 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
			global::haxe.format.JsonPrinter printer = new global::haxe.format.JsonPrinter(replacer, space);
			printer.write("", o);
			#line 47 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
			return printer.buf.b.ToString();
		}
		#line default
		
		public global::haxe.root.StringBuf buf;
		
		public global::haxe.lang.Function replacer;
		
		public string indent;
		
		public bool pretty;
		
		public int nind;
		
		public void ipad() {
			#line 72 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
			if (this.pretty) {
				#line 73 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
				string v = global::haxe.root.StringTools.lpad("", this.indent, ( this.nind * this.indent.Length ));
				#line 73 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
				this.buf.b.Append(((string) (global::haxe.root.Std.@string(v)) ));
			}
			
		}
		#line default
		
		public void newl() {
			unchecked {
				#line 77 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
				if (this.pretty) {
					#line 78 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
					this.buf.addChar(10);
				}
				
			}
			#line default
		}
		
		
		public virtual void write(object k, object v) {
			unchecked {
				#line 82 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
				if (( this.replacer != null )) {
					#line 83 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
					v = ((object) (this.replacer.__hx_invoke2_o(default(double), k, default(double), v)) );
				}
				
				#line 84 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
				{
					#line 84 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
					global::haxe.root.ValueType _g = global::haxe.root.Type.@typeof(v);
					#line 84 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
					switch (_g._hx_index) {
						case 0:
						{
							#line 136 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
							this.buf.b.Append(((string) ("null") ));
							#line 136 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
							break;
						}
						
						
						case 1:
						{
							#line 90 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
							this.buf.b.Append(((string) (global::haxe.root.Std.@string(global::haxe.lang.Runtime.toString(v))) ));
							#line 90 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
							break;
						}
						
						
						case 2:
						{
							#line 92 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
							double f = ((double) (global::haxe.lang.Runtime.toDouble(v)) );
							#line 92 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
							string v1 = ( ((  ! (global::System.Double.IsInfinity(((double) (f) )))  &&  ! (global::System.Double.IsNaN(((double) (f) )))  )) ? (global::haxe.root.Std.@string(v)) : ("null") );
							#line 92 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
							this.buf.b.Append(((string) (global::haxe.root.Std.@string(v1)) ));
							#line 92 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
							break;
						}
						
						
						case 3:
						{
							#line 134 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
							this.buf.b.Append(((string) (global::haxe.root.Std.@string(global::haxe.lang.Runtime.toString(v))) ));
							#line 134 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
							break;
						}
						
						
						case 4:
						{
							#line 88 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
							this.fieldsString(v, global::haxe.root.Reflect.fields(v));
							#line 88 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
							break;
						}
						
						
						case 5:
						{
							#line 94 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
							this.buf.b.Append(((string) ("\"<fun>\"") ));
							#line 94 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
							break;
						}
						
						
						case 6:
						{
							#line 95 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
							global::System.Type c = ( _g as global::haxe.root.ValueType_TClass ).c;
							if (global::haxe.lang.Runtime.refEq(c, typeof(string))) {
								#line 97 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
								this.quote(global::haxe.lang.Runtime.toString(v));
							}
							else if (global::haxe.lang.Runtime.refEq(c, typeof(global::haxe.root.Array))) {
								#line 99 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
								global::haxe.root.Array v2 = ((global::haxe.root.Array) (v) );
								this.buf.addChar(91);
								#line 102 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
								int len = v2.length;
								int last = ( len - 1 );
								#line 104 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
								{
									#line 104 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
									int _g1 = 0;
									#line 104 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
									int _g11 = len;
									#line 104 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
									while (( _g1 < _g11 )) {
										#line 104 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
										int i = _g1++;
										if (( i > 0 )) {
											#line 106 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
											this.buf.addChar(44);
										}
										else {
											#line 108 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
											this.nind++;
										}
										
										#line 109 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
										if (this.pretty) {
											#line 109 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
											this.buf.addChar(10);
										}
										
										#line 110 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
										if (this.pretty) {
											#line 110 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
											string v3 = global::haxe.root.StringTools.lpad("", this.indent, ( this.nind * this.indent.Length ));
											#line 110 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
											this.buf.b.Append(((string) (global::haxe.root.Std.@string(v3)) ));
										}
										
										#line 111 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
										this.write(i, v2.__get(i));
										if (( i == last )) {
											#line 113 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
											this.nind--;
											if (this.pretty) {
												#line 114 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
												this.buf.addChar(10);
											}
											
											#line 115 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
											if (this.pretty) {
												#line 115 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
												string v4 = global::haxe.root.StringTools.lpad("", this.indent, ( this.nind * this.indent.Length ));
												#line 115 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
												this.buf.b.Append(((string) (global::haxe.root.Std.@string(v4)) ));
											}
											
										}
										
									}
									
								}
								
								#line 118 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
								this.buf.addChar(93);
							}
							else if (global::haxe.lang.Runtime.refEq(c, typeof(global::haxe.ds.StringMap))) {
								#line 120 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
								global::haxe.ds.StringMap v5 = ((global::haxe.ds.StringMap) (v) );
								object o = new global::haxe.lang.DynamicObject(new int[]{}, new object[]{}, new int[]{}, new double[]{});
								#line 122 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
								{
									#line 122 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
									object k1 = ((object) (new global::haxe.ds._StringMap.StringMapKeyIterator(((global::haxe.ds.StringMap) (v5) ))) );
									#line 122 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
									while (global::haxe.lang.Runtime.toBool(global::haxe.lang.Runtime.callField(k1, "hasNext", 407283053, null))) {
										#line 122 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
										string k2 = global::haxe.lang.Runtime.toString(global::haxe.lang.Runtime.callField(k1, "next", 1224901875, null));
										global::haxe.root.Reflect.setField(o, k2, v5.@get(((string) (k2) )));
									}
									
								}
								
								#line 124 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
								{
									#line 124 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
									object v6 = ((object) (o) );
									#line 124 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
									this.fieldsString(v6, global::haxe.root.Reflect.fields(v6));
								}
								
							}
							else if (global::haxe.lang.Runtime.refEq(c, typeof(global::haxe.root.Date))) {
								#line 126 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
								global::haxe.root.Date v7 = ((global::haxe.root.Date) (v) );
								this.quote(v7.toString());
							}
							else {
								#line 129 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
								this.classString(v);
							}
							
							#line 95 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
							break;
						}
						
						
						case 7:
						{
							#line 130 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
							global::System.Type _g12 = ( _g as global::haxe.root.ValueType_TEnum ).e;
							#line 130 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
							{
								#line 131 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
								object i1 = global::haxe.root.Type.enumIndex(v);
								this.buf.b.Append(((string) (global::haxe.root.Std.@string(global::haxe.lang.Runtime.toString(i1))) ));
							}
							
							#line 130 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
							break;
						}
						
						
						case 8:
						{
							#line 86 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
							this.buf.b.Append(((string) ("\"???\"") ));
							#line 86 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
							break;
						}
						
						
					}
					
				}
				
			}
			#line default
		}
		
		
		public virtual void classString(object v) {
			#line 158 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
			this.fieldsString(v, global::haxe.root.Type.getInstanceFields(global::haxe.root.Type.getClass(((object) (v) ))));
		}
		#line default
		
		public void objString(object v) {
			#line 162 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
			this.fieldsString(v, global::haxe.root.Reflect.fields(v));
		}
		#line default
		
		public virtual void fieldsString(object v, global::haxe.root.Array fields) {
			unchecked {
				#line 166 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
				this.buf.addChar(123);
				int len = fields.length;
				#line 168 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
				int last = ( len - 1 );
				bool first = true;
				#line 170 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
				{
					#line 170 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
					int _g = 0;
					#line 170 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
					int _g1 = len;
					#line 170 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
					while (( _g < _g1 )) {
						#line 170 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
						int i = _g++;
						string f = global::haxe.lang.Runtime.toString(fields.__get(i));
						#line 172 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
						object @value = global::haxe.root.Reflect.field(v, f);
						if (( ((object) (@value) ) is global::haxe.lang.Function )) {
							#line 174 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
							continue;
						}
						
						#line 175 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
						if (first) {
							#line 176 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
							this.nind++;
							first = false;
						}
						else {
							#line 179 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
							this.buf.addChar(44);
						}
						
						#line 180 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
						if (this.pretty) {
							#line 180 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
							this.buf.addChar(10);
						}
						
						#line 181 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
						if (this.pretty) {
							#line 181 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
							string v1 = global::haxe.root.StringTools.lpad("", this.indent, ( this.nind * this.indent.Length ));
							#line 181 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
							this.buf.b.Append(((string) (global::haxe.root.Std.@string(v1)) ));
						}
						
						#line 182 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
						this.quote(f);
						this.buf.addChar(58);
						#line 184 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
						if (this.pretty) {
							#line 185 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
							this.buf.addChar(32);
						}
						
						#line 186 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
						this.write(f, @value);
						if (( i == last )) {
							#line 188 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
							this.nind--;
							if (this.pretty) {
								#line 189 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
								this.buf.addChar(10);
							}
							
							#line 190 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
							if (this.pretty) {
								#line 190 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
								string v2 = global::haxe.root.StringTools.lpad("", this.indent, ( this.nind * this.indent.Length ));
								#line 190 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
								this.buf.b.Append(((string) (global::haxe.root.Std.@string(v2)) ));
							}
							
						}
						
					}
					
				}
				
				#line 193 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
				this.buf.addChar(125);
			}
			#line default
		}
		
		
		public virtual void quote(string s) {
			unchecked {
				#line 203 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
				this.buf.addChar(34);
				int i = 0;
				#line 208 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
				while (true) {
					#line 209 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
					int index = i++;
					#line 209 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
					int c = ( (((bool) (( ((uint) (index) ) < s.Length )) )) ? (((int) (s[index]) )) : (-1) );
					if (( c == -1 )) {
						#line 211 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
						break;
					}
					
					#line 212 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
					switch (c) {
						case 8:
						{
							#line 224 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
							this.buf.b.Append(((string) ("\\b") ));
							#line 224 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
							break;
						}
						
						
						case 9:
						{
							#line 222 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
							this.buf.b.Append(((string) ("\\t") ));
							#line 222 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
							break;
						}
						
						
						case 10:
						{
							#line 218 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
							this.buf.b.Append(((string) ("\\n") ));
							#line 218 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
							break;
						}
						
						
						case 12:
						{
							#line 226 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
							this.buf.b.Append(((string) ("\\f") ));
							#line 226 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
							break;
						}
						
						
						case 13:
						{
							#line 220 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
							this.buf.b.Append(((string) ("\\r") ));
							#line 220 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
							break;
						}
						
						
						case 34:
						{
							#line 214 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
							this.buf.b.Append(((string) ("\\\"") ));
							#line 214 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
							break;
						}
						
						
						case 92:
						{
							#line 216 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
							this.buf.b.Append(((string) ("\\\\") ));
							#line 216 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
							break;
						}
						
						
						default:
						{
							#line 249 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
							this.buf.addChar(c);
							#line 249 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
							break;
						}
						
					}
					
				}
				
				#line 257 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
				this.buf.addChar(34);
			}
			#line default
		}
		
		
		public override double __hx_setField_f(string field, int hash, double @value, bool handleProperties) {
			unchecked {
				#line 33 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
				switch (hash) {
					case 1225098545:
					{
						#line 33 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
						this.nind = ((int) (@value) );
						#line 33 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
						return @value;
					}
					
					
					default:
					{
						#line 33 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
						return base.__hx_setField_f(field, hash, @value, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_setField(string field, int hash, object @value, bool handleProperties) {
			unchecked {
				#line 33 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
				switch (hash) {
					case 1225098545:
					{
						#line 33 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
						this.nind = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						#line 33 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
						return @value;
					}
					
					
					case 784433846:
					{
						#line 33 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
						this.pretty = global::haxe.lang.Runtime.toBool(@value);
						#line 33 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
						return @value;
					}
					
					
					case 334695532:
					{
						#line 33 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
						this.indent = global::haxe.lang.Runtime.toString(@value);
						#line 33 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
						return @value;
					}
					
					
					case 404153790:
					{
						#line 33 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
						this.replacer = ((global::haxe.lang.Function) (@value) );
						#line 33 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
						return @value;
					}
					
					
					case 4899635:
					{
						#line 33 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
						this.buf = ((global::haxe.root.StringBuf) (@value) );
						#line 33 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
						return @value;
					}
					
					
					default:
					{
						#line 33 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
						return base.__hx_setField(field, hash, @value, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties) {
			unchecked {
				#line 33 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
				switch (hash) {
					case 1576149820:
					{
						#line 33 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "quote", 1576149820)) );
					}
					
					
					case 878103594:
					{
						#line 33 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "fieldsString", 878103594)) );
					}
					
					
					case 1503920168:
					{
						#line 33 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "objString", 1503920168)) );
					}
					
					
					case 142151465:
					{
						#line 33 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "classString", 142151465)) );
					}
					
					
					case 1348037855:
					{
						#line 33 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "write", 1348037855)) );
					}
					
					
					case 1224901644:
					{
						#line 33 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "newl", 1224901644)) );
					}
					
					
					case 1169995914:
					{
						#line 33 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "ipad", 1169995914)) );
					}
					
					
					case 1225098545:
					{
						#line 33 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
						return this.nind;
					}
					
					
					case 784433846:
					{
						#line 33 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
						return this.pretty;
					}
					
					
					case 334695532:
					{
						#line 33 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
						return this.indent;
					}
					
					
					case 404153790:
					{
						#line 33 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
						return this.replacer;
					}
					
					
					case 4899635:
					{
						#line 33 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
						return this.buf;
					}
					
					
					default:
					{
						#line 33 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override double __hx_getField_f(string field, int hash, bool throwErrors, bool handleProperties) {
			unchecked {
				#line 33 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
				switch (hash) {
					case 1225098545:
					{
						#line 33 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
						return ((double) (this.nind) );
					}
					
					
					default:
					{
						#line 33 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
						return base.__hx_getField_f(field, hash, throwErrors, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_invokeField(string field, int hash, object[] dynargs) {
			unchecked {
				#line 33 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
				switch (hash) {
					case 1576149820:
					{
						#line 33 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
						this.quote(global::haxe.lang.Runtime.toString(((object) (dynargs[0]) )));
						#line 33 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
						break;
					}
					
					
					case 878103594:
					{
						#line 33 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
						this.fieldsString(((object) (dynargs[0]) ), ((global::haxe.root.Array) (((object) (dynargs[1]) )) ));
						#line 33 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
						break;
					}
					
					
					case 1503920168:
					{
						#line 33 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
						this.objString(((object) (dynargs[0]) ));
						#line 33 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
						break;
					}
					
					
					case 142151465:
					{
						#line 33 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
						this.classString(((object) (dynargs[0]) ));
						#line 33 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
						break;
					}
					
					
					case 1348037855:
					{
						#line 33 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
						this.write(((object) (dynargs[0]) ), ((object) (dynargs[1]) ));
						#line 33 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
						break;
					}
					
					
					case 1224901644:
					{
						#line 33 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
						this.newl();
						#line 33 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
						break;
					}
					
					
					case 1169995914:
					{
						#line 33 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
						this.ipad();
						#line 33 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
						break;
					}
					
					
					default:
					{
						#line 33 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
				#line 33 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
				return null;
			}
			#line default
		}
		
		
		public override void __hx_getFields(global::haxe.root.Array baseArr) {
			#line 33 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
			baseArr.push("nind");
			#line 33 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
			baseArr.push("pretty");
			#line 33 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
			baseArr.push("indent");
			#line 33 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
			baseArr.push("replacer");
			#line 33 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
			baseArr.push("buf");
			#line 33 "C:\\HaxeToolkit\\haxe\\std\\haxe\\format\\JsonPrinter.hx"
			base.__hx_getFields(baseArr);
		}
		#line default
		
	}
}


