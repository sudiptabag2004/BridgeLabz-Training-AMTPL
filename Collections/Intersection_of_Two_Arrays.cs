public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {

        HashSet<int> hash1 = new HashSet<int>(nums2);
        HashSet<int> hash2 = new HashSet<int>();


        foreach(int i in nums1){
            if(nums2.Contains(i)){
                hash2.Add(i);
            }
        }
        return hash2.ToArray();
    }
}