using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SiliconStudio.Xenko.Engine;

namespace Strategy
{
    public class Population : AsyncScript
    {
        /// <summary>
        /// Name of the population(e.g. Chinese, Hispanic, German)
        /// </summary>
        public String name;

        /// <summary>
        /// Auto assigned fist time this is loaded
        /// </summary>
        public int pop_id;

        /// <summary>
        /// The percentage of believes of this population(e.g. democratic 90% and nationalism 10%)
        /// first int: believe_id
        /// </summary>
        public Dictionary<int, int> believes;

        /// <summary>
        /// The percentage of religions of this population(e.g. for Germans 60% catholic, 30% evangelic etc.)
        /// </summary>
        public Dictionary<int, int> religions;

        public override async Task Execute()
        {
            if (Game.IsRunning)
            {
                await Script.NextFrame();
            }
        }
    }
}