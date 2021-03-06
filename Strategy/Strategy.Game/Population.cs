﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SiliconStudio.Xenko.Engine;
using Strategy.Treediagram;

namespace Strategy
{
    public class Population : AsyncScript
    {
        /// <summary>
        /// Auto assigned fist time this is loaded
        /// </summary>
        public int pop_id;

        /// <summary>
        /// Population percentage
        /// </summary>
        public TreeDiagram population;

        public override async Task Execute()
        {
            if (Game.IsRunning)
            {
                await Script.NextFrame();
            }
        }
    }
}