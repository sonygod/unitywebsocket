// Generated by Haxe 4.1.0-rc.1+0d88c583b

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.ds._Vector {
	public sealed class Vector_Impl_ {
		
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public static T1[] _new<T1>(int length) {
			T1[] this1 = new T1[length];
			return ((T1[]) (this1) );
		}
		
		
		public static T1 @get<T1>(T1[] this1, int index) {
			return ((T1) (this1[index]) );
		}
		
		
		public static T1 @set<T1>(T1[] this1, int index, T1 val) {
			return this1[index] = val;
		}
		
		
		
		
		public static int get_length<T1>(T1[] this1) {
			return ( this1 as global::System.Array ).Length;
		}
		
		
		public static void blit<T>(T[] src, int srcPos, T[] dest, int destPos, int len) {
			global::System.Array.Copy(((global::System.Array) (src) ), ((int) (srcPos) ), ((global::System.Array) (dest) ), ((int) (destPos) ), ((int) (len) ));
		}
		
		
		public static global::haxe.root.Array toArray<T1>(T1[] this1) {
			global::haxe.root.Array a = new global::haxe.root.Array();
			int len = ( ((T1[]) (this1) ) as global::System.Array ).Length;
			{
				int _g = 0;
				int _g1 = len;
				while (( _g < _g1 )) {
					int i = _g++;
					T1 __temp_expr1 = ((T1) (a.__set(i, ((T1) (((T1[]) (this1) )[i]) ))) );
				}
				
			}
			
			return a;
		}
		
		
		public static T1[] toData<T1>(T1[] this1) {
			return ((T1[]) (this1) );
		}
		
		
		public static T[] fromData<T>(T[] data) {
			return ((T[]) (data) );
		}
		
		
		public static T[] fromArrayCopy<T>(global::haxe.root.Array array) {
			T[] ret = new T[array.length];
			{
				int _g = 0;
				int _g1 = array.length;
				while (( _g < _g1 )) {
					int i = _g++;
					ret[i] = ((T) (array.__get(i)) );
				}
				
			}
			
			return ((T[]) (ret) );
		}
		
		
		public static void sort<T, T1>(T[] this1, global::haxe.lang.Function f) {
			throw global::haxe.lang.HaxeException.wrap("not yet supported");
		}
		
		
	}
}


