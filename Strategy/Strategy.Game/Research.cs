using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SiliconStudio.Xenko.Engine;

namespace Strategy
{
    public class Research : Unlockable
    {
        /// <summary>
        /// The effects this research has
        /// </summary>
        public List<Effect> effects;

        public override Task Execute()
        {
            return null;
        }
    }
}