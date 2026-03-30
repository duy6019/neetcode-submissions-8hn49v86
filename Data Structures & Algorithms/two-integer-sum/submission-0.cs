public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var index = new Dictionary<int, int>();

		for (int i = 0; i < nums.Length; i++){
			var key = nums[i];
			var complement = target - key;
			if(index.ContainsKey(complement)){
				return   [index[complement], i];
			}
			
			if(!index.ContainsKey(key)){
				index.Add(key, i);
			}
		}
	
		
		return [];
    }
}
