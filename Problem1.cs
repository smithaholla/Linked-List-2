public class BSTIterator
	{
        // Time Complexity : HasNext : O(1), Next(): O(1)
        // Space Complexity : HasNext : O(1), Next(): O(1)
        // Did this code successfully run on Leetcode : Yes
        // Any problem you faced while coding this : No

        Stack<TreeNode> st;
        public BSTIterator(TreeNode root)
        {
            st = new Stack<TreeNode>();
            dfs(root);
        }

        private void dfs(TreeNode root)
        {
            while(root != null)
            {
                st.Push(root);
                root = root.left;
            }
        }

        public int Next()
        {
            TreeNode next = st.Pop();
            dfs(next.right);
            return next.val;
        }

        public bool HasNext()
        {
            if (st.Count > 0)
                return true;
            else
                return false;
        }
    }
