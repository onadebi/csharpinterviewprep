namespace LeetCode;

public class TwoSum{
    public static int[] GetSums(int[] nums, int target){
        Dictionary<int,int> data = new();
        int index = 0;

        foreach(var num in nums){
            if(data.ContainsKey(target-num)){
                return new int[]{index, data[target-num]};
            }else{
                data.Add(num, index);
                index++;
            }
        }
        return new int[]{0};
    }
}