using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SiliconStudio.Xenko.Engine;

namespace Strategy
{
    public class SphereOfInfluence : AsyncScript
    {

        public List<int> friends;
        public List<int> allies;
        public List<int> sphere;

        public Dictionary<int, int> influences;

        public override Task Execute()
        {
            throw new NotImplementedException();
        }
    }
}