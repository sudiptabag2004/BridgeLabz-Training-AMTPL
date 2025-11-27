public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        
        HashSet<int> newhas = new HashSet<int>();

        for(int i=0;i<nums.Length;i++){
            if(newhas.Contains(nums[i])){
                return true;
            }
            else{
                newhas.Add(nums[i]);
            }
        }

        return false;
    }
}