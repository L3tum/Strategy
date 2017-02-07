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
    public class Important_Person : AsyncScript
    {
        // Declared public member fields and properties will show in the game studio

        /// <summary>
        /// Name of the person
        /// </summary>
        public string name;

        /// <summary>
        /// Assigned automatically on fist load
        /// </summary>
        public string gsp_id;

        /// <summary>
        /// Religion of the person
        /// </summary>
        public Religion religion;

        /// <summary>
        /// Believe of the person
        /// </summary>
        public Believe believer;

        /// <summary>
        /// Ethnicity of the person
        /// </summary>
        public Ethnicity ethnicity;

        /// <summary>
        /// Roles of this person(advisor, president etc.)
        /// </summary>
        public List<int> roles;

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