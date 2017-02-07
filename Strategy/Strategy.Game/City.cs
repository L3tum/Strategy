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
        /// Name of this city
        /// </summary>
        public string name;

        /// <summary>
        /// Population in this city
        /// </summary>
        public Population population;

        /// <summary>
        /// Classification of a city(e.g. village, city, capitol)
        /// </summary>
        public City_Classification classification;

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