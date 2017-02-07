using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Treediagram
{
    public class Level
    {
        public List<Node> nodes;

        /// <summary>
        /// Type of level. Ethnicity, Religion etc.
        /// </summary>
        public string name;

        /// <summary>
        /// Position in "the order". The nodes in the level can be at any position at any height in the tree, but the level has a set height to be at to uniform the nodes
        /// </summary>
        public int pos;
    }
}
