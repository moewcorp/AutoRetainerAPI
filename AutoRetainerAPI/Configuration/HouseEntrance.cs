using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AutoRetainerAPI.Configuration
{
    [Serializable]
    public class HouseEntrance
    {
        public HouseDescriptor Descriptor;
        public Vector3 Entrance;
        public List<Vector3> Path = [];

        public override string ToString()
        {
            return $"[Entrance={Entrance}, Descriptor={Descriptor}]";
        }
    }
}
