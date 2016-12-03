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
    public class country_reign_form : AsyncScript
    {
        // Declared public member fields and properties will show in the game studio

        /// <summary>
        /// Name of this form(e.g. Democracy, Patriarchy, Kingdom)
        /// </summary>
        public string name;

        /// <summary>
        /// Auto-assigned fist time this is loaded
        /// </summary>
        public string form_id;

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
