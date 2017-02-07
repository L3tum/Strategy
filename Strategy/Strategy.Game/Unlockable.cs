using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SiliconStudio.Xenko.Engine;

namespace Strategy
{
    public abstract class Unlockable : AsyncScript
    {
        public float value = 1.0f;
        public string news_article = "base.standard.0.0.1";

        /// <summary>
        /// Name of the 'screenshot' that is shown in the respective menu
        /// </summary>
        public String screenshot;
    }
}