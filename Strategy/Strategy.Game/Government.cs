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
    public class Government : AsyncScript
    {
        // Declared public member fields and properties will show in the game studio

        /// <summary>
        /// Staff of the government (e.g. ministers, advisors, leader, president)
        /// </summary>
        public List<Important_Person> staff;

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