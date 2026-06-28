public class KthLargest {
    private int k;
    private PriorityQueue<int, int> queue;

    public KthLargest(int k, int[] nums) {
        this.k=k;
        queue= new PriorityQueue<int, int>();
        foreach(int i  in nums) {
            queue.Enqueue(i,i);
            if(queue.Count > k) {
                queue.Dequeue();
            }
        }

        
    }
    
    public int Add(int val) {
        
        queue.Enqueue(val, val);
        if(queue.Count > k) {
            queue.Dequeue();
        }
        return queue.Peek();
    }
}
