public class Solution {
  
    public int Jump(int[] nums) {
        int jumpCount = 0; //how many jumps have been made
        int unconfirmedJumps = nums[0]; //the current longest jump that can be made
        int confirmedJumps = nums[0]; // the number of jumps that could have been made with our previous jump

        for(int i = 1; i < nums.Length; i++)
        {
            //every iteration decrement both jump counts;
            confirmedJumps--;
            unconfirmedJumps--;

            //if we find a bigger jump, we know that's the best jump found so far
            if(nums[i] > unconfirmedJumps)
            {
                unconfirmedJumps = nums[i];
            }

            //if the confirmedJumps has reached 0 that means our current jump was the best jump possible
            //so increase the jump count and set the confirmedJumps to be that new unconfirmedJumps amount
            //similarly if this is the final index we also need to increase the jump count
            //because we can't jump any further
            if(confirmedJumps == 0 || i == nums.Length - 1)
            {
                confirmedJumps = unconfirmedJumps;
                jumpCount++;
            } 
        }

        return jumpCount;
    }
}