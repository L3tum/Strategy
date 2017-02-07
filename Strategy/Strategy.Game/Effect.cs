using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SiliconStudio.Xenko.Engine;

namespace Strategy
{
    public class Effect : SyncScript
    {
        public string news_article;

        /// <summary>
        /// Automagically calculated
        /// </summary>
        public float value;

        /// <summary>
        /// List of things you want to unlock with this.
        /// </summary>
        public List<Unlockable> unlockables;

        public override void Update()
        {
        }

        public override void Start()
        {
            base.Start();
        }

        public void Execute(bool news_article_fired)
        {
        }
    }
}