public class Solution {
    public bool IsAnagram(string s, string t) {
		if(s.Length != t.Length){
			return false;
		}
			
        var seen = new Dictionary<char, int>();

		for (int i = 0; i < s.Length; i++){
			var key = s[i];
			if(!seen.ContainsKey(key)){
				seen.Add(key, 1);
				continue;
			}
			seen[key] += 1;
 		}
		
		for (int i = 0; i < t.Length; i++ ){
			var key = t[i];
			if(!seen.ContainsKey(key)){
				return false;
			}
			
			if(seen[key] == 1){
				seen.Remove(key);
				continue;
			}
			
			seen[key] -= 1;
		}

		if(seen.Count != 0){
			return false;
		}
        return true;
    }
}