using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SiliconStudio.Xenko.Engine;

namespace Strategy
{
    public class City : AsyncScript
    {
        /// <summary>
        /// Population percentages in this city
        /// First int=pop_id
        /// second int=percentage
        /// </summary>
        public Dictionary<int, int> populations;

        /// <summary>
        /// Classification of a city(e.g. village, city, capitol)
        /// int=classification_id
        /// </summary>
        public int classification;

        /// <summary>
        /// Auto-assigned fist time this is loaded
        /// </summary>
        public int city_id;

        public override async Task Execute()
        {
            if (Game.IsRunning)
            {
                await Script.NextFrame();
            }
        }
    }
}