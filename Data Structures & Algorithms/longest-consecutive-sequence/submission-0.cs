public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> numbers= new HashSet<int>(nums);
        int maxSequence=0;
        foreach(int i in nums) {
            if(!numbers.Contains(i-1)) {
                int length=1;
                while(numbers.Contains(i+length)) {
                    length++;
                }
                maxSequence=Math.Max(maxSequence,length);
            }
        }
        return maxSequence;
     
        
    }
}
