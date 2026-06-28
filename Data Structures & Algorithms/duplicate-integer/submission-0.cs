public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> values= new HashSet<int>();
        foreach(int i in nums) {
            if(values.Contains(i)) {
                return true;
            }
             values.Add(i);
        }
        return false;

    }
}
