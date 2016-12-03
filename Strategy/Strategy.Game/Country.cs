using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SiliconStudio.Xenko.Engine;

namespace Strategy
{
    public class Country : AsyncScript
    {
        public string country_name;

        /// <summary>
        /// Auto-assigned fist time this is loaded
        /// </summary>
        public int country_id;

        /// <summary>
        /// States in this country
        /// int=state_id
        /// </summary>
        public List<int> states;

        /// <summary>
        /// Provinces in this country
        /// int=province_id
        /// </summary>
        public List<int> provinces;

        /// <summary>
        /// Population percentages in this country
        /// </summary>
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