public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var result = new Dictionary<string, List<string>>();

        foreach (var item in strs) {
            var count = new int[26];
            foreach (var c in item)
                count[c - 'a']++;

            var key = string.Join(",", count);

            if (!result.TryGetValue(key, out var group)) {
                group = new List<string>();
                result[key] = group;
            }
            group.Add(item);
        }

        return new List<List<string>>(result.Values);
    }
}