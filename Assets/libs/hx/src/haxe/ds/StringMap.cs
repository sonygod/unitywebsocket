// Generated by Haxe 4.1.0-rc.1+0d88c583b
using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.ds {
	public class StringMap : global::haxe.lang.HxObject, global::haxe.IMap {
		
		public StringMap(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public StringMap() {
			global::haxe.ds.StringMap.__hx_ctor_haxe_ds_StringMap(((global::haxe.ds.StringMap) (this) ));
		}
		
		
		protected static void __hx_ctor_haxe_ds_StringMap(global::haxe.ds.StringMap __hx_this) {
			unchecked {
				__hx_this.cachedIndex = -1;
			}
		}
		
		
		global::haxe.IMap global::haxe.IMap.copy() {
			return ((global::haxe.IMap) (this.copy()) );
		}
		
		
		public int[] hashes;
		
		public string[] _keys;
		
		public object[] vals;
		
		public int nBuckets;
		
		public int size;
		
		public int nOccupied;
		
		public int upperBound;
		
		public string cachedKey;
		
		public int cachedIndex;
		
		public virtual void @set(object k, object v) {
			this.@set(global::haxe.lang.Runtime.toString(k), ((object) (v) ));
		}
		
		
		public virtual void @set(string key, object @value) {
			unchecked {
				int x = default(int);
				int k = default(int);
				if (( this.nOccupied >= this.upperBound )) {
					if (( this.nBuckets > ( this.size << 1 ) )) {
						this.resize(( this.nBuckets - 1 ));
					}
					else {
						this.resize(( this.nBuckets + 2 ));
					}
					
				}
				
				int[] hashes = this.hashes;
				string[] keys = this._keys;
				int[] hashes1 = hashes;
				{
					int mask = ( (( this.nBuckets == 0 )) ? (0) : (( this.nBuckets - 1 )) );
					x = this.nBuckets;
					int site = x;
					int k1 = key.GetHashCode();
					k1 = ( ( k1 + 2127912214 ) + (( k1 << 12 )) );
					k1 = ( ( k1 ^ -949894596 ) ^ ( k1 >> 19 ) );
					k1 = ( ( k1 + 374761393 ) + (( k1 << 5 )) );
					k1 = ( ( k1 + (-744332180) ) ^ ( k1 << 9 ) );
					k1 = ( ( k1 + (-42973499) ) + (( k1 << 3 )) );
					k1 = ( ( k1 ^ -1252372727 ) ^ ( k1 >> 16 ) );
					int ret = k1;
					if (( (( ret & -2 )) == 0 )) {
						if (( ret == 0 )) {
							ret = 2;
						}
						else {
							ret = -1;
						}
						
					}
					
					k = ret;
					int i = ( k & mask );
					int nProbes = 0;
					int delKey = -1;
					if (( ((int) (hashes1[i]) ) == 0 )) {
						x = i;
					}
					else {
						int last = i;
						int flag = default(int);
						while (true) {
							flag = ((int) (hashes1[i]) );
							if ( ! (( ! ((( ( flag == 0 ) || ( ( flag == k ) && ( ((string) (this._keys[i]) ) == key ) ) ))) )) ) {
								break;
							}
							
							if (( ( flag == 1 ) && ( delKey == -1 ) )) {
								delKey = i;
							}
							
							i = ( ( i +  ++ nProbes ) & mask );
						}
						
						if (( ( flag == 0 ) && ( delKey != -1 ) )) {
							x = delKey;
						}
						else {
							x = i;
						}
						
					}
					
				}
				
				int flag1 = ((int) (hashes1[x]) );
				if (( flag1 == 0 )) {
					keys[x] = key;
					this.vals[x] = @value;
					hashes1[x] = k;
					this.size++;
					this.nOccupied++;
				}
				else if (( flag1 == 1 )) {
					keys[x] = key;
					this.vals[x] = @value;
					hashes1[x] = k;
					this.size++;
				}
				else {
					this.vals[x] = @value;
				}
				
				this.cachedIndex = x;
				this.cachedKey = key;
			}
		}
		
		
		public int lookup(string key) {
			unchecked {
				if (( this.nBuckets != 0 )) {
					int[] hashes = this.hashes;
					string[] keys = this._keys;
					int mask = ( this.nBuckets - 1 );
					int k = key.GetHashCode();
					k = ( ( k + 2127912214 ) + (( k << 12 )) );
					k = ( ( k ^ -949894596 ) ^ ( k >> 19 ) );
					k = ( ( k + 374761393 ) + (( k << 5 )) );
					k = ( ( k + (-744332180) ) ^ ( k << 9 ) );
					k = ( ( k + (-42973499) ) + (( k << 3 )) );
					k = ( ( k ^ -1252372727 ) ^ ( k >> 16 ) );
					int ret = k;
					if (( (( ret & -2 )) == 0 )) {
						if (( ret == 0 )) {
							ret = 2;
						}
						else {
							ret = -1;
						}
						
					}
					
					int hash = ret;
					int k1 = hash;
					int nProbes = 0;
					int i = ( k1 & mask );
					int last = i;
					int flag = default(int);
					while (true) {
						flag = ((int) (hashes[i]) );
						if ( ! ((( ( flag != 0 ) && (( ( ( flag == 1 ) || ( flag != k1 ) ) || ( ((string) (keys[i]) ) != key ) )) ))) ) {
							break;
						}
						
						i = ( ( i +  ++ nProbes ) & mask );
					}
					
					if (( (( flag & -2 )) == 0 )) {
						return -1;
					}
					else {
						return i;
					}
					
				}
				
				return -1;
			}
		}
		
		
		public void resize(int newNBuckets) {
			unchecked {
				int[] newHash = null;
				int j = 1;
				{
					int x = newNBuckets;
					 -- x;
					x |= ((int) (( ((uint) (x) ) >> 1 )) );
					x |= ((int) (( ((uint) (x) ) >> 2 )) );
					x |= ((int) (( ((uint) (x) ) >> 4 )) );
					x |= ((int) (( ((uint) (x) ) >> 8 )) );
					x |= ((int) (( ((uint) (x) ) >> 16 )) );
					 ++ x;
					newNBuckets = x;
					if (( newNBuckets < 4 )) {
						newNBuckets = 4;
					}
					
					if (( this.size >= ( ( newNBuckets * 0.77 ) + 0.5 ) )) {
						j = 0;
					}
					else {
						int nfSize = newNBuckets;
						newHash = new int[nfSize];
						if (( this.nBuckets < newNBuckets )) {
							string[] k = new string[newNBuckets];
							if (( this._keys != null )) {
								global::System.Array.Copy(((global::System.Array) (this._keys) ), ((int) (0) ), ((global::System.Array) (k) ), ((int) (0) ), ((int) (this.nBuckets) ));
							}
							
							this._keys = k;
							object[] v = new object[newNBuckets];
							if (( this.vals != null )) {
								global::System.Array.Copy(((global::System.Array) (this.vals) ), ((int) (0) ), ((global::System.Array) (v) ), ((int) (0) ), ((int) (this.nBuckets) ));
							}
							
							this.vals = v;
						}
						
					}
					
				}
				
				if (( j != 0 )) {
					this.cachedKey = null;
					this.cachedIndex = -1;
					j = -1;
					int nBuckets = this.nBuckets;
					string[] _keys = this._keys;
					object[] vals = this.vals;
					int[] hashes = this.hashes;
					int newMask = ( newNBuckets - 1 );
					while ((  ++ j < nBuckets )) {
						int k1 = ((int) (hashes[j]) );
						if (( (( k1 & -2 )) != 0 )) {
							string key = ((string) (_keys[j]) );
							object val = ((object) (vals[j]) );
							_keys[j] = null;
							vals[j] = null;
							hashes[j] = 1;
							while (true) {
								int nProbes = 0;
								int i = ( k1 & newMask );
								while (( ((int) (newHash[i]) ) != 0 )) {
									i = ( ( i +  ++ nProbes ) & newMask );
								}
								
								newHash[i] = k1;
								bool tmp = default(bool);
								if (( i < nBuckets )) {
									k1 = ((int) (hashes[i]) );
									tmp = ( (( k1 & -2 )) != 0 );
								}
								else {
									tmp = false;
								}
								
								if (tmp) {
									{
										string tmp1 = ((string) (_keys[i]) );
										_keys[i] = key;
										key = tmp1;
									}
									
									{
										object tmp2 = ((object) (vals[i]) );
										vals[i] = val;
										val = tmp2;
									}
									
									hashes[i] = 1;
								}
								else {
									_keys[i] = key;
									vals[i] = val;
									break;
								}
								
							}
							
						}
						
					}
					
					if (( nBuckets > newNBuckets )) {
						{
							string[] k2 = new string[newNBuckets];
							global::System.Array.Copy(((global::System.Array) (_keys) ), ((int) (0) ), ((global::System.Array) (k2) ), ((int) (0) ), ((int) (newNBuckets) ));
							this._keys = k2;
						}
						
						{
							object[] v1 = new object[newNBuckets];
							global::System.Array.Copy(((global::System.Array) (vals) ), ((int) (0) ), ((global::System.Array) (v1) ), ((int) (0) ), ((int) (newNBuckets) ));
							this.vals = v1;
						}
						
					}
					
					this.hashes = newHash;
					this.nBuckets = newNBuckets;
					this.nOccupied = this.size;
					this.upperBound = ((int) (( ( newNBuckets * 0.77 ) + .5 )) );
				}
				
			}
		}
		
		
		public virtual object @get(object k) {
			return ((object) (this.@get(global::haxe.lang.Runtime.toString(k))) );
		}
		
		
		public virtual object @get(string key) {
			unchecked {
				int idx = -1;
				bool tmp = default(bool);
				if (( this.cachedKey == key )) {
					idx = this.cachedIndex;
					tmp = ( idx != -1 );
				}
				else {
					tmp = false;
				}
				
				if (tmp) {
					return ((object) (this.vals[idx]) );
				}
				
				idx = this.lookup(key);
				if (( idx != -1 )) {
					this.cachedKey = key;
					this.cachedIndex = idx;
					return ((object) (this.vals[idx]) );
				}
				
				return null;
			}
		}
		
		
		public virtual object getDefault(string key, object def) {
			unchecked {
				int idx = -1;
				bool tmp = default(bool);
				if (( this.cachedKey == key )) {
					idx = this.cachedIndex;
					tmp = ( idx != -1 );
				}
				else {
					tmp = false;
				}
				
				if (tmp) {
					return ((object) (this.vals[idx]) );
				}
				
				idx = this.lookup(key);
				if (( idx != -1 )) {
					this.cachedKey = key;
					this.cachedIndex = idx;
					return ((object) (this.vals[idx]) );
				}
				
				return def;
			}
		}
		
		
		public virtual bool exists(object k) {
			return ((bool) (this.exists(global::haxe.lang.Runtime.toString(k))) );
		}
		
		
		public virtual bool exists(string key) {
			unchecked {
				int idx = -1;
				bool tmp = default(bool);
				if (( this.cachedKey == key )) {
					idx = this.cachedIndex;
					tmp = ( idx != -1 );
				}
				else {
					tmp = false;
				}
				
				if (tmp) {
					return true;
				}
				
				idx = this.lookup(key);
				if (( idx != -1 )) {
					this.cachedKey = key;
					this.cachedIndex = idx;
					return true;
				}
				
				return false;
			}
		}
		
		
		public virtual bool @remove(object k) {
			return ((bool) (this.@remove(global::haxe.lang.Runtime.toString(k))) );
		}
		
		
		public virtual bool @remove(string key) {
			unchecked {
				int idx = -1;
				bool tmp = default(bool);
				if (( this.cachedKey == key )) {
					idx = this.cachedIndex;
					tmp = ( idx != -1 );
				}
				else {
					tmp = false;
				}
				
				if ( ! (tmp) ) {
					idx = this.lookup(key);
				}
				
				if (( idx == -1 )) {
					return false;
				}
				else {
					if (( this.cachedKey == key )) {
						this.cachedIndex = -1;
					}
					
					this.hashes[idx] = 1;
					this._keys[idx] = null;
					this.vals[idx] = null;
					 -- this.size;
					return true;
				}
				
			}
		}
		
		
		public object keys() {
			return new global::haxe.ds._StringMap.StringMapKeyIterator(((global::haxe.ds.StringMap) (this) ));
		}
		
		
		public object iterator() {
			return new global::haxe.ds._StringMap.StringMapValueIterator(((global::haxe.ds.StringMap) (this) ));
		}
		
		
		public object keyValueIterator() {
			return new global::haxe.iterators.MapKeyValueIterator(((global::haxe.IMap) (this) ));
		}
		
		
		public virtual global::haxe.ds.StringMap copy() {
			global::haxe.ds.StringMap copied = new global::haxe.ds.StringMap();
			{
				object key = ((object) (new global::haxe.ds._StringMap.StringMapKeyIterator(((global::haxe.ds.StringMap) (this) ))) );
				while (global::haxe.lang.Runtime.toBool(global::haxe.lang.Runtime.callField(key, "hasNext", 407283053, null))) {
					string key1 = global::haxe.lang.Runtime.toString(global::haxe.lang.Runtime.callField(key, "next", 1224901875, null));
					copied.@set(((string) (key1) ), ((object) (this.@get(((string) (key1) ))) ));
				}
				
			}
			
			return copied;
		}
		
		
		public virtual string toString() {
			global::System.Text.StringBuilder s_b = new global::System.Text.StringBuilder();
			s_b.Append(((string) ("{") ));
			object it = ((object) (new global::haxe.ds._StringMap.StringMapKeyIterator(((global::haxe.ds.StringMap) (this) ))) );
			{
				object i = it;
				while (global::haxe.lang.Runtime.toBool(global::haxe.lang.Runtime.callField(i, "hasNext", 407283053, null))) {
					string i1 = global::haxe.lang.Runtime.toString(global::haxe.lang.Runtime.callField(i, "next", 1224901875, null));
					s_b.Append(((string) (global::haxe.root.Std.@string(i1)) ));
					s_b.Append(((string) (" => ") ));
					s_b.Append(((string) (global::haxe.root.Std.@string(global::haxe.root.Std.@string(this.@get(((string) (i1) ))))) ));
					if (global::haxe.lang.Runtime.toBool(global::haxe.lang.Runtime.callField(it, "hasNext", 407283053, null))) {
						s_b.Append(((string) (", ") ));
					}
					
				}
				
			}
			
			s_b.Append(((string) ("}") ));
			return s_b.ToString();
		}
		
		
		public virtual void clear() {
			unchecked {
				this.hashes = null;
				this._keys = null;
				this.vals = null;
				this.nBuckets = 0;
				this.size = 0;
				this.nOccupied = 0;
				this.upperBound = 0;
				this.cachedKey = null;
				this.cachedIndex = -1;
			}
		}
		
		
		public override double __hx_setField_f(string field, int hash, double @value, bool handleProperties) {
			unchecked {
				switch (hash) {
					case 922671056:
					{
						this.cachedIndex = ((int) (@value) );
						return @value;
					}
					
					
					case 2022294396:
					{
						this.upperBound = ((int) (@value) );
						return @value;
					}
					
					
					case 480756972:
					{
						this.nOccupied = ((int) (@value) );
						return @value;
					}
					
					
					case 1280549057:
					{
						this.size = ((int) (@value) );
						return @value;
					}
					
					
					case 1537812987:
					{
						this.nBuckets = ((int) (@value) );
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
					case 922671056:
					{
						this.cachedIndex = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 1395555037:
					{
						this.cachedKey = global::haxe.lang.Runtime.toString(@value);
						return @value;
					}
					
					
					case 2022294396:
					{
						this.upperBound = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 480756972:
					{
						this.nOccupied = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 1280549057:
					{
						this.size = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 1537812987:
					{
						this.nBuckets = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 1313416818:
					{
						this.vals = ((object[]) (@value) );
						return @value;
					}
					
					
					case 2048392659:
					{
						this._keys = ((string[]) (@value) );
						return @value;
					}
					
					
					case 995006396:
					{
						this.hashes = ((int[]) (@value) );
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
					case 1213952397:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "clear", 1213952397)) );
					}
					
					
					case 946786476:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "toString", 946786476)) );
					}
					
					
					case 1103412149:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "copy", 1103412149)) );
					}
					
					
					case 1257164128:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "keyValueIterator", 1257164128)) );
					}
					
					
					case 328878574:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "iterator", 328878574)) );
					}
					
					
					case 1191633396:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "keys", 1191633396)) );
					}
					
					
					case 76061764:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "remove", 76061764)) );
					}
					
					
					case 1071652316:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "exists", 1071652316)) );
					}
					
					
					case 1797611211:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "getDefault", 1797611211)) );
					}
					
					
					case 5144726:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "get", 5144726)) );
					}
					
					
					case 142301684:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "resize", 142301684)) );
					}
					
					
					case 1639293562:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "lookup", 1639293562)) );
					}
					
					
					case 5741474:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "set", 5741474)) );
					}
					
					
					case 922671056:
					{
						return this.cachedIndex;
					}
					
					
					case 1395555037:
					{
						return this.cachedKey;
					}
					
					
					case 2022294396:
					{
						return this.upperBound;
					}
					
					
					case 480756972:
					{
						return this.nOccupied;
					}
					
					
					case 1280549057:
					{
						return this.size;
					}
					
					
					case 1537812987:
					{
						return this.nBuckets;
					}
					
					
					case 1313416818:
					{
						return this.vals;
					}
					
					
					case 2048392659:
					{
						return this._keys;
					}
					
					
					case 995006396:
					{
						return this.hashes;
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
					case 922671056:
					{
						return ((double) (this.cachedIndex) );
					}
					
					
					case 2022294396:
					{
						return ((double) (this.upperBound) );
					}
					
					
					case 480756972:
					{
						return ((double) (this.nOccupied) );
					}
					
					
					case 1280549057:
					{
						return ((double) (this.size) );
					}
					
					
					case 1537812987:
					{
						return ((double) (this.nBuckets) );
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
					case 1213952397:
					{
						this.clear();
						break;
					}
					
					
					case 946786476:
					{
						return this.toString();
					}
					
					
					case 1103412149:
					{
						return this.copy();
					}
					
					
					case 1257164128:
					{
						return this.keyValueIterator();
					}
					
					
					case 328878574:
					{
						return this.iterator();
					}
					
					
					case 1191633396:
					{
						return this.keys();
					}
					
					
					case 76061764:
					{
						return this.@remove(global::haxe.lang.Runtime.toString(((object) (dynargs[0]) )));
					}
					
					
					case 1071652316:
					{
						return this.exists(global::haxe.lang.Runtime.toString(((object) (dynargs[0]) )));
					}
					
					
					case 1797611211:
					{
						return this.getDefault(global::haxe.lang.Runtime.toString(((object) (dynargs[0]) )), ((object) (dynargs[1]) ));
					}
					
					
					case 5144726:
					{
						return this.@get(global::haxe.lang.Runtime.toString(((object) (dynargs[0]) )));
					}
					
					
					case 142301684:
					{
						this.resize(((int) (global::haxe.lang.Runtime.toInt(((object) (dynargs[0]) ))) ));
						break;
					}
					
					
					case 1639293562:
					{
						return this.lookup(global::haxe.lang.Runtime.toString(((object) (dynargs[0]) )));
					}
					
					
					case 5741474:
					{
						this.@set(global::haxe.lang.Runtime.toString(((object) (dynargs[0]) )), ((object) (dynargs[1]) ));
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
			baseArr.push("cachedIndex");
			baseArr.push("cachedKey");
			baseArr.push("upperBound");
			baseArr.push("nOccupied");
			baseArr.push("size");
			baseArr.push("nBuckets");
			baseArr.push("vals");
			baseArr.push("_keys");
			baseArr.push("hashes");
			base.__hx_getFields(baseArr);
		}
		
		
		public override string ToString(){
			return this.toString();
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.ds._StringMap {
	public sealed class StringMapKeyIterator : global::haxe.lang.HxObject {
		
		public StringMapKeyIterator(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public StringMapKeyIterator(global::haxe.ds.StringMap m) {
			global::haxe.ds._StringMap.StringMapKeyIterator.__hx_ctor_haxe_ds__StringMap_StringMapKeyIterator(((global::haxe.ds._StringMap.StringMapKeyIterator) (this) ), ((global::haxe.ds.StringMap) (m) ));
		}
		
		
		private static void __hx_ctor_haxe_ds__StringMap_StringMapKeyIterator(global::haxe.ds._StringMap.StringMapKeyIterator __hx_this, global::haxe.ds.StringMap m) {
			__hx_this.m = m;
			__hx_this.i = 0;
			__hx_this.len = m.nBuckets;
		}
		
		
		public global::haxe.ds.StringMap m;
		
		public int i;
		
		public int len;
		
		public bool hasNext() {
			unchecked {
				{
					int _g = this.i;
					int _g1 = this.len;
					while (( _g < _g1 )) {
						int j = _g++;
						if (( (( ((int) (this.m.hashes[j]) ) & -2 )) != 0 )) {
							this.i = j;
							return true;
						}
						
					}
					
				}
				
				return false;
			}
		}
		
		
		public string next() {
			string ret = ((string) (this.m._keys[this.i]) );
			this.m.cachedIndex = this.i;
			this.m.cachedKey = ret;
			this.i++;
			return ret;
		}
		
		
		public override double __hx_setField_f(string field, int hash, double @value, bool handleProperties) {
			unchecked {
				switch (hash) {
					case 5393365:
					{
						this.len = ((int) (@value) );
						return @value;
					}
					
					
					case 105:
					{
						this.i = ((int) (@value) );
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
					case 5393365:
					{
						this.len = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 105:
					{
						this.i = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 109:
					{
						this.m = ((global::haxe.ds.StringMap) (@value) );
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
					case 1224901875:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "next", 1224901875)) );
					}
					
					
					case 407283053:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "hasNext", 407283053)) );
					}
					
					
					case 5393365:
					{
						return this.len;
					}
					
					
					case 105:
					{
						return this.i;
					}
					
					
					case 109:
					{
						return this.m;
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
					case 5393365:
					{
						return ((double) (this.len) );
					}
					
					
					case 105:
					{
						return ((double) (this.i) );
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
					case 1224901875:
					{
						return this.next();
					}
					
					
					case 407283053:
					{
						return this.hasNext();
					}
					
					
					default:
					{
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
			}
		}
		
		
		public override void __hx_getFields(global::haxe.root.Array baseArr) {
			baseArr.push("len");
			baseArr.push("i");
			baseArr.push("m");
			base.__hx_getFields(baseArr);
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.ds._StringMap {
	public sealed class StringMapValueIterator : global::haxe.lang.HxObject {
		
		public StringMapValueIterator(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public StringMapValueIterator(global::haxe.ds.StringMap m) {
			global::haxe.ds._StringMap.StringMapValueIterator.__hx_ctor_haxe_ds__StringMap_StringMapValueIterator(((global::haxe.ds._StringMap.StringMapValueIterator) (this) ), ((global::haxe.ds.StringMap) (m) ));
		}
		
		
		private static void __hx_ctor_haxe_ds__StringMap_StringMapValueIterator(global::haxe.ds._StringMap.StringMapValueIterator __hx_this, global::haxe.ds.StringMap m) {
			__hx_this.m = m;
			__hx_this.i = 0;
			__hx_this.len = m.nBuckets;
		}
		
		
		public global::haxe.ds.StringMap m;
		
		public int i;
		
		public int len;
		
		public bool hasNext() {
			unchecked {
				{
					int _g = this.i;
					int _g1 = this.len;
					while (( _g < _g1 )) {
						int j = _g++;
						if (( (( ((int) (this.m.hashes[j]) ) & -2 )) != 0 )) {
							this.i = j;
							return true;
						}
						
					}
					
				}
				
				return false;
			}
		}
		
		
		public object next() {
			return ((object) (this.m.vals[this.i++]) );
		}
		
		
		public override double __hx_setField_f(string field, int hash, double @value, bool handleProperties) {
			unchecked {
				switch (hash) {
					case 5393365:
					{
						this.len = ((int) (@value) );
						return @value;
					}
					
					
					case 105:
					{
						this.i = ((int) (@value) );
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
					case 5393365:
					{
						this.len = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 105:
					{
						this.i = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 109:
					{
						this.m = ((global::haxe.ds.StringMap) (@value) );
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
					case 1224901875:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "next", 1224901875)) );
					}
					
					
					case 407283053:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "hasNext", 407283053)) );
					}
					
					
					case 5393365:
					{
						return this.len;
					}
					
					
					case 105:
					{
						return this.i;
					}
					
					
					case 109:
					{
						return this.m;
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
					case 5393365:
					{
						return ((double) (this.len) );
					}
					
					
					case 105:
					{
						return ((double) (this.i) );
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
					case 1224901875:
					{
						return this.next();
					}
					
					
					case 407283053:
					{
						return this.hasNext();
					}
					
					
					default:
					{
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
			}
		}
		
		
		public override void __hx_getFields(global::haxe.root.Array baseArr) {
			baseArr.push("len");
			baseArr.push("i");
			baseArr.push("m");
			base.__hx_getFields(baseArr);
		}
		
		
	}
}


