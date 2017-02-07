using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SiliconStudio.Xenko.Engine;

namespace Strategy
{
    public class Province : AsyncScript
    {
        /// <summary>
        /// Name of this province(e.g. Rheinland, Wessex)
        /// </summary>
        public String name;

        /// <summary>
        /// Auto-assigned fist time this is loaded
        /// </summary>
        public int province_id;

        /// <summary>
        /// Population in this province
        /// </summary>
        public Population population;

        /// <summary>
        /// Cities in this province
        /// city_id
        /// </summary>
        public List<int> cities;

        public override async Task Execute()
        {
            if (Game.IsRunning)
            {
                await Script.NextFrame();
            }
        }
    }
}