// Generated by Haxe 4.1.0-rc.1+cd0f0219b

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.zip {
	public class Huffman : global::haxe.lang.Enum {
		
		protected Huffman(int index) : base(index) {
		}
		
		
		public static global::haxe.zip.Huffman Found(int i) {
			#line 26 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
			return new global::haxe.zip.Huffman_Found(i);
		}
		#line default
		
		public static global::haxe.zip.Huffman NeedBit(global::haxe.zip.Huffman left, global::haxe.zip.Huffman right) {
			#line 27 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
			return new global::haxe.zip.Huffman_NeedBit(left, right);
		}
		#line default
		
		public static global::haxe.zip.Huffman NeedBits(int n, global::haxe.root.Array table) {
			#line 28 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
			return new global::haxe.zip.Huffman_NeedBits(n, table);
		}
		#line default
		
		protected static readonly string[] __hx_constructs = new string[]{"Found", "NeedBit", "NeedBits"};
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.zip {
	public sealed class Huffman_Found : global::haxe.zip.Huffman {
		
		public Huffman_Found(int i) : base(0) {
			#line 26 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
			this.i = i;
		}
		#line default
		
		public override global::haxe.root.Array getParams() {
			#line 26 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
			return new global::haxe.root.Array(new object[]{this.i});
		}
		#line default
		
		public override string getTag() {
			#line 26 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
			return "Found";
		}
		#line default
		
		public override int GetHashCode() {
			#line 26 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
			return global::haxe.lang.Enum.paramsGetHashCode(0, new object[]{this.i});
		}
		#line default
		
		public override bool Equals(object other) {
			#line 26 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
			if (global::System.Object.ReferenceEquals(((object) (this) ), ((object) (other) ))) {
				#line 26 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
				return true;
			}
			
			#line 26 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
			global::haxe.zip.Huffman_Found en = ( other as global::haxe.zip.Huffman_Found );
			#line 26 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
			if (( en == null )) {
				#line 26 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
				return false;
			}
			
			#line 26 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
			if ( ! (global::haxe.root.Type.enumEq(((object) (this.i) ), ((object) (en.i) ))) ) {
				#line 26 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
				return false;
			}
			
			#line 26 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
			return true;
		}
		#line default
		
		public override string toString() {
			#line 26 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
			return global::haxe.lang.Enum.paramsToString("Found", new object[]{this.i});
		}
		#line default
		
		public readonly int i;
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.zip {
	public sealed class Huffman_NeedBit : global::haxe.zip.Huffman {
		
		public Huffman_NeedBit(global::haxe.zip.Huffman left, global::haxe.zip.Huffman right) : base(1) {
			#line 27 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
			this.left = left;
			#line 27 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
			this.right = right;
		}
		#line default
		
		public override global::haxe.root.Array getParams() {
			#line 27 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
			return new global::haxe.root.Array(new object[]{this.left, this.right});
		}
		#line default
		
		public override string getTag() {
			#line 27 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
			return "NeedBit";
		}
		#line default
		
		public override int GetHashCode() {
			unchecked {
				#line 27 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
				return global::haxe.lang.Enum.paramsGetHashCode(1, new object[]{this.left, this.right});
			}
			#line default
		}
		
		
		public override bool Equals(object other) {
			#line 27 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
			if (global::System.Object.ReferenceEquals(((object) (this) ), ((object) (other) ))) {
				#line 27 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
				return true;
			}
			
			#line 27 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
			global::haxe.zip.Huffman_NeedBit en = ( other as global::haxe.zip.Huffman_NeedBit );
			#line 27 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
			if (( en == null )) {
				#line 27 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
				return false;
			}
			
			#line 27 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
			if ( ! (global::haxe.root.Type.enumEq(((object) (this.left) ), ((object) (en.left) ))) ) {
				#line 27 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
				return false;
			}
			
			#line 27 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
			if ( ! (global::haxe.root.Type.enumEq(((object) (this.right) ), ((object) (en.right) ))) ) {
				#line 27 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
				return false;
			}
			
			#line 27 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
			return true;
		}
		#line default
		
		public override string toString() {
			#line 27 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
			return global::haxe.lang.Enum.paramsToString("NeedBit", new object[]{this.left, this.right});
		}
		#line default
		
		public readonly global::haxe.zip.Huffman left;
		
		public readonly global::haxe.zip.Huffman right;
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.zip {
	public sealed class Huffman_NeedBits : global::haxe.zip.Huffman {
		
		public Huffman_NeedBits(int n, global::haxe.root.Array table) : base(2) {
			#line 28 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
			this.n = n;
			#line 28 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
			this.table = table;
		}
		#line default
		
		public override global::haxe.root.Array getParams() {
			#line 28 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
			return new global::haxe.root.Array(new object[]{this.n, this.table});
		}
		#line default
		
		public override string getTag() {
			#line 28 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
			return "NeedBits";
		}
		#line default
		
		public override int GetHashCode() {
			unchecked {
				#line 28 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
				return global::haxe.lang.Enum.paramsGetHashCode(2, new object[]{this.n, this.table});
			}
			#line default
		}
		
		
		public override bool Equals(object other) {
			#line 28 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
			if (global::System.Object.ReferenceEquals(((object) (this) ), ((object) (other) ))) {
				#line 28 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
				return true;
			}
			
			#line 28 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
			global::haxe.zip.Huffman_NeedBits en = ( other as global::haxe.zip.Huffman_NeedBits );
			#line 28 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
			if (( en == null )) {
				#line 28 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
				return false;
			}
			
			#line 28 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
			if ( ! (global::haxe.root.Type.enumEq(((object) (this.n) ), ((object) (en.n) ))) ) {
				#line 28 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
				return false;
			}
			
			#line 28 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
			if ( ! (global::haxe.root.Type.enumEq(((object) (this.table) ), ((object) (en.table) ))) ) {
				#line 28 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
				return false;
			}
			
			#line 28 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
			return true;
		}
		#line default
		
		public override string toString() {
			#line 28 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
			return global::haxe.lang.Enum.paramsToString("NeedBits", new object[]{this.n, this.table});
		}
		#line default
		
		public readonly int n;
		
		public readonly global::haxe.root.Array table;
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.zip {
	public class HuffTools : global::haxe.lang.HxObject {
		
		public HuffTools(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public HuffTools() {
			#line 32 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
			global::haxe.zip.HuffTools.__hx_ctor_haxe_zip_HuffTools(this);
		}
		#line default
		
		protected static void __hx_ctor_haxe_zip_HuffTools(global::haxe.zip.HuffTools __hx_this) {
		}
		
		
		public virtual int treeDepth(global::haxe.zip.Huffman t) {
			unchecked {
				#line 35 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
				switch (t._hx_index) {
					case 0:
					{
						#line 36 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
						int _g = ( t as global::haxe.zip.Huffman_Found ).i;
						#line 36 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
						return 0;
					}
					
					
					case 1:
					{
						#line 38 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
						global::haxe.zip.Huffman b = ( t as global::haxe.zip.Huffman_NeedBit ).right;
						#line 38 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
						global::haxe.zip.Huffman a = ( t as global::haxe.zip.Huffman_NeedBit ).left;
						int da = this.treeDepth(a);
						#line 40 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
						int db = this.treeDepth(b);
						return ( 1 + (( (( da < db )) ? (da) : (db) )) );
					}
					
					
					case 2:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
						global::haxe.root.Array _g2 = ( t as global::haxe.zip.Huffman_NeedBits ).table;
						#line 37 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
						int _g1 = ( t as global::haxe.zip.Huffman_NeedBits ).n;
						#line 37 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
						throw global::haxe.lang.HaxeException.wrap("assert");
					}
					
					
				}
				
				#line 34 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
				return default(int);
			}
			#line default
		}
		
		
		public virtual global::haxe.zip.Huffman treeCompress(global::haxe.zip.Huffman t) {
			unchecked {
				#line 46 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
				int d = this.treeDepth(t);
				if (( d == 0 )) {
					#line 48 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
					return t;
				}
				
				#line 49 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
				if (( d == 1 )) {
					#line 50 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
					if (( t._hx_index == 1 )) {
						#line 51 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
						global::haxe.zip.Huffman b = ( t as global::haxe.zip.Huffman_NeedBit ).right;
						#line 51 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
						global::haxe.zip.Huffman a = ( t as global::haxe.zip.Huffman_NeedBit ).left;
						#line 51 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
						return global::haxe.zip.Huffman.NeedBit(this.treeCompress(a), this.treeCompress(b));
					}
					else {
						#line 52 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
						throw global::haxe.lang.HaxeException.wrap("assert");
					}
					
				}
				
				#line 54 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
				int size = ( 1 << d );
				global::haxe.root.Array table = new global::haxe.root.Array();
				#line 56 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
				{
					#line 56 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
					int _g = 0;
					#line 56 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
					int _g1 = size;
					#line 56 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
					while (( _g < _g1 )) {
						#line 56 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
						int i = _g++;
						table.push(global::haxe.zip.Huffman.Found(-1));
					}
					
				}
				
				#line 58 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
				this.treeWalk(table, 0, 0, d, t);
				return global::haxe.zip.Huffman.NeedBits(d, table);
			}
			#line default
		}
		
		
		public virtual void treeWalk(global::haxe.root.Array table, int p, int cd, int d, global::haxe.zip.Huffman t) {
			unchecked {
				#line 63 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
				if (( t._hx_index == 1 )) {
					#line 64 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
					global::haxe.zip.Huffman b = ( t as global::haxe.zip.Huffman_NeedBit ).right;
					#line 64 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
					global::haxe.zip.Huffman a = ( t as global::haxe.zip.Huffman_NeedBit ).left;
					if (( d > 0 )) {
						#line 66 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
						this.treeWalk(table, p, ( cd + 1 ), ( d - 1 ), a);
						this.treeWalk(table, ( p | ( 1 << cd ) ), ( cd + 1 ), ( d - 1 ), b);
					}
					else {
						#line 69 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
						global::haxe.zip.Huffman __temp_expr2 = ((global::haxe.zip.Huffman) (table.__set(p, this.treeCompress(t))) );
					}
					
				}
				else {
					#line 71 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
					global::haxe.zip.Huffman __temp_expr1 = ((global::haxe.zip.Huffman) (table.__set(p, this.treeCompress(t))) );
				}
				
			}
			#line default
		}
		
		
		public virtual global::haxe.zip.Huffman treeMake(global::haxe.ds.IntMap bits, int maxbits, int v, int len) {
			unchecked {
				#line 76 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
				if (( len > maxbits )) {
					#line 77 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
					throw global::haxe.lang.HaxeException.wrap("Invalid huffman");
				}
				
				#line 78 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
				int idx = ( ( v << 5 ) | len );
				if (bits.exists(((int) (idx) ))) {
					#line 80 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
					return global::haxe.zip.Huffman.Found(((int) (global::haxe.lang.Runtime.toInt(bits.@get(((int) (idx) )))) ));
				}
				
				#line 81 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
				v <<= 1;
				 ++ len;
				#line 83 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
				return global::haxe.zip.Huffman.NeedBit(this.treeMake(bits, maxbits, v, len), this.treeMake(bits, maxbits, ( v | 1 ), len));
			}
			#line default
		}
		
		
		public virtual global::haxe.zip.Huffman make(global::haxe.root.Array lengths, int pos, int nlengths, int maxbits) {
			unchecked {
				#line 87 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
				if (( nlengths == 1 )) {
					#line 88 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
					return global::haxe.zip.Huffman.NeedBit(global::haxe.zip.Huffman.Found(0), global::haxe.zip.Huffman.Found(0));
				}
				
				#line 90 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
				global::haxe.root.Array counts = new global::haxe.root.Array();
				global::haxe.root.Array tmp = new global::haxe.root.Array();
				#line 92 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
				if (( maxbits > 32 )) {
					#line 93 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
					throw global::haxe.lang.HaxeException.wrap("Invalid huffman");
				}
				
				#line 94 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
				{
					#line 94 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
					int _g = 0;
					#line 94 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
					int _g1 = maxbits;
					#line 94 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
					while (( _g < _g1 )) {
						#line 94 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
						int i = _g++;
						counts.push(0);
						#line 96 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
						tmp.push(0);
					}
					
				}
				
				#line 98 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
				{
					#line 98 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
					int _g2 = 0;
					#line 98 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
					int _g3 = nlengths;
					#line 98 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
					while (( _g2 < _g3 )) {
						#line 98 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
						int i1 = _g2++;
						int p = ((int) (global::haxe.lang.Runtime.toInt(lengths.__get(( i1 + pos )))) );
						#line 100 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
						if (( p >= maxbits )) {
							#line 101 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
							throw global::haxe.lang.HaxeException.wrap("Invalid huffman");
						}
						
						#line 102 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
						{
							#line 102 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
							int __temp_arrVal1 = ((int) (global::haxe.lang.Runtime.toInt(counts.__get(p))) );
							#line 102 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
							int __temp_arrRet2 = __temp_arrVal1++;
							#line 102 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
							int __temp_expr1 = ((int) (global::haxe.lang.Runtime.toInt(counts.__set(p, __temp_arrVal1))) );
							#line 102 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
							int __temp_expr2 = __temp_arrRet2;
						}
						
					}
					
				}
				
				#line 104 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
				int code = 0;
				{
					#line 105 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
					int _g4 = 1;
					#line 105 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
					int _g5 = ( maxbits - 1 );
					#line 105 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
					while (( _g4 < _g5 )) {
						#line 105 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
						int i2 = _g4++;
						code = ( ( code + ((int) (global::haxe.lang.Runtime.toInt(counts.__get(i2))) ) ) << 1 );
						#line 107 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
						int __temp_expr3 = ((int) (global::haxe.lang.Runtime.toInt(tmp.__set(i2, code))) );
					}
					
				}
				
				#line 109 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
				global::haxe.ds.IntMap bits = new global::haxe.ds.IntMap();
				{
					#line 110 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
					int _g6 = 0;
					#line 110 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
					int _g7 = nlengths;
					#line 110 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
					while (( _g6 < _g7 )) {
						#line 110 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
						int i3 = _g6++;
						int l = ((int) (global::haxe.lang.Runtime.toInt(lengths.__get(( i3 + pos )))) );
						#line 112 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
						if (( l != 0 )) {
							#line 113 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
							int n = ((int) (global::haxe.lang.Runtime.toInt(tmp.__get(( l - 1 )))) );
							int __temp_expr4 = ((int) (global::haxe.lang.Runtime.toInt(tmp.__set(( l - 1 ), ( n + 1 )))) );
							#line 115 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
							bits.@set(((int) (( ( n << 5 ) | l )) ), ((object) (i3) ));
						}
						
					}
					
				}
				
				#line 118 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
				return this.treeCompress(global::haxe.zip.Huffman.NeedBit(this.treeMake(bits, maxbits, 0, 1), this.treeMake(bits, maxbits, 1, 1)));
			}
			#line default
		}
		
		
		public override object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties) {
			unchecked {
				#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
				switch (hash) {
					case 1213610478:
					{
						#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "make", 1213610478)) );
					}
					
					
					case 740165228:
					{
						#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "treeMake", 740165228)) );
					}
					
					
					case 851061127:
					{
						#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "treeWalk", 851061127)) );
					}
					
					
					case 567946016:
					{
						#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "treeCompress", 567946016)) );
					}
					
					
					case 1110774469:
					{
						#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "treeDepth", 1110774469)) );
					}
					
					
					default:
					{
						#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_invokeField(string field, int hash, object[] dynargs) {
			unchecked {
				#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
				switch (hash) {
					case 1213610478:
					{
						#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
						return this.make(((global::haxe.root.Array) (((object) (dynargs[0]) )) ), ((int) (global::haxe.lang.Runtime.toInt(((object) (dynargs[1]) ))) ), ((int) (global::haxe.lang.Runtime.toInt(((object) (dynargs[2]) ))) ), ((int) (global::haxe.lang.Runtime.toInt(((object) (dynargs[3]) ))) ));
					}
					
					
					case 740165228:
					{
						#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
						return this.treeMake(((global::haxe.ds.IntMap) (((object) (dynargs[0]) )) ), ((int) (global::haxe.lang.Runtime.toInt(((object) (dynargs[1]) ))) ), ((int) (global::haxe.lang.Runtime.toInt(((object) (dynargs[2]) ))) ), ((int) (global::haxe.lang.Runtime.toInt(((object) (dynargs[3]) ))) ));
					}
					
					
					case 851061127:
					{
						#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
						this.treeWalk(((global::haxe.root.Array) (((object) (dynargs[0]) )) ), ((int) (global::haxe.lang.Runtime.toInt(((object) (dynargs[1]) ))) ), ((int) (global::haxe.lang.Runtime.toInt(((object) (dynargs[2]) ))) ), ((int) (global::haxe.lang.Runtime.toInt(((object) (dynargs[3]) ))) ), ((global::haxe.zip.Huffman) (((object) (dynargs[4]) )) ));
						#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
						break;
					}
					
					
					case 567946016:
					{
						#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
						return this.treeCompress(((global::haxe.zip.Huffman) (((object) (dynargs[0]) )) ));
					}
					
					
					case 1110774469:
					{
						#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
						return this.treeDepth(((global::haxe.zip.Huffman) (((object) (dynargs[0]) )) ));
					}
					
					
					default:
					{
						#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
				#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\zip\\Huffman.hx"
				return null;
			}
			#line default
		}
		
		
	}
}


