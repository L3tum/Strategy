using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SiliconStudio.Xenko.Engine;

namespace Strategy
{
    public class State : AsyncScript
    {
        /// <summary>
        /// List of all the provinces in the state
        /// Province_id
        /// </summary>
        public List<int> provinces;

        /// <summary>
        /// Name of this state
        /// </summary>
        public string state_name;

        /// <summary>
        /// Auto assigned on first load
        /// </summary>
        public int state_id;

        /// <summary>
        /// Population in this state
        /// </summary>
        public Population population;

        public override async Task Execute()
        {
            if (Game.IsRunning)
            {
                await Script.NextFrame();
            }
        }
    }
}