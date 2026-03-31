public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var seen = new Dictionary<int, int>();
		var groupSeen = new Dictionary <int, List<int>>();
		
		foreach(var num in nums){
			if(seen.ContainsKey(num))
                seen[num]++;
			else
			    seen[num] = 1;
		}
		
		var max = 0;
		foreach (var entry in seen)
		{
			if(groupSeen.ContainsKey(entry.Value))
				groupSeen[entry.Value].Add(entry.Key);
			else
			    groupSeen[entry.Value] = new List<int>(){ entry.Key };
			
			if(max < entry.Value)
				max = entry.Value;
		}
		
		var count = 1;
		var result = new int[k];
		
		while(count <= k){
            if(!groupSeen.ContainsKey(max)){
                max--;
                continue;
            }

			foreach(var item in groupSeen[max]){
				result[count - 1] = item;
				count++;

				if(count > k)
					break;
			}
            max--;
		}
		
		return result;
    }
}



