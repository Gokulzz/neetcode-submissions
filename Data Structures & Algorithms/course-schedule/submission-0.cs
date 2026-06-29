public class Solution {
        Dictionary<int, List<int>> adjList= new Dictionary<int, List<int>>();
        HashSet<int> visited= new HashSet<int>();
        public bool CanFinish(int numCourses, int[][] prerequisites) {
            for(int i=0; i<numCourses; i++) {
                adjList[i] = new List<int>();
            }
            foreach(var element in prerequisites) {
                adjList[element[0]].Add(element[1]);
            }
            for(int i=0; i<numCourses;i++) {
                if(!Dfs(i))
                return false;
            }
            return true;
    

        
    }
    public bool Dfs(int course) {
        if(visited.Contains(course)) 
        return false;
        if(adjList.Count == 0)
        return true;

        visited.Add(course);
        foreach(var element in adjList[course]) {
        if(!Dfs(element)) {
            return false;
        }
        }
        adjList[course].Clear();
        visited.Remove(course);
        return true;

    }
}
