# Intuition
We can use a recursive approach to traverse the binary tree. At each node, we check if its left child is a leaf node (i.e., it has no children). If it is, we add its value to the sum. We then recursively traverse the left and right subtrees.

# Approach
We define a recursive function SumOfLeftLeaves that takes a TreeNode as input. If the input node is null, we return 0. Otherwise, we initialize a variable sum to 0. We then check if the left child of the current node exists and if it is a leaf node (i.e., it has no children). If it is, we add its value to the sum. We then recursively call SumOfLeftLeaves on the left and right subtrees and add their results to the sum. Finally, we return the sum.

# Complexity
- Time complexity: O(n), where n is the number of nodes in the binary tree. We visit each node once.

- Space complexity: O(h), where h is the height of the binary tree. The space complexity is determined by the recursive call stack. In the worst case, the binary tree is skewed, and the height is equal to the number of nodes, resulting in linear space complexity.
__________________________________________________________________________________________
# Create a new console project
dotnet new console -n SumOfLeftNode

# Run the project
dotnet run
