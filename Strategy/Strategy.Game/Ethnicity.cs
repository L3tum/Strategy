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
    public class Ethnicity : AsyncScript
    {
        // Declared public member fields and properties will show in the game studio

        /// <summary>
        /// Name
        /// </summary>
        public String name;

        /// <summary>
        /// Auto-assigned on first load
        /// </summary>
        public int ethnicity_id;

        public Dictionary<int, int> religionPercentages;

        public Dictionary<int, int> believePercentages;

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