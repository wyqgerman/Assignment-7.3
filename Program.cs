namespace Assignment_7._3
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public class Solution
    {
        public TreeNode SearchBST(TreeNode root, int val)
        {
            if (root == null)
            {
                return null;
            }

            if (root.val == val)
            {
                return root;
            }

            if (val < root.val)
            {
                return SearchBST(root.left, val);
            }

            return SearchBST(root.right, val);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(4);
            root.left = new TreeNode(2);
            root.right = new TreeNode(7);
            root.left.left = new TreeNode(1);
            root.left.right = new TreeNode(3);
            root.right.left = new TreeNode(6);
            root.right.right = new TreeNode(8);

            Solution solution = new Solution();
            TreeNode result = solution.SearchBST(root, 3);

            if (result != null)
            {
                Console.WriteLine($"Node found with value {result.val}");
            }
            else
            {
                Console.WriteLine("Node not found");
            }
        }
    }
}
