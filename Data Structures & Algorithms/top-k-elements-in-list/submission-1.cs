public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var seen = new Dictionary<int, int>();
		var groupSeen = new Dictionary <int, List<int>>();
		
		for(int i = 0; i < nums.Length; i++){
            var key = nums[i];
			if(!seen.ContainsKey(key)){
				seen.Add(key, 0);
			}
			
			seen[key]++;
		}
		
		var max = 0;
		foreach (KeyValuePair<int, int> entry in seen)
		{
			if(!groupSeen.ContainsKey(entry.Value)){
				groupSeen.Add(entry.Value, new List<int>());
			}
			
			groupSeen[entry.Value].Add(entry.Key);
			
			if(max < entry.Value){
				max = entry.Value;
			}
		}
		
		int count = 1;
		var result = new int[k];
		
		while(count <= k){
            if(!groupSeen.ContainsKey(max)){
                max--;
                continue;
            }

			var values = groupSeen[max];

			for(int i = 0; i < values.Count; i++){
				result[count - 1] = values[i];
				count++;

				if(count > k){
					break;
				}
			}
            max--;
		}
		
		return result;
    }
}



