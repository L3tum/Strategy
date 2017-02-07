using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Building : Unlockable
    {
        /// <summary>
        /// Name of the model
        /// </summary>
        public String model_name;

        /// <summary>
        /// The effects this building has. Local/Global effects are also possible to do
        /// </summary>
        public List<Effect> effects;

        public override Task Execute()
        {
            return null;
        }
    }
}