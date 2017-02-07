using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SiliconStudio.Xenko.Engine;

namespace Strategy
{
    public class Role : AsyncScript
    {
        /// <summary>
        /// Name of this role
        /// </summary>
        public string name;

        /// <summary>
        /// ID of this role
        /// </summary>
        public int role_id;

        /// <summary>
        /// The rights this role grants a person
        /// </summary>
        public List<Right> rights;

        public override async Task Execute()
        {
            if (Game.IsRunning)
            {
                await Script.NextFrame();
            }
        }
    }
}