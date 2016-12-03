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
        public string state_name;
        public int state_id;
        public Dictionary<int, int> populations;

        public override async Task Execute()
        {
            if (Game.IsRunning)
            {
                await Script.NextFrame();
            }
        }
    }
}