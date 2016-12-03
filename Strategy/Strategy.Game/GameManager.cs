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
    public class GameManager : StartupScript
    {
        // Declared public member fields and properties will show in the game studio
        /// <summary>
        /// Populations in the game
        /// First int: pop_id
        /// </summary>
        public Dictionary<int, Population> populations;

        /// <summary>
        /// Countries in the game
        /// First int: country_id
        /// </summary>
        public Dictionary<int, Country> countries;

        /// <summary>
        /// Believes in the game
        /// First int: believe_id
        /// </summary>
        public Dictionary<int, Believe> believes;
        

        /// <summary>
        /// States in the game
        /// First int: state_id
        /// </summary>
        public Dictionary<int, State> states;

        /// <summary>
        /// Provinces in the game
        /// First int: province_id;
        /// </summary>
        public Dictionary<int, Province> provinces;

        public override void Start()
        {
            // Initialization of the script.
        }
    }
}
