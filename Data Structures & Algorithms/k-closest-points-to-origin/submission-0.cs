public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        PriorityQueue<int[], int> minHeap= new PriorityQueue<int[], int>();
        foreach(int[] p in points) {
            int distance= p[0] * p[0] + p[1] * p[1];
            minHeap.Enqueue(new int[] {distance, p[0], p[1]}, distance);
         }
         int[][] result= new int[k][];
         for(int i=0; i<k; i++) {
            int[] point= minHeap.Dequeue();
            result[i]= new int[] {point[1], point[2]};
         }
         return result;
    }
}
