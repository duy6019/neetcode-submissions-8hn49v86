public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
		int length = nums.Length;
		var lResult = new int[length];
		var rResult = new int[length];
		Array.Fill(lResult, 1);
		Array.Fill(rResult, 1);

		int i = 1;
		int j = length - 2;
		
		while(i <= length - 1){
			lResult[i] = nums[i - 1] * lResult[i - 1] * lResult[i];
			rResult[j] = nums[j + 1] * rResult[j + 1] * rResult[j];
			
			i++;
			j--;
		}

        var result = new int[length];
		
        for (int k = 0; k < length ; k++){
            result[k] = lResult[k] * rResult[k];
        }

		return result;
    }
}
