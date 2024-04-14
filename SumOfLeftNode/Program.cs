class Program {
    static void Main(string[] args) {
        // Example usage:
        TreeNode root = new TreeNode(3);
        root.left = new TreeNode(9);
        root.right = new TreeNode(20);
        root.right.left = new TreeNode(15);
        root.right.right = new TreeNode(7);

        Solution solution = new Solution();
        int result = solution.SumOfLeftLeaves(root);
        Console.WriteLine("Sum of left leaves: " + result); // Output: 24
    }
}
