public class Solution {
    public string Encode(IList<string> strs) {
		var result = string.Empty;
        foreach (var str in strs) {
			var indicator = str.Length.ToString() + '#';
			result += indicator;
			result += str;
		}
		
		return result;
    }

    public List<string> Decode(string s) {
		var result = new List<string>();
		var length = string.Empty;
		
		for (int i = 0; i < s.Length; i++){
			if(s[i] != '#'){
				length += s[i];
				continue;
			}
			
			var parsedLength = int.Parse(length);
			result.Add(s.Substring(i + 1, parsedLength));
			i += parsedLength;
			
			length = string.Empty;
		}
		
		return result;
    }
}