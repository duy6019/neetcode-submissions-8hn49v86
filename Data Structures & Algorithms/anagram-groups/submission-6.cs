public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
		var result = new Dictionary<string, List<string>>();        
		for(int i = 0; i < strs.Length; i++){
            var item = strs[i];
            var count = new int[26];
            for (int j = 0; j < item.Length; j++){
                count[item[j] - 'a']++;
            }
            var key = string.Empty;
            for(int j = 0; j < count.Length; j++){
                key += j + 'a' + count[j];
            }

            if(!result.ContainsKey(key)){
                result.Add(key, new List<string> {item});
            } else{
                result[key].Add(item);
            }
		}
		
		return new List<List<string>>(result.Values);
    }
}
