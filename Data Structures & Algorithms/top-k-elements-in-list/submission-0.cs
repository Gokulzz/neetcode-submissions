public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        List<int> result= new List<int>();
        //we will be using bucket sort
        List<int>[] bucket= new List<int>[nums.Length+1];
        //initialize each bucekt
        for(int i=0; i<=nums.Length;i++) {
            bucket[i]= new List<int>();
        }
        Dictionary<int, int> frequency= new Dictionary<int, int>();
        foreach(int i in nums) {
            if(frequency.ContainsKey(i)) {
                frequency[i]++;
            }
            else {
                frequency[i]=1;
            }
        }
        foreach(var element in frequency) {
            bucket[element.Value].Add(element.Key);
        }
        for(int i=bucket.Length-1; i>=0 && result.Count < k;i--) {
            if(bucket[i].Count > 0) {
                result.AddRange(bucket[i]);
            }
        }
        return result.ToArray();
        
        

        
    }
}
