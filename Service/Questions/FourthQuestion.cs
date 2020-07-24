using System;
using Domain;

namespace Service.Questions
{
    public class FourthQuestion : IQuestion
    {
        private TreeDomain _tree = null;
        private int _id = 0;
        public FourthQuestion(TreeDomain tree, int id)
        {
            this._tree = tree;
            this._id = id;
        }

        public ResultDomain Execute()
        {
            if (this._tree == null) return new ResultDomain() { ListOfResults = null };

            var result = PathTree(this._tree, this._id);

            return new ResultDomain() { ListResultsInt = result };
        }

        private int[] PathTree(TreeDomain tree, int id)
        {
            if(tree.id == id) return new int[] { id };

            int nodeIdRef = 0;
            int[] intArr = new int[0];
            int count = 0;
            TreeDomain node = new TreeDomain();
            while (nodeIdRef != tree.id)
            {
                Array.Resize(ref intArr, intArr.Length + 1);
                intArr[count] = id;
                count++;
                recursiveCompareNodes(ref node, tree, id);
                id = node.id;
                nodeIdRef = node.id;
            }
            Array.Resize(ref intArr, intArr.Length + 1);
            intArr[count] = tree.id;
            return intArr;
        }

        public static void recursiveCompareNodes(ref TreeDomain node, TreeDomain tree, int id)
        {
            if (tree.nodes != null)
            {
                foreach(var el in tree.nodes)
                {
                    if(el.id == id) { node = tree; }
                    else { recursiveCompareNodes(ref node, el, id); }
                }
            }
        }                                                    
    }
}
