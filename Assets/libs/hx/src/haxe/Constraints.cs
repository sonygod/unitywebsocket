// Generated by Haxe 4.1.0-rc.1+0d88c583b

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe {
	public interface IMap : global::haxe.lang.IHxObject {
		
		object @get(object k);
		
		void @set(object k, object v);
		
		bool exists(object k);
		
		bool @remove(object k);
		
		object keys();
		
		object iterator();
		
		object keyValueIterator();
		
		global::haxe.IMap copy();
		
		string toString();
		
		void clear();
		
	}
}


