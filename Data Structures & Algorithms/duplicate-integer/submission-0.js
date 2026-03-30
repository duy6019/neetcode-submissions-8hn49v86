class Solution {
    /**
     * @param {number[]} nums
     * @return {boolean}
     */
    hasDuplicate(nums) {
        const eleCount = {}
        for (const num of nums){
            if(!eleCount[num]){
                eleCount[num] = 1;
            }else {
                return true;
            }

        }

        return false;
    }
}
