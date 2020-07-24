namespace Domain
{
    public class TreeDomain
    {
        public int id { get; set; }
        public TreeDomain[] nodes { get; set; }

        public static TreeDomain GenerateTree()
        {
            
            var node8 = new TreeDomain() { id = 8 };
            var node9 = new TreeDomain() { id = 9 };
            var node6 = new TreeDomain() { id = 6 };
            var node5 = new TreeDomain() { id = 5 };
            var node3 = new TreeDomain() { id = 3 };

            var node10 = new TreeDomain() { id = 10, nodes = new TreeDomain[] { node8 } };
            var node13 = new TreeDomain() { id = 13, nodes = new TreeDomain[] { node9 } };
            var node11 = new TreeDomain() { id = 11, nodes = new TreeDomain[] { node6, node5 } };

            var node12 = new TreeDomain() { id = 12, nodes = new TreeDomain[] { node13 } };

            var node2 = new TreeDomain() { id = 2, nodes = new TreeDomain[] { node12 } };

            var node4 = new TreeDomain() { id = 4, nodes = new TreeDomain[] { node10, node2 } };
            var node7 = new TreeDomain() { id = 7, nodes = new TreeDomain[] { node3, node11 } };

            var tree = new TreeDomain() { id = 1, nodes = new TreeDomain[] { node4, node7 } };

            return tree;
        }
    }
}
