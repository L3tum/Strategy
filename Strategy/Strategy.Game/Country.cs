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
        /// State_id
        /// </summary>
        public List<int> states;

        /// <summary>
        /// Population in this country
        /// </summary>
        public Population population;

        /// <summary>
        /// Government
        /// </summary>
        public Government government;

        /// <summary>
        /// Reign form of this country(Democracy, Anarchy etc..)
        /// </summary>
        public country_reign_form reign_form;

        /// <summary>
        /// Sphere of influence over other countries as major
        /// </summary>
        public SphereOfInfluence sphere;

        public override async Task Execute()
        {
            if (Game.IsRunning)
            {
                await Script.NextFrame();
            }
        }
    }
}