using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Treediagram
{
    public class Node
    {
        public readonly object content;
        public List<Node> nextNodes;
        public Node previousNode;
        public Level level;
        private int _percentage;
        private Type type;

        /// <summary>
        /// Consists of all the names prior to this node and this nodes types name
        /// </summary>
        public string name;

        protected void OnChanged(int oldPercentage, EventArgs e)
        {
            percentageChanged?.Invoke(this, oldPercentage);
        }

        public int Percentage
        {
            [DebuggerStepThrough] get { return _percentage; }
            [DebuggerStepThrough] set
            {
                int old = _percentage;
                _percentage = value;
                OnChanged(old, EventArgs.Empty);
            }
        }

        public Node(object content, int percentage, Node previousNode, Level level, Type contentType)
        {
            this.content = content;
            this.Percentage = percentage;
            this.previousNode = previousNode;
            previousNode.nextNodes.Add(this);
            this.level = level;
            level.nodes.Add(this);
            this.type = contentType;
            this.name = previousNode.name + this.type.Name;
            percentageChanged += PercentageChanged;
        }

        private void PercentageChanged(object sender, int old)
        {
            Node prevNode = previousNode;
            while (prevNode != null)
            {
                prevNode = prevNode.previousNode;
                prevNode.nextNodes.First(node => node.type == this.type)._percentage += (_percentage - old);
            }
        }
    }
}
