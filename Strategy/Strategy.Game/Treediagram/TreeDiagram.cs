using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Treediagram
{
    public class TreeDiagram
    {
        public List<Level> levels;

        public TreeDiagram()
        {
            levels = new List<Level>();
        }

        public void AddNodeByLevelName(object content, int percentage, string level, Node prevNode)
        {
            Level lev = levels.First(level1 => level1.name == level);
            Node node = new Node(content, percentage, prevNode, lev);
            lev.nodes.Add(node);
            prevNode.nextNodes.Add(node);
        }

        public void AddNodeByLevelPos(object content, int percentage, int level, Node prevNode)
        {
            Level lev = levels.First(level1 => level1.pos == level);
            Node node = new Node(content, percentage, prevNode, lev);
            lev.nodes.Add(node);
            prevNode.nextNodes.Add(node);
        }
    }
}
