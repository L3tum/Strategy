using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SiliconStudio.Xenko.Engine;

namespace Strategy
{
    public class Believe : AsyncScript
    {
        /// <summary>
        /// Name of this believe(e.g. Democracy, Anarchy)
        /// </summary>
        public String name;

        /// <summary>
        /// Auto-assigned fist time this is loaded
        /// </summary>
        public int believe_id;

        public override async Task Execute()
        {
            if (Game.IsRunning)
            {
                await Script.NextFrame();
            }
        }
    }
}