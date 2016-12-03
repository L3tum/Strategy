using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SiliconStudio.Core.Mathematics;
using SiliconStudio.Xenko.Input;
using SiliconStudio.Xenko.Engine;

namespace Strategy
{
    public class Religion : AsyncScript
    {
        // Declared public member fields and properties will show in the game studio

        /// <summary>
        /// auto-assigned fist time this is loaded
        /// </summary>
        public int religion_id;

        /// <summary>
        /// Name of the religion(e.g. Islam, Buddhism, Catholic)
        /// </summary>
        public string name;

        public override async Task Execute()
        {
            while (Game.IsRunning)
            {
                // Do stuff every new frame
                await Script.NextFrame();
            }
        }
    }
}