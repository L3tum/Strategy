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
    public class City_Classification : AsyncScript
    {
        // Declared public member fields and properties will show in the game studio
        /// <summary>
        /// Limit after which a city is considered this class
        /// </summary>
        public int pop_limit;

        /// <summary>
        /// Name of the class(e.g. city, village, megacity)
        /// </summary>
        public string name;

        /// <summary>
        /// Auto-assigned fist time this is loaded
        /// </summary>
        public string class_id;

        public override async Task Execute()
        {
            while(Game.IsRunning)
            {
                // Do stuff every new frame
                await Script.NextFrame();
            }
        }
    }
}
