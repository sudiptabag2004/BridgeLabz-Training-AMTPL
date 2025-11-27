
public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        Dictionary<int,int> db = new Dictionary<int,int>();

        for(int i=0;i<nums.Length;i++){
            int remain = target - nums[i];
            if(db.ContainsKey(remain)){
                return new int[] {db[remain], i};
            }
            else{
                db.Add(nums[i],i);
            }
        }
        return null; 
    }
}