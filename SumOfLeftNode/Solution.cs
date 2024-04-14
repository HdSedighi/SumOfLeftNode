public class Solution {
    public int SumOfLeftLeaves(TreeNode root) {
        if (root == null) return 0;
        int sum = 0;
        if (root.left != null && root.left.left == null && root.left.right == null) {
            sum += root.left.val; // if the left child is a leaf, add its value to sum
        }
        sum += SumOfLeftLeaves(root.left); // recursively traverse left subtree
        sum += SumOfLeftLeaves(root.right); // recursively traverse right subtree
        return sum;
    }
}