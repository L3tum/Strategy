using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using SiliconStudio.Xenko.Engine;

namespace Strategy
{
    public class EventManager : SyncScript
    {
        /// <summary>
        /// string=name of the node
        /// </summary>
        private Dictionary<string, EventHandler<int>> nodeEvents;

        /// <summary>
        /// All events concerning nodes
        /// </summary>
        private EventHandler<int> nodeEvent;

        public override void Update()
        {
        }

        public override void Start()
        {
            base.Start();
            nodeEvents = new Dictionary<string, EventHandler<int>>();
        }

        internal void OnChanged(object sender, int args)
        {
            nodeEvent?.Invoke(sender, args);
        }

        internal void OnChangedNode(string nodeName, object sender, int args)
        {
            nodeEvents[nodeName]?.Invoke(sender, args);
        }

        /// <summary>
        /// Subscribes to one specific node event
        /// </summary>
        /// <param name="nodeName">Name of the node to subcribe to</param>
        /// <param name="CallBack">Your callback method</param>
        /// <example>public void MyCallback(object sender, int arg){}</example>
        public void SubscribeToNode(string nodeName, dynamic CallBack)
        {
            nodeEvents[nodeName] += CallBack;
        }

        /// <summary>
        /// Subscribes to the general node event
        /// </summary>
        /// <param name="CallBack">Your callback method</param>
        /// <example>public void MyCallback(object sender, int arg){}</example>
        public void SubscribeToNodeEvent(dynamic CallBack)
        {
            nodeEvent += CallBack;
        }

        /// <summary>
        /// Unsubscribes from one specific node event
        /// </summary>
        /// <param name="nodeName">Name of the node to unsubcribe from</param>
        /// <param name="CallBack">Your callback method</param>
        /// <example>public void MyCallback(object sender, int arg){}</example>
        public void UnsubscribeFromNode(string nodeName, dynamic CallBack)
        {
            nodeEvents[nodeName] -= CallBack;
        }

        /// <summary>
        /// Unsubscribe from the general node event
        /// </summary>
        /// <param name="callback"></param>
        public void UnsubscribeFromNodeEvent(dynamic callback)
        {
            nodeEvent -= callback;
        }
    }
}
